---
title: "stack (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "stack (STL/CLR)"
f1_keywords: 
  - "cliext::stack"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<stack> header [STL/CLR]"
  - "<cliext/stack> header [STL/CLR]"
  - "stack class [STL/CLR]"
ms.assetid: 6ee96b9f-8a33-4cf7-b7e0-6535c24bdefb
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stack (STL-CLR)
The template class describes an object that controls a varying-length sequence of elements that has last-in first-out access. You use the container adapter `stack` to manage an underlying container as a push-down stack.  
  
 In the description below, `GValue` is the same as `Value` unless the latter is a ref type, in which case it is `Value^`. Similarly, `GContainer` is the same as `Container` unless the latter is a ref type, in which case it is `Container^`.  
  
## Syntax  
  
```  
template<typename Value,  
    typename Container>  
    ref class stack  
        :   public  
        System::ICloneable,  
        Microsoft::VisualC::StlClr::IStack<GValue, GContainer>  
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
|[const_reference](../VS_csharp/stack--const_reference--stl-clr-.md)|The type of a constant reference to an element.|  
|[container_type](../VS_csharp/stack--container_type--stl-clr-.md)|The type of the underlying container.|  
|[difference_type](../VS_csharp/stack--difference_type--stl-clr-.md)|The type of a signed distance between two elements.|  
|[generic_container](../VS_csharp/stack--generic_container--stl-clr-.md)|The type of the generic interface for the container adapter.|  
|[generic_value](../VS_csharp/stack--generic_value--stl-clr-.md)|The type of an element for the generic interface for the container adapter.|  
|[reference](../VS_csharp/stack--reference--stl-clr-.md)|The type of a reference to an element.|  
|[size_type](../VS_csharp/stack--size_type--stl-clr-.md)|The type of a signed distance between two elements.|  
|[value_type](../VS_csharp/stack--value_type--stl-clr-.md)|The type of an element.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[assign](../VS_csharp/stack--assign--stl-clr-.md)|Replaces all elements.|  
|[empty](../VS_csharp/stack--empty--stl-clr-.md)|Tests whether no elements are present.|  
|[get_container](../VS_csharp/stack--get_container--stl-clr-.md)|Accesses the underlying container.|  
|[pop](../VS_csharp/stack--pop--stl-clr-.md)|Removes the last element.|  
|[push](../VS_csharp/stack--push--stl-clr-.md)|Adds a new last element.|  
|[size](../VS_csharp/stack--size--stl-clr-.md)|Counts the number of elements.|  
|[stack](../VS_csharp/stack--stack--stl-clr-.md)|Constructs a container object.|  
|[top](../VS_csharp/stack--top--stl-clr-.md)|Accesses the last element.|  
|[to_array](../VS_csharp/stack--to_array--stl-clr-.md)|Copies the controlled sequence to a new array.|  
  
|Property|Description|  
|--------------|-----------------|  
|[top_item](../VS_csharp/stack--top_item--stl-clr-.md)|Accesses the last element.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator=](../VS_csharp/stack--operator=--stl-clr-.md)|Replaces the controlled sequence.|  
|[stack::operator!= (STL/CLR)](../VS_csharp/operator!=--stack---stl-clr-.md)|Determines if a `stack` object is not equal to another `stack` object.|  
|[stack::operator< (STL/CLR)](../VS_csharp/operator---stack---stl-clr-.md)|Determines if a `stack` object is less than another `stack` object.|  
|[stack::operator<= (STL/CLR)](../VS_csharp/operator-=--stack---stl-clr-.md)|Determines if a `stack` object is less than or equal to another `stack` object.|  
|[stack::operator== (STL/CLR)](../VS_csharp/operator==--stack---stl-clr-.md)|Determines if a `stack` object is equal to another `stack` object.|  
|[stack::operator> (STL/CLR)](../VS_csharp/operator---stack---stl-clr-.md)|Determines if a `stack` object is greater than another `stack` object.|  
|[stack::operator>= (STL/CLR)](../VS_csharp/operator-=--stack---stl-clr-.md)|Determines if a `stack` object is greater than or equal to another `stack` object.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|<xref:System.ICloneable*>|Duplicate an object.|  
|IStack<Value, Container>|Maintain generic container adapter.|  
  
## Remarks  
 The object allocates and frees storage for the sequence it controls through an underlying container, of type `Container`, that stores `Value` elements and grows on demand. The object restricts access to pushing and popping just the last element, implementing a last-in first-out queue (also known as a LIFO queue, or stack).  
  
## Requirements  
 **Header:** <cliext/stack>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../VS_csharp/deque--stl-clr-.md)   
 [list](../VS_csharp/list--stl-clr-.md)   
 [priority_queue](../VS_csharp/priority_queue--stl-clr-.md)   
 [queue](../VS_csharp/queue--stl-clr-.md)   
 [vector](../VS_csharp/vector--stl-clr-.md)   
 [STL/CLR Library](../VS_csharp/stl-clr-library-reference.md)