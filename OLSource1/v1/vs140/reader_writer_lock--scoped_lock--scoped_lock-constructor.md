---
title: "reader_writer_lock::scoped_lock::scoped_lock Constructor"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - concrt/concurrency::reader_writer_lock::scoped_lock::scoped_lock
dev_langs: 
  - C++
helpviewer_keywords: 
  - scoped_lock, constructor
ms.assetid: aba6705e-f6ff-4809-8494-bfe22ee89e78
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# reader_writer_lock::scoped_lock::scoped_lock Constructor
Constructs a `scoped_lock` object and acquires the `reader_writer_lock` object passed in the `_Reader_writer_lock` parameter as a writer. If the lock is held by another thread, this call will block.  
  
## Syntax  
  
```  
explicit _CRTIMP scoped_lock(  
   reader_writer_lock& _Reader_writer_lock  
);  
```  
  
#### Parameters  
 `_Reader_writer_lock`  
 The `reader_writer_lock` object to acquire as a writer.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [reader_writer_lock::scoped_lock Class](../vs140/reader_writer_lock--scoped_lock-class.md)