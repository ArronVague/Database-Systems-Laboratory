import mysql.connector
from datetime import date, datetime, timedelta
import random
import os
import configparser

# 从上级文件夹导入config.ini文件中的配置


# 获取当前文件的上级目录
current_path = os.path.abspath(os.path.dirname(__file__))
# 获取config.ini文件的路径
config_path = os.path.join(current_path, "../config.ini")
# 创建ConfigParser对象
config = configparser.ConfigParser()
# 读取config.ini文件
config.read(config_path)

print("read config.ini file successfully!")
print(config)

# MySQL数据库连接配置
db_config = {
    "host": config.get("mysql", "server").strip('"'),
    "user": config.get("mysql", "UID").strip('"'),
    "password": config.get("mysql", "PWD").strip('"'),
    "database": "eas_db",
    "port": int(config.get("mysql", "port").strip('"')),
}

# 连接MySQL数据库
connection = mysql.connector.connect(**db_config)
# 判断连接是否成功
if connection.is_connected():
    print("connection success!")
else:
    print("connection failed!")

cursor = connection.cursor()

# 插入10000条数据
num = 10

for _ in range(num):
    # birth_date类型是date

    birth_date = date(1970, 1, 1) + timedelta(days=random.randint(1, 365 * 40))
    first_name = "FirstName" + str(random.randint(1, 100))
    last_name = "LastName" + str(random.randint(1, 100))
    gender = random.choice(["M", "F"])
    hire_date = date(2020, 1, 1) + timedelta(days=random.randint(1, 365))

    # 执行插入语句
    insert_query = "INSERT INTO employees VALUES(NULL, %s, %s, %s, %s, %s)"

    insert_values = (birth_date, first_name, last_name, gender, hire_date)
    cursor.execute(insert_query, insert_values)

# 提交事务
connection.commit()

# 关闭连接
cursor.close()
connection.close()
