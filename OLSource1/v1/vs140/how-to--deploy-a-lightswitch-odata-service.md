---
title: "How to: Deploy a LightSwitch OData Service"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1bc0a023-5453-4c09-b5b2-aaaaf561a71c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Deploy a LightSwitch OData Service
By publishing a LightSwitch application as a service, you can use it as the middle tier to provide data to other applications. You can host services on Microsoft Azure or Internet Information Services (IIS). For more information about how to deploy a service to Azure, see [How to: Host an Application Using Microsoft Azure](../vs140/how-to--host-a-lightswitch-application-on-microsoft-azure.md).  
  
 You can use the **LightSwitch Publish Application Wizard** to deploy a service by either publishing or packaging it.  
  
-   If you publish a service, client computers can access it immediately after you complete the wizard. The installation automatically deploys the database schema to SQL Server. To publish a service, you must have administrative access to both the web server and the database server, and you must provision the web server for LightSwitch. See [How to: Configure a Server to Host LightSwitch Applications](../vs140/how-to--configure-a-server-to-host-lightswitch-applications.md).  
  
-   If you package an application, you must compress (zip) everything that’s required to run the service in a folder. A server administrator must also install the service and make it available. See [How to: Install a LightSwitch Application on a Server](../vs140/how-to--install-a-lightswitch-application-on-a-server.md).  
  
### To publish a service  
  
1.  In **Solution Explorer**, choose the *ProjectName* node, where *ProjectName* is the name of your project.  
  
2.  On the menu bar, choose **Build**, **Publish***ApplicationName*.  
  
     The **LightSwitch Publish Application Wizard** appears.  
  
3.  On the **Application Type** page, choose the **Web service only** option button, and then choose the **Next** button.  
  
4.  On the **Application Server Configuration** page, choose the **IIS Server** option button.  
  
    > [!NOTE]
    >  If you have a publish settings file (.publishsettings or .pubxml) that was created for another service, you can use that file to provide the rest of the information that you need for deployment. Choose the **Import Settings** button to specify a publish settings file.  
  
5.  Choose the **Next** button, and then, on the **Publish Output** page, choose the **Remotely publish to a server now** option button.  
  
     The **Details** section appears.  
  
6.  In the **Service URL** text box, enter the Uniform Resource Locater (URL) for the server that’s running IIS.  
  
