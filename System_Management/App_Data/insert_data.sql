---Insert User---

INSERT INTO Users VALUES('mra','197oV3Gr+WYRrky/Kiy63MvJt/Eznywf6Q+PIIbEY9htguJP1I644mfxbVnJcKF1T1')
INSERT INTO Users VALUES('admin','22P0o8BNR7jODHGCpWaF//yF3IwJjo8KXPSderQHoVyTjDOaqIIDdWQvRxy5n0SqQC')
INSERT INTO Users VALUES('mrb','22Y8tprnD205zHR5I5Gb9Px6Kvh0SgwfC5QAtkTMUVUqvOFyGrhiZpJZ9elgxOwKwz')
INSERT INTO Users VALUES('mrc','22kB0uLfBGgT01wfG9Yp5Zg8LCZPZirtBB8oNxjkDcdyd5dYRXcMAy/kNSpbq9FXJ5')
INSERT INTO Users VALUES('staff_1','15It6C6iVzd2pmxFw4A0tFz1q23JnCdT3qJiAMxBpocr+H89siyLQktRp4JMtKnBK8')
INSERT INTO Users VALUES('staff_2','15It6C6iVzd2pmxFw4A0tFz1q23JnCdT3qJiAMxBpocr+H89siyLQktRp4JMtKnBK8')
INSERT INTO Users VALUES('staff_3','15It6C6iVzd2pmxFw4A0tFz1q23JnCdT3qJiAMxBpocr+H89siyLQktRp4JMtKnBK8')
INSERT INTO Users VALUES('staff_4','15It6C6iVzd2pmxFw4A0tFz1q23JnCdT3qJiAMxBpocr+H89siyLQktRp4JMtKnBK8')

---Connect user to schools---
INSERT INTO SchoolHasUsers VALUES(10,10000)
INSERT INTO SchoolHasUsers VALUES(10,10001)
INSERT INTO SchoolHasUsers VALUES(10,10002)
INSERT INTO SchoolHasUsers VALUES(11,10003)
INSERT INTO SchoolHasUsers VALUES(10,10004)
INSERT INTO SchoolHasUsers VALUES(10,10005)
INSERT INTO SchoolHasUsers VALUES(10,10006)
INSERT INTO SchoolHasUsers VALUES(10,10007)

---Add role to user---
--mra mrb : student
--mrc : teacher
--admin : admin
-- staff_1 staff_2 staff_3 staff_4 : staff
INSERT INTO UserToRoles VALUES(10000,4)
INSERT INTO UserToRoles VALUES(10001,1)
INSERT INTO UserToRoles VALUES(10002,4)
INSERT INTO UserToRoles VALUES(10003,2)
INSERT INTO UserToRoles VALUES(10004,3)
INSERT INTO UserToRoles VALUES(10005,3)
INSERT INTO UserToRoles VALUES(10006,3)
INSERT INTO UserToRoles VALUES(10007,3)

---Add User To Students
INSERT INTO Students VALUES('140505',10000,100,DEFAULT,NULL)
INSERT INTO Students VALUES('145678',10002,100,DEFAULT,NULL)

---Add User To Admins
INSERT INTO Admins VALUES(10001)

---Add User To Teachers
INSERT INTO Teachers VALUES(10003,100)

---Add User To Staffs
INSERT INTO Staffs VALUES(10004,100)
INSERT INTO Staffs VALUES(10005,100)
INSERT INTO Staffs VALUES(10006,101)
INSERT INTO Staffs VALUES(10007,102)

