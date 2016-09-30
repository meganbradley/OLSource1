---
title: "hash_multiset::hash_multiset"
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
  - "hash_set/stdext::hash_multiset::hash_multiset"
  - "std.hash_multiset.hash_multiset"
  - "hash_multiset.hash_multiset"
  - "hash_multiset::hash_multiset"
  - "hash_multiset"
  - "stdext::hash_multiset::hash_multiset"
  - "stdext.hash_multiset.hash_multiset"
  - "std::hash_multiset::hash_multiset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash_multiset class, constructor"
  - "hash_multiset method"
ms.assetid: 24af1025-04a5-4e44-a384-67c23114022c
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::hash_multiset
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
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
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The initializer_list that contains the elements to be copied.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and that can later be returned by calling [hash_multiset::get_allocator](../vs140/hash_multiset--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their hash_multisets.  
  
 All constructors store a function object of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> that is used to establish an order among the keys of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and that can later be returned by calling [hash_multiset::key_comp](../vs140/hash_multiset--key_comp.md). For more information on <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> see the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
 The first three constructors specify an empty initial <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the second specifying the type of comparison function (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifying the allocator type (<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>) to be used. The keyword <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor moves the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 The fifth, sixth, and seventh constructors use an initializer_list.  
  
 The last three constructors copy the range [<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>) of a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> with increasing explicitness in specifying the type of comparison function of class Compare and allocator.  
  
 The actual order of elements in a hashed set container depends on the hash function, the ordering function and the current size of the hash table and cannot, in general, be predicted as it could with the set container, where it was determined by the ordering function alone.  
  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)