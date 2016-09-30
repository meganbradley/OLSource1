---
title: "Thread Timers (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 52ed71e8-4fd9-43a4-ae40-04cce7cff23f
caps.latest.revision: 7
---
# Thread Timers (C#)
The \<xref:System.Threading.Timer*?displayProperty=fullName> class is useful for periodically running a task on a separate thread. For example, you could use a thread timer to check the status and integrity of a database or to back up critical files.  
  
## Thread Timer Example  
 The following example starts a task every two seconds and uses a flag to initiate the \<xref:System.IDisposable.Dispose*> method that stops the timer. This example posts status to the output window.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Thread timers are particularly useful when the \<xref:System.Windows.Forms.Timer*?displayProperty=fullName> object is unavailable, such as when you are developing console applications.  
  
## See Also  
 \<xref:System.Threading*>   
 [Multithreaded Applications (C#)](../vs140/multithreaded-applications--csharp-.md)