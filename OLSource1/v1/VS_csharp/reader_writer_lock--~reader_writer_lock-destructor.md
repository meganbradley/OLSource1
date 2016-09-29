---
title: "reader_writer_lock::~reader_writer_lock Destructor"
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
  - "concrt/concurrency::reader_writer_lock::~reader_writer_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~reader_writer_lock, destructor"
ms.assetid: 2470306d-679d-4ba1-adcd-568745caa36a
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reader_writer_lock::~reader_writer_lock Destructor
Destroys the `reader_writer_lock` object.  
  
## Syntax  
  
```  
~reader_writer_lock();  
```  
  
## Remarks  
 It is expected that the lock is no longer held when the destructor runs. Allowing the reader writer lock to destruct with the lock still held results in undefined behavior.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [reader_writer_lock Class](../VS_csharp/reader_writer_lock-class.md)