USE [OutcomesFirst]
GO
/****** Object:  StoredProcedure [dbo].[Rep_MonthlyPlacementsStatus]    Script Date: 22/10/2019 16:12:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jan
-- Create date: 27/07/2019
-- Description: Stored procedure to provide dataset for Monthly Referral Status Report
-- =============================================
ALTER PROCEDURE [dbo].[Rep_MonthlyPlacementsStatus]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	with services_cte AS
	(
	Select ServiceId, ServiceName from Service
	),

	reasons_cte AS
	(
	select StatusId as ID ,StatusName as reasonName from Status where StatusID in(1,3,4)
	)

 
	Select cte.ServiceId,cte.ServiceName, st.StatusName, st.StatusOffersActivityReportOrder, COUNT(sub.SubmissionId) as count 
	
	from services_cte cte
	
	left outer join Submission sub on cte.ServiceId = sub.SubmissionServiceId
	left outer join Status st on st.StatusId = sub.SubmissionStatusId and StatusID in(1,3,4)
	group by cte.ServiceId,cte.ServiceName, st.StatusName,st.StatusOffersActivityReportOrder 


	END
