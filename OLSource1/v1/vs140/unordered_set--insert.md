---
title: "unordered_set::insert"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "std.tr1.unordered_set.insert"
  - "std::tr1::unordered_set::insert"
  - "unordered_set.insert"
  - "unordered_set::insert"
  - "unordered_set/std::tr1::unordered_set::insert"
  - "std.unordered_set.insert"
  - "std::unordered_set::insert"
  - "unordered_set/std::unordered_set::insert"
  - "insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method [TR1]"
  - "insert method"
ms.assetid: 38bf7b31-850f-4380-a730-1c75045785e5
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::insert
Inserts an element or a range of elements into an unordered_set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The value of an element to be inserted into the unordered_set unless it already contains an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Template parameter that specifies the argument type that the unordered_set can use to construct an element of [value_type](../vs140/map--value_type.md), and perfect-forwards <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> as an argument.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The position of the first element to be copied.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The position just beyond the last element to be copied.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map--value_type.md) objects.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
## Return Value  
 The single-element member functions, (1) and (2), return a [pair](../vs140/pair-structure.md) whose <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> component is true if an insertion was made, and false if the unordered_set already contained an element whose key had an equivalent value in the ordering. The iterator component of the return-value pair points to the newly inserted element if the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> component is true, or to the existing element if the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> component is false.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the unordered_set or, if an element with an equivalent key already exists, to the existing element.  
  
## Remarks  
 No iterators, pointers, or references are invalidated by this function.  
  
 During the insertion of just one element, if an exception is thrown but does not occur in the container's hash function, the container's state is not modified. If the exception is thrown in the hash function, the result is undefined. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 To access the iterator component of a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> that's returned by the single-element member functions, use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>; to dereference the iterator within the returned pair, use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, giving you an element. To access the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> component, use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. For an example, see the sample code later in this article.  
  
 The [value_type](../vs140/map--value_type.md) of a container is a typedef that belongs to the container, and, for set, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The range member function (5) inserts the sequence of element values into an unordered_set that corresponds to each element addressed by an iterator in the range <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>; therefore, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> does not get inserted. The container member function <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> refers to the position just after the last element in the container—for example, the statement <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attempts to insert all elements of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. Only elements that have unique values in the range are inserted; duplicates are ignored. To observe which elements are rejected, use the single-element versions of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the unordered_set.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [unordered_set::emplace](../vs140/set--emplace.md) and [unordered_set::emplace_hint](../vs140/set--emplace_hint.md).  
  
 For a code example, see [set::insert](../vs140/set--insert.md).  
  
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set Class](../vs140/unordered_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)