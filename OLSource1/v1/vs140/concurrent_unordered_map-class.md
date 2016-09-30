---
title: "concurrent_unordered_map Class"
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
  - "concurrent_unordered_map/concurrency::concurrent_unordered_map"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_unordered_map class"
ms.assetid: b2d879dd-87ef-4af9-a266-a5443fd538b8
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map Class
The             <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> class is a concurrency-safe container that controls a varying-length sequence of elements of type             <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. The sequence is represented in a way that enables concurrency-safe append, element access, iterator access, and iterator traversal operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The key type.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The mapped type.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The hash function object type. This argument is optional and the default value is                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The equality comparison function object type. This argument is optional and the default value is                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the allocation and deallocation of memory for the concurrent unordered map. This argument is optional and the default value is                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|The type of an allocator for managing storage.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|The type of a constant iterator for the controlled sequence.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|The type of a constant bucket iterator for the controlled sequence.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|The type of a constant pointer to an element.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|The type of a constant reference to an element.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|The type of a signed distance between two elements.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|The type of the hash function.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|The type of an iterator for the controlled sequence.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|The type of the comparison function.|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|The type of an ordering key.|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|The type of a bucket iterator for the controlled sequence.|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|The type of a mapped value associated with each key.|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|The type of a pointer to an element.|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|The type of a reference to an element.|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|The type of an unsigned distance between two elements.|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|The type of an element.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_unordered_map::concurrent_unordered_map Constructor](#concurrent_unordered_map__concurrent_unordered_map_constructor)|Overloaded. Constructs a concurrent unordered map.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_unordered_map::at Method](#concurrent_unordered_map__at_method)|Overloaded. Finds an element in a                                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> with a specified key value.. This method is concurrency-safe.|  
|[concurrent_unordered_map::hash_function Method](#concurrent_unordered_map__hash_function_method)|Gets the stored hash function object.|  
|[concurrent_unordered_map::insert Method](#concurrent_unordered_map__insert_method)|Overloaded. Adds elements to the                                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.|  
|[concurrent_unordered_map::key_eq Method](#concurrent_unordered_map__key_eq_method)|Gets the stored equality comparison function object.|  
|[concurrent_unordered_map::swap Method](#concurrent_unordered_map__swap_method)|Swaps the contents of two                                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> objects. This method is not concurrency-safe.|  
|[concurrent_unordered_map::unsafe_erase Method](#concurrent_unordered_map__unsafe_erase_method)|Overloaded. Removes elements from the                                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> at specified positions. This method is not concurrency-safe.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_unordered_map::operator&#91;&#93; Operator](#concurrent_unordered_map__operator_at_operator)|Overloaded. Finds or inserts an element with the specified key. This method is concurrency-safe.|  
|[concurrent_unordered_map::operator= Operator](#concurrent_unordered_map__operator_eq_operator)|Overloaded. Assigns the contents of another                                         <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object to this one. This method is not concurrency-safe.|  
  
## Remarks  
 For detailed information on the                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> class, see                 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
##  \<a name="concurrent_unordered_map__at_method">\</a>  concurrent_unordered_map::at Method  
 Finds an element in a                 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> with a specified key value.. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The key value to find.  
  
### Return Value  
 A reference to the data value of the element found.  
  
### Remarks  
 If the argument key value is not found, the function throws an object of class                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
##  \<a name="concurrent_unordered_map__begin_method">\</a>  concurrent_unordered_map::begin Method  
 Returns an iterator pointing to the first element in the concurrent container. This method is concurrency safe.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An iterator to the first element in the concurrent container.  
  
##  \<a name="concurrent_unordered_map__cbegin_method">\</a>  concurrent_unordered_map::cbegin Method  
 Returns a const iterator pointing to the first element in the concurrent container. This method is concurrency safe.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A const iterator to the first element in the concurrent container.  
  
##  \<a name="concurrent_unordered_map__cend_method">\</a>  concurrent_unordered_map::cend Method  
 Returns a const iterator pointing to the location succeeding the last element in the concurrent container. This method is concurrency safe.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A const iterator to the location succeeding the last element in the concurrent container.  
  
##  \<a name="concurrent_unordered_map__clear_method">\</a>  concurrent_unordered_map::clear Method  
 Erases all the elements in the concurrent container. This function is not concurrency safe.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="concurrent_unordered_map__concurrent_unordered_map_constructor">\</a>  concurrent_unordered_map::concurrent_unordered_map Constructor  
 Constructs a concurrent unordered map.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The type of the input iterator.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The initial number of buckets for this unordered map.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The hash function for this unordered map.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The equality comparison function for this unordered map.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The allocator for this unordered map.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The position of the first element beyond the range of elements to be copied.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The source                                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object to copy or move elements from.  
  
### Remarks  
 All constructors store an allocator object                         <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> and initialize the unordered map.  
  
 The first constructor specifies an empty initial map and explicitly specifies the number of buckets, hash function, equality function and allocator type to be used.  
  
 The second constructor specifies an allocator for the unordered map.  
  
 The third constructor specifies values supplied by the iterator range [                        <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>).  
  
 The fourth and fifth constructors specify a copy of the concurrent unordered map                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
 The last constructor specifies a move of the concurrent unordered map                         <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
##  \<a name="concurrent_unordered_map__count_method">\</a>  concurrent_unordered_map::count Method  
 Counts the number of elements matching a specified key. This function is concurrency safe.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The key to search for.  
  
### Return Value  
 The number of times number of times the key appears in the container.  
  
##  \<a name="concurrent_unordered_map__empty_method">\</a>  concurrent_unordered_map::empty Method  
 Tests whether no elements are present. This method is concurrency safe.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> if the concurrent container is empty,                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 In the presence of concurrent inserts, whether or not the concurrent container is empty may change immediately after calling this function, before the return value is even read.  
  
##  \<a name="concurrent_unordered_map__end_method">\</a>  concurrent_unordered_map::end Method  
 Returns an iterator pointing to the location succeeding the last element in the concurrent container. This method is concurrency safe.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 An iterator to the location succeeding the last element in the concurrent container.  
  
##  \<a name="concurrent_unordered_map__equal_range_method">\</a>  concurrent_unordered_map::equal_range Method  
 Finds a range that matches a specified key. This function is concurrency safe.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The key value to search for.  
  
### Return Value  
 A                         [pair](assetId:///c5a37023-d939-4eb2-ae24-ce8e0cd4505d) where the first element is an iterator to the beginning and the second element is an iterator to the end of the range.  
  
### Remarks  
 It is possible for concurrent inserts to cause additional keys to be inserted after the begin iterator and before the end iterator.  
  
##  \<a name="concurrent_unordered_map__find_method">\</a>  concurrent_unordered_map::find Method  
 Finds an element that matches a specified key. This function is concurrency safe.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The key value to search for.  
  
### Return Value  
 An iterator pointing to the location of the the first element that matched the key provided, or the iterator                         <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> if no such element exists.  
  
##  \<a name="concurrent_unordered_map__get_allocator_method">\</a>  concurrent_unordered_map::get_allocator Method  
 Returns the stored allocator object for this concurrent container. This method is concurrency safe.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The stored allocator object for this concurrent container.  
  
##  \<a name="concurrent_unordered_map__hash_function_method">\</a>  concurrent_unordered_map::hash_function Method  
 Gets the stored hash function object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The stored hash function object.  
  
##  \<a name="concurrent_unordered_map__insert_method">\</a>  concurrent_unordered_map::insert Method  
 Adds elements to the                 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The iterator type used for insertion.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 The type of the value inserted into the map.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The value to be inserted.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The starting location to search for an insertion point.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The beginning of the range to insert.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The end of the range to insert.  
  
### Return Value  
 A pair that contains an iterator and a boolean value. See the Remarks section for more details.  
  
### Remarks  
 The first member function determines whether an element X exists in the sequence whose key has equivalent ordering to that of                         <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>. If not, it creates such an element X and initializes it with                         <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>. The function then determines the iterator                         <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> that designates X. If an insertion occurred, the function returns                         <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>. Otherwise, it returns                         <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
 The second member function returns insert(                        <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>), using                         <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> as a starting place within the controlled sequence to search for the insertion point.  
  
 The third member function inserts the sequence of element values from the range [                        <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>).  
  
 The last two member functions behave the same as the first two, except that                         <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> is used to construct the inserted value.  
  
##  \<a name="concurrent_unordered_map__key_eq_method">\</a>  concurrent_unordered_map::key_eq Method  
 Gets the stored equality comparison function object.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 The stored equality comparison function object.  
  
##  \<a name="concurrent_unordered_map__load_factor_method">\</a>  concurrent_unordered_map::load_factor Method  
 Computes and returns the current load factor of the container. The load factor is the number of elements in the container divided by the number of buckets.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 The load factor for the container.  
  
##  \<a name="concurrent_unordered_map__max_load_factor_method">\</a>  concurrent_unordered_map::max_load_factor Method  
 Gets or sets the maximum load factor of the container. The maximum load factor is the largest number of elements than can be in any bucket before the container grows its internal table.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
  
### Return Value  
 The first member function returns the stored maximum load factor. The second member function does not return a value but throws an                         [out_of_range](../vs140/out_of_range-class.md) exception if the supplied load factor is invalid..  
  
##  \<a name="concurrent_unordered_map__max_size_method">\</a>  concurrent_unordered_map::max_size Method  
 Returns the maximum size of the concurrent container, determined by the allocator. This method is concurrency safe.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 The maximum number of elements that can be inserted into this concurrent container.  
  
### Remarks  
 This upper bound value may actually be higher than what the container can actually hold.  
  
##  \<a name="concurrent_unordered_map__operator_at_operator">\</a>  concurrent_unordered_map::operator[] Operator  
 Finds or inserts an element with the specified key. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The key value to  
  
 find or insert.  
  
### Return Value  
 A reference to the data value of the found or inserted element.  
  
### Remarks  
 If the argument key value is not found, then it is inserted along with the default value of the data type.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> may be used to insert elements into a map                         <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> using                         <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>, where                         <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> is the value of the                         <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> of the element with a key value of                         <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.  
  
 When using                         <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> to insert elements, the returned reference does not indicate whether an insertion is changing a pre-existing element or creating a new one. The member functions                         <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> and                         [insert](#concurrent_unordered_map__insert_method) can be used to determine whether an element with a specified key is already present before an insertion.  
  
##  \<a name="concurrent_unordered_map__operator_eq_operator">\</a>  concurrent_unordered_map::operator= Operator  
 Assigns the contents of another                 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object to this one. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The source                                 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A reference to this                         <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object.  
  
### Remarks  
 After erasing any existing elements a concurrent vector,                         <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> either copies or moves the contents of                         <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> into the concurrent vector.  
  
##  \<a name="concurrent_unordered_map__rehash_method">\</a>  concurrent_unordered_map::rehash Method  
 Rebuilds the hash table.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 The desired number of buckets.  
  
### Remarks  
 The member function alters the number of buckets to be at least                         <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> and rebuilds the hash table as needed. The number of buckets must be a power of 2. If not a power of 2, it will be rounded up to the next largest power of 2.  
  
 It throws an                         [out_of_range](../vs140/out_of_range-class.md) exception if the number of buckets is invalid (either 0 or greater than the maximum number of buckets).  
  
##  \<a name="concurrent_unordered_map__size_method">\</a>  concurrent_unordered_map::size Method  
 Returns the number of elements in this concurrent container. This method is concurrency safe.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the container.  
  
### Remarks  
 In the presence of concurrent inserts, the number of elements in the concurrent container may change immediately after calling this function, before the return value is even read.  
  
##  \<a name="concurrent_unordered_map__swap_method">\</a>  concurrent_unordered_map::swap Method  
 Swaps the contents of two                 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> objects. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> object to swap with.  
  
##  \<a name="concurrent_unordered_map__unsafe_begin_method">\</a>  concurrent_unordered_map::unsafe_begin Method  
 Returns an iterator to the first element in this container for a specific bucket.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 The bucket index.  
  
### Return Value  
 An iterator pointing to the beginning of the bucket.  
  
##  \<a name="concurrent_unordered_map__unsafe_bucket_method">\</a>  concurrent_unordered_map::unsafe_bucket Method  
 Returns the bucket index that a specific key maps to in this container.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 The element key being searched for.  
  
### Return Value  
 The bucket index for the key in this container.  
  
##  \<a name="concurrent_unordered_map__unsafe_bucket_count_method">\</a>  concurrent_unordered_map::unsafe_bucket_count Method  
 Returns the current number of buckets in this container.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 The current number of buckets in this container.  
  
##  \<a name="concurrent_unordered_map__unsafe_bucket_size_method">\</a>  concurrent_unordered_map::unsafe_bucket_size Method  
 Returns the number of items in a specific bucket of this container.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 The bucket to search for.  
  
### Return Value  
 The current number of buckets in this container.  
  
##  \<a name="concurrent_unordered_map__unsafe_cbegin_method">\</a>  concurrent_unordered_map::unsafe_cbegin Method  
 Returns an iterator to the first element in this container for a specific bucket.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The bucket index.  
  
### Return Value  
 An iterator pointing to the beginning of the bucket.  
  
##  \<a name="concurrent_unordered_map__unsafe_cend_method">\</a>  concurrent_unordered_map::unsafe_cend Method  
 Returns an iterator to the location succeeding the last element in a specific bucket.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The bucket index.  
  
### Return Value  
 An iterator pointing to the beginning of the bucket.  
  
##  \<a name="concurrent_unordered_map__unsafe_end_method">\</a>  concurrent_unordered_map::unsafe_end Method  
 Returns an iterator to the last element in this container for a specific bucket.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 The bucket index.  
  
### Return Value  
 An iterator pointing to the end of the bucket.  
  
##  \<a name="concurrent_unordered_map__unsafe_erase_method">\</a>  concurrent_unordered_map::unsafe_erase Method  
 Removes elements from the                 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> at specified positions. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The iterator position to erase from.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 The position of the first element in the range of elements to be erased.  
  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 The position of the first element beyond the range of elements to be erased.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The key value to erase.  
  
### Return Value  
 The first two member functions return an iterator that designates the first element remaining beyond any elements removed, or                         <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>() if no such element exists. The third member function returns the number of elements it removes.  
  
### Remarks  
 The first member function removes the element of the controlled sequence pointed to by                         <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>. The second member function removes the elements in the range [                        <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>).  
  
 The third member function removes the elements in the range delimited by                         <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>(_Keyval).  
  
##  \<a name="concurrent_unordered_map__unsafe_max_bucket_count_method">\</a>  concurrent_unordered_map::unsafe_max_bucket_count Method  
 Returns the maximum number of buckets in this container.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 The maximum number of buckets in this container.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md)