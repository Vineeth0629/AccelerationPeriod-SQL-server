USE [CompanyDetails]
GO

/****** Object:  StoredProcedure [dbo].[update_employee]    Script Date: 10/27/2022 1:35:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[update_employee](@age int,@id int)
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update employee set empage=@age where empid=@id
    -- Insert statements for procedure here
	
END
GO

