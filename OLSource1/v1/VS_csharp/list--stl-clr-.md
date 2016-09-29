---
title: "list (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list (STL/CLR)"
f1_keywords: 
  - "cliext::list"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<cliext/list> header [STL/CLR]"
  - "list class [STL/CLR]"
  - "<list> header [STL/CLR]"
ms.assetid: a70c45c8-a257-4f6b-8434-b27ff6685bac
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list (STL-CLR)
The template class describes an object that controls a varying-length sequence of elements that has bidirectional access. You use the container `list` to manage a sequence of elements as a bidirectional linked list of nodes, each storing one element.  
  
 In the description below, `GValue` is the same as `Value` unless the latter is a ref type, in which case it is `Value^`.  
  
## Syntax  
  
```  
template<typename Value>  
    ref class list  
        :   public  
        System::ICloneable,  
        System::Collections::IEnumerable,  
        System::Collections::ICollection,  
        System::Collections::Generic::IEnumerable<GValue>,  
        System::Collections::Generic::ICollection<GValue>,  
        Microsoft::VisualC::StlClr::IList<GValue>  
    { ..... };  
```  
  
#### Parameters  
 Value  
 The type of an element in the controlled sequence.  
  
## Members  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|[const_iterator](../VS_csharp/list--const_iterator--stl-clr-.md)|The type of a constant iterator for the controlled sequence.|  
|[const_reference](../VS_csharp/list--const_reference--stl-clr-.md)|The type of a constant reference to an element.|  
|[const_reverse_iterator](../VS_csharp/list--const_reverse_iterator--stl-clr-.md)|The type of a constant reverse iterator for the controlled sequence.|  
|[difference_type](../VS_csharp/list--difference_type--stl-clr-.md)|The type of a signed distance between two elements.|  
|[generic_container](../VS_csharp/list--generic_container--stl-clr-.md)|The type of the generic interface for the container.|  
|[generic_iterator](../VS_csharp/list--generic_iterator--stl-clr-.md)|The type of an iterator for the generic interface for the container.|  
|[generic_reverse_iterator](../VS_csharp/list--generic_reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the generic interface for the container.|  
|[generic_value](../VS_csharp/list--generic_value--stl-clr-.md)|The type of an element for the generic interface for the container.|  
|[iterator](../VS_csharp/list--iterator--stl-clr-.md)|The type of an iterator for the controlled sequence.|  
|[reference](../VS_csharp/list--reference--stl-clr-.md)|The type of a reference to an element.|  
|[reverse_iterator](../VS_csharp/list--reverse_iterator--stl-clr-.md)|The type of a reverse iterator for the controlled sequence.|  
|[size_type](../VS_csharp/list--size_type--stl-clr-.md)|The type of a signed distance between two elements.|  
|[value_type](../VS_csharp/list--value_type--stl-clr-.md)|The type of an element.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[assign](../VS_csharp/list--assign--stl-clr-.md)|Replaces all elements.|  
|[back](../VS_csharp/list--back--stl-clr-.md)|Accesses the last element.|  
|[begin](../VS_csharp/list--begin--stl-clr-.md)|Designates the beginning of the controlled sequence.|  
|[clear](../VS_csharp/list--clear--stl-clr-.md)|Removes all elements.|  
|[empty](../VS_csharp/list--empty--stl-clr-.md)|Tests whether no elements are present.|  
|[end](../VS_csharp/list--end--stl-clr-.md)|Designates the end of the controlled sequence.|  
|[erase](../VS_csharp/list--erase--stl-clr-.md)|Removes elements at specified positions.|  
|[front](../VS_csharp/list--front--stl-clr-.md)|Accesses the first element.|  
|[insert](../VS_csharp/list--insert--stl-clr-.md)|Adds elements at a specified position.|  
|[list](../VS_csharp/list--list--stl-clr-.md)|Constructs a container object.|  
|[merge](../VS_csharp/list--merge--stl-clr-.md)|Merges two ordered controlled sequences.|  
|[pop_back](../VS_csharp/list--pop_back--stl-clr-.md)|Removes the last element.|  
|[pop_front](../VS_csharp/list--pop_front--stl-clr-.md)|Removes the first element.|  
|[push_back](../VS_csharp/list--push_back--stl-clr-.md)|Adds a new last element.|  
|[push_front](../VS_csharp/list--push_front--stl-clr-.md)|Adds a new first element.|  
|[rbegin](../VS_csharp/list--rbegin--stl-clr-.md)|Designates the beginning of the reversed controlled sequence.|  
|[remove](../VS_csharp/list--remove--stl-clr-.md)|Removes an element with a specified value.|  
|[remove_if](../VS_csharp/list--remove_if--stl-clr-.md)|Removes elements that pass a specified test.|  
|[rend](../VS_csharp/list--rend--stl-clr-.md)|Designates the end of the reversed controlled sequence.|  
|[resize](../VS_csharp/list--resize--stl-clr-.md)|Changes the number of elements.|  
|[reverse](../VS_csharp/list--reverse--stl-clr-.md)|Reverses the controlled sequence.|  
|[size](../VS_csharp/list--size--stl-clr-.md)|Counts the number of elements.|  
|[sort](../VS_csharp/list--sort--stl-clr-.md)|Orders the controlled sequence.|  
|[splice](../VS_csharp/list--splice--stl-clr-.md)|Restitches links between nodes.|  
|[swap](../VS_csharp/list--swap--stl-clr-.md)|Swaps the contents of two containers.|  
|[to_array](../VS_csharp/list--to_array--stl-clr-.md)|Copies the controlled sequence to a new array.|  
|[unique](../VS_csharp/list--unique--stl-clr-.md)|Removes adjacent elements that pass a specified test.|  
  
|Property|Description|  
|--------------|-----------------|  
|[back_item](../VS_csharp/list--back_item--stl-clr-.md)|Accesses the last element.|  
|[front_item](../VS_csharp/list--front_item--stl-clr-.md)|Accesses the first element.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator=](../VS_csharp/list--operator=--stl-clr-.md)|Replaces the controlled sequence.|  
|[list::operator!= (STL/CLR)](../VS_csharp/operator!=--list---stl-clr-.md)|Determines if a `list` object is not equal to another `list` object.|  
|[list::operator< (STL/CLR)](../VS_csharp/operator---list---stl-clr-.md)|Determines if a `list` object is less than another `list` object.|  
|[list::operator<= (STL/CLR)](../VS_csharp/operator-=--list---stl-clr-.md)|Determines if a `list` object is less than or equal to another `list` object.|  
|[list::operator== (STL/CLR)](../VS_csharp/operator==--list---stl-clr-.md)|Determines if a `list` object is equal to another `list` object.|  
|[list::operator> (STL/CLR)](../VS_csharp/operator---list---stl-clr-.md)|Determines if a `list` object is greater than another `list` object.|  
|[list::operator>= (STL/CLR)](../VS_csharp/operator-=--list---stl-clr-.md)|Determines if a `list` object is greater than or equal to another `list` object.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|<xref:System.ICloneable*>|Duplicate an object.|  
|<xref:System.Collections.IEnumerable*>|Sequence through elements.|  
|<xref:System.Collections.ICollection*>|Maintain group of elements.|  
|<xref:System.Collections.Generic.IEnumerable`1*>|Sequence through typed elements.|  
|<xref:System.Collections.Generic.ICollection`1*>|Maintain group of typed elements.|  
|IList<Value\>|Maintain generic container.|  
  
