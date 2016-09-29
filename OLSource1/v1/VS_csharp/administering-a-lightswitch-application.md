---
title: "Administering a LightSwitch Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 4ae475d3-a909-45c6-b167-777cd93cdb8f
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Administering a LightSwitch Application
When authentication is enabled for a LightSwitch application, two administrative screens are added to the application. The **Users** and **Roles** screens allow an administrator to add and remove users, create groups of users known as roles, and grant permissions to users and roles.  
  
 When you publish for the first time, you must provide authentication information for a default administrator. Once published, the default administrator must log in and define users, roles, and permissions before anyone else can access the application.  
  
> [!NOTE]
>  The **Users** and **Roles** screens are Silverlight-based. For an HTML client application you need to add a Silverlight client to the solution – see [Administration](../VS_csharp/how-to--enable-authentication-in-an-html-client-app.md#admin). LightSwitch apps that have been enabled for SharePoint use SharePoint authentication for access control and don’t use the **Users** and **Roles** screens.  
  
-   [Defining a Default Administrator](../VS_csharp/administering-a-lightswitch-application.md#publish)  
  
-   [Defining Roles and Users](../VS_csharp/administering-a-lightswitch-application.md#admin)  
  
##  <a name="publish"></a> Defining a Default Administrator  
 When you help secure your application, the final step is to publish it. When you publish for the first time, you must provide authentication information for a default administrator. When you publish again, you don’t have to repeat this step.  
  
#### To provide authentication information when you publish an application  
  
1.  In the **LightSwitch Publish Application Wizard**, choose the **Security Settings** page, and then choose the **Yes, create an Application Administrator** option button.  
  
    > [!NOTE]
    >  You must perform the remaining steps only if you’re publishing directly to a server. If you’re creating a package, you will be prompted to add an administrative account when you deploy the package.  
  
2.  In the **User Name** text box, enter a username.  
  
     If you’re using Windows authentication, you must specify a valid Windows logon name that has the form *Domain*\\*Username*.  
  
    > [!TIP]
    >  You can also assign a security group in Active Directory as the default administrator.  
  
3.  In the **Full Name** text box, enter the full name of the user or group that will be the default administrator.  
  
4.  In the **Password** text box, enter a password.  
  
    > [!NOTE]
    >  If you’re using Windows authentication, the **Full Name**, **Password** and **Confirm Password** fields don’t appear.  
  
5.  In the **Confirm Password** text box, enter the password again.  
  
     Remember the username and password because you'll need to specify them the first time that you run the application.  
  
6.  Finish publishing the application.  
  
##  <a name="admin"></a> Defining Roles and Users  
 If you're the application administrator, you must run the published application the first time. You then use the **Roles** screen and the **Users** screen to define roles, assign permissions to the roles, and assign roles to users or groups of users. You can access these screens in the running application at design time or when it’s deployed. At design time, set a debug permission to access the screens. In a deployed application, anyone who has been granted the Security Administration permission can access the screens.  
  
> [!NOTE]
>  To log on, you must use the username and password that you specified when you published the application.  
  
#### To define a role and assign permissions  
  
1.  In a published application that’s running under administrator permissions, on the menu bar, choose **Roles**.  
  
2.  In the **Roles** pane, choose the **+…** (Add) button.  
  
3.  In the **Add New Role** dialog box, enter a name for the role, and then choose the **OK** button.  
  
4.  In the **Permissions** pane, choose the **+…** (Add) button.  
  
     A new row appears in the **Permissions** grid.  
  
5.  In the first column of the grid, choose a permission in the list.  
  
     The list contains all of the available permissions for your application. You can add as many permissions as you need, but you must choose the **+…** (Add) button for each one to add it.  
  
6.  On the application toolbar, choose the **Save** button to save your changes.  
  
#### To add a user or group of users  
  
1.  On the menu bar, choose **Users** to display the **Users** screen.  
  
2.  In the **Users and Groups** pane, choose the **+…** (Add) button.  
  
3.  In the **Name** text box, enter a username.  
  
     If you’re using Windows authentication, you must specify a valid username in the form of an alias (terry), a domain and an alias (example\terry), an alias and a domain (terry@example.com), or a fully qualified domain name and an alias (northamerica.corp.example.com\terry). The entire string must contain fewer than than 256 characters. You can also specify the name of a security group in Active Directory. If you’re using Forms authentication, the username must be unique and contain fewer than 256 characters.  
  
4.  In the **Full Name** text box, enter the user’s full name.  
  
     The information in the **Full Name** field is used only for display purposes.  
  
    > [!NOTE]
    >  For Windows authentication, the **Full Name** field is automatically populated based on the username and can’t be edited.  
  
5.  In the **Password** text box, enter a password.  
  
    > [!NOTE]
    >  The **Password** and **Confirm Password** fields don’t appear if you’re using Windows authentication.  
  
6.  In the **Confirm Password** text box, enter the same password.  
  
7.  In the **Roles** pane, choose the **Add** button, and then choose a role in the **Roles** list.  
  
     You can assign a user to multiple roles by repeating this step for each role.  
  
8.  On the application toolbar, choose the **Save** button to save the changes.  
  
#### To remove a user or group of users  
  
1.  On the menu bar, choose **Users** to display the **Users** screen.  
  
2.  In the **Users and Groups** pane, choose the account that you want to remove, and then choose the **X** (delete) button.  
  
    > [!NOTE]
    >  If a user is logged on with an account that’s deleted, the user can no longer save or access data on the server. If the user tries to access data from the server, an Access Denied message appears.  
  
    > [!NOTE]
    >  If a group account is deleted, any user whose role was inherited from that group will lose permissions for that role.  
  
3.  On the application toolbar, choose the **Save** button to save the changes.  
  
## See Also  
 [How to: Enable Authentication in an HTML Client App](../VS_csharp/how-to--enable-authentication-in-an-html-client-app.md)   
 [How to: Enable Authentication in an Silverlight Client App](../VS_csharp/how-to--enable-authentication-in-a-silverlight-client-app.md)