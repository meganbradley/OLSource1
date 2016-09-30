---
title: "lock::is_locked"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "is_locked"
  - "msclr::lock::is_locked"
  - "lock::is_locked"
  - "msclr::lock.is_locked"
  - "lock.is_locked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lock::is_locked"
ms.assetid: d888827c-8052-47c6-87a2-8c42f60a688d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lock::is_locked
Indicates whether a lock is being held.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if a lock is held, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> otherwise.  
  
## Example  
 This example uses a single instance of a class across multiple threads.  The class uses a lock on itself to ensure that accesses to its internal data are consistent for each thread.  The main application thread uses a lock on the same instance of the class to periodically check to see if any worker threads still exist, and waits to exit until all worker threads have completed their tasks.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **In thread 3, Counter = 0**  
**In thread 3, Counter = 10**  
**In thread 5, Counter = 0**  
**In thread 5, Counter = 10**  
**In thread 4, Counter = 0**  
**In thread 4, Counter = 10**  
**In thread 7, Counter = 0**  
**In thread 7, Counter = 10**  
**In thread 6, Counter = 0**  
**In thread 6, Counter = 10**  
**All threads completed.**   
## Requirements  
 **Header file** \<msclr\lock.h>  
  
 **Namespace** msclr  
  
## See Also  
 [lock Members](../vs140/lock-members.md)   
 [lock::operator bool](../vs140/lock--operator-bool.md)