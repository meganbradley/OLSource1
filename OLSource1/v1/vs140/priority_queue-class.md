---
title: "priority_queue Class"
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
  - "std.priority_queue"
  - "priority_queue"
  - "std::priority_queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "priority_queue class"
ms.assetid: 69fca9cc-a449-4be4-97b7-02ca5db9cbb2
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue Class
A template container adaptor class that provides a restriction of functionality limiting access to the top element of some underlying container type, which is always the largest or of the highest priority. New elements can be added to the priority_queue and the top element of the priority_queue can be inspected or removed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Type*  
 The element data type to be stored in the priority_queue.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The type of the underlying container used to implement the priority_queue.  
  
 *Compare*  
 The type that provides a function object that can compare two element values as sort keys to determine their relative order in the priority_queue. This argument is optional and the binary predicate **less***\<***typename** *Container***::value_type***>* is the default value.  
  
## Remarks  
 The elements of class **Type** stipulated in the first template parameter of a queue object are synonymous with [value_type](#priority_queue__value_type) and must match the type of element in the underlying container class **Container** stipulated by the second template parameter. The **Type** must be assignable, so that it is possible to copy objects of that type and to assign values to variables of that type.  
  
 The priority_queue orders the sequence it controls by calling a stored function object of class **Traits**. In general, the elements need be merely less than comparable to establish this order: so that, given any two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. On a more technical note, the comparison function is a binary predicate that induces a strict weak ordering in the standard mathematical sense.  
  
 Suitable underlying container classes for priority_queue include [deque Class](../vs140/deque-class.md) and the default [vector Class](../vs140/vector-class.md) or any other sequence container that supports the operations of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and a random-access iterator. The underlying container class is encapsulated within the container adaptor, which exposes only the limited set of the sequence container member functions as a public interface.  
  
 Adding elements to and removing elements from a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> both have logarithmic complexity. Accessing elements in a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> has constant complexity.  
  
 There are three types of container adaptors defined by the STL: stack, queue, and priority_queue. Each restricts the functionality of some underlying container class to provide a precisely controlled interface to a standard data structure.  
  
-   The [stack class](../vs140/stack-class.md) supports a last-in, first-out (LIFO) data structure. A good analogue to keep in mind would be a stack of plates. Elements (plates) may be inserted, inspected, or removed only from the top of the stack, which is the last element at the end of the base container. The restriction to accessing only the top element is the reason for using the stack class.  
  
-   The [queue class](../vs140/queue-class.md) supports a first-in, first-out (FIFO) data structure. A good analogue to keep in mind would be people lining up for a bank teller. Elements (people) may be added to the back of the line and are removed from the front of the line. Both the front and the back of a line may be inspected. The restriction to accessing only the front and back elements in this way is the reason for using the queue class.  
  
-   The priority_queue class orders its elements so that the largest element is always at the top position. It supports insertion of an element and the inspection and removal of the top element. A good analogue to keep in mind would be people lining up where they are arranged by age, height, or some other criterion.  
  
### Constructors  
  
|||  
|-|-|  
|[priority_queue](#priority_queue__priority_queue)|Constructs a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> that is empty or that is a copy of a range of a base container object or of other <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[container_type](#priority_queue__container_type)|A type that provides the base container to be adapted by a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|[size_type](#priority_queue__size_type)|An unsigned integer type that can represent the number of elements in a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[value_type](#priority_queue__value_type)|A type that represents the type of object stored as an element in a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[empty](#priority_queue__empty)|Tests if the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is empty.|  
|[pop](#priority_queue__pop)|Removes the largest element of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> from the top position.|  
|[push](#priority_queue__push)|Adds an element to the priority queue based on the priority of the element from operator<.|  
|[size](#priority_queue__size)|Returns the number of elements in the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.|  
|[top](#priority_queue__top)|Returns a const reference to the largest element at the top of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<queue>  
  
 **Namespace:** std  
  
##  \<a name="priority_queue__container_type">\</a>  priority_queue::container_type  
 A type that provides the base container to be adapted.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. The STL sequence container class deque and the default class vector meet the requirements to be used as the base container for a priority_queue object. User-defined types satisfying the requirements may also be used.  
  
 For more information on <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, see the Remarks section of the [priority_queue Class](../vs140/priority_queue-class.md) topic.  
  
### Example  
  See the example for [priority_queue](#priority_queue__priority_queue) for an example of how to declare and use <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
##  \<a name="priority_queue__empty">\</a>  priority_queue::empty  
 Tests if a priority_queue is empty.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the priority_queue is empty; **false** if the priority_queue is nonempty.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The priority_queue q1 is not empty.**  
**The priority_queue s2 is empty.**    
##  \<a name="priority_queue__pop">\</a>  priority_queue::pop  
 Removes the largest element of the priority_queue from the top position.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The priority_queue must be nonempty to apply the member function. The top of the priority_queue is always occupied by the largest element in the container.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The priority_queue length is 3.**  
**The element at the top of the priority_queue is 30.**  
**After a pop, the priority_queue length is 2.**  
**After a pop, the element at the top of the priority_queue is 20.**    
##  \<a name="priority_queue__priority_queue">\</a>  priority_queue::priority_queue  
 Constructs a priority_queue that is empty or that is a copy of a range of a base container object or of another priority_queue.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 *__Comp*  
 The comparison function of type **constTraits** used to order the elements in the priority_queue, which defaults to compare function of the base container.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The base container of which the constructed priority_queue is to be a copy.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The priority_queue of which the constructed set is to be a copy.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The position of the first element beyond the range of elements to be copied.  
  
### Remarks  
 Each of the first three constructors specifies an empty initial priority_queue, the second also specifying the type of comparison function ( <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifying the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>) to be used. The keyword **explicit** suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the priority_queue <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 The last three constructors copy the range [                        *_First, _Last*) of some container and use the values to initialize a priority_queue with increasing explicitness in specifying the type of comparison function of class **Traits** and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="priority_queue__push">\</a>  priority_queue::push  
 Adds an element to the priority queue based on the priority of the element from operator<.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The element added to the top of the priority_queue.  
  
### Remarks  
 The top of the priority_queue is the position occupied by the largest element in the container.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The priority_queue length is 3.**  
**The element at the top of the priority_queue is 30.**    
##  \<a name="priority_queue__size">\</a>  priority_queue::size  
 Returns the number of elements in the priority_queue.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the priority_queue.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **The priority_queue length is 1.**  
**The priority_queue length is now 2.**    
##  \<a name="priority_queue__size_type">\</a>  priority_queue::size_type  
 An unsigned integer type that can represent the number of elements in a priority_queue.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> of the base container adapted by the priority_queue.  
  
### Example  
  See the example for [size](#priority_queue__size) for an example of how to declare and use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
##  \<a name="priority_queue__top">\</a>  priority_queue::top  
 Returns a const reference to the largest element at the top of the priority_queue.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the largest element, as determined by the **Traits** function, object of the priority_queue.  
  
### Remarks  
 The priority_queue must be nonempty to apply the member function.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **The priority_queue length is 3.**  
**The element at the top of the priority_queue is 30.**    
##  \<a name="priority_queue__value_type">\</a>  priority_queue::value_type  
 A type that represents the type of object stored as an element in a priority_queue.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> of the base container adapted by the priority_queue.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **The value_type is AnInt = 69**  
**The element at the top of the priority_queue is 69.**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)