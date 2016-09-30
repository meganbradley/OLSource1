---
title: "How to: Read Windows Performance Counters (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Read Windows Performance Counters (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "performance counters"
  - "performance counters, reading Windows performance counters"
  - "performance monitoring, Windows performance counters"
  - "performance, counters"
  - "counters, reading Windows performance counters"
  - "performance"
  - "performance monitoring"
ms.assetid: 9e1c836c-cb0f-4f37-9a93-3dca6412d6b1
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Read Windows Performance Counters (C++-CLI)
Some applications and Windows subsystems expose performance data through the Windows performance system. These counters can be accessed using the \<xref:System.Diagnostics.PerformanceCounterCategory*> and \<xref:System.Diagnostics.PerformanceCounter*> classes, which reside in the \<xref:System.Diagnostics*?displayProperty=fullName> namespace.  
  
 The following code example uses these classes to retrieve and display a counter that is updated by Windows to indicate the percentage of time that the processor is busy.  
  
> [!NOTE]
>  This example requires administrative privileges to run on Windows Vista.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Introduction to Monitoring Performance](assetId:///d40f10b9-e2b7-4ec8-a9b3-706929e5bf35)   
 [Windows Operations in C++](../vs140/windows-operations--c---cli-.md)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)