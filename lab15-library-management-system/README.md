# Library management system

**开发思维导图**

点击查看 :point_down:

[mindmap](https://arronvague.github.io/Database-Systems-Laboratory/lab15-library-management-system/mindmap/mindmap.html)

**事务**

```csharp
using (MySqlConnection connection = Database.GetMySqlConnection())
{
    connection.Open();

    MySqlTransaction transaction = connection.BeginTransaction();

    try
    {
        // 设置事务关联的命令
        ...

        // 执行事务关联的命令
        command1.ExecuteNonQuery();
        command2.ExecuteNonQuery();
        command3.ExecuteNonQuery();
        command4.ExecuteNonQuery();

        // 提交事务
        transaction.Commit();
        Console.WriteLine("借阅图书成功！");

        ClearTextBox();
        DataBind_Customer();
        lbl_Note.Text = "Borrowed successfully!";
    }
    catch (Exception ex)
    {
        // 回滚事务
        transaction.Rollback();
        Console.WriteLine("借阅图书失败！");
        Console.WriteLine("错误信息：" + ex.Message);
    }
    
}
```

