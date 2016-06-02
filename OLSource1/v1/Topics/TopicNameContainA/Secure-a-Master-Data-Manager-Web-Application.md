---
title: Secure a Master Data Manager Web Application
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - setup-install
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e360ba3a-e96b-4f85-b588-ed1f767fa973
---
# Secure a Master Data Manager Web Application
  You can secure the [!INCLUDE[ssMDSmdm](../../Token\Other/ssMDSmdm_md.md)] web application with HTTPS.  
  
> [!NOTE]  
>  The [!INCLUDE[ssMDSmdm](../../Token\Other/ssMDSmdm_md.md)] web application can use either HTTP or HTTPS, but not both.  
  
## Prerequisites  
 To perform the procedure:  
  
-   You must be an administrator on the web server where [!INCLUDE[ssMDSmdm](../../Token\Other/ssMDSmdm_md.md)] is installed.  
  
-   MDS must be installed on the web server, and a web application must exist. For more information, see [Install Master Data Services](../../Topics\TopicNameNotContainA/Install-Master-Data-Services.md) and [Create a Master Data Manager Web Application &#40;Master Data Services&#41;](../Topic/Create%20a%20Master%20Data%20Manager%20Web%20Application%20\(Master%20Data%20Services\).md).  
  
### To secure the Master Data Manager web application with HTTPS  
  
1.  After you have confirmed that the [!INCLUDE[ssMDSmdm](../../Token\Other/ssMDSmdm_md.md)] web application is configured correctly with HTTP, create a certificate in IIS. For more information, see [Configuring Server Certificates in IIS 7](http://technet.microsoft.com/library/cc732230\(WS.10\).aspx).  
  
2.  In the **Connections** pane, under **Sites**, click the site that hosts the [!INCLUDE[ssMDSmdm](../../Token\Other/ssMDSmdm_md.md)] web application.  
  
3.  In the **Actions** pane, click **Bindings**.  
  
4.  Click **Add**.  
  
5.  From the list, select **https**.  
  
6.  Select the SSL certificate.  
  
7.  Click **OK**.  
  
8.  Optional. To remove HTTP so that users can access the site with HTTPS only, from the list, click the row with **http**. Click **Remove** and on the confirmation dialog box, click **Yes**.  
  
    > [!IMPORTANT]  
    >  You must change basicHttp and wsHttpBinding configurations after removing HTTP.  
  
9. To close the **Site Bindings** dialog box, click **Close**.  
  
10. Now open the web.config file from *drive*:\\Program Files\\Microsoft SQL Server\\130\\Master Data Services\\WebApplication.  
  
11. Find the string `<security mode="Message">` and change it to `<security mode="Transport">`.  
  
12. Save and close the file. If you get an error, it could be because you have UAC enabled. For more information, see [Turn off User Account Control](http://technet.microsoft.com/library/cc709691\(WS.10\).aspx). Users should now be able to use HTTPS to access the site.  
  
## See Also  
 [Create a Master Data Manager Web Application &#40;Master Data Services&#41;](../Topic/Create%20a%20Master%20Data%20Manager%20Web%20Application%20\(Master%20Data%20Services\).md)  
  
  