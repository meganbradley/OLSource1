---
title: Correlate a Trace with Windows Performance Log Data
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1e4412c8-d27c-4aae-9b35-214128d1d00a
---
# Correlate a Trace with Windows Performance Log Data
  Using [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)], you can open a Microsoft Windows performance log, choose the counters you want to correlate with a trace, and display the selected performance counters alongside the trace in the [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)] graphical user interface. When you select an event in the trace window, a vertical red bar in the System Monitor data window pane of [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)] indicates the performance log data that correlates with the selected trace event.  
  
 To correlate a trace with performance counters, open a trace file or table that contains the **StartTime** and **EndTime** data columns, and then click **Import Performance Data** on the [!INCLUDE[ssSqlProfiler](../../Token\Other/ssSqlProfiler_md.md)] **File** menu. You can then open a performance log, and select the System Monitor objects and counters that you want to correlate with the trace.  
  
## See Also  
 [Correlate a Trace with Windows Performance Log Data &#40;SQL Server Profiler&#41;](../Topic/Correlate%20a%20Trace%20with%20Windows%20Performance%20Log%20Data%20\(SQL%20Server%20Profiler\).md)  
  
  