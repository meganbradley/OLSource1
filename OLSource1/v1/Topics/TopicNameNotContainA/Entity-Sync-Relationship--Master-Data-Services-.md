---
title: "Entity Sync Relationship (Master Data Services)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bd627a2d-dc64-47e9-9a71-2d0ad04b4962
caps.latest.revision: 7
manager: jhubbard
---
# Entity Sync Relationship (Master Data Services)
Entity sync is a one-way and repeatable synchronization between entity versions. It enables you to share entity data between different models. You can keep a single source of truth in one model and reuse this master data in other models. For example, you can store US state data in one model entity and reuse that data in other models.  
  
 With entity sync, you can also make a one-time copy of data.  
  
 All leaf members with free-form and file attributes in the source entity are synced to the target entity during sync execution. This creates, deletes and modifies entity schema and members.  
  
 Once a sync relationship has been established, the target entity can be modified only by the sync process. A sync relationship can be removed at any time to make the target entity editable.  
  
## See Also  
 [Create and Execute an Entity Sync Relationship (Master Data Services)](../../Topics/TopicNameNotContainA/Create-and-Execute-an-Entity-Sync-Relationship--Master-Data-Services-.md)   
 [Edit and Delete an Entity Sync Relationship (Master Data Services)](../../Topics/TopicNameNotContainA/Edit-and-Delete-an-Entity-Sync-Relationship--Master-Data-Services-.md)