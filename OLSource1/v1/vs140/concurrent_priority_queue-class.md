---
title: "concurrent_priority_queue Class"
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
  - "concurrent_priority_queue/concurrency::concurrent_priority_queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_priority_queue class"
ms.assetid: 3e740381-0f4e-41fc-8b66-ad0bb55f17a3
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_priority_queue Class
The             <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class is a container that allows multiple threads to concurrently push and pop items. Items are popped in priority order where priority is determined by a functor supplied as a template argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The data type of the elements to be stored in the priority queue.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The type of the function object that can compare two element values as sort keys to determine their relative order in the priority queue. This argument is optional and the binary predicate                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is the default value.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the allocation and deallocation of memory for the concurrent priority queue. This argument is optional and the default value is                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|A type that represents the allocator class for the concurrent priority queue.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|A type that represents a const reference to an element of the type stored in a concurrent priority queue.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|A type that represents a reference to an element of the type stored in a concurrent priority queue.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|A type that counts the number of elements in a concurrent priority queue.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|A type that represents the data type stored in a concurrent priority queue.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_priority_queue::concurrent_priority_queue Constructor](#concurrent_priority_queue__concurrent_priority_queue_constructor)|Overloaded. Constructs a concurrent priority queue.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_priority_queue::clear Method](#concurrent_priority_queue__clear_method)|Erases all elements in the concurrent priority. This method is not concurrency-safe.|  
|[concurrent_priority_queue::empty Method](#concurrent_priority_queue__empty_method)|Tests if the concurrent priority queue is empty at the time this method is called. This method is concurrency-safe.|  
|[concurrent_priority_queue::get_allocator Method](#concurrent_priority_queue__get_allocator_method)|Returns a copy of the allocator used to construct the concurrent priority queue. This method is concurrency-safe.|  
|[concurrent_priority_queue::push Method](#concurrent_priority_queue__push_method)|Overloaded. Adds an element to the concurrent priority queue. This method is concurrency-safe.|  
|[concurrent_priority_queue::size Method](#concurrent_priority_queue__size_method)|Returns the number of elements in the concurrent priority queue. This method is concurrency-safe.|  
|[concurrent_priority_queue::swap Method](#concurrent_priority_queue__swap_method)|Swaps the contents of two concurrent priority queues. This method is not concurrency-safe.|  
|[concurrent_priority_queue::try_pop Method](#concurrent_priority_queue__try_pop_method)|Removes and returns the highest priority element from the queue if the queue is non-empty. This method is concurrency-safe.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_priority_queue::operator= Operator](#concurrent_priority_queue__operator_eq_operator)|Overloaded. Assigns the contents of another                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object to this one. This method is not concurrency-safe.|  
  
## Remarks  
 For detailed information on the                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class, see                 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concurrent_priority_queue.h  
  
 **Namespace:** concurrency  
  
##  \<a name="concurrent_priority_queue__clear_method">\</a>  concurrent_priority_queue::clear Method  
 Erases all elements in the concurrent priority. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is not concurrency-safe. You must ensure that no other threads are invoking methods on the concurrent priority queue when you call this method.                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> does not free memory.  
  
##  \<a name="concurrent_priority_queue__concurrent_priority_queue_constructor">\</a>  concurrent_priority_queue::concurrent_priority_queue Constructor  
 Constructs a concurrent priority queue.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The type of the input iterator.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The allocator class to use with this object.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The initial capacity of the                                 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The position of the first element beyond the range of elements to be copied.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The source                                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object to copy or move elements from.  
  
### Remarks  
 All constructors store an allocator object                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and initialize the priority queue.  
  
 The first constructor specifies an empty initial priority queue and optionally specifies an allocator.  
  
 The second constructor specifies a priority queue with an initial capacity                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and optionally specifies an allocator.  
  
 The third constructor specifies values supplied by the iterator range [                        <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>) and optionally specifies an allocator.  
  
 The fourth and fifth constructors specify a copy of the priority queue                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 The sixth and seventh constructors specify a move of the priority queue                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
##  \<a name="concurrent_priority_queue__empty_method">\</a>  concurrent_priority_queue::empty Method  
 Tests if the concurrent priority queue is empty at the time this method is called. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> if the priority queue was empty at the moment the function was called,                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="concurrent_priority_queue__get_allocator_method">\</a>  concurrent_priority_queue::get_allocator Method  
 Returns a copy of the allocator used to construct the concurrent priority queue. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A copy of the allocator used to construct the                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.  
  
##  \<a name="concurrent_priority_queue__operator_eq_operator">\</a>  concurrent_priority_queue::operator= Operator  
 Assigns the contents of another                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object to this one. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The source                                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A reference to this                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
##  \<a name="concurrent_priority_queue__push_method">\</a>  concurrent_priority_queue::push Method  
 Adds an element to the concurrent priority queue. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The element to be added to the concurrent priority queue.  
  
##  \<a name="concurrent_priority_queue__size_method">\</a>  concurrent_priority_queue::size Method  
 Returns the number of elements in the concurrent priority queue. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements in this                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The returned size is guaranteed to include all elements added by calls to the function                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. However, it may not reflect results of pending concurrent operations.  
  
##  \<a name="concurrent_priority_queue__swap_method">\</a>  concurrent_priority_queue::swap Method  
 Swaps the contents of two concurrent priority queues. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object to swap contents with.  
  
##  \<a name="concurrent_priority_queue__try_pop_method">\</a>  concurrent_priority_queue::try_pop Method  
 Removes and returns the highest priority element from the queue if the queue is non-empty. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 A reference to a variable that will be populated with the highest priority element, if the queue is non-empty.  
  
### Return Value  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> if a value was popped,                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> otherwise.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md)