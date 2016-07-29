---
title: "Set the Properties of a Connection Manager"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 54793114-2198-4d80-8091-e241d5a5d13c
caps.latest.revision: 37
manager: jhubbard
---
# Set the Properties of a Connection Manager
All connection managers can be configured using the **Properties** window.  
  
 [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] also provides custom dialog boxes for modifying the different types of connection managers in [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)]. The dialog box has a different set of options depending on the connection manager type.  
  
### To modify a connection manager using the Properties window  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], open the [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] project that contains the package you want.  
  
2.  In Solution Explorer, double-click the package to open it.  
  
3.  In SSIS Designer, click the **Control Flow** tab, the **Data Flow** tab, or the **Event Handler** tab to make the **Connection Managers** area available.  
  
4.  Right-click the connection manager and click **Properties**.  
  
5.  In the **Properties** window, edit the property values. The **Properties** window provides access to some properties that are not configurable in the standard editor for a connection manager.  
  
6.  Click **OK**.  
  
7.  To save the updated package, click **Save Selected Items** on the **File** menu.  
  
### To modify a connection manager using a connection manager dialog box  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], open the [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] project that contains the package you want.  
  
2.  In Solution Explorer, double-click the package to open it.  
  
3.  In [!INCLUDE[ssIS](../../Topics/TopicNameContainA/includes/ssIS_md.md)] Designer, click the **Control Flow** tab, the **Data Flow** tab, or the **Event Handler** tab to make the **Connection Managers** area available.  
  
