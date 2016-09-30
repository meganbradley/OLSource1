---
title: "map::insert"
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
  - "map/std::map::insert"
  - "insert"
  - "map::insert"
  - "map.insert"
  - "std::map::insert"
  - "std.map.insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: 44e98187-779a-49e6-9d27-654754f2f1b4
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::insert
Inserts an element or a range of elements into a map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The value of an element to be inserted into the map unless it already contains an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (If that point immediately precedes <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, insertion can occur in amortized constant time instead of logarithmic time.)|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Template parameter that specifies the argument type that the map can use to construct an element of [value_type](../vs140/map--value_type.md), and perfect-forwards <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> as an argument.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The position of the first element to be copied.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The position just beyond the last element to be copied.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map--value_type.md) objects.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
## Return Value  
 The single-element member functions, (1) and (2), return a [pair](../vs140/pair-structure.md) whose <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> component is true if an insertion was made, and false if the map already contained an element whose key had an equivalent value in the ordering. The iterator component of the return-value pair points to the newly inserted element if the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> component is true, or to the existing element if the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> component is false.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the map or, if an element with an equivalent key already exists, to the existing element.  
  
## Remarks  
 No iterators, pointers, or references are invalidated by this function.  
  
 During the insertion of just one element, if an exception is thrown, the container's state is not modified. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 To access the iterator component of a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that's returned by the single-element member functions, use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>; to dereference the iterator within the returned pair, use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, giving you an element. To access the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> component, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. For an example, see the sample code later in this article.  
  
 The [value_type](../vs140/map--value_type.md) of a container is a typedef that belongs to the container, and for map, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The value of an element is an ordered pair in which the first component is equal to the key value and the second component is equal to the data value of the element.  
  
 The range member function (5) inserts the sequence of element values into a map that corresponds to each element addressed by an iterator in the range <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>; therefore, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> does not get inserted. The container member function <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> refers to the position just after the last element in the container—for example, the statement <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> attempts to insert all elements of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. Only elements that have unique values in the range are inserted; duplicates are ignored. To observe which elements are rejected, use the single-element versions of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the map.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [map::emplace](../vs140/map--emplace.md) and [map::emplace_hint](../vs140/map--emplace_hint.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [map::insert, map::find, and map::end](../vs140/map--insert--map--find--and-map--end.md)   
 [multimap::insert](../vs140/multimap--insert.md)   
 [Standard Template Library](../vs140/standard-template-library.md)