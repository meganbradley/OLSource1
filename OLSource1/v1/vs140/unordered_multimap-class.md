---
title: "unordered_multimap Class"
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
  - "unordered_map/std::tr1::unordered_multimap"
  - "tr1.unordered_multimap"
  - "unordered_multimap"
  - "std.tr1.unordered_multimap"
  - "tr1::unordered_multimap"
  - "std::tr1::unordered_multimap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unordered_multimap class [TR1]"
  - "unordered_multimap class"
ms.assetid: 4baead6c-5870-4b85-940f-a47d6b891c27
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap Class
The template class describes an object that controls a varying-length sequence of elements of type <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>. The sequence is weakly ordered by a hash function, which partitions the sequence into an ordered set of subsequences called buckets. Within each bucket a comparison function determines whether any pair of elements has equivalent ordering. Each element stores two objects, a sort key and a value. The sequence is represented in a way that permits lookup, insertion, and removal of an arbitrary element with a number of operations that can be independent of the number of elements in the sequence (constant time), at least when all buckets are of roughly equal length. In the worst case, when all of the elements are in one bucket, the number of operations is proportional to the number of elements in the sequence (linear time). Moreover, inserting an element invalidates no iterators, and removing an element invalidates only those iterators which point at the removed element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|The key type.|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|The mapped type.|  
|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|The hash function object type.|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|The equality comparison function object type.|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|The allocator class.|  
  
## Members  
  
