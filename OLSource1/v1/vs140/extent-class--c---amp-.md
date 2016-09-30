---
title: "extent Class (C++ AMP)"
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
  - "amp/Concurrency::extent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "extent structure"
ms.assetid: edb5de3d-3935-4dbb-8365-4cc6c4fb0269
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# extent Class (C++ AMP)
Represents a vector of *N* integer values that specify the bounds of an *N*-dimensional space that has an origin of 0. The values in the vector are ordered from most significant to least significant.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The rank of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[extent::extent Constructor](../vs140/extent--extent-constructor.md)|Initializes a new instance of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[extent::contains Method](../vs140/extent--contains-method.md)|Verifies that the specified <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object has the specified rank.|  
|[extent::size Method](../vs140/extent--size-method.md)|Returns the total linear size of the extent (in units of elements).|  
|[extent::tile method](../vs140/extent--tile-method.md)|Produces a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object with the tile extents given by specified dimensions.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[extent::operator- Operator](../vs140/extent--operator--operator.md)|Returns a new <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that's created by subtracting the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> elements from the corresponding <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements.|  
|[extent::operator-- Operator](../vs140/extent--operator---operator.md)|Decrements each element of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
|[extent::operator%= Operator](../vs140/extent--operator-mod-=-operator.md)|Calculates the modulus (remainder) of each element in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object when that element is divided by a number.|  
|[extent::operator*= Operator](../vs140/extent--operator-=-operator.md)|Multiplies each element of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object by a number.|  
|[extent::operator/= Operator](../vs140/extent--operator-=-operator1.md)|Divides each element of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object by a number.|  
|[extent::operator&#91;&#93; Operator](../vs140/extent--operatoroperator.md)|Returns the element that's at the specified index.|  
|[extent::operator+ Operator](../vs140/extent--operator--operator.md)|Returns a new <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object that's created by adding the corresponding <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> elements.|  
|[extent::operator++ Operator](../vs140/extent--operator---operator.md)|Increments each element of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
|[extent::operator+= Operator](../vs140/extent--operator-=-operator.md)|Adds the specified number to each element of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
|[extent::operator= Operator](../vs140/extent--operator=-operator.md)|Copies the contents of another <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object into this one.|  
|[extent::operator-= Operator](../vs140/extent--operator-=-operator2.md)|Subtracts the specified number from each element of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[extent::rank Constant](../vs140/extent--rank-constant.md)|Gets the rank of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)