---
title: "How to: Deploy a Two-tier LightSwitch Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "deploying a 2-tier application [Visual Studio LightSwitch]"
  - "deployment [Visual Studio LightSwitch]"
ms.assetid: e46ac0c4-d609-4b02-963c-c149abc0c4c6
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Deploy a Two-tier LightSwitch Application
If you deploy a two-tier LightSwitch application, it runs on the end-user’s Windows desktop computer, and the database and server components run on the same computer. The **LightSwitch Publish Application Wizard** guides you through the deployment process.  
  
#### To publish a two-tier desktop application  
  
1.  In **Solution Explorer**, open the shortcut menu for the *ProjectName* node, where *ProjectName* is the name of your project, and then choose **Publish**.  
  
     The **LightSwitch Publish Application Wizard** opens.  
  
2.  On the **Application Type** page, choose the **Complete application** option button, and then choose the **Next** button.  
  
3.  On the **Application Server Configuration** page, verify that the **Local Desktop** option button is chosen, and then choose the **Next** button.  
  
4.  On the **Publish Output** page, under **Where do you want the application files to be placed?**, enter the path where you want the publish output to be located.  
  
     The default location is the **Publish** subdirectory under your project directory.  
  
5.  Under **How do you want to publish the default database?**, choose **Publish directly to the database now**, and then choose the **Next** button.  
  
     If you prefer to create a database script, choose **Create a script to install and configure the database**, and then choose the **Next** button.  
  
6.  If you've enabled authentication for your application, the **Application Administrator** tab of the **Security Settings** page appears.  
  
     On the **Authentication** page, choose the **Yes, create an Application Administrator** option button.  
  
7.  In the **User Name** box, enter a user name.  
  
     If you're using Windows authentication, you should specify a valid Windows logion name in the form *Domain*\\*User*.  
  
8.  In the **Full Name** box, enter the full name of the user who'll be the default administrator.  
  
    > [!NOTE]
    >  The **Full Name** box doesn't appear if you're using Windows authentication.  
  
9. In the **Password** box, enter a password.  
  
    > [!NOTE]
    >  The **Password** and **Confirm Password** boxess don't appear if you're using Windows authentication.  
  
10. In the **Confirm Password** box, enter the password again.  
  
     Make sure that you remember the user name and password because you'll need it later.  
  
11. If you haven’t enabled authentication, the **Digital Signature** tab of the **Security Settings** page appears. This application will run on the desktop, you don't need to specify a certificate.  
  
12. Choose the **Next** button to continue.  
  
13. On the **Data Connections** page, choose the **Database Connections** tab, and then, in the **Specify the user connection** text box, enter a connection string for the computer where you'll deploy the database.  
  
     To host the database in the default LocalDB, enter <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. To host the database on a different database server, complete the following procedure:  
  
    ###### To change the connection strings  
  
    1.  Choose the browse  **(…)** button.  
  
         The **Connection Properties** dialog box opens.  
  
    2.  In the **Server name** box, enter the name of the database server where you want to publish the application database.  
  
         The database server must be pre-configured to have SQL Server 2005 or a later version, or SQL Server 2005 Express or a later version. It does not have to be located on the same server where you are publishing the application.  
  
    3.  In the **Log on to the server** section, choose the **Use SQL Authentication** option button, and then enter a valid **User name** and **Password** for the server.  
  
         If SQL Server is configured to use Windows Authentication, you can choose the **Use Windows Authentication** option button instead.  
  
    4.  In the **Select or enter a database name**, enter the name of your application, and then choose the **OK** button.  
  
         You must enter the same name that you entered for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> property in the **Application Designer**.  
  
14. If you chose to publish directly to the database, in the **Publish database schema** text box, enter the same connection string.  
  
15. If you chose to create a script, complete the following procedure.  
  
    ###### To create a new database  
  
    1.  Under **Generate the SQL database script**, choose the **Generate a new database called** option button, and then, in the text box, enter the name for your database.  
  
         You must specify the same name that you entered for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> property in the **Client Designer**.  
  
    ###### To update an existing database  
  
    1.  Under **Generate the SQL database script**,  choose the **Update an existing database** option button.  
  
    2.  Near the **Connection String** text box, choose the browse  **(…)** button.  
  
         The **Connection Properties** dialog box opens.  
  
    3.  In the **Connection Properties** dialog box, enter the connection information for the database, and then choose the **OK** button.  
  
        > [!NOTE]
        >  The connection string can point to a different database as long as the database schema is exactly the same as the database that you want to update.  
  
16. Choose the **Next** button to continue.  
  
17. On the **Prerequisites** page, in the **Does the application have additional prerequisites that need to be installed?** section, review the list of prerequisites to determine whether you want to install them.  
  
     The prerequisites that are checked are the default prerequisites.  
  
18. If you want to install additional prerequisites, choose the **Yes, I need to specify additional prerequisites** option button, and then select the check boxes of the prerequisites to install.  
  
19. In the **Specify the install location for the prerequisites** section, if you want to install from a network share, click **Download from the following location** and enter the path of the location where the installers for the prerequisites are located.  
  
     The default choice, **Download from the Internet**, will download the prerequisites from the Microsoft download site as needed.  
  
     You can also choose **Copy from the same location as my application**. If you choose this option, you will need to make sure that the installers for the prerequisites are located in the application folder. For more information, see [How to: Include Prerequisites with a ClickOnce Application](../vs140/how-to--include-prerequisites-with-a-clickonce-application.md).  
  
20. Choose the **Next** button to continue.  
  
21. On the **Summary** page, choose the **Publish** button.  
  
     When the application is published, the setup files are placed in the directory that you specified for the publish output.  
  
22. Copy the contents of the publish output directory to each computer where you want to install the application. The following step must be completed before running Setup on the target computer.  
  
    1.  If you chose the **Publish directly to the database now** option in Step 5, in the directory that contains the publish output, open the Install.htm file and follow the instructions to configure the target computer.  
  
        > [!NOTE]
        >  If you are installing on a computer that has another LightSwitch application installed, the computer is already configured.  
  
    2.  If you chose the **Create a script to install and configure the database** option, in the directory that contains the publish output, run the two script (.sql) files to create the database and the default SQL user account for the application.  
  
23. Users can install the application by running the **Setup.exe** file.  
  
    > [!NOTE]
    >  If you have enabled authentication for your application, the application administrator will have to authorize users before they can run the application. For more information, see [How to: Create a Role-based Application](../vs140/how-to--enable-authentication-in-a-silverlight-client-app.md).  
  
## See Also  
 [Deployment: Distributing and Maintaining Your Application](../vs140/deployment--distributing-and-maintaining-your-application.md)   
 [Deploying LightSwitch Applications](../vs140/deploying-lightswitch-applications.md)   
 [How to: Deploy a 3-tier Application](../vs140/how-to--deploy-a-three-tier-lightswitch-application.md)   
 [How to: Change the Deployment Topology and Application Type](../vs140/how-to--change-the-type-of-a-lightswitch-application.md)   
 [How to: Create a Role-based Application](../vs140/how-to--enable-authentication-in-a-silverlight-client-app.md)