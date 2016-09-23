---
title: "reader_writer_lock::scoped_lock Class"
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
  - concrt/concurrency::reader_writer_lock::scoped_lock
dev_langs: 
  - C++
helpviewer_keywords: 
  - scoped_lock class
ms.assetid: 35a8af75-1c30-4ce5-890d-ad0385f7a004
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# reader_writer_lock::scoped_lock Class
An exception safe RAII wrapper that can be used to acquire `reader_writer_lock` lock objects as a writer.  
  
## Syntax  
  
```  
class scoped_lock;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[reader_writer_lock::scoped_lock::scoped_lock Constructor](../vs140/reader_writer_lock--scoped_lock--scoped_lock-constructor.md)|Constructs a `scoped_lock` object and acquires the `reader_writer_lock` object passed in the `_Reader_writer_lock` parameter as a writer. If the lock is held by another thread, this call will block.|  
|[reader_writer_lock::scoped_lock::~scoped_lock Destructor](../vs140/reader_writer_lock--scoped_lock--~scoped_lock-destructor.md)|Destroys a `reader_writer_lock` object and releases the lock supplied in its constructor.|  
  
## Inheritance Hierarchy  
 `scoped_lock`  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [reader_writer_lock Class](../vs140/reader_writer_lock-class.md)