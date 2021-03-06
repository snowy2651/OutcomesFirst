USE [OutcomesFirst]
GO
/****** Object:  StoredProcedure [dbo].[Rep_MonthlyReferralStatus]    Script Date: 22/10/2019 16:13:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jan
-- Create date: 27/07/2019
-- Description: Stored procedure to provide dataset for Monthly Referral Status Report
-- =============================================
ALTER PROCEDURE [dbo].[Rep_MonthlyReferralStatus]

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
	select StatusId as ID ,StatusName as reasonName from Status where statusid > 4
	)
 
	Select cte.ServiceId,cte.ServiceName, st.StatusName, COUNT(sub.SubmissionId) as count 
	
	from services_cte cte
	
	left outer join Submission sub on cte.ServiceId = sub.SubmissionServiceId
	left outer join Status st on st.StatusId = sub.SubmissionStatusId  and statusid > 4

	group by cte.ServiceId,cte.ServiceName, st.StatusName


	END
