---
title: SQL Server Audit Records
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7a291015-df15-44fe-8d53-c6d90a157118
---
# SQL Server Audit Records
  The [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Audit feature enables you to audit server\-level and database\-level groups of events and events. For more information, see [SQL Server Audit &#40;Database Engine&#41;](../Topic/SQL%20Server%20Audit%20\(Database%20Engine\).md). [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)].  
  
 Audits consist of zero or more audit action items, which are recorded to an audit *target*. The audit target can be a binary file, the Windows Application event log or the Windows Security event log. The records sent to the target can contain the elements described in the following table.  
  
|Column name|Description|Type|Always available|  
|-----------------|-----------------|----------|----------------------|  
|**event\_time**|Date\/time when the auditable action is fired.|**datetime2**|Yes|  
|**sequence\_no**|Tracks the sequence of records within a single audit record that was too large to fit in the write buffer for audits.|**int**|Yes|  
|**action\_id**|ID of the action<br /><br /> Tip: To use **action\_id** as a predicate it must be converted from a character string to a numeric value. For more information, see [Filter SQL Server Audit on action\_id \/ class\_type predicate](http://blogs.msdn.com/b/sqlsecurity/archive/2012/10/03/filter-sql-server-audit-on-action-id-class-type-predicate.aspx).|**varchar\(4\)**|Yes|  
|**succeeded**|Indicates if the action that triggered the event succeeded|**bit** – 1 \= Success, 0 \= Fail|Yes|  
|**permission\_bitmask**|When applicable, shows the permissions that were granted, denied, or revoked|**bigint**|No|  
|**is\_column\_permission**|Flag indicating a column level permission|**bit** – 1 \= True, 0 \= False|No|  
|**session\_id**|ID of the session on which the event occurred.|**int**|Yes|  
|**server\_principal\_id**|ID of the login context that the action is performed in.|**int**|Yes|  
|**database\_principal\_id**|ID of the database user context that the action is performed in.|**int**|No|  
|**object\_ id**|The primary ID of the entity on which the audit occurred. This includes:<br /><br /> server objects<br /><br /> databases<br /><br /> database objects<br /><br /> schema objects|**int**|No|  
|**target\_server\_principal\_id**|Server principal that the auditable action applies to.|**int**|Yes|  
|**target\_database\_principal\_id**|Database principal that the auditable action applies to.|**int**|No|  
|**class\_type**|Type of auditable entity that the audit occurs on.|**varchar\(2\)**|Yes|  
|**session\_server\_principal\_name**|Server principal for the session.|**sysname**|Yes|  
|**server\_principal\_name**|Current login.|**sysname**|Yes|  
|**server\_principal\_sid**|Current login SID.|**varbinary**|Yes|  
|**database\_principal\_name**|Current user.|**sysname**|No|  
|**target\_server\_principal\_name**|Target login of the action.|**sysname**|No|  
|**target\_server\_principal\_sid**|SID of the target login.|**varbinary**|No|  
|**target\_database\_principal\_name**|Target user of the action.|**sysname**|No|  
|**server\_instance\_name**|Name of the server instance where the audit occurred. Uses the standard machine\\instance format.|**nvarchar\(120\)**|Yes|  
|**database\_name**|The database context in which the action occurred.|**sysname**|No|  
|**schema\_name**|The schema context in which the action occurred.|**sysname**|No|  
|**object\_name**|The name of the entity on which the audit occurred. This includes:<br /><br /> server objects<br /><br /> databases<br /><br /> database objects<br /><br /> schema objects<br /><br /> TSQL statement \(if any\)|**sysname**|No|  
|**statement**|TSQL statement \(if any\)|**nvarchar\(4000\)**|No|  
|**additional\_information**|Any additional information about the event, stored as XML.|**nvarchar\(4000\)**|No|  
  
## Remarks  
 Some actions do not populate a column's value because it might be non\-applicable to the action.  
  
 [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Audit stores 4000 characters of data for character fields in an audit record. When the **additional\_information** and **statement** values returned from an auditable action return more than 4000 characters, the **sequence\_no** column is used to write multiple records into the audit report for a single audit action to record this data. The process is as follows:  
  
-   The **statement** column is divided into 4000 characters.  
  
-   [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Audit writes as the first row for the audit record with the partial data. All the other fields are duplicated in each row.  
  
-   The **sequence\_no** value is incremented.  
  
-   This process is repeated until all the data is recorded.  
  
 You can connect the data by reading the rows sequentially using the **sequence\_no** value, and the **event\_Time**, **action\_id** and **session\_id** columns to identify the action.  
  
## Related Content  
 [CREATE SERVER AUDIT &#40;Transact-SQL&#41;](../Topic/CREATE%20SERVER%20AUDIT%20\(Transact-SQL\).md)  
  
 [ALTER SERVER AUDIT  &#40;Transact-SQL&#41;](../Topic/ALTER%20SERVER%20AUDIT%20%20\(Transact-SQL\).md)  
  
 [DROP SERVER AUDIT  &#40;Transact-SQL&#41;](../Topic/DROP%20SERVER%20AUDIT%20%20\(Transact-SQL\).md)  
  
 [CREATE SERVER AUDIT SPECIFICATION &#40;Transact-SQL&#41;](../Topic/CREATE%20SERVER%20AUDIT%20SPECIFICATION%20\(Transact-SQL\).md)  
  
 [ALTER SERVER AUDIT SPECIFICATION &#40;Transact-SQL&#41;](../Topic/ALTER%20SERVER%20AUDIT%20SPECIFICATION%20\(Transact-SQL\).md)  
  
 [DROP SERVER AUDIT SPECIFICATION &#40;Transact-SQL&#41;](../Topic/DROP%20SERVER%20AUDIT%20SPECIFICATION%20\(Transact-SQL\).md)  
  
 [CREATE DATABASE AUDIT SPECIFICATION &#40;Transact-SQL&#41;](../Topic/CREATE%20DATABASE%20AUDIT%20SPECIFICATION%20\(Transact-SQL\).md)  
  
 [ALTER DATABASE AUDIT SPECIFICATION &#40;Transact-SQL&#41;](../Topic/ALTER%20DATABASE%20AUDIT%20SPECIFICATION%20\(Transact-SQL\).md)  
  
 [DROP DATABASE AUDIT SPECIFICATION &#40;Transact-SQL&#41;](../Topic/DROP%20DATABASE%20AUDIT%20SPECIFICATION%20\(Transact-SQL\).md)  
  
 [ALTER AUTHORIZATION &#40;Transact-SQL&#41;](../Topic/ALTER%20AUTHORIZATION%20\(Transact-SQL\).md)  
  
 [sys.fn_get_audit_file &#40;Transact-SQL&#41;](../Topic/sys.fn_get_audit_file%20\(Transact-SQL\).md)  
  
 [sys.server_audits &#40;Transact-SQL&#41;](../Topic/sys.server_audits%20\(Transact-SQL\).md)  
  
 [sys.server_file_audits &#40;Transact-SQL&#41;](../Topic/sys.server_file_audits%20\(Transact-SQL\).md)  
  
 [sys.server_audit_specifications &#40;Transact-SQL&#41;](../Topic/sys.server_audit_specifications%20\(Transact-SQL\).md)  
  
 [sys.server_audit_specification_details &#40;Transact-SQL&#41;](../Topic/sys.server_audit_specification_details%20\(Transact-SQL\).md)  
  
 [sys.database_audit_specifications &#40;Transact-SQL&#41;](../Topic/sys.database_audit_specifications%20\(Transact-SQL\).md)  
  
 [sys.database_audit_specification_details &#40;Transact-SQL&#41;](../Topic/sys.database_audit_specification_details%20\(Transact-SQL\).md)  
  
 [sys.dm_server_audit_status &#40;Transact-SQL&#41;](../Topic/sys.dm_server_audit_status%20\(Transact-SQL\).md)  
  
 [sys.dm_audit_actions &#40;Transact-SQL&#41;](../Topic/sys.dm_audit_actions%20\(Transact-SQL\).md)  
  
 [sys.dm_audit_class_type_map &#40;Transact-SQL&#41;](../Topic/sys.dm_audit_class_type_map%20\(Transact-SQL\).md)  
  
  