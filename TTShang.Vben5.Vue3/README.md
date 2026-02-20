## **简介**

[![license](https://img.shields.io/github/license/anncwb/vue-vben-admin.svg)](LICENSE)

基于 [ruoyi-plus-vben & vben5 & ant-design-vue  ](https://gitee.com/dapppp/ruoyi-plus-vben.git) 的 Yi 框架前端项目

完全兼容意框架[TTShang.Admin](https://gitee.com/ccnetcore/Yi) rbac模块

| 组件/框架      | 版本   |
| :------------- | :----- |
| vben           | 5.5.6  |
| ant-design-vue | 4.2.6  |
| vue            | 3.5.13 |



## 提示

该仓库使用vben5开发，采用分包目录结构, 实际开发路径为: `根目录/apps/web-antd`

前端已同时兼容 **Furion 规范化 API 响应** 和 **ABP 风格响应**，可通过 `apps/web-antd/.env` 中的 `VITE_GLOB_API_STYLE` 配置响应风格：`auto`(默认)、`furion`、`abp`。

如果使用 Furion 规范化响应，可在 `TTShang.Abp.Net8/src/TTShang.Abp.Web/YiAbpWebModule.cs` 中开启相关配置。

**Furion风格示例**

````json
{
    "statusCode": 200,
    "data": {"name": "du白","age": 20},
    "succeeded": true,
    "errors": null,
    "extras": null,
    "timestamp": 1770825190
}
````
**ABP风格示例**

````json
// 成功响应
{ "name": "du白","age": 20}
````
````json
// 异常响应
{
  "error": {
    "code": "string",
    "message": "string",
    "details": "string",
    "data": {
      "additionalProp1": "string",
      "additionalProp2": "string",
      "additionalProp3": "string"
    },
    "validationErrors": [
      {
        "message": "string",
        "members": [
          "string"
        ]
      }
    ]
  }
}
````



## 文档

[ruoyi-vben 框架文档](https://dapdap.top/)

[VbenAdmin V5 文档地址](https://doc.vben.pro/)


## 安装使用

前置准备环境(只能用pnpm)

```json
"packageManager": "pnpm",
"engines": {
  "node": ">=20.15.0",
  "pnpm": "latest"
},
```

安装依赖

```bash
cd TTShang.Vben5.Vue3

pnpm install
```

运行

```bash
pnpm dev:antd
```

打包

```bash
pnpm build:antd
```

## 这是一个特性 而不是一个bug!

1. 菜单管理可分配 但只有`admin`/`superadmin`角色能访问 其他角色访问会到403页面
2. 租户相关菜单可分配 但只有`superadmin`角色能访问 其他角色访问会到403页面
3. 分配的租户管理员无法修改自己的角色的菜单(即管理员角色的菜单) 防止自己把自己权限弄没了

## Git 贡献提交规范

参考 [vue](https://github.com/vuejs/vue/blob/dev/.github/COMMIT_CONVENTION.md) 规范 ([Angular](https://github.com/conventional-changelog/conventional-changelog/tree/master/packages/conventional-changelog-angular))

- `feat` 增加新功能
- `fix` 修复问题/BUG
- `style` 代码风格相关无影响运行结果的
- `perf` 优化/性能提升
- `refactor` 重构
- `revert` 撤销修改
- `test` 测试相关
- `docs` 文档/注释
- `chore` 依赖更新/脚手架配置修改等
- `workflow` 工作流改进
- `ci` 持续集成
- `types` 类型定义文件更改
- `wip` 开发中

## 浏览器支持

最低适配应该为`Chrome 88+`以上浏览器 详见 [css - where](https://developer.mozilla.org/en-US/docs/Web/CSS/:where#browser_compatibility)

本地开发推荐使用`Chrome` 最新版本浏览器

支持现代浏览器，不支持 IE

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt=" Edge" width="24px" height="24px" />](http://godban.github.io/browsers-support-badges/)</br>IE | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt=" Edge" width="24px" height="24px" />](http://godban.github.io/browsers-support-badges/)</br>Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](http://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](http://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](http://godban.github.io/browsers-support-badges/)</br>Safari |
| :-: | :-: | :-: | :-: | :-: |
| not support | last 2 versions | last 2 versions | last 2 versions | last 2 versions |
