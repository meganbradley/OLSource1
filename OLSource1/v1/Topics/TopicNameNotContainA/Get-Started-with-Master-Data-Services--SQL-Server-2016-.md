---
title: Get Started with Master Data Services (SQL Server 2016)
ms.custom: 
  - SQL2016_New_Updated
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: get-started-article
ms.assetid: d50863e7-50d9-4ab8-aabb-fd68e2d132a1
manager: jhubbard
robots: noindex,nofollow
---
# Get Started with Master Data Services (SQL Server 2016)
This article covers how to install  [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], set up the MDS database and website, and deploy the sample models and data.  
  
 For an overview of the building blocks of [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], such as a model and an entity, see [Master Data Services Overview (MDS)](../../Topics/TopicNameNotContainA/Master-Data-Services-Overview--MDS-.md).  
  
## Installing Master Data Services, and IIS Roles and Features  
 You use the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] setup installation wizard or a command prompt to install [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)].  
  
 **To install [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] using [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Setup.**  
  
1.  Double-click Setup.exe, and follow the steps in the installation wizard.  
  
2.  Select [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] on the **Feature Selection** page under **Shared Features**.  
  
     This installs [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)], assemblies, a Windows PowerShell snap-in, and folders and files for Web applications and services.  
  
     ![mds&#95;SQLServer2016Setup&#95;FeatureSelection](../../Topics/TopicNameNotContainA/media/mds_SQLServer2016Setup_FeatureSelection.png "mds_SQLServer2016Setup_FeatureSelection")  
  
3.  Complete the installation wizard.  
  
4.  In [!INCLUDE[winblue_server_2](../../Topics/TopicNameContainA/includes/winblue_server_2_md.md)], click the **Server Manager** icon on the taskbar on the **Desktop**.  
  
     ![Icon for the Server Manager in Windows Server 2012 taskbar](../../Topics/TopicNameNotContainA/media/mds_WindowsServerTaskbar_ServerManagerIcon.png "mds_WindowsServerTaskbar_ServerManagerIcon")  
  
5.  In **Server Manager**, click, **Add Roles and Features** on the **Manage** menu.  
  
     ![In Server Manage, the Add Roles and Features menu command](../../Topics/TopicNameNotContainA/media/mds_ServerManagerDashboard_AddRolesFeaturesMenu.png "mds_ServerManagerDashboard_AddRolesFeaturesMenu")  
  
6.  On the **Installation Type** page of the **Add Roles and Features Wizard**, accept the default value (**Role-based or feature-based installation**) and click **Next**.  
  
7.  Click **Select a server from the server pool**, and then click the server where you installed [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)].  
  
     ![Server Selection page on the Add Roles and Features Wizard](../../Topics/TopicNameNotContainA/media/mds_ServerManagerDashboard_AddRolesandFeaturesWizard_ServerSelection.png "mds_ServerManagerDashboard_AddRolesandFeaturesWizard_ServerSelection")  
  
