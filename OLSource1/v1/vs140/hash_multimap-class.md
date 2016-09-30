---
title: "hash_multimap Class"
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
  - "stdext::hash_multimap"
  - "stdext.hash_multimap"
  - "hash_map/stdext::hash_multimap"
  - "hash_multimap"
  - "std::hash_multimap"
  - "std.hash_multimap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash_multimap class"
ms.assetid: f41a6db9-67aa-43a3-a3c5-dbfe9ec3ae7d
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap Class
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 The container class hash_multimap is an extension of the Standard Template Library and is used for the storage and fast retrieval of data from a collection in which each element is a pair that has a sort key whose value need not be unique and an associated data value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The key data type to be stored in the hash_multimap.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The element data type to be stored in the hash_multimap.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The type that includes two function objects, one of class <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> that is able to compare two element values as sort keys to determine their relative order and a hash function that is a unary predicate mapping key values of the elements to unsigned integers of type **size_t**. This argument is optional, and the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> is the default value.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the hash_multimap's allocation and deallocation of memory. This argument is optional, and the default value is <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
## Remarks  
 The hash_multimap is:  
  
-   An associative container, which a variable size container that supports the efficient retrieval of element values based on an associated key value.  
  
-   Reversible, because it provides a bidirectional iterator to access its elements.  
  
-   Hashed, because its elements are grouped into buckets based on the value of a hash function applied to the key values of the elements.  
  
-   Multiple, because its elements do not need to have a unique keys, so that one key value may have many element data values associated with it.  
  
-   A pair associative container, because its element values are distinct from its key values.  
  
