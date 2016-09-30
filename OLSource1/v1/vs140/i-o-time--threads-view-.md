---
title: "I-O Time (Threads View)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "I/O Time (Threads View)"
f1_keywords: 
  - "vs.cv.threads.timeline.io"
helpviewer_keywords: 
  - "Concurrency Visualizer, I/O time (Threads View)"
ms.assetid: 0c4ec14d-d8dd-49c1-999c-dcbf4e8e1dc8
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# I-O Time (Threads View)
These segments in the timeline are associated with blocking times that are categorized as I/O. This means that a thread is waiting for an I/O operation to finish. The thread may have been blocked in an API, or by an I/O-related kernel wait that the Concurrency Visualizer is counting as I/O. APIs such as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> fall into this group.  
  
## See Also  
 [Threads View (Parallel Performance)](../vs140/threads-view--parallel-performance-.md)