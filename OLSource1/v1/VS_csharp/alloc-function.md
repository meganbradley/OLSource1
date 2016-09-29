---
title: "Alloc Function"
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
  - "concrt/concurrency::Alloc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Alloc function"
ms.assetid: 41246453-c699-4a73-9234-f952efbd9106
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Alloc Function
Allocates a block of memory of the size specified from the Concurrency Runtime Caching Suballocator.  
  
## Syntax  
  
```  
void * __cdecl Alloc(  
   size_t _NumBytes  
);  
```  
  
#### Parameters  
 `_NumBytes`  
 The number of bytes of memory to allocate.  
  
## Return Value  
 A pointer to newly allocated memory.  
  
## Remarks  
 For more information about which scenarios in your application could benefit from using the Caching Suballocator, see [Task Scheduler (Concurrency Runtime)](../VS_csharp/task-scheduler--concurrency-runtime-.md).  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../VS_csharp/concurrency-namespace.md)   
 [Concurrency::Free Function](../VS_csharp/free-function.md)