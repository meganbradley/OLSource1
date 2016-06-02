---
title: Natively Compiled Stored Procedures and Execution Set Options
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine-imoltp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c1869cf7-9030-4d18-85d6-0e419a4e9af7
---
# Natively Compiled Stored Procedures and Execution Set Options
  Session options are fixed in atomic blocks. A stored procedure's execution is not affected by a session's SET options. However, certain SET options, such as SET NOEXEC and SET SHOWPLAN\_XML, cause stored procedures \(including natively compiled stored procedures\) to not execute.  
  
 When a natively compiled stored procedure is executed with any STATISTICS option turned on, statistics are gathered for the procedure as a whole and not per statement. For more information, see [SET STATISTICS IO &#40;Transact-SQL&#41;](../Topic/SET%20STATISTICS%20IO%20\(Transact-SQL\).md), [SET STATISTICS PROFILE &#40;Transact-SQL&#41;](../Topic/SET%20STATISTICS%20PROFILE%20\(Transact-SQL\).md), [SET STATISTICS TIME &#40;Transact-SQL&#41;](../Topic/SET%20STATISTICS%20TIME%20\(Transact-SQL\).md), and [SET STATISTICS XML &#40;Transact-SQL&#41;](../Topic/SET%20STATISTICS%20XML%20\(Transact-SQL\).md). To obtain execution statistics on a per\-statement level in natively compiled stored procedures, use an Extended Event session on the sp\_statement\_completed event, which starts when each individual query in a stored procedures execution completes. For more information on creating Extended Event sessions, see [CREATE EVENT SESSION &#40;Transact-SQL&#41;](../Topic/CREATE%20EVENT%20SESSION%20\(Transact-SQL\).md).  
  
 **SHOWPLAN\_XML** is supported for natively compiled stored procedures. **SHOWPLAN\_ALL** and **SHOWPLAN\_TEXT** are not supported with natively compiled stored procedures.  
  
 **SET FMTONLY** in not supported with natively compiled stored procedures. Use [sp_describe_first_result_set &#40;Transact-SQL&#41;](../Topic/sp_describe_first_result_set%20\(Transact-SQL\).md) instead.  
  
## See Also  
 [Natively Compiled Stored Procedures](../../Topics\TopicNameNotContainA/Natively-Compiled-Stored-Procedures.md)  
  
  