CREATE DATABASE CursRab
GO


USE CursRab
GO

CREATE TABLE SUB_BERS( /*ПОДПИСЧИКИ*/
SUBERS_CODE INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_SUBERS PRIMARY KEY, /*Код подписчика*/
FIO VARCHAR(100) NOT NULL, /*ФИО*/
ADRESS VARCHAR(150) NOT NULL, /*Место жительства (населенный пункт)*/
TELEPHONE VARCHAR(30) NOT NULL, /*Номер телефона*/
ZIP_CODE VARCHAR (10) NOT NULL, /*Почтовый индекс*/
);

CREATE TABLE EDITION( /*ИЗДАHИЯ*/
PUBLIC_CODE INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_EDITION PRIMARY KEY, /*код издания*/
NAME_ED VARCHAR(100) NOT NULL, /*название*/
COMMON_PRICE INT DEFAULT (0) CONSTRAINT CH_COMMON CHECK ([COMMON_PRICE]>=(0)), /*цена за месяц(обычная)*/
PREF_PRICE INT DEFAULT (0) CONSTRAINT CH_PREF CHECK ([PREF_PRICE]>=(0)), /*цена за месяц(льготная)*/
CIRCULATION INT DEFAULT (1) CONSTRAINT CH_CIRCULATION CHECK ([CIRCULATION]>=(1)), /*тираж*/
NUMBER_SUBERS INT NULL DEFAULT (0), /*число подписчиков (связать с таблицей Подписка)*/
TYPE_ED VARCHAR(10) NOT NULL CONSTRAINT CK_TYPE_ED CHECK (TYPE_ED IN ('журнал','газета','книга')), /*тип издания (жуpнал, газета, книга)*/
EDITOR VARCHAR(100), /*ФИО редактора*/
) ON [PRIMARY]; 

CREATE TABLE SUB_TION( /*ПОДПИСКА*/
SUBTION_CODE INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_SUBTION PRIMARY KEY,
SUBERS_CODE INT NOT NULL CONSTRAINT FK_SUBERS FOREIGN KEY REFERENCES SUB_BERS(SUBERS_CODE) ON DELETE CASCADE ON UPDATE CASCADE, /*код подписчика*/
PUBLIC_CODE INT NOT NULL CONSTRAINT FK_EDITION FOREIGN KEY REFERENCES EDITION(PUBLIC_CODE) ON DELETE CASCADE ON UPDATE CASCADE, /*код издания*/
DATE_SUBTION DATE, /*дата подписки*/
NUM_MONTHS INT NOT NULL DEFAULT (1) CONSTRAINT CH_MONTHS CHECK ([NUM_MONTHS]>=(1)), /*на сколько месяцев*/
SIGN_PERKS VARCHAR (30) NOT NULL CONSTRAINT CK_SIGN_PERKS CHECK (SIGN_PERKS = 'есть льгота' OR SIGN_PERKS = 'нет льготы'), /*признак льготы*/
);
TRUNCATE TABLE SUB_TION;
INSERT INTO SUB_BERS (FIO, ADRESS, TELEPHONE, ZIP_CODE)
VALUES
('Милорадов Поликарп Савелиевич', 'г. Большое Мурашкино, ул. Барклая, дом 26, квартира 83', '8 (974) 858-42-88', '659350,'),
('Круглова Ариадна Ростиславовна ', 'г. Ардатов, ул. Бакунинская, дом 93, квартира 285', '8 (925) 825-53-80', '422559'),
('Дёшина Агния Андрияновна', 'г. Рогнедино, ул. Загородная, дом 33, квартира 181', '8 (933) 907-53-95', '416109'),
('Ермилов Макар Ираклиевич', 'г. Снежинск, ул. Башиловская, дом 95, квартира 126', '8 (975) 902-42-13', '215472'),
('Серпионов Богдан Иванович', 'г. Сочи, ул. Хрущёва, дом 90, квартира 284', '8 (928) 293-35-37', '652392'),
('Янышева Марфа Федоровна', 'г. Сочи, ул. Барышиха, дом 86, квартира 95', '8 (952) 211-83-55', '352217'),
('Берия Клавдий Евграфович', 'г. Чердынь, ул. Бахрушина, дом 64, квартира 171', '8 (970) 367-84-59', '659300'),
('Погребняк Измаил Эдуардович', 'г. Касторное, ул. Баррикадная, дом 68, квартира 26', '8 (902) 554-15-85', '141273'),
('Масмехова Дарья Ильевна ', 'г. Усть-Джегута, ул. Завокзальная 2-я, дом 46, квартира 267', '8 (965) 844-14-96', '422520'),
('Андрюшина Людмила Казимировна', 'г. Уйское, ул. Барболина, дом 1, квартира 141', '8 (940) 395-31-40', '624582'),
('Ревякин Феофан Никитевич', ' г. Шаранга, ул. Гайдара, дом 60, квартира 14', '8 (904) 920-56-82', '667008'),
('Ярушина Александра Леонидовна', 'г. Майкоп, ул. Бебеля, дом 68, квартира 81', '8 (928) 585-67-73', '182725'), /*12*/
('Доронин Михаил Алексеевич', 'г. Казань, ул. Барклая, дом 26, квартира 83', '8 (974) 858-42-88', '659350,'),
('Магина Анастасия Андреевна', 'г. Казань, ул. Бакунинская, дом 93, квартира 285', '8 (925) 825-53-80', '422559'),
('Серегина Ксения Андреевна', 'г. Казань, ул. Бакунинская, дом 94, квартира 280', '8 (925) 825-53-80', '422559');


