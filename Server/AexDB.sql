CREATE DATABASE [AEXTestDB]
GO

USE [AEXTestDB]
GO

CREATE TABLE [dbo].[Movies] (
[Id] INT NOT NULL IDENTITY,
[Name] NVARCHAR(100) COLLATE Cyrillic_General_CI_AS_KS NOT NULL,
[RealeaseYear] DATE NOT NULL,
[Description] NVARCHAR(100) COLLATE Cyrillic_General_CI_AS_KS NOT NULL,
PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[Actors] (
[Id] INT NOT NULL IDENTITY,
[FirstName] NVARCHAR(100) COLLATE Cyrillic_General_CI_AS_KS NOT NULL,
[MiddleName] NVARCHAR(100) COLLATE Cyrillic_General_CI_AS_KS NOT NULL,
[LastName] NVARCHAR(100) COLLATE Cyrillic_General_CI_AS_KS NOT NULL,
[Country] NVARCHAR(100) COLLATE Cyrillic_General_CI_AS_KS NOT NULL,
PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[Genres] (
[Id] INT NOT NULL IDENTITY,
[Name] NVARCHAR(100) COLLATE Cyrillic_General_CI_AS_KS NOT NULL,
PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE TABLE [dbo].[MoviesActors] (
[Id] INT NOT NULL IDENTITY PRIMARY KEY,
[ActorId] INT NOT NULL,
[MovieId] INT NOT NULL,
FOREIGN KEY ([ActorId]) REFERENCES [dbo].[Actors] ([Id]),
FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
);
GO

CREATE TABLE [dbo].[MoviesGenres] (
[Id] INT NOT NULL IDENTITY PRIMARY KEY,
[MovieId] INT NOT NULL,
[GenreId] INT NOT NULL,
FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genres] ([Id]),
FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
);
GO

insert into dbo.Movies values('Joker', '2019-02-10', 'description of Joker');
insert into dbo.Movies values('Iron Man', '2010-02-10', 'description of Iron Man');
insert into dbo.Movies values('Spider-Man', '2005-02-20', 'description of Spider-Man');
insert into dbo.Movies values('Dark knight', '2006-06-20', 'description of Dark Knight');

insert into dbo.Genres values('Drama');
insert into dbo.Genres values('Action');
insert into dbo.Genres values('Comedy');
insert into dbo.Genres values('Fantasy');

insert into dbo.Actors values('Joaquin', 'Phoenix', 'no', 'USA');
insert into dbo.Actors values('Downy', 'Robert', 'Jr', 'USA');
insert into dbo.Actors values('Beil', 'Christian', 'no', 'USA');
insert into dbo.Actors values('Ladger', 'Hit', 'no', 'USA');
insert into dbo.Actors values('Maguire ', 'Tobey', 'no', 'USA');

insert into dbo.MoviesActors values(1, 1);
insert into dbo.MoviesActors values(2, 2);
insert into dbo.MoviesActors values(5, 3);
insert into dbo.MoviesActors values(3, 4);
insert into dbo.MoviesActors values(4, 4);

insert into dbo.MoviesGenres values(1, 1)
insert into dbo.MoviesGenres values(2, 2)
insert into dbo.MoviesGenres values(3, 2)
insert into dbo.MoviesGenres values(3, 3)
insert into dbo.MoviesGenres values(3, 4)
insert into dbo.MoviesGenres values(4, 2)
insert into dbo.MoviesGenres values(4, 1)