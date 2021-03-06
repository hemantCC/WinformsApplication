USE [DbAssignment]
GO
/****** Object:  StoredProcedure [dbo].[usp_ChangePassword]    Script Date: 12/8/2020 4:45:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- EXEC usp_ChangePassword 'hemant' , 'hemant' , 'hemant2'
-- =============================================
ALTER PROCEDURE [dbo].[usp_ChangePassword] 
	-- Add the parameters for the stored procedure here
	@Username nvarchar(50),
	@CurrentPassword nvarchar(max),
	@NewPassword nvarchar(max),
	@Result int OUTPUT 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @@PasswordIsCorrect bit = 0
	--DECLARE @@result tinyint = 0


	IF EXISTS(SELECT * FROM TblUser WHERE UserName = @Username AND [Password] = @CurrentPassword)
       SET @@PasswordIsCorrect = 1
	ELSE
       set @@PasswordIsCorrect = 0


	IF (@@PasswordIsCorrect = 1)
		BEGIN
			UPDATE TblUser SET [Password] = @NewPassword WHERE Username = @Username
			SET @Result = 1
		END
	ELSE
		SET @Result = 0

		SELECT @Result as Result
END

