---
title: "How to: Host a LightSwitch Application on Microsoft Azure"
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
  - "ls.ConnectToAzure"
  - "ls.ServerConfiguration"
helpviewer_keywords: 
  - "Windows Azure [Visual Studio LightSwitch]"
  - "publishing to Windows Azure [Visual Studio LightSwitch]"
  - "hosting on Windows Azure [Visual Studio LightSwitch]"
  - "cloud applications [Visual Studio LightSwitch]"
  - "Azure [Visual Studio LightSwitch]"
ms.assetid: 6657c16b-7ef4-4fdd-8ec4-6f64beca77c6
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Host a LightSwitch Application on Microsoft Azure
You can deploy Visual Studio LightSwitch applications, such as web applications and three-tier desktop applications, to an Azure cloud service or an Azure website by using a wizard. You can also host application data in SQL Azure databases.  
  
> [!NOTE]
>  To deploy an application to Azure, you must have a subscription.  
  
###  \<a name="cloud"></a> To publish an application to an Azure cloud service  
  
1.  In **Solution Explorer**, open the shortcut menu for the top-level project node and choose **Publish**.  
  
     The **LightSwitch Publish Application Wizard** appears.  
  
2.  On the **Welcome to the LightSwitch Publish Wizard** page, choose either the **Complete application** or **Web service only** option button, and then choose the **Next** button.  
  
3.  On the **Application Services** page, choose the **Azure** option button, and then choose the **Next** button.  
  
4.  On the **Azure subscription** page, in the **Subscriptions** list, choose the Azure subscription to use for the application. If the list is empty, choose **\<Manage Settings>** to manage your Azure subscriptions.  
  
5.  Expand the **Service type selection** list and choose the **Cloud Service** option button, and then choose the **Next** button.  
  
6.  On the **Azure cloud service and storage** page, in the **Cloud Service** list, choose the cloud service where you want to host the application. To create a new cloud service, choose **\<Create new>**.  
  
7.  In the **Environment** list, choose the environment (**Production** or **Staging**) to host the application.  
  
8.  (Optional) To allow access to the Azure role for troubleshooting and development purposes, select the **Enable Remote Desktop for all roles** check box.  
  
9. Choose the **Advanced** tab, and, in the **Deployment Name** text box, specify the name for the deployment.  
  
     This name will appear in the Azure Management Portal; the default value is the application name.  
  
10. (Optional) Clear the **Append current date and time** check box to prevent the current date and time from being appended to the deployment name each time the application is published.  
  
11. In the **Storage** list, choose the storage service in which the application binaries will be stored.  
  
    > [!NOTE]
    >  If no storage services are listed, choose the **\<Create new>** link to create one for your subscription.  
  
12. (Optional) Clear the **Enable deployment upgrade** check box to stop overwriting the previous version of an application each time that you publish it.  
  
     If you clear this check box, you must manually remove the previous version of the application in the management portal before you publish a new version.  
  
13. Choose **Next** to continue.  
  
     If you have enabled authentication for your application, the **Application Administrator** tab of the **Security Settings** page appears.  
  
14. If the **Application Administrator** tab appears, enter a valid **User Name**, **Full Name**, and **Password** for the user who will be the initial application administrator.  
  
    > [!NOTE]
    >  When you publish updates, the application administrator already exists. Select the **No, an Application Administrator already exists** check box to skip this step.  
  
15. On the **HTTPS** tab, choose the **Yes, users must connect using HTTPS** option button.  
  
16. In the **Choose your certificate** list, choose the security certificate that you want to use for the application.  
  
    > [!NOTE]
    >  If no certificates are listed, choose the **Upload** button to add an existing certificate. When you publish your application to a staging environment for testing, you can create a test certificate by choosing **Create new self-signed certificate**.  
  
17. Choose the **Next** button to continue.  
  
18. On the **Data Connections** page, choose the **Database Connections** tab, and, in the **Specify the user connection** text box, enter the connection string for the intrinsic database.  
  
