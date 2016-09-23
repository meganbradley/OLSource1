---
title: "Security Considerations for LightSwitch"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - ls.SecurityConsiderations
  - ls.AzureSecuritySettingsBrowserClient
  - ls.AzureSecuritySettings
  - ls.AzureSecuritySettingsDesktopClient
  - LS.SecurityConsiderations
helpviewer_keywords: 
  - security [Visual Studio LightSwitch]
ms.assetid: c7bdc720-5fb5-4535-9bfd-05d526f5a24c
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Security Considerations for LightSwitch
Most business applications have security requirements. For example, you may want to limit which employees have access to an application, or to screens in an application, and which users can view or update certain data.  [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] provides a built-in authentication and authorization model that can help implement security in your application.  
  
## Authentication and Authorization  
 Authentication is a mechanism to verify who a user is. For example, when you log on to Windows, your user name and password authenticate that you are really you. Authorization is a mechanism to define what you can – or cannot – do. For example, an employee might be able to view their own payroll information, but they most likely would not be authorized to give themselves a pay raise.  
  
 In [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)], authentication is handled by a logon screen that is used to identify the user. Once a user is authenticated, roles and permissions determine what that user is authorized to do in the application.  
  
### Enabling Authentication  
 Authentication in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] is disabled by default; you enable it on the **Access Control** tab of the Application Designer. Both Windows authentication and Forms authentication are supported. Windows authentication uses a user’s Windows logon information to identify the user. With Forms authentication, an application administrator creates the user identities and passwords.  
  
 When choosing Windows authentication, you can also choose whether specific users or all Windows users have access to the application. If you choose all users, any user who has a valid Windows logon ID will be able to access the application, but they will only be authorized for the minimum permissions. You can still assign roles and permissions to individual users as needed.  
  
### Permissions, Users and Roles  
 Authorization in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] is accomplished by defining permissions, users and roles. Permissions are created by the developer on the **Access Control** tab of the Application Designer and the effect of those permissions is designed by writing code. For example, you might create a ViewSales permission to authorize users to view a Sales screen. In the `CanView` method for the screen, you would write code that only allows the screen to be displayed if the current user has been granted permission to view it. In addition to setting permissions to view screens, you can also create permissions to restrict access to individual controls on a screen, to data entities or fields of an entity, to queries and more.  
  
 Roles are created by the application administrator after the application has been deployed. A role contains one or more permissions. For example, the administrator might define a Sales role and assign the ViewSales permission to that role. The application administrator also adds users and assigns roles to users. For example, if Bob is in the sales department, the administrator might add Bob as a user by adding his authentication information, and then assign him to the Sales role. When the application is run, the code would evaluate Bob’s user information, see that he is a member of the Sales role, and display the menu item to display the Sales screen.  
  
 Every application has a default permission, the **SecurityAdministration** permission. This permission grants access to the **Users** and **Roles** administrative screens that are used by the application administrator. When publishing an application for the first time, you can provide authentication information for the person who will be the default application administrator. When that person first runs the application, they will be able to see the **Users** and **Roles** screens and define users and roles.  
  
### Testing Authorization  
 When testing an application you will want to make sure that any permissions that you defined work as expected. You do this by enabling debug permissions on the **Access Control** tab of the Application Designer. For example, if you defined a ViewSales permission, you could check the **Granted for Debug** check box for that permission. When you debug the application, you can verify that you can view the Sales screen – you are running as a user who has the ViewSales permission. You can set any combination of permissions in order to emulate the permissions that might be assigned to a given role.  
  
> [!NOTE]
>  If you enable the **SecurityAdministration** permission for debugging, you can view the administrative **Users** and **Roles** screens while you are debugging. While you can enter users and roles in these screens, the users and roles will not be deployed with the application and cannot be used for debugging permissions.  
  
### Secure Connections  
 For three-tier client applications that are based on [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] and hosted on a server that’s running Internet Information Services (IIS), communication between the application and the server uses HTTP protocol instead of the HTTPS protocol, which is more secure. This requirement can leave your application vulnerable to attackers. Secure Sockets Layer (SSL) encryption helps to protect confidential or personal information that’s sent between a client application and a server. When SSL is enabled, remote client applications access the server by using URLs that start with https://. We recommend that you configure SSL for any site that hosts an application that’s based on [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)]. For more information, see [Configuring Secure Sockets Layer in IIS 7](http://go.microsoft.com/fwlink/?LinkId=210432).  
  
##### To enable SSL  
  
1.  On the menu bar, choose **Build**, **Publish**.  
  
2.  In the **Publish Application Wizard**, choose the **Security Settings** tab.  
  
3.  In the **Require Secure Connection (HTTPS)** section, choose the **On** option button.  
  
    > [!NOTE]
    >  When this setting is on, the website must be properly configured to use HTTPS.  
  
 For three-tier applications that use SQL Server for the data tier, communication between IIS and the database is also potentially vulnerable. We recommend that you configure SSL for any database that’s accessed by an application that’s based on [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)]. For more information, see [Encrypting Connections to SQL Server](http://go.microsoft.com/fwlink/?LinkId=151362).  
  
### Security and Version Control  
 When you work with a [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] project that's under version control, a connection string in the web.config file may contain the user name and password for the most recent developer of the project. This information would then be available to the next developer who checks the project out.  
  
 This issue doesn’t apply to a published application; connection string information from the Publish Wizard isn’t saved in version control. By using a test database instead of a production database at design time, you can prevent unauthorized users from accessing production data.  
  
### Additional Security Considerations  
 In addition to authentication, there are other aspects of security that you should consider. Even if your application does not deal with sensitive business data, other information such as passwords could be at risk of exposure.  
  
 Security is also a consideration when you write code that accesses a server. For example, you might write query code to filter employee data so employees can only see their own data:  
  
```vb  
Private Partial Sub Employees_All_PreprocessQuery(ByRef query As IQueryable(Of Application43.Employee))  
    query = From item In query Where item.EmpName = Me.Application.User.Nameitem  
End Sub  
  
```  
  
```c#  
partial void Employees_All_PreprocessQuery(ref IQueryable<Application43.Employee> query)  
{  
    query = from item in query where item.EmpName == this.Application.User.Name select item;  
}  
  
```  
  
 While this works to display the data, if the user attempts to update or delete the data and a concurrency exception occurs, data for other employees could be exposed in the error information that is returned from the server. To avoid this, you would want to write additional code in the Updating and Deleting methods to make sure that the employee can only see their own data:  
  
```  
Dim user As String = Me.Application.User.Name  
If Me.DataWorkspace.ApplicationData.Employees.Where(Function(e) e.Id = entity.Id AndAlso e.EmpName = user).Execute().Count() = 0 Then  
    Throw New DataServiceOperationException("Permission error: Cannot modify a record you don't have access to.")  
End If  
```  
  
```  
string user = this.Application.User.Name;  
if (this.DataWorkspace.ApplicationData.Employees.Where(e => e.Id == entity.Id && e.EmpName == user).Execute().Count() == 0)  
{  
throw new DataServiceOperationException("Permission error: Cannot modify a record you don't have access to.");  
}  
  
```  
  
 To learn more about secure coding practices in general, see [Creating Secure Applications](http://go.microsoft.com/fwlink/?LinkId=210474).  
  
## See Also  
 [How to: Create a Role-based Application](../vs140/how-to--enable-authentication-in-a-silverlight-client-app.md)   
 [Deployment: Distributing and Maintaining Your Application](../vs140/deployment--distributing-and-maintaining-your-application.md)   
 [Debugging: Finding and Fixing Errors](../vs140/debugging--finding-and-fixing-errors.md)