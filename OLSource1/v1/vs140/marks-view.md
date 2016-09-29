---
title: "Marks View"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.performance.view.marks"
helpviewer_keywords: 
  - "profiling tools, Marks view"
  - "profiling tools reports, Marks view"
ms.assetid: b2773344-8081-4116-85a1-58f770448f6a
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Marks View
The Marks view displays sampling and ETW events that were inserted into the application.  
  
 The default marks that are prepopulated in the report label the start of the program and the end of the program.  
  
 Windows counters data from automatically generated marks is also presented in this view. For more information, see [How to: Collect Windows Counter Data](../vs140/how-to--collect-windows-counter-data.md).  
  
 To create a filter between two marks, select the marks, right-click, and then click **Add Filter by Marks** or **Add Filter by Timestamp**.  
  
 The following table provides the definitions of columns that are available in the Marks view.  
  
 **Mark ID**  
 Unique Identifier of the profiling mark.  
  
 **Mark Name**  
 The name of the event.  
  
 **Timestamp**  
 Time from the start of profiling to the time that the event is recorded.  
  
 Windows performance counter data  
 When Windows performance counter data is collected the values are displayed in a column that has the name of the counter.  
  
## See Also  
 [Profiling Tools Report Overview](../vs140/performance-report-overview.md)   
 [How to: Configure Profiling Marks](../Topic/%3CPAVE_OVER%3E%20How%20to:%20Configure%20Profiling%20Marks_deleted.md)   
 [How to: Insert Marks in a Profiler Data File](../Topic/%3CPAVE_OVER%3E%20How%20to:%20Insert%20Marks%20in%20a%20Profiler%20Data%20File_deleted.md)   
 [How to: Collect Windows Counter Data](../vs140/how-to--collect-windows-counter-data.md)   
 [&#91;NIB&#93; Data Collection Control Window](assetId:///98d740d8-459f-4605-bf04-fb17aafaaa8f)