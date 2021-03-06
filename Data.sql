USE [ProductStoreManagement]
GO
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([Id], [DisplayName]) VALUES (1, N'Kg')
INSERT [dbo].[Unit] ([Id], [DisplayName]) VALUES (2, N'Box')
INSERT [dbo].[Unit] ([Id], [DisplayName]) VALUES (3, N'Pack')
SET IDENTITY_INSERT [dbo].[Unit] OFF
SET IDENTITY_INSERT [dbo].[Suplier] ON 

INSERT [dbo].[Suplier] ([Id], [DisplayName], [Address], [Phone], [Email], [MoreInfo], [ContractDate]) VALUES (1, N'sup1', N'ha noi', N'1234567687', N'sup1@gmail.com', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Suplier] OFF
INSERT [dbo].[Object] ([Id], [DisplayName], [IdUnit], [QRCode], [IdSuplier], [BarCode]) VALUES (N'1', N'Cement', 3, NULL, 1, NULL)
INSERT [dbo].[Object] ([Id], [DisplayName], [IdUnit], [QRCode], [IdSuplier], [BarCode]) VALUES (N'2', N'Stone', 1, NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [DisplayName], [Address], [Phone], [Email], [MoreInfo], [ContractDate]) VALUES (1, N'Cus1', N'Ha noi', N'1234545', N'cus1@gmail.com', NULL, NULL)
INSERT [dbo].[Customer] ([Id], [DisplayName], [Address], [Phone], [Email], [MoreInfo], [ContractDate]) VALUES (2, N'Cus2', N'HCM', N'43434434', N'cus2@gmail.com', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Customer] OFF
INSERT [dbo].[Output] ([Id], [DateOutput]) VALUES (N'1', CAST(0x00009E1E00F65D24 AS DateTime))
INSERT [dbo].[Output] ([Id], [DateOutput]) VALUES (N'2', CAST(0x00009E1E00F65D24 AS DateTime))
INSERT [dbo].[OutputInfo] ([Id], [IdObject], [IdOutputInfo], [IdCustomer], [Count], [Status]) VALUES (N'1', N'1', N'1', 1, 10, NULL)
INSERT [dbo].[OutputInfo] ([Id], [IdObject], [IdOutputInfo], [IdCustomer], [Count], [Status]) VALUES (N'2', N'2', N'1', 1, 200, NULL)
INSERT [dbo].[Input] ([Id], [DateInput]) VALUES (N'1', CAST(0x00009B4400F65D24 AS DateTime))
INSERT [dbo].[Input] ([Id], [DateInput]) VALUES (N'2', CAST(0x00009CB100F65D24 AS DateTime))
INSERT [dbo].[InputInfo] ([Id], [IdObject], [IdInput], [Count], [InputPrice], [OutputPrice], [Status]) VALUES (N'1', N'1', N'1', 50, 20000, 30000, NULL)
INSERT [dbo].[InputInfo] ([Id], [IdObject], [IdInput], [Count], [InputPrice], [OutputPrice], [Status]) VALUES (N'2', N'2', N'1', 90, 30000, 50000, NULL)
INSERT [dbo].[InputInfo] ([Id], [IdObject], [IdInput], [Count], [InputPrice], [OutputPrice], [Status]) VALUES (N'3', N'1', N'1', 10, 15000, 45000, NULL)
SET IDENTITY_INSERT [dbo].[UserRole] ON 

INSERT [dbo].[UserRole] ([Id], [DisplayName]) VALUES (1, N'Admin')
INSERT [dbo].[UserRole] ([Id], [DisplayName]) VALUES (2, N'staff')
SET IDENTITY_INSERT [dbo].[UserRole] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [DisplayName], [UserName], [Password], [IdRole]) VALUES (1, N'duc anh', N'admin', N'pass', 1)
INSERT [dbo].[Users] ([Id], [DisplayName], [UserName], [Password], [IdRole]) VALUES (2, N'staff', N'staff', N'pass', 2)
SET IDENTITY_INSERT [dbo].[Users] OFF
