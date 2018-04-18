
CREATE TABLE [dbo].[RaspberrySensorData](
	[DeviceId] [nvarchar](50) NOT NULL,
	[SendDateTime] [datetime] NOT NULL,
	[Temperature] [float] NOT NULL,
	[Humidity] [float] NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Config](
	[ConfigName] [nvarchar](150) NOT NULL,
	[ConfigValue] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Config] PRIMARY KEY CLUSTERED 
(
	[ConfigName] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

