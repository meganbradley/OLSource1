---
title: "auto_partitioner Class"
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
  - "ppl/concurrency::auto_partitioner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_partitioner class"
ms.assetid: 7cc08e5d-20b4-47a4-b4b5-c214a78f5a9e
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_partitioner Class
The             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class represents the default method             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>,             <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and             <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> use to partition the range they iterates over. This method of partitioning employes range stealing for load balancing as well as per-iterate cancellation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[auto_partitioner::auto_partitioner Constructor](#auto_partitioner__auto_partitioner_constructor)|Constructs a                                         <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
|[auto_partitioner::~auto_partitioner Destructor](#auto_partitioner___dtorauto_partitioner_destructor)|Destroys a                                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
##  \<a name="auto_partitioner___dtorauto_partitioner_destructor">\</a>  auto_partitioner::~auto_partitioner Destructor  
 Destroys a                 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="auto_partitioner__auto_partitioner_constructor">\</a>  auto_partitioner::auto_partitioner Constructor  
 Constructs a                 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)