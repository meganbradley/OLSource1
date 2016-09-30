---
title: "unordered_set Class"
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
  - "std.tr1.unordered_set"
  - "std::tr1::unordered_set"
  - "unordered_set/std::tr1::unordered_set"
  - "tr1::unordered_set"
  - "unordered_set"
  - "tr1.unordered_set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unordered_set class"
  - "unordered_set class [TR1]"
ms.assetid: ac08084e-05a7-48c0-9ae4-d40c529922dd
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set Class
The template class describes an object that controls a varying-length sequence of elements of type<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>. The sequence is weakly ordered by a hash function, which partitions the sequence into an ordered set of subsequences called buckets. Within each bucket a comparison function determines whether any pair of elements has equivalent ordering. Each element serves as both a sort key and a value. The sequence is represented in a way that permits lookup, insertion, and removal of an arbitrary element with a number of operations that can be independent of the number of elements in the sequence (constant time), at least when all buckets are of roughly equal length. In the worst case, when all of the elements are in one bucket, the number of operations is proportional to the number of elements in the sequence (linear time). Moreover, inserting an element invalidates no iterators, and removing an element invalidates only those iterators which point at the removed element.  
  
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
|[allocator_type](#unordered_set__allocator_type)|The type of an allocator for managing storage.|  
|[const_iterator](#unordered_set__const_iterator)|The type of a constant iterator for the controlled sequence.|  
|[const_local_iterator](#unordered_set__const_local_iterator)|The type of a constant bucket iterator for the controlled sequence.|  
|[const_pointer](#unordered_set__const_pointer)|The type of a constant pointer to an element.|  
|[const_reference](#unordered_set__const_reference)|The type of a constant reference to an element.|  
|[difference_type](#unordered_set__difference_type)|The type of a signed distance between two elements.|  
|[hasher](#unordered_set__hasher)|The type of the hash function.|  
|[iterator](#unordered_set__iterator)|The type of an iterator for the controlled sequence.|  
|[key_equal](#unordered_set__key_equal)|The type of the comparison function.|  
|[key_type](#unordered_set__key_type)|The type of an ordering key.|  
|[local_iterator](#unordered_set__local_iterator)|The type of a bucket iterator for the controlled sequence.|  
|[pointer](#unordered_set__pointer)|The type of a pointer to an element.|  
|[reference](#unordered_set__reference)|The type of a reference to an element.|  
|[size_type](#unordered_set__size_type)|The type of an unsigned distance between two elements.|  
|[value_type](#unordered_set__value_type)|The type of an element.|  
  
|||  
|-|-|  
|Member Function|Description|  
|[begin](#unordered_set__begin)|Designates the beginning of the controlled sequence.|  
|[bucket](#unordered_set__bucket)|Gets the bucket number for a key value.|  
|[bucket_count](#unordered_set__bucket_count)|Gets the number of buckets.|  
|[bucket_size](#unordered_set__bucket_size)|Gets the size of a bucket.|  
|[cbegin](#unordered_set__cbegin)|Designates the beginning of the controlled sequence.|  
|[cend](#unordered_set__cend)|Designates the end of the controlled sequence.|  
|[clear](#unordered_set__clear)|Removes all elements.|  
|[count](#unordered_set__count)|Finds the number of elements matching a specified key.|  
|[emplace](#unordered_set__emplace)|Adds an element constructed in place.|  
|[emplace_hint](#unordered_set__emplace_hint)|Adds an element constructed in place, with hint.|  
|[empty](#unordered_set__empty)|Tests whether no elements are present.|  
|[end](#unordered_set__end)|Designates the end of the controlled sequence.|  
|[equal_range](#unordered_set__equal_range)|Finds range that matches a specified key.|  
|[erase](#unordered_set__erase)|Removes elements at specified positions.|  
|[find](#unordered_set__find)|Finds an element that matches a specified key.|  
|[get_allocator](#unordered_set__get_allocator)|Gets the stored allocator object.|  
|[hash_function](#unordered_set__hash_function)|Gets the stored hash function object.|  
|[insert](#unordered_set__insert)|Adds elements.|  
|[key_eq](#unordered_set__key_eq)|Gets the stored comparison function object.|  
|[load_factor](#unordered_set__load_factor)|Counts the average elements per bucket.|  
|[max_bucket_count](#unordered_set__max_bucket_count)|Gets the maximum number of buckets.|  
|[max_load_factor](#unordered_set__max_load_factor)|Gets or sets the maximum elements per bucket.|  
|[max_size](#unordered_set__max_size)|Gets the maximum size of the controlled sequence.|  
|[rehash](#unordered_set__rehash)|Rebuilds the hash table.|  
|[size](#unordered_set__size)|Counts the number of elements.|  
|[swap](#unordered_set__swap)|Swaps the contents of two containers.|  
|[unordered_set](#unordered_set__unordered_set)|Constructs a container object.|  
  
|||  
|-|-|  
|Operators|Description|  
|[operator=](#unordered_set__operator_eq)|Copies a hash table.|  
  
## Remarks  
 The object orders the sequence it controls by calling two stored objects, a comparison function object of type[key_equal](#unordered_set__key_equal) and a hash function object of type[hasher](#unordered_set__hasher). You access the first stored object by calling the member function[key_eq](#unordered_set__key_eq)<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>; and you access the second stored object by calling the member function[hash_function](#unordered_set__hash_function)<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>. Specifically, for all values<CodeContentPlaceHolder>88\</CodeContentPlaceHolder> and<CodeContentPlaceHolder>89\</CodeContentPlaceHolder> of type<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, the call<CodeContentPlaceHolder>91\</CodeContentPlaceHolder> returns true only if the two argument values have equivalent ordering; the call<CodeContentPlaceHolder>92\</CodeContentPlaceHolder> yields a distribution of values of type<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>. Unlike template class[unordered_multiset](../vs140/unordered_multiset-class.md), an object of template class<CodeContentPlaceHolder>94\</CodeContentPlaceHolder> ensures that<CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is always false for any two elements of the controlled sequence. (Keys are unique.)  
  
 The object also stores a maximum load factor, which specifies the maximum desired average number of elements per bucket. If inserting an element causes[load_factor](#unordered_set__load_factor)<CodeContentPlaceHolder>96\</CodeContentPlaceHolder> to exceed the maximum load factor, the container increases the number of buckets and rebuilds the hash table as needed.  
  
 The actual order of elements in the controlled sequence depends on the hash function, the comparison function, the order of insertion, the maximum load factor, and the current number of buckets. You cannot in general predict the order of elements in the controlled sequence. You can always be assured, however, that any subset of elements that have equivalent ordering are adjacent in the controlled sequence.  
  
 The object allocates and frees storage for the sequence it controls through a stored allocator object of type[allocator_type](#unordered_set__allocator_type). Such an allocator object must have the same external interface as an object of template class<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>. Note that the stored allocator object is not copied when the container object is assigned.  
  
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
##  \<a name="unordered_set__allocator_type">\</a>  unordered_set::allocator_type  
 The type of an allocator for managing storage.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **al == std::allocator() is true**    
##  \<a name="unordered_set__begin">\</a>  unordered_set::begin  
 Designates the beginning of the controlled sequence or a bucket.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|The bucket number.|  
  
### Remarks  
 The first two member functions return a forward iterator that points at the first element of the sequence (or just beyond the end of an empty sequence). The last two member functions return a forward iterator that points at the first element of bucket<CodeContentPlaceHolder>100\</CodeContentPlaceHolder> (or just beyond the end of an empty bucket).  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
   **[a] [b] [c]**   
 **[a] [b] [c]**   
 **[a] [b]**   
 **[a]**     
##  \<a name="unordered_set__bucket">\</a>  unordered_set::bucket  
 Gets the bucket number for a key value.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 The key value to map.  
  
### Remarks  
 The member function returns the bucket number currently corresponding to the key value<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **bucket('a') == 7**  
 **bucket_size(7) == 1**    
##  \<a name="unordered_set__bucket_count">\</a>  unordered_set::bucket_count  
 Gets the number of buckets.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the current number of buckets.  
  
### Example  
  Â  
  
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
##  \<a name="unordered_set__bucket_size">\</a>  unordered_set::bucket_size  
 Gets the size of a bucket  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The bucket number.  
  
### Remarks  
 The member functions returns the size of bucket number<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **bucket('a') == 7**  
 **bucket_size(7) == 1**    
##  \<a name="unordered_set__cbegin">\</a>  unordered_set::cbegin  
 Returns a<CodeContentPlaceHolder>105\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A<CodeContentPlaceHolder>106\</CodeContentPlaceHolder> forward-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range,                         <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the<CodeContentPlaceHolder>109\</CodeContentPlaceHolder> member function to guarantee that the return value is<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the[auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider<CodeContentPlaceHolder>111\</CodeContentPlaceHolder> to be a modifiable (non-                        <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>) container of any kind that supports<CodeContentPlaceHolder>113\</CodeContentPlaceHolder> and<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="unordered_set__cend">\</a>  unordered_set::cend  
 Returns a<CodeContentPlaceHolder>115\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A<CodeContentPlaceHolder>116\</CodeContentPlaceHolder> forward-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the<CodeContentPlaceHolder>118\</CodeContentPlaceHolder> member function to guarantee that the return value is<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the[auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider<CodeContentPlaceHolder>120\</CodeContentPlaceHolder> to be a modifiable (non-                        <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>) container of any kind that supports<CodeContentPlaceHolder>122\</CodeContentPlaceHolder> and<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The value returned by<CodeContentPlaceHolder>124\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="unordered_set__clear">\</a>  unordered_set::clear  
 Removes all elements.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The member function calls[erase](#unordered_set__erase)<CodeContentPlaceHolder>125\</CodeContentPlaceHolder> [begin](#unordered_set__begin)<CodeContentPlaceHolder>126\</CodeContentPlaceHolder> [end](#unordered_set__end)<CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **size == 0**  
 **empty() == true**  
 **[e] [d]**  
 **size == 2**  
 **empty() == false**    
##  \<a name="unordered_set__const_iterator">\</a>  unordered_set::const_iterator  
 The type of a constant iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant forward iterator for the controlled sequence. It is described here as a synonym for the implementation-defined type<CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
   **[c] [b] [a]**    
##  \<a name="unordered_set__const_local_iterator">\</a>  unordered_set::const_local_iterator  
 The type of a constant bucket iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant forward iterator for a bucket. It is described here as a synonym for the implementation-defined type<CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[a]**    
##  \<a name="unordered_set__const_pointer">\</a>  unordered_set::const_pointer  
 The type of a constant pointer to an element.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant pointer to an element of the controlled sequence.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
   **[c] [b] [a]**    
##  \<a name="unordered_set__const_reference">\</a>  unordered_set::const_reference  
 The type of a constant reference to an element.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant reference to an element of the controlled sequence.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
   **[c] [b] [a]**    
##  \<a name="unordered_set__count">\</a>  unordered_set::count  
 Finds the number of elements matching a specified key.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 Key value to search for.  
  
### Remarks  
 The member function returns the number of elements in the range delimited by[equal_range](#unordered_set__equal_range)<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **count('A') == 0**  
 **count('b') == 1**  
 **count('C') == 0**    
##  \<a name="unordered_set__difference_type">\</a>  unordered_set::difference_type  
 The type of a signed distance between two elements.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in the controlled sequence. It is described here as a synonym for the implementation-defined type<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **end()-begin() == 3**  
 **begin()-end() == -3**    
##  \<a name="unordered_set__emplace">\</a>  unordered_set::emplace  
 Inserts an element constructed in place (no copy or move operations are performed).  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the unordered_set unless it already contains an element whose value is equivalently ordered.|  
  
### Return Value  
 A<CodeContentPlaceHolder>134\</CodeContentPlaceHolder> whose<CodeContentPlaceHolder>135\</CodeContentPlaceHolder> component returns true if an insertion was made and false if the<CodeContentPlaceHolder>136\</CodeContentPlaceHolder> already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
 To access the iterator component of a pair<CodeContentPlaceHolder>137\</CodeContentPlaceHolder> returned by this member function, use<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>, and to dereference it, use<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>. To access the<CodeContentPlaceHolder>140\</CodeContentPlaceHolder> component of a pair<CodeContentPlaceHolder>141\</CodeContentPlaceHolder> returned by this member function, use<CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
### Remarks  
 No iterators or references are invalidated by this function.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 For a code example, see[set::emplace](../vs140/set-class.md#set__emplace).  
  
##  \<a name="unordered_set__emplace_hint">\</a>  unordered_set::emplace_hint  
 Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the unordered_set unless the unordered_set already contains that element or, more generally, unless it already contains an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>|A hint regarding the place to start searching for the correct point of insertion.|  
  
### Return Value  
 An iterator to the newly inserted element.  
  
 If the insertion failed because the element already exists, returns an iterator to the existing element.  
  
### Remarks  
 No iterators or references are invalidated by this function.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 For a code example, see[set::emplace_hint](../vs140/set-class.md#set__emplace_hint).  
  
##  \<a name="unordered_set__empty">\</a>  unordered_set::empty  
 Tests whether no elements are present.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns true for an empty controlled sequence.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **size == 0**  
 **empty() == true**  
 **[e] [d]**  
 **size == 2**  
 **empty() == false**    
##  \<a name="unordered_set__end">\</a>  unordered_set::end  
 Designates the end of the controlled sequence.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>|The bucket number.|  
  
### Remarks  
 The first two member functions return a forward iterator that points just beyond the end of the sequence. The last two member functions return a forward iterator that points just beyond the end of bucket<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[a] [b]**  
 **[a]**    
##  \<a name="unordered_set__equal_range">\</a>  unordered_set::equal_range  
 Finds range that matches a specified key.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 Key value to search for.  
  
### Remarks  
 The member function returns a pair of iterators<CodeContentPlaceHolder>148\</CodeContentPlaceHolder> such that<CodeContentPlaceHolder>149\</CodeContentPlaceHolder> delimits just those elements of the controlled sequence that have equivalent ordering with<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>. If no such elements exist, both iterators are<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **equal_range('x'):**  
 **equal_range('b'): [b]**    
##  \<a name="unordered_set__erase">\</a>  unordered_set::erase  
 Removes an element or a range of elements in a unordered_set from specified positions or removes elements that match a specified key.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 Position of the element to be removed.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 Position of the first element to be removed.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Position just beyond the last element to be removed.  
  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 The key value of the elements to be removed.  
  
### Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the unordered_set if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the unordered_set.  
  
### Remarks  
 For a code example, see[set::erase](../vs140/set-class.md#set__erase).  
  
##  \<a name="unordered_set__find">\</a>  unordered_set::find  
 Finds an element that matches a specified key.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 Key value to search for.  
  
### Remarks  
 The member function returns[equal_range](#unordered_set__equal_range)<CodeContentPlaceHolder>157\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **find('A') == false**  
 **find('b') == true: [b]**    
##  \<a name="unordered_set__get_allocator">\</a>  unordered_set::get_allocator  
 Gets the stored allocator object.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored allocator object.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  **al == std::allocator() is true**    
##  \<a name="unordered_set__hash_function">\</a>  unordered_set::hash_function  
 Gets the stored hash function object.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored hash function object.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
   **hfn('a') == 1630279**  
 **hfn('b') == 1647086**    
##  \<a name="unordered_set__hasher">\</a>  unordered_set::hasher  
 The type of the hash function.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter<CodeContentPlaceHolder>158\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
   **hfn('a') == 1630279**  
 **hfn('b') == 1647086**    
##  \<a name="unordered_set__insert">\</a>  unordered_set::insert  
 Inserts an element or a range of elements into an unordered_set.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>159\</CodeContentPlaceHolder>|The value of an element to be inserted into the unordered_set unless it already contains an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion.|  
|<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>|Template parameter that specifies the argument type that the unordered_set can use to construct an element of[value_type](../vs140/map-class.md#map__value_type), and perfect-forwards<CodeContentPlaceHolder>162\</CodeContentPlaceHolder> as an argument.|  
|<CodeContentPlaceHolder>163\</CodeContentPlaceHolder>|The position of the first element to be copied.|  
|<CodeContentPlaceHolder>164\</CodeContentPlaceHolder>|The position just beyond the last element to be copied.|  
|<CodeContentPlaceHolder>165\</CodeContentPlaceHolder>|Template function argument that meets the requirements of an[input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct[value_type](../vs140/map-class.md#map__value_type) objects.|  
|<CodeContentPlaceHolder>166\</CodeContentPlaceHolder>|The[initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
### Return Value  
 The single-element member functions, (1) and (2), return a[pair](../vs140/pair-structure.md) whose<CodeContentPlaceHolder>167\</CodeContentPlaceHolder> component is true if an insertion was made, and false if the unordered_set already contained an element whose key had an equivalent value in the ordering. The iterator component of the return-value pair points to the newly inserted element if the<CodeContentPlaceHolder>168\</CodeContentPlaceHolder> component is true, or to the existing element if the<CodeContentPlaceHolder>169\</CodeContentPlaceHolder> component is false.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the unordered_set or, if an element with an equivalent key already exists, to the existing element.  
  
### Remarks  
 No iterators, pointers, or references are invalidated by this function.  
  
 During the insertion of just one element, if an exception is thrown but does not occur in the container's hash function, the container's state is not modified. If the exception is thrown in the hash function, the result is undefined. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 To access the iterator component of a<CodeContentPlaceHolder>170\</CodeContentPlaceHolder> that's returned by the single-element member functions, use<CodeContentPlaceHolder>171\</CodeContentPlaceHolder>; to dereference the iterator within the returned pair, use<CodeContentPlaceHolder>172\</CodeContentPlaceHolder>, giving you an element. To access the<CodeContentPlaceHolder>173\</CodeContentPlaceHolder> component, use<CodeContentPlaceHolder>174\</CodeContentPlaceHolder>. For an example, see the sample code later in this article.  
  
 The[value_type](../vs140/map-class.md#map__value_type) of a container is a typedef that belongs to the container, and, for set,                         <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> is type<CodeContentPlaceHolder>176\</CodeContentPlaceHolder>.  
  
 The range member function (5) inserts the sequence of element values into an unordered_set that corresponds to each element addressed by an iterator in the range<CodeContentPlaceHolder>177\</CodeContentPlaceHolder>; therefore,                         <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> does not get inserted. The container member function<CodeContentPlaceHolder>179\</CodeContentPlaceHolder> refers to the position just after the last element in the containerâ€”for example, the statement<CodeContentPlaceHolder>180\</CodeContentPlaceHolder> attempts to insert all elements of<CodeContentPlaceHolder>181\</CodeContentPlaceHolder> into<CodeContentPlaceHolder>182\</CodeContentPlaceHolder>. Only elements that have unique values in the range are inserted; duplicates are ignored. To observe which elements are rejected, use the single-element versions of<CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.  
  
 The initializer list member function (6) uses an[initializer_list](../vs140/-initializer_list-.md) to copy elements into the unordered_set.  
  
 For insertion of an element constructed in placeâ€”that is, no copy or move operations are performedâ€”see[unordered_set::emplace](../vs140/set-class.md#set__emplace) and[unordered_set::emplace_hint](../vs140/set-class.md#set__emplace_hint).  
  
 For a code example, see[set::insert](../vs140/set-class.md#set__insert).  
  
##  \<a name="unordered_set__iterator">\</a>  unordered_set::iterator  
 A type that provides a constant[forward iterator](../vs140/forward_iterator_tag-struct.md) that can read elements in an unordered_set.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Example  
  See the example for[begin](../vs140/set-class.md#set__begin) for an example of how to declare and use an**iterator**.  
  
##  \<a name="unordered_set__key_eq">\</a>  unordered_set::key_eq  
 Gets the stored comparison function object.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored comparison function object.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
   **cmpfn('a', 'a') == true**  
 **cmpfn('a', 'b') == false**    
##  \<a name="unordered_set__key_equal">\</a>  unordered_set::key_equal  
 The type of the comparison function.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter<CodeContentPlaceHolder>184\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
   **cmpfn('a', 'a') == true**  
 **cmpfn('a', 'b') == false**    
##  \<a name="unordered_set__key_type">\</a>  unordered_set::key_type  
 The type of an ordering key.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter<CodeContentPlaceHolder>185\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[d] [c] [b] [a]**    
##  \<a name="unordered_set__load_factor">\</a>  unordered_set::load_factor  
 Counts the average elements per bucket.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns<CodeContentPlaceHolder>186\</CodeContentPlaceHolder>[size](#unordered_set__size)<CodeContentPlaceHolder>187\</CodeContentPlaceHolder>[bucket_count](#unordered_set__bucket_count)<CodeContentPlaceHolder>188\</CodeContentPlaceHolder>, the average number of elements per bucket.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
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
##  \<a name="unordered_set__local_iterator">\</a>  unordered_set::local_iterator  
 The type of a bucket iterator.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a forward iterator for a bucket. It is described here as a synonym for the implementation-defined type<CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[a]**    
##  \<a name="unordered_set__max_bucket_count">\</a>  unordered_set::max_bucket_count  
 Gets the maximum number of buckets.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the maximum number of buckets currently permitted.  
  
### Example  
  Â  
  
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
##  \<a name="unordered_set__max_load_factor">\</a>  unordered_set::max_load_factor  
 Gets or sets the maximum elements per bucket.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 The new maximum load factor.  
  
### Remarks  
 The first member function returns the stored maximum load factor. The second member function replaces the stored maximum load factor with<CodeContentPlaceHolder>191\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
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
##  \<a name="unordered_set__max_size">\</a>  unordered_set::max_size  
 Gets the maximum size of the controlled sequence.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the length of the longest sequence that the object can control.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  **max_size() == 4294967295**    
##  \<a name="unordered_set__operator_eq">\</a>  unordered_set::operator=  
 Copies a hash table.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>192\</CodeContentPlaceHolder>|The[unordered_set](../vs140/unordered_set-class.md) being copied into the<CodeContentPlaceHolder>193\</CodeContentPlaceHolder>.|  
  
### Remarks  
 After erasing any existing elements in an<CodeContentPlaceHolder>194\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> either copies or moves the contents of<CodeContentPlaceHolder>196\</CodeContentPlaceHolder> into the<CodeContentPlaceHolder>197\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
##  \<a name="unordered_set__pointer">\</a>  unordered_set::pointer  
 The type of a pointer to an element.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a pointer to an element of the controlled sequence.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
   **[c] [b] [a]**    
##  \<a name="unordered_set__reference">\</a>  unordered_set::reference  
 The type of a reference to an element.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a reference to an element of the controlled sequence.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
   **[c] [b] [a]**    
##  \<a name="unordered_set__rehash">\</a>  unordered_set::rehash  
 Rebuilds the hash table.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The requested number of buckets.  
  
### Remarks  
 The member function alters the number of buckets to be at least<CodeContentPlaceHolder>199\</CodeContentPlaceHolder> and rebuilds the hash table as needed.  
  
### Example  
  Â  
  
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
##  \<a name="unordered_set__size">\</a>  unordered_set::size  
 Counts the number of elements.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the length of the controlled sequence.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **size == 0**  
 **empty() == true**  
 **[e] [d]**  
 **size == 2**  
 **empty() == false**    
##  \<a name="unordered_set__size_type">\</a>  unordered_set::size_type  
 The type of an unsigned distance between two elements.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Remarks  
 The unsigned integer type describes an object that can represent the length of any controlled sequence. It is described here as a synonym for the implementation-defined type<CodeContentPlaceHolder>200\</CodeContentPlaceHolder>.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  **size == 0**    
##  \<a name="unordered_set__swap">\</a>  unordered_set::swap  
 Swaps the contents of two containers.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 The container to swap with.  
  
### Remarks  
 The member function swaps the controlled sequences between<CodeContentPlaceHolder>202\</CodeContentPlaceHolder> and<CodeContentPlaceHolder>203\</CodeContentPlaceHolder>. If[get_allocator](#unordered_set__get_allocator)<CodeContentPlaceHolder>204\</CodeContentPlaceHolder>, it does so in constant time, it throws an exception only as a result of copying the stored traits object of type<CodeContentPlaceHolder>205\</CodeContentPlaceHolder>, and it invalidates no references, pointers, or iterators that designate elements in the two controlled sequences. Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[f] [e] [d]**  
 **[c] [b] [a]**    
##  \<a name="unordered_set__unordered_set">\</a>  unordered_set::unordered_set  
 Constructs a container object.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>206\</CodeContentPlaceHolder>|The iterator type.|  
|<CodeContentPlaceHolder>207\</CodeContentPlaceHolder>|The allocator object to store.|  
|<CodeContentPlaceHolder>208\</CodeContentPlaceHolder>|The comparison function object to store.|  
|<CodeContentPlaceHolder>209\</CodeContentPlaceHolder>|The hash function object to store.|  
|<CodeContentPlaceHolder>210\</CodeContentPlaceHolder>|The minimum number of buckets.|  
|<CodeContentPlaceHolder>211\</CodeContentPlaceHolder>|The container to copy.|  
|<CodeContentPlaceHolder>212\</CodeContentPlaceHolder>|The initializer_list containing the elements to copy.|  
  
### Remarks  
 The first constructor specifies a copy of the sequence controlled by<CodeContentPlaceHolder>213\</CodeContentPlaceHolder>. The second constructor specifies an empty controlled sequence. The third constructor specifies a copy of the sequence by moving<CodeContentPlaceHolder>214\</CodeContentPlaceHolder> The fourth through eighth constructors use an initializer_list to specify the elements to copy. The ninth constructor inserts the sequence of element values<CodeContentPlaceHolder>215\</CodeContentPlaceHolder>.  
  
 All constructors also initialize several stored values. For the copy constructor, the values are obtained from<CodeContentPlaceHolder>216\</CodeContentPlaceHolder>. Otherwise:  
  
 The minimum number of buckets is the argument<CodeContentPlaceHolder>217\</CodeContentPlaceHolder>, if present; otherwise it is a default value described here as the implementation-defined value<CodeContentPlaceHolder>218\</CodeContentPlaceHolder>.  
  
 The hash function object is the argument<CodeContentPlaceHolder>219\</CodeContentPlaceHolder>, if present; otherwise it is<CodeContentPlaceHolder>220\</CodeContentPlaceHolder>.  
  
 The comparison function object is the argument<CodeContentPlaceHolder>221\</CodeContentPlaceHolder>, if present; otherwise it is<CodeContentPlaceHolder>222\</CodeContentPlaceHolder>.  
  
 The allocator object is the argument<CodeContentPlaceHolder>223\</CodeContentPlaceHolder>, if present; otherwise, it is<CodeContentPlaceHolder>224\</CodeContentPlaceHolder>.  
  
##  \<a name="unordered_set__value_type">\</a>  unordered_set::value_type  
 The type of an element.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an element of the controlled sequence.  
  
### Example  
  Â  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
   **[c] [b] [a]**  
 **[d] [c] [b] [a]**    
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [Containers](../vs140/containers--modern-c---.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)