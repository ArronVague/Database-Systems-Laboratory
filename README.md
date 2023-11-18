# Database-Systems-Laboratory
A repo to store something of database systems lab

## Tips

If you want to use `.net` code, please create a file name `config.ini`, and add your own MySql information such as:

```ini
server = "your server"
database = "the database you want to use"
UID = "user"
PWD = "password"
port = "port"
```



## 吐槽

`PowerDesigner`添加外键的时候，如果想要自动将主表的主键添加到从表的属性里，从表任一属性的code不能和主表的主键code相同。

例：reader_category(**id**, ...)和reader_info(**id**, ...)这种命名方式不行。