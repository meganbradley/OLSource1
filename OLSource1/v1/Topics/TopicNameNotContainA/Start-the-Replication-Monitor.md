---
title: "Start the Replication Monitor"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e037bd27-cc87-4ee9-9e5f-83f6d717cfa4
caps.latest.revision: 37
manager: jhubbard
---
# Start the Replication Monitor
Replication Monitor can be started from [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] on any instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)], or from the command prompt. After starting Replication Monitor, add one or more Publishers to monitor. For more information, see [Add and Remove Publishers from Replication Monitor](../../Topics/TopicNameNotContainA/Add-and-Remove-Publishers-from-Replication-Monitor.md).  
  
### To start Replication Monitor from SQL Server Management Studio  
  
1.  Connect to an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] in [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], and then expand the server node.  
  
2.  Right-click the **Replication** folder or any of its subfolders, and then click **Launch Replication Monitor**.  
  
### To start Replication Monitor from the command prompt  
  
1.  From the command prompt, navigate to the tools installation directory. The default path is [!INCLUDE[ssInstallPath](../../Topics/TopicNameContainA/includes/ssInstallPath_md.md)]Tools\Binn\ .  
  
2.  Run sqlmonitor.exe.  
  
## See Also  
 [Monitoring Replication](../../Topics/TopicNameNotContainA/Monitoring-Replication.md)