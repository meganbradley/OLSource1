---
title: "unordered_multiset::insert"
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
  - "unordered_multiset::insert"
  - "insert"
  - "tr1::unordered_multiset::insert"
  - "std::tr1::unordered_multiset::insert"
  - "std.tr1.unordered_multiset.insert"
  - "tr1.unordered_multiset.insert"
  - "unordered_multiset.insert"
  - "unordered_set/std::tr1::unordered_multiset::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
  - "insert method [TR1]"
ms.assetid: f4ef1e76-f230-4e23-85af-12341f75de8e
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::insert
Inserts an element or a range of elements into an unordered_multiset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The value of an element to be inserted into the unordered_multiset.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Template parameter that specifies the argument type that the unordered_multiset can use to construct an element of [value_type](../vs140/map--value_type.md), and perfect-forwards <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> as an argument.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The position of the first element to be copied.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The position just beyond the last element to be copied.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map--value_type.md) objects.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
## Return Value  
 The single-element-insert member functions, (1) and (2), return an iterator to the position where the new element was inserted into the unordered_multiset.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the unordered_multiset.  
  
## Remarks  
 No pointers or references are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During the insertion of just one element, if an exception is thrown but does not occur in the container's hash function, the container's state is not modified. If the exception is thrown in the hash function, the result is undefined. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 The [value_type](../vs140/map--value_type.md) of a container is a typedef that belongs to the container, and, for set, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The range member function (5) inserts the sequence of element values into an unordered_multiset that corresponds to each element addressed by an iterator in the range <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; therefore, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> does not get inserted. The container member function <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> refers to the position just after the last element in the container—for example, the statement <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> inserts all elements of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the unordered_multiset.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [unordered_multiset::emplace](../vs140/unordered_multiset--emplace.md) and [unordered_multiset::emplace_hint](../vs140/unordered_multiset--emplace_hint.md).  
  
 For a code example, see [multiset::insert](../vs140/multiset--insert.md).  
  
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset Class](../vs140/unordered_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)