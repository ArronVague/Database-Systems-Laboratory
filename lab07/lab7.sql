CREATE VIEW student_view1 AS
SELECT * FROM
student_info s
WHERE s.MID = 1 or s.MID = 2;

CREATE VIEW student_view2 AS
SELECT s.SNo, s.SName, s.hobby FROM
student_info s
WHERE s.Sex = 1;

CREATE VIEW student_view3 AS
c