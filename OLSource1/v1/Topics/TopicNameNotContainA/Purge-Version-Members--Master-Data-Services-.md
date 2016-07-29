---
title: "Purge Version Members (Master Data Services)"
ms.custom: 
  - SQL2016_New_Updated
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: adecce2d-46bb-49ff-8be9-0b31b8dd3cb6
caps.latest.revision: 8
manager: jhubbard
---
# Purge Version Members (Master Data Services)
In [!INCLUDE[ssMDSshort](../../Topics/TopicNameContainA/includes/ssMDSshort_md.md)], deleting a member only deactivates, or soft-deletes, it. The  data still resides in the database. This topic describes how to purge (permanently delete) all soft-deleted members in a model version.  
  
## Prerequisites  
 To perform this procedure.  
  
-   You must have permission to access the Version Management functional area.  
  
-   You must be a model administrator. For more information, see [Administrators (Master Data Services)](../../Topics/TopicNameNotContainA/Administrators--Master-Data-Services-.md).  
  
## To purge soft-deleted members  
  
1.  In [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)], click **Version Management**.  
  
2.  On the **Manage Versions** page, select the model that has the version that you want to purge. The list of model versions is displayed.  
  
3.  Select the row for the version that you want to purge.  
  
4.  Click **Purge Members**.  
  
5.  Click "OK" on the confirmation prompt.  
  
## Additional Methods to Purge Members  
 Purging version members permanently delete soft-deleted members in all entities pertaining to the selected version. A more finely grained alternative is to use entity base staging to permanently delete only specific members of an entity. Also, entity administrators with Explorer functional permission may purge an entity version in the entity explorer page.  
  
 For more information, see [Leaf Member Staging Table (Master Data Services)](../../Topics/TopicNameNotContainA/Leaf-Member-Staging-Table--Master-Data-Services-.md)