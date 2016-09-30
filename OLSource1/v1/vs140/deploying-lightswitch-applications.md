---
title: "Deploying LightSwitch Applications"
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
  - "deployment [Visual Studio LightSwitch]"
ms.assetid: 4818d933-295c-4ecc-9148-7ad9ca28dcdb
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Deploying LightSwitch Applications
The process of deploying a LightSwitch application differs depending on the application type and deployment scenario that you choose.  
  
 The possible deployment scenarios are:  
  
-   Desktop client, 2-tier. This deployment scenario creates an application that runs on the end-user’s Windows desktop. The database and server components run on a networked computer.  
  
-   Desktop client, 3-tier. This deployment scenario creates an application that runs on the end-user’s Windows desktop. The database and server components run on a server that is running Internet Information Services (IIS) or on Microsoft Azure.  
  
-   Browser client, 3-tier. This deployment scenario creates an application that runs in the end-user’s web browser. The database and server components run on a server that is running IIS or on Microsoft Azure.  
  
-   Service only. This deployment scenario creates an OData web service that other applications can access. For more information, see [How to: Deploy a LightSwitch OData Service](../vs140/how-to--deploy-a-lightswitch-odata-service.md).  
  
 The application type can be set in the Application Designer. For more information, see [How to: Change the Deployment Topology and Application Type](../vs140/how-to--change-the-type-of-a-lightswitch-application.md)  
  
 You can deploy a LightSwitch 3-tier application by either publishing or packaging it. In either case, the **LightSwitch Publish Application Wizard** guides you through the deployment process. You can start that wizard by, on the menu bar, choosing **Build**, **Publish \<application name>** or by opening the Application Designer, going to the **General Properties** page, and then choosing the **Publish** button.  
  
-   A published application can be run on client computers immediately after the wizard has been completed. The application is ready to install and the installation automatically deploys the database schema to SQL Server. You must have administrative access to the computer in order to deploy the database schema.  
  
-   A packaged application means that everything that is required to run the application is bundled together, but additional steps must be taken to make the application available to the user. Choose this option when a server administrator will be installing the application and database schema. For more information, see [How to: Install a LightSwitch Application on a Server](../vs140/how-to--install-a-lightswitch-application-on-a-server.md).  
  
 You can deploy updates to a LightSwitch application by running the wizard again. 3-tier browser clients need only re-navigate to the web page to get the updated version. 2-tier desktop clients will automatically receive the updates the next time they are run.  
  
##  \<a name="tier">\</a> Publishing a 2-tier desktop application  
 To publish a 2-tier desktop application, choose **Desktop** on the **Application Type** page of the Application Designer, and choose the **Publish** button to display the **LightSwitch Publish Application Wizard**.  
  
 Additional options in the wizard differ depending on the choices you have made for your application. For more information, see [How to: Deploy a 2-tier Application](../vs140/how-to--deploy-a-two-tier-lightswitch-application.md).  
  
 Once the application is published, users can install it from the publish location that you specify in the wizard by running the **Setup.exe** file.  
  
> [!NOTE]
>  You may need to pre-configure the client computer, following the instructions in the **Install.htm** file. The file is published to the same location as the **Setup.exe** file.  
  
### Publishing Updates  
 To publish updates to the application, update the **Application version** on the **General Properties** page of the Application Designer. Run the **LightSwitch Publish Application Wizard** again. The next time the user runs the application they will automatically receive the update from the publish location.  
  
> [!NOTE]
>  When you publish updates, you don't need to republish the database unless you change the schema. To prevent the database from being republished, open the **LightSwitch Publish Application Wizard**, go to the **Data Connections** page, and then clear the **Generate the SQL database script** check box.  
  
### Uninstalling  
 An end user can uninstall a 2-tier desktop application from **Programs and Features** or **Add and Remove Programs** in **Control Panel**.  
  