8.  In the **Roles** box, click the roles and roles services that are required for [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] on [!INCLUDE[winblue_server_2](../../Topics/TopicNameContainA/includes/winblue_server_2_md.md)], and then click **Next**. The following images show the selected, required roles and roles services.  
  
    > [!WARNING]  
    >  Do not install the WebDAV Publishing role service. WebDAV Publishing is not compatible with [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)].  
  
    > [!IMPORTANT]  
    >  **Dynamic Content Compression** is enabled by default. This significantly reduces the size of the xml response and saves the network I/O, though CPU usage is increased.  For more information, see **[CTP 2.0] Improved Performance** in [What's New in Master Data Services (MDS)](../../Topics/TopicNameNotContainA/What-s-New-in-Master-Data-Services--MDS-.md).  
  
    |Roles and Role Services|Roles and Role Services|  
    |-----------------------------|-----------------------------|  
    |![Common HTTP Features](../../Topics/TopicNameNotContainA/media/mds_ServerManagerDashboard_CommonHTTPFeaturesRoles.png "mds_ServerManagerDashboard_CommonHTTPFeaturesRoles")|![Health Diagnostics Roles](../../Topics/TopicNameNotContainA/media/mds_ServerManagerDashboard_HealthDiagnosticsRoles.png "mds_ServerManagerDashboard_HealthDiagnosticsRoles")|  
    |![Performance Roles](../../Topics/TopicNameNotContainA/media/mds_ServerManagerDashboard_PerformanceRoles.png "mds_ServerManagerDashboard_PerformanceRoles")|![Security Roles](../../Topics/TopicNameNotContainA/media/mds_ServerManagerDashboard_SecurityRoles.png "mds_ServerManagerDashboard_SecurityRoles")|  
    |![WebServer Application Development Roles](../../Topics/TopicNameNotContainA/media/mds_ServerManagerDashboard_WebServerApplicationDevelopmentRoles.png "mds_ServerManagerDashboard_WebServerApplicationDevelopmentRoles")|![Management Tools](../../Topics/TopicNameNotContainA/media/mds_ServerManagerDashboard_ManagementToolsRoles.png "mds_ServerManagerDashboard_ManagementToolsRoles")|  
  
     For a list of the required roles and roles services on various operating systems, see [Web Application Requirements (Master Data Services)](../../Topics/TopicNameNotContainA/Web-Application-Requirements--Master-Data-Services-.md) .  
  
9. In the **Features** box, click the features that are required for [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] on [!INCLUDE[winblue_server_2](../../Topics/TopicNameContainA/includes/winblue_server_2_md.md)], and then click **Next**. The following images show the selected, required features.  
  
    |Features|Features|  
    |--------------|--------------|  
    |![Net Framework Features](../../Topics/TopicNameNotContainA/media/mds_ServerManagerDashboard_NetFrameworkFeatures.png "mds_ServerManagerDashboard_NetFrameworkFeatures")|![Windows Process Features](../../Topics/TopicNameNotContainA/media/mds_ServerManagerDashboard_WindowsProcessFeatures.png "mds_ServerManagerDashboard_WindowsProcessFeatures")|  
  
     For a list of the required features on various operating systems, see [Web Application Requirements (Master Data Services)](../../Topics/TopicNameNotContainA/Web-Application-Requirements--Master-Data-Services-.md) .  
  
 For more information about installing [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] using setup, see [Install SQL Server 2016 from the Installation Wizard (Setup)](../../Topics/TopicNameNotContainA/Install-SQL-Server-2016-from-the-Installation-Wizard--Setup-.md).  
  
 For more information about installing [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] using a command prompt, see [Install SQL Server 2016 from the Command Prompt](../../Topics/TopicNameNotContainA/Install-SQL-Server-2016-from-the-Command-Prompt.md). When you use a command prompt, [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] is available as a feature parameter.  
  
 For a brief description with links to additional information about pre-installation tasks, see [Install Master Data Services](../../Topics/TopicNameNotContainA/Install-Master-Data-Services.md).  
  
##  <a name="SetUpWeb"></a> Setting up the Database and Website  
 **To set up the database and website using the [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)]**  
  
1.  Launch the [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)], and click **Database Configuration** in the left pane.  
  
2.  Click **Create Database**, and then click **Next** in the **Create Database Wizard**.  
  
3.  On the **Database Server** page, select the **Authentication type** and then click **Test Connection** to confirm that you can connect to the database using the credentials for the authentication type you selected.  
  
    > [!NOTE]  
    >  When you select **Current User – Integrated Security** as the authentication type, **User name** box is read-only and displays the name of the Windows user account that is logged on to the computer.  
  
     ![The Database server page in the Create Database Wizard](../../Topics/TopicNameNotContainA/media/mds_ConfigurationManager_CreateDatabaseWizard_ServerPage.png "mds_ConfigurationManager_CreateDatabaseWizard_ServerPage")  
  
4.  Type a name in the **Database name** field. Optionally, to select a Windows collation and specify one or more of the available options such as **Case-sensitive**, clear the **SQL Server default collation** checkbox.  
  
     ![The Database page in the Create Database Wizard](../../Topics/TopicNameNotContainA/media/mds_ConfigurationManager_CreateDatabaseWizard_DatabasePage.png "mds_ConfigurationManager_CreateDatabaseWizard_DatabasePage")  
  
     For more information about Windows collation, see [Windows Collation Name (Transact-SQL)](https://msdn.microsoft.com/en-us/library/ms188046.aspx).  
  
5.  In the **User name** field, specify  the Windows account of the user that will be the default Super User for Master Data Services. A Super User has access to all functional areas and can add, delete, and update all models.  
  
     ![The Administrator Account page in the Create Database Wizard.](../../Topics/TopicNameNotContainA/media/mds_ConfigurationManager_CreateDatabaseWizard_AdminPage.png "mds_ConfigurationManager_CreateDatabaseWizard_AdminPage")  
  
6.  Click **Next** to view a summary of the settings for the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)]database, and then click **Next** again to create the database.  
  
     For more information about the settings in the **Create Database Wizard**, see [Create Database Wizard (Master Data Services Configuration Manager)](../../Topics/TopicNameNotContainA/Create-Database-Wizard--Master-Data-Services-Configuration-Manager-.md).  
  
