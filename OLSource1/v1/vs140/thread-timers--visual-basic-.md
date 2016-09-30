---
title: "Thread Timers (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 809cba93-cc93-4e21-afda-f299f9a39818
caps.latest.revision: 3
---
# Thread Timers (Visual Basic)
The \<xref:System.Threading.Timer*?displayProperty=fullName> class is useful for periodically running a task on a separate thread. For example, you could use a thread timer to check the status and integrity of a database or to back up critical files.  
  
## Thread Timer Example  
 The following example starts a task every two seconds and uses a flag to initiate the \<xref:System.IDisposable.Dispose*> method that stops the timer. This example posts status to the output window.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Thread timers are particularly useful when the \<xref:System.Windows.Forms.Timer*?displayProperty=fullName> object is unavailable, such as when you are developing console applications.  
  
## See Also  
 \<xref:System.Threading*>   
 [Multithreaded Applications (Visual Basic)](../vs140/multithreaded-applications--visual-basic-.md)