CREATE DATABASE CursRab
GO


USE CursRab
GO

CREATE TABLE SUB_BERS( /*����������*/
SUBERS_CODE INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_SUBERS PRIMARY KEY, /*��� ����������*/
FIO VARCHAR(100) NOT NULL, /*���*/
ADRESS VARCHAR(150) NOT NULL, /*����� ���������� (���������� �����)*/
TELEPHONE VARCHAR(30) NOT NULL, /*����� ��������*/
ZIP_CODE VARCHAR (10) NOT NULL, /*�������� ������*/
);

CREATE TABLE EDITION( /*����H��*/
PUBLIC_CODE INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_EDITION PRIMARY KEY, /*��� �������*/
NAME_ED VARCHAR(100) NOT NULL, /*��������*/
COMMON_PRICE INT DEFAULT (0) CONSTRAINT CH_COMMON CHECK ([COMMON_PRICE]>=(0)), /*���� �� �����(�������)*/
PREF_PRICE INT DEFAULT (0) CONSTRAINT CH_PREF CHECK ([PREF_PRICE]>=(0)), /*���� �� �����(��������)*/
CIRCULATION INT DEFAULT (1) CONSTRAINT CH_CIRCULATION CHECK ([CIRCULATION]>=(1)), /*�����*/
NUMBER_SUBERS INT NULL DEFAULT (0), /*����� ����������� (������� � �������� ��������)*/
TYPE_ED VARCHAR(10) NOT NULL CONSTRAINT CK_TYPE_ED CHECK (TYPE_ED IN ('������','������','�����')), /*��� ������� (��p���, ������, �����)*/
EDITOR VARCHAR(100), /*��� ���������*/
) ON [PRIMARY]; 

CREATE TABLE SUB_TION( /*��������*/
SUBTION_CODE INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_SUBTION PRIMARY KEY,
SUBERS_CODE INT NOT NULL CONSTRAINT FK_SUBERS FOREIGN KEY REFERENCES SUB_BERS(SUBERS_CODE) ON DELETE CASCADE ON UPDATE CASCADE, /*��� ����������*/
PUBLIC_CODE INT NOT NULL CONSTRAINT FK_EDITION FOREIGN KEY REFERENCES EDITION(PUBLIC_CODE) ON DELETE CASCADE ON UPDATE CASCADE, /*��� �������*/
DATE_SUBTION DATE, /*���� ��������*/
NUM_MONTHS INT NOT NULL DEFAULT (1) CONSTRAINT CH_MONTHS CHECK ([NUM_MONTHS]>=(1)), /*�� ������� �������*/
SIGN_PERKS VARCHAR (30) NOT NULL CONSTRAINT CK_SIGN_PERKS CHECK (SIGN_PERKS = '���� ������' OR SIGN_PERKS = '��� ������'), /*������� ������*/
);
TRUNCATE TABLE SUB_TION;
INSERT INTO SUB_BERS (FIO, ADRESS, TELEPHONE, ZIP_CODE)
VALUES
('��������� �������� ����������', '�. ������� ���������, ��. �������, ��� 26, �������� 83', '8 (974) 858-42-88', '659350,'),
('�������� ������� ������������� ', '�. �������, ��. �����������, ��� 93, �������� 285', '8 (925) 825-53-80', '422559'),
('ĸ���� ����� �����������', '�. ���������, ��. ����������, ��� 33, �������� 181', '8 (933) 907-53-95', '416109'),
('������� ����� ����������', '�. ��������, ��. �����������, ��� 95, �������� 126', '8 (975) 902-42-13', '215472'),
('��������� ������ ��������', '�. ����, ��. �������, ��� 90, �������� 284', '8 (928) 293-35-37', '652392'),
('������� ����� ���������', '�. ����, ��. ��������, ��� 86, �������� 95', '8 (952) 211-83-55', '352217'),
('����� ������� ����������', '�. �������, ��. ���������, ��� 64, �������� 171', '8 (970) 367-84-59', '659300'),
('��������� ������ ����������', '�. ���������, ��. �����������, ��� 68, �������� 26', '8 (902) 554-15-85', '141273'),
('��������� ����� ������� ', '�. ����-�������, ��. ������������ 2-�, ��� 46, �������� 267', '8 (965) 844-14-96', '422520'),
('��������� ������� �����������', '�. ������, ��. ���������, ��� 1, �������� 141', '8 (940) 395-31-40', '624582'),
('������� ������ ���������', ' �. �������, ��. �������, ��� 60, �������� 14', '8 (904) 920-56-82', '667008'),
('������� ���������� ����������', '�. ������, ��. ������, ��� 68, �������� 81', '8 (928) 585-67-73', '182725'), /*12*/
('������� ������ ����������', '�. ������, ��. �������, ��� 26, �������� 83', '8 (974) 858-42-88', '659350,'),
('������ ��������� ���������', '�. ������, ��. �����������, ��� 93, �������� 285', '8 (925) 825-53-80', '422559'),
('�������� ������ ���������', '�. ������, ��. �����������, ��� 94, �������� 280', '8 (925) 825-53-80', '422559');


