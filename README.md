企业无纸化注册登记
=====
### 概述
1. 迁移至DotNetCore2.0.3
2. `ODP.NET EntityFrameworkCore需2018年第三季度才出，暂时无法以EF架构迁移DbApi`
3. `ODP.Net Core在2018年3月6号推出，考虑将原本ODP.NET EF6.x以ADO.NET方式重构DbApi`
4. [GzApi接口定义](src/EnterpriseRegistration.GzApi/STANDARD.md)
5. [FsApi接口定义](src/EnterpriseRegistration.FsApi/STANDARD.md)
### 更新日志
[TODO.md](TODO.md)
### 解决方案
* 主程序
  * 广州商事平台数据库接口 src/EnterpriseRegistration.DbApi(待迁移)
  * 广州工商数据接口 src/EnterpriseRegistration.GzApi
  * 佛山工商数据接口 src/EnterpriseRegistration.FsApi
* 依赖项目
  * 数据连接 dependent/EportDataPlatform.DataAccess
  * 数据实体 dependent/EportDataPlatform.Entity
---
## 安装调试
1. 安装 DotNetCore2.0.3 [https://dotnet.github.io/](https://dotnet.github.io/)
2. 下载源码 git clone https://github.com/watson1029/EnterpriseRegistration.git
3. 恢复依赖包 dotnet restore 
4. 运行 dotnet run
---
## 部署
### DotNet Core Runtime 2.0.3
### Oracle11g
### DbApi部署在海关管理网
### GzApi部署在广州政务外网
### FsApi部署在海关对外接入局域网通过VPN访问佛山工商接口
---
