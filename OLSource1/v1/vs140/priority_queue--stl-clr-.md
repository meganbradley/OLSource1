---
title: "priority_queue (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "priority_queue (STL/CLR)"
f1_keywords: 
  - "cliext::priority_queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "priority_queue class [STL/CLR]"
  - "<queue> header [STL/CLR]"
  - "<cliext/queue> header [STL/CLR]"
ms.assetid: 4d0000d3-68ff-4c4b-8157-7060540136f5
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue (STL-CLR)
The template class describes an object that controls a varying-length ordered sequence of elements that has limited access. You use the container adapter <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to manage an underlying container as a priority queue.  
  
 In the description below, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the same as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> unless the latter is a ref type, in which case it is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Similarly, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the same as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> unless the latter is a ref type, in which case it is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Value  
 The type of an element in the controlled sequence.  
  
 Container  
 The type of the underlying container.  
  
## Members  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|[const_reference](../vs140/priority_queue--const_reference--stl-clr-.md)|The type of a constant reference to an element.|  
|[container_type](../vs140/priority_queue--container_type--stl-clr-.md)|The type of the underlying container.|  
|[difference_type](../vs140/priority_queue--difference_type--stl-clr-.md)|The type of a signed distance between two elements.|  
|[generic_container](../vs140/priority_queue--generic_container--stl-clr-.md)|The type of the generic interface for the container adapter.|  
|[generic_value](../vs140/priority_queue--generic_value--stl-clr-.md)|The type of an element for the generic interface for the container adapter.|  
|[reference](../vs140/priority_queue--reference--stl-clr-.md)|The type of a reference to an element.|  
|[size_type](../vs140/priority_queue--size_type--stl-clr-.md)|The type of a signed distance between two elements.|  
|[value_compare](../vs140/priority_queue--value_compare--stl-clr-.md)|The ordering delegate for two elements.|  
|[value_type](../vs140/priority_queue--value_type--stl-clr-.md)|The type of an element.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[assign](../vs140/priority_queue--assign--stl-clr-.md)|Replaces all elements.|  
|[empty](../vs140/priority_queue--empty--stl-clr-.md)|Tests whether no elements are present.|  
|[get_container](../vs140/priority_queue--get_container--stl-clr-.md)|Accesses the underlying container.|  
|[pop](../vs140/priority_queue--pop--stl-clr-.md)|Removes the hghest-priority element.|  
|[priority_queue](../vs140/priority_queue--priority_queue--stl-clr-.md)|Constructs a container object.|  
|[push](../vs140/priority_queue--push--stl-clr-.md)|Adds a new element.|  
|[size](../vs140/priority_queue--size--stl-clr-.md)|Counts the number of elements.|  
|[top](../vs140/priority_queue--top--stl-clr-.md)|Accesses the highest-priority element.|  
|[to_array](../vs140/priority_queue--to_array--stl-clr-.md)|Copies the controlled sequence to a new array.|  
|[value_comp](../vs140/priority_queue--value_comp--stl-clr-.md)|Copies the ordering delegate for two elements.|  
  
|Property|Description|  
|--------------|-----------------|  
|[top_item](../vs140/priority_queue--top_item--stl-clr-.md)|Accesses the highest-priority element.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator=](../vs140/priority_queue--operator=--stl-clr-.md)|Replaces the controlled sequence.|  
  
## Interfaces  
  
|Interface|Description|  
|---------------|-----------------|  
|\<xref:System.ICloneable*>|Duplicate an object.|  
|IPriorityQueue\<Value, Container>|Maintain generic container adapter.|  
  
## Remarks  
 The object allocates and frees storage for the sequence it controls through an underlying container, of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, that stores <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> elements and grows on demand. It keeps the sequence ordered as a heap, with the highest-priority element (the top element) readily accessible and removable. The object restricts access to pushing new elements and popping just the highest-priority element, implementing a priority queue.  
  
 The object orders the sequence it controls by calling a stored delegate object of type [value_compare](../vs140/priority_queue--value_compare--stl-clr-.md). You can specify the stored delegate object when you construct the priority_queue; if you specify no delegate object, the default is the comparison <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. You access this stored object by calling the member function [value_comp](../vs140/priority_queue--value_comp--stl-clr-.md)<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 Such a delegate object must impose a strict weak ordering on values of type [value_type](../vs140/priority_queue--value_type--stl-clr-.md). That means, for any two keys <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>:  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns the same Boolean result on every call.  
  
 If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is true, then <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> must be false.  
  
 If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is true, then <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is said to be ordered before <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is true, then <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are said to have equivalent ordering.  
  
 For any element <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> that precedes <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in the controlled sequence, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is false. (For the default delegate object, keys never decrease in value.)  
  
 The highest priority element is thus one of the elements which is not ordered before any other element.  
  
 Since the underlying container keeps elements ordered as a heap:  
  
 The container must support random-access iterators.  
  
 Elements with equivalent ordering may be popped in a different order than they were pushed. (The ordering is not stable.)  
  
 Thus, candidates for the underlying container include [deque](../vs140/deque--stl-clr-.md) and [vector](../vs140/vector--stl-clr-.md).  
  
## Requirements  
 **Header:** \<cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [queue](../vs140/queue--stl-clr-.md)   
 [stack](../vs140/stack--stl-clr-.md)   
 [vector](../vs140/vector--stl-clr-.md)   
 [STL/CLR Library](../vs140/stl-clr-library-reference.md)