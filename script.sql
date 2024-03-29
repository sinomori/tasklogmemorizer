USE [tasklogmemorizer]
GO
/****** Object:  Table [db_owner].[UserSetting]    Script Date: 2019/07/12 19:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [db_owner].[UserSetting](
	[user_id] [nvarchar](50) NOT NULL,
	[btn_index] [int] NOT NULL,
	[task_category_code] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskCategory]    Script Date: 2019/07/12 19:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskCategory](
	[code] [int] NOT NULL,
	[task_type_code] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[memo] [text] NULL,
 CONSTRAINT [PK_TaskCategory] PRIMARY KEY CLUSTERED 
(
	[code] ASC,
	[task_type_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskRecord]    Script Date: 2019/07/12 19:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskRecord](
	[user_id] [nvarchar](50) NOT NULL,
	[logged_time] [datetime] NOT NULL,
	[time_type_code] [int] NOT NULL,
	[task_category_code] [int] NOT NULL,
	[memo] [text] NULL,
 CONSTRAINT [PK_TaskRecord] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC,
	[logged_time] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskType]    Script Date: 2019/07/12 19:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskType](
	[code] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[memo] [text] NULL,
 CONSTRAINT [PK_TaskType_1] PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeType]    Script Date: 2019/07/12 19:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeType](
	[code] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TimeType] PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
