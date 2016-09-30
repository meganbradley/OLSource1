---
title: "reader_writer_lock::unlock Method"
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
  - "concrt/concurrency::reader_writer_lock::unlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unlock method"
ms.assetid: 91aef6f4-4b07-492b-bba9-788e1bbfeddc
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reader_writer_lock::unlock Method
Unlocks the reader-writer lock based on who locked it, reader or writer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If there are writers waiting on the lock, the release of the lock will always go to the next writer in FIFO order. This lock is biased towards writers and can starve readers under a continuous load of writers.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [reader_writer_lock Class](../vs140/reader_writer_lock-class.md)   
 [reader_writer_lock::lock Method](../vs140/reader_writer_lock--lock-method.md)   
 [reader_writer_lock::lock_read Method](../vs140/reader_writer_lock--lock_read-method.md)   
 [reader_writer_lock::try_lock Method](../vs140/reader_writer_lock--try_lock-method.md)   
 [reader_writer_lock::try_lock_read Method](../vs140/reader_writer_lock--try_lock_read-method.md)