##  \<a name="publish">\</a> Publishing a 3-tier application  
 Publishing a 3-tier application requires that you have administrative access to a server that is running IIS and is preconfigured for LightSwitch, and also that you have administrative access to a computer that is running SQL Server. For more information, see [How to: Configure a Server to Host LightSwitch Applications](../vs140/how-to--configure-a-server-to-host-lightswitch-applications.md). You can also publish an application to Microsoft Azure. For more information, see [How to: Host an Application Using Microsoft Azure](../vs140/how-to--host-a-lightswitch-application-on-microsoft-azure.md).  
  
 The publishing process is the same for both desktop and browser applications. To publish a 3-tier application, open the Client Designer, go to the **Application Type** page, and then choose either the **Desktop** or **Web** option button.  
  
 On the **Publish Output** page of the wizard, choose the **Remotely publish to a server now** option button. Additional options in the wizard differ depending on the choices you have made for your application. For more information, see [How to: Deploy a 3-tier Application](../vs140/how-to--deploy-a-three-tier-lightswitch-application.md).  
  
 Once the application is published, users can install it from the web site that you specify in the wizard by choosing the *ApplicationName* link, where *ApplicationName* is the display name of your application. For a desktop application, the user will be prompted to install. For a Web application, the application will open in the web browser.  
  
### Publishing Updates  
 To publish updates to the application, update the **Application version** on the **General Properties** page of the Application Designer. Run the **LightSwitch Publish Application Wizard** again. The next time that the user runs the application they will automatically see the new version.  
  
> [!NOTE]
>  When you publish updates, you don't need to republish the database unless you change the schema. To prevent the database from being republished, open the **LightSwitch Publish Application Wizard**, go to the **Data Connections** page, and then clear the **Generate the SQL database script** check box.  
  
### Uninstalling  
 An end user can uninstall a 3-tier desktop application from **Programs and Features** or **Add and Remove Programs** in **Control Panel**. Browser applications must be uninstalled from the server by the IIS administrator.  
  
##  \<a name="package">\</a> Packaging a 3-tier application  
 A packaged 3-tier application generates everything necessary to install the application on an Internet Information Services (IIS) host. The publishing process is the same for both desktop and browser applications. To package a 3-tier application, open the Client Designer, go to the **Application Type** page, and then choose either **Desktop** or **Web**. On the **Publish Output** page of the wizard, choose the **Create a package on disk** option button. Additional options in the wizard differ depending on the choices you have made for your application. For more information, see [How to: Deploy a 3-tier Application](../vs140/how-to--deploy-a-three-tier-lightswitch-application.md).  
  
 Once the application is published, a .zip file that contains the package is placed in the publish location that you specified in the wizard. Once this package has been created, a server administrator can deploy the application to servers that are running IIS and SQL Server. For more information, see [How to: Install a LightSwitch Application on a Server](../vs140/how-to--install-a-lightswitch-application-on-a-server.md).  
  
### Publishing Updates  
 To publish updates to the application, update the **Application version** on the **General Properties** page of the Application Designer. Run the **LightSwitch Publish Application Wizard** again. After the server administrator has installed the new package, the next time that the user runs the application they will automatically see the new version.  
  
> [!NOTE]
>  When you publish updates, you don't need to republish the database unless you change the schema. To prevent the database from being republished, open the **LightSwitch Publish Application Wizard**, go to the **Data Connections** page, and then clear the **Generate the SQL database script** check box.  
  
### Uninstalling  
 An end user can uninstall a 3-tier desktop application from **Programs and Features** or **Add and Remove Programs** in **Control Panel**. Browser applications must be uninstalled by the IIS administrator.  
  
## See Also  
 [Deployment: Distributing and Maintaining Your Application](../vs140/deployment--distributing-and-maintaining-your-application.md)   
 [How to: Change the Deployment Topology and Application Type](../vs140/how-to--change-the-type-of-a-lightswitch-application.md)   
 [How to: Deploy a 2-tier Application](../vs140/how-to--deploy-a-two-tier-lightswitch-application.md)   
 [How to: Deploy a 3-tier Application](../vs140/how-to--deploy-a-three-tier-lightswitch-application.md)   
 [How to: Host an Application Using Microsoft Azure](../vs140/how-to--host-a-lightswitch-application-on-microsoft-azure.md)   
 [How to: Install a LightSwitch Application on a Server](../vs140/how-to--install-a-lightswitch-application-on-a-server.md)