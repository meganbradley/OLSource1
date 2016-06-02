---
title: Delete a Resource Pool
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3bdd348b-6582-4ffa-80ef-d49e50596ce5
---
# Delete a Resource Pool
  You can delete a resource pool by using either [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] or Transact\-SQL.  
  
-   **Before you begin:**  [Limitations and Restrictions](#LimitationsRestrictions), [Permissions](#Permissions)  
  
-   **To delete a resource pool, using:** [SQL Server Management Studio](#DelRPSSMS), [Transact\-SQL](#DelRPTSQL)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
 You cannot delete a resource pool if it contains workload groups.  
  
###  <a name="LimitationsRestrictions"></a> Limitations and Restrictions  
 You cannot delete the Resource Governor default or internal resource pools. You cannot delete a resource pool if it contains workload groups. For more information, see [Delete a Workload Group](../../Topics\TopicNameContainA/Delete-a-Workload-Group.md).  
  
###  <a name="Permissions"></a> Permissions  
 Deleting a resource pool requires CONTROL SERVER permission.  
  
##  <a name="DelRPSSMS"></a> Delete a Resource Pool Using Object Explorer  
 **To delete a resource pool by using SQL Server Management Studio**  
  
1.  In [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)], open Object Explorer and recursively expand the **Management** node down to and including **Resource Governor**.  
  
2.  Right\-click the resource pool to be deleted, and then click **Delete**.  
  
3.  In the **Delete Object** window, the resource pool is listed in the **Object to be deleted** list. To delete the resource pool, click **OK**.  
  
    > [!NOTE]  
    >  If the resource pool that you are trying to delete contains a workload group, this action will fail.  
  
##  <a name="DelRPTSQL"></a> Delete a Resource Pool Using Transact\-SQL  
 **To delete a resource pool by using Transact\-SQL**  
  
1.  Run the **DROP RESOURCE POOL** or **DROP EXTERNAL RESOURCE POOL** statement specifying the name of the resource pool to delete.  
  
2.  Run the **ALTER RESOURCE GOVERNOR RECONFIGURE** statement.  
  
### Example \(Transact\-SQL\)  
 The following example drops a workload group named `poolAdhoc`.  
  
```  
DROP RESOURCE POOL poolAdhoc;  
GO  
ALTER RESOURCE GOVERNOR RECONFIGURE;  
GO  
```  
  
## See Also  
 [Resource Governor](../../Topics\TopicNameNotContainA/Resource-Governor.md)   
 [Resource Governor Resource Pool](../../Topics\TopicNameNotContainA/Resource-Governor-Resource-Pool.md)   
 [Create a Resource Pool](../../Topics\TopicNameContainA/Create-a-Resource-Pool.md)   
 [Change Resource Pool Settings](../../Topics\TopicNameNotContainA/Change-Resource-Pool-Settings.md)   
 [Resource Governor Workload Group](../../Topics\TopicNameNotContainA/Resource-Governor-Workload-Group.md)   
 [Resource Governor Classifier Function](../../Topics\TopicNameNotContainA/Resource-Governor-Classifier-Function.md)   
 [DROP WORKLOAD GROUP &#40;Transact-SQL&#41;](../Topic/DROP%20WORKLOAD%20GROUP%20\(Transact-SQL\).md)   
 [DROP RESOURCE POOL &#40;Transact-SQL&#41;](../Topic/DROP%20RESOURCE%20POOL%20\(Transact-SQL\).md)   
 [ALTER RESOURCE GOVERNOR &#40;Transact-SQL&#41;](../Topic/ALTER%20RESOURCE%20GOVERNOR%20\(Transact-SQL\).md)   
 [DROP EXTERNAL RESOURCE POOL &#40;Transact-SQL&#41;](../Topic/DROP%20EXTERNAL%20RESOURCE%20POOL%20\(Transact-SQL\).md)   
 [CREATE EXTERNAL RESOURCE POOL &#40;Transact-SQL&#41;](../Topic/CREATE%20EXTERNAL%20RESOURCE%20POOL%20\(Transact-SQL\).md)   
 [ALTER EXTERNAL RESOURCE POOL &#40;Transact-SQL&#41;](../Topic/ALTER%20EXTERNAL%20RESOURCE%20POOL%20\(Transact-SQL\).md)  
  
  