-   A template class, because the functionality it provides is generic and so independent of the specific type of data contained as elements or keys. The data types to be used for elements and keys are, instead, specified as parameters in the class template along with the comparison function and allocator.  
  
 The main advantage of hashing over sorting is greater efficiency; a successful hashing performs insertions, deletions, and finds in constant average time as compared with a time proportional to the logarithm of the number of elements in the container for sorting techniques. The value of an element in a hash_multimap, but not its associated key value, may be changed directly. Instead, key values associated with old elements must be deleted and new key values associated with new elements inserted.  
  
 The choice of container type should be based in general on the type of searching and inserting required by the application. Hashed associative containers are optimized for the operations of lookup, insertion and removal. The member functions that explicitly support these operations are efficient when used with a well-designed hash function, performing them in a time that is on average constant and not dependent on the number of elements in the container. A well-designed hash function produces a uniform distribution of hashed values and minimizes the number of collisions, where a collision is said to occur when distinct key values are mapped into the same hashed value. In the worst case, with the worst possible hash function, the number of operations is proportional to the number of elements in the sequence (linear time).  
  
 The hash_multimap should be the associative container of choice when the conditions associating the values with their keys are satisfied by the application. A model for this type of structure is an ordered list of key words with associated string values providing, say, definitions, where the words were not always uniquely defined. If, instead, the keywords were uniquely defined so that keys were unique, then a hash_map would be the container of choice. If, on the other hand, just the list of words were being stored, then a hash_set would be the correct container. If multiple occurrences of the words were allowed, then a hash_multiset would be the appropriate container structure.  
  
 The hash_multimap orders the sequence it controls by calling a stored hash <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object of type [value_compare](../vs140/value_compare-class.md). This stored object may be accessed by calling the member function [key_comp](../vs140/hash_map-class.md#hash_map__key_comp). Such a function object must behave the same as an object of class [hash_compare](../vs140/hash_compare-class.md)<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>. Specifically, for all values <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, the call <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> yields a distribution of values of type <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
 In general, the elements need be merely less than comparable to establish this order: so that, given any two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the non-equivalent elements. On a more technical note, the comparison function is a binary predicate that induces a strict weak ordering in the standard mathematical sense. A binary predicate f(x, y) is a function object that has two argument objects <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> and a return value of <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>. An ordering imposed on a hash_multimap is a strict weak ordering if the binary predicate is irreflexive, antisymmetric, and transitive and if equivalence is transitive, where two objects <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> are defined to be equivalent when both f(x, y) and f(y, x) are <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>. If the stronger condition of equality between keys replaces that of equivalence, then the ordering becomes total (in the sense that all the elements are ordered with respect to each other) and the keys matched will be indiscernible from each other.  
  
 The actual order of elements in the controlled sequence depends on the hash function, the ordering function, and the current size of the hash table stored in the container object. You cannot determine the current size of the hash table, so you cannot in general predict the order of elements in the controlled sequence. Inserting elements invalidates no iterators, and removing elements invalidates only those iterators that had specifically pointed at the removed elements.  
  
 The iterator provided by the hash_multimap class is a bidirectional iterator, but the class member functions [insert](#hash_multimap__insert) and [hash_multimap](#hash_multimap__hash_multimap) have versions that take as template parameters a weaker input iterator, whose functionality requirements are more minimal than those guaranteed by the class of bidirectional iterators. The different iterator concepts form a family related by refinements in their functionality. Each iterator concept has its own hash_multimap of requirements, and the algorithms that work with them must limit their assumptions to the requirements provided by that type of iterator. It may be assumed that an input iterator may be dereferenced to refer to some object and that it may be incremented to the next iterator in the sequence. This is a minimal hash_multimap of functionality, but it is enough to be able to talk meaningfully about a range of iterators <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> in the context of the member functions.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Constructors  
  
|||  
|-|-|  
|[hash_multimap](#hash_multimap__hash_multimap)|Constructs a list of a specific size or with elements of a specific value or with a specific <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> or as a copy of some other <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#hash_multimap__allocator_type)|A type that represents the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> class for the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object.|  
|[const_iterator](#hash_multimap__const_iterator)|A type that provides a bidirectional iterator that can read a <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.|  
|[const_pointer](#hash_multimap__const_pointer)|A type that provides a pointer to a <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.|  
|[const_reference](#hash_multimap__const_reference)|A type that provides a reference to a <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> element stored in a <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> for reading and performing <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> operations.|  
|[const_reverse_iterator](#hash_multimap__const_reverse_iterator)|A type that provides a bidirectional iterator that can read any <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.|  
|[difference_type](#hash_multimap__difference_type)|A signed integer type that can be used to represent the number of elements of a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> in a range between elements pointed to by iterators.|  
|[iterator](#hash_multimap__iterator)|A type that provides a bidirectional iterator that can read or modify any element in a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.|  
|[key_compare](#hash_multimap__key_compare)|A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.|  
|[key_type](#hash_multimap__key_type)|A type that describes the sort key object that constitutes each element of the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.|  
|[mapped_type](#hash_multimap__mapped_type)|A type that represents the data type stored in a <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.|  
|[pointer](#hash_multimap__pointer)|A type that provides a pointer to an element in a <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.|  
|[reference](#hash_multimap__reference)|A type that provides a reference to an element stored in a <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.|  
|[reverse_iterator](#hash_multimap__reverse_iterator)|A type that provides a bidirectional iterator that can read or modify an element in a reversed <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.|  
|[size_type](#hash_multimap__size_type)|An unsigned integer type that can represent the number of elements in a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.|  
|[value_type](#hash_multimap__value_type)|A type that provides a function object that can compare two elements as sort keys to determine their relative order in the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[begin](#hash_multimap__begin)|Returns an iterator addressing the first element in the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.|  
|[cbegin](#hash_multimap__cbegin)|Returns a const iterator addressing the first element in the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.|  
|[cend](#hash_multimap__cend)|Returns a const iterator that addresses the location succeeding the last element in a <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.|  
|[clear](#hash_multimap__clear)|Erases all the elements of a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.|  
|[count](#hash_multimap__count)|Returns the number of elements in a <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> whose key matches a parameter-specified key.|  
|[crbegin](#hash_multimap__crbegin)|Returns a const iterator addressing the first element in a reversed <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.|  
|[crend](#hash_multimap__crend)|Returns a const iterator that addresses the location succeeding the last element in a reversed <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.|  
|[emplace](#hash_multimap__emplace)|Inserts an element constructed in place into a <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.|  
|[emplace_hint](#hash_multimap__emplace_hint)|Inserts an element constructed in place into a <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>, with a placement hint.|  
|[empty](#hash_multimap__empty)|Tests if a <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> is empty.|  
|[end](#hash_multimap__end)|Returns an iterator that addresses the location succeeding the last element in a <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.|  
|[equal_range](#hash_multimap__equal_range)|Returns an iterator that addresses the location succeeding the last element in a <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.|  
|[erase](#hash_multimap__erase)|Removes an element or a range of elements in a <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> from specified positions|  
|[find](#hash_multimap__find)|Returns an iterator addressing the location of an element in a <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> that has a key equivalent to a specified key.|  
|[get_allocator](#hash_multimap__get_allocator)|Returns a copy of the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> object used to construct the <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.|  
|[insert](#hash_multimap__insert)|Inserts an element or a range of elements into the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> at a specified position.|  
|[key_comp](#hash_multimap__key_comp)|Retrieves a copy of the comparison object used to order keys in a <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>.|  
|[lower_bound](#hash_multimap__lower_bound)|Returns an iterator to the first element in a <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> that with a key value that is equal to or greater than that of a specified key.|  
|[max_size](#hash_multimap__max_size)|Returns the maximum length of the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.|  
|[rbegin](#hash_multimap__rbegin)|Returns an iterator addressing the first element in a reversed <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.|  
|[rend](#hash_multimap__rend)|Returns an iterator that addresses the location succeeding the last element in a reversed <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.|  
|[size](#hash_multimap__size)|Specifies a new size for a <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.|  
|[swap](#hash_multimap__swap)|Exchanges the elements of two <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>s.|  
|[upper_bound](#hash_multimap__upper_bound)|Returns an iterator to the first element in a <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> that with a key value that is greater than that of a specified key.|  
|[value_comp](#hash_multimap__value_comp)|Retrieves a copy of the comparison object used to order element values in a <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#hash_multimap__operator_eq)|Replaces the elements of a <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> with a copy of another <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
##  \<a name="hash_multimap__allocator_type">\</a>  hash_multimap::allocator_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that represents the allocator class for the hash_multimap object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>, see the Remarks section of the [hash_multimap Class](../vs140/hash_multimap-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [get_allocator](#hash_multimap__get_allocator) for an example using <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multimap__begin">\</a>  hash_multimap::begin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator addressing the first element in the hash_multimap.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator addressing the first element in the hash_multimap or the location succeeding an empty hash_multimap.  
  
### Remarks  
 If the return value of **begin** is assigned to a <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>, the elements in the hash_multimap object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the hash_multimap object can be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The first element of hm1 is 0.**  
**The first element of hm1 is now 1.**    
##  \<a name="hash_multimap__cbegin">\</a>  hash_multimap::cbegin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a const iterator addressing the first element in the hash_multimap.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A const bidirectional iterator addressing the first element in the [hash_multimap](../vs140/hash_multimap-class.md) or the location succeeding an empty <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The first element of hm1 is 2.**    
##  \<a name="hash_multimap__cend">\</a>  hash_multimap::cend  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a hash_multimap.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A const bidirectional iterator that addresses the location succeeding the last element in a [hash_multimap](../vs140/hash_multimap-class.md). If the <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> is empty, then <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> is used to test whether an iterator has reached the end of its hash_multimap.  
  
 The value returned by <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The value of last element of hm1 is 30.**    
##  \<a name="hash_multimap__clear">\</a>  hash_multimap::clear  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Erases all the elements of a hash_multimap.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  The following example demonstrates the use of the hash_multimap::clear member function.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The size of the hash_multimap is initially 2.**  
**The size of the hash_multimap after clearing is 0.**    
##  \<a name="hash_multimap__const_iterator">\</a>  hash_multimap::const_iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a bidirectional iterator that can read a **const** element in the hash_multimap.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 The <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> defined by hash_multimap points to objects of [value_type](#hash_multimap__value_type), which are of type <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>*\<***constKey, Type***>*. The value of the key is available through the first member pair, and the value of the mapped element is available through the second member of the pair.  
  
 To dereference a <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> pointing to an element in a hash_multimap, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>). **first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>). **first**.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [begin](#hash_multimap__begin) for an example using <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multimap__const_pointer">\</a>  hash_multimap::const_pointer  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a pointer to a **const** element in a hash_multimap.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 In most cases, an [iterator](#hash_multimap__iterator) should be used to access the elements in a hash_multimap object.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
##  \<a name="hash_multimap__const_reference">\</a>  hash_multimap::const_reference  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a reference to a **const** element stored in a hash_multimap for reading and performing **const** operations.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The key of first element in the hash_multimap is 1.**  
**The data value of 1st element in the hash_multimap is 10.**    
##  \<a name="hash_multimap__const_reverse_iterator">\</a>  hash_multimap::const_reverse_iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a bidirectional iterator that can read any **const** element in the hash_multimap.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> cannot modify the value of an element and is use to iterate through the hash_multimap in reverse.  
  
 The <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> defined by hash_multimap points to objects of [value_type](#hash_multimap__value_type), which are of type <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>*\<***const Key, Type>**, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference a <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> pointing to an element in a hash_multimap, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>). **first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>). **first**.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [rend](#hash_multimap__rend) for an example of how to declare and use the <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multimap__count">\</a>  hash_multimap::count  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns the number of elements in a hash_multimap whose key matches a parameter-specified key.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 The key of the elements to be matched from the hash_multimap.  
  
### Return Value  
 1 if the hash_multimap contains an element whose sort key matches the parameter key; 0 if the hash_multimap doesn't contain an element with a matching key.  
  
### Remarks  
 The member function returns the number of elements in the range  
  
 **[lower_bound (** <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  **), upper_bound (** <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  **) )**  
  
 which have a key value <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  The following example demonstrates the use of the hash_multimap::count member function.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **The number of elements in hm1 with a sort key of 1 is: 2.**  
**The number of elements in hm1 with a sort key of 2 is: 2.**  
**The number of elements in hm1 with a sort key of 3 is: 0.**    
##  \<a name="hash_multimap__crbegin">\</a>  hash_multimap::crbegin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a const iterator addressing the first element in a reversed hash_multimap.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [hash_multimap](../vs140/hash_multimap-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> is used with a reversed hash_multimap just as [begin](#hash_multimap__begin) is used with a <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> can be used to iterate through a <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The first element of the reversed hash_multimap hm1 is 3.**    
##  \<a name="hash_multimap__crend">\</a>  hash_multimap::crend  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a reversed hash_multimap.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [hash_multimap](../vs140/hash_multimap-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>).  
  
### Remarks  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> is used with a reversed hash_multimap just as [end](#hash_multimap__end) is used with a hash_multimap.  
  
 With the return value of <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its hash_multimap.  
  
 The value returned by <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **The last element of the reversed hash_multimap hm1 is 3.**    
##  \<a name="hash_multimap__difference_type">\</a>  hash_multimap::difference_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A signed integer type that can be used to represent the number of elements of a hash_multimap in a range between elements pointed to by iterators.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> is the type returned when subtracting or incrementing through iterators of the container. The <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> is typically used to represent the number of elements in the range                         *[_First, _Last)* between the iterators <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>, includes the element pointed to by <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> and the range of elements up to, but not including, the element pointed to by <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>.  
  
 Note that although <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers such as set, subtraction between iterators is only supported by random-access iterators provided by a random-access container such as vector.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The number of elements in the hash_multimap hm1 is: 4.**  
**The keys of the mapped elements are: 1 2 2 3.**  
**The values of the mapped elements are: 10 20 30 20.**    
##  \<a name="hash_multimap__emplace">\</a>  hash_multimap::emplace  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Inserts an element constructed in place into a hash_multimap.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>197\</CodeContentPlaceHolder>|The value used to move construct an element to be inserted into the [hash_multimap](../vs140/hash_multimap-class.md).|  
  
### Return Value  
 The <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> member function returns an iterator that points to the position where the new element was inserted.  
  
### Remarks  
 The [value_type](#hash_multimap__value_type) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 Beginning with Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **After the emplace insertion, hm1 contains:**  
 **1 => a**    
##  \<a name="hash_multimap__emplace_hint">\</a>  hash_multimap::emplace_hint  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Inserts an element constructed in place into a hash_multimap, with a placement hint.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>199\</CodeContentPlaceHolder>|The value used to move construct an element to be inserted into the [hash_multimap](../vs140/hash_multimap-class.md) unless the <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> already contains that element (or, more generally, an element whose key is equivalently ordered).|  
|<CodeContentPlaceHolder>201\</CodeContentPlaceHolder>|A hint regarding the place to start searching for the correct point of insertion.|  
  
### Return Value  
 The [emplace](#hash_multimap__emplace) member function returns an iterator that points to the position where the new element was inserted into the <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>.  
  
### Remarks  
 The [value_type](#hash_multimap__value_type) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>.  
  
 Beginning with Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **After the emplace insertion, hm1 contains:**  
 **1 => a**    
##  \<a name="hash_multimap__empty">\</a>  hash_multimap::empty  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Tests if a hash_multimap is empty.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the hash_multimap is empty; **false** if the hash_multimap is nonempty.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **The hash_multimap hm1 is not empty.**  
**The hash_multimap hm2 is empty.**    
##  \<a name="hash_multimap__end">\</a>  hash_multimap::end  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a hash_multimap.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator that addresses the location succeeding the last element in a hash_multimap. If the hash_multimap is empty, then hash_multimap::end == hash_multimap::begin.  
  
### Remarks  
 **end** is used to test whether an iterator has reached the end of its hash_multimap.  
  
 The value returned by **end** should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **The value of last element of hm1 is 30.**  
**The value of last element of hm1 is now 20.**    
##  \<a name="hash_multimap__equal_range">\</a>  hash_multimap::equal_range  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a pair of iterators respectively to the first element in a hash_multimap with a key that is greater than a specified key and to the first element in the hash_multimap with a key that is equal to or greater than the key.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the hash_multimap being searched.  
  
### Return Value  
 A pair of iterators such that the first is the [lower_bound](#hash_multimap__lower_bound) of the key and the second is the [upper_bound](#hash_multimap__upper_bound) of the key.  
  
 To access the first iterator of a pair <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>. **first** and to dereference the lower bound iterator, use \*( <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>. **first**). To access the second iterator of a pair <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>. **second** and to dereference the upper bound iterator, use \*( <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>. **second**).  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  **The lower bound of the element with a key of 2**  
 **in the hash_multimap hm1 is: 20.**  
**The upper bound of the element with a key of 2**  
 **in the hash_multimap hm1 is: 30.**  
**A direct call of upper_bound( 2 ) gives 30,**  
 **matching the 2nd element of the pair returned by equal_range( 2 ).**  
**The hash_multimap hm1 doesn't have an element with a key less than 4.**    
##  \<a name="hash_multimap__erase">\</a>  hash_multimap::erase  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Removes an element or a range of elements in a hash_multimap from specified positions or removes elements that match a specified key.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 Position of the element to be removed from the hash_multimap.  
  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 Position of the first element removed from the hash_multimap.  
  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 Position just beyond the last element removed from the hash_multimap.  
  
 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
 The key of the elements to be removed from the hash_multimap.  
  
### Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the hash_multimap if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the hash_multimap.  
  
### Remarks  
 The member functions never throw an exception.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  The following example demonstrates the use of the hash_multimap::erase member function.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  **After the 2nd element is deleted, the hash_multimap hm1 is: 1 3 4.**  
**After the middle two elements are deleted, the hash_multimap hm2 is: 1 16.**  
**After the element with a key of 2 is deleted,**  
 **the hash_multimap hm3 is: 0 2 3.**  
**The number of elements removed from hm3 is: 2.**  
**After another element with a key equal to that of the**  
 **2nd element is deleted, the hash_multimap hm3 is: 0 3.**    
##  \<a name="hash_multimap__find">\</a>  hash_multimap::find  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator addressing the first location of an element in a hash_multimap that has a key equivalent to a specified key.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 The key to be matched by the sort key of an element from the hash_multimap being searched.  
  
### Return Value  
 An iterator that addresses the first location of an element with a specified key, or the location succeeding the last element in the hash_multimap if no match is found for the key.  
  
### Remarks  
 The member function returns an iterator that addresses an element in the hash_multimap whose sort key is **equivalent** to the argument key under a binary predicate that induces an ordering based on a less than comparability relation.  
  
 If the return value of **find** is assigned to a <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>, the hash_multimap object cannot be modified. If the return value of **find** is assigned to an **iterator**, the hash_multimap object can be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  **The element of hash_multimap hm1 with a key of 2 is: 20.**  
**The first element of hash_multimap hm1 with a key of 3 is: 20.**  
**The hash_multimap hm1 doesn't have an element with a key of 4.**  
**The first element of hm1 with a key matching**  
**that of the last element is: 20.**  
**This is not the last element of hash_multimap hm1.**    
##  \<a name="hash_multimap__get_allocator">\</a>  hash_multimap::get_allocator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a copy of the allocator object used to construct the hash_multimap.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 The allocator used by the hash_multimap.  
  
### Remarks  
 Allocators for the hash_multimap class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
##  \<a name="hash_multimap__hash_multimap">\</a>  hash_multimap::hash_multimap  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Constructs a hash_multimap that is empty or is a copy of all or part of some other hash_multimap.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>217\</CodeContentPlaceHolder>|The storage allocator class to be used for this hash_multimap object, which defaults to <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>219\</CodeContentPlaceHolder>|The comparison function of type <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> used to order the elements in the map, which defaults to <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>222\</CodeContentPlaceHolder>|The map of which the constructed set is to be a copy.|  
|<CodeContentPlaceHolder>223\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>224\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>225\</CodeContentPlaceHolder>|The initializer_list to copy from.|  
  
### Remarks  
 All constructors store a type of allocator object that manages memory storage for the hash_multimap and that can later be returned by calling [get_allocator](#hash_multimap__get_allocator). The allocator parameter is often omitted in the class declarations and preprocessing macros are used to substitute alternative allocators.  
  
 All constructors initialize their hash_multimap.  
  
 All constructors store a function object of type <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> that is used to establish an order among the keys of the hash_multimap and can later be returned by calling [key_comp](#hash_multimap__key_comp).  
  
 The first three constructors specify an empty initial hash_multimap; the second specifies the type of comparison function ( <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifies the allocator type ( <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>) to be used. The keyword <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the hash_multimap <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>.  
  
 The next three constructors copy the range <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> of a map with increasing explicitness in specifying the type of comparison function of class **Traits** and allocator.  
  
 The eighth constructor moves the hash_multimap <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>.  
  
 The final three constructors use an initializer_list.  
  
##  \<a name="hash_multimap__insert">\</a>  hash_multimap::insert  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Inserts an element or a range of elements into a hash_multimap.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>233\</CodeContentPlaceHolder>|The value of an element to be inserted into the hash_multimap unless it already contains that element, or more generally, unless it already contains an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>234\</CodeContentPlaceHolder>|A hint about where to start searching for the correct point of insertion.|  
|<CodeContentPlaceHolder>235\</CodeContentPlaceHolder>|The position of the first element to be copied from a map.|  
|<CodeContentPlaceHolder>236\</CodeContentPlaceHolder>|The position just beyond the last element to be copied from a map.|  
  
### Return Value  
 The first two <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> member functions return an iterator that points to the position where the new element was inserted.  
  
 The third member function uses an initializer_list for the elements to be inserted.  
  
 The fourth member function inserts the sequence of element values into a map that corresponds to each element addressed by an iterator in the range <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> of a specified set.  
  
 The last two <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> member functions behave the same as the first two, except that they move-construct the inserted value.  
  
### Remarks  
 The [value_type](#hash_multimap__value_type) of an element is a pair, so that the value of an element will be an ordered pair in which the first component is equal to the key value and the second component is equal to the data value of the element.  
  
 Insertion can occur in amortized constant time for the hint version of <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multimap__iterator">\</a>  hash_multimap::iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify any element in a hash_multimap.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Remarks  
 The **iterator** defined by hash_multimap points to objects of [value_type](#hash_multimap__value_type), which are of type <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>\< **const Key, Type**>, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference an **iterator**<CodeContentPlaceHolder>243\</CodeContentPlaceHolder> pointing to an element in a hash_multimap, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>). **first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>). **first**.  
  
 A type **iterator** can be used to modify the value of an element.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [begin](#hash_multimap__begin) for an example of how to declare and use **iterator**.  
  
##  \<a name="hash_multimap__key_comp">\</a>  hash_multimap::key_comp  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Retrieves a copy of the comparison object used to order keys in a hash_multimap.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 Returns the function object that a hash_multimap uses to order its elements.  
  
### Remarks  
 The stored object defines the member function  
  
 **bool operator(const Key&**  <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> **, const Key&**  <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> **);**  
  
 which returns **true** if <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> in the sort order.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
##  \<a name="hash_multimap__key_compare">\</a>  hash_multimap::key_compare  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the hash_multimap.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 **key_compare** is a synonym for the template parameter <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> see the [hash_multimap Class](../vs140/hash_multimap-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [key_comp](#hash_multimap__key_comp) for an example of how to declare and use <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multimap__key_type">\</a>  hash_multimap::key_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that describes the sort key object that constitutes each element of the hash_multimap.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>, see the Remarks section of the [hash_multimap Class](../vs140/hash_multimap-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [value_type](#hash_multimap__value_type) for an example of how to declare and use <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multimap__lower_bound">\</a>  hash_multimap::lower_bound  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator to the first element in a hash_multimap with a key that is equal to or greater than a specified key.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the hash_multimap being searched.  
  
### Return Value  
 An [iterator](#hash_multimap__iterator) or [const_iterator](#hash_multimap__const_iterator) that addresses the location of an element in a hash_multimap with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the hash_multimap if no match is found for the key.  
  
 If the return value of <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>, the hash_multimap object cannot be modified. If the return value of <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> is assigned to an **iterator**, the hash_multimap object can be modified.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  **The element of hash_multimap hm1 with a key of 2 is: 20.**  
**The first element of hash_multimap hm1 with a key of 3 is: 20.**  
**The hash_multimap hm1 doesn't have an element with a key of 4.**  
**The first element of hm1 with a key matching**  
 **that of the last element is: 20.**  
**This is not the last element of hash_multimap hm1.**    
##  \<a name="hash_multimap__mapped_type">\</a>  hash_multimap::mapped_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that represents the data type stored in a hash_multimap.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> see the [hash_multimap Class](../vs140/hash_multimap-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [value_type](#hash_multimap__value_type) for an example of how to declare and use <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multimap__max_size">\</a>  hash_multimap::max_size  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns the maximum length of the hash_multimap.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Return Value  
 The maximum possible length of the hash_multimap.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
##  \<a name="hash_multimap__operator_eq">\</a>  hash_multimap::operator=  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Replaces the elements of the hash_multimap with a copy of another hash_multimap.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>267\</CodeContentPlaceHolder>|The [hash_multimap](../vs140/hash_multimap-class.md) being copied into the <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>.|  
  
### Remarks  
 After erasing any existing elements in a <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> either copies or moves the contents of <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
##  \<a name="hash_multimap__pointer">\</a>  hash_multimap::pointer  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a pointer to an element in a hash_multimap.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Remarks  
 A type **pointer** can be used to modify the value of an element.  
  
 In most cases, an [iterator](#hash_multimap__iterator) should be used to access the elements in a hash_multimap object.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
##  \<a name="hash_multimap__rbegin">\</a>  hash_multimap::rbegin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator addressing the first element in a reversed hash_multimap.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed hash_multimap or addressing what had been the last element in the unreversed hash_multimap.  
  
### Remarks  
 <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> is used with a reversed hash_multimap just as [begin](#hash_multimap__begin) is used with a hash_multimap.  
  
 If the return value of <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>, then the hash_multimap object cannot be modified. If the return value of <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>, then the hash_multimap object can be modified.  
  
 <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> can be used to iterate through a hash_multimap backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  **The first element of the reversed hash_multimap hm1 is 3.**  
**The hash_multimap is: 1 2 3 .**  
**The reversed hash_multimap is: 3 2 1 .**  
**After the erasure, the first element**  
 **in the reversed hash_multimap is 2.**    
##  \<a name="hash_multimap__reference">\</a>  hash_multimap::reference  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a reference to an element stored in a hash_multimap.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  **The key of first element in the hash_multimap is 1.**  
**The data value of first element in the hash_multimap is 10.**  
**The modified data value of first element is 15.**    
##  \<a name="hash_multimap__rend">\</a>  hash_multimap::rend  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a reversed hash_multimap.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed hash_multimap (the location that had preceded the first element in the unreversed hash_multimap).  
  
### Remarks  
 <CodeContentPlaceHolder>279\</CodeContentPlaceHolder> is used with a reversed hash_multimap just as [end](#hash_multimap__end) is used with a hash_multimap.  
  
 If the return value of <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> is assigned to a [const_reverse_iterator](#hash_multimap__const_reverse_iterator), then the hash_multimap object cannot be modified. If the return value of <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> is assigned to a [reverse_iterator](#hash_multimap__reverse_iterator), then the hash_multimap object can be modified.  
  
 <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its hash_multimap.  
  
 The value returned by <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  **The last element of the reversed hash_multimap hm1 is 1.**  
**The hash_multimap is: 1 2 3 .**  
**The reversed hash_multimap is: 3 2 1 .**  
**After the erasure, the last element in the reversed hash_multimap is 2.**    
##  \<a name="hash_multimap__reverse_iterator">\</a>  hash_multimap::reverse_iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify an element in a reversed hash_multimap.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> is used to iterate through the hash_multimap in reverse.  
  
 The <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> defined by hash_multimap points to objects of [value_type](#hash_multimap__value_type), which are of type <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>\< **const Key, Type**>. The value of the key is available through the first member pair and the value of the mapped element is available through the second member of the pair.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [rbegin](#hash_multimap__rbegin) for an example of how to declare and use <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multimap__size">\</a>  hash_multimap::size  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns the number of elements in the hash_multimap.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the hash_multimap.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  The following example demonstrates the use of the hash_multimap::size member function.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  **The hash_multimap length is 1.**  
**The hash_multimap length is now 2.**    
##  \<a name="hash_multimap__size_type">\</a>  hash_multimap::size_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 An unsigned integer type that counts the number of elements in a hash_multimap.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [size](#hash_multimap__size) for an example of how to declare and use <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>  
  
##  \<a name="hash_multimap__swap">\</a>  hash_multimap::swap  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Exchanges the elements of two hash_multimaps.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>  
 The hash_multimap providing the elements to be swapped or the hash_multimap whose elements are to be exchanged with those of the hash_multimap.  
  
### Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two hash_multimaps whose elements are being exchanged.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  **The original hash_multimap hm1 is: 10 20 30.**  
**After swapping with hm2, hash_multimap hm1 is: 100 200.**  
**After swapping with hm3, hash_multimap hm1 is: 300.**    
##  \<a name="hash_multimap__upper_bound">\</a>  hash_multimap::upper_bound  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator to the first element in a hash_multimap with a key that is greater than a specified key.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the hash_multimap being searched.  
  
### Return Value  
 An [iterator](#hash_multimap__iterator) or [const_iterator](#hash_multimap__const_iterator) that addresses the location of an element in a hash_multimap with a key that is greater than the argument key, or that addresses the location succeeding the last element in the hash_multimap if no match is found for the key.  
  
 If the return value of <CodeContentPlaceHolder>291\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>, the hash_multimap object cannot be modified. If the return value of <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> is assigned to a **iterator**, the hash_multimap object can be modified.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  **The 1st element of hash_multimap hm1 with a key greater than 1 is: 20.**  
**The first element of hash_multimap hm1**  
 **with a key  greater than 2 is: 30.**  
**The hash_multimap hm1 doesn't have an element with a key of 4.**  
**The first element of hm1 with a key greater than**  
 **that of the initial element of hm1 is: 20.**    
##  \<a name="hash_multimap__value_comp">\</a>  hash_multimap::value_comp  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 The member function returns a function object that determines the order of elements in a hash_multimap by comparing their key values.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Return Value  
 Returns the comparison function object that a hash_multimap uses to order its elements.  
  
### Remarks  
 For a hash_multimap                         *m*, if two elements                         *e*1(                        *k*1                        *, d*1) and                         *e*2(                        *k*2                        *, d*2) are objects of type [value_type](#hash_multimap__value_type), where                         *k*1 and                         *k*2 are their keys of type [key_type](#hash_multimap__key_type) and <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>1 and <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>2 are their data of type [mapped_type](#hash_multimap__mapped_type), then                         *m.*<CodeContentPlaceHolder>296\</CodeContentPlaceHolder>( )(                        *e*1                        *, e*2) is equivalent to                         *m.*<CodeContentPlaceHolder>297\</CodeContentPlaceHolder>( ) (                        *k*1                        *, k*2). A stored object defines the member function  
  
 **bool operator**( **value_type&**<CodeContentPlaceHolder>298\</CodeContentPlaceHolder>,  **value_type&** <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>);  
  
 which returns **true** if the key value of <CodeContentPlaceHolder>300\</CodeContentPlaceHolder> precedes and is not equal to the key value of <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> in the sort order.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
##  \<a name="hash_multimap__value_type">\</a>  hash_multimap::value_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that represents the type of object stored in a hash_multimap.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>302\</CodeContentPlaceHolder> is declared to be <CodeContentPlaceHolder>303\</CodeContentPlaceHolder> *\<***const**[key_type](#hash_multimap__key_type), [mapped_type](#hash_multimap__mapped_type)> and not <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> *<*<CodeContentPlaceHolder>305\</CodeContentPlaceHolder>*,* <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>*>* because the keys of an associative container may not be changed using a nonconstant iterator or reference.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  **The key of first element in the hash_multimap is 1.**  
**The data value of first element in the hash_multimap is 10.**  
**The keys of the mapped elements are: 1 2.**  
**The values of the mapped elements are: 10 20.**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)