---
title: "lock_when Enum"
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
  - "msclr::lock_when"
  - "msclr.lock_when"
  - "lock_when"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lock_when enum"
ms.assetid: 6b87bbe9-63cd-450d-a02e-bb91ffd0dcea
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lock_when Enum
Specifies deferred locking.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When passed to [lock::lock](../vs140/lock--lock.md), <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> specifies that the lock is not to be taken now.  
  
## Example  
 This example uses a single instance of a class across multiple threads.  The class uses a lock on itself to ensure that accesses to its internal data are consistent for each thread.  The main application thread uses a lock on the same instance of the class to periodically check to see if any worker threads still exist, and waits to exit until all worker threads have completed their tasks.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **In thread 3, Counter = 0**  
**In thread 3, Counter = 10**  
**In thread 5, Counter = 0**  
**In thread 5, Counter = 10**  
**In thread 7, Counter = 0**  
**In thread 7, Counter = 10**  
**In thread 4, Counter = 0**  
**In thread 4, Counter = 10**  
**In thread 6, Counter = 0**  
**In thread 6, Counter = 10**  
**All threads completed.**   
## Requirements  
 **Header file** \<msclr\lock.h>  
  
 **Namespace** msclr  
  
## See Also  
 [\<msclr\lock.h> Header](../vs140/lock.md)