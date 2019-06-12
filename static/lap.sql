CREATE TABLE Lap
(
   [Id] varchar(64) NOT NULL,
   [UserId] varchar(64) NOT NULL,
   [SessionId] varchar(64) NOT NULL,
   [RecordDate] date NOT NULL,
   [Milliseconds] int(11) NOT NULL,
   [Seconds] int(11) NOT NULL,
   [Minutes] int(11) NOT NULL,
   [Hours] int(11) NOT NULL,
   [Days] int(11) NOT NULL
)

ALTER TABLE Lap
  ADD PRIMARY KEY (Id);
COMMIT;