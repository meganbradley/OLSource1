---
title: "hash_map Class"
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
  - "stdext::hash_map"
  - "hash_map/stdext::hash_map"
  - "std.hash_map"
  - "stdext.hash_map"
  - "std::hash_map"
  - "hash_map"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash_map class"
ms.assetid: 40879dfc-51ba-4a59-9f9e-26208de568a8
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map Class
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Stores and retrieves data quickly from a collection in which each element is a pair that has a sort key whose value is unique and an associated data value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The key data type to be stored in the hash_map.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The element data type to be stored in the hash_map.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The type which includes two function objects, one of class compare able to compare two element values as sort keys to determine their relative order and a hash function that is a unary predicate mapping key values of the elements to unsigned integers of type <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>. This argument is optional, and hash_compare< <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, less< <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>> > is the default value.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the hash_map's allocation and deallocation of memory. This argument is optional, and the default value is allocator<pair <const <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>>>.  
  
## Remarks  
 The hash_map is:  
  
-   An associative container, which a variable size container that supports the efficient retrieval of element values based on an associated key value.  
  
-   Reversible, because it provides a bidirectional iterator to access its elements.  
  
-   Hashed, because its elements are grouped into buckets based on the value of a hash function applied to the key values of the elements.  
  
-   Unique in the sense that each of its elements must have a unique key.  
  
-   A pair associative container, because its element data values are distinct from its key values.  
  
