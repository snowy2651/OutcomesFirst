USE [OutcomesFirst]
GO
/****** Object:  StoredProcedure [dbo].[Rep_Occupancy]    Script Date: 22/10/2019 16:30:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================


ALTER PROCEDURE [dbo].[Rep_Occupancy]
--exec Rep_Occupancy 
	-- Add the parameters for the stored procedure here
	--<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	--<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT o.PlacementFirstName,
	o.PlacementLastName,
	g.GenderName as PlacementGenderId,
	case when PlacementType = 1 then 'Education & Residential'
	        when PlacementType = 2 then 'Education only'
			when PlacementType = 3 then 'Residential only'
			else '' end as PlacementType,
	o.PlacementDateStartedWithGroup,
	o.PlacementPlacementStartDate,
	o.PlacementDOB,
	o.PlacementLocalAuthorityId,
	o.PlacementFramework,
	o.PlacementLengthOfStayWithPlacement,
	o.PlacementNotes
	PlacementLengthOfStayWithGroup,
	serv.ServiceName,
	serv.ServicePlaces,
	r.RegionName,
	o.PlacementServiceTransition,
	o.PlacementWeeklyFee,
	o.PlacementNotes
	 from Placement o
	  left outer join Service serv on o.PlacementServiceId = serv.ServiceId
	  left outer join Gender g on o.PlacementGenderId = g.GenderId
	  left outer join LocalAuthority LA on o.PlacementLocalAuthorityId = LA.LocalAuthorityId
	  left outer join LeavingReason LR on o.PlacementLeavingReasonId = LR.LeavingReasonId
	  left outer join Region r on r.RegionId = la.LocalAuthorityId
	  where o.PlacementLeaveDate is null

END
