---
title: "reader_writer_lock::try_lock_read Method"
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
  - "concrt/concurrency::reader_writer_lock::try_lock_read"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "try_lock_read method"
ms.assetid: 558021f3-d86b-4cd7-91be-e3fed8a69ef9
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reader_writer_lock::try_lock_read Method
Attempts to acquire the reader-writer lock as a reader without blocking.  
  
## Syntax  
  
```  
bool try_lock_read();  
```  
  
## Return Value  
 If the lock was acquired, the value `true`; otherwise, the value `false`.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [reader_writer_lock Class](../VS_csharp/reader_writer_lock-class.md)   
 [reader_writer_lock::unlock Method](../VS_csharp/reader_writer_lock--unlock-method.md)