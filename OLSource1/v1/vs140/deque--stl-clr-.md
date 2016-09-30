---
title: "deque (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "deque (STL/CLR)"
f1_keywords: 
  - "cliext::deque"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deque class [STL/CLR]"
  - "<deque> header [STL/CLR]"
  - "<cliext/deque> header [STL/CLR]"
ms.assetid: dd669da3-3c0e-45e9-8596-f6b483720941
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque (STL-CLR)
The template class describes an object that controls a varying-length sequence of elements that has random access. You use the container <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to manage a sequence of elements that looks like a contiguous block of storage, but which can grow or shrink at either end without the need to copy any remaining elements. Thus it can implement efficiently a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. (Hence the name.)  
  
 In the description below, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the same as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> unless the latter is a ref type, in which case it is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 GValue  
 The generic type of an element in the controlled sequence.  
  
 Value  
 The type of an element in the controlled sequence.  
  
## Members  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|[const_iterator](../vs140/deque--const_iterator--stl-clr-.md)|The type of a constant iterator for the controlled sequence.|  
|[const_reference](../vs140/deque--const_reference--stl-clr-.md)|The type of a constant reference to an element.|  
|[const_reverse_iterator](../vs140/deque--const_reverse_iterator--stl-clr-.md)|The type of a constant reverse iterator for the controlled sequence.|  
|[difference_type](../vs140/deque--difference_type--stl-clr-.md)|The type of a signed distance between two elements.|  
|[generic_container](../vs140/deque--generic_container--stl-clr-.md)|The type of the generic interface for the container.|  
|[generic_iterator](../vs140/deque--generic_iterator--stl-clr-.md)|The type of an iterator for the generic interface for the container.|  
|[generic_reverse_iterator](../vs140/deque--generic_reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the generic interface for the container.|  
|[generic_value](../vs140/deque--generic_value--stl-clr-.md)|The type of an element for the generic interface for the container.|  
|[iterator](../vs140/deque--iterator--stl-clr-.md)|The type of an iterator for the controlled sequence.|  
|[reference](../vs140/deque--reference--stl-clr-.md)|The type of a reference to an element.|  
|[reverse_iterator](../vs140/deque--reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the controlled sequence.|  
|[size_type](../vs140/deque--size_type--stl-clr-.md)|The type of a signed distance between two elements.|  
|[value_type](../vs140/deque--value_type--stl-clr-.md)|The type of an element.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[assign](../vs140/deque--assign--stl-clr-.md)|Replaces all elements.|  
|[at](../vs140/deque--at--stl-clr-.md)|Accesses an element at a specified position.|  
|[back](../vs140/deque--back--stl-clr-.md)|Accesses the last element.|  
|[begin](../vs140/deque--begin--stl-clr-.md)|Designates the beginning of the controlled sequence.|  
|[clear](../vs140/deque--clear--stl-clr-.md)|Removes all elements.|  
|[deque](../vs140/deque--deque--stl-clr-.md)|Constructs a container object.|  
|[empty](../vs140/deque--empty--stl-clr-.md)|Tests whether no elements are present.|  
|[end](../vs140/deque--end--stl-clr-.md)|Designates the end of the controlled sequence.|  
|[erase](../vs140/deque--erase--stl-clr-.md)|Removes elements at specified positions.|  
|[front](../vs140/deque--front--stl-clr-.md)|Accesses the first element.|  
|[insert](../vs140/deque--insert--stl-clr-.md)|Adds elements at a specified position.|  
|[pop_back](../vs140/deque--pop_back--stl-clr-.md)|Removes the last element.|  
|[pop_front](../vs140/deque--pop_front--stl-clr-.md)|Removes the first element.|  
|[push_back](../vs140/deque--push_back--stl-clr-.md)|Adds a new last element.|  
|[push_front](../vs140/deque--push_front--stl-clr-.md)|Adds a new first element.|  
|[rbegin](../vs140/deque--rbegin--stl-clr-.md)|Designates the beginning of the reversed controlled sequence.|  
|[rend](../vs140/deque--rend--stl-clr-.md)|Designates the end of the reversed controlled sequence.|  
|[resize](../vs140/deque--resize--stl-clr-.md)|Changes the number of elements.|  
|[size](../vs140/deque--size--stl-clr-.md)|Counts the number of elements.|  
|[swap](../vs140/deque--swap--stl-clr-.md)|Swaps the contents of two containers.|  
|[to_array](../vs140/deque--to_array--stl-clr-.md)|Copies the controlled sequence to a new array.|  
  
|Property|Description|  
|--------------|-----------------|  
|[back_item](../vs140/deque--back_item--stl-clr-.md)|Accesses the last element.|  
|[front_item](../vs140/deque--front_item--stl-clr-.md)|Accesses the first element.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[deque::operator!= (STL/CLR)](../vs140/deque--operator!=--stl-clr-.md)|Determines if two <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> objects are not equal.|  
|[operator&#91;&#93;](../vs140/deque--operator-stl-clr-.md)|Accesses an element at a specified position.|  
|[deque::operator< (STL/CLR)](../vs140/operator---deque---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is less than another <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
|[deque::operator<= (STL/CLR)](../vs140/operator-=--deque---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object is less than or equal to another <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
|[operator=](../vs140/operator=--deque---stl-clr-.md)|Replaces the controlled sequence.|  
|[deque::operator== (STL/CLR)](../vs140/operator==--deque---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object is equal to another <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
|[deque::operator> (STL/CLR)](../vs140/operator---deque---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object is greater than another <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
|[deque::operator>= (STL/CLR)](../vs140/operator-=--deque---stl-clr-.md)|Determines if a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object is greater than or equal to another <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|\<xref:System.ICloneable*>|Duplicate an object.|  
|\<xref:System.Collections.IEnumerable*>|Sequence through elements.|  
|\<xref:System.Collections.ICollection*>|Maintain group of elements.|  
|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>1*>|Maintain group of typed elements.|  
|<xref:System.Collections.Generic.IList<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>Value<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>deque<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>() - 1<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>not<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>not<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>can<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>end()<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>not` destroy its elements.  
  
## Requirements  
 **Header:** \<cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [priority_queue](../vs140/priority_queue--stl-clr-.md)   
 [queue](../vs140/queue--stl-clr-.md)   
 [stack](../vs140/stack--stl-clr-.md)   
 [vector](../vs140/vector--stl-clr-.md)   
 [STL/CLR Library](../vs140/stl-clr-library-reference.md)