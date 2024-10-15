SET IDENTITY_INSERT [dbo].[Observations] ON

INSERT INTO [dbo].[Observations] ([id], [patientId], [notes], [date])
VALUES
(1, 1, 'Routine check-up, no issues.', '2023-02-15'),
(2, 2, 'Patient has allergies to penicillin.', '2023-02-20'),
(3, 3, 'Blood pressure slightly elevated.', '2023-03-01'),
(4, 4, 'Diabetes management ongoing.', '2023-02-10'),
(5, 5, 'Allergy symptoms observed.', '2023-02-25'),
(6, 6, 'Post-surgery recovery monitored.', '2023-03-10'),
(7, 7, 'Healthy, regular exercise.', '2023-02-05'),
(8, 8, 'Regular check-up, no major concerns.', '2023-02-01'),
(9, 9, 'Counseling sessions ongoing.', '2023-02-20'),
(10, 10, 'Injury recovery monitored.', '2023-02-25'),
(11, 11, 'Injury recovery monitored.', '2023-02-25'),
(12, 12, 'Experiencing vivid dreams due to insomnia.', '2023-05-10'),
(13, 13, 'Asthma well controlled, but allergies worsening.', '2023-08-10'),
(14, 14, 'Blood pressure stabilized.', '2023-09-25'),
(15, 15, 'Muscle tension reduced, but high stress remains.', '2023-02-14');

SET IDENTITY_INSERT [dbo].[Observations] OFF