INSERT INTO EDITION (NAME_ED, COMMON_PRICE, PREF_PRICE, CIRCULATION, TYPE_ED, EDITOR)
VALUES
('1001 Совет женщинам', '150', '130', '5000', 'журнал', 'Фомов Анатолий Денисович'),
('Вязание для вас', '180', '150', '10000', 'журнал', 'Савельева Маргарита Иосифовна '),
('Великие российские предприниматели', '150', '100', '2000', 'книга', 'Чаурина Клеопатра Ярославовна'),
('Фантастика 20го века', '200', '170', '23000', 'книга', 'Русин Парамон Филиппович'),
('Собрание трактатов философов СССР', '165', '150', '85400', 'книга', 'Крылова Валентина Георгиевна '),
('Cosmopolitan', '200', '180', '1300000', 'журнал', 'Беляева Казимира Ильинична '),
('THE ART NEWSPAPER RUSSIA', '290', '250', '400000', 'газета', 'Белозёров Павел Викторович'), /*7*/
('777', '150', '125', '4000', 'газета', 'Серегина Ксения Иванович');

INSERT INTO SUB_TION (SUBERS_CODE, PUBLIC_CODE, DATE_SUBTION, NUM_MONTHS, SIGN_PERKS)
VALUES
('1', '7','01.04.2018', '8', 'есть льгота'),
('5', '7', '05.04.2018','7', 'нет льготы'),
('12', '5', '13.05.2018', '10', 'нет льготы'),
('12', '2', '25.06.2018', '6', 'нет льготы'),
('2', '2', '07.07.2018', '5', 'есть льгота'),
('5', '4', '10.07.2018', '6', 'нет льготы'),
('11', '1', '15.07.2018', '7', 'есть льгота'),
('3', '3', '30.07.2018', '9', 'есть льгота'),
('10', '6', '05.08.2018', '4', 'нет льготы'),
('4', '1', '14.08.2018', '3', 'есть льгота'),
('8', '1', '15.08.2018', '7', 'нет льготы'),
('9', '2', '17.08.2018', '6', 'нет льготы'),
('6', '1', '24.08.2018', '2', 'есть льгота'),
('7', '3', '19.09.2018', '4', 'есть льгота'),
('4','3', '25.10.2018', '1', 'есть льгота'),
('13', '7','01.05.2015', '8', 'есть льгота'),
('13', '8', '05.04.2015','7', 'нет льготы'),
('14', '8', '05.04.2015','7', 'нет льготы');

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
SELECT EDITION.NAME_ED AS 'Название издания',
	EDITION.TYPE_ED AS 'Тип издания',
	EDITION.EDITOR AS 'Автор',
	EDITION.COMMON_PRICE AS 'Обычная цена',
	EDITION.PREF_PRICE AS 'Льготная цена'
	FROM EDITION;
	

