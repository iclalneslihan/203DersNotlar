/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ID]
      ,[ad]
      ,[soyad]
      ,[telefon]
      ,[tc]
  FROM [DB_Test].[dbo].[tb_ogrenci]

  CREATE TABLE [dbo].[tb_ogrenci](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NOT NULL,
	[telefon] [nchar](15) NOT NULL,
	[tc] [nchar](11) NULL,
 CONSTRAINT [PK_tb_ogrenci] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO