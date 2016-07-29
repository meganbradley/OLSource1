---
title: "SQL Server Profiler - Performance Counters Limit"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d10140ef-36c4-449c-b365-1cff1b2524e4
caps.latest.revision: 21
manager: jhubbard
---
# SQL Server Profiler - Performance Counters Limit
Use the Performance Counters Limit dialog box to limit the information from a System Monitor performance log file when correlating it with a [!INCLUDE[ssSqlProfiler](../../Topics/TopicNameContainA/includes/ssSqlProfiler_md.md)] trace. You can use this dialog box to select counters that should be displayed and used for correlation.  
  
 The **Performance Counters Limit** dialog box is populated with the performance objects and counters that the performance log file contains.  
  
### To select performance objects and counters to correlate with a trace  
  
1.  Expand a performance object to see which counters are included in the performance log file.  
  
2.  Check the counters that you want to correlate with the [!INCLUDE[ssSqlProfiler](../../Topics/TopicNameContainA/includes/ssSqlProfiler_md.md)] trace file.  
  
     If you want to select all counters for a performance object, check the box that is adjacent to the performance object. Checking the topmost node, which indicates the computer, selects all performance objects and counters contained in the performance log file.  
  
## See Also  
 [Correlate a Trace with Windows Performance Log Data (SQL Server Profiler)](../../Topics/TopicNameContainA/Correlate-a-Trace-with-Windows-Performance-Log-Data--SQL-Server-Profiler-.md)