-   A template class, because the functionality it provides is generic and so independent of the specific type of data contained as elements or keys. The data types to be used for elements and keys are, instead, specified as parameters in the class template along with the comparison function and allocator.  
  
 The main advantage of hashing over sorting is greater efficiency; a successful hashing performs insertions, deletions, and finds in constant average time as compared with a time proportional to the logarithm of the number of elements in the container for sorting techniques. The value of an element in a hash_map, but not its associated key value, may be changed directly. Instead, key values associated with old elements must be deleted and new key values associated with new elements inserted.  
  
 The choice of container type should be based in general on the type of searching and inserting required by the application. Hashed associative containers are optimized for the operations of lookup, insertion and removal. The member functions that explicitly support these operations are efficient when used with a well-designed hash function, performing them in a time that is on average constant and not dependent on the number of elements in the container. A well-designed hash function produces a uniform distribution of hashed values and minimizes the number of collisions, where a collision is said to occur when distinct key values are mapped into the same hashed value. In the worst case, with the worst possible hash function, the number of operations is proportional to the number of elements in the sequence (linear time).  
  
 The hash_map should be the associative container of choice when the conditions associating the values with their keys are satisfied by the application. A model for this type of structure is an ordered list of uniquely occurring keywords with associated string values providing, say, definitions. If, instead, the words had more than one correct definition, so that keys were not unique, then a hash_multimap would be the container of choice. If, on the other hand, just the list of words were being stored, then a hash_set would be the correct container. If multiple occurrences of the words were allowed, then a hash_multiset would be the appropriate container structure.  
  
 The hash_map orders the sequence it controls by calling a stored hash <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object of class [value_compare](../vs140/value_compare-class.md). This stored object may be accessed by calling the member function [key_comp](#hash_map__key_comp). Such a function object must behave the same as an object of class [hash_compare](../vs140/hash_compare-class.md)<Key, less\<Key>>. Specifically, for all values <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, the call <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> ) yields a distribution of values of type <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
 In general, the elements need be merely less than comparable to establish this order: so that, given any two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. On a more technical note, the comparison function is a binary predicate that induces a strict weak ordering in the standard mathematical sense. A binary predicate f(x y) is a function object that has two argument objects <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> and a return value of <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>. An ordering imposed on a hash_map is a strict weak ordering if the binary predicate is irreflexive, antisymmetric, and transitive and if equivalence is transitive, where two objects x and y are defined to be equivalent when both f(x, y) and f(y, x) are false. If the stronger condition of equality between keys replaces that of equivalence, then the ordering becomes total (in the sense that all the elements are ordered with respect to each other) and the keys matched will be indiscernible from each other.  
  
 The actual order of elements in the controlled sequence depends on the hash function, the ordering function, and the current size of the hash table stored in the container object. You cannot determine the current size of the hash table, so you cannot in general predict the order of elements in the controlled sequence. Inserting elements invalidates no iterators, and removing elements invalidates only those iterators that had specifically pointed at the removed elements.  
  
 The iterator provided by the hash_map class is a bidirectional iterator, but the class member functions [insert](#hash_map__insert) and [hash_map](#hash_map__hash_map) have versions that take as template parameters a weaker input iterator, whose functionality requirements are more minimal than those guaranteed by the class of bidirectional iterators. The different iterator concepts form a family related by refinements in their functionality. Each iterator concept has its own set of requirements, and the algorithms that work with them must limit their assumptions to the requirements provided by that type of iterator. It may be assumed that an input iterator may be dereferenced to refer to some object and that it may be incremented to the next iterator in the sequence. This is a minimal set of functionality, but it is enough to be able to talk meaningfully about a range of iterators <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> in the context of the class member functions.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Constructors  
  
|||  
|-|-|  
|[hash_map](#hash_map__hash_map)|Constructs a <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> that is empty or that is a copy of all or part of some other <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#hash_map__allocator_type)|A type that represents the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> class for the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object.|  
|[const_iterator](#hash_map__const_iterator)|A type that provides a bidirectional iterator that can read a <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.|  
|[const_pointer](#hash_map__const_pointer)|A type that provides a pointer to a <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.|  
|[const_reference](#hash_map__const_reference)|A type that provides a reference to a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> element stored in a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> for reading and performing <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> operations.|  
|[const_reverse_iterator](#hash_map__const_reverse_iterator)|A type that provides a bidirectional iterator that can read any <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.|  
|[difference_type](#hash_map__difference_type)|A signed integer type that can be used to represent the number of elements of a <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> in a range between elements pointed to by iterators.|  
|[iterator](#hash_map__iterator)|A type that provides a bidirectional iterator that can read or modify any element in a <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.|  
|[key_compare](#hash_map__key_compare)|A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.|  
|[key_type](#hash_map__key_type)|A type describes the sort key object that constitutes each element of the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.|  
|[mapped_type](#hash_map__mapped_type)|A type that represents the data type stored in a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.|  
|[pointer](#hash_map__pointer)|A type that provides a pointer to an element in a <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.|  
|[reference](#hash_map__reference)|A type that provides a reference to an element stored in a <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.|  
|[reverse_iterator](#hash_map__reverse_iterator)|A type that provides a bidirectional iterator that can read or modify an element in a reversed <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.|  
|[size_type](#hash_map__size_type)|An unsigned integer type that can represent the number of elements in a <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.|  
|[value_type](#hash_map__value_type)|A type that provides a function object that can compare two elements as sort keys to determine their relative order in the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[at](#hash_map__at)|Finds an element in a <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> with a specified key value.|  
|[begin](#hash_map__begin)|Returns an iterator addressing the first element in the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.|  
|[cbegin](#hash_map__cbegin)|Returns a const iterator addressing the first element in the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.|  
|[cend](#hash_map__cend)|Returns a const iterator that addresses the location succeeding the last element in a <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.|  
|[clear](#hash_map__clear)|Erases all the elements of a <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.|  
|[count](#hash_map__count)|Returns the number of elements in a <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> whose key matches a parameter-specified key.|  
|[crbegin](#hash_map__crbegin)|Returns a const iterator addressing the first element in a reversed <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.|  
|[crend](#hash_map__crend)|Returns a const iterator that addresses the location succeeding the last element in a reversed <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.|  
|[emplace](#hash_map__emplace)|Inserts an element constructed in place into a <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.|  
|[emplace_hint](#hash_map__emplace_hint)|Inserts an element constructed in place into a <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>, with a placement hint.|  
|[empty](#hash_map__empty)|Tests if a <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> is empty.|  
|[end](#hash_map__end)|Returns an iterator that addresses the location succeeding the last element in a <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.|  
|[equal_range](#hash_map__equal_range)|Returns a pair of iterators, respectively, to the first element in a <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> with a key that is greater than a specified key and to the first element in the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> with a key that is equal to or greater than the key.|  
|[erase](#hash_map__erase)|Removes an element or a range of elements in a <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> from specified positions|  
|[find](#hash_map__find)|Returns an iterator addressing the location of an element in a <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> that has a key equivalent to a specified key.|  
|[get_allocator](#hash_map__get_allocator)|Returns a copy of the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> object used to construct the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.|  
|[insert](#hash_map__insert)|Inserts an element or a range of elements into a <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.|  
|[key_comp](#hash_map__key_comp)|Returns an iterator to the first element in a <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> with a key value that is equal to or greater than that of a specified key.|  
|[lower_bound](#hash_map__lower_bound)|Returns an iterator to the first element in a <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> with a key value that is equal to or greater than that of a specified key.|  
|[max_size](#hash_map__max_size)|Returns the maximum length of the <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.|  
|[rbegin](#hash_map__rbegin)|Returns an iterator addressing the first element in a reversed <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.|  
|[rend](#hash_map__rend)|Returns an iterator that addresses the location succeeding the last element in a reversed <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.|  
|[size](#hash_map__size)|Returns the number of elements in the <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>.|  
|[swap](#hash_map__swap)|Exchanges the elements of two <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>s.|  
|[upper_bound](#hash_map__upper_bound)|Returns an iterator to the first element in a <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> that with a key value that is greater than that of a specified key.|  
|[value_comp](#hash_map__value_comp)|Retrieves a copy of the comparison object used to order element values in a <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator&#91;&#93;](#hash_map__operator_at)|Inserts an element into a <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> with a specified key value.|  
|[operator=](#hash_map__operator_eq)|Replaces the elements of a <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> with a copy of another <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
##  \<a name="hash_map__allocator_type">\</a>  hash_map::allocator_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that represents the allocator class for the hash_map object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Example  
  See example for [get_allocator](#hash_map__get_allocator) for an example using <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_map__at">\</a>  hash_map::at  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Finds an element in a hash_map with a specified key value.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>152\</CodeContentPlaceHolder>|The key value of the element that is to be found.|  
  
### Return Value  
 A reference to the data value of the element found.  
  
### Remarks  
 If the argument key value is not found, then the function throws an object of class [out_of_range](../vs140/out_of_range-class.md).  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="hash_map__begin">\</a>  hash_map::begin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator addressing the first element in the hash_map.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator addressing the first element in the hash_map or the location succeeding an empty hash_map.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The first element of hm1 is 0.**  
**The first element of hm1 is now 1.**    
##  \<a name="hash_map__cbegin">\</a>  hash_map::cbegin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a const iterator addressing the first element in the hash_map.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A const bidirectional iterator addressing the first element in the [hash_map](../vs140/hash_map-class.md) or the location succeeding an empty <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The first element of hm1 is 2.**    
##  \<a name="hash_map__cend">\</a>  hash_map::cend  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a hash_map.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A const bidirectional iterator that addresses the location succeeding the last element in a [hash_map](../vs140/hash_map-class.md). If the <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> is empty, then <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> is used to test whether an iterator has reached the end of its <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>.  
  
 The value returned by <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The value of last element of hm1 is 30.**    
##  \<a name="hash_map__clear">\</a>  hash_map::clear  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Erases all the elements of a hash_map.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  The following example demonstrates the use of the hash_map::clear member function.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **The size of the hash_map is initially 2.**  
**The size of the hash_map after clearing is 0.**    
##  \<a name="hash_map__const_iterator">\</a>  hash_map::const_iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a bidirectional iterator that can read a **const** element in the hash_map.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 The <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> defined by hash_map points to elements that are objects of [value_type](#hash_map__value_type), that is of type <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>*\<***const Key, Type***>*, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference a <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> pointing to an element in a hash_map, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> **-> first**, which is equivalent to (\* <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>) **.first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> **-> second**, which is equivalent to (\* <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>) **.second**.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [begin](#hash_map__begin) for an example using <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_map__const_pointer">\</a>  hash_map::const_pointer  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a pointer to a **const** element in a hash_map.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 In most cases, an [iterator](#hash_map__iterator) should be used to access the elements in a hash_map object.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
##  \<a name="hash_map__const_reference">\</a>  hash_map::const_reference  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a reference to a **const** element stored in a hash_map for reading and performing **const** operations.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **The key of the first element in the hash_map is 1.**  
**The data value of the first element in the hash_map is 10.**    
##  \<a name="hash_map__const_reverse_iterator">\</a>  hash_map::const_reverse_iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a bidirectional iterator that can read any **const** element in the hash_map.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> cannot modify the value of an element and is use to iterate through the hash_map in reverse.  
  
 The <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> defined by hash_map points to elements that are objects of [value_type](#hash_map__value_type), that is of type <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>\< **const Key, Type**>, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference a <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> pointing to an element in a hash_map, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>) **.first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>). **first**.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [rend](#hash_map__rend) for an example of how to declare and use the <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_map__count">\</a>  hash_map::count  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns the number of elements in a hash_map whose key matches a parameter-specified key.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 The key value of the elements to be matched from the hash_map.  
  
### Return Value  
 1 if the hash_map contains an element whose sort key matches the parameter key; 0 if the hash_map doesn't contain an element with a matching key.  
  
### Remarks  
 The member function returns the number of elements                         *x* in the range  
  
 [ <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> (_                        *Key* ), <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> (\_                        *Key* ) )  
  
 which is 0 or 1 in the case of hash_map, which is a unique associative container.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  The following example demonstrates the use of the hash_map::count member function.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The number of elements in hm1 with a sort key of 1 is: 1.**  
**The number of elements in hm1 with a sort key of 2 is: 1.**  
**The number of elements in hm1 with a sort key of 3 is: 0.**    
##  \<a name="hash_map__crbegin">\</a>  hash_map::crbegin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a const iterator addressing the first element in a reversed hash_map.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [hash_map](../vs140/hash_map-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> is used with a reversed hash_map just as [begin](#hash_map__begin) is used with a <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> can be used to iterate through a <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **The first element of the reversed hash_map hm1 is 3.**    
##  \<a name="hash_map__crend">\</a>  hash_map::crend  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a reversed hash_map.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [hash_map](../vs140/hash_map-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>).  
  
### Remarks  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> just as [end](#hash_map__end) is used with a <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>.  
  
 The value returned by <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The last element of the reversed hash_map hm1 is 3.**    
##  \<a name="hash_map__difference_type">\</a>  hash_map::difference_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A signed integer type that can be used to represent the number of elements of a hash_map in a range between elements pointed to by iterators.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **The number of elements in the hash_map hm1 is: 3.**  
**The keys of the mapped elements are: 1 2 3.**  
**The values of the mapped elements are: 10 20 20.**    
##  \<a name="hash_map__emplace">\</a>  hash_map::emplace  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Inserts an element constructed in place into a hash_map.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>197\</CodeContentPlaceHolder>|The value used to move construct an element to be inserted into the [hash_map](../vs140/hash_map-class.md) unless the <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> already contains that element (or, more generally, an element whose key is equivalently ordered).|  
  
### Return Value  
 The <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> member function returns a pair whose bool component returns true if an insertion was made and false if the <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
 To access the iterator component of a pair <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>, and to dereference it, use <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>. To access the <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> component of a pair <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>, and to dereference it, use <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>.  
  
### Remarks  
 The [value_type](#hash_map__value_type) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 Beginning with Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **After the emplace insertion, hm1 contains:**  
 **1 => a**    
##  \<a name="hash_map__emplace_hint">\</a>  hash_map::emplace_hint  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Inserts an element constructed in place into a hash_map, with a placement hint.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>208\</CodeContentPlaceHolder>|The value used to move construct an element to be inserted into the [hash_map](../vs140/hash_map-class.md) unless the <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> already contains that element (or, more generally, an element whose key is equivalently ordered).|  
|<CodeContentPlaceHolder>210\</CodeContentPlaceHolder>|A hint regarding the place to start searching for the correct point of insertion.|  
  
### Return Value  
 The [emplace](../vs140/hash_multimap-class.md#hash_multimap__emplace) member function returns an iterator that points to the position where the new element was inserted into the <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>, or where the existing element with equivalent ordering is located.  
  
### Remarks  
 The [value_type](#hash_map__value_type) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>.  
  
 Beginning with Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **After the emplace insertion, hm1 contains:**  
 **1 => a**    
##  \<a name="hash_map__empty">\</a>  hash_map::empty  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Tests if a hash_map is empty.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the hash_map is empty; **false** if the hash_map is nonempty.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **The hash_map hm1 is not empty.**  
**The hash_map hm2 is empty.**    
##  \<a name="hash_map__end">\</a>  hash_map::end  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a hash_map.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator that addresses the location succeeding the last element in a hash_map. If the hash_map is empty, then hash_map::end == hash_map::begin.  
  
### Remarks  
 **end** is used to test whether an iterator has reached the end of its hash_map.  
  
 The value returned by **end** should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  **The value of last element of hm1 is 30.**  
**The value of last element of hm1 is now 20.**    
##  \<a name="hash_map__equal_range">\</a>  hash_map::equal_range  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a pair of iterators respectively to the first element in a hash_map with a key that is greater than a specified key and to the first element in the hash_map with a key that is equal to or greater than the key.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 The argument key value to be compared with the sort key of an element from the hash_map being searched.  
  
### Return Value  
 A pair of iterators such that the first is the [lower_bound](#hash_map__lower_bound) of the key and the second is the [upper_bound](#hash_map__upper_bound) of the key.  
  
 To access the first iterator of a pair <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>. **first** and to dereference the lower bound iterator, use \*( <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>. **first**). To access the second iterator of a pair <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>. **second** and to dereference the upper bound iterator, use \*( <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>. **second**).  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  **The lower bound of the element with a key of 2 in the hash_map hm1 is: 20.**  
**The upper bound of the element with a key of 2 in the hash_map hm1 is: 30.**  
**A direct call of upper_bound( 2 ) gives 30,**  
 **matching the 2nd element of the pair returned by equal_range( 2 ).**  
**The hash_map hm1 doesn't have an element with a key less than 40.**    
##  \<a name="hash_map__erase">\</a>  hash_map::erase  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Removes an element or a range of elements in a hash_map from specified positions or removes elements that match a specified key.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 Position of the element to be removed from the hash_map.  
  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 Position of the first element removed from the hash_map.  
  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 Position just beyond the last element removed from the hash_map.  
  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 The key value of the elements to be removed from the hash_map.  
  
### Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the hash_map if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the hash_map.  
  
### Remarks  
 The member functions never throw an exception.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  The following example demonstrates the use of the hash_map::erase member function.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  **After the 2nd element is deleted, the hash_map hm1 is: 1 3 4.**  
**After the middle two elements are deleted, the hash_map hm2 is: 1 16.**  
**After the element with a key of 2 is deleted,**  
**the hash_map hm3 is: 0 2 3.**  
**The number of elements removed from hm3 is: 1.**  
**After another element with a key equal to that**  
**of the 2nd element is deleted, the hash_map hm3 is: 0 3.**    
##  \<a name="hash_map__find">\</a>  hash_map::find  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator addressing the location of an element in a hash_map that has a key equivalent to a specified key.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 The key value to be matched by the sort key of an element from the hash_map being searched.  
  
### Return Value  
 An iterator that addresses the location of an element with a specified key, or the location succeeding the last element in the hash_map if no match is found for the key.  
  
### Remarks  
 **find** returns an iterator that addresses an element in the hash_map whose sort key is equivalent to the argument key under a binary predicate that induces an ordering based on a less than comparability relation.  
  
 If the return value of **find** is assigned to a [const_iterator](#hash_map__const_iterator), the hash_map object cannot be modified. If the return value of **find** is assigned to an [iterator](#hash_map__iterator), the hash_map object can be modified  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  **The element of hash_map hm1 with a key of 2 is: 20.**  
**The hash_map hm1 doesn't have an element with a key of 4.**  
**The element of hm1 with a key matching that of the last element is: 30.**    
##  \<a name="hash_map__get_allocator">\</a>  hash_map::get_allocator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a copy of the allocator object used to construct the hash_map.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
 The allocator used by the hash_map.  
  
### Remarks  
 Allocators for the hash_map class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
##  \<a name="hash_map__hash_map">\</a>  hash_map::hash_map  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Constructs a hash_map that is empty or is a copy of all or part of some other hash_map.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>225\</CodeContentPlaceHolder>|The storage allocator class to be used for this hash_map object, which defaults to **Allocator**.|  
|<CodeContentPlaceHolder>226\</CodeContentPlaceHolder>|The comparison function of type const <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> used to order the elements in the hash_map, which defaults to <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>229\</CodeContentPlaceHolder>|The hash_map of which the constructed map is to be a copy.|  
|<CodeContentPlaceHolder>230\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>231\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>232\</CodeContentPlaceHolder>|The initializer_list|  
  
### Remarks  
 All constructors store a type of allocator object that manages memory storage for the hash_map and can later be returned by calling [get_allocator](#hash_map__get_allocator). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their hash_map.  
  
 All constructors store a function object of type <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> that is used to establish an order among the keys of the hash_map and that can later be returned by calling [key_comp](#hash_map__key_comp).  
  
 The first three constructors specify an empty initial hash_map, in addition, the second specifies the type of comparison function ( <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifies the allocator type ( <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>) to be used. The keyword <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the hash_map <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>.  
  
 The next three constructors copy the range <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> of a hash_map with increasing explicitness in specifying the type of comparison function of class <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> and allocator.  
  
 The last constructor moves the hash_map <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_map__insert">\</a>  hash_map::insert  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Inserts an element or a range of elements into a hash_map.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>241\</CodeContentPlaceHolder>|The value of an element to be inserted into the hash_map unless the hash_map already contains that element (or, more generally, an element whose key is equivalently ordered).|  
|<CodeContentPlaceHolder>242\</CodeContentPlaceHolder>|A hint regarding the place to start searching for the correct point of insertion.|  
|<CodeContentPlaceHolder>243\</CodeContentPlaceHolder>|The position of the first element to be copied from a hash_map.|  
|<CodeContentPlaceHolder>244\</CodeContentPlaceHolder>|The position just beyond the last element to be copied from a hash_map.|  
  
### Return Value  
 The first **insert** member function returns a pair whose bool component returns true if an insertion was made and false if the hash_map already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
 To access the iterator component of a pair <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>. **first**, and to dereference it, use \*( <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>. **first**). To access the <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> component of a pair <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>. **second**, and to dereference it, use \*( <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>. **second**).  
  
 The second **insert** member function, the hint version, returns an iterator that points to the position where the new element was inserted into the hash_map.  
  
 The last two **insert** member functions behave the same as the first two, except that they move construct the inserted value.  
  
### Remarks  
 The [value_type](../vs140/map-class.md#map__value_type) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 Insertion can occur in amortized constant time for the hint version of insert, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>.  
  
 The third member function inserts the sequence of element values into a hash_map corresponding to each element addressed by an iterator of in the range                         *[First, Last)* of a specified set.  
  
### Example  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  **The original elements (Key => Value) of hm1 are:**  
 **1 => 10**  
 **2 => 20**  
 **3 => 30**  
 **4 => 40**  
**The element 10 already exists in hm1**  
 **with a key value of((pr.first) -> first)= 1.**  
**After the insertions, the elements of hm1 are:**  
 **1 => 10**  
 **2 => 20**  
 **3 => 30**  
 **4 => 40**  
 **5 => 50**  
**After the insertions, the elements of hm2 are:**  
 **2 => 20**  
 **10 => 100**  
 **3 => 30**  
 **4 => 40**  
**After the move insertion, hm3 contains:**  
 **1 => a**  
**After the move insertion, hm4 contains:**  
 **2 => b**    
##  \<a name="hash_map__iterator">\</a>  hash_map::iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify any element in a hash_map.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 The **iterator** defined by hash_map points to elements that are objects of [value_type](#hash_map__value_type), that is of type **pair\<const Key, Type>,** whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference an **iterator**<CodeContentPlaceHolder>253\</CodeContentPlaceHolder> pointing to an element in a multimap, use the  **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>). **first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>). **second**.  
  
 A type **iterator** can be used to modify the value of an element.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [begin](#hash_map__begin) for an example of how to declare and use the **iterator**.  
  
##  \<a name="hash_map__key_comp">\</a>  hash_map::key_comp  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Retrieves a copy of the comparison object used to order keys in a hash_map.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
 Returns the function object that a hash_map uses to order its elements.  
  
### Remarks  
 The stored object defines the member function  
  
 **bool operator**( **const Key&** <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>**, const Key&** <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>);  
  
 that returns **true** if <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> in the sort order.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
##  \<a name="hash_map__key_compare">\</a>  hash_map::key_compare  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the map.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> see the [hash_map Class](../vs140/hash_map-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [key_comp](#hash_map__key_comp) for an example of how to declare and use <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_map__key_type">\</a>  hash_map::key_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type describes the sort key object that constitutes each element of the hash_map.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>, see the Remarks section of the [hash_map Class](../vs140/hash_map-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [value_type](#hash_map__value_type) for an example of how to declare and use <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_map__lower_bound">\</a>  hash_map::lower_bound  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator to the first element in a hash_map with a key value that is equal to or greater than that of a specified key.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
 The argument key value to be compared with the sort key of an element from the hash_map being searched.  
  
### Return Value  
 An [iterator](#hash_map__iterator) or [const_iterator](#hash_map__const_iterator) that addresses the location of an element in a hash_map that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the hash_map if no match is found for the key.  
  
 If the return value of <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>, the hash_map object cannot be modified. If the return value of <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> is assigned to a **iterator**, the hash_map object can be modified.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  **The first element of hash_map hm1 with a key of 2 is: 20.**  
**The hash_map hm1 doesn't have an element with a key of 4.**  
**The element of hm1 with a key matching that of the last element is: 30.**    
##  \<a name="hash_map__mapped_type">\</a>  hash_map::mapped_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that represents the data type stored in a hash_map.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Remarks  
 The type <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> see the [hash_map Class](../vs140/hash_map-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [value_type](#hash_map__value_type) for an example of how to declare and use <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_map__max_size">\</a>  hash_map::max_size  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns the maximum length of the hash_map.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 The maximum possible length of the hash_map.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
##  \<a name="hash_map__operator_at">\</a>  hash_map::operator[]  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Inserts an element into a <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> with a specified key value.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>279\</CodeContentPlaceHolder>|The key value of the element that is to be inserted.|  
  
### Return Value  
 A reference to the data value of the inserted element.  
  
### Remarks  
 If the argument key value is not found, then it is inserted along with the default value of the data type.  
  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> may be used to insert elements into a <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> using  
  
 <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>;  
  
 where DataValue is the value of the <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> of the element with a key value of <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>.  
  
 When using <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> to insert elements, the returned reference does not indicate whether an insertion is changing a preexisting element or creating a new one. The member functions [find](../vs140/map-class.md#map__find) and [insert](../vs140/map-class.md#map__insert) can be used to determine whether an element with a specified key is already present before an insertion.  
  
### Example  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
##  \<a name="hash_map__operator_eq">\</a>  hash_map::operator=  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Replaces the elements of the hash_map with a copy of another hash_map.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>286\</CodeContentPlaceHolder>|The [hash_map Class](../vs140/hash_map-class.md) being copied into the <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>.|  
  
### Remarks  
 After erasing any existing elements in a <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> either copies or moves the contents of <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
##  \<a name="hash_map__pointer">\</a>  hash_map::pointer  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a pointer to an element in a hash_map.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Remarks  
 A type **pointer** can be used to modify the value of an element.  
  
 In most cases, an [iterator](#hash_map__iterator) should be used to access the elements in a hash_map object.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
##  \<a name="hash_map__rbegin">\</a>  hash_map::rbegin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator addressing the first element in a reversed hash_map.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed hash_map or addressing what had been the last element in the unreversed hash_map.  
  
### Remarks  
 <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> is used with a reversed hash_map just as [begin](#hash_map__begin) is used with a hash_map.  
  
 If the return value of <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> is assigned to a [const_reverse_iterator](#hash_map__const_reverse_iterator), then the hash_map object cannot be modified. If the return value of <CodeContentPlaceHolder>294\</CodeContentPlaceHolder> is assigned to a [reverse_iterator](#hash_map__reverse_iterator), then the hash_map object can be modified.  
  
 <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> can be used to iterate through a hash_map backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  **The first element of the reversed hash_map hm1 is 3.**  
**The hash_map is: 1 2 3 .**  
**The reversed hash_map is: 3 2 1 .**  
**After the erasure, the first element in the reversed hash_map is 2.**    
##  \<a name="hash_map__reference">\</a>  hash_map::reference  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a reference to an element stored in a hash_map.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  **The key of first element in the hash_map is 1.**  
**The data value of first element in the hash_map is 10.**  
**The modified data value of first element is 15.**    
##  \<a name="hash_map__rend">\</a>  hash_map::rend  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a reversed hash_map.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed hash_map (the location that had preceded the first element in the unreversed hash_map).  
  
### Remarks  
 <CodeContentPlaceHolder>296\</CodeContentPlaceHolder> is used with a reversed hash_map just as [end](#hash_map__end) is used with a hash_map.  
  
 If the return value of <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> is assigned to a [const_reverse_iterator](#hash_map__const_reverse_iterator), then the hash_map object cannot be modified. If the return value of <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> is assigned to a [reverse_iterator](#hash_map__reverse_iterator), then the hash_map object can be modified.  
  
 <CodeContentPlaceHolder>299\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its hash_map.  
  
 The value returned by <CodeContentPlaceHolder>300\</CodeContentPlaceHolder> should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  **The last element of the reversed hash_map hm1 is 1.**  
**The hash_map is: 1 2 3 .**  
**The reversed hash_map is: 3 2 1 .**  
**After the erasure, the last element in the reversed hash_map is 2.**    
##  \<a name="hash_map__reverse_iterator">\</a>  hash_map::reverse_iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify an element in a reversed hash_map.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> cannot modify the value of an element and is use to iterate through the hash_map in reverse.  
  
 The <CodeContentPlaceHolder>302\</CodeContentPlaceHolder> defined by hash_map points to elements that are objects of [value_type](#hash_map__value_type), that is of type **pair\<const Key, Type>**, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference a <CodeContentPlaceHolder>303\</CodeContentPlaceHolder> pointing to an element in a hash_map, use the -> operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>). **first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>). **first**.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [rbegin](#hash_map__rbegin) for an example of how to declare and use <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_map__size">\</a>  hash_map::size  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns the number of elements in the hash_map.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the hash_map.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  The following example demonstrates the use of the hash_map::size member function.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  **The hash_map length is 1.**  
**The hash_map length is now 2.**    
##  \<a name="hash_map__size_type">\</a>  hash_map::size_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 An unsigned integer type that can represent the number of elements in a hash_map.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [size](#hash_map__size) for an example of how to declare and use <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
  
##  \<a name="hash_map__swap">\</a>  hash_map::swap  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Exchanges the elements of two hash_maps.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>  
 The argument hash_map providing the elements to be swapped with the target hash_map.  
  
### Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two hash_maps whose elements are being exchanged.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  **The original hash_map hm1 is: 10 20 30.**  
**After swapping with hm2, hash_map hm1 is: 100 200.**  
**After swapping with hm3, hash_map hm1 is: 300.**    
##  \<a name="hash_map__upper_bound">\</a>  hash_map::upper_bound  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator to the first element in a hash_map that with a key having a value that is greater than that of a specified key.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>  
 The argument key value to be compared with the sort key value of an element from the hash_map being searched.  
  
### Return Value  
 An [iterator](#hash_map__iterator) or [const_iterator](#hash_map__const_iterator) that addresses the location of an element in a hash_map that with a key that is greater than the argument key, or that addresses the location succeeding the last element in the hash_map if no match is found for the key.  
  
 If the return value is assigned to a <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>, the hash_map object cannot be modified. If the return value is assigned to an **iterator**, the hash_map object can be modified.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  **The first element of hash_map hm1 with a key greater than 2 is: 30.**  
**The hash_map hm1 doesn't have an element with a key greater than 4.**  
**The 1st element of hm1 with a key greater than that**  
 **of the initial element of hm1 is: 20.**    
##  \<a name="hash_map__value_comp">\</a>  hash_map::value_comp  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a function object that determines the order of elements in a hash_map by comparing their key values.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Return Value  
 Returns the comparison function object that a hash_map uses to order its elements.  
  
### Remarks  
 For a hash_map                         *m*, if two elements                         *e*1                        *(k*1                        *, d*1                        *)* and                         *e*2                        *(k*2                        *, d*2                        *)* are objects of type [value_type](#hash_map__value_type), where                         *k*1 and                         *k*2 are their keys of type [key_type](#hash_map__key_type) and <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>1 and <CodeContentPlaceHolder>314\</CodeContentPlaceHolder>2 are their data of type [mapped_type](#hash_map__mapped_type), then                         *m.*<CodeContentPlaceHolder>315\</CodeContentPlaceHolder>*( )(e*1                        *, e*2                        *)* is equivalent to                         *m.*<CodeContentPlaceHolder>316\</CodeContentPlaceHolder>*( ) (k*1                        *, k*2                        *)*. A stored object defines the member function  
  
 **bool operator**( **value_type&** <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>, **value_type&** <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>) **;**  
  
 which returns **true** if the key value of <CodeContentPlaceHolder>319\</CodeContentPlaceHolder> precedes and is not equal to the key value of <CodeContentPlaceHolder>320\</CodeContentPlaceHolder> in the sort order.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
##  \<a name="hash_map__value_type">\</a>  hash_map::value_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that represents the type of object stored in a hash_map.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> is declared to be <CodeContentPlaceHolder>322\</CodeContentPlaceHolder> *\<***const**[key_type](#hash_map__key_type), [mapped_type](#hash_map__mapped_type)*>* and not <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>**\<key_type, mapped_type>** because the keys of an associative container may not be changed using a nonconstant iterator or reference.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  **The key of first element in the hash_map is 1.**  
**The data value of first element in the hash_map is 10.**  
**The keys of the mapped elements are: 1 2 3.**  
**The values of the mapped elements are: 10 20 30.**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)