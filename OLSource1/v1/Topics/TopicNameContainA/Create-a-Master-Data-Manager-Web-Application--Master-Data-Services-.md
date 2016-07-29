---
title: "Create a Master Data Manager Web Application (Master Data Services)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - setup-install
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 241d46d7-8008-47f6-bebd-0dfff1cc856a
caps.latest.revision: 9
manager: jhubbard
---
# Create a Master Data Manager Web Application (Master Data Services)
The [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)] web application provides an interface for users to work with master data and for administrators to configure and administer MDS.  
  
 A web application must always be contained by a website. To create a web application, you must either:  
  
-   Use the Default website and then create the web application,  
  
-   Use an existing website and then create the web application, or  
  
-   Create a new website, which automatically creates a web application.  
  
 After you create the web application, you associate it with the [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database.  
  
## Prerequisites  
  
-   For information about the requirements for the computer that hosts the web application, see [Web Application Requirements (Master Data Services)](../../Topics/TopicNameNotContainA/Web-Application-Requirements--Master-Data-Services-.md).  
  
## To create a Master Data Manager web application in a new website  
 When you create a new website, the root web application is the [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)] web application. The web application is also added to a new application pool.  
  
> [!NOTE]  
>  If you follow this procedure, you cannot specify a virtual path and alias of the [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)] web application. If you want to specify a virtual path and alias for [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], you must create a web application in an existing website that is not already configured as a [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)] web application.  
  
 Additionally, [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)] supports creating sites with HTTP bindings only. To add an HTTPS binding, create a new site and application in [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)] and then see [Secure a Master Data Manager Web Application](../../Topics/TopicNameContainA/Secure-a-Master-Data-Manager-Web-Application.md) for more information.  
  
#### To create a Master Data Manager web application in a new website  
  
1.  Open [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)].  
  
2.  In the left pane, click **Web Configuration**.  
  
3.  On the **Web Configuration** page, in the Website list, select **Create new website**.  
  
4.  On the **Create Website** dialog box, specify information for a new website. For more information about the user interface (UI) options in the dialog box, see [Create Website Dialog Box (Master Data Services Configuration Manager)](../../Topics/TopicNameNotContainA/Create-Website-Dialog-Box--Master-Data-Services-Configuration-Manager-.md).  
  
5.  Click **OK**.  
  
## To create a Master Data Manager web application in an existing website  
 When you create a web application in an existing website, you can choose the virtual path and alias of the web application. The web application is added to a new application pool.  
  
#### To create a Master Data Manager web application in an existing website  
  
1.  Open [!INCLUDE[ssMDScfgmgr](../../Topics/TopicNameContainA/includes/ssMDScfgmgr_md.md)].  
  
2.  In the left pane, click **Web Configuration**.  
  
3.  On the **Web Configuration** page, from the **Website** list, select the website in which you want to create the [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)] web application.  
  
4.  Click **Create Application**.  
  
5.  On the **Create Web Application** dialog box, specify information for a new web application. For more information about the user interface (UI) options in the dialog box, see [Create Web Application Dialog Box (Master Data Services Configuration Manager)](../../Topics/TopicNameNotContainA/Create-Web-Application-Dialog-Box--Master-Data-Services-Configuration-Manager-.md).  
  
6.  Click **OK**.  
  
## Next Steps  
  
-   Associate the web application with a [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)] database. For more information, see [Associate a Master Data Services Database and Web Application](../../Topics/TopicNameContainA/Associate-a-Master-Data-Services-Database-and-Web-Application.md).  
  
-   Optionally, configure the website that hosts the [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)] web application to use an HTTPS binding if you want to encrypt content by using Secure Sockets Layer (SSL). You must use an Internet Information Services (IIS) tool, such as IIS Manager, to configure the server certificate for the web server, and to configure an HTTPS binding and the SSL settings for the site. For more information, see [Secure a Master Data Manager Web Application](../../Topics/TopicNameContainA/Secure-a-Master-Data-Manager-Web-Application.md).  
  
## See Also  
 [Install Master Data Services](../../Topics/TopicNameNotContainA/Install-Master-Data-Services.md)