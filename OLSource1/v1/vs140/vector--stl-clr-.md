---
title: "vector (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector (STL/CLR)"
f1_keywords: 
  - "cliext::vector"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "vector class [STL/CLR]"
  - "<cliext/vector> header [STL/CLR]"
  - "<vector> header [STL/CLR]"
ms.assetid: f90060d5-097a-4e9d-9a26-a634b5b9c6c2
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector (STL-CLR)
The template class describes an object that controls a varying-length sequence of elements that has random access. You use the container `vector` to manage a sequence of elements as a contiguous block of storage. The block is implemented as an array that grows on demand.  
  
 In the description below, `GValue` is the same as `Value` unless the latter is a ref type, in which case it is `Value^`.  
  
## Syntax  
  
```  
template<typename Value>  
    ref class vector  
        :   public  
        System::ICloneable,  
        System::Collections::IEnumerable,  
        System::Collections::ICollection,  
        System::Collections::Generic::IEnumerable<GValue>,  
        System::Collections::Generic::ICollection<GValue>,  
        System::Collections::Generic::IList<GValue>,  
        Microsoft::VisualC::StlClr::IVector<GValue>  
    { ..... };  
```  
  
#### Parameters  
 Value  
 The type of an element in the controlled sequence.  
  
## Members  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|[const_iterator](../vs140/vector--const_iterator--stl-clr-.md)|The type of a constant iterator for the controlled sequence.|  
|[const_reference](../vs140/vector--const_reference--stl-clr-.md)|The type of a constant reference to an element.|  
|[const_reverse_iterator](../vs140/vector--const_reverse_iterator--stl-clr-.md)|The type of a constant reverse iterator for the controlled sequence.|  
|[difference_type](../vs140/vector--difference_type--stl-clr-.md)|The type of a signed distance between two elements.|  
|[generic_container](../vs140/vector--generic_container--stl-clr-.md)|The type of the generic interface for the container.|  
|[generic_iterator](../vs140/vector--generic_iterator--stl-clr-.md)|The type of an iterator for the generic interface for the container.|  
|[generic_reverse_iterator](../vs140/vector--generic_reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the generic interface for the container.|  
|[generic_value](../vs140/vector--generic_value--stl-clr-.md)|The type of an element for the generic interface for the container.|  
|[iterator](../vs140/vector--iterator--stl-clr-.md)|The type of an iterator for the controlled sequence.|  
|[reference](../vs140/vector--reference--stl-clr-.md)|The type of a reference to an element.|  
|[reverse_iterator](../vs140/vector--reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the controlled sequence.|  
|[size_type](../vs140/vector--size_type--stl-clr-.md)|The type of a signed distance between two elements.|  
|[value_type](../vs140/vector--value_type--stl-clr-.md)|The type of an element.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[assign](../vs140/vector--assign--stl-clr-.md)|Replaces all elements.|  
|[at](../vs140/vector--at--stl-clr-.md)|Accesses an element at a specified position.|  
|[back](../vs140/vector--back--stl-clr-.md)|Accesses the last element.|  
|[begin](../vs140/vector--begin--stl-clr-.md)|Designates the beginning of the controlled sequence.|  
|[capacity](../vs140/vector--capacity--stl-clr-.md)|Reports the size of allocated storage for the container.|  
|[clear](../vs140/vector--clear--stl-clr-.md)|Removes all elements.|  
|[empty](../vs140/vector--empty--stl-clr-.md)|Tests whether no elements are present.|  
|[end](../vs140/vector--end--stl-clr-.md)|Designates the end of the controlled sequence.|  
|[erase](../vs140/vector--erase--stl-clr-.md)|Removes elements at specified positions.|  
|[front](../vs140/vector--front--stl-clr-.md)|Accesses the first element.|  
|[insert](../vs140/vector--insert--stl-clr-.md)|Adds elements at a specified position.|  
|[pop_back](../vs140/vector--pop_back--stl-clr-.md)|Removes the last element.|  
|[push_back](../vs140/vector--push_back--stl-clr-.md)|Adds a new last element.|  
|[rbegin](../vs140/vector--rbegin--stl-clr-.md)|Designates the beginning of the reversed controlled sequence.|  
|[rend](../vs140/vector--rend--stl-clr-.md)|Designates the end of the reversed controlled sequence.|  
|[reserve](../vs140/vector--reserve--stl-clr-.md)|Ensures a minimum growth capacity for the container.|  
|[resize](../vs140/vector--resize--stl-clr-.md)|Changes the number of elements.|  
|[size](../vs140/vector--size--stl-clr-.md)|Counts the number of elements.|  
|[swap](../vs140/vector--swap--stl-clr-.md)|Swaps the contents of two containers.|  
|[to_array](../vs140/vector--to_array--stl-clr-.md)|Copies the controlled sequence to a new array.|  
|[vector](../vs140/vector--vector--stl-clr-.md)|Constructs a container object.|  
  
|Property|Description|  
|--------------|-----------------|  
|[back_item](../vs140/vector--back_item--stl-clr-.md)|Accesses the last element.|  
|[front_item](../vs140/vector--front_item--stl-clr-.md)|Accesses the first element.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator=](../vs140/vector--operator=--stl-clr-.md)|Replaces the controlled sequence.|  
|[operator&#91;&#93;](../vs140/vector--operator-stl-clr-.md)|Accesses an element at a specified position.|  
|[vector::operator!= (STL/CLR)](../vs140/operator!=--vector---stl-clr-.md)|Determines if a `vector` object is not equal to another `vector` object.|  
|[vector::operator< (STL/CLR)](../vs140/operator---vector---stl-clr-.md)|Determines if a `vector` object is less than another `vector` object.|  
|[vector::operator<= (STL/CLR)](../vs140/operator-=--vector---stl-clr-.md)|Determines if a `vector` object is less than or equal to another `vector` object.|  
|[vector::operator== (STL/CLR)](../vs140/operator==--vector---stl-clr-.md)|Determines if a `vector` object is equal to another `vector` object.|  
|[vector::operator> (STL/CLR)](../vs140/operator---vector---stl-clr-.md)|Determines if a `vector` object is greater than another `vector` object.|  
|[vector::operator>= (STL/CLR)](../vs140/operator-=--vector---stl-clr-.md)|Determines if a `vector` object is greater than or equal to another `vector` object.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|<xref:System.ICloneable*>|Duplicate an object.|  
|<xref:System.Collections.IEnumerable*>|Sequence through elements.|  
|<xref:System.Collections.ICollection*>|Maintain group of elements.|  
|<xref:System.Collections.Generic.IEnumerable`1*>|Sequence through typed elements.|  
|<xref:System.Collections.Generic.ICollection`1*>|Maintain group of typed elements.|  
|<xref:System.Collections.Generic.IList`1*>|Maintain ordered group of typed elements.|  
|IVector<Value\>|Maintain generic container.|  
  
## Remarks  
 The object allocates and frees storage for the sequence it controls through a stored array of `Value` elements, which grows on demand. Growth occurs in such a way that the cost of appending a new element is amortized constant time. In other words, the cost of adding elements at the end does not increase, on average, as the length of the controlled sequence gets larger. Thus, a vector is a good candidate for the underlying container for template class [stack](../vs140/stack--stl-clr-.md).  
  
 A `vector` supports random-access iterators, which means you can refer to an element directly given its numerical position, counting from zero for the first (front) element, to [size](../vs140/vector--size--stl-clr-.md)`() - 1` for the last (back) element. It also means that a vector is a good candidate for the underlying container for template class [priority_queue](../vs140/priority_queue--stl-clr-.md).  
  
 A vector iterator stores a handle to its associated vector object, along with the bias of the element it designates. You can use iterators only with their associated container objects. The bias of a vector element is the same as its position.  
  
 Inserting or erasing elements can change the element value stored at a given position, so the value designated by an iterator can also change. (The container may have to copy elements up or down to create a hole before an insert or to fill a hole after an erase.) Nevertheless, a vector iterator remains valid so long as its bias is in the range `[0,` [size](../vs140/vector--size--stl-clr-.md)`()]`. Moreover, a valid iterator remains dereferencable -- you can use it to access or alter the element value it designates -- so long as its bias is not equal to `size()`.  
  
 Erasing or removing an element calls the destructor for its stored value. Destroying the container erases all elements. Thus, a container whose element type is a ref class ensures that no elements outlive the container. Note, however, that a container of handles does `not` destroy its elements.  
  
## Requirements  
 **Header:** <cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [list](../vs140/list--stl-clr-.md)   
 [priority_queue](../vs140/priority_queue--stl-clr-.md)   
 [queue](../vs140/queue--stl-clr-.md)   
 [stack](../vs140/stack--stl-clr-.md)   
 [STL/CLR Library](../vs140/stl-clr-library-reference.md)