---
title: "multimap Class"
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
  - "multimap"
  - "std.multimap"
  - "map/std::multimap"
  - "std::multimap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "multimap class"
ms.assetid: 8796ae05-37c4-475a-9e61-75fde9d4a463
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap Class
The Standard Template Library multimap class is used for the storage and retrieval of data from a collection in which the each element is a pair that has both a data value and a sort key. The value of the key does not need to be unique and is used to order the data automatically. The value of an element in a multimap, but not its associated key value, may be changed directly. Instead, key values associated with old elements must be deleted and new key values associated with new elements inserted.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The key data type to be stored in the multimap.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The element data type to be stored in the multimap.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The type that provides a function object that can compare two element values as sort keys to determine their relative order in the multimap. The binary predicate <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> is the default value.  
  
 In C++14 you can enable heterogeneous lookup by specifying the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> predicate that has no type parameters. For more information, see [Heterogeneous Lookup in Associative Containers](../vs140/stl-containers.md#sequence_containers)  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the map's allocation and deallocation of memory. This argument is optional and the default value is <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
## Remarks  
 The STL multimap class is  
  
-   An associative container, which a variable size container that supports the efficient retrieval of element values based on an associated key value.  
  
-   Reversible, because it provides bidirectional iterators to access its elements.  
  
-   Sorted, because its elements are ordered by key values within the container in accordance with a specified comparison function.  
  
-   Multiple, because its elements do not need to have a unique keys, so that one key value may have many element data values associated with it.  
  
-   A pair associative container, because its element data values are distinct from its key values.  
  
-   A template class, because the functionality it provides is generic and so independent of the specific type of data contained as elements or keys. The data types to be used for elements and keys are, instead, specified as parameters in the class template along with the comparison function and allocator.  
  
 The iterator provided by the map class is a bidirectional iterator, but the class member functions [insert](#multimap__insert) and [multimap](#multimap__multimap) have versions that take as template parameters a weaker input iterator, whose functionality requirements are more minimal than those guaranteed by the class of bidirectional iterators. The different iterator concepts form a family related by refinements in their functionality. Each iterator concept has its own set of requirements and the algorithms that work with them must limit their assumptions to the requirements provided by that type of iterator. It may be assumed that an input iterator may be dereferenced to refer to some object and that it may be incremented to the next iterator in the sequence. This is a minimal set of functionality, but it is enough to be able to talk meaningfully about a range of iterators <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> in the context of the class's member functions.  
  
 The choice of container type should be based in general on the type of searching and inserting required by the application. Associative containers are optimized for the operations of lookup, insertion and removal. The member functions that explicitly support these operations are efficient, performing them in a time that is on average proportional to the logarithm of the number of elements in the container. Inserting elements invalidates no iterators, and removing elements invalidates only those iterators that had specifically pointed at the removed elements.  
  
 The multimap should be the associative container of choice when the conditions associating the values with their keys are satisfied by the application. A model for this type of structure is an ordered list of key words with associated string values providing, say, definitions, where the words were not always uniquely defined. If, instead, the key words were uniquely defined so that keys were unique, then a map would be the container of choice. If, on the other hand, just the list of words were being stored, then a set would be the correct container. If multiple occurrences of the words were allowed, then a multiset would be the appropriate container structure.  
  
 The multimap orders the sequence it controls by calling a stored function object of type [key_compare](#multimap__key_compare). This stored object is a comparison function that may be accessed by calling the member function [key_comp](#multimap__key_comp). In general, the elements need be merely less than comparable to establish this order: so that, given any two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. On a more technical note, the comparison function is a binary predicate that induces a strict weak ordering in the standard mathematical sense. A binary predicate <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is a function object that has two argument objects <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> and a return value of true or false. An ordering imposed on a set is a strict weak ordering if the binary predicate is irreflexive, antisymmetric, and transitive and if equivalence is transitive, where two objects <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> are defined to be equivalent when both <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> are false. If the stronger condition of equality between keys replaces that of equivalence, then the ordering becomes total (in the sense that all the elements are ordered with respect to each other) and the keys matched will be indiscernible from each other.  
  
 In C++14 you can enable heterogeneous lookup by specifying the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> predicate that has no type parameters. For more information, see [Heterogeneous Lookup in Associative Containers](../vs140/stl-containers.md#sequence_containers)  
  
## Members  
  
### Constructors  
  
|||  
|-|-|  
|[multimap](#multimap__multimap)|Constructs a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> that is empty or that is a copy of all or part of some other <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#multimap__allocator_type)|A type that represents the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> class for the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object.|  
|[const_iterator](#multimap__const_iterator)|A type that provides a bidirectional iterator that can read a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.|  
|[const_pointer](#multimap__const_pointer)|A type that provides a pointer to a <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.|  
|[const_reference](#multimap__const_reference)|A type that provides a reference to a <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> element stored in a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> for reading and performing <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> operations.|  
|[const_reverse_iterator](#multimap__const_reverse_iterator)|A type that provides a bidirectional iterator that can read any <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.|  
|[difference_type](#multimap__difference_type)|A signed integer type that can be used to represent the number of elements of a <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> in a range between elements pointed to by iterators.|  
|[iterator](#multimap__iterator)|A type that provides the difference between two iterators that refer to elements within the same <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.|  
|[key_compare](#multimap__key_compare)|A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.|  
|[key_type](#multimap__key_type)|A type that describes the sort key object that constitutes each element of the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.|  
|[mapped_type](#multimap__mapped_type)|A type that represents the data type stored in a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.|  
|[pointer](#multimap__pointer)|A type that provides a pointer to a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.|  
|[reference](#multimap__reference)|A type that provides a reference to an element stored in a <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.|  
|[reverse_iterator](#multimap__reverse_iterator)|A type that provides a bidirectional iterator that can read or modify an element in a reversed <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.|  
|[size_type](#multimap__size_type)|An unsigned integer type that provides a pointer to a <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.|  
|[value_type](#multimap__value_type)|A type that provides a function object that can compare two elements as sort keys to determine their relative order in the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[begin](#multimap__begin)|Returns an iterator addressing the first element in the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.|  
|[cbegin](#multimap__cbegin)|Returns a const iterator addressing the first element in the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.|  
|[cend](#multimap__cend)|Returns a const iterator that addresses the location succeeding the last element in a <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.|  
|[clear](#multimap__clear)|Erases all the elements of a <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.|  
|[count](#multimap__count)|Returns the number of elements in a <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> whose key matches a parameter-specified key.|  
|[crbegin](#multimap__crbegin)|Returns a const iterator addressing the first element in a reversed <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.|  
|[crend](#multimap__crend)|Returns a const iterator that addresses the location succeeding the last element in a reversed <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.|  
|[emplace](#multimap__emplace)|Inserts an element constructed in place into a <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.|  
|[emplace_hint](#multimap__emplace_hint)|Inserts an element constructed in place into a <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, with a placement hint|  
|[empty](#multimap__empty)|Tests if a <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> is empty.|  
|[end](#multimap__end)|Returns an iterator that addresses the location succeeding the last element in a <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.|  
|[equal_range](#multimap__equal_range)|Finds the range of elements where the key of the element matches a specified value.|  
|[erase](#multimap__erase)|Removes an element or a range of elements in a <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> from specified positions or removes elements that match a specified key.|  
|[find](#multimap__find)|Returns an iterator addressing the first location of an element in a <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> that has a key equivalent to a specified key.|  
|[get_allocator](#multimap__get_allocator)|Returns a copy of the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object used to construct the <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.|  
|[insert](#multimap__insert)|Inserts an element or a range of elements into a <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.|  
|[key_comp](#multimap__key_comp)|Retrieves a copy of the comparison object used to order keys in a <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.|  
|[lower_bound](#multimap__lower_bound)|Returns an iterator to the first element in a <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> that with a key that is equal to or greater than a specified key.|  
|[max_size](#multimap__max_size)|Returns the maximum length of the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.|  
|[rbegin](#multimap__rbegin)|Returns an iterator addressing the first element in a reversed <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>.|  
|[rend](#multimap__rend)|Returns an iterator that addresses the location succeeding the last element in a reversed <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.|  
|[size](#multimap__size)|Returns the number of elements in the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.|  
|[swap](#multimap__swap)|Exchanges the elements of two <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>s.|  
|[upper_bound](#multimap__upper_bound)|Returns an iterator to the first element in a <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> that with a key that is greater than a specified key.|  
|[value_comp](#multimap__value_comp)|The member function returns a function object that determines the order of elements in a <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> by comparing their key values.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#multimap__operator_eq)|Replaces the elements of a <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> with a copy of another <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
 The ( **key**, **value**) pairs are stored in a multimap as objects of type <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>. The pair class requires the header \<utility>, which is automatically included by \<map>.  
  
##  \<a name="multimap__allocator_type">\</a>  multimap::allocator_type  
 A type that represents the allocator class for the multimap object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Example  
  See the example for [get_allocator](#multimap__get_allocator) for an example using <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
##  \<a name="multimap__begin">\</a>  multimap::begin  
 Returns an iterator addressing the first element in the multimap.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator addressing the first element in the multimap or the location succeeding an empty multimap.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The first element of m1 is 0**  
**First element of m1 is now 1**    
##  \<a name="multimap__cbegin">\</a>  multimap::cbegin  
 Returns a <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> bidirectional-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="multimap__cend">\</a>  multimap::cend  
 Returns a <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> bidirectional-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="multimap__clear">\</a>  multimap::clear  
 Erases all the elements of a multimap.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Example  
  The following example demonstrates the use of the multimap::clear member function.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The size of the multimap is initially 2.**  
**The size of the multimap after clearing is 0.**    
##  \<a name="multimap__const_iterator">\</a>  multimap::const_iterator  
 A type that provides a bidirectional iterator that can read a **const** element in the multimap.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 The <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> defined by multimap points to objects of [value_type](#multimap__value_type), which are of type <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>*\<***const Key**, **Type***>*. The value of the key is available through the first member pair and the value of the mapped element is available through the second member of the pair.  
  
 To dereference a <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> pointing to an element in a multimap, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>). **first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>). **second**.  
  
### Example  
  See the example for [begin](#multimap__begin) for an example using <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
##  \<a name="multimap__const_pointer">\</a>  multimap::const_pointer  
 A type that provides a pointer to a **const** element in a multimap.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 In most cases, an [iterator](#multimap__iterator) should be used to access the elements in a multimap object.  
  
##  \<a name="multimap__const_reference">\</a>  multimap::const_reference  
 A type that provides a reference to a **const** element stored in a multimap for reading and performing **const** operations.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The key of the first element in the multimap is 1.**  
**The data value of the first element in the multimap is 10.**    
##  \<a name="multimap__const_reverse_iterator">\</a>  multimap::const_reverse_iterator  
 A type that provides a bidirectional iterator that can read any **const** element in the multimap.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> cannot modify the value of an element and is use to iterate through the multimap in reverse.  
  
 The <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> defined by multimap points to objects of [value_type](#multimap__value_type), which are of type <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>*\<***const Key**, **Type***>*. The value of the key is available through the first member pair and the value of the mapped element is available through the second member of the pair.  
  
 To dereference a <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> pointing to an element in a multimap, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>). **first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>). **first**.  
  
### Example  
  See the example for [rend](#multimap__rend) for an example of how to declare and use <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>.  
  
##  \<a name="multimap__count">\</a>  multimap::count  
 Returns the number of elements in a multimap whose keys match a parameter-specified key.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 The key of the elements to be matched from the multimap.  
  
### Return Value  
 The number of elements whose sort keys match the parameter key; 0 if the multimap doesn't contain an element with a matching key.  
  
### Remarks  
 The member function returns the number of elements in the range  
  
 [ <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> (_                        *Key* ), <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> (\_                        *Key* ) )  
  
 that have a key value <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>.  
  
### Example  
  The following example demonstrates the use of the multimap::count member function.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **The number of elements in m1 with a sort key of 1 is: 2.**  
**The number of elements in m1 with a sort key of 2 is: 2.**  
**The number of elements in m1 with a sort key of 3 is: 0.**    
##  \<a name="multimap__crbegin">\</a>  multimap::crbegin  
 Returns a const iterator addressing the first element in a reversed multimap.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [multimap](../vs140/multimap-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> just as [begin](#multimap__begin) is used with a <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> can be used to iterate through a <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> backwards.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The first element of the reversed multimap m1 is 3.**    
##  \<a name="multimap__crend">\</a>  multimap::crend  
 Returns a const iterator that addresses the location succeeding the last element in a reversed multimap.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [multimap](../vs140/multimap-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>).  
  
### Remarks  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> just as [end](#multimap__end) is used with a <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>.  
  
 The value returned by <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **The last element of the reversed multimap m1 is 1.**    
##  \<a name="multimap__difference_type">\</a>  multimap::difference_type  
 A signed integer type that can be used to represent the number of elements of a multimap in a range between elements pointed to by iterators.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> is the type returned when subtracting or incrementing through iterators of the container. The <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> is typically used to represent the number of elements in the range [                        *_First, _Last*) between the iterators <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>, includes the element pointed to by <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> and the range of elements up to, but not including, the element pointed to by                         *_Last*.  
  
 Note that although <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers such as set, subtraction between iterators is only supported by random-access iterators provided by a random-access container such as vector.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The number of elements in the multimap m1 is: 4.**    
##  \<a name="multimap__emplace">\</a>  multimap::emplace  
 Inserts an element constructed in place (no copy or move operations are performed).  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>209\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the multimap.|  
  
### Return Value  
 An iterator to the newly inserted element.  
  
### Remarks  
 No references to container elements are invalidated by this function, but it may invalidate all iterators to the container.  
  
 If an exception is thrown during the insertion, the container is left unaltered and the exception is rethrown.  
  
 The [value_type](../vs140/map-class.md#map__value_type) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
##  \<a name="multimap__emplace_hint">\</a>  multimap::emplace_hint  
 Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>210\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the multimap.|  
|<CodeContentPlaceHolder>211\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (If that point immediately precedes <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>, insertion can occur in amortized constant time instead of logarithmic time.)|  
  
### Return Value  
 An iterator to the newly inserted element.  
  
### Remarks  
 No references to container elements are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During emplacement, if an exception is thrown, the container's state is not modified.  
  
 The [value_type](../vs140/map-class.md#map__value_type) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 For a code example, see [map::emplace_hint](../vs140/map-class.md#map__emplace_hint).  
  
##  \<a name="multimap__empty">\</a>  multimap::empty  
 Tests if a multimap is empty.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the multimap is empty; **false** if the multimap is nonempty.  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  **The multimap m1 is not empty.**  
**The multimap m2 is empty.**    
##  \<a name="multimap__end">\</a>  multimap::end  
 Returns the past-the-end iterator.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 The past-the-end iterator. If the multimap is empty, then <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>.  
  
### Remarks  
 **end** is used to test whether an iterator has passed the end of its multimap.  
  
 The value returned by **end** should not be dereferenced.  
  
 For a code example, see [multimap::find](#multimap__find).  
  
##  \<a name="multimap__equal_range">\</a>  multimap::equal_range  
 Finds the range of elements where the key of the element matches a specified value.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the multimap being searched.  
  
### Return Value  
 A pair of iterators such that the first is the [lower_bound](#multimap__lower_bound) of the key and the second is the [upper_bound](#multimap__upper_bound) of the key.  
  
 To access the first iterator of a pair <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>. **first** and to dereference the lower bound iterator, use \*( <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>. **first**). To access the second iterator of a pair <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>. **second** and to dereference the upper bound iterator, use \*( <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>. **second**).  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **The lower bound of the element with a key of 2 in the multimap m1 is: 20.**  
**The upper bound of the element with a key of 2 in the multimap m1 is: 30.**  
**A direct call of upper_bound( 2 ) gives 30,**  
 **matching the 2nd element of the pair returned by equal_range( 2 ).**  
**The multimap m1 doesn't have an element with a key less than 4.**    
##  \<a name="multimap__erase">\</a>  multimap::erase  
 Removes an element or a range of elements in a multimap from specified positions or removes elements that match a specified key.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 Position of the element to be removed.  
  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 Position of the first element to be removed.  
  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 Position just beyond the last element to be removed.  
  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 The key of the elements to be removed.  
  
### Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the map if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the multimap.  
  
### Remarks  
 For a code example, see [map::erase](../vs140/map-class.md#map__erase).  
  
##  \<a name="multimap__find">\</a>  multimap::find  
 Returns an iterator that refers to the first location of an element in a multimap that has a key equivalent to a specified key.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 The key value to be matched by the sort key of an element from the multimap being searched.  
  
### Return Value  
 An iterator that refers to the location of an element with a specified key, or the location succeeding the last element in the multimap ( <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>) if no match is found for the key.  
  
### Remarks  
 The member function returns an iterator that refers to an element in the multimap whose sort key is equivalent to the argument key under a binary predicate that induces an ordering based on a less than comparability relation.  
  
 If the return value of **find** is assigned to a **const_iterator**, the multimap object cannot be modified. If the return value of **find** is assigned to an **iterator**, the multimap object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
##  \<a name="multimap__get_allocator">\</a>  multimap::get_allocator  
 Returns a copy of the allocator object used to construct the multimap.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 The allocator used by the multimap.  
  
### Remarks  
 Allocators for the multimap class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
##  \<a name="multimap__insert">\</a>  multimap::insert  
 Inserts an element or a range of elements into a multimap.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>227\</CodeContentPlaceHolder>|The value of an element to be inserted into the multimap.|  
|<CodeContentPlaceHolder>228\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (If that point immediately precedes <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>, insertion can occur in amortized constant time instead of logarithmic time.)|  
|<CodeContentPlaceHolder>230\</CodeContentPlaceHolder>|Template parameter that specifies the argument type that the map can use to construct an element of [value_type](../vs140/map-class.md#map__value_type), and perfect-forwards <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> as an argument.|  
|<CodeContentPlaceHolder>232\</CodeContentPlaceHolder>|The position of the first element to be copied.|  
|<CodeContentPlaceHolder>233\</CodeContentPlaceHolder>|The position just beyond the last element to be copied.|  
|<CodeContentPlaceHolder>234\</CodeContentPlaceHolder>|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map-class.md#map__value_type) objects.|  
|<CodeContentPlaceHolder>235\</CodeContentPlaceHolder>|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
### Return Value  
 The single-element-insert member functions, (1) and (2), return an iterator to the position where the new element was inserted into the multimap.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the multimap.  
  
### Remarks  
 No pointers or references are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During the insertion of just one element, if an exception is thrown, the container's state is not modified. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 The [value_type](../vs140/map-class.md#map__value_type) of a container is a typedef that belongs to the container, and for map, <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>. The value of an element is an ordered pair in which the first component is equal to the key value and the second component is equal to the data value of the element.  
  
 The range member function (5) inserts the sequence of element values into a multimap that corresponds to each element addressed by an iterator in the range <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>; therefore, <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> does not get inserted. The container member function <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> refers to the position just after the last element in the container—for example, the statement <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> inserts all elements of <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the map.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [multimap::emplace](#multimap__emplace) and [multimap::emplace_hint](#multimap__emplace_hint).  
  
### Example  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
##  \<a name="multimap__iterator">\</a>  multimap::iterator  
 A type that provides a bidirectional iterator that can read or modify any element in a multimap.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Remarks  
 The **iterator** defined by multimap points to objects of [value_type](#multimap__value_type), which are of type <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>*\<***const Key**, **Type***>*. The value of the key is available through the first member pair and the value of the mapped element is available through the second member of the pair.  
  
 To dereference an **iterator**<CodeContentPlaceHolder>245\</CodeContentPlaceHolder> pointing to an element in a multimap, use the  **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>). **first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>). **second**.  
  
 A type **iterator** can be used to modify the value of an element.  
  
### Example  
  See the example for [begin](#multimap__begin) for an example of how to declare and use **iterator**.  
  
##  \<a name="multimap__key_comp">\</a>  multimap::key_comp  
 Retrieves a copy of the comparison object used to order keys in a multimap.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
 Returns the function object that a multimap uses to order its elements.  
  
### Remarks  
 The stored object defines the member function  
  
 **bool operator**( **const Key&** *x*, **const Key&** *y*);  
  
 which returns true if                         *x* strictly precedes                         *y* in the sort order.  
  
### Example  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  **kc1( 2,3 ) returns value of true, where kc1 is the function object of m1.**  
**kc2( 2,3 ) returns value of false, where kc2 is the function object of m2.**    
##  \<a name="multimap__key_compare">\</a>  multimap::key_compare  
 A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the multimap.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Remarks  
 **key_compare** is a synonym for the template parameter <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> see the [multimap Class](../vs140/multimap-class.md) topic.  
  
### Example  
  See the example for [key_comp](#multimap__key_comp) for an example of how to declare and use <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>.  
  
##  \<a name="multimap__key_type">\</a>  multimap::key_type  
 A type that describes the sort key object that constitutes each element of the multimap.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Remarks  
 **key_type** is a synonym for the template parameter <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>, see the Remarks section of the [multimap Class](../vs140/multimap-class.md) topic.  
  
### Example  
  See the example for [value_type](#multimap__value_type) for an example of how to declare and use <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>.  
  
##  \<a name="multimap__lower_bound">\</a>  multimap::lower_bound  
 Returns an iterator to the first element in a multimap that with a key that is equal to or greater than a specified key.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the multimap being searched.  
  
### Return Value  
 An iterator or <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> that addresses the location of an element in a multimap that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the multimap if no match is found for the key.  
  
 If the return value of <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>, the multimap object cannot be modified. If the return value of <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> is assigned to an **iterator**, the multimap object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  **The element of multimap m1 with a key of 2 is: 20.**  
**The first element of multimap m1 with a key of 3 is: 20.**  
**The multimap m1 doesn't have an element with a key of 4.**  
**The first element of m1 with a key matching**  
**that of the last element is: 20.**  
**This is not the last element of multimap m1.**    
##  \<a name="multimap__mapped_type">\</a>  multimap::mapped_type  
 A type that represents the data type stored in a multimap.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> see the [multimap Class](../vs140/multimap-class.md) topic.  
  
### Example  
  See the example for [value_type](#multimap__value_type) for an example of how to declare and use <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>.  
  
##  \<a name="multimap__max_size">\</a>  multimap::max_size  
 Returns the maximum length of the multimap.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Return Value  
 The maximum possible length of the multimap.  
  
### Example  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
##  \<a name="multimap__multimap">\</a>  multimap::multimap  
 Constructs a multimap that is empty or that is a copy of all or part of some other multimap.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>265\</CodeContentPlaceHolder>|The storage allocator class to be used for this multimap object, which defaults to Allocator.|  
|<CodeContentPlaceHolder>266\</CodeContentPlaceHolder>|The comparison function of type **constTraits** used to order the elements in the map, which defaults to **Traits**.|  
|<CodeContentPlaceHolder>267\</CodeContentPlaceHolder>|The map of which the constructed set is to be a copy.|  
|<CodeContentPlaceHolder>268\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>269\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>270\</CodeContentPlaceHolder>|The initializer_list from which to copy the elements.|  
  
### Remarks  
 All constructors store a type of allocator object that manages memory storage for the multimap and that can later be returned by calling [get_allocator](#multimap__get_allocator). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their multimap.  
  
 All constructors store a function object of type <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> that is used to establish an order among the keys of the multimap and that can later be returned by calling [key_comp](#multimap__key_comp).  
  
 The first three constructors specify an empty initial multimap, the second specifying the type of comparison function ( <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifying the allocator type ( <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>) to be used. The key word <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the multimap <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>.  
  
 The fifth constructor specifies a copy of the multimap by moving <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>.  
  
 The sixth, seventh, and eighth constructors copy the members of an initializer_list.  
  
 The next three constructors copy the range <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> of a map with increasing explicitness in specifying the type of comparison function of class **Traits** and allocator.  
  
### Example  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
##  \<a name="multimap__operator_eq">\</a>  multimap::operator=  
 Replaces the elements of a multimap with a copy of another multimap.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>278\</CodeContentPlaceHolder>|The [multimap](../vs140/multimap-class.md) being copied into the <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>.|  
  
### Remarks  
 After erasing any existing elements in a <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> either copies or moves the contents of <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
##  \<a name="multimap__pointer">\</a>  multimap::pointer  
 A type that provides a pointer to an element in a multimap.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Remarks  
 A type **pointer** can be used to modify the value of an element.  
  
 In most cases, an [iterator](#multimap__iterator) should be used to access the elements in a multimap object.  
  
##  \<a name="multimap__rbegin">\</a>  multimap::rbegin  
 Returns an iterator addressing the first element in a reversed multimap.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed multimap or addressing what had been the last element in the unreversed multimap.  
  
### Remarks  
 <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> is used with a reversed multimap just as [begin](#multimap__begin) is used with a multimap.  
  
 If the return value of <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>, then the multimap object cannot be modified. If the return value of <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>, then the multimap object can be modified.  
  
 <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> can be used to iterate through a multimap backwards.  
  
### Example  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  **The first element of the reversed multimap m1 is 3.**  
**The multimap is: 1 2 3 .**  
**The reversed multimap is: 3 2 1 .**  
**After the erasure, the first element in the reversed multimap is 2.**    
##  \<a name="multimap__reference">\</a>  multimap::reference  
 A type that provides a reference to an element stored in a multimap.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  **The key of first element in the multimap is 1.**  
**The data value of first element in the multimap is 10.**  
**The modified data value of first element is 15.**    
##  \<a name="multimap__rend">\</a>  multimap::rend  
 Returns an iterator that addresses the location succeeding the last element in a reversed multimap.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed multimap (the location that had preceded the first element in the unreversed multimap).  
  
### Remarks  
 <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> is used with a reversed multimap just as [end](../vs140/map-class.md#map__end) is used with a multimap.  
  
 If the return value of <CodeContentPlaceHolder>291\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>, then the multimap object cannot be modified. If the return value of <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>, then the multimap object can be modified.  
  
 <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its multimap.  
  
 The value returned by <CodeContentPlaceHolder>296\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  **The last element of the reversed multimap m1 is 1.**  
**The multimap is: 1 2 3 .**  
**The reversed multimap is: 3 2 1 .**  
**After the erasure, the last element in the reversed multimap is 2.**    
##  \<a name="multimap__reverse_iterator">\</a>  multimap::reverse_iterator  
 A type that provides a bidirectional iterator that can read or modify an element in a reversed multimap.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> is use to iterate through the multimap in reverse.  
  
 The <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> defined by multimap points to objects of [value_type](#multimap__value_type), which are of type <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>*\<***const Key**, **Type***>*. The value of the key is available through the first member pair and the value of the mapped element is available through the second member of the pair.  
  
 To dereference a <CodeContentPlaceHolder>300\</CodeContentPlaceHolder> pointing to an element in a multimap, use the -> operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\* <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>). **first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>303\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\* <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>). **first**.  
  
### Example  
  See the example for [rbegin](#multimap__rbegin) for an example of how to declare and use <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>.  
  
##  \<a name="multimap__size">\</a>  multimap::size  
 Returns the number of elements in the multimap.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the multimap.  
  
### Example  
  The following example demonstrates the use of the multimap::size member function.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  **The multimap length is 1.**  
**The multimap length is now 2.**    
##  \<a name="multimap__size_type">\</a>  multimap::size_type  
 An unsigned integer type that counts the number of elements in a multimap.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Example  
  See the example for [size](#multimap__size) for an example of how to declare and use <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>  
  
##  \<a name="multimap__swap">\</a>  multimap::swap  
 Exchanges the elements of two multimaps.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
 The multimap providing the elements to be swapped, or the multimap whose elements are to be exchanged with those of the multimap <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>.  
  
### Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two multimaps whose elements are being exchanged.  
  
### Example  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  **The original multimap m1 is: 10 20 30.**  
**After swapping with m2, multimap m1 is: 100 200.**  
**After swapping with m3, multimap m1 is: 300.**    
##  \<a name="multimap__upper_bound">\</a>  multimap::upper_bound  
 Returns an iterator to the first element in a multimap that with a key that is greater than a specified key.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the multimap being searched.  
  
### Return Value  
 An iterator or <CodeContentPlaceHolder>310\</CodeContentPlaceHolder> that addresses the location of an element in a multimap that with a key that is greater than the argument key, or that addresses the location succeeding the last element in the multimap if no match is found for the key.  
  
 If the return value is assigned to a <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>, the multimap object cannot be modified. If the return value is assigned to a **iterator**, the multimap object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  **The 1st element of multimap m1 with a key greater than 1 is: 20.**  
**The first element of multimap m1 with a key  greater than 2 is: 30.**  
**The multimap m1 doesn't have an element with a key of 4.**  
**The first element of m1 with a key greater than**  
**that of the initial element of m1 is: 20.**    
##  \<a name="multimap__value_comp">\</a>  multimap::value_comp  
 The member function returns a function object that determines the order of elements in a multimap by comparing their key values.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Return Value  
 Returns the comparison function object that a multimap uses to order its elements.  
  
### Remarks  
 For a multimap                         *m*, if two elements                         *e*1(                        *k*1,                         *d*1) and                         *e*2(                        *k*2, <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>2) are objects of type <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>, where                         *k*1 and                         *k*2 are their keys of type <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>1 and <CodeContentPlaceHolder>316\</CodeContentPlaceHolder>2 are their data of type <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>, then                         *m.*<CodeContentPlaceHolder>318\</CodeContentPlaceHolder>(                        *e*1,                         *e*2) is equivalent to                         *m.*<CodeContentPlaceHolder>319\</CodeContentPlaceHolder>(                        *k*1,                         *k*2).  
  
### Example  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  **The element ( 1,10 ) precedes the element ( 2,5 ).**  
**The element ( 2,5 ) does not precede the element ( 1,10 ).**    
##  \<a name="multimap__value_type">\</a>  multimap::value_type  
 A type that represents the type of object stored as an element in a map.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  **The key of first element in the multimap is 1.**  
**The data value of first element in the multimap is 10.**  
**The keys of the mapped elements are: 1 2.**  
**The values of the mapped elements are: 10 20.**    
## See Also  
 [\<map> Members](assetId:///7e8f0bc2-6034-40f6-9d14-76d4cef86308)   
 [Containers](../vs140/containers--modern-c---.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)