|||  
|-|-|  
|Type Definition|Description|  
|[allocator_type](#unordered_multimap__allocator_type)|The type of an allocator for managing storage.|  
|[const_iterator](#unordered_multimap__const_iterator)|The type of a constant iterator for the controlled sequence.|  
|[const_local_iterator](#unordered_multimap__const_local_iterator)|The type of a constant bucket iterator for the controlled sequence.|  
|[const_pointer](#unordered_multimap__const_pointer)|The type of a constant pointer to an element.|  
|[const_reference](#unordered_multimap__const_reference)|The type of a constant reference to an element.|  
|[difference_type](#unordered_multimap__difference_type)|The type of a signed distance between two elements.|  
|[hasher](#unordered_multimap__hasher)|The type of the hash function.|  
|[iterator](#unordered_multimap__iterator)|The type of an iterator for the controlled sequence.|  
|[key_equal](#unordered_multimap__key_equal)|The type of the comparison function.|  
|[key_type](#unordered_multimap__key_type)|The type of an ordering key.|  
|[local_iterator](#unordered_multimap__local_iterator)|The type of a bucket iterator for the controlled sequence.|  
|[mapped_type](#unordered_multimap__mapped_type)|The type of a mapped value associated with each key.|  
|[pointer](#unordered_multimap__pointer)|The type of a pointer to an element.|  
|[reference](#unordered_multimap__reference)|The type of a reference to an element.|  
|[size_type](#unordered_multimap__size_type)|The type of an unsigned distance between two elements.|  
|[value_type](#unordered_multimap__value_type)|The type of an element.|  
  
|||  
|-|-|  
|Member Function|Description|  
|[begin](#unordered_multimap__begin)|Designates the beginning of the controlled sequence.|  
|[bucket](#unordered_multimap__bucket)|Gets the bucket number for a key value.|  
|[bucket_count](#unordered_multimap__bucket_count)|Gets the number of buckets.|  
|[bucket_size](#unordered_multimap__bucket_size)|Gets the size of a bucket.|  
|[cbegin](#unordered_multimap__cbegin)|Designates the beginning of the controlled sequence.|  
|[cend](#unordered_multimap__cend)|Designates the end of the controlled sequence.|  
|[clear](#unordered_multimap__clear)|Removes all elements.|  
|[count](#unordered_multimap__count)|Finds the number of elements matching a specified key.|  
|[emplace](#unordered_multimap__emplace)|Adds an element constructed in place.|  
|[emplace_hint](#unordered_multimap__emplace_hint)|Adds an element constructed in place, with hint.|  
|[empty](#unordered_multimap__empty)|Tests whether no elements are present.|  
|[end](#unordered_multimap__end)|Designates the end of the controlled sequence.|  
|[equal_range](#unordered_multimap__equal_range)|Finds range that matches a specified key.|  
|[erase](#unordered_multimap__erase)|Removes elements at specified positions.|  
|[find](#unordered_multimap__find)|Finds an element that matches a specified key.|  
|[get_allocator](#unordered_multimap__get_allocator)|Gets the stored allocator object.|  
|[hash_function](#unordered_multimap__hash_function)|Gets the stored hash function object.|  
|[insert](#unordered_multimap__insert)|Adds elements.|  
|[key_eq](#unordered_multimap__key_eq)|Gets the stored comparison function object.|  
|[load_factor](#unordered_multimap__load_factor)|Counts the average elements per bucket.|  
|[max_bucket_count](#unordered_multimap__max_bucket_count)|Gets the maximum number of buckets.|  
|[max_load_factor](#unordered_multimap__max_load_factor)|Gets or sets the maximum elements per bucket.|  
|[max_size](#unordered_multimap__max_size)|Gets the maximum size of the controlled sequence.|  
|[rehash](#unordered_multimap__rehash)|Rebuilds the hash table.|  
|[size](#unordered_multimap__size)|Counts the number of elements.|  
|[swap](#unordered_multimap__swap)|Swaps the contents of two containers.|  
|[unordered_multimap](#unordered_multimap__unordered_multimap)|Constructs a container object.|  
  
|||  
|-|-|  
|Operator|Description|  
|[operator=](#unordered_multimap__operator_eq)|Copies a hash table.|  
  
## Remarks  
 The object orders the sequence it controls by calling two stored objects, a comparison function object of type [key_equal](#unordered_multimap__key_equal) and a hash function object of type [hasher](#unordered_multimap__hasher). You access the first stored object by calling the member function [key_eq](#unordered_multimap__key_eq)<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>; and you access the second stored object by calling the member function [hash_function](#unordered_multimap__hash_function)<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>. Specifically, for all values <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, the call <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> returns true only if the two argument values have equivalent ordering; the call <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> yields a distribution of values of type <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>. Unlike template class [unordered_map](../vs140/unordered_map-class.md), an object of template class <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> does not ensure that <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> is always false for any two elements of the controlled sequence. (Keys need not be unique.)  
  
 The object also stores a maximum load factor, which specifies the maximum desired average number of elements per bucket. If inserting an element causes [load_factor](#unordered_multimap__load_factor)<CodeContentPlaceHolder>101\</CodeContentPlaceHolder> to exceed the maximum load factor, the container increases the number of buckets and rebuilds the hash table as needed.  
  
 The actual order of elements in the controlled sequence depends on the hash function, the comparison function, the order of insertion, the maximum load factor, and the current number of buckets. You cannot in general predict the order of elements in the controlled sequence. You can always be assured, however, that any subset of elements that have equivalent ordering are adjacent in the controlled sequence.  
  
 The object allocates and frees storage for the sequence it controls through a stored allocator object of type [allocator_type](#unordered_multimap__allocator_type). Such an allocator object must have the same external interface as an object of template class <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>. Note that the stored allocator object is not copied when the container object is assigned.  
  
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
##  \<a name="unordered_multimap__allocator_type">\</a>  unordered_multimap::allocator_type  
 The type of an allocator for managing storage.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **al == std::allocator() is true**    
##  \<a name="unordered_multimap__begin">\</a>  unordered_multimap::begin  
 Designates the beginning of the controlled sequence or a bucket.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>|The bucket number.|  
  
### Remarks  
 The first two member functions return a forward iterator that points at the first element of the sequence (or just beyond the end of an empty sequence). The last two member functions return a forward iterator that points at the first element of bucket <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> (or just beyond the end of an empty bucket).  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[c, 3] [b, 2]**  
 **[a, 1]**    
##  \<a name="unordered_multimap__bucket">\</a>  unordered_multimap::bucket  
 Gets the bucket number for a key value.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 The key value to map.  
  
### Remarks  
 The member function returns the bucket number currently corresponding to the key value <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**bucket('a') == 7**  
**bucket_size(7) == 1**    
##  \<a name="unordered_multimap__bucket_count">\</a>  unordered_multimap::bucket_count  
 Gets the number of buckets.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the current number of buckets.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_bucket_count() == 8**  
**max_load_factor() == 4**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_bucket_count() == 8**  
**max_load_factor() == 0.1**  
**bucket_count() == 128**  
**load_factor() == 0.0234375**  
**max_bucket_count() == 128**  
**max_load_factor() == 0.1**    
##  \<a name="unordered_multimap__bucket_size">\</a>  unordered_multimap::bucket_size  
 Gets the size of a bucket  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 The bucket number.  
  
### Remarks  
 The member functions returns the size of bucket number <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**bucket('a') == 7**  
**bucket_size(7) == 1**    
##  \<a name="unordered_multimap__cbegin">\</a>  unordered_multimap::cbegin  
 Returns a <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> forward-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="unordered_multimap__cend">\</a>  unordered_multimap::cend  
 Returns a <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> forward-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="unordered_multimap__clear">\</a>  unordered_multimap::clear  
 Removes all elements.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The member function calls [erase](#unordered_multimap__erase)<CodeContentPlaceHolder>130\</CodeContentPlaceHolder> [begin](#unordered_multimap__begin)<CodeContentPlaceHolder>131\</CodeContentPlaceHolder> [end](#unordered_multimap__end)<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**size == 0**  
**empty() == true**  
 **[e, 5] [d, 4]**  
**size == 2**  
**empty() == false**    
##  \<a name="unordered_multimap__const_iterator">\</a>  unordered_multimap::const_iterator  
 The type of a constant iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant forward iterator for the controlled sequence. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_multimap__const_local_iterator">\</a>  unordered_multimap::const_local_iterator  
 The type of a constant bucket iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant forward iterator for a bucket. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[a, 1]**    
##  \<a name="unordered_multimap__const_pointer">\</a>  unordered_multimap::const_pointer  
 The type of a constant pointer to an element.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant pointer to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_multimap__const_reference">\</a>  unordered_multimap::const_reference  
 The type of a constant reference to an element.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant reference to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_multimap__count">\</a>  unordered_multimap::count  
 Finds the number of elements matching a specified key.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 Key value to search for.  
  
### Remarks  
 The member function returns the number of elements in the range delimited by [equal_range](#unordered_multimap__equal_range)<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**count('A') == 0**  
**count('b') == 1**  
**count('C') == 0**    
##  \<a name="unordered_multimap__difference_type">\</a>  unordered_multimap::difference_type  
 The type of a signed distance between two elements.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in the controlled sequence. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**end()-begin() == 3**  
**begin()-end() == -3**    
##  \<a name="unordered_multimap__emplace">\</a>  unordered_multimap::emplace  
 Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the unordered_multimap.|  
  
### Return Value  
 An iterator to the newly inserted element.  
  
### Remarks  
 No references to container elements are invalidated by this function, but it may invalidate all iterators to the container.  
  
 The [value_type](../vs140/map-class.md#map__value_type) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 For a code example, see [multimap::emplace](../vs140/multimap-class.md#multimap__emplace).  
  
##  \<a name="unordered_multimap__emplace_hint">\</a>  unordered_multimap::emplace_hint  
 Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the unordered.|  
|<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>|A hint regarding the place to start searching for the correct point of insertion.|  
  
### Return Value  
 An iterator to the newly inserted element.  
  
### Remarks  
 No references to container elements are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 The [value_type](../vs140/map-class.md#map__value_type) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 For a code example, see [map::emplace_hint](../vs140/map-class.md#map__emplace_hint).  
  
##  \<a name="unordered_multimap__empty">\</a>  unordered_multimap::empty  
 Tests whether no elements are present.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns true for an empty controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**size == 0**  
**empty() == true**  
 **[e, 5] [d, 4]**  
**size == 2**  
**empty() == false**    
##  \<a name="unordered_multimap__end">\</a>  unordered_multimap::end  
 Designates the end of the controlled sequence.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>|The bucket number.|  
  
### Remarks  
 The first two member functions return a forward iterator that points just beyond the end of the sequence. The last two member functions return a forward iterator that points just beyond the end of bucket <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[a, 1] [b, 2]**  
 **[a, 1]**    
##  \<a name="unordered_multimap__equal_range">\</a>  unordered_multimap::equal_range  
 Finds range that matches a specified key.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 Key value to search for.  
  
### Remarks  
 The member function returns a pair of iterators <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> such that <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> delimits just those elements of the controlled sequence that have equivalent ordering with <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>. If no such elements exist, both iterators are <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**equal_range('x'):**  
**equal_range('b'): [b, 2]**    
##  \<a name="unordered_multimap__erase">\</a>  unordered_multimap::erase  
 Removes an element or a range of elements in a unordered_multimap from specified positions or removes elements that match a specified key.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 Position of the element to be removed.  
  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 Position of the first element to be removed.  
  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 Position just beyond the last element to be removed.  
  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 The key value of the elements to be removed.  
  
### Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the map if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the unordered_multimap.  
  
### Remarks  
 For a code example, see [map::erase](../vs140/map-class.md#map__erase).  
  
##  \<a name="unordered_multimap__find">\</a>  unordered_multimap::find  
 Finds an element that matches a specified key.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 Key value to search for.  
  
### Remarks  
 The member function returns [equal_range](#unordered_multimap__equal_range)<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**find('A') == false**  
**find('b') == true: [b, 2]**    
##  \<a name="unordered_multimap__get_allocator">\</a>  unordered_multimap::get_allocator  
 Gets the stored allocator object.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored allocator object.  
  
### Example  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  **al == std::allocator() is true**    
##  \<a name="unordered_multimap__hash_function">\</a>  unordered_multimap::hash_function  
 Gets the stored hash function object.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored hash function object.  
  
### Example  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  **hfn('a') == 1630279**  
**hfn('b') == 1647086**    
##  \<a name="unordered_multimap__hasher">\</a>  unordered_multimap::hasher  
 The type of the hash function.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  **hfn('a') == 1630279**  
**hfn('b') == 1647086**    
##  \<a name="unordered_multimap__insert">\</a>  unordered_multimap::insert  
 Inserts an element or a range of elements into an unordered_multimap.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>|The value of an element to be inserted into the unordered_multimap.|  
|<CodeContentPlaceHolder>156\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion.|  
|<CodeContentPlaceHolder>157\</CodeContentPlaceHolder>|Template parameter that specifies the argument type that the unordered_multimap can use to construct an element of [value_type](../vs140/map-class.md#map__value_type), and perfect-forwards <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> as an argument.|  
|<CodeContentPlaceHolder>159\</CodeContentPlaceHolder>|The position of the first element to be copied.|  
|<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>|The position just beyond the last element to be copied.|  
|<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map-class.md#map__value_type) objects.|  
|<CodeContentPlaceHolder>162\</CodeContentPlaceHolder>|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
### Return Value  
 The single-element-insert member functions, (1) and (2), return an iterator to the position where the new element was inserted into the unordered_multimap.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the unordered_multimap.  
  
### Remarks  
 No pointers or references are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During the insertion of just one element, if an exception is thrown but does not occur in the container's hash function, the container's state is not modified. If the exception is thrown in the hash function, the result is undefined. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 The [value_type](../vs140/map-class.md#map__value_type) of a container is a typedef that belongs to the container, and for map, <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>. The value of an element is an ordered pair in which the first component is equal to the key value and the second component is equal to the data value of the element.  
  
 The range member function (5) inserts the sequence of element values into an unordered_multimap that corresponds to each element addressed by an iterator in the range <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>; therefore, <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> does not get inserted. The container member function <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> refers to the position just after the last element in the container—for example, the statement <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> inserts all elements of <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the unordered_multimap.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [unordered_multimap::emplace](#unordered_multimap__emplace) and [unordered_multimap::emplace_hint](#unordered_multimap__emplace_hint).  
  
 For a code example, see [multimap::insert](../vs140/multiset-class.md#multiset__insert).  
  
##  \<a name="unordered_multimap__iterator">\</a>  unordered_multimap::iterator  
 The type of an iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a forward iterator for the controlled sequence. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_multimap__key_eq">\</a>  unordered_multimap::key_eq  
 Gets the stored comparison function object.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored comparison function object.  
  
### Example  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  **cmpfn('a', 'a') == true**  
**cmpfn('a', 'b') == false**    
##  \<a name="unordered_multimap__key_equal">\</a>  unordered_multimap::key_equal  
 The type of the comparison function.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  **cmpfn('a', 'a') == true**  
**cmpfn('a', 'b') == false**    
##  \<a name="unordered_multimap__key_type">\</a>  unordered_multimap::key_type  
 The type of an ordering key.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[d, 4] [c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_multimap__load_factor">\</a>  unordered_multimap::load_factor  
 Counts the average elements per bucket.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>[size](#unordered_multimap__size)<CodeContentPlaceHolder>175\</CodeContentPlaceHolder>[bucket_count](#unordered_multimap__bucket_count)<CodeContentPlaceHolder>176\</CodeContentPlaceHolder>, the average number of elements per bucket.  
  
### Example  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
##  \<a name="unordered_multimap__local_iterator">\</a>  unordered_multimap::local_iterator  
 The type of a bucket iterator.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a forward iterator for a bucket. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[a, 1]**    
##  \<a name="unordered_multimap__mapped_type">\</a>  unordered_multimap::mapped_type  
 The type of a mapped value associated with each key.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[d, 4] [c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_multimap__max_bucket_count">\</a>  unordered_multimap::max_bucket_count  
 Gets the maximum number of buckets.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the maximum number of buckets currently permitted.  
  
### Example  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_bucket_count() == 8**  
**max_load_factor() == 4**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_bucket_count() == 8**  
**max_load_factor() == 0.1**  
**bucket_count() == 128**  
**load_factor() == 0.0234375**  
**max_bucket_count() == 128**  
**max_load_factor() == 0.1**    
##  \<a name="unordered_multimap__max_load_factor">\</a>  unordered_multimap::max_load_factor  
 Gets or sets the maximum elements per bucket.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 The new maximum load factor.  
  
### Remarks  
 The first member function returns the stored maximum load factor. The second member function replaces the stored maximum load factor with <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_bucket_count() == 8**  
**max_load_factor() == 4**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_bucket_count() == 8**  
**max_load_factor() == 0.1**  
**bucket_count() == 128**  
**load_factor() == 0.0234375**  
**max_bucket_count() == 128**  
**max_load_factor() == 0.1**    
##  \<a name="unordered_multimap__max_size">\</a>  unordered_multimap::max_size  
 Gets the maximum size of the controlled sequence.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the length of the longest sequence that the object can control.  
  
### Example  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  **max_size() == 536870911**    
##  \<a name="unordered_multimap__operator_eq">\</a>  unordered_multimap::operator=  
 Copies a hash table.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>181\</CodeContentPlaceHolder>|The unordered_multimap being copied into the unordered_multimap.|  
  
### Remarks  
 After erasing any existing elements in a unordered_multimap, <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> either copies or moves the contents of <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> into the unordered_multimap.  
  
### Example  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
##  \<a name="unordered_multimap__pointer">\</a>  unordered_multimap::pointer  
 The type of a pointer to an element.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a pointer to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_multimap__reference">\</a>  unordered_multimap::reference  
 The type of a reference to an element.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a reference to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_multimap__rehash">\</a>  unordered_multimap::rehash  
 Rebuilds the hash table.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 The requested number of buckets.  
  
### Remarks  
 The member function alters the number of buckets to be at least <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> and rebuilds the hash table as needed.  
  
### Example  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_load_factor() == 4**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_load_factor() == 0.1**  
**bucket_count() == 128**  
**load_factor() == 0.0234375**  
**max_load_factor() == 0.1**    
##  \<a name="unordered_multimap__size">\</a>  unordered_multimap::size  
 Counts the number of elements.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the length of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**size == 0**  
**empty() == true**  
 **[e, 5] [d, 4]**  
**size == 2**  
**empty() == false**    
##  \<a name="unordered_multimap__size_type">\</a>  unordered_multimap::size_type  
 The type of an unsigned distance between two elements.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Remarks  
 The unsigned integer type describes an object that can represent the length of any controlled sequence. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  **size == 0**    
##  \<a name="unordered_multimap__swap">\</a>  unordered_multimap::swap  
 Swaps the contents of two containers.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 The container to swap with.  
  
### Remarks  
 The member function swaps the controlled sequences between <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>. If [get_allocator](#unordered_multimap__get_allocator)<CodeContentPlaceHolder>190\</CodeContentPlaceHolder>, it does so in constant time, it throws an exception only as a result of copying the stored traits object of type <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>, and it invalidates no references, pointers, or iterators that designate elements in the two controlled sequences. Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
### Example  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[f, 6] [e, 5] [d, 4]**  
 **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_multimap__unordered_multimap">\</a>  unordered_multimap::unordered_multimap  
 Constructs a container object.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>192\</CodeContentPlaceHolder>|The iterator type.|  
|<CodeContentPlaceHolder>193\</CodeContentPlaceHolder>|The allocator object to store.|  
|<CodeContentPlaceHolder>194\</CodeContentPlaceHolder>|The comparison function object to store.|  
|<CodeContentPlaceHolder>195\</CodeContentPlaceHolder>|The hash function object to store.|  
|<CodeContentPlaceHolder>196\</CodeContentPlaceHolder>|The minimum number of buckets.|  
|<CodeContentPlaceHolder>197\</CodeContentPlaceHolder>|The container to copy.|  
|<CodeContentPlaceHolder>198\</CodeContentPlaceHolder>|The initializer_list from which to copy the elements.|  
  
### Remarks  
 The first constructor specifies a copy of the sequence controlled by <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>. The second constructor specifies an empty controlled sequence. The third constructor. specifies a copy of the sequence by moving <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>. The fourth, fifth, sixth, seventh, and eighth constructors use an initializer_list for the members. The ninth constructor inserts the sequence of element values <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>.  
  
 All constructors also initialize several stored values. For the copy constructor, the values are obtained from <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>. Otherwise:  
  
 The minimum number of buckets is the argument <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>, if present; otherwise it is a default value described here as the implementation-defined value <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>.  
  
 The hash function object is the argument <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>, if present; otherwise it is <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>.  
  
 The comparison function object is the argument <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>, if present; otherwise it is <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>.  
  
 The allocator object is the argument <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>, if present; otherwise, it is <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  **[a, 1] [b, 2] [c, 3] [d, 4] [e, 5] [f, 6] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [5, g] [6, h] [7, i] [8, j] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [c, 3] [b, 2] [a, 1]**  
 **[f, 6] [e, 5] [d, 4]**  
 **[c, 3] [b, 2] [a, 1]**  
 **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_multimap__value_type">\</a>  unordered_multimap::value_type  
 The type of an element.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[d, 4] [c, 3] [b, 2] [a, 1]**    
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [Containers](../vs140/containers--modern-c---.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)