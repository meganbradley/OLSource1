---
title: common criteria compliance enabled Server Configuration Option
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 61766eea-c450-408d-af33-fbe7ef8c9ff2
---
# common criteria compliance enabled Server Configuration Option
  The common criteria compliance enabled option enables the following elements that are required for the Common Criteria.  
  
|Criteria|Description|  
|--------------|-----------------|  
|Residual Information Protection \(RIP\)|RIP requires a memory allocation to be overwritten with a known pattern of bits before memory is reallocated to a new resource. Meeting the RIP standard can contribute to improved security; however, overwriting the memory allocation can slow performance. After the common criteria compliance enabled option is enabled, the overwriting occurs.|  
|The ability to view login statistics|After the common criteria compliance enabled option is enabled, login auditing is enabled. Each time a user successfully logs in to [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], information about the last successful login time, the last unsuccessful login time, and the number of attempts between the last successful and current login times is made available. These login statistics can be viewed by querying the [sys.dm\_exec\_sessions](../Topic/sys.dm_exec_sessions%20\(Transact-SQL\).md) dynamic management view.|  
|That column GRANT should not override table DENY|After the common criteria compliance enabled option is enabled, a table\-level DENY takes precedence over a column\-level GRANT. When the option is not enabled, a column\-level GRANT takes precedence over a table\-level DENY.|  
  
 The common criteria compliance enabled option is an advanced option. Common criteria is only evaluated and certified for the Enterprise edition and Datacenter edition. For the latest status of common criteria certification, see the [Microsoft SQL Server Common Criteria](http://go.microsoft.com/fwlink/?LinkId=616319) Web site.  
  
> [!IMPORTANT]  
>  In addition to enabling the common criteria compliance enabled option, you also must download and run a script that finishes configuring [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] to comply with Common Criteria Evaluation Assurance Level 4\+ \(EAL4\+\). You can download this script from the [Microsoft SQL Server Common Criteria](http://go.microsoft.com/fwlink/?LinkId=616319) Web site.  
  
 If you are using the sp\_configure system stored procedure to change the setting, you can change common criteria compliance enabled only when show advanced options is set to 1. The setting takes effect after the server is restarted. The possible values are 0 and 1:  
  
-   0 indicates that common criteria compliance is not enabled. This is the default.  
  
-   1 indicates that common criteria compliance is enabled.  
  
## Examples  
 The following example enables common criteria compliance.  
  
```  
sp_configure 'show advanced options', 1;  
GO  
RECONFIGURE;  
GO  
sp_configure 'common criteria compliance enabled', 1;  
GO  
RECONFIGURE  
GO  
```  
  
## See Also  
 [Server Configuration Options &#40;SQL Server&#41;](../Topic/Server%20Configuration%20Options%20\(SQL%20Server\).md)  
  
  