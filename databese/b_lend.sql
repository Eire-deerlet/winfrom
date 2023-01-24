USE [BookDB]
GO

/****** Object:  Table [dbo].[b_lend]    Script Date: 2023/01/24 19:36:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[b_lend](
	[lend_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [varchar](20) NOT NULL,
	[book_id] [varchar](30) NOT NULL,
	[date_time] [datetime] NOT NULL,
	[book_name] [varchar](30) NULL,
 CONSTRAINT [PK_b_lend] PRIMARY KEY CLUSTERED 
(
	[lend_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

