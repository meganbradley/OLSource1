---
title: "Parallel Containers and Objects"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parallel objects"
  - "parallel containers"
  - "concurrent containers"
ms.assetid: 90ab715c-29cd-48eb-8e76-528619aab466
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parallel Containers and Objects
The Parallel Patterns Library (PPL) includes several containers and objects that provide thread-safe access to their elements.  
  
 A *concurrent container* provides concurrency-safe access to the most important operations. The functionality of these containers resembles those that are provided by the Standard Template Library (STL). For example, the [concurrency::concurrent_vector](../vs140/concurrent_vector-class.md) class resembles the [std::vector](../vs140/vector-class.md) class, except that the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class lets you append elements in parallel. Use concurrent containers when you have parallel code that requires both read and write access to the same container.  
  
 A *concurrent object* is shared concurrently among components. A process that computes the state of a concurrent object in parallel produces the same result as another process that computes the same state serially. The [concurrency::combinable](../vs140/combinable-class.md) class is one example of a concurrent object type. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class lets you perform computations in parallel, and then combine those computations into a final result. Use concurrent objects when you would otherwise use a synchronization mechanism, for example, a mutex, to synchronize access to a shared variable or resource.  
  
##  \<a name="top">\</a> Sections  
 This topic describes the following parallel containers and objects in detail.  
  
 Concurrent containers:  
  
