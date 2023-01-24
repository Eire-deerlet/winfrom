USE [BookDB]
GO

/****** Object:  Table [dbo].[b_book]    Script Date: 2023/01/24 19:36:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[b_book](
	[id] [int] NOT NULL,
	[name] [varchar](10) NOT NULL,
	[author] [varchar](10) NOT NULL,
	[publishing_house] [varchar](10) NOT NULL,
	[stock] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[b_book] ADD  DEFAULT ('') FOR [id]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'b_book', @level2type=N'COLUMN',@level2name=N'name'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'作者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'b_book', @level2type=N'COLUMN',@level2name=N'author'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出版社' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'b_book', @level2type=N'COLUMN',@level2name=N'publishing_house'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'库存' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'b_book', @level2type=N'COLUMN',@level2name=N'stock'
GO

