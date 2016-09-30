---
title: "multiset::insert"
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
  - "std.multiset.insert"
  - "Insert"
  - "insert"
  - "std::multiset::insert"
  - "multiset.insert"
  - "multiset::insert"
  - "set/std::multiset::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: 91df7f6a-6316-4709-882a-48dc99a2fd8e
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::insert
Inserts an element or a range of elements into a multiset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The value of an element to be inserted into the multiset.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (If that point immediately precedes <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, insertion can occur in amortized constant time instead of logarithmic time.)|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Template parameter that specifies the argument type that the multiset can use to construct an element of [value_type](../vs140/map--value_type.md), and perfect-forwards <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> as an argument.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The position of the first element to be copied.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The position just beyond the last element to be copied.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map--value_type.md) objects.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
## Return Value  
 The single-element-insert member functions, (1) and (2), return an iterator to the position where the new element was inserted into the multiset.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the multiset.  
  
## Remarks  
 No pointers or references are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During the insertion of just one element, if an exception is thrown, the container's state is not modified. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 The [value_type](../vs140/map--value_type.md) of a container is a typedef that belongs to the container, and, for set, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The range member function (5) inserts the sequence of element values into a multiset that corresponds to each element addressed by an iterator in the range <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; therefore, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> does not get inserted. The container member function <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> refers to the position just after the last element in the container—for example, the statement <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> inserts all elements of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the multiset.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [multiset::emplace](../vs140/multiset--emplace.md) and [multiset::emplace_hint](../vs140/multiset--emplace_hint.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [\<set>](../vs140/-set-.md)   
 [multiset Class](../vs140/multiset-class.md)   
 [set::insert](../vs140/set--insert.md)   
 [Standard Template Library](../vs140/standard-template-library.md)