7.  On the Database Configuration page in the [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)],  click Select Database.  
  
8.  Click **Connect**, and then select the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database that you created in Step 6.  
  
     ![Connect to Database dialog box for the Database Configuration page](../../Topics/TopicNameNotContainA/media/mds_ConfigurationManager_SelectDatabaseButton_ConnectToDatabaseDialog.png "mds_ConfigurationManager_SelectDatabaseButton_ConnectToDatabaseDialog")  
  
     You've finished setting up the database. The **Database Configuration** page now displays the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instance that you're connected to for [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], the  database you've created and the current database version.  
  
     ![Database Configuration page in the Configuration Manager shows a completed database setup.](../../Topics/TopicNameNotContainA/media/mds_ConfigurationManager_DatabaseConfig_Completed.png "mds_ConfigurationManager_DatabaseConfig_Completed")  
  
9. In [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)], and click **Web Configuration** in the left pane.  
  
10. In the **Website** list box, click **Default Web Site**, and then click **Create** to create a Web application.  
  
    > [!NOTE]  
    >  When you select **Default Web Site**, you must create a Web application. If you select **Create new website** in the list box, the application is automatically created.  
  
     ![Web Configuration page in the Configuration Manager](../../Topics/TopicNameNotContainA/media/mds_ConfigurationManager_WebConfig.png "mds_ConfigurationManager_WebConfig")  
  
11. In the **Application Pool** section, do one of the following.  
  
    -   Enter the same user name that you entered in Step 5 for the database **Administrator Account**, enter the password, and then click **OK**.  
  
         **-OR-**  
  
    -   Enter a different user name, enter the password, and then click OK.  
  
         You don't have to use the same account when you create the database and the web application.  
  
     ![Create Web Application dialog box, Web Configuration page](../../Topics/TopicNameNotContainA/media/mds_ConfigurationManager_WebConfig_CreateWebApplication.png "mds_ConfigurationManager_WebConfig_CreateWebApplication")  
  
     For more information about the **Create Web Application** dialog box, see [Create Web Application Dialog Box (Master Data Services Configuration Manager)](../../Topics/TopicNameNotContainA/Create-Web-Application-Dialog-Box--Master-Data-Services-Configuration-Manager-.md).  
  
12. On the **Web Configuration** page in the **Web application** box, click the application you've created, and then click **Select** in the  **Associate Application with Database** section.  
  
13. Click **Connect**, select the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database that you want to associate with the Web application, and then click **OK**.  
  
     You've finished setting up the Website. The **Web Configuration** page now displays the Website you selected,  Web application you created, and the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database  associated with the application.  
  
     ![The completed Web site configuration](../../Topics/TopicNameNotContainA/media/mds_ConfigurationManager_WebConfig_Completed.png "mds_ConfigurationManager_WebConfig_Completed")  
  
     For more information about the settings on the Web Configuration page, see [Web Configuration Page (Master Data Services Configuration Manager)](../../Topics/TopicNameNotContainA/Web-Configuration-Page--Master-Data-Services-Configuration-Manager-.md)  
  
 You can also use [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)] to specify other settings for the Web applications and services associated with the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database. For example, you can specify how frequently data is loaded or how often validation emails are sent. For more information, see [System Settings (Master Data Services)](../../Topics/TopicNameNotContainA/System-Settings--Master-Data-Services-.md).  
  
##  <a name="deploySample"></a> Deploying Sample Models and Data  
 The following three sample model packages are included with  [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)].   These sample models include data. The default location for the sample model packages is *<drive\>*\Program Files\Microsoft SQL Server\130\Master Data Services\Samples\Packages.  
  
-   chartofaccounts_en.pkg  
  
-   customer_en.pkg  
  