---Add News
INSERT INTO News VALUES(N'Thông báo về kế hoạch học tập các lớp part2 kỳ Summer 2021 từ ngày 12/07/2021 tại cơ sở Hà Nội',N'Căn cứ tình hình dịch bệnh Covid-19 vẫn diễn biến phức tạp, Phòng TC&QL Đào tạo cơ sở Hà Nội thông báo về kế hoạch học tập các lớp part2 kỳ Summer 2021 như sau:$
1. Các lớp Vovinam (VOV) tạm nghỉ $
2. Các lớp Little UK (LUK) học online theo thông báo cụ thể của văn phòng Little UK $
3. Các lớp còn lại học từ xa trên Google Meet (theo link trên FAP) $
4. Chương trình Global Citizen Project ++ ( Chương trình học tập bổ sung dành cho Sinh viên Little UK kỳ Summer 2021 Part1 đã thông báo ngày 21/6) tạm hoãn. $
5. Kế hoạch áp dụng từ ngày bắt đầu part 2 (12/7/2021) cho đến khi có thông báo tiếp theo. $
     Yêu cầu giảng viên, sinh viên tiếp tục tăng cường thực hiện các biện pháp phòng, chống dịch Covid-19 theo hướng dẫn của Bộ Y tế và các cơ quan chức năng. $',1000,DEFAULT,NULL,10,1)

INSERT INTO News VALUES(N'     FU-HL V/v: Tham dự buổi định hướng làm khóa luận tốt nghiệp cho sinh viên ngành Khoa học máy tính',
N'   Phòng tổ chức và Quản lý đào tạo mời các em sinh viên tham dự buổi định hướng làm khóa luận tốt nghiệp học kỳ Fall 2021 dành cho các sinh viên khóa 14A chuyên ngành Khoa học máy tính :$
$
Nội dung chi tiết:$
$
- Hướng dẫn làm KLTN: Điều kiện làm KLTN, quy định thành lập nhóm…$
$
- Các mốc thời gian quan trọng$
$
- Thầy Phan Duy Hùng – Chủ nhiệm bộ môn Khoa học máy tính sẽ chia sẻ, tư vấn và giải đáp các thắc mắc của sinh viên.$
$
     Thời gian: Slot 7, thứ 3 ngày 27/7/2021.$
$
     Địa điểm (OR Online qua link): https://meet.google.com/jip-ojmu-yeq$
$
Lưu ý: Đây là buổi định hướng rất quan trọng để em nắm được các quy định về KLTN và quy định xét tốt nghiệp của nhà trường. Đề nghị sinh viên có mặt đầy đủ và đúng giờ.$',1002,DEFAULT,NULL,10,0)

INSERT INTO News VALUES(N'
     FU-HL Thông báo điểm thi lần 2 các môn BDP301b, BDP303b, CPP101b, CQT201b HK Summer 2021',
N'   Phòng khảo thí thông báo đã có điểm thi lần 2 các môn BDP301b, BDP303b, CPP101b, CQT201b HK Summer 2021. Các em đăng nhập FAP để xem điểm chi tiết.$',1003,DEFAULT,NULL,10,0)



---Insert Data To Application Type
SELECT * FROM ApplicationType
INSERT INTO ApplicationType VALUES(N'Đề nghị cấp bảng điểm quá trình',DEFAULT);
INSERT INTO ApplicationType VALUES(N'Đề nghị chuyển đổi tín chỉ',0);
INSERT INTO ApplicationType VALUES(N'Đề nghị chuyển dổi quá trình',2300000);

SELECT * FROM Applications
SELECT * FROM ApplicationDetails

CREATE PROCEDURE stp_InsertApplication
@Title NVARCHAR(500),
@StudentId INT, @Content NVARCHAR(MAX), @FileName NVARCHAR(300), @FileBytes VARBINARY(MAX)
AS
BEGIN
     DECLARE @Department INT;
     DECLARE @DetailId INT;
     DECLARE @FileId INT;
     SET @Department = 100;
     IF @FileName IS NOT NULL AND @FileBytes IS NOT NULL
          BEGIN
               INSERT INTO Files VALUES(@FileName,@FileBytes)
               SET @FileId = @@IDENTITY
          END
     ELSE
          BEGIN
               SET @FileId = NULL
          END

     INSERT INTO Applications VALUES(@Department,@Title,GETDATE(),NULL,NULL,NULL)
     SET @DetailId = @@IDENTITY
     INSERT INTO ApplicationDetails VALUES(@DetailId,@StudentId,@Content,@FileId,NULL)
     
END
----

CREATE PROCEDURE stp_InsertApplication
@Title INT, @UserId INT,
@Content NVARCHAR(MAX), @FileName NVARCHAR(200), @FileBytes VARBINARY(MAX)
AS
BEGIN
     SET NOCOUNT ON;
     DECLARE @Department INT;
     DECLARE @DateCreated DATE;
     DECLARE @DateClose DATE;
     DECLARE @AppStatus BIT;
     DECLARE @Solve INT;
     DECLARE @Solution NVARCHAR(MAX);
     DECLARE @FileId INT;
     DECLARE @AppId INT;
     DECLARE @Student INT;
     DECLARE @Cost MONEY;

     SET @Department = 100;
     SET @DateCreated = GETDATE();
     SET @DateClose = NULL;
     SET @AppStatus = NULL;
     SET @Solve = NULL;
     SET @Solution = NULL;

     IF(@FileName IS NOT NULL)
          BEGIN
               INSERT INTO Files VALUES(@FileName,@FileBytes);
               SET @FileId = @@IDENTITY
          END
     ELSE
          BEGIN
               SET @FileId = NULL
          END

     SET @Cost = (SELECT Cost FROM ApplicationType WHERE @Title = Id)

     UPDATE UserInformations SET Balance = Balance - @Cost WHERE UserId = @UserId
     UPDATE Files SET FilesName = CONCAT(@FileId,'_',@FileName) WHERE FileId = @FileId

     INSERT INTO Applications VALUES(@Department,@Title,@DateCreated,@DateClose,@AppStatus,@Solve)
     SET @AppId = @@IDENTITY
     SET @Student = (SELECT StudentId FROM Students WHERE UserId = @UserId)
     
     INSERT INTO ApplicationDetails VALUES(@AppId,@Student,@Content,@FileId,@Solution)
    
END

DROP PROCEDURE stp_InsertApplication

 SELECT * FROM Applications
     SELECT * FROM ApplicationDetails
     SELECT * FROM Users
     SELECT * FROM UserToRoles




-----------------------------------
---PROC FOR LOGIN---
GO
CREATE PROCEDURE sp_UserLogin
@UserName VARCHAR(50), @School INT
AS
BEGIN
     SELECT db.UserPassword FROM (
     SELECT u.UserId,u.UserName,u.UserPassword,su.SchoolId FROM Users u JOIN SchoolHasUsers su ON u.UserId = su.UserId) AS db
     WHERE db.UserName = @UserName AND db.SchoolId = @School
END

GO
---Create Procedure Search News By Title
CREATE PROCEDURE sp_SearchNews
@Title NVARCHAR(100)
AS
BEGIN
     DECLARE @Regex NVARCHAR(100);
     SET @Regex = CONCAT('%',@Title,'%')
     SELECT * FROM News WHERE NewsTitle LIKE @Regex
END

