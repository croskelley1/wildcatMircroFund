insert into Application(CompanyName, CreatedDate, AppStatus)
values 
	('Wallys Bistro', '2019-01-01 00:01:00', 1),
	('Starbucks', '2019-01-02 00:00:00', 1);
select * from Application;

insert into ApplicationStatus(UserID, AppID, StatusID, StatusDate)
values 
	(1, 1, 1, '2019-01-01 00:01:00'),
	(2, 2, 2, '2019-01-02 00:00:00');
select * from ApplicationStatus;

insert into Availability(UserID, AvailStart, AvailEnd)
values 
	(1, '2019-01-01 00:01:00', '2019-02-01 00:01:00');
select * from Availability;

insert into Award(AppID, AwardTypeID, AwardAmount, AwardDate, WasRecieved)
values 
	(1, 1, 1000.00, '2019-03-01 00:01:00', 1);
select * from Award;

insert into AwardType(AwardTypeDesc)
values 
	('Cash');
select * from AwardType;

insert into Document(AppId, DocFile)
values 
	(1, 'test.txt');
select * from Document;

insert into DocumentType(DocTypeDesc)
values 
	('Text file');
select * from DocumentType;

insert into Note(NoteContent, NoteVisibility, NoteInternal, NoteCreator)
values 
	('This is my first note', 1, 1, 1);
select * from Note;

insert into NoteType(NoteTypeDesc)
values 
	('Mentor note');
select * from NoteType;

insert into PitchEvent(PitchEventDate)
values 
	('2019-02-01 00:01:00')
select * from PitchEvent;

insert into PitchEventApplication(PitchID, UserAppID)
values 
	(1, 1);
select * from PitchEventApplication;

insert into Question(QuestDesc, SurveyQuestion, QuestIsActive)
values 
	('Business Name', 'What is the name of your business?', 1),
	('Employees', 'How many employees do you have?', 1);
select * from Question;

insert into Response(SurveyQuestionID, AppID, Responses)
values 
	(1, 1, 'Wallys Bistro');
select * from Response;

insert into Role(RoleTitle)
values
	('Admin'),
	('Entrepreneur'),
	('Judge'),
	('Mentor');
select * from Role;

insert into Score(UserId, ScoreValue, ScoreComments, PitchEvAppID, ResponseID)
values 
	(1, 8, 'Good job', 1, 1);
select * from Score;

insert into Status(StatusDesc)
values 
	('Submitted'), ('Ready For Pitch Event'), ('Scored'), ('Awarded');
select * from Status;

insert into Survey(SurveyQID, AppID, SurveyTypeID)
values 
	(1, 1, 1);
select * from Survey;

insert into SurveyQuestion(QuestID, SurvId, SurveyQuestionDate)
values 
	(1, 1, '2019-01-31 00:01:00');
select * from SurveyQuestion;

insert into SurveyType(SurveyTypeDesc)
values 
	('1 month follow-up');
select * from SurveyType;