CREATE VIEW LGOTNIKI_1001SOVET (FIO, ADRESS, TELEPHONE, ZIP_CODE)
AS
SELECT SUB_BERS.FIO AS 'ФИО',
		SUB_BERS.ADRESS AS 'Адрес',
		SUB_BERS.TELEPHONE AS 'Телефон',
		SUB_BERS.ZIP_CODE AS 'Индекс'
		FROM EDITION, SUB_BERS, SUB_TION
		WHERE SUB_BERS.SUBERS_CODE = SUB_TION.SUBERS_CODE
		AND EDITION.PUBLIC_CODE = SUB_TION.PUBLIC_CODE
		AND EDITION.NAME_ED = '1001 Совет женщинам'
		AND SUB_TION.SIGN_PERKS = 'есть льгота';

/*триггер для вставки данных*/
CREATE TRIGGER AI_SUB_TION ON SUB_TION
AFTER INSERT AS
BEGIN
DECLARE @COUNT INT;    
SET @COUNT = @@ROWCOUNT;  /*проверка, что ни одна строка не была затронута операцией вставки*/
IF @COUNT = 0         /*count создали, потому что rowcount постоянно сбрасывается*/
RETURN;     
SET NOCOUNT ON;
UPDATE EDITION    
SET NUMBER_SUBERS = NUMBER_SUBERS + (SELECT COUNT(PUBLIC_CODE)  /*НУЖЕН ЛИ EDITION?!*/          
FROM INSERTED i WHERE i.PUBLIC_CODE = EDITION.PUBLIC_CODE)    /*при выполнении триггера всегда создаются Inserted и Deleted.*/  
WHERE PUBLIC_CODE IN (SELECT PUBLIC_CODE FROM INSERTED i1);
END 

/*если подписка закончилась, нужно удалить подписку из таблицы*/
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


/* Найти и вывести сведения о подписке на журналы в заданном году (параметр):
•	ФИО подписчика
•	почтовый индекс
•	место жительства
•	название журнала
•	Дата подписки*/

SELECT DISTINCT SUB_BERS.FIO, SUB_BERS.ZIP_CODE, SUB_BERS.ADRESS, EDITION.NAME_ED, SUB_TION.DATE_SUBTION
FROM SUB_BERS, EDITION, SUB_TION
WHERE EDITION.PUBLIC_CODE = SUB_TION.PUBLIC_CODE
AND SUB_BERS.SUBERS_CODE = SUB_TION.SUBERS_CODE
AND EDITION.TYPE_ED = 'журнал'
AND YEAR(SUB_TION.DATE_SUBTION) = 2018;

SELECT FIO FROM SUB_BERS
WHERE EXISTS(SELECT * FROM EDITION
WHERE (TYPE_ED = 'газета')
AND NOT EXISTS (SELECT * FROM SUB_TION
WHERE (EDITION.PUBLIC_CODE = SUB_TION.PUBLIC_CODE)
AND (SUB_BERS.SUBERS_CODE = SUB_TION.SUBERS_CODE)
AND (YEAR(SUB_TION.DATE_SUBTION) = 2018))
)

SELECT EDITION.NAME_ED FROM EDITION
WHERE (TYPE_ED = 'газета')
AND NOT EXISTS (SELECT * FROM SUB_BERS
WHERE(SUBSTRING(ADRESS, 3, 6) = 'Казань')
AND NOT EXISTS( SELECT * FROM SUB_TION
WHERE (SUB_BERS.SUBERS_CODE = SUB_TION.SUBERS_CODE)
AND (EDITION.PUBLIC_CODE = SUB_TION.PUBLIC_CODE)
AND (YEAR(SUB_TION.DATE_SUBTION) = 2015))
);
SELECT*
FROM SUB_TION;




SELECT FIO, COUNT(CASE WHEN EDITION.TYPE_ED='журнал' THEN 1 ELSE NULL END)
AS COUNT_M,
COUNT (CASE WHEN EDITION.TYPE_ED = 'газета' THEN 1 ELSE NULL END) AS COUNT_N
FROM SUB_BERS, SUB_TION, EDITION
WHERE
SUB_BERS.SUBERS_CODE = SUB_TION.SUBERS_CODE AND
SUB_TION.PUBLIC_CODE = EDITION.PUBLIC_CODE 
AND YEAR(SUB_TION.DATE_SUBTION) = 2018
GROUP BY SUB_BERS.FIO;