---
title: "reader_writer_lock::try_lock Method"
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
  - "concrt/concurrency::reader_writer_lock::try_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "try_lock method"
ms.assetid: 3dc29ace-f1da-4827-803a-f3f243e6951e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reader_writer_lock::try_lock Method
Attempts to acquire the reader-writer lock as a writer without blocking.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If the lock was acquired, the value <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>; otherwise, the value <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [reader_writer_lock Class](../vs140/reader_writer_lock-class.md)   
 [reader_writer_lock::unlock Method](../vs140/reader_writer_lock--unlock-method.md)