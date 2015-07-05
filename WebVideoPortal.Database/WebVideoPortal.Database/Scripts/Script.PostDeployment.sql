MERGE INTO [dbo].[Template] AS Target
USING (VALUES
(1, 'AccountActivation', 'Web Viedo Portal - Confirm email address',
'<table class="body-wrap" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;background-color:#f6f6f6;width:100%;">
    <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
        <td style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;"></td>
        <td class="container" width="600" style="padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;display:block!important;max-width:600px!important;margin-top:0 !important;margin-bottom:0 !important;margin-right:auto !important;margin-left:auto !important;clear:both!important;">
            <div class="content" style="font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;max-width:600px;margin-top:0;margin-bottom:0;margin-right:auto;margin-left:auto;display:block;padding-top:20px;padding-bottom:20px;padding-right:20px;padding-left:20px;">
                <table cellpadding="0" cellspacing="0" class="main" width="100%" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;background-color:#fff;background-image:none;background-repeat:repeat;background-position:top left;background-attachment:scroll;border-width:1px;border-style:solid;border-color:#e9e9e9;border-radius:3px;">
                    <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                        <td class="content-wrap" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;padding-top:20px;padding-bottom:20px;padding-right:20px;padding-left:20px;">
                            <table cellpadding="0" cellspacing="0" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                                <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                                    <td style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;"><img class="img-responsive" src="http://ec2-54-200-65-232.us-west-2.compute.amazonaws.com/Images/header.jpg" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;max-width:100%;" /></td>
                                </tr>
                                <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                                    <td class="content-block" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;padding-top:0;padding-bottom:20px;padding-right:0;padding-left:0;">
                                        <h3 style="padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;box-sizing:border-box;font-family:''Helvetica Neue'',Helvetica,Arial,''Lucida Grande'',sans-serif;color:#000;margin-top:40px;margin-bottom:0;margin-right:0;margin-left:0;line-height:1.2;font-weight:400;font-size:18px;">Welcom to Web Video Portal</h3>
                                    </td>
                                </tr>
                                <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                                    <td class="content-block" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;padding-top:0;padding-bottom:20px;padding-right:0;padding-left:0;">Please confirm your email address.</td>
                                </tr>
                                <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                                    <td class="content-block aligncenter" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;padding-top:0;padding-bottom:20px;padding-right:0;padding-left:0;text-align:center;"><a class="btn-primary" href="[LINK]" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;text-decoration:none;color:#FFF;background-color:#1ab394;border-style:solid;border-color:#1ab394;border-width:5px 10px;line-height:2;font-weight:700;text-align:center;cursor:pointer;display:inline-block;border-radius:5px;text-transform:capitalize;">Confirm email address</a></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <div class="footer" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;width:100%;clear:both;color:#999;padding-top:20px;padding-bottom:20px;padding-right:20px;padding-left:20px;">
                    <table width="100%" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                        <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                            <td class="aligncenter content-block" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;vertical-align:top;padding-top:0;padding-bottom:20px;padding-right:0;padding-left:0;text-align:center;font-size:12px;">Follow <a href="#" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;text-decoration:underline;color:#999;font-size:12px;">Company</a> on Twitter.</td>
                        </tr>
                    </table>
                </div>
            </div>
        </td>
        <td style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;"></td>
    </tr>
</table>'),
(2, 'ResetPassword', 'Web Video Portal - Reset your password',
'<table class="body-wrap" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;background-color:#f6f6f6;width:100%;">
    <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
        <td style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;"></td>
        <td class="container" width="600" style="padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;display:block!important;max-width:600px!important;margin-top:0 !important;margin-bottom:0 !important;margin-right:auto !important;margin-left:auto !important;clear:both!important;">
            <div class="content" style="font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;max-width:600px;margin-top:0;margin-bottom:0;margin-right:auto;margin-left:auto;display:block;padding-top:20px;padding-bottom:20px;padding-right:20px;padding-left:20px;">
                <table cellpadding="0" cellspacing="0" class="main" width="100%" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;background-color:#fff;background-image:none;background-repeat:repeat;background-position:top left;background-attachment:scroll;border-width:1px;border-style:solid;border-color:#e9e9e9;border-radius:3px;">
                    <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                        <td class="content-wrap" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;padding-top:20px;padding-bottom:20px;padding-right:20px;padding-left:20px;">
                            <table cellpadding="0" cellspacing="0" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                                <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                                    <td style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;"><img class="img-responsive" src="http://ec2-54-200-65-232.us-west-2.compute.amazonaws.com/Images/header.jpg" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;max-width:100%;" /></td>
                                </tr>
                                <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                                    <td class="content-block" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;padding-top:0;padding-bottom:20px;padding-right:0;padding-left:0;">
                                        <h3 style="padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;box-sizing:border-box;font-family:''Helvetica Neue'',Helvetica,Arial,''Lucida Grande'',sans-serif;color:#000;margin-top:40px;margin-bottom:0;margin-right:0;margin-left:0;line-height:1.2;font-weight:400;font-size:18px;">Welcom to Web Video Portal</h3>
                                    </td>
                                </tr>
                                <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                                    <td class="content-block" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;padding-top:0;padding-bottom:20px;padding-right:0;padding-left:0;">Please click the button below to reset your password.</td>
                                </tr>
                                <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                                    <td class="content-block aligncenter" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;padding-top:0;padding-bottom:20px;padding-right:0;padding-left:0;text-align:center;"><a class="btn-primary" href="[LINK]" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;text-decoration:none;color:#FFF;background-color:#1ab394;border-style:solid;border-color:#1ab394;border-width:5px 10px;line-height:2;font-weight:700;text-align:center;cursor:pointer;display:inline-block;border-radius:5px;text-transform:capitalize;">Reset password</a></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <div class="footer" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;width:100%;clear:both;color:#999;padding-top:20px;padding-bottom:20px;padding-right:20px;padding-left:20px;">
                    <table width="100%" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                        <tr style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;">
                            <td class="aligncenter content-block" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;vertical-align:top;padding-top:0;padding-bottom:20px;padding-right:0;padding-left:0;text-align:center;font-size:12px;">Follow <a href="#" style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;text-decoration:underline;color:#999;font-size:12px;">Company</a> on Twitter.</td>
                        </tr>
                    </table>
                </div>
            </div>
        </td>
        <td style="margin-top:0;margin-bottom:0;margin-right:0;margin-left:0;padding-top:0;padding-bottom:0;padding-right:0;padding-left:0;font-family:''Helvetica Neue'',Helvetica,Helvetica,Arial,sans-serif;box-sizing:border-box;font-size:14px;vertical-align:top;"></td>
    </tr>
</table>')
)
AS Source (Id, [Name], [Subject], [Body]) 
ON Target.Id = Source.Id
-- update matched rows 
WHEN MATCHED THEN 
	UPDATE SET	[Name] = Source.[Name],
				[Subject] = Source.[Subject],
				[Body] = Source.[Body]
-- insert new rows 
WHEN NOT MATCHED BY TARGET THEN 
	INSERT (Id, [Name], [Subject], [Body]) 
	VALUES (Id, [Name], [Subject], [Body]) 
-- delete rows that are in the target but not the source 
WHEN NOT MATCHED BY SOURCE THEN 
	DELETE;
GO