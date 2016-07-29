---
title: "Change Workload Group Settings"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 73b6109c-2ad0-4915-b11b-d40d5a0fdc25
caps.latest.revision: 16
manager: jhubbard
---
# Change Workload Group Settings
You can change workload group settings by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)].  
  
-   **Before you begin:**  [Limitations and Restrictions](#LimitationsRestrictions), [Permissions](#Permissions)  
  
-   **To change the settings for a workload group, using:**  [SQL Server Management Studio](#ChgWGProp), [Transact-SQL](#ChgWGTSQL)  
  
## Before You Begin  
  
###  <a name="LimitationsRestrictions"></a> Limitations and Restrictions  
 You can change the settings of the default workload group and user-defined workload groups.  
  
 **REQUEST_MAX_MEMORY_GRANT_PERCENT**  
  
 The memory consumed by index creation on a non-aligned partitioned table is proportional to the number of partitions involved. If the total required memory exceeds the per-query limit, (REQUEST_MAX_MEMORY_GRANT_PERCENT) imposed by the workload group setting, this index creation may fail. Because the default workload group allows a query to exceed the per-query limit with the minimum required memory to start for SQL Server 2005 compatibility, the user may be able to run the same index creation in the default workload group, if the default resource pool has enough total memory configured to run such a query.  
  
 Index creation is allowed to use more memory workspace than initially granted for performance. This special handling is supported by Resource Governor, however, the initial grant and any additional memory grant are limited by the workload group and resource pool settings.  
  
###  <a name="Permissions"></a> Permissions  
 Changing workload group settings requires CONTROL SERVER permission.  
  
##  <a name="ChgWGProp"></a> Change Workload Group Settings Using SQL Server Management Studio  
 **To change workload group settings by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)]**  
  
1.  In Object Explorer, recursively expand the **Management** node down to and including the **Workload Groups** folder that contains the workload group to be modified.  
  
2.  Right-click the workload group to be modified, and then click **Properties**.  
  
3.  In the **Resource Governor Properties** page, select the row for the workload group in the **Workload groups for resource pool** grid if it is not automatically selected.  
  
4.  Click or double-click the cells in the row to be changed, and enter the new values.  
  
5.  To save the changes, click **OK**  
  
##  <a name="ChgWGTSQL"></a> Change Workload Group Settings Using Transact-SQL  
 **To change workload group settings by using Transact-SQL**  
  
1.  Run the ALTER WORKLOAD GROUP statement specifying the property values to be changed.  
  
2.  Run the ALTER RESOURCE GOVERNOR RECONFIGURE statement.  
  
### Example (Transact-SQL)  
 The following example changes the max memory grant percent setting for the workload group named `groupAdhoc`.  
  
```  
ALTER WORKLOAD GROUP groupAdhoc  
WITH (REQUEST_MAX_MEMORY_GRANT_PERCENT = 30);  
GO  
ALTER RESOURCE GOVERNOR RECONFIGURE;  
GO  
```  
  
## See Also  
 [Resource Governor](../../Topics/TopicNameNotContainA/Resource-Governor.md)   
 [Create a Workload Group](../../Topics/TopicNameContainA/Create-a-Workload-Group.md)   
 [Create a Resource Pool](../../Topics/TopicNameContainA/Create-a-Resource-Pool.md)   
 [Change Resource Pool Settings](../../Topics/TopicNameNotContainA/Change-Resource-Pool-Settings.md)   
 [ALTER WORKLOAD GROUP (Transact-SQL)](assetId:///957addce-feb0-4e54-893e-5faca3cd184c)   
 [ALTER RESOURCE POOL (Transact-SQL)](assetId:///9c1c4cfb-0e3b-4f01-bf57-3fce94c7d1d4)   
 [ALTER RESOURCE GOVERNOR (Transact-SQL)](assetId:///442c54bf-a0a6-4108-ad20-db910ffa6e3c)