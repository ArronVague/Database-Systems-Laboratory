《图书馆管理系统》

Entity

读者

- 读者编号（主键）

- 类别编号（外键）

- 密码

读者类别（单独创建表？）

- 类别编号（主键）

- 单次借阅上限

- 借阅时长

管理员

- 管理员编号（主键）
- 密码

图书（一本书有好几本）

- 图书编号（主键）

- ISBN

- 图书名称

- 图书类别

- 图书简介

- 借阅状态（未借/借出/丢失）

图书借阅记录

- 图书借阅记录编号（主键）

- 读者编号（外键）

- 图书编号（外键）

- 借阅时间

- 预计归还时间

- 实际归还时间

- 违规信息（无/超期/丢失）

- 借阅业务管理员编号（外键）

- 归还业务管理员编号（外键）

个人违规记录

- 个人违规记录编号（主键）

- 读者编号（外键）

- 图书借阅记录编号（外键）

- 违规信息（超期/丢失）

- 金额

- 管理员编号（外键）

罚款规则（复杂化）（简单化可固定）

- 金额

- 计算公式