---
title: Validate a SQL Server Installation
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - setup-install
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1689af50-d2b8-4aa6-8f27-cc7127157fc8
---
# Validate a SQL Server Installation
  The [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] discovery report can be used to verify the version of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] and the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] features installed on the computer. The **Installed [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] features discovery report** displays a report of all [!INCLUDE[ssVersion2000](../../Token\Other/ssVersion2000_md.md)], [!INCLUDE[ssVersion2005](../../Token\Other/ssVersion2005_md.md)], [!INCLUDE[ssKatmai](../../Token\Other/ssKatmai_md.md)], [!INCLUDE[ssKilimanjaro](../../Token\Other/ssKilimanjaro_md.md)], [!INCLUDE[ssSQL11](../../Token\Other/ssSQL11_md.md)], [!INCLUDE[ssSQL14](../../Token\Other/ssSQL14_md.md)], and [!INCLUDE[ssSQL15](../../Token\Other/ssSQL15_md.md)] products and features that are installed on the local server. The [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] features discovery report is available on the **Tools** page on the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Installation center.  
  
 **To run [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] features discovery report:**  
  
 Launch the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Installation center, using the **Start** menu, point to **All Programs**, point to **[!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)][!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] \<Version Name\>**, point to **Configuration Tools**, and click **[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Installation Center**. To run the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] features discovery report, click **Tools** in the left\-hand navigation area of **[!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Installation Center**, and then click **Installed [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] features discovery report**.  
  
 The [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] discovery report is saved to %ProgramFiles%\\[!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)][!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]\\130\\Setup Bootstrap\\Log\\\<last Setup Session\>.  
  
 You can also generate the discovery report through the command line. Run “Setup.exe \/Action\=RunDiscovery” from a command prompt If you add “\/q” to the command line above no UI will be shown, but the report will still be created in %ProgramFiles%\\[!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)][!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]\\130\\Setup Bootstrap\\Log\\\<last Setup Session\>.  
  
## See Also  
 [View and Read SQL Server Setup Log Files](../../Topics\TopicNameNotContainA/View-and-Read-SQL-Server-Setup-Log-Files.md)  
  
  