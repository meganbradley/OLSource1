---
title: "concurrent_queue Class"
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
  - "concurrent_queue/concurrency::concurrent_queue"
  - "concurrent_queue/Concurrency::concurrent_queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_queue class"
ms.assetid: c2218996-d0ea-40e9-b002-e9a15b085f51
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_queue Class
The             <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class is a sequence container class that allows first-in, first-out access to its elements. It enables a limited set of concurrency-safe operations, such as             <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and             <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The data type of the elements to be stored in the queue.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the allocation and deallocation of memory for this concurrent queue. This argument is optional and the default value is                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|A type that represents the allocator class for the concurrent queue.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|A type that represents a non-thread-safe                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> iterator over elements in a concurrent queue.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|A type that provides a reference to a                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> element stored in a concurrent queue for reading and performing                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> operations.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|A type that provides the signed distance between two elements in a concurrent queue.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|A type that represents a non-thread-safe iterator over the elements in a concurrent queue.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|A type that provides a reference to an element stored in a concurrent queue.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|A type that counts the number of elements in a concurrent queue.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|A type that represents the data type stored in a concurrent queue.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_queue::concurrent_queue Constructor](#concurrent_queue__concurrent_queue_constructor)|Overloaded. Constructs a concurrent queue.|  
|[concurrent_queue::~concurrent_queue Destructor](#concurrent_queue___dtorconcurrent_queue_destructor)|Destroys the concurrent queue.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_queue::clear Method](#concurrent_queue__clear_method)|Clears the concurrent queue, destroying any currently enqueued elements. This method is not concurrency-safe.|  
|[concurrent_queue::empty Method](#concurrent_queue__empty_method)|Tests if the concurrent queue is empty at the moment this method is called. This method is concurrency-safe.|  
|[concurrent_queue::get_allocator Method](#concurrent_queue__get_allocator_method)|Returns a copy of the allocator used to construct the concurrent queue. This method is concurrency-safe.|  
|[concurrent_queue::push Method](#concurrent_queue__push_method)|Overloaded. Enqueues an item at tail end of the concurrent queue. This method is concurrency-safe.|  
|[concurrent_queue::try_pop Method](#concurrent_queue__try_pop_method)|Dequeues an item from the queue if one is available. This method is concurrency-safe.|  
|[concurrent_queue::unsafe_begin Method](#concurrent_queue__unsafe_begin_method)|Overloaded. Returns an iterator of type                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to the beginning of the concurrent queue. This method is not concurrency-safe.|  
|[concurrent_queue::unsafe_end Method](#concurrent_queue__unsafe_end_method)|Overloaded. Returns an iterator of type                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to the end of the concurrent queue. This method is not concurrency-safe.|  
|[concurrent_queue::unsafe_size Method](#concurrent_queue__unsafe_size_method)|Returns the number of items in the queue. This method is not concurrency-safe.|  
  
## Remarks  
 For more information, see                 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concurrent_queue.h  
  
 **Namespace:** concurrency  
  
##  \<a name="concurrent_queue__clear_method">\</a>  concurrent_queue::clear Method  
 Clears the concurrent queue, destroying any currently enqueued elements. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="concurrent_queue__concurrent_queue_constructor">\</a>  concurrent_queue::concurrent_queue Constructor  
 Constructs a concurrent queue.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The type of the input iterator that specifies a range of values.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The allocator class to use with this object.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The source                                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object to copy or move elements from.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Position of the first element beyond the range of elements to be copied.  
  
### Remarks  
 All constructors store an allocator object                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and initialize the queue.  
  
 The first constructor specifies an empty initial queue and explicitly specifies the allocator type to be used.  
  
 The second constructor specifies a copy of the concurrent queue                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 The third constructor specifies a move of the concurrent queue                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 The fourth constructor specifies values supplied by the iterator range [                        <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>).  
  
##  \<a name="concurrent_queue___dtorconcurrent_queue_destructor">\</a>  concurrent_queue::~concurrent_queue Destructor  
 Destroys the concurrent queue.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="concurrent_queue__empty_method">\</a>  concurrent_queue::empty Method  
 Tests if the concurrent queue is empty at the moment this method is called. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> if the concurrent queue was empty at the moment we looked,                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 While this method is concurrency-safe with respect to calls to the methods                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, and                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, the value returned might be incorrect by the time it is inspected by the calling thread.  
  
##  \<a name="concurrent_queue__get_allocator_method">\</a>  concurrent_queue::get_allocator Method  
 Returns a copy of the allocator used to construct the concurrent queue. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A copy of the allocator used to construct the concurrent queue.  
  
##  \<a name="concurrent_queue__push_method">\</a>  concurrent_queue::push Method  
 Enqueues an item at tail end of the concurrent queue. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The item to be added to the queue.  
  
### Remarks  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is concurrency-safe with respect to calls to the methods                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, and                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
##  \<a name="concurrent_queue__try_pop_method">\</a>  concurrent_queue::try_pop Method  
 Dequeues an item from the queue if one is available. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A reference to a location to store the dequeued item.  
  
### Return Value  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> if an item was successfully dequeued,                        <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 If an item was successfully dequeued, the parameter                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> receives the dequeued value, the original value held in the queue is destroyed, and this function returns                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. If there was no item to dequeue, this function returns                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> without blocking, and the contents of the                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> parameter are undefined.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is concurrency-safe with respect to calls to the methods                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, and                         <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
##  \<a name="concurrent_queue__unsafe_begin_method">\</a>  concurrent_queue::unsafe_begin Method  
 Returns an iterator of type                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> to the beginning of the concurrent queue. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 An iterator of type                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> to the beginning of the concurrent queue object.  
  
### Remarks  
 The iterators for the                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> class are primarily intended for debugging, as they are slow, and iteration is not concurrency-safe with respect to other queue operations.  
  
##  \<a name="concurrent_queue__unsafe_end_method">\</a>  concurrent_queue::unsafe_end Method  
 Returns an iterator of type                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to the end of the concurrent queue. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 An iterator of type                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> to the end of the concurrent queue.  
  
### Remarks  
 The iterators for the                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> class are primarily intended for debugging, as they are slow, and iteration is not concurrency-safe with respect to other queue operations.  
  
##  \<a name="concurrent_queue__unsafe_size_method">\</a>  concurrent_queue::unsafe_size Method  
 Returns the number of items in the queue. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The size of the concurrent queue.  
  
### Remarks  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> is not concurrency-safe and can produce incorrect results if called concurrently with calls to the methods                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, and                         <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)