-   [concurrent_vector Class](#vector)  
  
    -   [Differences Between concurrent_vector and vector](#vector-differences)  
  
    -   [Concurrency-Safe Operations](#vector-safety)  
  
    -   [Exception Safety](#vector-exceptions)  
  
-   [concurrent_queue Class](#queue)  
  
    -   [Differences Between concurrent_queue and queue](#queue-differences)  
  
    -   [Concurrency-Safe Operations](#queue-safety)  
  
    -   [Iterator Support](#queue-iterators)  
  
-   [concurrent_unordered_map Class](#unordered_map)  
  
    -   [Differences Between concurrent_unordered_map and unordered_map](#map-differences)  
  
    -   [Concurrency-Safe Operations](#map-safety)  
  
-   [concurrent_unordered_multimap Class](#unordered_multimap)  
  
-   [concurrent_unordered_set Class](#unordered_set)  
  
-   [concurrent_unordered_multiset Class](#unordered_multiset)  
  
 Concurrent objects:  
  
-   [combinable Class](#combinable)  
  
    -   [Methods and Features](#combinable-features)  
  
    -   [Examples](#combinable-examples)  
  
##  \<a name="vector">\</a> concurrent_vector Class  
 The [concurrency::concurrent_vector](../vs140/concurrent_vector-class.md) class is a sequence container class that, just like the [std::vector](../vs140/vector-class.md) class, lets you randomly access its elements. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class enables concurrency-safe append and element access operations. Append operations do not invalidate existing pointers or iterators. Iterator access and traversal operations are also concurrency-safe.  
  
###  \<a name="vector-differences">\</a> Differences Between concurrent_vector and vector  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class closely resembles the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class. The complexity of append, element access, and iterator access operations on a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object are the same as for a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. The following points illustrate where <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> differs from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>:  
  
-   Append, element access, iterator access, and iterator traversal operations on a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object are concurrency-safe.  
  
-   You can add elements only to the end of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class does not provide the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method.  
  
-   A <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object does not use [move semantics](../vs140/rvalue-reference-declarator----.md) when you append to it.  
  
-   The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class does not provide the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> methods. As with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, use the [clear](../vs140/concurrent_vector--clear-method.md) method to remove all elements from a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
-   The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class does not store its elements contiguously in memory. Therefore, you cannot use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class in all the ways that you can use an array. For example, for a variable named <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the expression <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> produces undefined behavior.  
  
-   The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class defines the [grow_by](../vs140/concurrent_vector--grow_by-method.md) and [grow_to_at_least](../vs140/concurrent_vector--grow_to_at_least-method.md) methods. These methods resemble the [resize](../vs140/concurrent_vector--resize-method.md) method, except that they are concurrency-safe.  
  
-   A <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object does not relocate its elements when you append to it or resize it. This enables existing pointers and iterators to remain valid during concurrent operations.  
  
-   The runtime does not define a specialized version of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> for type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
###  \<a name="vector-safety">\</a> Concurrency-Safe Operations  
 All methods that append to or increase the size of a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object, or access an element in a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object, are concurrency-safe. The exception to this rule is the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> method.  
  
 The following table shows the common <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> methods and operators that are concurrency-safe.  
  
||||  
|-|-|-|  
|[at](../vs140/concurrent_vector--at-method.md)|[end](../vs140/concurrent_vector--end-method.md)|[operator&#91;&#93;](../vs140/concurrent_vector--operatoroperator.md)|  
|[begin](../vs140/concurrent_vector--begin-method.md)|[front](../vs140/concurrent_vector--front-method.md)|[push_back](../vs140/concurrent_vector--push_back-method.md)|  
|[back](../vs140/concurrent_vector--back-method.md)|[grow_by](../vs140/concurrent_vector--grow_by-method.md)|[rbegin](../vs140/concurrent_vector--rbegin-method.md)|  
|[capacity](../vs140/concurrent_vector--capacity-method.md)|[grow_to_at_least](../vs140/concurrent_vector--grow_to_at_least-method.md)|[rend](../vs140/concurrent_vector--rend-method.md)|  
|[empty](../vs140/concurrent_vector--empty-method.md)|[max_size](../vs140/concurrent_vector--max_size-method.md)|[size](../vs140/concurrent_vector--size-method.md)|  
  
 Operations that the runtime provides for compatibility with the STL, for example, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, are not concurrency-safe. The following table shows the common methods and operators that are not concurrency-safe.  
  
|||  
|-|-|  
|[assign](../vs140/concurrent_vector--assign-method.md)|[reserve](../vs140/concurrent_vector--reserve-method.md)|  
|[clear](../vs140/concurrent_vector--clear-method.md)|[resize](../vs140/concurrent_vector--resize-method.md)|  
|[operator=](../vs140/concurrent_vector--operator=-operator.md)|[shrink_to_fit](../vs140/concurrent_vector--shrink_to_fit-method.md)|  
  
 Operations that modify the value of existing elements are not concurrency-safe. Use a synchronization object such as a [reader_writer_lock](../vs140/reader_writer_lock-class.md) object to synchronize concurrent read and write operations to the same data element. For more information about synchronization objects, see [Synchronization Data Structures](../vs140/synchronization-data-structures.md).  
  
 When you convert existing code that uses <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to use <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, concurrent operations can cause the behavior of your application to change. For example, consider the following program that concurrently performs two tasks on a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object. The first task appends additional elements to a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object. The second task computes the sum of all elements in the same object.  
  
 [!code[concrt-vector-safety#1](../vs140/codesnippet/CPP/parallel-containers-and-objects_1.cpp)]  
  
 Although the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method is concurrency-safe, a concurrent call to the [push_back](../vs140/concurrent_vector--push_back-method.md) method causes the value that is returned by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to change. The number of elements that the iterator traverses is indeterminate. Therefore, this program can produce a different result each time that you run it.  
  
###  \<a name="vector-exceptions">\</a> Exception Safety  
 If a growth or assignment operation throws an exception, the state of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object becomes invalid. The behavior of a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object that is in an invalid state is undefined unless stated otherwise. However, the destructor always frees the memory that the object allocates, even if the object is in an invalid state.  
  
 The data type of the vector elements, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, must meet the following requirements. Otherwise, the behavior of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> class is undefined.  
  
-   The destructor must not throw.  
  
-   If the default or copy constructor throws, the destructor must not be declared by using the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> keyword and it must work correctly with zero-initialized memory.  
  
 [[Top](#top)]  
  
##  \<a name="queue">\</a> concurrent_queue Class  
 The [concurrency::concurrent_queue](../vs140/concurrent_queue-class.md) class, just like the [std::queue](../vs140/queue-class.md) class, lets you access its front and back elements. The <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> class enables concurrency-safe enqueue and dequeue operations. The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> class also provides iterator support that is not concurrency-safe.  
  
###  \<a name="queue-differences">\</a> Differences Between concurrent_queue and queue  
 The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> class closely resembles the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> class. The following points illustrate where <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> differs from <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>:  
  
-   Enqueue and dequeue operations on a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object are concurrency-safe.  
  
-   The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> class provides iterator support that is not concurrency-safe.  
  
-   The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> class does not provide the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> methods. The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> class replaces these methods by defining the [try_pop](../vs140/concurrent_queue--try_pop-method.md) method.  
  
-   The <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> class does not provide the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> method. Therefore, you cannot reference the end of the queue.  
  
-   The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> class provides the [unsafe_size](../vs140/concurrent_queue--unsafe_size-method.md) method instead of the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> method. The <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> method is not concurrency-safe.  
  
###  \<a name="queue-safety">\</a> Concurrency-Safe Operations  
 All methods that enqueue to or dequeue from a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object are concurrency-safe.  
  
 The following table shows the common <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> methods and operators that are concurrency-safe.  
  
|||  
|-|-|  
|[empty](../vs140/concurrent_queue--empty-method.md)|[push](../vs140/concurrent_queue--push-method.md)|  
|[get_allocator](../vs140/concurrent_queue--get_allocator-method.md)|[try_pop](../vs140/concurrent_queue--try_pop-method.md)|  
  
 Although the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> method is concurrency-safe, a concurrent operation may cause the queue to grow or shrink before the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> method returns.  
  
 The following table shows the common methods and operators that are not concurrency-safe.  
  
|||  
|-|-|  
|[clear](../vs140/concurrent_queue--clear-method.md)|[unsafe_end](../vs140/concurrent_queue--unsafe_end-method.md)|  
|[unsafe_begin](../vs140/concurrent_queue--unsafe_begin-method.md)|[unsafe_size](../vs140/concurrent_queue--unsafe_size-method.md)|  
  
###  \<a name="queue-iterators">\</a> Iterator Support  
 The <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> provides iterators that are not concurrency-safe. We recommend that you use these iterators for debugging only.  
  
 A <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> iterator traverses elements in the forward direction only. The following table shows the operators that each iterator supports.  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator++](assetId:///4cfdd07e-927a-42f8-aaa0-d6881687f413)|Advances to next item in the queue. This operator is overloaded to provide both pre-increment and post-increment semantics.|  
|[operator*](assetId:///a0e671fc-76e6-4fb4-b95c-ced4dd2b2017)|Retrieves a reference to the current item.|  
|[operator->](assetId:///41fa393d-ae1e-4a38-bb4b-19e8df709ca9)|Retrieves a pointer to the current item.|  
  
 [[Top](#top)]  
  
##  \<a name="unordered_map">\</a> concurrent_unordered_map Class  
 The [HYPERLINK "file:///C:\\\Users\\\thompet\\\AppData\\\Local\\\Temp\\\DxEditor\\\DduePreview\\\Default\\\798d7037-df37-4310-858b-6f590bbf6ebf\\\HTM\\\html\\\a217b4ac-af2b-4d41-94eb-09a75ee28622" concurrency::concurrent_unordered_map](../vs140/concurrent_unordered_map-class.md) class is an associative container class that, just like the [std::unordered_map](../vs140/unordered_map-class.md) class, controls a varying-length sequence of elements of type [std::pair\<const Key, Ty>](../vs140/pair-structure.md). Think of an unordered map as a dictionary that you can add a key and value pair to or look up a value by key. This class is useful when you have multiple threads or tasks that have to concurrently access a shared container, insert into it, or update it.  
  
 The following example shows the basic structure for using <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>. This example inserts character keys in the range ['a', 'i']. Because the order of operations is undetermined, the final value for each key is also undetermined. However, it is safe to perform the insertions in parallel.  
  
 [!code[concrt-unordered-map-structure#1](../vs140/codesnippet/CPP/parallel-containers-and-objects_2.cpp)]  
  
 For an example that uses <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> to perform a map and reduce operation in parallel, see [How to: Perform Map and Reduce Operations in Parallel](../vs140/how-to--perform-map-and-reduce-operations-in-parallel.md).  
  
###  \<a name="map-differences">\</a> Differences Between concurrent_unordered_map and unordered_map  
 The <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> class closely resembles the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> class. The following points illustrate where <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> differs from <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>:  
  
-   The <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> methods are named <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, respectively. The <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> naming convention indicates that these methods are not concurrency-safe. For more information about concurrency safety, see [Concurrency-Safe Operations](#map-safety).  
  
-   Insert operations do not invalidate existing pointers or iterators, nor do they change the order of items that already exist in the map. Insert and traverse operations can occur concurrently.  
  
-   <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> supports forward iteration only.  
  
-   Insertion does not invalidate or update the iterators that are returned by <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>. Insertion can append unequal items to the end of the range. The begin iterator points to an equal item.  
  
 To help avoid deadlock, no method of <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> holds a lock when it calls the memory allocator, hash functions, or other user-defined code. Also, you must ensure that the hash function always evaluates equal keys to the same value. The best hash functions distribute keys uniformly across the hash code space.  
  
###  \<a name="map-safety">\</a> Concurrency-Safe Operations  
 The <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> class enables concurrency-safe insert and element-access operations. Insert operations do not invalidate existing pointers or iterators. Iterator access and traversal operations are also concurrency-safe. The following table shows the commonly used <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> methods and operators that are concurrency-safe.  
  
|||||  
|-|-|-|-|  
|[at](../vs140/concurrent_unordered_map--at-method.md)|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|[key_eq](../vs140/concurrent_unordered_map--key_eq-method.md)|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|[operator&#91;&#93;](../vs140/concurrent_unordered_map--operatoroperator.md)|  
|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|[insert](../vs140/concurrent_unordered_map--insert-method.md)|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|  
  
 Although the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> method can be called safely from concurrently running threads, different threads can receive different results if a new value is simultaneously inserted into the container.  
  
 The following table shows the commonly used methods and operators that are not concurrency-safe.  
  
||||  
|-|-|-|  
|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>|[operator=](../vs140/concurrent_unordered_map--operator=-operator.md)|[swap](../vs140/concurrent_unordered_map--swap-method.md)|  
  
 In addition to these methods, any method that begins with <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> is also not concurrency-safe.  
  
 [[Top](#top)]  
  
##  \<a name="unordered_multimap">\</a> concurrent_unordered_multimap Class  
 The [concurrency::concurrent_unordered_multimap](../vs140/concurrent_unordered_multimap-class.md) class closely resembles the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> class except that it allows for multiple values to map to the same key. It also differs from <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> in the following ways:  
  
-   The [concurrent_unordered_multimap::insert](../vs140/concurrent_unordered_multimap--insert-method.md) method returns an iterator instead of <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
-   The <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> class does not provide <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> nor the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> method.  
  
 The following example shows the basic structure for using <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>. This example inserts character keys in the range ['a', 'i']. <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> enables a key to have multiple values.  
  
 [!code[concrt-unordered-multimap-structure#1](../vs140/codesnippet/CPP/parallel-containers-and-objects_3.cpp)]  
  
 [[Top](#top)]  
  
##  \<a name="unordered_set">\</a> concurrent_unordered_set Class  
 The [concurrency::concurrent_unordered_set](../vs140/concurrent_unordered_set-class.md) class closely resembles the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> class except that it manages values instead of key and value pairs. The <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> class does not provide <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> nor the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> method.  
  
 The following example shows the basic structure for using <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>. This example inserts character values in the range ['a', 'i']. It is safe to perform the insertions in parallel.  
  
 [!code[concrt-unordered-set#1](../vs140/codesnippet/CPP/parallel-containers-and-objects_4.cpp)]  
  
 [[Top](#top)]  
  
##  \<a name="unordered_multiset">\</a> concurrent_unordered_multiset Class  
 The [concurrency::concurrent_unordered_multiset](../vs140/concurrent_unordered_multiset-class.md) class closely resembles the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> class except that it allows for duplicate values. It also differs from <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> in the following ways:  
  
-   The [concurrent_unordered_multiset::insert](../vs140/concurrent_unordered_multiset--insert-method.md) method returns an iterator instead of <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
-   The <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> class does not provide <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> nor the <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> method.  
  
 The following example shows the basic structure for using <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>. This example inserts character values in the range ['a', 'i']. <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> enables a value to occur multiple times.  
  
 [!code[concrt-unordered-multiset#1](../vs140/codesnippet/CPP/parallel-containers-and-objects_5.cpp)]  
  
 [[Top](#top)]  
  
##  \<a name="combinable">\</a> combinable Class  
 The [concurrency::combinable](../vs140/combinable-class.md) class provides reusable, thread-local storage that lets you perform fine-grained computations and then merge those computations into a final result. You can think of a <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> object as a reduction variable.  
  
 The <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> class is useful when you have a resource that is shared among several threads or tasks. The <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> class helps you eliminate shared state by providing access to shared resources in a lock-free manner. Therefore, this class provides an alternative to using a synchronization mechanism, for example, a mutex, to synchronize access to shared data from multiple threads.  
  
###  \<a name="combinable-features">\</a> Methods and Features  
 The following table shows some of the important methods of the <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> class. For more information about all the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> class methods, see [combinable Class](../vs140/combinable-class.md).  
  
|Method|Description|  
|------------|-----------------|  
|[local](../vs140/combinable--local-method.md)|Retrieves a reference to the local variable that is associated with the current thread context.|  
|[clear](../vs140/combinable--clear-method.md)|Removes all thread-local variables from the <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> object.|  
|[combine](../vs140/combinable--combine-method.md)\<br />\<br /> [combine_each](../vs140/combinable--combine_each-method.md)|Uses the provided combine function to generate a final value from the set of all thread-local computations.|  
  
 The <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> class is a template class that is parameterized on the final merged result. If you call the default constructor, the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> template parameter type must have a default constructor and a copy constructor. If the <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> template parameter type does not have a default constructor, call the overloaded version of the constructor that takes an initialization function as its parameter.  
  
 You can store additional data in a <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object after you call the [combine](../vs140/combinable--combine-method.md) or [combine_each](../vs140/combinable--combine_each-method.md) methods. You can also call the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> methods multiple times. If no local value in a <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> object changes, the <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> methods produce the same result every time that they are called.  
  
###  \<a name="combinable-examples">\</a> Examples  
 For examples about how to use the <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> class, see the following topics:  
  
-   [How to: Use combinable to Improve Performance](../vs140/how-to--use-combinable-to-improve-performance.md)  
  
-   [How to: Use combinable to Combine Sets](../vs140/how-to--use-combinable-to-combine-sets.md)  
  
 [[Top](#top)]  
  
## Related Topics  
 [How-to: Use Parallel Containers](../vs140/how-to--use-parallel-containers-to-increase-efficiency.md)  
 Shows how to use parallel containers to efficiently store and access data in parallel.  
  
 [How to: Use combinable to Improve Performance](../vs140/how-to--use-combinable-to-improve-performance.md)  
 Shows how to use the <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> class to eliminate shared state, and thereby improve performance.  
  
 [How to: Use combinable to Combine Sets](../vs140/how-to--use-combinable-to-combine-sets.md)  
 Shows how to use a <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> function to merge thread-local sets of data.  
  
 [Parallel Patterns Library (PPL)](../vs140/parallel-patterns-library--ppl-.md)  
 Describes the PPL, which provides an imperative programming model that promotes scalability and ease-of-use for developing concurrent applications.  
  
## Reference  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)  
  
 [concurrent_queue Class](../vs140/concurrent_queue-class.md)  
  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)  
  
 [concurrent_unordered_multimap Class](../vs140/concurrent_unordered_multimap-class.md)  
  
 [concurrent_unordered_set Class](../vs140/concurrent_unordered_set-class.md)  
  
 [concurrent_unordered_multiset Class](../vs140/concurrent_unordered_multiset-class.md)  
  
 [combinable Class](../vs140/combinable-class.md)