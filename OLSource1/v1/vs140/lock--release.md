---
title: "lock::release"
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
  - "lock.release"
  - "msclr::lock::release"
  - "lock::release"
  - "msclr.lock.release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lock::release"
ms.assetid: b73d48fc-cf98-4b78-b39d-813d4a12fa84
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lock::release
Releases a lock.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If no lock is being held, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> does nothing.  
  
 You do not have to call this function explicitly; when a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object goes out of scope, its destructor calls <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
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
 [lock Members](../vs140/lock-members.md)   
 [lock::~lock](../vs140/lock--~lock.md)