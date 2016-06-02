---
title: Set Up FILESTREAM on a Failover Cluster
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-blob
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6721f780-20b7-4109-8ddb-ac327310699e
---
# Set Up FILESTREAM on a Failover Cluster
  This topic describes how to enable FILESTREAM on a failover cluster. Before you try this procedure, you should understand [failover clustering](../Topic/AlwaysOn%20Failover%20Cluster%20Instances%20\(SQL%20Server\).md) and have FILESTREAM enabled. For information about how to enable FILESTREAM, see [Enable and Configure FILESTREAM](../../Topics\TopicNameNotContainA/Enable-and-Configure-FILESTREAM.md).  
  
### To set up FILESTREAM on a failover cluster  
  
1.  Set up the primary node for the failover cluster.  
  
     After the setup finishes, enable FILESTREAM on the primary node by using **SQL Server Configuration Manager**. This enables the settings that require Windows Admin privileges. If remote access is required, select **Allow remote clients to have streaming access to FILESTREAM data**. This will create a file\-share cluster resource.  
  
2.  Set up a passive node.  
  
     After the setup finishes, enable FILESTREAM on the passive node by using **SQL Server Configuration Manager**. The name that you specify for **Windows Share Name** must be the same across all nodes in the cluster.  
  
3.  To add more passive nodes, repeat step 2.  
  
4.  After all the nodes are added, complete the process by executing the sp\_configure stored procedure on each instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)].  
  
5.  To add and enable additional nodes to the cluster at any time, you can repeat steps 2, 3, and 4.  
  
## See Also  
 [Server Configuration Options &#40;SQL Server&#41;](../Topic/Server%20Configuration%20Options%20\(SQL%20Server\).md)   
 [Create a New SQL Server Failover Cluster &#40;Setup&#41;](../Topic/Create%20a%20New%20SQL%20Server%20Failover%20Cluster%20\(Setup\).md)   
 [Remove a SQL Server Failover Cluster Instance &#40;Setup&#41;](../Topic/Remove%20a%20SQL%20Server%20Failover%20Cluster%20Instance%20\(Setup\).md)   
 [Add or Remove Nodes in a SQL Server Failover Cluster &#40;Setup&#41;](../Topic/Add%20or%20Remove%20Nodes%20in%20a%20SQL%20Server%20Failover%20Cluster%20\(Setup\).md)  
  
  