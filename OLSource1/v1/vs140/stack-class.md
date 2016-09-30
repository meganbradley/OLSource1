---
title: "stack Class"
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
  - "std::stack"
  - "std.stack"
  - "stack"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stack, stack class"
  - "stack class"
ms.assetid: 02151c1e-eab0-41b8-be94-a839ead78ecf
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stack Class
A template container adaptor class that provides a restriction of functionality limiting access to the element most recently added to some underlying container type. The stack class is used when it is important to be clear that only stack operations are being performed on the container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Type*  
 The element data type to be stored in the stack.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The type of the underlying container used to implement the stack. The default value is the class <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>*\<Type>*.  
  
## Remarks  
 The elements of class **Type** stipulated in the first template parameter of a stack object are synonymous with [value_type](#stack__value_type) and must match the type of element in the underlying container class **Container** stipulated by the second template parameter. The **Type** must be assignable, so that it is possible to copy objects of that type and to assign values to variables of that type.  
  
 Suitable underlying container classes for stack include [deque](../vs140/deque-class.md), [list](../vs140/list-class.md), and [vector](../vs140/vector-class.md), or any other sequence container that supports the operations of **back**, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The underlying container class is encapsulated within the container adaptor, which exposes only the limited set of the sequence container member functions as a public interface.  
  
 The stack objects are equality comparable if and only if the elements of class **Type** are equality comparable and are less-than comparable if and only if the elements of class **Type** are less-than comparable.  
  
-   The stack class supports a last-in, first-out (LIFO) data structure. A good analogue to keep in mind would be a stack of plates. Elements (plates) may be inserted, inspected, or removed only from the top of the stack, which is the last element at the end of the base container. The restriction to accessing only the top element is the reason for using the stack class.  
  
-   The [queue class](../vs140/queue-class.md) supports a first-in, first-out (FIFO) data structure. A good analogue to keep in mind would be people lining up for a bank teller. Elements (people) may be added to the back of the line and are removed from the front of the line. Both the front and the back of a line may be inspected. The restriction to accessing only the front and back elements in this way is the reason fur using the queue class.  
  
-   The [priority_queue class](../vs140/priority_queue-class.md) orders its elements so that the largest element is always at the top position. It supports insertion of an element and the inspection and removal of the top element. A good analogue to keep in mind would be people lining up where they are arranged by age, height, or some other criterion.  
  
### Constructors  
  
|||  
|-|-|  
|[stack](#stack__stack)|Constructs a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> that is empty or that is a copy of a base container object.|  
  
### Typedefs  
  
|||  
|-|-|  
|[container_type](#stack__container_type)|A type that provides the base container to be adapted by a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.|  
|[size_type](#stack__size_type)|An unsigned integer type that can represent the number of elements in a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.|  
|[value_type](#stack__value_type)|A type that represents the type of object stored as an element in a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[empty](#stack__empty)|Tests if the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is empty.|  
|[pop](#stack__pop)|Removes the element from the top of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[push](#stack__push)|Adds an element to the top of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
|[size](#stack__size)|Returns the number of elements in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
|[top](#stack__top)|Returns a reference to an element at the top of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<stack>  
  
 **Namespace:** std  
  
##  \<a name="stack__container_type">\</a>  stack::container_type  
 A type that provides the base container to be adapted.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. All three STL sequence container classes — the vector class, list class, and the default class deque — meet the requirements to be used as the base container for a stack object. User-defined types satisfying these requirements may also be used.  
  
 For more information on <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, see the Remarks section of the [stack Class](../vs140/stack-class.md) topic.  
  
### Example  
  See the example for [stack::stack](#stack__stack) for an example of how to declare and use <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
##  \<a name="stack__empty">\</a>  stack::empty  
 Tests if a stack is empty.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the stack is empty; **false** if the stack is nonempty.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The stack s1 is not empty.**  
**The stack s2 is empty.**    
##  \<a name="stack__pop">\</a>  stack::pop  
 Removes the element from the top of the stack.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The stack must be nonempty to apply the member function. The top of the stack is the position occupied by the most recently added element and is the last element at the end of the container.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The stack length is 3.**  
**The element at the top of the stack is 30.**  
**After a pop, the stack length is 2.**  
**After a pop, the element at the top of the stack is 20.**    
##  \<a name="stack__push">\</a>  stack::push  
 Adds an element to the top end of the stack.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The element added to the top of the stack.  
  
### Remarks  
 The top of the stack is the position occupied by the most recently added element and is the last element at the end of the container.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The stack length is 3.**  
**The element at the top of the stack is 30.**    
##  \<a name="stack__size">\</a>  stack::size  
 Returns the number of elements in the stack.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the stack.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The stack length is 1.**  
**The stack length is now 2.**    
##  \<a name="stack__size_type">\</a>  stack::size_type  
 An unsigned integer type that can represent the number of elements in a stack.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> of the base container adapted by the stack.  
  
### Example  
  See the example for [size](#stack__size) for an example of how to declare and use <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
##  \<a name="stack__stack">\</a>  stack::stack  
 Constructs a stack that is empty or that is a copy of a base container class.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The container of which the constructed stack is to be a copy.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **The element at the top of stack vsi2 is 1.**    
##  \<a name="stack__top">\</a>  stack::top  
 Returns a reference to an element at the top of the stack.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the last element in the container at the top of the stack.  
  
### Remarks  
 The stack must be nonempty to apply the member function. The top of the stack is the position occupied by the most recently added element and is the last element at the end of the container.  
  
 If the return value of **top** is assigned to a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, the stack object cannot be modified. If the return value of **top** is assigned to a **reference**, the stack object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **The top integer of the stack s1 is 2.**  
**The next integer down is 1.**    
##  \<a name="stack__value_type">\</a>  stack::value_type  
 A type that represents the type of object stored as an element in a stack.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> of the base container adapted by the stack.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **The value_type is AnInt = 69**  
**The element at the top of the stack is 69.**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)