7.  In the **Site/Application** text box, enter a path for the webpage that’s used to host the application manifest.  
  
     This path is typically Default Web Site/*ServiceName*, where *ServiceName* is the name of your application.  
  
8.  In the **User Name** and **Password** text boxes, enter your IIS credentials, and then choose the **Next** button.  
  
9. If the **Application Administrator** tab of the **Security Settings** page appears, enter a valid **User Name**, **Full Name**, and **Password** for the user who'll be the initial application administrator, and then choose the **HTTPS** tab.  
  
    > [!NOTE]
    >  When you publish updates, the application administrator already exists. Select the **No, an Application Administrator already exists** check box to skip this step.  
  
10. On the **HTTPS** tab of the **Security Settings** page, choose **Yes** to require a secure HTTPS connection, or choose **No** if your application doesn’t need a secure connection.  
  
     See [Security Considerations for LightSwitch](../vs140/security-considerations-for-lightswitch.md).  
  
11. Choose the **Next** button to open the **Data Connections** page of the wizard.  
  
12. On the **Database Connections** tab, enter the administrator and user connection strings for the database server where you want to publish the application database, and then choose the **Attached Data Sources** tab.  
  
    > [!NOTE]
    >  When you publish updates, you don't need to republish the database unless you have changed the schema. To prevent the database from being republished, clear the **Publish database schema** check box.  
  
     The database server must be running a compatible version of SQL Server, such as SQL Server 2005 or SQL Server 2005 Express. You don’t need to publish the application to the database server.  
  
    > [!NOTE]
    >  The user connection string can’t use Integrated Security; you must specify a valid user name and password for the connection.  
  
13. On the **Attached Data Sources** tab, update the connection strings for any additional connections as needed, choose the **Next** button, and then choose the **Publish** button.  
  
     When the service is published, other applications can access it from the website specified by the **Site/Application** name plus *ServiceName*.svc, where *ServiceName* is the name of a data source that your service exposes.  
  
### To package a service  
  
1.  In **Solution Explorer**, choose the *ProjectName* node, where *ProjectName* is the name of your project.  
  
2.  On the menu bar, choose **Build**, **Publish***ApplicationName*.  
  
     The **LightSwitch Publish Application Wizard** appears.  
  
3.  On the **Application Type** page, choose the **Web service only** option button, and then choose the **Next** button.  
  
4.  On the **Application Server Configuration** page, choose the **IIS Server** option button.  
  
    > [!NOTE]
    >  If you have a publish settings file (.publishsettings or .pubxml) that was created for another application, you can use that file to provide the rest of the information that you need for deployment. Choose the **Import Settings** button to specify a publish settings file.  
  
5.  Choose the **Next** button, and then, on the **Publish Output** page, choose the **Create a package on disk** option button.  
  
6.  In the **What should the website be named?** text box, enter a name for the website that will host the service.  
  
     By default, the name of the website is the application name.  
  
7.  In the **Where should the package be created?** text box, enter the UNC path for the location where you want the output to be published.  
  
     By default, the output is published in the **Publish** subdirectory under your project directory.  
  
8.  If the **Application Administrator** tab of the Security Settings page will appear. Enter a valid **User Name**, **Full Name**, and **Password** for the user who will be the initial application administrator, and then choose the **HTTPS** tab.  
  
    > [!NOTE]
    >  When you publish updates, the application administrator already exists. Select the **No, an Application Administrator already exists** check box to skip this step.  
  
9. On the **HTTPS** tab of the **Security Settings** page, choose **Yes** to require a secure HTTPS connection, or choose **No** if your application doesn’t need a secure connection.  
  
     See [Security Considerations for LightSwitch](../vs140/security-considerations-for-lightswitch.md).  
  
10. Choose the **Next** button, and then, on the **Database Connections** tab of the **Data Connections** page of the wizard, select the **Generate the SQL database script** option button, and then enter a name for the database.  
  
     You must specify the same name that you entered for the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> property in the **Application Designer**.  
  
    > [!NOTE]
    >  If the database already exists on the server, choose the **Generate a new database called** option button, and then enter the connection string for that database. If you don’t have access to the server, you can enter a connection string for another database that has the same schema as the database on the server.  
  
    > [!NOTE]
    >  When you publish an update, you don't need to republish the database unless you’ve changed the schema. To prevent the database from being republished, clear the **Generate the SQL database script** check box.  
  
11. On the **Attached Data Sources** tab, update the connection strings for any additional connections as needed, choose the **Next** button, and then choose the **Publish** button.  
  
     When the service is published, a .zip file that contains the package is placed in the directory that you specified for the publish output. After this package has been created, a server administrator can use the MSDeploy tool to deploy the service to servers that are running IIS and SQL Server. See [How to: Install a LightSwitch Application on a Server](../vs140/how-to--install-a-lightswitch-application-on-a-server.md).  
  
     When the service is deployed, other applications can access it from the website specified by the **Site/Application** name plus *ServiceName*.svc, where *ServiceName* is the name of a data source that your service exposes.  
  
    > [!NOTE]
    >  If you’ve enabled authentication for your application, the application administrator must authorize users before they can run the application. For more information, see [How to: Create a Role-based Application](../vs140/how-to--enable-authentication-in-a-silverlight-client-app.md).  
  
## See Also  
 [LightSwitch as a Data Source](../vs140/lightswitch-as-a-data-source.md)   
 [Deploying LightSwitch Applications](../vs140/deploying-lightswitch-applications.md)   
 [How to: Host an Application Using Microsoft Azure](../vs140/how-to--host-a-lightswitch-application-on-microsoft-azure.md)