INSERT INTO EDITION (NAME_ED, COMMON_PRICE, PREF_PRICE, CIRCULATION, TYPE_ED, EDITOR)
VALUES
('1001 ����� ��������', '150', '130', '5000', '������', '����� �������� ���������'),
('������� ��� ���', '180', '150', '10000', '������', '��������� ��������� ��������� '),
('������� ���������� ���������������', '150', '100', '2000', '�����', '������� ��������� �����������'),
('���������� 20�� ����', '200', '170', '23000', '�����', '����� ������� ����������'),
('�������� ��������� ��������� ����', '165', '150', '85400', '�����', '������� ��������� ���������� '),
('Cosmopolitan', '200', '180', '1300000', '������', '������� �������� ��������� '),
('THE ART NEWSPAPER RUSSIA', '290', '250', '400000', '������', '�������� ����� ����������'), /*7*/
('777', '150', '125', '4000', '������', '�������� ������ ��������');

INSERT INTO SUB_TION (SUBERS_CODE, PUBLIC_CODE, DATE_SUBTION, NUM_MONTHS, SIGN_PERKS)
VALUES
('1', '7','01.04.2018', '8', '���� ������'),
('5', '7', '05.04.2018','7', '��� ������'),
('12', '5', '13.05.2018', '10', '��� ������'),
('12', '2', '25.06.2018', '6', '��� ������'),
('2', '2', '07.07.2018', '5', '���� ������'),
('5', '4', '10.07.2018', '6', '��� ������'),
('11', '1', '15.07.2018', '7', '���� ������'),
('3', '3', '30.07.2018', '9', '���� ������'),
('10', '6', '05.08.2018', '4', '��� ������'),
('4', '1', '14.08.2018', '3', '���� ������'),
('8', '1', '15.08.2018', '7', '��� ������'),
('9', '2', '17.08.2018', '6', '��� ������'),
('6', '1', '24.08.2018', '2', '���� ������'),
('7', '3', '19.09.2018', '4', '���� ������'),
('4','3', '25.10.2018', '1', '���� ������'),
('13', '7','01.05.2015', '8', '���� ������'),
('13', '8', '05.04.2015','7', '��� ������'),
('14', '8', '05.04.2015','7', '��� ������');

UPDATE SUB_TION 
SET PUBLIC_CODE = 7
WHERE DATE_SUBTION = '01.04.2015';

DELETE FROM SUB_TION
WHERE PUBLIC_CODE = 2
AND SUBERS_CODE = 12;

SELECT *
FROM SUB_BERS;

SELECT *
FROM EDITION;

SELECT *
FROM SUB_TION;

CREATE VIEW MY_CATALOG (NAME_ED, TYPE_ED, EDITOR, COMMON_PRICE, PREF_PRICE)
AS
SELECT EDITION.NAME_ED AS '�������� �������',
	EDITION.TYPE_ED AS '��� �������',
	EDITION.EDITOR AS '�����',
	EDITION.COMMON_PRICE AS '������� ����',
	EDITION.PREF_PRICE AS '�������� ����'
	FROM EDITION;
	

CREATE VIEW LGOTNIKI_1001SOVET (FIO, ADRESS, TELEPHONE, ZIP_CODE)
AS
SELECT SUB_BERS.FIO AS '���',
		SUB_BERS.ADRESS AS '�����',
		SUB_BERS.TELEPHONE AS '�������',
		SUB_BERS.ZIP_CODE AS '������'
		FROM EDITION, SUB_BERS, SUB_TION
		WHERE SUB_BERS.SUBERS_CODE = SUB_TION.SUBERS_CODE
		AND EDITION.PUBLIC_CODE = SUB_TION.PUBLIC_CODE
		AND EDITION.NAME_ED = '1001 ����� ��������'
		AND SUB_TION.SIGN_PERKS = '���� ������';

/*������� ��� ������� ������*/
CREATE TRIGGER AI_SUB_TION ON SUB_TION
AFTER INSERT AS
BEGIN
DECLARE @COUNT INT;    
SET @COUNT = @@ROWCOUNT;  /*��������, ��� �� ���� ������ �� ���� ��������� ��������� �������*/
IF @COUNT = 0         /*count �������, ������ ��� rowcount ��������� ������������*/
RETURN;     
SET NOCOUNT ON;
UPDATE EDITION    
SET NUMBER_SUBERS = NUMBER_SUBERS + (SELECT COUNT(PUBLIC_CODE)  /*����� �� EDITION?!*/          
FROM INSERTED i WHERE i.PUBLIC_CODE = EDITION.PUBLIC_CODE)    /*��� ���������� �������� ������ ��������� Inserted � Deleted.*/  
WHERE PUBLIC_CODE IN (SELECT PUBLIC_CODE FROM INSERTED i1);
END 

