---
title: Temporal Table System Consistency Checks
ms.custom: 
  - SQL2016_New_Updated
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-tables
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ec081d42-57e4-43c7-9e1c-317ba8f23437
---
# Temporal Table System Consistency Checks
  When using temporal tables, the system performs a number of consistency checks to ensure the schema complies with the requirements for temporal and the data is consistent, and remains consistent. In addition, temporal checks have been added to the **DBCC CHECKCONSTRAINTS** statement.  
  
## System Consistency Checks  
 Before **SYSTEM\_VERSIONING** is set to **ON**, a set of checks are performed on the history table and the current table. These checks are grouped into schema checks and data checks \(if history table is not empty\). In addition, the system also performs a runtime consistency check.  
  
### Schema Check  
 When creating or alter a table to become a temporal table, the system verifies that requirements are met:  
  
1.  The names and number of columns is the same in both the current table and the history table.  
  
2.  The datatypes match for each column between the current table and the history table.  
  
3.  The period columns are set to **NOT NULL**.  
  
4.  The current table has a primary key constraint and the history table does not have a primary key constraint.  
  
5.  No **IDENTITY** columns are defined in the history table.  
  
6.  No triggers are defined in the history table.  
  
7.  No foreign keys are defined in the history table.  
  
8.  No table or column constraints are defined on the history table. However, default column values on the history table are permitted.  
  
9. The history table is not placed in a read\-only filegroup.  
  
10. The history table is not configured for change tracking or change data capture.  
  
### Data Consistency Check  
 Before **SYSTEM\_VERSIONING** is set to **ON** and as part of any DML operation, the system performs the following check: **SysEndTime** ≥**SysStartTime**  
  
 When creating a link to an existing history table, you can choose to perform a data consistency check. This data consistency check ensures that existing records do not overlap and that temporal requirements are fulfilled for every individual record. Performing the data consistency check is the default. Generally, performing the data consistency is recommended whenever the data between the current and history tables may be out of sync, such as when incorporating an existing history table that is populated with history data.  
  
> [!WARNING]  
>  Manual changes to the system clock will cause the system to fail unexpectedly because the runtime data consistency checks that are in place to prevent overlap conditions \(namely that the end time for a record is not less than its start time\) will fail.  
  
## DBCC CHECKCONSTRAINTS  
 The **DBCC CHECKCONSTRAINTS** command includes temporal data consistency checks. For more information, see [DBCC CHECKCONSTRAINTS &#40;Transact-SQL&#41;](../Topic/DBCC%20CHECKCONSTRAINTS%20\(Transact-SQL\).md).  
  
## Did this Article Help You? We’re Listening  
 What information are you looking for, and did you find it? We’re listening to your feedback to improve the content. Please submit your comments to [sqlfeedback@microsoft.com](mailto:sqlfeedback@microsoft.com?subject=Your%20feedback%20about%20the%20Temporal%20Table%20System%20Consistency%20Checks%20page)  
  
## See Also  
 [Temporal Tables](../../Topics\TopicNameNotContainA/Temporal-Tables.md)   
 [Getting Started with System-Versioned Temporal Tables](../../Topics\TopicNameNotContainA/Getting-Started-with-System-Versioned-Temporal-Tables.md)   
 [Partitioning with Temporal Tables](../../Topics\TopicNameNotContainA/Partitioning-with-Temporal-Tables.md)   
 [Temporal Table Considerations and Limitations](../../Topics\TopicNameNotContainA/Temporal-Table-Considerations-and-Limitations.md)   
 [Temporal Table Security](../../Topics\TopicNameNotContainA/Temporal-Table-Security.md)   
 [Manage Retention of Historical Data in System-Versioned Temporal Tables](../../Topics\TopicNameNotContainA/Manage-Retention-of-Historical-Data-in-System-Versioned-Temporal-Tables.md)   
 [System-Versioned Temporal Tables with Memory-Optimized Tables](../../Topics\TopicNameNotContainA/System-Versioned-Temporal-Tables-with-Memory-Optimized-Tables.md)   
 [Temporal Table Metadata Views and Functions](../../Topics\TopicNameNotContainA/Temporal-Table-Metadata-Views-and-Functions.md)  
  
  