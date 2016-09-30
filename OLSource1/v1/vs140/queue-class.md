---
title: "queue Class"
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
  - "std.queue"
  - "std::queue"
  - "queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "queue class"
ms.assetid: 28c20ab0-3a72-4185-9e0f-5a44eea0e204
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# queue Class
A template container adaptor class that provides a restriction of functionality for some underlying container type, limiting access to the front and back elements. Elements can be added at the back or removed from the front, and elements can be inspected at either end of the queue.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Type*  
 The element data type to be stored in the queue  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The type of the underlying container used to implement the queue.  
  
## Remarks  
 The elements of class **Type** stipulated in the first template parameter of a queue object are synonymous with [value_type](#queue__value_type) and must match the type of element in the underlying container class **Container** stipulated by the second template parameter. The **Type** must be assignable, so that it is possible to copy objects of that type and to assign values to variables of that type.  
  
 Suitable underlying container classes for queue include [deque](../vs140/deque-class.md) and [list](../vs140/list-class.md), or any other sequence container that supports the operations of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, **back**, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The underlying container class is encapsulated within the container adaptor, which exposes only the limited set of the sequence container member functions as a public interface.  
  
 The queue objects are equality comparable if and only if the elements of class **Type** are equality comparable, and are less-than comparable if and only if the elements of class **Type** are less-than comparable.  
  
 There are three types of container adaptors defined by the STL: stack, queue, and priority_queue. Each restricts the functionality of some underlying container class to provide a precisely controlled interface to a standard data structure.  
  
-   The [stack class](../vs140/stack-class.md) supports a last-in, first-out (LIFO) data structure. A good analogue to keep in mind would be a stack of plates. Elements (plates) may be inserted, inspected, or removed only from the top of the stack, which is the last element at the end of the base container. The restriction to accessing only the top element is the reason for using the stack class.  
  
-   The queue class supports a first-in, first-out (FIFO) data structure. A good analogue to keep in mind would be people lining up for a bank teller. Elements (people) may be added to the back of the line and are removed from the front of the line. Both the front and the back of a line may be inspected. The restriction to accessing only the front and back elements in this way is the reason for using the queue class.  
  
-   The [priority_queue class](../vs140/priority_queue-class.md) orders its elements so that the largest element is always at the top position. It supports insertion of an element and the inspection and removal of the top element. A good analogue to keep in mind would be people lining up where they are arranged by age, height, or some other criterion.  
  
### Constructors  
  
|||  
|-|-|  
|[queue](#queue__queue)|Constructs a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> that is empty or that is a copy of a base container object.|  
  
### Typedefs  
  
|||  
|-|-|  
|[container_type](#queue__container_type)|A type that provides the base container to be adapted by the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
|[size_type](#queue__size_type)|An unsigned integer type that can represent the number of elements in a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|[value_type](#queue__value_type)|A type that represents the type of object stored as an element in a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[back](#queue__back)|Returns a reference to the last and most recently added element at the back of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
|[empty](#queue__empty)|Tests if the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is empty.|  
|[front](#queue__front)|Returns a reference to the first element at the front of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.|  
|[pop](#queue__pop)|Removes an element from the front of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.|  
|[push](#queue__push)|Adds an element to the back of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.|  
|[size](#queue__size)|Returns the number of elements in the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<queue>  
  
 **Namespace:** std  
  
##  \<a name="queue__back">\</a>  queue::back  
 Returns a reference to the last and most recently added element at the back of the queue.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The last element of the queue. If the queue is empty, the return value is undefined.  
  
### Remarks  
 If the return value of **back** is assigned to a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, the queue object cannot be modified. If the return value of **back** is assigned to a **reference**, the queue object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty queue.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="queue__container_type">\</a>  queue::container_type  
 A type that provides the base container to be adapted.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. Two STL sequence container classes — the list class and the default deque class — meet the requirements to be used as the base container for a queue object. User-defined types satisfying the requirements may also be used.  
  
 For more information on <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, see the Remarks section of the [queue Class](../vs140/queue-class.md) topic.  
  
### Example  
  See the example for [queue](#queue__queue) for an example of how to declare and use <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
##  \<a name="queue__empty">\</a>  queue::empty  
 Tests if a queue is empty.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the queue is empty; **false** if the queue is nonempty.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The queue q1 is not empty.**  
**The queue q2 is empty.**    
##  \<a name="queue__front">\</a>  queue::front  
 Returns a reference to the first element at the front of the queue.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The first element of the queue. If the queue is empty, the return value is undefined.  
  
### Remarks  
 If the return value of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, the queue object cannot be modified. If the return value of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is assigned to a **reference**, the queue object can be modified.  
  
 The member function returns a **reference** to the first element of the controlled sequence, which must be nonempty.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty queue.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="queue__pop">\</a>  queue::pop  
 Removes an element from the front of the queue.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 The queue must be nonempty to apply the member function. The top of the queue is the position occupied by the most recently added element and is the last element at the end of the container.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The queue length is 3.**  
**The element at the front of the queue is 10.**  
**After a pop the queue length is 2.**  
**After a pop, the element at the front of the queue is 20.**    
##  \<a name="queue__push">\</a>  queue::push  
 Adds an element to the back of the queue.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The element added to the back of the queue.  
  
### Remarks  
 The back of the queue is the position occupied by the most recently added element and is the last element at the end of the container.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **The queue length is 3.**  
**The element at the front of the queue is 10.**    
##  \<a name="queue__queue">\</a>  queue::queue  
 Constructs a queue that is empty or that is a copy of a base container object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The **const** container of which the constructed queue is to be a copy.  
  
### Remarks  
 The default base container for queue is deque. You can also specify list as a base container, but you cannot specify vector, because it lacks the required <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> member function.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The element at the front of queue q5 is 1.**  
**The element at the back of queue q5 is 2.**    
##  \<a name="queue__size">\</a>  queue::size  
 Returns the number of elements in the queue.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the queue.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **The queue length is 1.**  
**The queue length is now 2.**    
##  \<a name="queue__size_type">\</a>  queue::size_type  
 An unsigned integer type that can represent the number of elements in a queue.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> of the base container adapted by the queue.  
  
### Example  
  See the example for [queue::front](#queue__front) for an example of how to declare and use <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
##  \<a name="queue__value_type">\</a>  queue::value_type  
 A type that represents the type of object stored as an element in a queue.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> of the base container adapted by the queue.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The value_type is AnInt = 69**  
**The element at the front of the queue is 69.**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)