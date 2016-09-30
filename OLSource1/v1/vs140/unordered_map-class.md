---
title: "unordered_map Class"
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
  - "std::tr1::unordered_map"
  - "std.tr1.unordered_map"
  - "tr1.unordered_map"
  - "tr1::unordered_map"
  - "unordered_map"
  - "unordered_map/std::tr1::unordered_map"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unordered_map class"
  - "unordered_map class [TR1]"
ms.assetid: 7cf7cfa1-16e7-461c-a9b2-3b8d8ec24e0d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_map Class
The template class describes an object that controls a varying-length sequence of elements of type <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>. The sequence is weakly ordered by a hash function, which partitions the sequence into an ordered set of subsequences called buckets. Within each bucket a comparison function determines whether any pair of elements has equivalent ordering. Each element stores two objects, a sort key and a value. The sequence is represented in a way that permits lookup, insertion, and removal of an arbitrary element with a number of operations that can be independent of the number of elements in the sequence (constant time), at least when all buckets are of roughly equal length. In the worst case, when all of the elements are in one bucket, the number of operations is proportional to the number of elements in the sequence (linear time). Moreover, inserting an element invalidates no iterators, and removing an element invalidates only those iterators which point at the removed element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|The key type.|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|The mapped type.|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|The hash function object type.|  
|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|The equality comparison function object type.|  
|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|The allocator class.|  
  
## Members  
  
