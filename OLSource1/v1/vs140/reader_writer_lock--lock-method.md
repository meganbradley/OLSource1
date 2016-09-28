---
title: "reader_writer_lock::lock Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "concrt/concurrency::reader_writer_lock::lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lock method"
ms.assetid: 2785cfe2-772f-434e-b553-ece90c880536
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reader_writer_lock::lock Method
Acquires the reader-writer lock as a writer.  
  
## Syntax  
  
```  
void lock();  
```  
  
## Remarks  
 It is often safer to utilize the [scoped_lock](../vs140/reader_writer_lock--scoped_lock-class.md) construct to acquire and release a `reader_writer_lock` object as a writer in an exception safe way.  
  
 After a writer attempts to acquire the lock, any future readers will block until the writers have successfully acquired and released the lock. This lock is biased towards writers and can starve readers under a continuous load of writers.  
  
 Writers are chained so that a writer exiting the lock releases the next writer in line.  
  
 If the lock is already held by the calling context, an [improper_lock](../vs140/improper_lock-class.md) exception will be thrown.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [reader_writer_lock Class](../vs140/reader_writer_lock-class.md)   
 [reader_writer_lock::unlock Method](../vs140/reader_writer_lock--unlock-method.md)