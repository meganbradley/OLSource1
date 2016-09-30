---
title: "vector::vector"
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
  - "std::vector::vector"
  - "std.vector.vector"
  - "vector::vector"
  - "vector.vector"
  - "vector"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "vector method"
  - "vector class, constructor"
ms.assetid: 24b14024-3af3-4f4b-89a5-0291744a9f83
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::vector
Constructs a vector of a specific size or with elements of a specific value or with a specific allocator or as a copy of all or part of some other vector.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The allocator class to use with this object. [get_allocator](../vs140/vector--get_allocator.md) returns the allocator class for the object.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The number of elements in the constructed vector.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The value of the elements in the constructed vector.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The vector of which the constructed vector is to be a copy.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The initializer_list containing the elmeents to copy.|  
  
## Remarks  
 All constructors store an allocator object (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) and initialize the vector.  
  
 The first two constructors specify an empty initial vector. The second explicitly specifies the allocator type (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) to be used.  
  
 The third constructor specifies a repetition of a specified number (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) of elements of the default value for class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The fourth and fifth constructors specify a repetition of (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) elements of value <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 The sixth constructor specifies a copy of the vector <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 The seventh constructor moves the vector <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 The eighth constructor uses an initializer_list to specify the elements.  
  
 The ninth and tenth constructors copy the range [<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>) of a vector.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **v1 = 0 0 0v2 = 2 2 2 2 2v3 = 1 1 1v4 = 2 2 2 2 2v5 = 0 1 2 3 4v6 = 1 2v7 = 2 2 2 2 21 2 3 4**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)