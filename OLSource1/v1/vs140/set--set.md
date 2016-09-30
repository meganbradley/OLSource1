---
title: "set::set"
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
  - "set::set"
  - "std::set::set"
  - "std.set.set"
  - "set"
  - "set/std::set::set"
  - "set.set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set class, using custom comparators"
  - "set method"
  - "set class, constructor"
ms.assetid: 592c1d24-12a7-436b-9bca-d6c90de86f4e
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::set
Constructs a set that is empty or that is a copy of all or part of some other set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The storage allocator class to be used for this set object, which defaults to **Allocator**.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The comparison function of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> used to order the elements in the set, which defaults to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The set of which the constructed set is to be a copy.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The initializer_list from which to copy the elements.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the set and that can later be returned by calling [get_allocator](../vs140/set--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their sets.  
  
 All constructors store a function object of type **Traits** that is used to establish an order among the keys of the set and that can later be returned by calling [key_comp](../vs140/set--key_comp.md).  
  
 The first three constructors specify an empty initial set, the second specifying the type of comparison function (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifying the allocator type (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) to be used. The keyword **explicit** suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The next three constructors use an initializer_list to specify the elements.  
  
 The next three constructors copy the range [<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) of a set with increasing explicitness in specifying the type of comparison function of class **Traits** and **Allocator**.  
  
 The eighth constructor specifies a copy of the set by moving <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **s1 = 10 20 30 40s2 = 10 20s3 = 30s4 = 10 20 30 40s5 = 10 20s6 = 10s7 = 10 20s8 = 1 2 3 4s9 = 5 6 7 8s10 = 10 20 30 40**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)