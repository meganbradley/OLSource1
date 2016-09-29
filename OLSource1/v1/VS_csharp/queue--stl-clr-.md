---
title: "queue (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "queue (STL/CLR)"
f1_keywords: 
  - "cliext::queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<queue> header [STL/CLR]"
  - "queue class [STL/CLR]"
  - "<cliext/queue> header [STL/CLR]"
ms.assetid: 9ea7dec3-ea98-48ff-87d0-a5afc924aaf2
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# queue (STL-CLR)
The template class describes an object that controls a varying-length sequence of elements that has first-in first-out access. You use the container adapter `queue` to manage an underlying container as a queue.  
  
 In the description below, `GValue` is the same as `Value` unless the latter is a ref type, in which case it is `Value^`. Similarly, `GContainer` is the same as `Container` unless the latter is a ref type, in which case it is `Container^`.  
  
## Syntax  
  
```  
template<typename Value,  
    typename Container>  
    ref class queue  
        :   public  
        System::ICloneable,  
        Microsoft::VisualC::StlClr::IQueue<GValue, GContainer>  
    { ..... };  
```  
  
#### Parameters  
 Value  
 The type of an element in the controlled sequence.  
  
 Container  
 The type of the underlying container.  
  
## Members  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|[const_reference](../VS_csharp/queue--const_reference--stl-clr-.md)|The type of a constant reference to an element.|  
|[container_type](../VS_csharp/queue--container_type--stl-clr-.md)|The type of the underlying container.|  
|[difference_type](../VS_csharp/queue--difference_type--stl-clr-.md)|The type of a signed distance between two elements.|  
|[generic_container](../VS_csharp/queue--generic_container--stl-clr-.md)|The type of the generic interface for the container adapter.|  
|[generic_value](../VS_csharp/queue--generic_value--stl-clr-.md)|The type of an element for the generic interface for the container adapter.|  
|[reference](../VS_csharp/queue--reference--stl-clr-.md)|The type of a reference to an element.|  
|[size_type](../VS_csharp/queue--size_type--stl-clr-.md)|The type of a signed distance between two elements.|  
|[value_type](../VS_csharp/queue--value_type--stl-clr-.md)|The type of an element.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[assign](../VS_csharp/queue--assign--stl-clr-.md)|Replaces all elements.|  
|[back](../VS_csharp/queue--back--stl-clr-.md)|Accesses the last element.|  
|[empty](../VS_csharp/queue--empty--stl-clr-.md)|Tests whether no elements are present.|  
|[front](../VS_csharp/queue--front--stl-clr-.md)|Accesses the first element.|  
|[get_container](../VS_csharp/queue--get_container--stl-clr-.md)|Accesses the underlying container.|  
|[pop](../VS_csharp/queue--pop--stl-clr-.md)|Removes the first element.|  
|[push](../VS_csharp/queue--push--stl-clr-.md)|Adds a new last element.|  
|[queue](../VS_csharp/queue--queue--stl-clr-.md)|Constructs a container object.|  
|[size](../VS_csharp/queue--size--stl-clr-.md)|Counts the number of elements.|  
|[to_array](../VS_csharp/queue--to_array--stl-clr-.md)|Copies the controlled sequence to a new array.|  
  
|Property|Description|  
|--------------|-----------------|  
|[back_item](../VS_csharp/queue--back_item--stl-clr-.md)|Accesses the last element.|  
|[front_item](../VS_csharp/queue--front_item--stl-clr-.md)|Accesses the first element.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator=](../VS_csharp/queue--operator=--stl-clr-.md)|Replaces the controlled sequence.|  
|[queue::operator!= (STL/CLR)](../VS_csharp/operator!=--queue---stl-clr-.md)|Determines if a `queue` object is not equal to another `queue` object.|  
|[queue::operator< (STL/CLR)](../VS_csharp/operator---queue---stl-clr-.md)|Determines if a `queue` object is less than another `queue` object.|  
|[queue::operator<= (STL/CLR)](../VS_csharp/operator-=--queue---stl-clr-.md)|Determines if a `queue` object is less than or equal to another `queue` object.|  
|[queue::operator== (STL/CLR)](../VS_csharp/operator==--queue---stl-clr-.md)|Determines if a `queue` object is equal to another `queue` object.|  
|[queue::operator> (STL/CLR)](../VS_csharp/operator---queue---stl-clr-.md)|Determines if a `queue` object is greater than another `queue` object.|  
|[queue::operator>= (STL/CLR)](../VS_csharp/operator-=--queue---stl-clr-.md)|Determines if a `queue` object is greater than or equal to another `queue` object.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|<xref:System.ICloneable*>|Duplicate an object.|  
|IQueue<Value, Container>|Maintain generic container adapter.|  
  
## Remarks  
 The object allocates and frees storage for the sequence it controls through an underlying container, of type `Container`, that stores `Value` elements and grows on demand. The object restricts access to just pushing the first element and popping the last element, implementing a first-in first-out queue (also known as a FIFO queue, or simply a queue).  
  
## Requirements  
 **Header:** <cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../VS_csharp/deque--stl-clr-.md)   
 [list](../VS_csharp/list--stl-clr-.md)   
 [priority_queue](../VS_csharp/priority_queue--stl-clr-.md)   
 [stack](../VS_csharp/stack--stl-clr-.md)   
 [vector](../VS_csharp/vector--stl-clr-.md)   
 [STL/CLR Library](../VS_csharp/stl-clr-library-reference.md)