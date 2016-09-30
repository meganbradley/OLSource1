---
title: "map Class"
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
  - "std::map"
  - "map/std::map"
  - "map"
  - "std.map"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "map class"
ms.assetid: 7876f4c9-ebb4-4878-af1e-09364c43af0a
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map Class
Used for the storage and retrieval of data from a collection in which each element is a pair that has both a data value and a sort key. The value of the key is unique and is used to automatically sort the data.  
  
 The value of an element in a map can be changed directly. The key value is a constant and cannot be changed. Instead, key values associated with old elements must be deleted, and new key values must be inserted for new elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The key data type to be stored in the map.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The element data type to be stored in the map.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The type that provides a function object that can compare two element values as sort keys to determine their relative order in the map. This argument is optional and the binary predicate <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is the default value.  
  
 In C++14 you can enable heterogeneous lookup by specifying the std::less<> predicate that has no type parameters. For more information, see [Heterogeneous Lookup in Associative Containers](../vs140/stl-containers.md#sequence_containers)  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the map's allocation and deallocation of memory. This argument is optional and the default value is <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>*,* <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
## Remarks  
 The Standard Template Library (STL) map class is:  
  
-   A container of variable size that efficiently retrieves element values based on associated key values.  
  
-   Reversible, because it provides bidirectional iterators to access its elements.  
  
-   Sorted, because its elements are ordered by key values according to a specified comparison function.  
  
-   Unique. because each of its elements must have a unique key.  
  
-   A pair-associative container, because its element data values are distinct from its key values.  
  
-   A template class, because the functionality it provides is generic and independent of element or key type. The data types used for elements and keys are specified as parameters in the class template together with the comparison function and allocator.  
  
 The iterator provided by the map class is a bidirectional iterator, but the [insert](#map__insert) and [map](#map__map) class member functions have versions that take as template parameters a weaker input iterator, whose functionality requirements are fewer than those guaranteed by the class of bidirectional iterators. The different iterator concepts are related by refinements in their functionality. Each iterator concept has its own set of requirements, and the algorithms that work with it must be limited by those requirements. An input iterator may be dereferenced to refer to some object and may be incremented to the next iterator in the sequence.  
  
 We recommend that you base the choice of container type on the kind of searching and inserting that is required by the application. Associative containers are optimized for the operations of lookup, insertion, and removal. The member functions that explicitly support these operations perform them in a worst-case time that is proportional to the logarithm of the number of elements in the container. Inserting elements invalidates no iterators, and removing elements invalidates only those iterators that specifically pointed to the removed elements.  
  
 We recommend that you make the map the associative container of choice when conditions that associate values with keys are satisfied by the application. A model for this kind of structure is an ordered list of uniquely occurring key words that have associated string values that provide definitions. If a word has more than one correct definition, so that key is not unique, then a multimap would be the container of choice. If just the list of words is being stored, then a set would be the appropriate container. If multiple occurrences of the words are allowed, then a multiset would be appropriate.  
  
 The map orders the elements it controls by calling a stored function object of type [key_compare](#map__key_compare). This stored object is a comparison function that is accessed by calling the [key_comp](#map__key_comp) method. In general, any two given elements are compared to determine whether one is less than the other or whether they are equivalent. As all elements are compared, an ordered sequence of non-equivalent elements is created.  
  
> [!NOTE]
>  The comparison function is a binary predicate that induces a strict weak ordering in the standard mathematical sense. A binary predicate                     f(x,y) is a function object that has two argument objects                     x and                     y, and a return value of <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>. An ordering imposed on a set is a strict weak ordering if the binary predicate is irreflexive, antisymmetric, and transitive, and if equivalence is transitive, where two objects                     x and                     y are defined to be equivalent when both                     f(x,y)and                     f(y,x) are <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>. If the stronger condition of equality between keys replaces that of equivalence, the ordering becomes total (in the sense that all the elements are ordered with regard to one other), and the keys matched will be indiscernible from one other.  
>   
>  In C++14 you can enable heterogeneous lookup by specifying the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> predicate that has no type parameters. For more information, see [Heterogeneous Lookup in Associative Containers](../vs140/stl-containers.md#sequence_containers)  
  
## Members  
  
### Constructors  
  
|||  
|-|-|  
|[map](#map__map)|Constructs a list of a specific size or with elements of a specific value or with a specific <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> or as a copy of some other map.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#map__allocator_type)|A typedef for the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> class for the map object.|  
|[const_iterator](#map__const_iterator)|A typedef for a bidirectional iterator that can read a <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> element in the map.|  
|[const_pointer](#map__const_pointer)|A typedef for a pointer to a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> element in a map.|  
|[const_reference](#map__const_reference)|A typedef for a reference to a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> element stored in a map for reading and performing <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> operations.|  
|[const_reverse_iterator](#map__const_reverse_iterator)|A type that provides a bidirectional iterator that can read any <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> element in the map.|  
|[difference_type](#map__difference_type)|A signed integer typedef for the number of elements of a map in a range between elements pointed to by iterators.|  
|[iterator](#map__iterator)|A typedef for a bidirectional iterator that can read or modify any element in a map.|  
|[key_compare](#map__key_compare)|A typedef for a function object that can compare two sort keys to determine the relative order of two elements in the map.|  
|[key_type](#map__key_type)|A typedef for the sort key stored in each element of the map.|  
|[mapped_type](#map__mapped_type)|A typedef for the data stored in each element of a map.|  
|[pointer](#map__pointer)|A typedef for a pointer to a <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> element in a map.|  
|[reference](#map__reference)|A typedef for a reference to an element stored in a map.|  
|[reverse_iterator](#map__reverse_iterator)|A typedef for a bidirectional iterator that can read or modify an element in a reversed map.|  
|[size_type](#map__size_type)|An unsigned integer typedef for the number of elements in a map|  
|[value_type](#map__value_type)|A typedef for the type of object stored as an element in a map.|  
  
### Member Functions  
  
|||  
|-|-|  
|[at](#map__at)|Finds an element with a specified key value.|  
|[begin](#map__begin)|Returns an iterator that points to the first element in the map.|  
|[cbegin](#map__cbegin)|Returns a const iterator that points to the first element in the map.|  
|[cend](#map__cend)|Returns a const past-the-end iterator.|  
|[clear](#map__clear)|Erases all the elements of a map.|  
|[count](#map__count)|Returns the number of elements in a map whose key matches the key specified in a parameter.|  
|[crbegin](#map__crbegin)|Returns a const iterator that points to the first element in a reversed map.|  
|[crend](#map__crend)|Returns a const iterator that points to the location after the last element in a reversed map.|  
|[emplace](#map__emplace)|Inserts an element constructed in place into the map.|  
|[emplace_hint](#map__emplace_hint)|Inserts an element constructed in place into the map, with a placement hint.|  
|[empty](#map__empty)|Returns <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> if a map is empty.|  
|[end](#map__end)|Returns the past-the-end iterator.|  
|[equal_range](#map__equal_range)|Returns a pair of iterators. The first iterator in the pair points to the first element in a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> with a key that is greater than a specified key. The second iterator in the pair points to the first element in the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> with a key that is equal to or greater than the key.|  
|[erase](#map__erase)|Removes an element or a range of elements in a map from the specified positions.|  
|[find](#map__find)|Returns an iterator that points to the location of an element in a map that has a key equal to a specified key.|  
|[get_allocator](#map__get_allocator)|Returns a copy of the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object that is used to construct the map.|  
|[insert](#map__insert)|Inserts an element or a range of elements into the map at a specified position.|  
|[key_comp](#map__key_comp)|Returns a copy of the comparison object that used to order keys in a map.|  
|[lower_bound](#map__lower_bound)|Returns an iterator to the first element in a map that has a key value that is equal to or greater than that of a specified key.|  
|[max_size](#map__max_size)|Returns the maximum length of the map.|  
|[rbegin](#map__rbegin)|Returns an iterator that points to the first element in a reversed map.|  
|[rend](#map__rend)|Returns an iterator that points to the location after the last element in a reversed map.|  
|[size](#map__size)|Returns the number of elements in the map.|  
|[swap](#map__swap)|Exchanges the elements of two maps.|  
|[upper_bound](#map__upper_bound)|Returns an iterator to the first element in a map that has a key value that is greater than that of a specified key.|  
|[value_comp](#map__value_comp)|Retrieves a copy of the comparison object that is used to order element values in a map.|  
  
### Operators  
  
|||  
|-|-|  
|[operator&#91;&#93;](#map__operator_at)|Inserts an element into a map with a specified key value.|  
|[operator=](#map__operator_eq)|Replaces the elements of a map with a copy of another map.|  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
##  \<a name="map__allocator_type">\</a>  map::allocator_type  
 A type that represents the allocator class for the map object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Example  
  See example for [get_allocator](#map__get_allocator) for an example that uses <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
##  \<a name="map__at">\</a>  map::at  
 Finds an element with a specified key value.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|The key value to find.|  
  
### Return Value  
 A reference to the data value of the element found.  
  
### Remarks  
 If the argument key value is not found, then the function throws an object of class [out_of_range Class](../vs140/out_of_range-class.md).  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="map__begin">\</a>  map::begin  
 Returns an iterator addressing the first element in the map.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator addressing the first element in the map or the location succeeding an empty map.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The first element of m1 is 0**  
**The first element of m1 is now 1**    
##  \<a name="map__cbegin">\</a>  map::cbegin  
 Returns a <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> bidirectional iterator addressing the first element in the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="map__cend">\</a>  map::cend  
 Returns a <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> bidirectional-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="map__clear">\</a>  map::clear  
 Erases all the elements of a map.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Example  
  The following example demonstrates the use of the map::clear member function.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **The size of the map is initially 2.**  
**The size of the map after clearing is 0.**    
##  \<a name="map__const_iterator">\</a>  map::const_iterator  
 A type that provides a bidirectional iterator that can read a **const** element in the map.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 The <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> defined by map points to elements that are objects of [value_type](#map__value_type), that is of type <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>\< **constKey**, **Type**>, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference a <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> pointing to an element in a map, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>). **first**.  
  
 To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>).  **second**.  
  
### Example  
  See example for [begin](#map__begin) for an example that uses <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
##  \<a name="map__const_pointer">\</a>  map::const_pointer  
 A type that provides a pointer to a **const** element in a map.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 In most cases, an [iterator](#map__iterator) should be used to access the elements in a map object.  
  
##  \<a name="map__const_reference">\</a>  map::const_reference  
 A type that provides a reference to a **const** element stored in a map for reading and performing **const** operations.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **The key of first element in the map is 1.**  
**The data value of first element in the map is 10.**    
##  \<a name="map__const_reverse_iterator">\</a>  map::const_reverse_iterator  
 A type that provides a bidirectional iterator that can read any **const** element in the map.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> cannot modify the value of an element and is use to iterate through the map in reverse.  
  
 The <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> defined by map points to elements that are objects of [value_type](#map__value_type), that is of type <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>*\<***constKey***,* **Type***>*, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference a <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> pointing to an element in a map, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>). **first**.  
  
 To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>). **first**.  
  
### Example  
  See the example for [rend](#map__rend) for an example of how to declare and use <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
##  \<a name="map__count">\</a>  map::count  
 Returns the number of elements in a map whose key matches a parameter-specified key.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 The key value of the elements to be matched from the map.  
  
### Return Value  
 1 if the map contains an element whose sort key matches the parameter key; 0 if the map does not contain an element with a matching key.  
  
### Remarks  
 The member function returns the number of elements                         *x* in the range  
  
 [ <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> (_                        *Key* ), <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> (\_                        *Key* ) )  
  
 which is 0 or 1 in the case of map, which is a unique associative container.  
  
### Example  
  The following example demonstrates the use of the map::count member function.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The number of elements in m1 with a sort key of 1 is: 1.**  
**The number of elements in m1 with a sort key of 2 is: 1.**  
**The number of elements in m1 with a sort key of 3 is: 0.**    
##  \<a name="map__crbegin">\</a>  map::crbegin  
 Returns a const iterator addressing the first element in a reversed map.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [map](../vs140/map-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> just as [begin](#map__begin) is used with a <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> object cannot be modified  
  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> can be used to iterate through a <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> backwards.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **The first element of the reversed map m1 is 3.**    
##  \<a name="map__crend">\</a>  map::crend  
 Returns a const iterator that addresses the location succeeding the last element in a reversed map.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [map](../vs140/map-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>).  
  
### Remarks  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> is used with a reversed map just as [end](#map__end) is used with a <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>.  
  
 The value returned by <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The last element of the reversed map m1 is 1.**    
##  \<a name="map__difference_type">\</a>  map::difference_type  
 A signed integer type that can be used to represent the number of elements of a map in a range between elements pointed to by iterators.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> is the type returned when subtracting or incrementing through iterators of the container. The <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> is typically used to represent the number of elements in the range                         *[_First, _Last)* between the iterators <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>, includes the element pointed to by <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> and the range of elements up to, but not including, the element pointed to by <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
 Note that although <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers such as set, subtraction between iterators is only supported by random access iterators provided by a random access container such as vector.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **The number of elements in the map m1 is: 4.**    
##  \<a name="map__emplace">\</a>  map::emplace  
 Inserts an element constructed in place (no copy or move operations are performed) into a map.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>168\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the map unless it already contains an element whose value is equivalently ordered.|  
  
### Return Value  
 A [pair](../vs140/pair-structure.md) whose <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> component is true if an insertion was made, and false if the map already contained an element of equivalent value in the ordering. The iterator component of the return-value pair points to the newly inserted element if the <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> component is true, or to the existing element if the <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> component is false.  
  
 To access the iterator component of a <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>, use <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>; to dereference it, use <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>. To access the <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> component, use <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>. For an example, see the sample code later in this article.  
  
### Remarks  
 No iterators or references are invalidated by this function.  
  
 During emplacement, if an exception is thrown, the container's state is not modified.  
  
 The [value_type](#map__value_type) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
##  \<a name="map__emplace_hint">\</a>  map::emplace_hint  
 Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>177\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the map unless the map already contains that element or, more generally, unless it already contains an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>178\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (If that point immediately precedes <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>, insertion can occur in amortized constant time instead of logarithmic time.)|  
  
### Return Value  
 An iterator to the newly inserted element.  
  
 If the insertion failed because the element already exists, returns an iterator to the existing element with its key.  
  
### Remarks  
 No iterators or references are invalidated by this function.  
  
 During emplacement, if an exception is thrown, the container's state is not modified.  
  
 The [value_type](#map__value_type) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
##  \<a name="map__empty">\</a>  map::empty  
 Tests if a map is empty.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the map is empty; **false** if the map is nonempty.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **The map m1 is not empty.**  
**The map m2 is empty.**    
##  \<a name="map__end">\</a>  map::end  
 Returns the past-the-end iterator.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 The past-the-end iterator. If the map is empty, then <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>.  
  
### Remarks  
 **end** is used to test whether an iterator has passed the end of its map.  
  
 The value returned by **end** should not be dereferenced.  
  
 For a code example, see [map::find](#map__find).  
  
##  \<a name="map__equal_range">\</a>  map::equal_range  
 Returns a pair of iterators that represent the [lower_bound](#map__lower_bound) of the key and the [upper_bound](#map__upper_bound) of the key.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 The argument key value to be compared with the sort key of an element from the map being searched.  
  
### Return Value  
 To access the first iterator of a pair <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>. **first**, and to dereference the lower bound iterator, use \*( <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>. **first**). To access the second iterator of a pair <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>. **second**, and to dereference the upper bound iterator, use \*( <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>. **second**).  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  **The lower bound of the element with a key of 2 in the map m1 is: 20.**  
**The upper bound of the element with a key of 2 in the map m1 is: 30.**  
**A direct call of upper_bound( 2 ) gives 30,**  
 **matching the 2nd element of the pair returned by equal_range( 2 ).**  
**The map m1 doesn't have an element with a key less than 40.**    
##  \<a name="map__erase">\</a>  map::erase  
 Removes an element or a range of elements in a map from specified positions or removes elements that match a specified key.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 Position of the element to be removed.  
  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 Position of the first element to be removed.  
  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 Position just beyond the last element to be removed.  
  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 The key value of the elements to be removed.  
  
### Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the map if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the map.  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
##  \<a name="map__find">\</a>  map::find  
 Returns an iterator that refers to the location of an element in a map that has a key equivalent to a specified key.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 The key value to be matched by the sort key of an element from the map being searched.  
  
### Return Value  
 An iterator that refers to the location of an element with a specified key, or the location succeeding the last element in the map ( <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>) if no match is found for the key.  
  
### Remarks  
 The member function returns an iterator that refers to an element in the map whose sort key is equivalent to the argument key under a binary predicate that induces an ordering based on a less than comparability relation.  
  
 If the return value of **find** is assigned to a **const_iterator**, the map object cannot be modified. If the return value of **find** is assigned to an **iterator**, the map object can be modified  
  
### Example  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
##  \<a name="map__get_allocator">\</a>  map::get_allocator  
 Returns a copy of the allocator object used to construct the map.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Return Value  
 The allocator used by the map.  
  
### Remarks  
 Allocators for the map class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
### Example  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
##  \<a name="map__insert">\</a>  map::insert  
 Inserts an element or a range of elements into a map.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>194\</CodeContentPlaceHolder>|The value of an element to be inserted into the map unless it already contains an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>195\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (If that point immediately precedes <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>, insertion can occur in amortized constant time instead of logarithmic time.)|  
|<CodeContentPlaceHolder>197\</CodeContentPlaceHolder>|Template parameter that specifies the argument type that the map can use to construct an element of [value_type](#map__value_type), and perfect-forwards <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> as an argument.|  
|<CodeContentPlaceHolder>199\</CodeContentPlaceHolder>|The position of the first element to be copied.|  
|<CodeContentPlaceHolder>200\</CodeContentPlaceHolder>|The position just beyond the last element to be copied.|  
|<CodeContentPlaceHolder>201\</CodeContentPlaceHolder>|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](#map__value_type) objects.|  
|<CodeContentPlaceHolder>202\</CodeContentPlaceHolder>|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
### Return Value  
 The single-element member functions, (1) and (2), return a [pair](../vs140/pair-structure.md) whose <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> component is true if an insertion was made, and false if the map already contained an element whose key had an equivalent value in the ordering. The iterator component of the return-value pair points to the newly inserted element if the <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> component is true, or to the existing element if the <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> component is false.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the map or, if an element with an equivalent key already exists, to the existing element.  
  
### Remarks  
 No iterators, pointers, or references are invalidated by this function.  
  
 During the insertion of just one element, if an exception is thrown, the container's state is not modified. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 To access the iterator component of a <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> that's returned by the single-element member functions, use <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>; to dereference the iterator within the returned pair, use <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>, giving you an element. To access the <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> component, use <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>. For an example, see the sample code later in this article.  
  
 The [value_type](#map__value_type) of a container is a typedef that belongs to the container, and for map, <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>. The value of an element is an ordered pair in which the first component is equal to the key value and the second component is equal to the data value of the element.  
  
 The range member function (5) inserts the sequence of element values into a map that corresponds to each element addressed by an iterator in the range <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>; therefore, <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> does not get inserted. The container member function <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> refers to the position just after the last element in the container—for example, the statement <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> attempts to insert all elements of <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>. Only elements that have unique values in the range are inserted; duplicates are ignored. To observe which elements are rejected, use the single-element versions of <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the map.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [map::emplace](#map__emplace) and [map::emplace_hint](#map__emplace_hint).  
  
### Example  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
##  \<a name="map__iterator">\</a>  map::iterator  
 A type that provides a bidirectional iterator that can read or modify any element in a map.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Remarks  
 The **iterator** defined by map points to elements that are objects of [value_type](#map__value_type), that is of type <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>*\<***constKey**, **Type***>*, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference an **iterator**<CodeContentPlaceHolder>221\</CodeContentPlaceHolder> pointing to an element in a map, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>). **first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>). **second**.  
  
### Example  
  See example for [begin](#map__begin) for an example of how to declare and use **iterator**.  
  
##  \<a name="map__key_comp">\</a>  map::key_comp  
 Retrieves a copy of the comparison object used to order keys in a map.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 Returns the function object that a map uses to order its elements.  
  
### Remarks  
 The stored object defines the member function  
  
 **bool operator**( **constKey&**<CodeContentPlaceHolder>226\</CodeContentPlaceHolder>, **const Key&**<CodeContentPlaceHolder>227\</CodeContentPlaceHolder>);  
  
 which returns **true** if <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> in the sort order.  
  
### Example  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  **kc1( 2,3 ) returns value of true, where kc1 is the function object of m1.**  
**kc2( 2,3 ) returns value of false, where kc2 is the function object of m2.**    
##  \<a name="map__key_compare">\</a>  map::key_compare  
 A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the map.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> see the [map Class](../vs140/map-class.md) topic.  
  
### Example  
  See example for [key_comp](#map__key_comp) for an example of how to declare and use <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>.  
  
##  \<a name="map__key_type">\</a>  map::key_type  
 A type that describes the sort key stored in each element of the map.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>, see the Remarks section of the [map Class](../vs140/map-class.md) topic.  
  
### Example  
  See example for [value_type](#map__value_type) for an example of how to declare and use <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>.  
  
##  \<a name="map__lower_bound">\</a>  map::lower_bound  
 Returns an iterator to the first element in a map with a key value that is equal to or greater than that of a specified key.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 The argument key value to be compared with the sort key of an element from the map being searched.  
  
### Return Value  
 An **iterator** or <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> that addresses the location of an element in a map that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the map if no match is found for the key.  
  
 If the return value of <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>, the map object cannot be modified. If the return value of <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> is assigned to an **iterator**, the map object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  **The first element of map m1 with a key of 2 is: 20.**  
**The map m1 doesn't have an element with a key of 4.**  
**The element of m1 with a key matching that of the last element is: 30.**    
##  \<a name="map__map">\</a>  map::map  
 Constructs a map that is empty or that is a copy of all or part of some other map.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>243\</CodeContentPlaceHolder>|The storage allocator class to be used for this map object, which defaults to <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>245\</CodeContentPlaceHolder>|The comparison function of type <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> used to order the elements in the map, which defaults to <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>248\</CodeContentPlaceHolder>|The map of which the constructed set is to be a copy.|  
|<CodeContentPlaceHolder>249\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>250\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>251\</CodeContentPlaceHolder>|The initializer_list from which the elements are to be copied.|  
  
### Remarks  
 All constructors store a type of allocator object that manages memory storage for the map and that can later be returned by calling [get_allocator](#map__get_allocator). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their map.  
  
 All constructors store a function object of type Traits that is used to establish an order among the keys of the map and that can later be returned by calling [key_comp](#map__key_comp).  
  
 The first three constructors specify an empty initial map, the second specifying the type of comparison function ( <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifying the allocator type ( <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>) to be used. The key word <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the map <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>.  
  
 The fifth constructor specifies a copy of the map by moving <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>.  
  
 The sixth, seventh, and eighth constructors use an initializer_list from which to copy the members.  
  
 The next three constructors copy the range <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> of a map with increasing explicitness in specifying the type of comparison function of class <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> and allocator.  
  
### Example  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
##  \<a name="map__mapped_type">\</a>  map::mapped_type  
 A type that represents the data stored in a map.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Remarks  
 The type <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> is a synonym for the class's <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> template parameter.  
  
 For more information on <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> see the [map Class](../vs140/map-class.md) topic.  
  
### Example  
  See example for [value_type](#map__value_type) for an example of how to declare and use <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>.  
  
##  \<a name="map__max_size">\</a>  map::max_size  
 Returns the maximum length of the map.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 The maximum possible length of the map.  
  
### Example  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
##  \<a name="map__operator_at">\</a>  map::operator[]  
 Inserts an element into a map with a specified key value.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>263\</CodeContentPlaceHolder>|The key value of the element that is to be inserted.|  
  
### Return Value  
 A reference to the data value of the inserted element.  
  
### Remarks  
 If the argument key value is not found, then it is inserted along with the default value of the data type.  
  
 <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> may be used to insert elements into a map <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> using <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> is the value of the <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> of the element with a key value of <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>.  
  
 When using <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> to insert elements, the returned reference does not indicate whether an insertion is changing a pre-existing element or creating a new one. The member functions [find](#map__find) and [insert](#map__insert) can be used to determine whether an element with a specified key is already present before an insertion.  
  
### Example  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  **The keys of the mapped elements are: 1 2 3.**  
**The values of the mapped elements are: 10 20 30.**  
**The keys of the mapped elements are now: 1 2 3 5.**  
**The values of the mapped elements are now: 10 40 30 0.**  
**c2[move(str)] == 0**  
**c2["abc"] == 1**    
##  \<a name="map__operator_eq">\</a>  map::operator=  
 Replaces the elements of a map with a copy of another map.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>271\</CodeContentPlaceHolder>|The [map](../vs140/map-class.md) being copied into the <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>.|  
  
### Remarks  
 After erasing any existing elements in a <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> either copies or moves the contents of <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> into the map.  
  
### Example  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
##  \<a name="map__pointer">\</a>  map::pointer  
 A type that provides a pointer to an element in a map.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Remarks  
 A type **pointer** can be used to modify the value of an element.  
  
 In most cases, an [iterator](#map__iterator) should be used to access the elements in a map object.  
  
##  \<a name="map__rbegin">\</a>  map::rbegin  
 Returns an iterator addressing the first element in a reversed map.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed map or addressing what had been the last element in the unreversed map.  
  
### Remarks  
 <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> is used with a reversed map just as [begin](#map__begin) is used with a map.  
  
 If the return value of <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>, then the map object cannot be modified. If the return value of <CodeContentPlaceHolder>279\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>, then the map object can be modified.  
  
 <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> can be used to iterate through a map backwards.  
  
### Example  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  **The first element of the reversed map m1 is 3.**  
**The map is: 1 2 3 .**  
**The reversed map is: 3 2 1 .**  
**After the erasure, the first element in the reversed map is 2.**    
##  \<a name="map__reference">\</a>  map::reference  
 A type that provides a reference to an element stored in a map.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  **The key of first element in the map is 1.**  
**The data value of first element in the map is 10.**  
**The modified data value of first element is 15.**    
##  \<a name="map__rend">\</a>  map::rend  
 Returns an iterator that addresses the location succeeding the last element in a reversed map.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed map (the location that had preceded the first element in the unreversed map).  
  
### Remarks  
 <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> is used with a reversed map just as [end](#map__end) is used with a map.  
  
 If the return value of <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>, then the map object cannot be modified. If the return value of <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>, then the map object can be modified.  
  
 <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its map.  
  
 The value returned by <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  **The last element of the reversed map m1 is 1.**  
**The map is: 1 2 3 .**  
**The reversed map is: 3 2 1 .**  
**After the erasure, the last element in the reversed map is 2.**    
##  \<a name="map__reverse_iterator">\</a>  map::reverse_iterator  
 A type that provides a bidirectional iterator that can read or modify an element in a reversed map.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> cannot modify the value of an element and is use to iterate through the map in reverse.  
  
 The <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> defined by map points to elements that are objects of [value_type](#map__value_type), that is of type <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>*\<***constKey**, **Type***>*, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference a <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> pointing to an element in a map, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>). **first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>). **first**.  
  
### Example  
  See example for [rbegin](#map__rbegin) for an example of how to declare and use <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>.  
  
##  \<a name="map__size">\</a>  map::size  
 Returns the number of elements in the map.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the map.  
  
### Example  
  The following example demonstrates the use of the map::size member function.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  **The map length is 1.**  
**The map length is now 2.**    
##  \<a name="map__size_type">\</a>  map::size_type  
 An unsigned integer type that can represent the number of elements in a map.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Example  
  See the example for [size](#map__size) for an example of how to declare and use <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>.  
  
##  \<a name="map__swap">\</a>  map::swap  
 Exchanges the elements of two maps.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
 The argument map providing the elements to be swapped with the target map.  
  
### Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two maps whose elements are being exchanged.  
  
### Example  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  **The original map m1 is: 10 20 30.**  
**After swapping with m2, map m1 is: 100 200.**  
**After swapping with m3, map m1 is: 300.**    
##  \<a name="map__upper_bound">\</a>  map::upper_bound  
 Returns an iterator to the first element in a map that with a key having a value that is greater than that of a specified key.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 The argument key value to be compared with the sort key value of an element from the map being searched.  
  
### Return Value  
 An **iterator** or <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> that addresses the location of an element in a map that with a key that is greater than the argument key, or that addresses the location succeeding the last element in the map if no match is found for the key.  
  
 If the return value is assigned to a <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>, the map object cannot be modified. If the return value is assigned to a **iterator**, the map object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  **The first element of map m1 with a key greater than 2 is: 30.**  
**The map m1 doesn't have an element with a key greater than 4.**  
**The 1st element of m1 with a key greater than**  
**that of the initial element of m1 is: 20.**    
##  \<a name="map__value_comp">\</a>  map::value_comp  
 The member function returns a function object that determines the order of elements in a map by comparing their key values.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Return Value  
 Returns the comparison function object that a map uses to order its elements.  
  
### Remarks  
 For a map                         *m*, if two elements                         *e*1(                        *k*1,                         *d*1) and                         *e*2(                        *k*2, <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>2) are objects of type <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>, where                         *k*1 and                         *k*2 are their keys of type <CodeContentPlaceHolder>305\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>1 and <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>2 are their data of type <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>, then                         *m.*<CodeContentPlaceHolder>309\</CodeContentPlaceHolder>(                        *e*1,                         *e*2) is equivalent to                         *m.*<CodeContentPlaceHolder>310\</CodeContentPlaceHolder>*(k*1,                         *k*2). A stored object defines the member function  
  
 **bool operator**( **value_type&**<CodeContentPlaceHolder>311\</CodeContentPlaceHolder>, **value_type&**<CodeContentPlaceHolder>312\</CodeContentPlaceHolder>);  
  
 which returns **true** if the key value of <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> precedes and is not equal to the key value of <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> in the sort order.  
  
### Example  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  **The element ( 1,10 ) precedes the element ( 2,5 ).**  
**The element ( 2,5 ) does not precede the element ( 1,10 ).**    
##  \<a name="map__value_type">\</a>  map::value_type  
 The type of object stored as an element in a map.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
## See Also  
 [\<map> Members](assetId:///7e8f0bc2-6034-40f6-9d14-76d4cef86308)   
 [Containers](../vs140/containers--modern-c---.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)