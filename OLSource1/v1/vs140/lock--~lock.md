---
title: "lock::~lock"
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
  - "~lock"
  - "msclr.lock.~lock"
  - "lock.~lock"
  - "msclr::lock::~lock"
  - "lock::~lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~lock destructor"
ms.assetid: 55fa9f6c-d7a6-48ef-9236-ee03342c1d20
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lock::~lock
Destructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The destructor calls [lock::release](../vs140/lock--release.md).  
  
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
 [lock::lock](../vs140/lock--lock.md)