4.  In the **Connection Managers** area, double-click the connection manager to open the **Connection Manager** dialog box. For information about specific connection manager types, and the options available for each type, see the following table.  
  
    |Connection manager|Options|  
    |------------------------|-------------|  
    |[ADO Connection Manager](../../Topics/TopicNameNotContainA/ADO-Connection-Manager.md)|[Configure OLE DB Connection Manager](../../Topics/TopicNameNotContainA/Configure-OLE-DB-Connection-Manager.md)|  
    |[ADO.NET Connection Manager](../../Topics/TopicNameNotContainA/ADO.NET-Connection-Manager.md)|[Configure ADO.NET Connection Manager](../../Topics/TopicNameNotContainA/Configure-ADO.NET-Connection-Manager.md)|  
    |[Analysis Services Connection Manager](../../Topics/TopicNameNotContainA/Analysis-Services-Connection-Manager.md)|[Add Analysis Services Connection Manager Dialog Box UI Reference](../../Topics/TopicNameNotContainA/Add-Analysis-Services-Connection-Manager-Dialog-Box-UI-Reference.md)|  
    |[Excel Connection Manager](../../Topics/TopicNameNotContainA/Excel-Connection-Manager.md)|[Excel Connection Manager Editor](../../Topics/TopicNameNotContainA/Excel-Connection-Manager-Editor.md)|  
    |[File Connection Manager](../../Topics/TopicNameNotContainA/File-Connection-Manager.md)|[File Connection Manager Editor](../../Topics/TopicNameNotContainA/File-Connection-Manager-Editor.md)|  
    |[Multiple Files Connection Manager](../../Topics/TopicNameNotContainA/Multiple-Files-Connection-Manager.md)|[Add File Connection Manager Dialog Box UI Reference](../../Topics/TopicNameNotContainA/Add-File-Connection-Manager-Dialog-Box-UI-Reference.md)|  
    |[Flat File Connection Manager](../../Topics/TopicNameNotContainA/Flat-File-Connection-Manager.md)|[Flat File Connection Manager Editor (General Page)](../../Topics/TopicNameNotContainA/Flat-File-Connection-Manager-Editor--General-Page-.md)<br /><br /> [Flat File Connection Manager Editor (Columns Page)](../../Topics/TopicNameNotContainA/Flat-File-Connection-Manager-Editor--Columns-Page-.md)<br /><br /> [Flat File Connection Manager Editor (Advanced Page)](../../Topics/TopicNameNotContainA/Flat-File-Connection-Manager-Editor--Advanced-Page-.md)<br /><br /> [Flat File Connection Manager Editor (Preview Page)](../../Topics/TopicNameNotContainA/Flat-File-Connection-Manager-Editor--Preview-Page-.md)|  
    |[Multiple Flat Files Connection Manager](../../Topics/TopicNameNotContainA/Multiple-Flat-Files-Connection-Manager.md)|[Multiple Flat Files Connection Manager Editor (General Page)](../../Topics/TopicNameNotContainA/Multiple-Flat-Files-Connection-Manager-Editor--General-Page-.md)<br /><br /> [Multiple Flat Files Connection Manager Editor (Columns Page)](../../Topics/TopicNameNotContainA/Multiple-Flat-Files-Connection-Manager-Editor--Columns-Page-.md)<br /><br /> [Multiple Flat Files Connection Manager Editor (Advanced Page)](../../Topics/TopicNameNotContainA/Multiple-Flat-Files-Connection-Manager-Editor--Advanced-Page-.md)<br /><br /> [Multiple Flat Files Connection Manager Editor (Preview Page)](../../Topics/TopicNameNotContainA/Multiple-Flat-Files-Connection-Manager-Editor--Preview-Page-.md)|  
    |[FTP Connection Manager](../../Topics/TopicNameNotContainA/FTP-Connection-Manager.md)|[FTP Connection Manager Editor](../../Topics/TopicNameNotContainA/FTP-Connection-Manager-Editor.md)|  
    |[HTTP Connection Manager](../../Topics/TopicNameNotContainA/HTTP-Connection-Manager.md)|[HTTP Connection Manager Editor (Server Page)](../../Topics/TopicNameNotContainA/HTTP-Connection-Manager-Editor--Server-Page-.md)<br /><br /> [HTTP Connection Manager Editor (Proxy Page)](../../Topics/TopicNameNotContainA/HTTP-Connection-Manager-Editor--Proxy-Page-.md)|  
    |[MSMQ Connection Manager](../../Topics/TopicNameNotContainA/MSMQ-Connection-Manager.md)|[MSMQ Connection Manager Editor](../../Topics/TopicNameNotContainA/MSMQ-Connection-Manager-Editor.md)|  
    |[ODBC Connection Manager](../../Topics/TopicNameNotContainA/ODBC-Connection-Manager.md)|[ODBC Connection Manager UI Reference](../../Topics/TopicNameNotContainA/ODBC-Connection-Manager-UI-Reference.md)|  
    |[OLE DB Connection Manager](../../Topics/TopicNameNotContainA/OLE-DB-Connection-Manager.md)|[Configure OLE DB Connection Manager](../../Topics/TopicNameNotContainA/Configure-OLE-DB-Connection-Manager.md)|  
    |[SMO Connection Manager](../../Topics/TopicNameNotContainA/SMO-Connection-Manager.md)|[SMO Connection Manager Editor](../../Topics/TopicNameNotContainA/SMO-Connection-Manager-Editor.md)|  
    |[SMTP Connection Manager](../../Topics/TopicNameNotContainA/SMTP-Connection-Manager.md)|[SMTP Connection Manager Editor](../../Topics/TopicNameNotContainA/SMTP-Connection-Manager-Editor.md)|  
    |[SQL Server Compact Edition Connection Manager](../../Topics/TopicNameNotContainA/SQL-Server-Compact-Edition-Connection-Manager.md)|[SQL Server Compact Edition Connection Manager Editor (Connection Page)](../../Topics/TopicNameNotContainA/SQL-Server-Compact-Edition-Connection-Manager-Editor--Connection-Page-.md)<br /><br /> [SQL Server Compact Edition Connection Manager Editor (All Page)](../../Topics/TopicNameNotContainA/SQL-Server-Compact-Edition-Connection-Manager-Editor--All-Page-.md)|  
    |[WMI Connection Manager](../../Topics/TopicNameNotContainA/WMI-Connection-Manager.md)|[WMI Connection Manager Editor](../../Topics/TopicNameNotContainA/WMI-Connection-Manager-Editor.md)|  
  
5.  To save the updated package, click **Save Selected Items** on the **File** menu.  
  
## See Also  
 [Integration Services (SSIS) Connections](../../Topics/TopicNameNotContainA/Integration-Services--SSIS--Connections.md)   
 [Add, Delete, or Share a Connection Manager in a Package](../../Topics/TopicNameContainA/Add--Delete--or-Share-a-Connection-Manager-in-a-Package.md)