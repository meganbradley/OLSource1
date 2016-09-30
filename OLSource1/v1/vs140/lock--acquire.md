---
title: "lock::acquire"
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
  - "lock::acquire"
  - "acquire"
  - "msclr.lock.acquire"
  - "msclr::lock::acquire"
  - "lock.acquire"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "acquire method"
ms.assetid: c214274e-7519-4739-82aa-91b04a32d3f9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lock::acquire
Acquires a lock on an object, optionally waiting to acquire the lock forever, for a specified amount of time, or not at all.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Timeout value in milliseconds or as a \<xref:System.TimeSpan*>.  
  
## Exceptions  
 Throws \<xref:System.ApplicationException*> if lock acquisition does not occur before timeout.  
  
## Remarks  
 If a timeout value is not supplied, the default timeout is \<xref:System.Threading.Timeout.Infinite*>.  
  
 If a lock has already been acquired, this function does nothing.  
  
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
 [lock::try_acquire](../vs140/lock--try_acquire.md)