---
title: "Memory Management Time"
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
  - "vs.cv.threads.timeline.paging"
helpviewer_keywords: 
  - "Concurrency Visualizer, Paging Time"
ms.assetid: 67af3509-3a7d-435d-bc37-5262448da915
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Memory Management Time
These segments in the timeline are associated with blocking times that are categorized as Memory Management. This implies that a thread is blocked by an event that is associated with a memory management operation such as Paging. During this time, a thread has been blocked in an API or kernel state that the Concurrency Visualizer is counting as memory management. These include events such as paging and memory allocation.  
  
 Examine the associated call stacks and profile reports to better understand the underlying reasons for blocks that are categorized as Memory Management.  
  
## See Also  
 [Threads View (Parallel Performance)](../VS_csharp/threads-view--parallel-performance-.md)