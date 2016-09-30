---
title: "concurrent_unordered_set Class"
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
  - "concurrent_unordered_set/concurrency::concurrent_unordered_set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_unordered_set class"
ms.assetid: c61f9a9a-4fd9-491a-9251-e300737ecf4b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_set Class
The             <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class is an concurrency-safe container that controls a varying-length sequence of elements of type _Key_type. The sequence is represented in a way that enables concurrency-safe append, element access, iterator access and iterator traversal operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The key type.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The hash function object type. This argument is optional and the default value is                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The equality comparison function object type. This argument is optional and the default value is                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the allocation and deallocation of memory for the concurrent unordered set. This argument is optional and the default value is                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|The type of an allocator for managing storage.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|The type of a constant iterator for the controlled sequence.|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|The type of a constant bucket iterator for the controlled sequence.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|The type of a constant pointer to an element.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|The type of a constant reference to an element.|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|The type of a signed distance between two elements.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|The type of the hash function.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|The type of an iterator for the controlled sequence.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|The type of the comparison function.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|The type of an ordering key.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|The type of a bucket iterator for the controlled sequence.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|The type of a pointer to an element.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|The type of a reference to an element.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|The type of an unsigned distance between two elements.|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|The type of an element.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_unordered_set::concurrent_unordered_set Constructor](#concurrent_unordered_set__concurrent_unordered_set_constructor)|Overloaded. Constructs a concurrent unordered set.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_unordered_set::hash_function Method](#concurrent_unordered_set__hash_function_method)|Returns the stored hash function object.|  
|[concurrent_unordered_set::insert Method](#concurrent_unordered_set__insert_method)|Overloaded. Adds elements to the                                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.|  
|[concurrent_unordered_set::key_eq Method](#concurrent_unordered_set__key_eq_method)|Returns the stored equality comparison function object.|  
|[concurrent_unordered_set::swap Method](#concurrent_unordered_set__swap_method)|Swaps the contents of two                                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> objects. This method is not concurrency-safe.|  
|[concurrent_unordered_set::unsafe_erase Method](#concurrent_unordered_set__unsafe_erase_method)|Overloaded. Removes elements from the                                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> at specified positions. This method is not concurrency-safe.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_unordered_set::operator= Operator](#concurrent_unordered_set__operator_eq_operator)|Overloaded. Assigns the contents of another                                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object to this one. This method is not concurrency-safe.|  
  
## Remarks  
 For detailed information on the                 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> class, see                 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concurrent_unordered_set.h  
  
 **Namespace:** concurrency  
  
##  \<a name="concurrent_unordered_set__begin_method">\</a>  concurrent_unordered_set::begin Method  
 Returns an iterator pointing to the first element in the concurrent container. This method is concurrency safe.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 An iterator to the first element in the concurrent container.  
  
##  \<a name="concurrent_unordered_set__cbegin_method">\</a>  concurrent_unordered_set::cbegin Method  
 Returns a const iterator pointing to the first element in the concurrent container. This method is concurrency safe.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A const iterator to the first element in the concurrent container.  
  
##  \<a name="concurrent_unordered_set__cend_method">\</a>  concurrent_unordered_set::cend Method  
 Returns a const iterator pointing to the location succeeding the last element in the concurrent container. This method is concurrency safe.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A const iterator to the location succeeding the last element in the concurrent container.  
  
##  \<a name="concurrent_unordered_set__clear_method">\</a>  concurrent_unordered_set::clear Method  
 Erases all the elements in the concurrent container. This function is not concurrency safe.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="concurrent_unordered_set__concurrent_unordered_set_constructor">\</a>  concurrent_unordered_set::concurrent_unordered_set Constructor  
 Constructs a concurrent unordered set.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The type of the input iterator.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The initial number of buckets for this unordered set.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The hash function for this unordered set.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The equality comparison function for this unordered set.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The allocator for this unordered set.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The source                                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object to copy or move elements from.  
  
### Remarks  
 All constructors store an allocator object                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> and initialize the unordered set.  
  
 The first constructor specifies an empty initial set and explicitly specifies the number of buckets, hash function, equality function and allocator type to be used.  
  
 The second constructor specifies an allocator for the unordered set.  
  
 The third constructor specifies values supplied by the iterator range [                        <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>).  
  
 The fourth and fifth constructors specify a copy of the concurrent unordered set                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
 The last constructor specifies a move of the concurrent unordered set                         <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.  
  
##  \<a name="concurrent_unordered_set__count_method">\</a>  concurrent_unordered_set::count Method  
 Counts the number of elements matching a specified key. This function is concurrency safe.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The key to search for.  
  
### Return Value  
 The number of times number of times the key appears in the container.  
  
##  \<a name="concurrent_unordered_set__empty_method">\</a>  concurrent_unordered_set::empty Method  
 Tests whether no elements are present. This method is concurrency safe.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> if the concurrent container is empty,                         <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 In the presence of concurrent inserts, whether or not the concurrent container is empty may change immediately after calling this function, before the return value is even read.  
  
##  \<a name="concurrent_unordered_set__end_method">\</a>  concurrent_unordered_set::end Method  
 Returns an iterator pointing to the location succeeding the last element in the concurrent container. This method is concurrency safe.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 An iterator to the location succeeding the last element in the concurrent container.  
  
##  \<a name="concurrent_unordered_set__equal_range_method">\</a>  concurrent_unordered_set::equal_range Method  
 Finds a range that matches a specified key. This function is concurrency safe.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The key value to search for.  
  
### Return Value  
 A                         [pair](assetId:///32e72d66-3020-4cb9-92c3-f7a5fa7998ff) where the first element is an iterator to the beginning and the second element is an iterator to the end of the range.  
  
### Remarks  
 It is possible for concurrent inserts to cause additional keys to be inserted after the begin iterator and before the end iterator.  
  
##  \<a name="concurrent_unordered_set__find_method">\</a>  concurrent_unordered_set::find Method  
 Finds an element that matches a specified key. This function is concurrency safe.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The key value to search for.  
  
### Return Value  
 An iterator pointing to the location of the the first element that matched the key provided, or the iterator                         <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> if no such element exists.  
  
##  \<a name="concurrent_unordered_set__get_allocator_method">\</a>  concurrent_unordered_set::get_allocator Method  
 Returns the stored allocator object for this concurrent container. This method is concurrency safe.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The stored allocator object for this concurrent container.  
  
##  \<a name="concurrent_unordered_set__hash_function_method">\</a>  concurrent_unordered_set::hash_function Method  
 Returns the stored hash function object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The stored hash function object.  
  
##  \<a name="concurrent_unordered_set__insert_method">\</a>  concurrent_unordered_set::insert Method  
 Adds elements to the                 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 The iterator type used for insertion.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The type of the value inserted into the set.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The value to be inserted.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The starting location to search for an insertion point.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The beginning of the range to insert.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The end of the range to insert.  
  
### Return Value  
 A pair that contains an iterator and a boolean value. See the Remarks section for more details.  
  
### Remarks  
 The first member function determines whether an element X exists in the sequence whose key has equivalent ordering to that of                         <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>. If not, it creates such an element X and initializes it with                         <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>. The function then determines the iterator                         <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> that designates X. If an insertion occurred, the function returns                         <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>. Otherwise, it returns                         <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
 The second member function returns insert(                        <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>), using                         <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> as a starting place within the controlled sequence to search for the insertion point.  
  
 The third member function inserts the sequence of element values from the range [                        <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>).  
  
 The last two member functions behave the same as the first two, except that                         <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is used to construct the inserted value.  
  
##  \<a name="concurrent_unordered_set__key_eq_method">\</a>  concurrent_unordered_set::key_eq Method  
 Returns the stored equality comparison function object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The stored equality comparison function object.  
  
##  \<a name="concurrent_unordered_set__load_factor_method">\</a>  concurrent_unordered_set::load_factor Method  
 Computes and returns the current load factor of the container. The load factor is the number of elements in the container divided by the number of buckets.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 The load factor for the container.  
  
##  \<a name="concurrent_unordered_set__max_load_factor_method">\</a>  concurrent_unordered_set::max_load_factor Method  
 Gets or sets the maximum load factor of the container. The maximum load factor is the largest number of elements than can be in any bucket before the container grows its internal table.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
  
### Return Value  
 The first member function returns the stored maximum load factor. The second member function does not return a value but throws an                         [out_of_range](../vs140/out_of_range-class.md) exception if the supplied load factor is invalid..  
  
##  \<a name="concurrent_unordered_set__max_size_method">\</a>  concurrent_unordered_set::max_size Method  
 Returns the maximum size of the concurrent container, determined by the allocator. This method is concurrency safe.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 The maximum number of elements that can be inserted into this concurrent container.  
  
### Remarks  
 This upper bound value may actually be higher than what the container can actually hold.  
  
##  \<a name="concurrent_unordered_set__operator_eq_operator">\</a>  concurrent_unordered_set::operator= Operator  
 Assigns the contents of another                 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object to this one. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 The source                                 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A reference to this                         <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object.  
  
### Remarks  
 After erasing any existing elements in a concurrent unordered set,                         <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> either copies or moves the contents of                         <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> into the concurrent unordered set.  
  
##  \<a name="concurrent_unordered_set__rehash_method">\</a>  concurrent_unordered_set::rehash Method  
 Rebuilds the hash table.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 The desired number of buckets.  
  
### Remarks  
 The member function alters the number of buckets to be at least                         <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> and rebuilds the hash table as needed. The number of buckets must be a power of 2. If not a power of 2, it will be rounded up to the next largest power of 2.  
  
 It throws an                         [out_of_range](../vs140/out_of_range-class.md) exception if the number of buckets is invalid (either 0 or greater than the maximum number of buckets).  
  
##  \<a name="concurrent_unordered_set__size_method">\</a>  concurrent_unordered_set::size Method  
 Returns the number of elements in this concurrent container. This method is concurrency safe.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the container.  
  
### Remarks  
 In the presence of concurrent inserts, the number of elements in the concurrent container may change immediately after calling this function, before the return value is even read.  
  
##  \<a name="concurrent_unordered_set__swap_method">\</a>  concurrent_unordered_set::swap Method  
 Swaps the contents of two                 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> objects. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> object to swap with.  
  
##  \<a name="concurrent_unordered_set__unsafe_begin_method">\</a>  concurrent_unordered_set::unsafe_begin Method  
 Returns an iterator to the first element in this container for a specific bucket.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 The bucket index.  
  
### Return Value  
 An iterator pointing to the beginning of the bucket.  
  
##  \<a name="concurrent_unordered_set__unsafe_bucket_method">\</a>  concurrent_unordered_set::unsafe_bucket Method  
 Returns the bucket index that a specific key maps to in this container.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The element key being searched for.  
  
### Return Value  
 The bucket index for the key in this container.  
  
##  \<a name="concurrent_unordered_set__unsafe_bucket_count_method">\</a>  concurrent_unordered_set::unsafe_bucket_count Method  
 Returns the current number of buckets in this container.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 The current number of buckets in this container.  
  
##  \<a name="concurrent_unordered_set__unsafe_bucket_size_method">\</a>  concurrent_unordered_set::unsafe_bucket_size Method  
 Returns the number of items in a specific bucket of this container.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 The bucket to search for.  
  
### Return Value  
 The current number of buckets in this container.  
  
##  \<a name="concurrent_unordered_set__unsafe_cbegin_method">\</a>  concurrent_unordered_set::unsafe_cbegin Method  
 Returns an iterator to the first element in this container for a specific bucket.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 The bucket index.  
  
### Return Value  
 An iterator pointing to the beginning of the bucket.  
  
##  \<a name="concurrent_unordered_set__unsafe_cend_method">\</a>  concurrent_unordered_set::unsafe_cend Method  
 Returns an iterator to the location succeeding the last element in a specific bucket.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 The bucket index.  
  
### Return Value  
 An iterator pointing to the beginning of the bucket.  
  
##  \<a name="concurrent_unordered_set__unsafe_end_method">\</a>  concurrent_unordered_set::unsafe_end Method  
 Returns an iterator to the last element in this container for a specific bucket.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 The bucket index.  
  
### Return Value  
 An iterator pointing to the end of the bucket.  
  
##  \<a name="concurrent_unordered_set__unsafe_erase_method">\</a>  concurrent_unordered_set::unsafe_erase Method  
 Removes elements from the                 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> at specified positions. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The iterator position to erase from.  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The key value to erase.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  
### Return Value  
 The first two member functions return an iterator that designates the first element remaining beyond any elements removed, or                         [concurrent_unordered_set::end Method](#concurrent_unordered_set__end_method)() if no such element exists. The third member function returns the number of elements it removes.  
  
### Remarks  
 The first member function removes the element pointed to by                         <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>. The second member function removes the elements in the range [                        <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>).  
  
 The third member function removes the elements in the range delimited by                         [concurrent_unordered_set::equal_range Method](#concurrent_unordered_set__equal_range_method)(_Keyval).  
  
##  \<a name="concurrent_unordered_set__unsafe_max_bucket_count_method">\</a>  concurrent_unordered_set::unsafe_max_bucket_count Method  
 Returns the maximum number of buckets in this container.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 The maximum number of buckets in this container.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md)