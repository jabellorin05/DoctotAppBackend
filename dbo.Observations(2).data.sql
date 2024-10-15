SET IDENTITY_INSERT [dbo].[Observations] ON
INSERT INTO [dbo].[Observations] ([id], [PatientId], [Notes], [Date]) VALUES (1, 123456, 'Routine check-up, no issues.', '2023-02-15')

SET IDENTITY_INSERT [dbo].[Observations] OFF
