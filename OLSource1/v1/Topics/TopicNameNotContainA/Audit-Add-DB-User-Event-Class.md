---
title: "Audit Add DB User Event Class"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ac9ed573-c84d-444c-81fb-923a6240c1ef
caps.latest.revision: 32
manager: jhubbard
---
# Audit Add DB User Event Class
The **Audit Add DB User** event class occurs whenever a login is added or removed as a database user to a database. This event class is used for the **sp_grantdbaccess**, **sp_revokedbaccess**, **sp_adduser**, and **sp_dropuser** stored procedures.  
  
 This event class may be removed in a future version of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. It is recommended that you use the **Audit Database Principal Management** event class instead.  
  
## Audit Add DB User Event Class Data Columns  
  
|Data column name|Data type|Description|Column ID|Filterable|  
|----------------------|---------------|-----------------|---------------|----------------|  
|**ApplicationName**|**nvarchar**|Name of the client application that created the connection to an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. This column is populated with the values passed by the application rather than the displayed name of the program.|10|Yes|  
|**ClientProcessID**|**int**|ID assigned by the host computer to the process where the client application is running. This data column is populated if the client process ID is provided by the client.|9|Yes|  
|**ColumnPermissions**|**int**|Indicator of whether a column permission was set. Parse the statement text to determine which permissions were applied to which columns.|44|Yes|  
|**DatabaseID**|**int**|ID of the database specified by the USE *database* statement or the default database if no USE *database* statement has been issued for a given instance. [!INCLUDE[ssSqlProfiler](../../Topics/TopicNameContainA/includes/ssSqlProfiler_md.md)] displays the name of the database if the **ServerName** data column is captured in the trace and the server is available. Determine the value for a database by using the DB_ID function.|3|Yes|  
|**DatabaseName**|**nvarchar**|Name of the database where the username is being added or removed.|35|Yes|  
|**DBUserName**|**nvarchar**|Issuer’s username in the database.|40|Yes|  
|**EventClass**|**int**|Type of event = 109.|27|No|  
|**EventSequence**|**int**|Sequence of a given event within the request.|51|No|  
|**EventSubClass**|**int**|Type of event subclass.<br /><br /> 1=Add<br /><br /> 2=Drop<br /><br /> 3=Grant database access<br /><br /> 4=Revoke database access|21|Yes|  
|**HostName**|**nvarchar**|Name of the computer on which the client is running. This data column is populated if the host name is provided by the client. To determine the host name, use the HOST_NAME function.|8|Yes|  
|**IsSystem**|**int**|Indicates whether the event occurred on a system process or a user process. 1 = system, 0 = user.|60|Yes|  
|**LoginName**|**nvarchar**|Name of the login of the user (either the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] security login or the [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Windows login credentials in the form of DOMAIN\username).|11|Yes|  
|**LoginSid**|**image**|Security identification number (SID) of the logged-in user. You can find this information in the **sys.server_principals** catalog view. Each SID is unique for each login in the server.|41|Yes|  
|**NTDomainName**|**nvarchar**|Windows domain to which the user belongs.|7|Yes|  
|**NTUserName**|**nvarchar**|Windows user name.|6|Yes|  
|**OwnerName**|**nvarchar**|Database user name of the object owner.|37|Yes|  
|**RequestID**|**int**|ID of the request containing the statement.|49|Yes|  
|**RoleName**|**nvarchar**|Name of the database role whose membership is being modified (if done with **sp_adduser**).|38|Yes|  
|**ServerName**|**nvarchar**|Name of the instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] being traced.|26||  
|**SessionLoginName**|**Nvarchar**|Login name of the user who originated the session. For example, if you connect to [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] using Login1 and execute a statement as Login2, **SessionLoginName** shows Login1 and **LoginName** shows Login2. This column displays both [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] and Windows logins.|64|Yes|  
|**SPID**|**int**|ID of the session on which the event occurred.|12|Yes|  
|**StartTime**|**datetime**|Time at which the event started, if available.|14|Yes|  
|**Success**|**int**|1 = success. 0 = failure. For example, a value of 1 indicates success of a permissions check and a value of 0 indicates failure of that check.|23|Yes|  
|**TargetLoginName**|**nvarchar**|Name of the login that is having its database access modified.|42|Yes|  
|**TargetLoginSid**|**image**|For actions that target a login (for example, adding a new login), the security identification number (SID) of the targeted login.|43|Yes|  
|**TargetUserName**|**nvarchar**|Name of the database user being added.|39|Yes|  
|**TransactionID**|**bigint**|System-assigned ID of the transaction.|4|Yes|  
|**XactSequence**|**bigint**|Token used to describe the current transaction.|50|Yes|  
  
## See Also  
 [Extended Events](../../Topics/TopicNameNotContainA/Extended-Events.md)   
 [sp_trace_setevent (Transact-SQL)](assetId:///7662d1d9-6d0f-443a-b011-c901a8b77a44)   
 [sp_grantdbaccess (Transact-SQL)](assetId:///3eb09513-03f1-42f8-9917-3a1f3a579bec)   
 [sp_revokedbaccess (Transact-SQL)](assetId:///c997cfa1-539d-485c-a664-9c6f76bfe0c2)   
 [sp_adduser (Transact-SQL)](assetId:///61a40eb4-573f-460c-9164-bd1bbfaf8b25)   
 [sp_dropuser (Transact-SQL)](assetId:///e28f18f9-7ecf-4568-89f4-fe5c520df386)   
 [Audit Database Principal Management Event Class](../../Topics/TopicNameNotContainA/Audit-Database-Principal-Management-Event-Class.md)