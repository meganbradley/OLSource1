---
title: "index::index Constructor"
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
  - "amp/Concurrency::index::index"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "index, constructor"
ms.assetid: b8bb7854-eb96-4fe6-8d86-54efba3f56d5
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# index::index Constructor
Initializes a new instance of the [index](../vs140/index-class.md) class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A one-dimensional array with the rank values.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The index location in a one-dimensional index.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The length of the most significant dimension.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The length of the next-to-most-significant dimension.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The length of the least significant dimension.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object on which the new <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is based.  
  
## Overloads  
  
|Name|Definition|  
|----------|----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Initializes a new instance of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class, setting the value at each dimension to zero. For example, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> initializes the variable to the location (0,0,0).|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Initializes a new instance of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class by copying the specified <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Initializes a new instance of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class, using the specified coordinate value or values. These constructors are valid only when the rank of the index is 1, 2, or 3. Using an incompatible rank when invoking one of these constructors causes a compilation error.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Initializes a new instance of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class, using the coordinate values that are in the specified array. If the length of the array isn't equal to the rank of the index, the behavior is undefined. If the array value is NULL or is not a valid pointer, the behavior is undefined.|  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [index Structure](../vs140/index-class.md)