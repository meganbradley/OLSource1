---
title: "affinity_partitioner Class"
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
  - "ppl/concurrency::affinity_partitioner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "affinity_partitioner class"
ms.assetid: 31bf7bb1-bd01-491c-9760-d9d60edfccad
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# affinity_partitioner Class
The             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class is similar to the             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class, but it improves cache affinity by its choice of mapping subranges to worker threads. It can improve performance significantly when a loop is re-executed over the same data set, and the data fits in cache. Note that the same             <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object must be used with subsequent iterations of a parallel loop that is executed over a particular data set, to benefit from data locality.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[affinity_partitioner::affinity_partitioner Constructor](#affinity_partitioner__affinity_partitioner_constructor)|Constructs an                                         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
|[affinity_partitioner::~affinity_partitioner Destructor](#affinity_partitioner___dtoraffinity_partitioner_destructor)|Destroys an                                         <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
##  \<a name="affinity_partitioner___dtoraffinity_partitioner_destructor">\</a>  affinity_partitioner::~affinity_partitioner Destructor  
 Destroys an                 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="affinity_partitioner__affinity_partitioner_constructor">\</a>  affinity_partitioner::affinity_partitioner Constructor  
 Constructs an                 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)