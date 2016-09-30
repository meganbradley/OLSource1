---
title: "hash_set::hash_set"
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
  - "stdext::hash_set::hash_set"
  - "std.hash_set.hash_set"
  - "hash_set/stdext::hash_set::hash_set"
  - "stdext.hash_set.hash_set"
  - "hash_set"
  - "hash_set.hash_set"
  - "hash_set::hash_set"
  - "std::hash_set::hash_set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash_set class, constructor"
  - "hash_set method"
ms.assetid: 806b4861-f8ff-4a2b-ac69-4d2bc8466c1d
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::hash_set
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that is empty or that is a copy of all or part of some other <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The storage allocator class to be used for this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object, which defaults to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The comparison function of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> used to order the elements in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which defaults to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> of which the constructed <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is to be a copy.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and that can later be returned by calling [hash_set::get_allocator](../vs140/hash_set--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their hash_sets.  
  
 All constructors store a function object of type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> that is used to establish an order among the keys of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and that can later be returned by calling [hash_set::key_comp](../vs140/hash_set--key_comp.md). For more information on <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> see the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
 The first constructor creates an empty initial <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> The second specifies the type of comparison function (<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) to be used in establishing the order of the elements, and the third explicitly specifies the allocator type (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) to be used. The key word <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth and fifth constructors specify a copy of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 The last sixth, seventh, and eighth constructors use an initializer_list for the elements.  
  
 The last constructors copy the range [<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>) of a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> with increasing explicitness in specifying the type of comparison function of class Traits and allocator.  
  
 The eighth constructor moves the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 The actual order of elements in a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> container depends on the hash function, the ordering function and the current size of the hash table and cannot, in general, be predicted as it could with the set container, where it was determined by the ordering function alone.  
  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)