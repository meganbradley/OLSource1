---
title: "reader_writer_lock::scoped_lock_read Class"
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
  - "concrt/concurrency::reader_writer_lock::scoped_lock_read"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scoped_lock_read class"
ms.assetid: 808cf852-b770-448c-80d2-e15ee4c0d208
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reader_writer_lock::scoped_lock_read Class
An exception safe RAII wrapper that can be used to acquire `reader_writer_lock` lock objects as a reader.  
  
## Syntax  
  
```  
class scoped_lock_read;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[reader_writer_lock::scoped_lock_read::scoped_lock_read Constructor](../vs140/reader_writer_lock--scoped_lock_read--scoped_lock_read-constructor.md)|Constructs a `scoped_lock_read` object and acquires the `reader_writer_lock` object passed in the `_Reader_writer_lock` parameter as a reader. If the lock is held by another thread as a writer or there are pending writers, this call will block.|  
|[reader_writer_lock::scoped_lock_read::~scoped_lock_read Destructor](../vs140/reader_writer_lock--scoped_lock_read--~scoped_lock_read-destructor.md)|Destroys a `scoped_lock_read` object and releases the lock supplied in its constructor.|  
  
## Inheritance Hierarchy  
 `scoped_lock_read`  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [reader_writer_lock Class](../vs140/reader_writer_lock-class.md)