/*���� �������� �����������, ����� ������� �������� �� �������*/
CREATE TRIGGER BD_SUB_TION ON SUB_TION
AFTER DELETE AS
BEGIN
DECLARE @COUNT INT;
SET @COUNT = @@ROWCOUNT;
IF @COUNT = 0
RETURN;
SET NOCOUNT ON;
UPDATE EDITION
SET NUMBER_SUBERS = NUMBER_SUBERS - (SELECT COUNT(PUBLIC_CODE)
FROM DELETED d WHERE d.PUBLIC_CODE = EDITION.PUBLIC_CODE)
WHERE PUBLIC_CODE IN (SELECT PUBLIC_CODE FROM DELETED d1);
END

CREATE TRIGGER AU_SUB_TION ON SUB_TION
AFTER UPDATE AS
	BEGIN
	DECLARE @COUNT INT;
	SET @COUNT = @@ROWCOUNT;
	IF @COUNT = 0
	RETURN;
	SET NOCOUNT ON;
	IF UPDATE (PUBLIC_CODE)
	BEGIN
		SELECT * FROM DELETED 
		SET @COUNT = @@ROWCOUNT;
		IF @COUNT > 0
		UPDATE EDITION
		SET NUMBER_SUBERS = NUMBER_SUBERS - (SELECT COUNT(PUBLIC_CODE)
			FROM DELETED d WHERE d.PUBLIC_CODE = EDITION.PUBLIC_CODE
			GROUP BY PUBLIC_CODE)
		WHERE PUBLIC_CODE IN(SELECT PUBLIC_CODE FROM DELETED d1)
		SELECT * FROM INSERTED
		SET @COUNT = @@ROWCOUNT;
		IF @COUNT > 0
		UPDATE EDITION
		SET NUMBER_SUBERS = NUMBER_SUBERS + (SELECT COUNT(PUBLIC_CODE)
			FROM INSERTED i WHERE i.PUBLIC_CODE = EDITION.PUBLIC_CODE
			GROUP BY PUBLIC_CODE)
		WHERE PUBLIC_CODE IN (SELECT PUBLIC_CODE FROM INSERTED i1);
	END
END;

	
TRUNCATE TABLE EDITION;
TRUNCATE TABLE SUB_BERS;
TRUNCATE TABLE SUB_TION;
DROP TRIGGER AI_SUBITION;


/* ����� � ������� �������� � �������� �� ������� � �������� ���� (��������):
�	��� ����������
�	�������� ������
�	����� ����������
�	�������� �������
�	���� ��������*/

SELECT DISTINCT SUB_BERS.FIO, SUB_BERS.ZIP_CODE, SUB_BERS.ADRESS, EDITION.NAME_ED, SUB_TION.DATE_SUBTION
FROM SUB_BERS, EDITION, SUB_TION
WHERE EDITION.PUBLIC_CODE = SUB_TION.PUBLIC_CODE
AND SUB_BERS.SUBERS_CODE = SUB_TION.SUBERS_CODE
AND EDITION.TYPE_ED = '������'
AND YEAR(SUB_TION.DATE_SUBTION) = 2018;

SELECT FIO FROM SUB_BERS
WHERE EXISTS(SELECT * FROM EDITION
WHERE (TYPE_ED = '������')
AND NOT EXISTS (SELECT * FROM SUB_TION
WHERE (EDITION.PUBLIC_CODE = SUB_TION.PUBLIC_CODE)
AND (SUB_BERS.SUBERS_CODE = SUB_TION.SUBERS_CODE)
AND (YEAR(SUB_TION.DATE_SUBTION) = 2018))
)

SELECT EDITION.NAME_ED FROM EDITION
WHERE (TYPE_ED = '������')
AND NOT EXISTS (SELECT * FROM SUB_BERS
WHERE(SUBSTRING(ADRESS, 3, 6) = '������')
AND NOT EXISTS( SELECT * FROM SUB_TION
WHERE (SUB_BERS.SUBERS_CODE = SUB_TION.SUBERS_CODE)
AND (EDITION.PUBLIC_CODE = SUB_TION.PUBLIC_CODE)
AND (YEAR(SUB_TION.DATE_SUBTION) = 2015))
);
SELECT*
FROM SUB_TION;




SELECT FIO, COUNT(CASE WHEN EDITION.TYPE_ED='������' THEN 1 ELSE NULL END)
AS COUNT_M,
COUNT (CASE WHEN EDITION.TYPE_ED = '������' THEN 1 ELSE NULL END) AS COUNT_N
FROM SUB_BERS, SUB_TION, EDITION
WHERE
SUB_BERS.SUBERS_CODE = SUB_TION.SUBERS_CODE AND
SUB_TION.PUBLIC_CODE = EDITION.PUBLIC_CODE 
AND YEAR(SUB_TION.DATE_SUBTION) = 2018
GROUP BY SUB_BERS.FIO;