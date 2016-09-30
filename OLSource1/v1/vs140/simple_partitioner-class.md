---
title: "simple_partitioner Class"
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
  - "ppl/concurrency::simple_partitioner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "simple_partitioner class"
ms.assetid: d7e997af-54d1-43f5-abe0-def72df6edb3
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# simple_partitioner Class
The             `simple_partitioner` class represents a static partitioning of the range iterated over by             `parallel_for`. The partitioner divides the range into chunks such that each chunk has at least the number of iterations specified by the chunk size.  
  
## Syntax  
  
```  
class simple_partitioner;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[simple_partitioner::simple_partitioner Constructor](#simple_partitioner__simple_partitioner_constructor)|Constructs a                                         `simple_partitioner` object.|  
|[simple_partitioner::~simple_partitioner Destructor](#simple_partitioner___dtorsimple_partitioner_destructor)|Destroys a                                         `simple_partitioner` object.|  
  
## Inheritance Hierarchy  
 `simple_partitioner`  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
##  <a name="simple_partitioner___dtorsimple_partitioner_destructor"></a>  simple_partitioner::~simple_partitioner Destructor  
 Destroys a                 `simple_partitioner` object.  
  
```  
~simple_partitioner();  
```  
  
##  <a name="simple_partitioner__simple_partitioner_constructor"></a>  simple_partitioner::simple_partitioner Constructor  
 Constructs a                 `simple_partitioner` object.  
  
```  
explicit simple_partitioner(  
   _Size_type                 _Chunk_size  
);  
```  
  
### Parameters  
 `_Chunk_size`  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)