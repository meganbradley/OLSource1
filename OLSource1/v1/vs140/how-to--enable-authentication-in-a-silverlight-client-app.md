---
title: "How to: Enable Authentication in a Silverlight Client App"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ls.AuthenticationWithoutWebDeploymentProvider"
helpviewer_keywords: 
  - "role-based application [Visual Studio LightSwitch]"
  - "users and roles [Visual Studio LightSwitch]"
  - "permissions [Visual Studio LightSwitch]"
  - "authentication [Visual Studio LightSwitch]"
  - "roles [Visual Studio LightSwitch]"
  - "debug permissions [Visual Studio LightSwitch]"
  - "authorization [Visual Studio LightSwitch]"
ms.assetid: 068a4c41-0da0-4d04-aa15-455d1e31a5fb
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Enable Authentication in a Silverlight Client App
In LightSwitch, you can make your application more secure by preventing unauthorized users from reading, changing, or deleting data. If you implement authentication and authorization, users must prove their identities before they can access the application.  
  
> [!NOTE]
>  The process for setting permissions differs for HTML clients – see [How to: Enable Authentication in an HTML Client App](../vs140/how-to--enable-authentication-in-an-html-client-app.md). LightSwitch apps that have been enabled for SharePoint use SharePoint authentication for access control.  
  
 If you have many users, you can also manage access more easily by creating user roles that have various levels of access to particular screens and data and then assigning each user to the appropriate role.  
  
 For example, a payroll application could allow employees to view, but not change, their payroll information. However, a payroll supervisor could be given permission to view and change the employee information. The employees would be assigned to the Employee role and the supervisor would be assigned to the Supervisor role.  
  
 You can also administer permissions more easily by adding users to security groups in Active Directory and then assigning permissions to those groups. Because membership and permissions are inherited, you can grant and deny permissions for not only a group but also all of its subgroups by making a single change. For example, you can add *Bob* to the *Sales* group in Active Directory. If *Sales* is a subgroup of *Marketing*, any permission that you grant to *Marketing* would also be granted to *Bob*.  
  
