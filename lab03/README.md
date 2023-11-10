create table student_info

(

    student_id varchar(10) not null,

    major_id int not null,

    name varchar(30) not null,

    sex int not null,

    birthday datetime not null,

    total_credit float not null,

    favorite text,

    remark text,

    primary key (student_id),

    foreign key (major_id) references major_info (major_id)

);



CREATE TABLE student_info (
    student_id varchar(10) not null,
    major_id int not null,
    name varchar(30) not null,
    sex int not null,
    birthday datetime not null,
    total_credit float not null,
    favorite text,
    remark text,
    primary key (student_id),
    foreign key (major_id) references major_info (major_id)
);



```
create score_info (
    c
    course_id int not null,
    score float not null,
    foreign key (student_id) references student_info (student_id),
    foreign key (course_id) references course_info (course_id)
);
```

CREATE TABLE score_info (
    student_id varchar(10) not null,
    course_id int not null,
    score float not null,
    foreign key (student_id) references student_info (student_id),
    foreign key (course_id) references course_info (course_id)
);






