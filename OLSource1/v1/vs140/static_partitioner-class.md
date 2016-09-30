---
title: "static_partitioner Class"
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
  - "ppl/concurrency::static_partitioner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "static_partitioner class"
ms.assetid: 2b3dbdf0-6eb9-49f6-8639-03df1d974143
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# static_partitioner Class
The             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class represents a static partitioning of the range iterated over by             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The partitioner divides the range into as many chunks as there are workers available to the underyling scheduler.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[static_partitioner::static_partitioner Constructor](#static_partitioner__static_partitioner_constructor)|Constructs a                                         <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
|[static_partitioner::~static_partitioner Destructor](#static_partitioner___dtorstatic_partitioner_destructor)|Destroys a                                         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
##  \<a name="static_partitioner___dtorstatic_partitioner_destructor">\</a>  static_partitioner::~static_partitioner Destructor  
 Destroys a                 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="static_partitioner__static_partitioner_constructor">\</a>  static_partitioner::static_partitioner Constructor  
 Constructs a                 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)