19. In the **Publish database schema** text box, enter the connection string for the intrinsic database.  
  
    > [!NOTE]
    >  When you publish updates, clear the **Publish database schema** check box unless you have changed the schema.  
  
20. Choose the **Attached Data Sources** tab, update the connection strings for any additional connections as needed, and then choose the **Next** button.  
  
    > [!NOTE]
    >  The **Attached Data Sources** tab is available only if you have specified an external data source for your application.  
  
21. On the **Summary** page, review the settings, and then choose the **Publish** button.  
  
     When the publishing operation finishes, the Azure Management Portal appears in your browser.  
  
    > [!NOTE]
    >  The publishing operation may take several minutes depending on connection speed, application size, and other factors.  
  
###  \<a name="web"></a> To publish an application to an Azure website  
  
1.  In **Solution Explorer**, open the shortcut menu for the top-level project node and choose **Publish**.  
  
     The **LightSwitch Publish Application Wizard** appears.  
  
2.  On the **Welcome to the LightSwitch Publish Wizard** page, choose either the **Complete application** or **Web service only** option button, and then choose the **Next** button.  
  
3.  On the **Application Services** page, choose the **Azure** option button, and then choose the **Next** button.  
  
4.  On the **Azure subscription** page, in the **Subscriptions** list, choose the Azure subscription to use for the application. If the list is empty, choose **\<Manage Settings>** to manage your Azure subscriptions.  
  
5.  Expand the **Service type selection** list and choose the **Web Site** option button, and then choose the **Next** button.  
  
6.  On the **Service Configuration** page, in the dropdown list, choose the website where you want to host your application and then choose the **Next** button.  
  
    > [!NOTE]
    >  If no websites are listed, choose the **Sign-in to the Azure portal** link, and create a website, then choose the **Refresh** button.  
  
7.  If you have enabled authentication for your application, the **Application Administrator** tab of the **Security Settings** page appears.  
  
8.  If the **Application Administrator** tab appears, enter a valid **User Name**, **Full Name**, and **Password** for the user who will be the initial application administrator.  
  
    > [!NOTE]
    >  When you publish updates, the application administrator already exists. Select the **No, an Application Administrator already exists** check box to skip this step.  
  
9. On the **HTTPS** tab, choose the **Yes, users must connect using HTTPS** option button to require a secure HTTPS connection or the **No, HTTPS is not required** option button if your application doesn’t need a secure connection, and then choose the **Next** button.  
  
     For more information about security, see [Security Considerations for LightSwitch](../vs140/security-considerations-for-lightswitch.md).  
  
10. On the **Data Connections** page, on the **Database Connections** tab, the connection strings for the intrinsic database should appear in the **Specify the user connection** and **Publish database schema** text boxes. If they don’t appear or if you want to create a new database, choose the **Provision a database at the Azure portal** link, create a database, and then copy the new connection string to both the **Specify the user connection** and **Publish database schema** text boxes.  
  
    > [!NOTE]
    >  When you publish updates, clear the **Publish database schema** check box unless you have changed the schema.  
  
11. Choose the **Next** button to continue.  
  
12. Choose the **Attached Data Sources** tab, update the connection strings for any additional connections as needed, and then choose the **Next** button.  
  
    > [!NOTE]
    >  The **Attached Data Sources** tab is available only if you have specified an external data source for your application.  
  
13. On the **Summary** page, review the settings, and then choose the **Publish** button.  
  
     When the publishing operation finishes, the Azure Management Portal appears in your browser.  
  
    > [!NOTE]
    >  The publishing operation may take several minutes depending on connection speed, application size, and other factors.  
  
## See Also  
 [Deployment: Distributing and Maintaining Your Application](../vs140/deployment--distributing-and-maintaining-your-application.md)   
 [Deploying LightSwitch Applications](../vs140/deploying-lightswitch-applications.md)   
 [Setting Up Named Authentication Credentials](http://msdn.microsoft.com/en-us/library/azure/ff683676.aspx)   
 [Using Remote Desktop with Azure Roles](http://msdn.microsoft.com/library/azure/gg443832.aspx)