|||  
|-|-|  
|Type Definition|Description|  
|[allocator_type](#unordered_map__allocator_type)|The type of an allocator for managing storage.|  
|[const_iterator](#unordered_map__const_iterator)|The type of a constant iterator for the controlled sequence.|  
|[const_local_iterator](#unordered_map__const_local_iterator)|The type of a constant bucket iterator for the controlled sequence.|  
|[const_pointer](#unordered_map__const_pointer)|The type of a constant pointer to an element.|  
|[const_reference](#unordered_map__const_reference)|The type of a constant reference to an element.|  
|[difference_type](#unordered_map__difference_type)|The type of a signed distance between two elements.|  
|[hasher](#unordered_map__hasher)|The type of the hash function.|  
|[iterator](#unordered_map__iterator)|The type of an iterator for the controlled sequence.|  
|[key_equal](#unordered_map__key_equal)|The type of the comparison function.|  
|[key_type](#unordered_map__key_type)|The type of an ordering key.|  
|[local_iterator](#unordered_map__local_iterator)|The type of a bucket iterator for the controlled sequence.|  
|[mapped_type](#unordered_map__mapped_type)|The type of a mapped value associated with each key.|  
|[pointer](#unordered_map__pointer)|The type of a pointer to an element.|  
|[reference](#unordered_map__reference)|The type of a reference to an element.|  
|[size_type](#unordered_map__size_type)|The type of an unsigned distance between two elements.|  
|[value_type](#unordered_map__value_type)|The type of an element.|  
  
|||  
|-|-|  
|Member Function|Description|  
|[at](#unordered_map__at)|Finds an element with the specified key.|  
|[begin](#unordered_map__begin)|Designates the beginning of the controlled sequence.|  
|[bucket](#unordered_map__bucket)|Gets the bucket number for a key value.|  
|[bucket_count](#unordered_map__bucket_count)|Gets the number of buckets.|  
|[bucket_size](#unordered_map__bucket_size)|Gets the size of a bucket.|  
|[cbegin](#unordered_map__cbegin)|Designates the beginning of the controlled sequence.|  
|[cend](#unordered_map__cend)|Designates the end of the controlled sequence.|  
|[clear](#unordered_map__clear)|Removes all elements.|  
|[count](#unordered_map__count)|Finds the number of elements matching a specified key.|  
|[emplace](#unordered_map__emplace)|Adds an element constructed in place.|  
|[emplace_hint](#unordered_map__emplace_hint)|Adds an element constructed in place, with hint.|  
|[empty](#unordered_map__empty)|Tests whether no elements are present.|  
|[end](#unordered_map__end)|Designates the end of the controlled sequence.|  
|[equal_range](#unordered_map__equal_range)|Finds range that matches a specified key.|  
|[erase](#unordered_map__erase)|Removes elements at specified positions.|  
|[find](#unordered_map__find)|Finds an element that matches a specified key.|  
|[get_allocator](#unordered_map__get_allocator)|Gets the stored allocator object.|  
|[hash_function](#unordered_map__hash_function)|Gets the stored hash function object.|  
|[insert](#unordered_map__insert)|Adds elements.|  
|[key_eq](#unordered_map__key_eq)|Gets the stored comparison function object.|  
|[load_factor](#unordered_map__load_factor)|Counts the average elements per bucket.|  
|[max_bucket_count](#unordered_map__max_bucket_count)|Gets the maximum number of buckets.|  
|[max_load_factor](#unordered_map__max_load_factor)|Gets or sets the maximum elements per bucket.|  
|[max_size](#unordered_map__max_size)|Gets the maximum size of the controlled sequence.|  
|[rehash](#unordered_map__rehash)|Rebuilds the hash table.|  
|[size](#unordered_map__size)|Counts the number of elements.|  
|[swap](#unordered_map__swap)|Swaps the contents of two containers.|  
|[unordered_map](#unordered_map__unordered_map)|Constructs a container object.|  
  
|||  
|-|-|  
|Operator|Description|  
|[operator&#91;&#93;](#unordered_map__operator_at)|Finds or inserts an element with the specified key.|  
|[operator=](#unordered_map__operator_eq)|Copies a hash table.|  
  
## Remarks  
 The object orders the sequence it controls by calling two stored objects, a comparison function object of type [key_equal](#unordered_map__key_equal) and a hash function object of type [hasher](#unordered_map__hasher). You access the first stored object by calling the member function [key_eq](#unordered_map__key_eq)<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>; and you access the second stored object by calling the member function [hash_function](#unordered_map__hash_function)<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>. Specifically, for all values <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, the call <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> returns true only if the two argument values have equivalent ordering; the call <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> yields a distribution of values of type <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. Unlike template class [unordered_multimap](../vs140/unordered_multimap-class.md), an object of template class <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> ensures that <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> is always false for any two elements of the controlled sequence. (Keys are unique.)  
  
 The object also stores a maximum load factor, which specifies the maximum desired average number of elements per bucket. If inserting an element causes [load_factor](#unordered_map__load_factor)<CodeContentPlaceHolder>104\</CodeContentPlaceHolder> to exceed the maximum load factor, the container increases the number of buckets and rebuilds the hash table as needed.  
  
 The actual order of elements in the controlled sequence depends on the hash function, the comparison function, the order of insertion, the maximum load factor, and the current number of buckets. You cannot in general predict the order of elements in the controlled sequence. You can always be assured, however, that any subset of elements that have equivalent ordering are adjacent in the controlled sequence.  
  
 The object allocates and frees storage for the sequence it controls through a stored allocator object of type [allocator_type](#unordered_map__allocator_type). Such an allocator object must have the same external interface as an object of template class <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>. Note that the stored allocator object is not copied when the container object is assigned.  
  
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
##  \<a name="unordered_map__allocator_type">\</a>  unordered_map::allocator_type  
 The type of an allocator for managing storage.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **al == std::allocator() is true**    
##  \<a name="unordered_map__at">\</a>  unordered_map::at  
 Finds an element in a unordered_map with a specified key value.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>|The key value to find.|  
  
### Return Value  
 A reference to the data value of the element found.  
  
### Remarks  
 If the argument key value is not found, then the function throws an object of class <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="unordered_map__begin">\</a>  unordered_map::begin  
 Designates the beginning of the controlled sequence or a bucket.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>|The bucket number.|  
  
### Remarks  
 The first two member functions return a forward iterator that points at the first element of the sequence (or just beyond the end of an empty sequence). The last two member functions return a forward iterator that points at the first element of bucket <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> (or just beyond the end of an empty bucket).  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[c, 3] [b, 2]**  
 **[a, 1]**    
##  \<a name="unordered_map__bucket">\</a>  unordered_map::bucket  
 Gets the bucket number for a key value.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 The key value to map.  
  
### Remarks  
 The member function returns the bucket number currently corresponding to the key value <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**bucket('a') == 7**  
**bucket_size(7) == 1**    
##  \<a name="unordered_map__bucket_count">\</a>  unordered_map::bucket_count  
 Gets the number of buckets.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the current number of buckets.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
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
##  \<a name="unordered_map__bucket_size">\</a>  unordered_map::bucket_size  
 Gets the size of a bucket  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 The bucket number.  
  
### Remarks  
 The member functions returns the size of bucket number <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**bucket('a') == 7**  
**bucket_size(7) == 1**    
##  \<a name="unordered_map__cbegin">\</a>  unordered_map::cbegin  
 Returns a <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> forward-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="unordered_map__cend">\</a>  unordered_map::cend  
 Returns a <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> forward-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="unordered_map__clear">\</a>  unordered_map::clear  
 Removes all elements.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 The member function calls [erase](#unordered_map__erase)<CodeContentPlaceHolder>135\</CodeContentPlaceHolder> [begin](#unordered_map__begin)<CodeContentPlaceHolder>136\</CodeContentPlaceHolder> [end](#unordered_map__end)<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**size == 0**  
**empty() == true**  
 **[e, 5] [d, 4]**  
**size == 2**  
**empty() == false**    
##  \<a name="unordered_map__const_iterator">\</a>  unordered_map::const_iterator  
 The type of a constant iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant forward iterator for the controlled sequence. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_map__const_local_iterator">\</a>  unordered_map::const_local_iterator  
 The type of a constant bucket iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant forward iterator for a bucket. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[a, 1]**    
##  \<a name="unordered_map__const_pointer">\</a>  unordered_map::const_pointer  
 The type of a constant pointer to an element.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant pointer to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_map__const_reference">\</a>  unordered_map::const_reference  
 The type of a constant reference to an element.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant reference to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_map__count">\</a>  unordered_map::count  
 Finds the number of elements matching a specified key.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 Key value to search for.  
  
### Remarks  
 The member function returns the number of elements in the range delimited by [equal_range](#unordered_map__equal_range)<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**count('A') == 0**  
**count('b') == 1**  
**count('C') == 0**    
##  \<a name="unordered_map__difference_type">\</a>  unordered_map::difference_type  
 The type of a signed distance between two elements.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in the controlled sequence. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**end()-begin() == 3**  
**begin()-end() == -3**    
##  \<a name="unordered_map__emplace">\</a>  unordered_map::emplace  
 Inserts an element constructed in place (no copy or move operations are performed) into an unordered_map.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the unordered_map unless it already contains an element whose value is equivalently ordered.|  
  
### Return Value  
 A <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> whose <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> component returns true if an insertion was made and false if the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
 To access the iterator component of a pair <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>, and to dereference it, use <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>. To access the <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> component of a pair <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>.  
  
### Remarks  
 No iterators or references are invalidated by this function.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 For a code example, see [map::emplace](../vs140/map-class.md#map__emplace).  
  
##  \<a name="unordered_map__emplace_hint">\</a>  unordered_map::emplace_hint  
 Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the unordered_map unless the unordered_map already contains that element or, more generally, unless it already contains an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>|A hint regarding the place to start searching for the correct point of insertion.|  
  
### Return Value  
 An iterator to the newly inserted element.  
  
 If the insertion failed because the element already exists, returns an iterator to the existing element.  
  
### Remarks  
 No references are invalidated by this function.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 The [value_type](../vs140/map-class.md#map__value_type) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 For a code example, see [map::emplace_hint](../vs140/map-class.md#map__emplace_hint).  
  
##  \<a name="unordered_map__empty">\</a>  unordered_map::empty  
 Tests whether no elements are present.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns true for an empty controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**size == 0**  
**empty() == true**  
 **[e, 5] [d, 4]**  
**size == 2**  
**empty() == false**    
##  \<a name="unordered_map__end">\</a>  unordered_map::end  
 Designates the end of the controlled sequence.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>|The bucket number.|  
  
### Remarks  
 The first two member functions return a forward iterator that points just beyond the end of the sequence. The last two member functions return a forward iterator that points just beyond the end of bucket <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>.  
  
##  \<a name="unordered_map__equal_range">\</a>  unordered_map::equal_range  
 Finds range that matches a specified key.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 Key value to search for.  
  
### Remarks  
 The member function returns a pair of iterators <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> such that <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> delimits just those elements of the controlled sequence that have equivalent ordering with <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>. If no such elements exist, both iterators are <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**equal_range('x'):**  
**equal_range('b'): [b, 2]**    
##  \<a name="unordered_map__erase">\</a>  unordered_map::erase  
 Removes an element or a range of elements in a unordered_map from specified positions or removes elements that match a specified key.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 Position of the element to be removed.  
  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 Position of the first element to be removed.  
  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 Position just beyond the last element to be removed.  
  
 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 The key value of the elements to be removed.  
  
### Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the map if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the unordered_map.  
  
### Remarks  
 For a code example, see [map::erase](../vs140/map-class.md#map__erase).  
  
##  \<a name="unordered_map__find">\</a>  unordered_map::find  
 Finds an element that matches a specified key.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 Key value to search for.  
  
### Remarks  
 The member function returns [equal_range](#unordered_map__equal_range)<CodeContentPlaceHolder>167\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**find('A') == false**  
**find('b') == true: [b, 2]**    
##  \<a name="unordered_map__get_allocator">\</a>  unordered_map::get_allocator  
 Gets the stored allocator object.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored allocator object.  
  
### Example  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  **al == std::allocator() is true**    
##  \<a name="unordered_map__hash_function">\</a>  unordered_map::hash_function  
 Gets the stored hash function object.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored hash function object.  
  
### Example  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  **hfn('a') == 1630279**  
**hfn('b') == 1647086**    
##  \<a name="unordered_map__hasher">\</a>  unordered_map::hasher  
 The type of the hash function.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  **hfn('a') == 1630279**  
**hfn('b') == 1647086**    
##  \<a name="unordered_map__insert">\</a>  unordered_map::insert  
 Inserts an element or a range of elements into an unordered_map.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>169\</CodeContentPlaceHolder>|The value of an element to be inserted into the unordered_map unless it already contains an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>170\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion.|  
|<CodeContentPlaceHolder>171\</CodeContentPlaceHolder>|Template parameter that specifies the argument type that the unordered_map can use to construct an element of [value_type](../vs140/map-class.md#map__value_type), and perfect-forwards <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> as an argument.|  
|<CodeContentPlaceHolder>173\</CodeContentPlaceHolder>|The position of the first element to be copied.|  
|<CodeContentPlaceHolder>174\</CodeContentPlaceHolder>|The position just beyond the last element to be copied.|  
|<CodeContentPlaceHolder>175\</CodeContentPlaceHolder>|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map-class.md#map__value_type) objects.|  
|<CodeContentPlaceHolder>176\</CodeContentPlaceHolder>|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
### Return Value  
 The single-element member functions, (1) and (2), return a [pair](../vs140/pair-structure.md) whose <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> component is true if an insertion was made, and false if the unordered_map already contained an element whose key had an equivalent value in the ordering. The iterator component of the return-value pair points to the newly inserted element if the <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> component is true, or to the existing element if the <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> component is false.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the unordered_map or, if an element with an equivalent key already exists, to the existing element.  
  
### Remarks  
 No iterators, pointers, or references are invalidated by this function.  
  
 During the insertion of just one element, if an exception is thrown but does not occur in the container's hash function, the container's state is not modified. If the exception is thrown in the hash function, the result is undefined. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 To access the iterator component of a <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> that's returned by the single-element member functions, use <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>; to dereference the iterator within the returned pair, use <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>, giving you an element. To access the <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> component, use <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>. For an example, see the sample code later in this article.  
  
 The [value_type](../vs140/map-class.md#map__value_type) of a container is a typedef that belongs to the container, and for map, <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>. The value of an element is an ordered pair in which the first component is equal to the key value and the second component is equal to the data value of the element.  
  
 The range member function (5) inserts the sequence of element values into an unordered_map that corresponds to each element addressed by an iterator in the range <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>; therefore, <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> does not get inserted. The container member function <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> refers to the position just after the last element in the container—for example, the statement <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> attempts to insert all elements of <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>. Only elements that have unique values in the range are inserted; duplicates are ignored. To observe which elements are rejected, use the single-element versions of <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the unordered_map.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [unordered_map::emplace](#unordered_map__emplace) and [unordered_map::emplace_hint](#unordered_map__emplace_hint).  
  
 For a code example, see [map::insert](../vs140/map-class.md#map__insert).  
  
##  \<a name="unordered_map__iterator">\</a>  unordered_map::iterator  
 The type of an iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a forward iterator for the controlled sequence. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_map__key_eq">\</a>  unordered_map::key_eq  
 Gets the stored comparison function object.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored comparison function object.  
  
### Example  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  **cmpfn('a', 'a') == true**  
**cmpfn('a', 'b') == false**    
##  \<a name="unordered_map__key_equal">\</a>  unordered_map::key_equal  
 The type of the comparison function.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  **cmpfn('a', 'a') == true**  
**cmpfn('a', 'b') == false**    
##  \<a name="unordered_map__key_type">\</a>  unordered_map::key_type  
 The type of an ordering key.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[d, 4] [c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_map__load_factor">\</a>  unordered_map::load_factor  
 Counts the average elements per bucket.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>[size](#unordered_map__size)<CodeContentPlaceHolder>198\</CodeContentPlaceHolder>[bucket_count](#unordered_map__bucket_count)<CodeContentPlaceHolder>199\</CodeContentPlaceHolder>, the average number of elements per bucket.  
  
### Example  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
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
##  \<a name="unordered_map__local_iterator">\</a>  unordered_map::local_iterator  
 The type of a bucket iterator.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a forward iterator for a bucket. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[a, 1]**    
##  \<a name="unordered_map__mapped_type">\</a>  unordered_map::mapped_type  
 The type of a mapped value associated with each key.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[d, 4] [c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_map__max_bucket_count">\</a>  unordered_map::max_bucket_count  
 Gets the maximum number of buckets.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the maximum number of buckets currently permitted.  
  
### Example  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
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
##  \<a name="unordered_map__max_load_factor">\</a>  unordered_map::max_load_factor  
 Gets or sets the maximum elements per bucket.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 The new maximum load factor.  
  
### Remarks  
 The first member function returns the stored maximum load factor. The second member function replaces the stored maximum load factor with <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
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
##  \<a name="unordered_map__max_size">\</a>  unordered_map::max_size  
 Gets the maximum size of the controlled sequence.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the length of the longest sequence that the object can control.  
  
### Example  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  **max_size() == 536870911**    
##  \<a name="unordered_map__operator_at">\</a>  unordered_map::operator[]  
 Finds or inserts an element with the specified key.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>204\</CodeContentPlaceHolder>|The key value to find or insert.|  
  
### Return Value  
 A reference to the data value of the inserted element.  
  
### Remarks  
 If the argument key value is not found, then it is inserted along with the default value of the data type.  
  
 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> may be used to insert elements into a map                         *m* using                         *m*[_                        *Key*] = <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>; where <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> is the value of the <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> of the element with a key value of \_                        *Key*.  
  
 When using <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> to insert elements, the returned reference does not indicate whether an insertion is changing a pre-existing element or creating a new one. The member functions [find](../vs140/map-class.md#map__find) and [insert](../vs140/map-class.md#map__insert) can be used to determine whether an element with a specified key is already present before an insertion.  
  
### Example  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**c1['A'] == 0**  
**c1['a'] == 1**  
 **[c, 3] [b, 2] [A, 0] [a, 1]**  
**c2[move(str)] == 0**  
**c2["abc"] == 1**    
### Remarks  
 The member function determines the iterator <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> as the return value of [insert](#unordered_map__insert)<CodeContentPlaceHolder>211\</CodeContentPlaceHolder> [value_type](#unordered_map__value_type)<CodeContentPlaceHolder>212\</CodeContentPlaceHolder>. (It inserts an element with the specified key if no such element exists.) It then returns a reference to <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>.  
  
##  \<a name="unordered_map__operator_eq">\</a>  unordered_map::operator=  
 Replaces the elements of this unordered_map using the elements from another unordered_map.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>214\</CodeContentPlaceHolder>|The unordered_map that the operator function assigns content from.|  
  
### Remarks  
 The first version copies all of the elements from <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> to this unordered_map.  
  
 The second version moves all of the elements from <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> to this unordered_map.  
  
 Any elements that are in this unordered_map before <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>= executes are discarded.  
  
### Example  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
##  \<a name="unordered_map__pointer">\</a>  unordered_map::pointer  
 The type of a pointer to an element.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a pointer to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_map__reference">\</a>  unordered_map::reference  
 The type of a reference to an element.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a reference to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_map__rehash">\</a>  unordered_map::rehash  
 Rebuilds the hash table.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 The requested number of buckets.  
  
### Remarks  
 The member function alters the number of buckets to be at least <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> and rebuilds the hash table as needed.  
  
### Example  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
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
##  \<a name="unordered_map__size">\</a>  unordered_map::size  
 Counts the number of elements.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the length of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
**size == 0**  
**empty() == true**  
 **[e, 5] [d, 4]**  
**size == 2**  
**empty() == false**    
##  \<a name="unordered_map__size_type">\</a>  unordered_map::size_type  
 The type of an unsigned distance between two elements.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Remarks  
 The unsigned integer type describes an object that can represent the length of any controlled sequence. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  **size == 0**    
##  \<a name="unordered_map__swap">\</a>  unordered_map::swap  
 Swaps the contents of two containers.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 The container to swap with.  
  
### Remarks  
 The member function swaps the controlled sequences between <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>. If [get_allocator](#unordered_map__get_allocator)<CodeContentPlaceHolder>224\</CodeContentPlaceHolder>, it does so in constant time, it throws an exception only as a result of copying the stored traits object of type <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>, and it invalidates no references, pointers, or iterators that designate elements in the two controlled sequences. Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
### Example  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[f, 6] [e, 5] [d, 4]**  
 **[c, 3] [b, 2] [a, 1]**    
##  \<a name="unordered_map__unordered_map">\</a>  unordered_map::unordered_map  
 Constructs a container object.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>226\</CodeContentPlaceHolder>|The allocator object to store.|  
|<CodeContentPlaceHolder>227\</CodeContentPlaceHolder>|The comparison function object to store.|  
|<CodeContentPlaceHolder>228\</CodeContentPlaceHolder>|The hash function object to store.|  
|<CodeContentPlaceHolder>229\</CodeContentPlaceHolder>|The minimum number of buckets.|  
|<CodeContentPlaceHolder>230\</CodeContentPlaceHolder>|The container to copy.|  
|<CodeContentPlaceHolder>231\</CodeContentPlaceHolder>||  
|<CodeContentPlaceHolder>232\</CodeContentPlaceHolder>||  
|<CodeContentPlaceHolder>233\</CodeContentPlaceHolder>|The initializer_list that contains the elements to be copied.|  
  
### Remarks  
 The first constructor specifies a copy of the sequence controlled by <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>. The second constructor specifies an empty controlled sequence. The third constructor inserts the sequence of element values <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>. The fourth constructor specifies a copy of the sequence by moving <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>.  
  
 All constructors also initialize several stored values. For the copy constructor, the values are obtained from <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>. Otherwise:  
  
 the minimum number of buckets is the argument <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>, if present; otherwise it is a default value described here as the implementation-defined value <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>.  
  
 the hash function object is the argument <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>, if present; otherwise it is <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>.  
  
 The comparison function object is the argument <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>, if present; otherwise it is <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>.  
  
 The allocator object is the argument <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>, if present; otherwise, it is <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  **[a, 1] [b, 2] [c, 3] [d, 4] [e, 5] [f, 6] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [5, g] [6, h] [7, i] [8, j] [5, g] [6, h] [7, i] [8, j] [5, g] [6, h] [7, i] [8, j] [5, g] [6, h] [7, i] [8, j] [5, g] [6, h] [7, i] [8, j]**    
##  \<a name="unordered_map__value_type">\</a>  unordered_map::value_type  
 The type of an element.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
   **[c, 3] [b, 2] [a, 1]**  
 **[d, 4] [c, 3] [b, 2] [a, 1]**    
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [Containers](../vs140/containers--modern-c---.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)