-   [Authentication](../vs140/how-to--enable-authentication-in-a-silverlight-client-app.md#auth)  
  
-   [Permissions](../vs140/how-to--enable-authentication-in-a-silverlight-client-app.md#perms)  
  
-   [Publishing and Administration](../vs140/how-to--enable-authentication-in-a-silverlight-client-app.md#admin)  
  
##  \<a name="auth">\</a> Authentication  
 The first step in securing your application is to enable authentication. You can use either Forms authentication or Windows authentication. Forms authentication is managed by the application itself, and a user must supply a username and a password to access the application. In Windows authentication, the credentials that were used to log on to the computer where the application is run are used to authenticate the application user, and no additional username or password is required. In both cases, an application administrator maintains a list of authorized users; in Forms authentication, the administrator also maintains encrypted passwords.  
  
#### To enable authentication  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Properties** node, and then choose **Open**.  
  
2.  In the **Application Designer**, choose the **Access Control** tab.  
  
3.  In the **Select the type of authentication to use:** list, choose either **Use Windows authentication** or **Use Forms authentication**.  
  
     If you chose **Use Windows authentication**, choose either the **Allow only users specified in the Users screen of your application** option button or the **Allow any authenticated Windows user** option button.  
  
     The application will now require users to provide credentials in order to access the application.  
  
#### To disable authentication  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Properties** node, and then choose **Open**.  
  
2.  In the **Application Designer**, choose the **Access Control** tab.  
  
3.  In the **Select the type of authentication to use:** list, choose **Do not enable authentication**.  
  
     The application will not require users to provide credentials in order to access the application, and any user can access every part of the application.  
  
##  \<a name="perms">\</a> Permissions  
 The next step in securing your application is to create permissions. You can define permissions for screens, commands, data entities, and queries. First, define a permission object in the **Application Designer**. Then, you can reference the object in code, in one of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> methods such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>*\<ScreenName>* or *\<QueryName>*<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Code in these methods typically checks whether the current user or role has the permission, and then displays the form or executes the query only if permission is validated.  
  
 To test your code, run the application as both a user who has the permission and as a user who does not.  By setting debug permissions, you can impersonate a user when you test or debug the application.  
  
#### To create a permission  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Properties** node, and then choose **Open**.  
  
2.  In the **Application Designer**, choose the **Access Control** tab.  
  
3.  In the **Define permissions or select permissions to use for debugging** grid, in the **Name** column, choose **\<Add New Permission>**, and then enter a programmatic name for the permission.  
  
     The name must begin with an alphabetical character, and it can only contain alphabetical or numeric characters, or underscores.  
  
4.  In the **Display Name** column, enter the name of the permission as you want it to appear in the screen that the application administrator will use to assign roles.  
  
5.  In the **Description** column, enter a description of the permission.  
  
#### To write code to set permissions for a screen  
  
1.  In **Solution Explorer**, open the shortcut menu for a screen node, and then choose **Open**.  
  
     The **Screen Designer** for that screen opens.  
  
2.  In the **Write Code** list, choose <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>*ScreenName*, where *ScreenName* is the name of the selected screen.  
  
3.  In the **Code Editor**, enter the following code in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>*ScreenName* method:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     This code will be evaluated every time that the application starts.  
  
    > [!NOTE]
    >  Notice that the example code checks for a permission named Can_View_Products. Replace the name of a permission that you have defined in your application.  
  
#### To write code to set permissions for a command  
  
1.  In **Solution Explorer**, open the shortcut menu for a screen node, and then choose **Open**.  
  
     The **Screen Designer** for that screen opens.  
  
2.  In the **Screen Content Tree** pane, expand a command node, and then choose the command for which you want to write code.  
  
3.  Open the shortcut menu for the command, and then choose *ButtonName*<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, where *ButtonName* is the name of the command that you chose.  
  
4.  In the **Code Editor**, enter the code that you want in the *ButtonName*<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method.  
  
    > [!NOTE]
    >  For an example of code, see "To write code to set permissions for a screen" earlier in this topic.  
  
#### To write code to set permissions for an entity  
  
1.  In **Solution Explorer**, open the shortcut menu for an entity node, and then choose **Open**.  
  
     The **Entity Designer** for that entity opens.  
  
2.  In the Entity Designer, on the **Perspective** bar, choose **Server**.  
  
3.  In the **Write Code** list, choose an *EntityName*<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>*Operation* method, where *EntityName* is the name of the entity, and *Operation* is the name of the operation for which you want to write code.  
  
    > [!NOTE]
    >  The available methods vary by context. Some examples are <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
4.  In the **Code Editor**, enter the code that you want in the *EntityName*<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>*Operation* method.  
  
    > [!NOTE]
    >  For an example of code, see "To write code to set permissions for a screen" earlier in this topic.  
  
#### To write code to set permissions for a query  
  
1.  In **Solution Explorer**, open the shortcut menu for a query node, and then choose **Open**.  
  
     The **Query Designer** for that query opens.  
  
2.  In the **Write Code** list, choose one of the *QueryName*<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> methods, where *QueryName* is the name of the query.  
  
3.  In the **Code Editor**, enter the code that you want in the *QueryName*<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method.  
  
    > [!NOTE]
    >  For an example of code, see "To write code to set permissions for a screen" earlier in this topic.  
  
#### To enable permissions for debugging  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Properties** node, and then choose **Open**.  
  
2.  In the **Application Designer**, choose the **Access Control** tab.  
  
3.  In the **Define permissions or select permissions to use for debugging** grid, choose the permission that you want to enable for debugging, and then select the **Granted for debug** check box.  
  
##  \<a name="admin">\</a> Publishing and Administration  
 The final step in enabling authentication is to define a default administrator for the application during publishing. Once published, the default administrator must log in and define users, roles and permissions.  
  
#### To define an administrator  
  
-   Follow the steps in [Administering a LightSwitch Application](../vs140/administering-a-lightswitch-application.md).  
  
    > [!IMPORTANT]
    >  If authentication is enabled and you haven’t defined a default administrator, you won’t be able to access the published application.  
  
## See Also  
 [Silverlight Client Screens for LightSwitch Apps](../vs140/silverlight-client-screens-for-lightswitch-apps.md)   
 [Administering a LightSwitch Application](../vs140/administering-a-lightswitch-application.md)   
 [How to: Enable Authentication in an HTML Client App](../vs140/how-to--enable-authentication-in-an-html-client-app.md)   
 [Creating Secure Applications](../vs140/security-considerations-for-lightswitch.md)   
 [Active Directory Security Groups](http://go.microsoft.com/fwlink/?LinkID=186402)