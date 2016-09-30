---
title: "How to: Deploy a Three-Tier LightSwitch Application"
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
  - "deploying a 3-tier application [Visual Studio LightSwitch]"
  - "deployment [Visual Studio LightSwitch]"
ms.assetid: d9d7072c-8383-4dca-8c83-705eacb50a16
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Deploy a Three-Tier LightSwitch Application
When you choose the application type and deployment topology for your three-tier LightSwitch application, you also determine the process by which you'll deploy that application.  
  
 You can host three-tier applications on a server that's running Internet Information Services (IIS) or on Microsoft Azure. For more information about how to deploy an application to Azure, see [How to: Host an Application Using Microsoft Azure](../vs140/how-to--host-a-lightswitch-application-on-microsoft-azure.md)  
  
-   Desktop client, three-tier deployment creates an application that runs on the end-user’s Windows desktop; the database and server components run on a server that runs IIS or on Azure.  
  
-   Web client, three-tier deployment creates an application that runs in the end-user’s web browser; the database and server components run on a server that runs IIS or on Azure.  
  
 You can deploy a three-tier LightSwitch-based application by either publishing or packaging it. In either case, the **LightSwitch Publish Application Wizard** guides you through the deployment process.  
  
-   Users can run a published application on client computers immediately after you complete the wizard. The application is ready to install, and the installation automatically deploys the database schema to SQL Server. You must have administrative access to both the web server and the database server for this option. The server must also be provisioned for LightSwitch. See [How to: Configure a Server to Host LightSwitch Applications](../vs140/how-to--configure-a-server-to-host-lightswitch-applications.md)  
  
-   In a packaged application, you bundle together everything that's required to run the application. The server administrator must take additional steps to install the application and make it available to end users. See [How to: Install a LightSwitch Application on a Server](../vs140/how-to--install-a-lightswitch-application-on-a-server.md).  
  
#### To publish a three-tier application  
  
1.  In **Solution Explorer**, choose the *ProjectName* node, where *ProjectName* is the name of your project.  
  
2.  On the menu bar, choose **Build**, **Publish \<Application Name>**.  
  
     The **LightSwitch Publish Application Wizard** appears.  
  
3.  On the **Application Type** page, choose the **Complete application** option button, and then choose the **Next** button.  
  
4.  On the **Application Server Configuration** page, choose the **IIS Server** option button, and then choose the **Next** button.  
  
    > [!NOTE]
    >  If you have a publish settings file (.publishsettings or .pubxml) that was created for another application, you can use that file to provide the rest of the information that you need for deployment. Choose the **Import Settings** button to specify a publish settings file.  
  
5.  On the **Publish Output** page, choose the **Remotely publish to a server now** option button, and then choose the **Next** button.  
  
6.  On the **Publish Settings** page, in the **Service URL** box, enter the Uniform Resource Locater (URL) for the server that's running IIS.  
  
7.  In the **Site/Application** box, enter a path for the web page that's used to host the application manifest. This path is typically Default Web Site/*ApplicationName*, where *ApplicationName* is the name of your application.  
  
    > [!NOTE]
    >  If you're publishing to an existing web folder and want to remove any existing content, choose the **Remove additional files at destination** check box.  
  
8.  In the **User Name** and **Password** fields, enter your IIS credentials, and then choose the **Next** button.  
  
9. If the **Application Administrator** tab of the Security Settings page appears, enter a valid **User Name**, **Full Name**, and **Password** for the user who'll be the initial application administrator, and then choose the **HTTPS** tab.  
  
    > [!NOTE]
    >  When you publish updates, the application administrator already exists. Select the **No, an Application Administrator already exists** check box to skip this step.  
  
10. On the **HTTPS** tab of the **Security Settings** page, choose **Yes** to require a secure HTTPS connection, or choose **No** if your application doesn’t need a secure connection, and then choose the **Digital Signature** tab.  
  
     See [Security Considerations for LightSwitch](../vs140/security-considerations-for-lightswitch.md).  
  
11. On the **Digital Signature** tab, select the **Specify a Certificate** check box. To publish without a certificate, clear the **Specify a certificate** check box.  
  
    > [!NOTE]
    >  If you publish your application without a certificate, a security warning appears when an end user runs the application. In some cases, the application might not run. In addition, a certificate tells your users that your application originated from a trustworthy source. See [How to: Sign a XAP File](../vs140/signing-a-xap-file-for-a-lightswitch-application.md).  
  
12. Choose the **Browse** button.  
  
13. In the **Select File** dialog box, browse to the location of the certificate that you want to use, and then choose the **OK** button.  
  
     Basic information about the certificate appears. You can choose the **View Certificate** button to display more information about the certificate.  
  
14. Choose the **Next** button  
  
15. On the **Data connections** page of the wizard, choose the  **Database Connections** tab, enter the administrator and user connection strings for the database server where you want to publish the application database, and then choose the **Attached Data Sources** tab.  
  
    > [!NOTE]
    >  When you publish updates, you don't need to republish the database unless you have changed the schema. To prevent the database from being republished, clear the **Publish database schema** check box.  
  
     The database server must be pre-configured to have SQL Server 2005 or a later version, or SQL Server 2005 Express or a later version. It does not have to be located on the same server where you are publishing the application.  
  
    > [!NOTE]
    >  The user connection string cannot use Integrated Security; you must specify a valid user name and password for the connection.  
  
16. On the **Attached Data Sources** tab, update the connection strings for any additional connections as needed, and then choose the **Next** button.  
  
