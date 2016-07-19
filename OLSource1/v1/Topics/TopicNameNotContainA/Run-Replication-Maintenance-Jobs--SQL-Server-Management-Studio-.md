---
title: Run Replication Maintenance Jobs (SQL Server Management Studio)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0dc485a0-5a50-41eb-a29d-f2b2fb920174
manager: jhubbard
---
# Run Replication Maintenance Jobs (SQL Server Management Studio)
Replication uses the following maintenance jobs:  
  
-   **Reinitialize subscriptions having data validation failures**  
  
-   **Agent history clean up: distribution**  
  
-   **Replication monitoring refresher for distribution.**  
  
-   **Replication agents checkup**  
  
-   **Distribution clean up: distribution**  
  
-   **Expired subscription clean up**  
  
 Start and stop these jobs from the **Jobs** folder in [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] and from the **Agents** tab in Replication Monitor. For information about starting Replication Monitor, see [Start the Replication Monitor](../../Topics/TopicNameNotContainA/Start-the-Replication-Monitor.md). View and modify properties for each job in the **Job Properties - <Job\>** dialog box, which is available from the same folder and tab.  
  
### To start or stop a replication maintenance job in Management Studio  
  
1.  Connect to the Distributor in [!INCLUDE[ssManStudio](../../Topics/TopicNameContainA/includes/ssManStudio_md.md)], and then expand the server node.  
  
2.  Expand the **SQL Server Agent** folder, and then expand the **Jobs** folder.  
  
3.  Right-click a job, and then click **Start Job** or **Stop Job**.  
  
### To start or stop a replication maintenance job in Replication Monitor  
  
1.  Expand a Publisher group in Replication Monitor, and then select a Publisher.  
  
2.  Click the **Agents** tab.  
  
3.  Right-click a job in the grid, and then click **Start Job** or **Stop Job**.  
  
### To view and modify properties for a replication maintenance job in Management Studio  
  
1.  Connect to the Distributor in [!INCLUDE[ssManStudio](../../Topics/TopicNameContainA/includes/ssManStudio_md.md)], and then expand the server node.  
  
2.  Expand the **SQL Server Agent** folder, and then expand the **Jobs** folder.  
  
3.  Right-click a job, and then click **Properties**.  
  
4.  In the **Job Properties - <Job\>** dialog box, modify any properties if necessary, and then click **OK**.  
  
### To view and modify properties for a replication maintenance job in Replication Monitor  
  
1.  Expand a Publisher group in Replication Monitor, and then select a Publisher.  
  
2.  Click the **Agents** tab.  
  
3.  Right-click a job in the grid, and then click **Properties**.  
  
4.  In the **Job Properties - <Job\>** dialog box, modify any properties if necessary, and then click **OK**.  
  
## See Also  
 [Start and Stop a Replication Agent (SQL Server Management Studio)](../../Topics/TopicNameContainA/Start-and-Stop-a-Replication-Agent--SQL-Server-Management-Studio-.md)   
 [View Information and Perform Tasks for a Publisher (Replication Monitor)](../../Topics/TopicNameContainA/View-Information-and-Perform-Tasks-for-a-Publisher--Replication-Monitor-.md)   
 [Replication Agent Administration](../../Topics/TopicNameNotContainA/Replication-Agent-Administration.md)