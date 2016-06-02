---
title: SQL Server Service Broker
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8b8b3b57-fd46-44de-9a4e-e3a8e3999c1e
---
# SQL Server Service Broker
  [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)] provides native support for messaging and queuing applications in the [!INCLUDE[ssDEnoversion](../../Token\Other/ssDEnoversion_md.md)]. This makes it easier for developers to create sophisticated applications that use the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] components to communicate between disparate databases. Developers can use [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)] to easily build distributed and reliable applications.  
  
 Application developers who use [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)] can distribute data workloads across several databases without programming complex communication and messaging internals. This reduces development and test work because [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)] handles the communication paths in the context of a conversation. It also improves performance. For example, front\-end databases supporting Web sites can record information and send process intensive tasks to queue in back\-end databases. [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)] ensures that all tasks are managed in the context of transactions to assure reliability and technical consistency.  
  
## Where is the documentation for Service Broker?  
 The reference documentation for [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)] is included in the [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] documentation. This reference documentation includes the following sections:  
  
-   [Data Definition Language &#40;DDL&#41; Statements &#40;Transact-SQL&#41;](../Topic/Data%20Definition%20Language%20\(DDL\)%20Statements%20\(Transact-SQL\).md) for CREATE, ALTER, and DROP statements  
  
-   [Service Broker Statements](../Topic/Service%20Broker%20Statements.md)  
  
-   [Service Broker Catalog Views &#40;Transact-SQL&#41;](../Topic/Service%20Broker%20Catalog%20Views%20\(Transact-SQL\).md)  
  
-   [Service Broker Related Dynamic Management Views &#40;Transact-SQL&#41;](../Topic/Service%20Broker%20Related%20Dynamic%20Management%20Views%20\(Transact-SQL\).md)  
  
-   [ssbdiagnose Utility &#40;Service Broker&#41;](../Topic/ssbdiagnose%20Utility%20\(Service%20Broker\).md)  
  
 See the [previously published documentation](http://go.microsoft.com/fwlink/?LinkId=231312) for [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)] concepts and for development and management tasks. This documentation is not reproduced in the [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] documentation due to the small number of changes in [!INCLUDE[ssSB](../../Token\Other/ssSB_md.md)] in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)].  
  
## What's new in Service Broker  
 No significant changes are introduced in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)].  The following changes were introduced in [!INCLUDE[ssSQL11](../../Token\Other/ssSQL11_md.md)].  
  
### Messages can be sent to multiple target services \(multicast\)  
 The syntax of the [SEND &#40;Transact-SQL&#41;](../Topic/SEND%20\(Transact-SQL\).md) statement has been extended to enable multicast by supporting multiple conversation handles.  
  
### Queues expose the message enqueued time  
 Queues have a new column, **message\_enqueue\_time**, that shows how long a message has been in the queue.  
  
### Poison message handling can be disabled  
 The [CREATE QUEUE &#40;Transact-SQL&#41;](../Topic/CREATE%20QUEUE%20\(Transact-SQL\).md) and [ALTER QUEUE &#40;Transact-SQL&#41;](../Topic/ALTER%20QUEUE%20\(Transact-SQL\).md) statements now have the ability to enable or disable poison message handling by adding the clause, `POISON_MESSAGE_HANDLING (STATUS = ON | OFF)`. The catalog view **sys.service\_queues** now has the column **is\_poison\_message\_handling\_enabled** to indicate whether poison message is enabled or disabled.  
  
### Always On support in Service Broker  
 For more information, see [Service Broker with AlwaysOn Availability Groups &#40;SQL Server&#41;](../Topic/Service%20Broker%20with%20AlwaysOn%20Availability%20Groups%20\(SQL%20Server\).md).  
  
  