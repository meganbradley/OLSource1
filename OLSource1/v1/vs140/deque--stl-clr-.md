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
The template class describes an object that controls a varying-length sequence of elements that has random access. You use the container `deque` to manage a sequence of elements that looks like a contiguous block of storage, but which can grow or shrink at either end without the need to copy any remaining elements. Thus it can implement efficiently a `double-ended queue`. (Hence the name.)  
  
 In the description below, `GValue` is the same as `Value` unless the latter is a ref type, in which case it is `Value^`.  
  
## Syntax  
  
```  
template<typename Value>  
    ref class deque  
        :   public  
        System::ICloneable,  
        System::Collections::IEnumerable,  
        System::Collections::ICollection,  
        System::Collections::Generic::IEnumerable<GValue>,  
        System::Collections::Generic::ICollection<GValue>,  
        System::Collections::Generic::IList<GValue>,  
        Microsoft::VisualC::StlClr::IDeque<GValue>  
    { ..... };  
```  
  
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
|[deque::operator!= (STL/CLR)](../vs140/deque--operator!=--stl-clr-.md)|Determines if two `deque` objects are not equal.|  
|[operator&#91;&#93;](../vs140/deque--operator-stl-clr-.md)|Accesses an element at a specified position.|  
|[deque::operator< (STL/CLR)](../vs140/operator---deque---stl-clr-.md)|Determines if a `deque` object is less than another `deque` object.|  
|[deque::operator<= (STL/CLR)](../vs140/operator-=--deque---stl-clr-.md)|Determines if a `deque` object is less than or equal to another `deque` object.|  
|[operator=](../vs140/operator=--deque---stl-clr-.md)|Replaces the controlled sequence.|  
|[deque::operator== (STL/CLR)](../vs140/operator==--deque---stl-clr-.md)|Determines if a `deque` object is equal to another `deque` object.|  
|[deque::operator> (STL/CLR)](../vs140/operator---deque---stl-clr-.md)|Determines if a `deque` object is greater than another `deque` object.|  
|[deque::operator>= (STL/CLR)](../vs140/operator-=--deque---stl-clr-.md)|Determines if a `deque` object is greater than or equal to another `deque` object.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|<xref:System.ICloneable*>|Duplicate an object.|  
|<xref:System.Collections.IEnumerable*>|Sequence through elements.|  
|<xref:System.Collections.ICollection*>|Maintain group of elements.|  
|<xref:System.Collections.Generic.IEnumerable`1*>|Sequence through typed elements.|  
|<xref:System.Collections.Generic.ICollection`1*>|Maintain group of typed elements.|  
|<xref:System.Collections.Generic.IList`1*>|Maintain ordered group of typed elements.|  
|IDeque<Value\>|Maintain generic container.|  
  
## Remarks  
 The object allocates and frees storage for the sequence it controls through a stored array of handles that designate blocks of `Value` elements. The array grows on demand. Growth occurs in such a way that the cost of either prepending or appending a new element is constant time, and no remaining elements are disturbed. You can also remove an element at either end in constant time, and without disturbing remaining elements. Thus, a deque is a good candidate for the underlying container for template class [queue](../vs140/queue--stl-clr-.md) or template class [stack](../vs140/stack--stl-clr-.md).  
  
 A `deque` object supports random-access iterators, which means you can refer to an element directly given its numerical position, counting from zero for the first (front) element, to [size](../vs140/deque--size--stl-clr-.md)`() - 1` for the last (back) element. It also means that a deque is a good candidate for the underlying container for template class [priority_queue](../vs140/priority_queue--stl-clr-.md).  
  
 A deque iterator stores a handle to its associated deque object, along with the bias of the element it designates. You can use iterators only with their associated container objects. The bias of a deque element is `not` necessarily the same as its position. The first element inserted has bias zero, the next appended element has bias 1, but the next prepended element has bias -1.  
  
 Inserting or erasing elements at either end does `not` alter the value of an element stored at any valid bias. Inserting or erasing an interior element, however, `can` change the element value stored at a given bias, so the value designated by an iterator can also change. (The container may have to copy elements up or down to create a hole before an insert or to fill a hole after an erase.) Nevertheless, a deque iterator remains valid so long as its bias designates a valid element. Moreover, a valid iterator remains dereferencable -- you can use it to access or alter the element value it designates -- so long as its bias is not equal to the bias for the iterator returned by `end()`.  
  
 Erasing or removing an element calls the destructor for its stored value. Destroying the container erases all elements. Thus, a container whose element type is a ref class ensures that no elements outlive the container. Note, however, that a container of handles does `not` destroy its elements.  
  
## Requirements  
 **Header:** <cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [priority_queue](../vs140/priority_queue--stl-clr-.md)   
 [queue](../vs140/queue--stl-clr-.md)   
 [stack](../vs140/stack--stl-clr-.md)   
 [vector](../vs140/vector--stl-clr-.md)   
 [STL/CLR Library](../vs140/stl-clr-library-reference.md)