---
title: "lock::lock"
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
  - "lock::lock"
  - "lock.lock"
  - "msclr.lock.lock"
  - "msclr::lock::lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lock constructor"
ms.assetid: c9ad6c71-36ec-49c5-8ebd-f5c3a0cc94f0
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lock::lock
Constructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object, optionally waiting to acquire the lock forever, for a specified amount of time, or not at all.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The object to be locked.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Timeout value in milliseconds or as a \<xref:System.TimeSpan*>.  
  
## Exceptions  
 Throws \<xref:System.ApplicationException*> if lock acquisition does not occur before timeout.  
  
## Remarks  
 The first three forms of the constructor attempt to acquire a lock on <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> within the specified timeout period (or \<xref:System.Threading.Timeout.Infinite*> if none is specified).  
  
 The fourth form of the constructor does not acquire a lock on <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a member of the [lock_when Enum](../vs140/lock_when-enum.md). Use [acquire](../vs140/lock--acquire.md) or [try_acquire](../vs140/lock--try_acquire.md) to acquire the lock in this case.  
  
 The lock will automatically be released when the destructor is called.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> cannot be \<xref:System.Threading.ReaderWriterLock*>.  If it is, a compiler error will result.  
  
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
 [lock::acquire](../vs140/lock--acquire.md)   
 [lock::try_acquire](../vs140/lock--try_acquire.md)