-   product_en.pkg  
  
 You deploy the packages using the MDSModelDeploy tool. The default location for the MDSModelDeploy tool is *<drive\>*\Program Files\Microsoft SQL Server\ 130\Master Data Services\Configuration.  
  
 For information about prerequisites for running this tool, see [Deploy a Model Deployment Package by Using MDSModelDeploy](../../Topics/TopicNameContainA/Deploy-a-Model-Deployment-Package-by-Using-MDSModelDeploy.md).  
  
 For information about updates made to the data to support new features in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)][!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], see [Samples: Model Deployment Packages (Master Data Services)](../Topic/Samples:%20Model%20Deployment%20Packages%20\(Master%20Data%20Services\).md).  
  
 **To deploy the sample models**  
  
1.  Copy the sample model packages to <drive\>\Program Files\Microsoft SQL Server\130\Master Data Services\Configuration.  
  
2.  Open an Administrator: Command Prompt and navigate to MDSModelDeploy.exe, by running the following command.  
  
    ```  
    cd c:\Program Files\Microsoft SQL Server\130\Master Data Services\Configuration  
    ```  
  
3.  Deploy each of the sample models to [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] by running each of the following commands.  
  
    > [!IMPORTANT]  
    >  In the examples below, the `MDS1` service value is specified. You use this value if you selected  **Default Web Site** when you set up the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] Web site.  See the [Setting up the Database and Website](#SetUpWeb) section.  
    >   
    >  If you created a new web site or selected another existing web site, run the following command first to determine the correct service value.  
    >   
    >  `MDSModelDeploy listservices`  
    >   
    >  The first service value in the list of values returned, is the one you specify to deploy a model.  
  
     **To deploy the chartofaccounts_en.pkg sample model**  
  
    ```  
    MDSModelDeploy deploynew -package chartofaccounts_en.pkg -model Customer -service MDS1  
    ```  
  
     **To deploy the customer_en.pkg sample model**  
  
    ```  
    MDSModelDeploy deploynew -package customer_en.pkg -model Customer -service MDS1  
    ```  
  
     **To deploy the product_en.pkg sample model**  
  
    ```  
    MDSModelDeploy deploynew -package product_en.pkg -model Customer -service MDS1  
  
    ```  
  
     When a model is successfully deployed, the **MDSModelDeploy operation completed** message is displayed.  
  
     The following image shows the command for deploying the product_en.pkg sample model.  
  
     ![Command line for deploying the Product sample model](../../Topics/TopicNameNotContainA/media/mds_CommandPrompt_DeployingSampleModel_Product.png "mds_CommandPrompt_DeployingSampleModel_Product")  
  
4.  To view the sample models, do the following.  
  
    1.  Navigate to the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] web site that you set up. See the [Setting up the Database and Website](#SetUpWeb) section.  
  
         The web site address is http://<server name\>/<web application\>/.  
  
    2.  Select a model from the **Model** list box, and click **Explorer**.  
  
         ![MDS Web site, home page.](../../Topics/TopicNameNotContainA/media/mds_MDSWebSite_HomePage_SelectSampleModel.png "mds_MDSWebSite_HomePage_SelectSampleModel")  
  
## Next Step  
 Create a new model and entities for your data. See [Create a Model (Master Data Services)](../../Topics/TopicNameContainA/Create-a-Model--Master-Data-Services-.md) and [Create an Entity (Master Data Services)](../../Topics/TopicNameNotContainA/Create-an-Entity--Master-Data-Services-.md).  
  
 For an overview of how you use a model and entities to build a structure for your data in [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], see [Master Data Services Overview (MDS)](../../Topics/TopicNameNotContainA/Master-Data-Services-Overview--MDS-.md)  
  
## Did this Article Help You? We’re Listening  
 What information are you looking for, and did you find it? We’re listening to your feedback to improve the content. Please submit your comments to [sqlfeedback@microsoft.com](mailto:sqlfeedback@microsoft.com?subject=Get%20Started%20with%20Master%20Data%20Services)  
  
## See Also  
 [Master Data Services Database](../../Topics/TopicNameNotContainA/Master-Data-Services-Database.md)   
 [Master Data Manager Web Application](../../Topics/TopicNameNotContainA/Master-Data-Manager-Web-Application.md)   
 [Database Configuration Page (Master Data Services Configuration Manager)](../../Topics/TopicNameNotContainA/Database-Configuration-Page--Master-Data-Services-Configuration-Manager-.md)   
 [What's New in Master Data Services (MDS)](../../Topics/TopicNameNotContainA/What-s-New-in-Master-Data-Services--MDS-.md)