17. Choose the **Publish** button to publish the application.  
  
     When the application is published, users can install it from the website specified by the **Site/Application** name. For a desktop application, the user will be prompted to choose the **Install \<ApplicationName>** link, where *ApplicationName* is the display name of your application. The application will be installed on the end-user's computer and will be available on the **Start** menu. For a web application, the application will open in the browser when they navigate to the URL.  
  
    > [!NOTE]
    >  If you have enabled authentication for your application, the application administrator will have to authorize users before they can run the application. For more information, see [How to: Create a Role-based Application](../vs140/how-to--enable-authentication-in-a-silverlight-client-app.md).  
  
#### To package a 3-tier application  
  
1.  In **Solution Explorer**, choose the *ProjectName* node, where *ProjectName* is the name of your project.  
  
2.  On the menu bar, choose **Build**, **Publish***ApplicationName*.  
  
     The **LightSwitch Publish Application Wizard** appears.  
  
3.  On the **Application Type** page, choose the **Complete application** option button, and then choose the **Next** button.  
  
4.  On the **Application Server Configuration** page, choose the **IIS Server** option button, and then choose the **Next** button.  
  
    > [!NOTE]
    >  If you have a publish settings file (.publishsettings or .pubxml) that was created for another application, you can use that file to provide the rest of the information that you need for deployment. Choose the **Import Settings** button to specify a publish settings file.  
  
5.  On the **Publish Output** page, choose the **Create a package on disk** option button, and then choose the **Next** button.  
  
6.  On the **Publish Settings** page, in the **What should the website be named?** box, enter a name for the website.  
  
     The default name is the application name.  
  
7.  In the **Where should the package be created?** box, enter the UNC path for the location where you want the output to be published, and then choose the **Next** button.  
  
     The default location is the **Publish** subdirectory under your project directory.  
  
8.  If the **Application Administrator** tab of the **Security Settings** page appears, enter a valid **User Name**, **Full Name**, and **Password** for the user who'll be the initial application administrator, and then choose the **HTTPS** tab.  
  
    > [!NOTE]
    >  When you publish updates, the application administrator already exists. Select the **No, an Application Administrator already exists** check box to skip this step.  
  
9. On the **HTTPS** tab of the **Security Settings** page, choose **Yes** to require a secure HTTPS connection, or choose **No** if your application doesn’t need a secure connection, and then choose the **Digital Signature** tab.  
  
     See [Security Considerations for LightSwitch](../vs140/security-considerations-for-lightswitch.md).  
  
10. On the **Digital Signature** tab, select the **Specify a Certificate** check box. To publish without a certificate, clear the **Specify a certificate** check box.  
  
    > [!NOTE]
    >  If you publish your application without a certificate, a security warning appears when an end user runs the application. In some cases, the application might not run. In addition, a certificate tells your users that your application originated from a trustworthy source. See [How to: Sign a XAP File](../vs140/signing-a-xap-file-for-a-lightswitch-application.md).  
  
11. Choose the **Browse** button.  
  
12. In the **Select File** dialog box, browse to the location of the certificate that you want to use, and then choose the **OK** button.  
  
     Basic information about the certificate appears. You can choose the **View Certificate** button to display more information about the certificate.  
  
13. Choose the **Next** button  
  
14. On the **Database Configuration** page of the wizard, select the **Generate a new database called** option and enter the name for the database.  
  
     This must be the same name that you entered for the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> property in the **Application Designer**.  
  
    > [!NOTE]
    >  If the database already exists on the server, choose the **Update an existing database** option button, and then, in the **Connection String** text box, enter the connection string for that database. If you don't have access to the server, you can enter a connection string for another database that has the same schema as the database on the server.  
  
    > [!NOTE]
    >  When publishing updates, you don't need to republish the database unless you have changed the schema. To prevent the database from being republished, clear the **Generate the SQL database script** check box.  
  
15. Choose the **Attached Data Sources** tab, update the connection strings for any additional connections as needed, and then choose the **Next** button.  
  
16. Choose the **Publish** button to publish the application.  
  
     When the application is published, a .zip file that contains the package is placed in the directory that you specified for the publish output. After this package has been created, a server administrator can use the MSDeploy tool to deploy the application to servers that are running IIS and SQL Server. For more information, see [How to: Install a LightSwitch Application on a Server](../vs140/how-to--install-a-lightswitch-application-on-a-server.md).  
  
    > [!NOTE]
    >  If you have enabled authentication for your application, the application administrator must authorize users before they can run the application. For more information, see [How to: Create a Role-based Application](../vs140/how-to--enable-authentication-in-a-silverlight-client-app.md).  
  
## See Also  
 [Deployment: Distributing and Maintaining Your Application](../vs140/deployment--distributing-and-maintaining-your-application.md)   
 [Deploying LightSwitch Applications](../vs140/deploying-lightswitch-applications.md)   
 [How to: Configure a Server to Host LightSwitch Applications](../vs140/how-to--configure-a-server-to-host-lightswitch-applications.md)   
 [How to: Install a LightSwitch Application on a Server](../vs140/how-to--install-a-lightswitch-application-on-a-server.md)   
 [How to: Change the Deployment Topology and Application Type](../vs140/how-to--change-the-type-of-a-lightswitch-application.md)   
 [How to: Create a Role-based Application](../vs140/how-to--enable-authentication-in-a-silverlight-client-app.md)   
 [How to: Sign a Xap File](../vs140/signing-a-xap-file-for-a-lightswitch-application.md)