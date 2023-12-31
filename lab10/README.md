# 《图书馆管理系统》

## 实体

声明：所有外键在E-R图都不用画

### 读者信息

- 读者编号（主键）
- 读者类别编号（外键）
- 姓名
- 性别
- 联系电话
- 登记日期
- 有效期至
- 现借图书数
- 累计借书数
- 违规次数
- 状态
- 备注

### 读者类别

- 读者类别编号（主键）
- 读者类别名称
- 可借册数
- 可借天数

### 图书基本信息（每本书的信息）

- ISBN（主键）
- 书名
- 作者
- 出版社编号（外键）
- 版次
- 出版日期
- 价格
- 简介
- 库存总量
- 现在库数量

### 出版社信息

- 出版社编号（主键）
- 出版社名称
- 联系人
- 联系电话
- 传真
- 地址

### 图书馆藏信息

- 图书馆藏编号（主键）
- 状态
- 入库时间
- ISBN（外键）

### 管理员信息

- 管理员工号（主键）
- 姓名
- 性别
- 联系电话
- 岗位

## 业务

个人认为图书借阅和图书归还合并为图书借阅记录更好

> ### 图书借阅（使用聚合的转化方法）
>
> - 借阅编号（主键）
> - 图书馆藏编号（外键）
> - 读者编号（外键）
> - 借阅时间
> - 应还时间
> - 续借次数
> - 管理员工号（外键）
>
> ### 图书归还
>
> - 归还编号（主键）
> - 图书馆藏编号（外键）
> - 读者编号（外键）
> - 归还时间
> - 是否超期
> - 是否损坏
> - 管理员工号（外键）

### 图书借阅记录

- 借阅记录编号（主键）
- 图书馆藏编号（外键）
- 读者编号（外键）
- 借阅时间
- 应还时间
- 续借次数
- 归还时间
- 是否超期
- 是否丢失
- 管理员工号（外键）

### 超期罚款

- 罚款编号（主键）
- 借阅记录编号（外键）
- 罚款金额
- 是否交款
- 罚款日期
- 管理员工号（外键）
- 备注

### 图书丢失

- 丢失编号（主键）
- 借阅记录编号（外键）
- 罚款金额
- 是否交款
- 操作时间
- 管理员工号（外键）
- 备注