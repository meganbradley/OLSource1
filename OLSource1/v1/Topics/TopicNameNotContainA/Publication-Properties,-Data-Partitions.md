---
title: Publication Properties, Data Partitions
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5869edb7-d05f-495b-b828-b7fd5e828d20
---
# Publication Properties, Data Partitions
  The **Data Partitions** page of the **Publication Properties** dialog box allows you to define data partitions for merge publications that use parameterized filtering. After defining partitions, you can then generate snapshots for these partitions, providing different initial data sets for different Subscribers based on the connection properties \(login and\/or computer name\) of the Subscribers. You can also select to allow Subscribers to request snapshot delivery and generation if they do not have a snapshot available for their partition the first time they synchronize. For more information, see [Create a Snapshot for a Merge Publication with Parameterized Filters](../../Topics\TopicNameContainA/Create-a-Snapshot-for-a-Merge-Publication-with-Parameterized-Filters.md).  
  
## Options  
 **Add**  
 Click **Add** to define a partition. In the **Add Data Partition** dialog box, specify values for **HOST\_NAME\(\)** and\/or **SUSER\_SNAME\(\)**, and define a schedule to refresh snapshots.  
  
 **Edit**  
 Select an existing partition in the grid, and click **Edit** to edit the partition.  
  
 **Delete**  
 Select an existing partition in the grid, and click **Delete** to delete the partition.  
  
 **Generate the selected snapshots now**  
 Select one or more partitions in the grid, and click **Generate the selected snapshots now** to generate snapshots for these partitions.  
  
 **Clean up the existing snapshots**  
 Select one or more partitions in the grid, and click **Clean up the existing snapshots** to clean up snapshots for these partitions.  
  
 **Automatically define a partition and generate a snapshot if needed when a new Subscriber tries to synchronize**  
 Select this option if you want to allow Subscribers to request snapshot generation and application. Subscribers might require this option if they do not have a snapshot available for their partition the first time they synchronize.  
  
## See Also  
 [Create a Publication](../../Topics\TopicNameContainA/Create-a-Publication.md)   
 [View and Modify Publication Properties](../../Topics\TopicNameNotContainA/View-and-Modify-Publication-Properties.md)   
 [Parameterized Row Filters](../../Topics\TopicNameNotContainA/Parameterized-Row-Filters.md)   
 [Publish Data and Database Objects](../../Topics\TopicNameNotContainA/Publish-Data-and-Database-Objects.md)   
 [Snapshots for Merge Publications with Parameterized Filters](../../Topics\TopicNameNotContainA/Snapshots-for-Merge-Publications-with-Parameterized-Filters.md)  
  
  