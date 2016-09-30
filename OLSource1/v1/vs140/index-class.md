---
title: "index Class"
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
  - "amp/Concurrency::index"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "index structure"
ms.assetid: cbe79b08-0ba7-474c-9828-f1a71da39eb3
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# index Class
Defines an *N*-dimensional index point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The rank, or number of dimensions.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[index::index Constructor](../vs140/index--index-constructor.md)|Initializes a new instance of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[index::operator-- Operator](../vs140/index--operator---operator.md)|Decrements each element of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
|[index::operator%= Operator](../vs140/index--operator-mod-=-operator.md)|Calculates the modulus (remainder) of each element in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object when that element is divided by a number.|  
|[index::operator*= Operator](../vs140/index--operator-=-operator.md)|Multiplies each element of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object by a number.|  
|[index::operator/= Operator](../vs140/index--operator-=-operator2.md)|Divides each element of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object by a number.|  
|[index::operator&#91;&#93; Operator](../vs140/index--operatoroperator.md)|Returns the element that's at the specified index.|  
|[index::operator++ Operator](../vs140/index--operator---operator.md)|Increments each element of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
|[index::operator+= Operator](../vs140/index--operator-=-operator.md)|Adds the specified number to each element of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
|[index::operator= Operator](../vs140/index--operator=-operator.md)|Copies the contents of the specified <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object into this one.|  
|[index::operator-= Operator](../vs140/index--operator-=-operator1.md)|Subtracts the specified number from each element of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[index::rank Constant](../vs140/index--rank-constant.md)|Stores the rank of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> structure represents a coordinate vector of *N* integers that specifies a unique position in an *N*-dimensional space. The values in the vector are ordered from most significant to least significant. You can retrieve the values of the components using [index::operator= Operator](../vs140/index--operator=-operator.md).  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)