---
title: "unordered_multiset Class"
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
  - "tr1::unordered_multiset"
  - "std::tr1::unordered_multiset"
  - "unordered_multiset"
  - "std.tr1.unordered_multiset"
  - "unordered_set/std::tr1::unordered_multiset"
  - "tr1.unordered_multiset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unordered_multiset class [TR1]"
  - "unordered_multiset class"
ms.assetid: 70c8dfc5-492a-4af2-84f5-1aa9cb04b71c
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset Class
The template class describes an object that controls a varying-length sequence of elements of type <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>. The sequence is weakly ordered by a hash function, which partitions the sequence into an ordered set of subsequences called buckets. Within each bucket a comparison function determines whether any pair of elements has equivalent ordering. Each element serves as both a sort key and a value. The sequence is represented in a way that permits lookup, insertion, and removal of an arbitrary element with a number of operations that can be independent of the number of elements in the sequence (constant time), at least when all buckets are of roughly equal length. In the worst case, when all of the elements are in one bucket, the number of operations is proportional to the number of elements in the sequence (linear time). Moreover, inserting an element invalidates no iterators, and removing an element invalidates only those iterators which point at the removed element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|The key type.|  
|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|The hash function object type.|  
|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|The equality comparison function object type.|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|The allocator class.|  
  
## Members  
  
