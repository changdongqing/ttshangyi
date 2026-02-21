interface TreeHelperConfig {
  id?: string;
  pid?: string;
  children?: string;
}

const DEFAULT_CONFIG: TreeHelperConfig = {
  id: 'id',
  pid: 'parentId',
  children: 'children',
};

export function listToTree<T extends Record<string, any>>(
  list: T[],
  config: TreeHelperConfig = {},
): T[] {
  const conf = { ...DEFAULT_CONFIG, ...config };
  const idKey = conf.id!;
  const pidKey = conf.pid!;
  const childrenKey = conf.children!;

  const nodeMap = new Map<any, T & { [key: string]: any }>();
  const result: T[] = [];

  for (const item of list) {
    nodeMap.set(item[idKey], { ...item, [childrenKey]: [] });
  }

  for (const item of list) {
    const node = nodeMap.get(item[idKey])!;
    const parent = nodeMap.get(item[pidKey]);
    if (parent) {
      parent[childrenKey].push(node);
    } else {
      result.push(node);
    }
  }

  return result;
}

export function treeToList<T extends Record<string, any>>(
  tree: T[],
  config: Pick<TreeHelperConfig, 'children'> = {},
): T[] {
  const childrenKey = config.children || 'children';
  const result: T[] = [];
  const stack = [...tree];

  while (stack.length > 0) {
    const node = stack.shift()!;
    result.push(node);
    const children = (node as any)[childrenKey];
    if (children && children.length > 0) {
      stack.unshift(...children);
    }
  }

  return result;
}

export function eachTree<T extends Record<string, any>>(
  tree: T[],
  callback: (item: T, index: number, parent?: T) => void,
  config: Pick<TreeHelperConfig, 'children'> = {},
): void {
  const childrenKey = config.children || 'children';

  const traverse = (nodes: T[], parent?: T) => {
    nodes.forEach((item, index) => {
      callback(item, index, parent);
      const children = (item as any)[childrenKey];
      if (children && children.length > 0) {
        traverse(children, item);
      }
    });
  };

  traverse(tree);
}

export function addFullName<T extends Record<string, any>>(
  tree: T[],
  field: string,
  separator = ' / ',
  config: Pick<TreeHelperConfig, 'children'> = {},
  parentName = '',
): void {
  const childrenKey = config.children || 'children';

  for (const item of tree) {
    const currentName = parentName
      ? `${parentName}${separator}${item[field]}`
      : item[field];
    item['fullName'] = currentName;
    const children = (item as any)[childrenKey];
    if (children && children.length > 0) {
      addFullName(children, field, separator, config, currentName);
    }
  }
}

export function findGroupParentIds<T extends Record<string, any>>(
  tree: T[],
  ids: (number | string)[],
  config: Pick<TreeHelperConfig, 'id' | 'children'> = {},
): number[] {
  const idKey = config.id || 'id';
  const childrenKey = config.children || 'children';
  const idsSet = new Set(ids.map(String));
  const parentIds = new Set<number>();

  const traverse = (nodes: T[], parentIdList: number[]) => {
    for (const node of nodes) {
      const currentId = node[idKey];
      const currentParents = [...parentIdList, Number(currentId)];

      if (idsSet.has(String(currentId))) {
        parentIdList.forEach((id) => parentIds.add(id));
      }

      const children = (node as any)[childrenKey];
      if (children && children.length > 0) {
        traverse(children, currentParents);
      }
    }
  };

  traverse(tree, []);
  return [...parentIds];
}
