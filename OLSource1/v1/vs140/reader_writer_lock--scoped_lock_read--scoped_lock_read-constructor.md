---
title: "reader_writer_lock::scoped_lock_read::scoped_lock_read Constructor"
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
  - "concrt/concurrency::reader_writer_lock::scoped_lock_read::scoped_lock_read"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scoped_lock_read, constructor"
ms.assetid: b01a1548-4ecb-48e6-b80d-1befd7eff261
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reader_writer_lock::scoped_lock_read::scoped_lock_read Constructor
Constructs a `scoped_lock_read` object and acquires the `reader_writer_lock` object passed in the `_Reader_writer_lock` parameter as a reader. If the lock is held by another thread as a writer or there are pending writers, this call will block.  
  
## Syntax  
  
```  
explicit _CRTIMP scoped_lock_read(  
   reader_writer_lock& _Reader_writer_lock  
);  
```  
  
#### Parameters  
 `_Reader_writer_lock`  
 The `reader_writer_lock` object to acquire as a reader.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [reader_writer_lock::scoped_lock_read Class](../vs140/reader_writer_lock--scoped_lock_read-class.md)