## Remarks  
 The object allocates and frees storage for the sequence it controls as individual nodes in a bidirectional link list. It rearranges elements by altering the links between nodes, never by copying the contents of one node to another. That means you can insert and remove elements freely without disturbing remaining elements. Thus, a list is a good candidate for the underlying container for template class [queue](../VS_csharp/queue--stl-clr-.md) or template class [stack](../VS_csharp/stack--stl-clr-.md).  
  
 A `list` object supports bidirectional iterators, which means you can step to adjacent elements given an iterator that designates an element in the controlled sequence. A special head node corresponds to the iterator returned by [end](../VS_csharp/list--end--stl-clr-.md)`()`. You can decrement this iterator to reach the last element in the controlled sequence, if present. You can increment a list iterator to reach the head node, and it will then compare equal to `end()`. But you cannot dereference the iterator returned by `end()`.  
  
 Note that you cannot refer to a list element directly given its numerical position -- that requires a random-access iterator. So a list is `not` usable as the underlying container for template class [priority_queue](../VS_csharp/priority_queue--stl-clr-.md).  
  
 A list iterator stores a handle to its associated list node, which in turn stores a handle to its associated container. You can use iterators only with their associated container objects. A list iterator remains valid so long as its associated list node is associated with some list. Moreover, a valid iterator is dereferencable -- you can use it to access or alter the element value it designates -- so long as it is not equal to `end()`.  
  
 Erasing or removing an element calls the destructor for its stored value. Destroying the container erases all elements. Thus, a container whose element type is a ref class ensures that no elements outlive the container. Note, however, that a container of handles does `not` destroy its elements.  
  
## Requirements  
 **Header:** <cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../VS_csharp/deque--stl-clr-.md)   
 [priority_queue](../VS_csharp/priority_queue--stl-clr-.md)   
 [queue](../VS_csharp/queue--stl-clr-.md)   
 [stack](../VS_csharp/stack--stl-clr-.md)   
 [vector](../VS_csharp/vector--stl-clr-.md)   
 [STL/CLR Library](../VS_csharp/stl-clr-library-reference.md)