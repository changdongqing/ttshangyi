export function optionsToEnum<T extends string | number>(
  options: Array<{ label: string; value: T }>,
): Record<string, T> {
  return options.reduce(
    (acc, option) => {
      const key = String(option.value).toUpperCase().replaceAll('-', '_');
      acc[key] = option.value;
      return acc;
    },
    {} as Record<string, T>,
  );
}