|||  
|-|-|  
|Type Definition|Description|  
|[allocator_type](#unordered_multiset__allocator_type)|The type of an allocator for managing storage.|  
|[const_iterator](#unordered_multiset__const_iterator)|The type of a constant iterator for the controlled sequence.|  
|[const_local_iterator](#unordered_multiset__const_local_iterator)|The type of a constant bucket iterator for the controlled sequence.|  
|[const_pointer](#unordered_multiset__const_pointer)|The type of a constant pointer to an element.|  
|[const_reference](#unordered_multiset__const_reference)|The type of a constant reference to an element.|  
|[difference_type](#unordered_multiset__difference_type)|The type of a signed distance between two elements.|  
|[hasher](#unordered_multiset__hasher)|The type of the hash function.|  
|[iterator](#unordered_multiset__iterator)|The type of an iterator for the controlled sequence.|  
|[key_equal](#unordered_multiset__key_equal)|The type of the comparison function.|  
|[key_type](#unordered_multiset__key_type)|The type of an ordering key.|  
|[local_iterator](#unordered_multiset__local_iterator)|The type of a bucket iterator for the controlled sequence.|  
|[pointer](#unordered_multiset__pointer)|The type of a pointer to an element.|  
|[reference](#unordered_multiset__reference)|The type of a reference to an element.|  
|[size_type](#unordered_multiset__size_type)|The type of an unsigned distance between two elements.|  
|[value_type](#unordered_multiset__value_type)|The type of an element.|  
  
|||  
|-|-|  
|Member Function|Description|  
|[begin](#unordered_multiset__begin)|Designates the beginning of the controlled sequence.|  
|[bucket](#unordered_multiset__bucket)|Gets the bucket number for a key value.|  
|[bucket_count](#unordered_multiset__bucket_count)|Gets the number of buckets.|  
|[bucket_size](#unordered_multiset__bucket_size)|Gets the size of a bucket.|  
|[cbegin](#unordered_multiset__cbegin)|Designates the beginning of the controlled sequence.|  
|[cend](#unordered_multiset__cend)|Designates the end of the controlled sequence.|  
|[clear](#unordered_multiset__clear)|Removes all elements.|  
|[count](#unordered_multiset__count)|Finds the number of elements matching a specified key.|  
|[emplace](#unordered_multiset__emplace)|Adds an element constructed in place.|  
|[emplace_hint](#unordered_multiset__emplace_hint)|Adds an element constructed in place, with hint.|  
|[empty](#unordered_multiset__empty)|Tests whether no elements are present.|  
|[end](#unordered_multiset__end)|Designates the end of the controlled sequence.|  
|[equal_range](#unordered_multiset__equal_range)|Finds range that matches a specified key.|  
|[erase](#unordered_multiset__erase)|Removes elements at specified positions.|  
|[find](#unordered_multiset__find)|Finds an element that matches a specified key.|  
|[get_allocator](#unordered_multiset__get_allocator)|Gets the stored allocator object.|  
|[hash_function](#unordered_multiset__hash_function)|Gets the stored hash function object.|  
|[insert](#unordered_multiset__insert)|Adds elements.|  
|[key_eq](#unordered_multiset__key_eq)|Gets the stored comparison function object.|  
|[load_factor](#unordered_multiset__load_factor)|Counts the average elements per bucket.|  
|[max_bucket_count](#unordered_multiset__max_bucket_count)|Gets the maximum number of buckets.|  
|[max_load_factor](#unordered_multiset__max_load_factor)|Gets or sets the maximum elements per bucket.|  
|[max_size](#unordered_multiset__max_size)|Gets the maximum size of the controlled sequence.|  
|[rehash](#unordered_multiset__rehash)|Rebuilds the hash table.|  
|[size](#unordered_multiset__size)|Counts the number of elements.|  
|[swap](#unordered_multiset__swap)|Swaps the contents of two containers.|  
|[unordered_multiset](#unordered_multiset__unordered_multiset)|Constructs a container object.|  
  
|||  
|-|-|  
|Operator|Description|  
|[operator=](#unordered_multiset__operator_eq)|Copies a hash table.|  
  
## Remarks  
 The object orders the sequence it controls by calling two stored objects, a comparison function object of type [key_equal](#unordered_multiset__key_equal) and a hash function object of type [hasher](#unordered_multiset__hasher). You access the first stored object by calling the member function [key_eq](#unordered_multiset__key_eq)<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>; and you access the second stored object by calling the member function [hash_function](#unordered_multiset__hash_function)<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>. Specifically, for all values <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, the call <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> returns true only if the two argument values have equivalent ordering; the call <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> yields a distribution of values of type <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>. Unlike template class [unordered_set](../vs140/unordered_set-class.md), an object of template class <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> does not ensure that <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is always false for any two elements of the controlled sequence. (Keys need not be unique.)  
  
 The object also stores a maximum load factor, which specifies the maximum desired average number of elements per bucket. If inserting an element causes [load_factor](#unordered_multiset__load_factor)<CodeContentPlaceHolder>96\</CodeContentPlaceHolder> to exceed the maximum load factor, the container increases the number of buckets and rebuilds the hash table as needed.  
  
 The actual order of elements in the controlled sequence depends on the hash function, the comparison function, the order of insertion, the maximum load factor, and the current number of buckets. You cannot in general predict the order of elements in the controlled sequence. You can always be assured, however, that any subset of elements that have equivalent ordering are adjacent in the controlled sequence.  
  
 The object allocates and frees storage for the sequence it controls through a stored allocator object of type [allocator_type](#unordered_multiset__allocator_type). Such an allocator object must have the same external interface as an object of template class <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>. Note that the stored allocator object is not copied when the container object is assigned.  
  
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
##  \<a name="unordered_multiset__allocator_type">\</a>  unordered_multiset::allocator_type  
 The type of an allocator for managing storage.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **al == std::allocator() is true**    
##  \<a name="unordered_multiset__begin">\</a>  unordered_multiset::begin  
 Designates the beginning of the controlled sequence or a bucket.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|The bucket number.|  
  
### Remarks  
 The first two member functions return a forward iterator that points at the first element of the sequence (or just beyond the end of an empty sequence). The last two member functions return a forward iterator that points at the first element of bucket <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> (or just beyond the end of an empty bucket).  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[c] [b]**  
 **[a]**    
##  \<a name="unordered_multiset__bucket">\</a>  unordered_multiset::bucket  
 Gets the bucket number for a key value.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 keyval  
 The key value to map.  
  
### Remarks  
 The member function returns the bucket number currently corresponding to the key value <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
**bucket('a') == 7**  
**bucket_size(7) == 1**    
##  \<a name="unordered_multiset__bucket_count">\</a>  unordered_multiset::bucket_count  
 Gets the number of buckets.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the current number of buckets.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
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
##  \<a name="unordered_multiset__bucket_size">\</a>  unordered_multiset::bucket_size  
 Gets the size of a bucket  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 The bucket number.  
  
### Remarks  
 The member functions returns the size of bucket number <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
**bucket('a') == 7**  
**bucket_size(7) == 1**    
##  \<a name="unordered_multiset__cbegin">\</a>  unordered_multiset::cbegin  
 Returns a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> forward-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="unordered_multiset__cend">\</a>  unordered_multiset::cend  
 Returns a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> forward-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="unordered_multiset__clear">\</a>  unordered_multiset::clear  
 Removes all elements.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The member function calls [erase](#unordered_multiset__erase)<CodeContentPlaceHolder>124\</CodeContentPlaceHolder> [begin](#unordered_multiset__begin)<CodeContentPlaceHolder>125\</CodeContentPlaceHolder> [end](#unordered_multiset__end)<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
**size == 0**  
**empty() == true**  
 **[e] [d]**  
**size == 2**  
**empty() == false**    
##  \<a name="unordered_multiset__const_iterator">\</a>  unordered_multiset::const_iterator  
 The type of a constant iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant forward iterator for the controlled sequence. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
   **[c] [b] [a]**    
##  \<a name="unordered_multiset__const_local_iterator">\</a>  unordered_multiset::const_local_iterator  
 The type of a constant bucket iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant forward iterator for a bucket. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[a]**    
##  \<a name="unordered_multiset__const_pointer">\</a>  unordered_multiset::const_pointer  
 The type of a constant pointer to an element.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant pointer to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
   **[c] [b] [a]**    
##  \<a name="unordered_multiset__const_reference">\</a>  unordered_multiset::const_reference  
 The type of a constant reference to an element.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant reference to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
   **[c] [b] [a]**    
##  \<a name="unordered_multiset__count">\</a>  unordered_multiset::count  
 Finds the number of elements matching a specified key.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 Key value to search for.  
  
### Remarks  
 The member function returns the number of elements in the range delimited by [equal_range](#unordered_multiset__equal_range)<CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
**count('A') == 0**  
**count('b') == 1**  
**count('C') == 0**    
##  \<a name="unordered_multiset__difference_type">\</a>  unordered_multiset::difference_type  
 The type of a signed distance between two elements.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in the controlled sequence. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
**end()-begin() == 3**  
**begin()-end() == -3**    
##  \<a name="unordered_multiset__emplace">\</a>  unordered_multiset::emplace  
 Inserts an element constructed in place (no copy or move operations are performed).  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the unordered_multiset.|  
  
### Return Value  
 An iterator to the newly inserted element.  
  
### Remarks  
 No references to container elements are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 For a code example, see [multiset::emplace](../vs140/multiset-class.md#multiset__emplace).  
  
##  \<a name="unordered_multiset__emplace_hint">\</a>  unordered_multiset::emplace_hint  
 Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the unordered_multiset.|  
|<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>|A hint regarding the place to start searching for the correct point of insertion.|  
  
### Return Value  
 An iterator to the newly inserted element.  
  
### Remarks  
 No references to container elements are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 For a code example, see [set::emplace_hint](../vs140/set-class.md#set__emplace_hint).  
  
##  \<a name="unordered_multiset__empty">\</a>  unordered_multiset::empty  
 Tests whether no elements are present.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns true for an empty controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
**size == 0**  
**empty() == true**  
 **[e] [d]**  
**size == 2**  
**empty() == false**    
##  \<a name="unordered_multiset__end">\</a>  unordered_multiset::end  
 Designates the end of the controlled sequence.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 The bucket number.  
  
### Remarks  
 The first two member functions return a forward iterator that points just beyond the end of the sequence. The last two member functions return a forward iterator that points just beyond the end of bucket <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[a] [b]**  
 **[a]**    
##  \<a name="unordered_multiset__equal_range">\</a>  unordered_multiset::equal_range  
 Finds range that matches a specified key.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 Key value to search for.  
  
### Remarks  
 The member function returns a pair of iterators <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> such that <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> delimits just those elements of the controlled sequence that have equivalent ordering with <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>. If no such elements exist, both iterators are <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
**equal_range('x'):**  
**equal_range('b'): [b]**    
##  \<a name="unordered_multiset__erase">\</a>  unordered_multiset::erase  
 Removes an element or a range of elements in a unordered_multiset from specified positions or removes elements that match a specified key.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 Position of the element to be removed.  
  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 Position of the first element to be removed.  
  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 Position just beyond the last element to be removed.  
  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 The key value of the elements to be removed.  
  
### Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the unordered_multiset if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the unordered_multiset.  
  
### Remarks  
 For a code example, see [set::erase](../vs140/set-class.md#set__erase).  
  
##  \<a name="unordered_multiset__find">\</a>  unordered_multiset::find  
 Finds an element that matches a specified key.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 Key value to search for.  
  
### Remarks  
 The member function returns [equal_range](#unordered_multiset__equal_range)<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
**find('A') == false**  
**find('b') == true: [b]**    
##  \<a name="unordered_multiset__get_allocator">\</a>  unordered_multiset::get_allocator  
 Gets the stored allocator object.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored allocator object.  
  
### Example  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  **al == std::allocator() is true**    
##  \<a name="unordered_multiset__hash_function">\</a>  unordered_multiset::hash_function  
 Gets the stored hash function object.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored hash function object.  
  
### Example  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  **hfn('a') == 1630279**  
**hfn('b') == 1647086**    
##  \<a name="unordered_multiset__hasher">\</a>  unordered_multiset::hasher  
 The type of the hash function.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  **hfn('a') == 1630279**  
**hfn('b') == 1647086**    
##  \<a name="unordered_multiset__insert">\</a>  unordered_multiset::insert  
 Inserts an element or a range of elements into an unordered_multiset.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>|The value of an element to be inserted into the unordered_multiset.|  
|<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion.|  
|<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>|Template parameter that specifies the argument type that the unordered_multiset can use to construct an element of [value_type](../vs140/map-class.md#map__value_type), and perfect-forwards <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> as an argument.|  
|<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>|The position of the first element to be copied.|  
|<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>|The position just beyond the last element to be copied.|  
|<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map-class.md#map__value_type) objects.|  
|<CodeContentPlaceHolder>156\</CodeContentPlaceHolder>|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
### Return Value  
 The single-element-insert member functions, (1) and (2), return an iterator to the position where the new element was inserted into the unordered_multiset.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the unordered_multiset.  
  
### Remarks  
 No pointers or references are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During the insertion of just one element, if an exception is thrown but does not occur in the container's hash function, the container's state is not modified. If the exception is thrown in the hash function, the result is undefined. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 The [value_type](../vs140/map-class.md#map__value_type) of a container is a typedef that belongs to the container, and, for set, <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> is type <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>.  
  
 The range member function (5) inserts the sequence of element values into an unordered_multiset that corresponds to each element addressed by an iterator in the range <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>; therefore, <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> does not get inserted. The container member function <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> refers to the position just after the last element in the container—for example, the statement <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> inserts all elements of <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the unordered_multiset.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [unordered_multiset::emplace](#unordered_multiset__emplace) and [unordered_multiset::emplace_hint](#unordered_multiset__emplace_hint).  
  
 For a code example, see [multiset::insert](../vs140/multiset-class.md#multiset__insert).  
  
##  \<a name="unordered_multiset__iterator">\</a>  unordered_multiset::iterator  
 A type that provides a constant [forward iterator](../vs140/forward_iterator_tag-struct.md) that can read elements in an unordered_multiset.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Example  
  See the example for [begin](../vs140/multiset-class.md#multiset__begin) for an example of how to declare and use an **iterator**.  
  
##  \<a name="unordered_multiset__key_eq">\</a>  unordered_multiset::key_eq  
 Gets the stored comparison function object.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored comparison function object.  
  
### Example  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  **cmpfn('a', 'a') == true**  
**cmpfn('a', 'b') == false**    
##  \<a name="unordered_multiset__key_equal">\</a>  unordered_multiset::key_equal  
 The type of the comparison function.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  **cmpfn('a', 'a') == true**  
**cmpfn('a', 'b') == false**    
##  \<a name="unordered_multiset__key_type">\</a>  unordered_multiset::key_type  
 The type of an ordering key.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[d] [c] [b] [a]**    
##  \<a name="unordered_multiset__load_factor">\</a>  unordered_multiset::load_factor  
 Counts the average elements per bucket.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>[size](#unordered_multiset__size)<CodeContentPlaceHolder>168\</CodeContentPlaceHolder>[bucket_count](#unordered_multiset__bucket_count)<CodeContentPlaceHolder>169\</CodeContentPlaceHolder>, the average number of elements per bucket.  
  
### Example  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
##  \<a name="unordered_multiset__local_iterator">\</a>  unordered_multiset::local_iterator  
 The type of a bucket iterator.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a forward iterator for a bucket. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[a]**    
##  \<a name="unordered_multiset__max_bucket_count">\</a>  unordered_multiset::max_bucket_count  
 Gets the maximum number of buckets.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the maximum number of buckets currently permitted.  
  
### Example  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
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
##  \<a name="unordered_multiset__max_load_factor">\</a>  unordered_multiset::max_load_factor  
 Gets or sets the maximum elements per bucket.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 The new maximum load factor.  
  
### Remarks  
 The first member function returns the stored maximum load factor. The second member function replaces the stored maximum load factor with <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
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
##  \<a name="unordered_multiset__max_size">\</a>  unordered_multiset::max_size  
 Gets the maximum size of the controlled sequence.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the length of the longest sequence that the object can control.  
  
### Example  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  **max_size() == 4294967295**    
##  \<a name="unordered_multiset__operator_eq">\</a>  unordered_multiset::operator=  
 Copies a hash table.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>173\</CodeContentPlaceHolder>|The [unordered_multiset](../vs140/unordered_multiset-class.md) being copied into the <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>.|  
  
### Remarks  
 After erasing any existing elements in an <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> either copies or moves the contents of <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
##  \<a name="unordered_multiset__pointer">\</a>  unordered_multiset::pointer  
 The type of a pointer to an element.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a pointer to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
   **[c] [b] [a]**    
##  \<a name="unordered_multiset__reference">\</a>  unordered_multiset::reference  
 The type of a reference to an element.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a reference to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
   **[c] [b] [a]**    
##  \<a name="unordered_multiset__rehash">\</a>  unordered_multiset::rehash  
 Rebuilds the hash table.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 The requested number of buckets.  
  
### Remarks  
 The member function alters the number of buckets to be at least <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> and rebuilds the hash table as needed.  
  
### Example  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_load_factor() == 4**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_load_factor() == 0.1**  
**bucket_count() == 128**  
**load_factor() == 0.0234375**  
**max_load_factor() == 0.1**    
##  \<a name="unordered_multiset__size">\</a>  unordered_multiset::size  
 Counts the number of elements.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the length of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
**size == 0**  
**empty() == true**  
 **[e] [d]**  
**size == 2**  
**empty() == false**    
##  \<a name="unordered_multiset__size_type">\</a>  unordered_multiset::size_type  
 The type of an unsigned distance between two elements.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Remarks  
 The unsigned integer type describes an object that can represent the length of any controlled sequence. It is described here as a synonym for the implementation-defined type <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  **size == 0**    
##  \<a name="unordered_multiset__swap">\</a>  unordered_multiset::swap  
 Swaps the contents of two containers.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 The container to swap with.  
  
### Remarks  
 The member function swaps the controlled sequences between <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>. If [get_allocator](#unordered_multiset__get_allocator)<CodeContentPlaceHolder>185\</CodeContentPlaceHolder>, it does so in constant time, it throws an exception only as a result of copying the stored traits object of type <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>, and it invalidates no references, pointers, or iterators that designate elements in the two controlled sequences. Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
### Example  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[f] [e] [d]**  
 **[c] [b] [a]**    
##  \<a name="unordered_multiset__unordered_multiset">\</a>  unordered_multiset::unordered_multiset  
 Constructs a container object.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>187\</CodeContentPlaceHolder>|The iterator type.|  
|<CodeContentPlaceHolder>188\</CodeContentPlaceHolder>|The allocator object to store.|  
|<CodeContentPlaceHolder>189\</CodeContentPlaceHolder>|The comparison function object to store.|  
|<CodeContentPlaceHolder>190\</CodeContentPlaceHolder>|The hash function object to store.|  
|<CodeContentPlaceHolder>191\</CodeContentPlaceHolder>|The minimum number of buckets.|  
|<CodeContentPlaceHolder>192\</CodeContentPlaceHolder>|The container to copy.|  
|<CodeContentPlaceHolder>193\</CodeContentPlaceHolder>|The initializer_list from which to copy.|  
  
### Remarks  
 The first constructor specifies a copy of the sequence controlled by <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>. The second constructor specifies an empty controlled sequence. The third constructor inserts the sequence of element values <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>. The fourth constructor specifies a copy of the sequence by moving <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>.  
  
 All constructors also initialize several stored values. For the copy constructor, the values are obtained from <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>. Otherwise:  
  
 The minimum number of buckets is the argument <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>, if present; otherwise it is a default value described here as the implementation-defined value <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>.  
  
 The hash function object is the argument <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>, if present; otherwise it is <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>.  
  
 The comparison function object is the argument <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>, if present; otherwise it is <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>.  
  
 The allocator object is the argument <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>, if present; otherwise, it is <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>.  
  
##  \<a name="unordered_multiset__value_type">\</a>  unordered_multiset::value_type  
 The type of an element.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[d] [c] [b] [a]**    
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [Containers](../vs140/containers--modern-c---.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)