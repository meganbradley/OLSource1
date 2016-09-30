---
title: "concurrent_vector::concurrent_vector Constructor"
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
  - "concurrent_vector/concurrency::concurrent_vector::concurrent_vector"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_vector, constructor"
ms.assetid: 1a3a39af-7ea4-479f-8107-ed0a9be91d0e
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::concurrent_vector Constructor
Constructs a concurrent vector.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The allocator type of the source vector.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of the input iterator.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The allocator class to use with this object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The source <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object to copy or move elements from.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The initial capacity of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The value of elements in the constructed object.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Position of the first element beyond the range of elements to be copied.  
  
## Remarks  
 All constructors store an allocator object <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and initialize the vector.  
  
 The first constructor specify an empty initial vector and explicitly specifies the allocator type. to be used.  
  
 The second and third constructors specify a copy of the concurrent vector <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The fourth constructor specifies a move of the concurrent vector <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The fifth constructor specifies a repetition of a specified number (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) of elements of the default value for class <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 The sixth constructor specifies a repetition of (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) elements of value <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 The last constructor specifies values supplied by the iterator range [<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)