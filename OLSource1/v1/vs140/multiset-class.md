---
title: "multiset Class"
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
  - "std::multiset"
  - "set/std::multiset"
  - "std.multiset"
  - "multiset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "multiset class"
ms.assetid: 630e8c10-0ce9-4ad9-8d79-9e91a600713f
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset Class
The Standard Template Library multiset class is used for the storage and retrieval of data from a collection in which the values of the elements contained need not be unique and in which they serve as the key values according to which the data is automatically ordered. The key value of an element in a multiset may not be changed directly. Instead, old values must be deleted and elements with new values inserted.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Key*  
 The element data type to be stored in the multiset.  
  
 *Compare*  
 The type that provides a function object that can compare two element values as sort keys to determine their relative order in the multiset. The binary predicate **less**\<Key> is the default value.  
  
 In C++14 you can enable heterogeneous lookup by specifying the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> predicate that has no type parameters. For more information, see [Heterogeneous Lookup in Associative Containers](../vs140/stl-containers.md#sequence_containers)  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the multiset's allocation and deallocation of memory. The default value is **allocator***\<Key>.*  
  
## Remarks  
 The STL multiset class is:  
  
-   An associative container, which is a variable size container that supports the efficient retrieval of element values based on an associated key value.  
  
-   Reversible, because it provides bidirectional iterators to access its elements.  
  
-   Sorted, because its elements are ordered by key values within the container in accordance with a specified comparison function.  
  
-   Multiple in the sense that its elements do not need to have unique keys, so that one key value can have many element values associated with it.  
  
-   A simple associative container because its element values are its key values.  
  
-   A template class, because the functionality it provides is generic and so independent of the specific type of data contained as elements. The data type to be used is, instead, specified as a parameter in the class template along with the comparison function and allocator.  
  
 The iterator provided by the multiset class is a bidirectional iterator, but the class member functions [insert](#multiset__insert) and [multiset](#multiset__multiset) have versions that take as template parameters a weaker input iterator, whose functionality requirements are more minimal than those guaranteed by the class of bidirectional iterators. The different iterator concepts form a family related by refinements in their functionality. Each iterator concept has its own set of requirements and the algorithms that work with them must limit their assumptions to the requirements provided by that type of iterator. It may be assumed that an input iterator may be dereferenced to refer to some object and that it may be incremented to the next iterator in the sequence. This is a minimal set of functionality, but it is enough to be able to talk meaningfully about a range of iterators [ <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>) in the context of the class's member functions.  
  
 The choice of container type should be based in general on the type of searching and inserting required by the application. Associative containers are optimized for the operations of lookup, insertion and removal. The member functions that explicitly support these operations are efficient, performing them in a time that is on average proportional to the logarithm of the number of elements in the container. Inserting elements invalidates no iterators, and removing elements invalidates only those iterators that had specifically pointed at the removed elements.  
  
 The multiset should be the associative container of choice when the conditions associating the values with their keys are satisfies by the application. The elements of a multiset may be multiple and serve as their own sort keys, so keys are not unique. A model for this type of structure is an ordered list of, say, words in which the words may occur more than once. Had multiple occurrences of the words not been allowed, then a set would have been the appropriate container structure. If unique definitions were attached as values to the list of unique key words, then a map would be an appropriate structure to contain this data. If instead the definitions were not unique, then a multimap would be the container of choice.  
  
 The multiset orders the sequence it controls by calling a stored function object of type <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. This stored object is a comparison function that may be accessed by calling the member function [key_comp](#multiset__key_comp). In general, the elements need be merely less than comparable to establish this order: so that, given any two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. On a more technical note, the comparison function is a binary predicate that induces a strict weak ordering in the standard mathematical sense. A binary predicate                 *f*(                *x*,                *y*) is a function object that has two argument objects                 *x* and                 *y* and a return value of **true** or **false**. An ordering imposed on a set is a strict weak ordering if the binary predicate is irreflexive, antisymmetric, and transitive and if equivalence is transitive, where two objects x and y are defined to be equivalent when both                 *f*(                *x,y*) and                 *f*(                *y,x*) are false. If the stronger condition of equality between keys replaces that of equivalence, then the ordering becomes total (in the sense that all the elements are ordered with respect to each other) and the keys matched will be indiscernible from each other.  
  
 In C++14 you can enable heterogeneous lookup by specifying the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> predicate that has no type parameters. For more information, see [Heterogeneous Lookup in Associative Containers](../vs140/stl-containers.md#sequence_containers)  
  
### Constructors  
  
|||  
|-|-|  
|[multiset](#multiset__multiset)|Constructs a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> that is empty or that is a copy of all or part of a specified <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#multiset__allocator_type)|A typedef for the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> class for the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object.|  
|[const_iterator](#multiset__const_iterator)|A typedef for a bidirectional iterator that can read a <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.|  
|[const_pointer](#multiset__const_pointer)|A typedef for a pointer to a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.|  
|[const_reference](#multiset__const_reference)|A typedef for a reference to a <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> element stored in a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> for reading and performing <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> operations.|  
|[const_reverse_iterator](#multiset__const_reverse_iterator)|A typedef for a bidirectional iterator that can read any <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.|  
|[difference_type](#multiset__difference_type)|A signed integer typedef for the number of elements of a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> in a range between elements pointed to by iterators.|  
|[iterator](#multiset__iterator)|A typedef for a bidirectional iterator that can read or modify any element in a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.|  
|[key_compare](#multiset__key_compare)|A typedef for a function object that can compare two keys to determine the relative order of two elements in the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.|  
|[key_type](#multiset__key_type)|A typedef for a function object that can compare two sort keys to determine the relative order of two elements in the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.|  
|[pointer](#multiset__pointer)|A typedef for a pointer to an element in a <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.|  
|[reference](#multiset__reference)|A typedef for a reference to an element stored in a <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.|  
|[reverse_iterator](#multiset__reverse_iterator)|A typedef for a bidirectional iterator that can read or modify an element in a reversed <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.|  
|[size_type](#multiset__size_type)|An unsigned integer type that can represent the number of elements in a <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.|  
|[value_compare](#multiset__value_compare)|The typedef for a function object that can compare two elements as sort keys to determine their relative order in the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.|  
|[value_type](#multiset__value_type)|A typedef that describes an object stored as an element as a <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> in its capacity as a value.|  
  
### Member Functions  
  
|||  
|-|-|  
|[begin](#multiset__begin)|Returns an iterator that points to the first element in the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.|  
|[cbegin](#multiset__cbegin)|Returns a const iterator that addresses the first element in the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.|  
|[cend](#multiset__cend)|Returns a const iterator that addresses the location succeeding the last element in a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.|  
|[clear](#multiset__clear)|Erases all the elements of a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.|  
|[count](#multiset__count)|Returns the number of elements in a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> whose key matches the key specified as a parameter.|  
|[crbegin](#multiset__crbegin)|Returns a const iterator addressing the first element in a reversed set.|  
|[crend](#multiset__crend)|Returns a const iterator that addresses the location succeeding the last element in a reversed set.|  
|[emplace](#multiset__emplace)|Inserts an element constructed in place into a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.|  
|[emplace_hint](#multiset__emplace_hint)|Inserts an element constructed in place into a <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>, with a placement hint.|  
|[empty](#multiset__empty)|Tests if a <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> is empty.|  
|[end](#multiset__end)|Returns an iterator that points to the location after the last element in a <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.|  
|[equal_range](#multiset__equal_range)|Returns a pair of iterators. The first iterator in the pair points to the first element in a <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> with a key that is greater than a specified key. The second iterator in the pair points to first element in the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> with a key that is equal to or greater than the key.|  
|[erase](#multiset__erase)|Removes an element or a range of elements in a <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> from specified positions or removes elements that match a specified key.|  
|[find](#multiset__find)|Returns an iterator that points to the first location of an element in a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> that has a key equal to a specified key.|  
|[get_allocator](#multiset__get_allocator)|Returns a copy of the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object that is used to construct the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.|  
|[insert](#multiset__insert)|Inserts an element or a range of elements into a <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.|  
|[key_comp](#multiset__key_comp)|Provides a function object that can compare two sort keys to determine the relative order of two elements in the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.|  
|[lower_bound](#multiset__lower_bound)|Returns an iterator to the first element in a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> with a key that is equal to or greater than a specified key.|  
|[max_size](#multiset__max_size)|Returns the maximum length of the <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.|  
|[rbegin](#multiset__rbegin)|Returns an iterator that points to the first element in a reversed <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.|  
|[rend](#multiset__rend)|Returns an iterator that points to the location succeeding the last element in a reversed <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.|  
|[size](#multiset__size)|Returns the number of elements in a <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.|  
|[swap](#multiset__swap)|Exchanges the elements of two <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>s.|  
|[upper_bound](#multiset__upper_bound)|Returns an iterator to the first element in a <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> with a key that is greater than a specified key.|  
|[value_comp](#multiset__value_comp)|Retrieves a copy of the comparison object that is used to order element values in a <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#multiset__operator_eq)|Replaces the elements of a <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> with a copy of another <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
##  \<a name="multiset__allocator_type">\</a>  multiset::allocator_type  
 A type that represents the allocator class for the multiset object  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>, see the Remarks section of the [multiset Class](../vs140/multiset-class.md) topic.  
  
### Example  
  See the example for [get_allocator](#multiset__get_allocator) for an example using <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
  
##  \<a name="multiset__begin">\</a>  multiset::begin  
 Returns an iterator addressing the first element in the multiset.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator addressing the first element in the multiset or the location succeeding an empty multiset.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The first element of ms1 is 1**  
**The first element of ms1 is now 2**    
##  \<a name="multiset__cbegin">\</a>  multiset::cbegin  
 Returns a <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> bidirectional-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="multiset__cend">\</a>  multiset::cend  
 Returns a <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> bidirectional-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="multiset__clear">\</a>  multiset::clear  
 Erases all the elements of a multiset.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The size of the multiset is initially 2.**  
**The size of the multiset after clearing is 0.**    
##  \<a name="multiset__const_iterator">\</a>  multiset::const_iterator  
 A type that provides a bidirectional iterator that can read a **const** element in the multiset.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
### Example  
  See the example for [begin](#multiset__begin) for an example using <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>.  
  
##  \<a name="multiset__const_pointer">\</a>  multiset::const_pointer  
 A type that provides a pointer to a **const** element in a multiset.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 In most cases, an [iterator](#multiset__iterator) should be used to access the elements in a multiset object.  
  
##  \<a name="multiset__const_reference">\</a>  multiset::const_reference  
 A type that provides a reference to a **const** element stored in a multiset for reading and performing **const** operations.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The first element in the multiset is 10.**    
##  \<a name="multiset__const_reverse_iterator">\</a>  multiset::const_reverse_iterator  
 A type that provides a bidirectional iterator that can read any **const** element in the multiset.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> cannot modify the value of an element and is use to iterate through the multiset in reverse.  
  
### Example  
  See the example for [rend](#multiset__rend) for an example of how to declare and use the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>.  
  
##  \<a name="multiset__count">\</a>  multiset::count  
 Returns the number of elements in a multiset whose key matches a parameter-specified key.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 The key of the elements to be matched from the multiset.  
  
### Return Value  
 The number of elements in the multiset whose sort key matches the parameter key.  
  
### Remarks  
 The member function returns the number of elements                         *x* in the range  
  
 [ <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> (_                        *Key* ), <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> (\_                        *Key* ) ).  
  
### Example  
  The following example demonstrates the use of the multiset::count member function.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **The number of elements in ms1 with a sort key of 1 is: 2.**  
**The number of elements in ms1 with a sort key of 2 is: 1.**  
**The number of elements in ms1 with a sort key of 3 is: 0.**    
##  \<a name="multiset__crbegin">\</a>  multiset::crbegin  
 Returns a const iterator addressing the first element in a reversed multiset.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed multiset or addressing what had been the last element in the unreversed multiset.  
  
### Remarks  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> is used with a reversed multiset just as begin is used with a multiset.  
  
 With the return value of <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>, the multiset object cannot be modified.  
  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> can be used to iterate through a multiset backwards.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The first element in the reversed multiset is 30.**    
##  \<a name="multiset__crend">\</a>  multiset::crend  
 Returns a const iterator that addresses the location succeeding the last element in a reversed multiset.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A  const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed multiset (the location that had preceded the first element in the unreversed multiset).  
  
### Remarks  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> is used with a reversed multiset just as [end](#multiset__end) is used with a multiset.  
  
 With the return value of <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>, the multiset object cannot be modified.  
  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its multiset.  
  
 The value returned by <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
##  \<a name="multiset__difference_type">\</a>  multiset::difference_type  
 A signed integer type that can be used to represent the number of elements of a multiset in a range between elements pointed to by iterators.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> is the type returned when subtracting or incrementing through iterators of the container. The <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> is typically used to represent the number of elements in the range [ <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>) between the iterators <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>, includes the element pointed to by <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> and the range of elements up to, but not including, the element pointed to by <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>.  
  
 Note that although <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers like set, subtraction between iterators is only supported by random-access iterators provided by a random-access container like vector.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The number '5' occurs 0 times in multiset ms1.**  
**The number '10' occurs 1 times in multiset ms1.**  
**The number '20' occurs 2 times in multiset ms1.**  
**The number of elements in the multiset ms1 is: 3.**    
##  \<a name="multiset__emplace">\</a>  multiset::emplace  
 Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>177\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the multiset.|  
  
### Return Value  
 An iterator to the newly inserted element.  
  
### Remarks  
 No references to container elements are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During emplacement, if an exception is thrown, the container's state is not modified.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
##  \<a name="multiset__emplace_hint">\</a>  multiset::emplace_hint  
 Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>178\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the multiset.|  
|<CodeContentPlaceHolder>179\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (If that point immediately precedes <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>, insertion can occur in amortized constant time instead of logarithmic time.)|  
  
### Return Value  
 An iterator to the newly inserted element.  
  
### Remarks  
 No references to container elements are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During emplacement, if an exception is thrown, the container's state is not modified.  
  
 For a code example, see [set::emplace_hint](../vs140/set-class.md#set__emplace_hint).  
  
##  \<a name="multiset__empty">\</a>  multiset::empty  
 Tests if a multiset is empty.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the multiset is empty; **false** if the multiset is nonempty.  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  **The multiset ms1 is not empty.**  
**The multiset ms2 is empty.**    
##  \<a name="multiset__end">\</a>  multiset::end  
 Returns the past-the-end iterator.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 The past-the-end iterator. If the multiset is empty, then <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>.  
  
### Remarks  
 **end** is used to test whether an iterator has passed the end of its multiset.  
  
 The value returned by **end** should not be dereferenced.  
  
 For a code example, see [multiset::find](#multiset__find).  
  
##  \<a name="multiset__equal_range">\</a>  multiset::equal_range  
 Returns a pair of iterators respectively to the first element in a multiset with a key that is greater than a specified key and to the first element in the multiset with a key that is equal to or greater than the key.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the multiset being searched.  
  
### Return Value  
 A pair of iterators such that the first is the [lower_bound](#multiset__lower_bound) of the key and the second is the [upper_bound](#multiset__upper_bound) of the key.  
  
 To access the first iterator of a pair <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>. **first**, and to dereference the lower bound iterator, use \*( <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>. **first**). To access the second iterator of a pair <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>. **second**, and to dereference the upper bound iterator, use \*( <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>. **second**).  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **The upper bound of the element with a key of 20 in the multiset ms1 is: 30.**  
**The lower bound of the element with a key of 20 in the multiset ms1 is: 20.**  
**A direct call of upper_bound( 20 ) gives 30,**  
**matching the 2nd element of the pair returned by equal_range( 20 ).**  
**The multiset ms1 doesn't have an element with a key less than 40.**    
##  \<a name="multiset__erase">\</a>  multiset::erase  
 Removes an element or a range of elements in a multiset from specified positions or removes elements that match a specified key.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 Position of the element to be removed.  
  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 Position of the first element to be removed.  
  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 Position just beyond the last element to be removed.  
  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 The key value of the elements to be removed.  
  
### Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the multiset if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the multiset.  
  
### Remarks  
 For a code example, see [set::erase](../vs140/set-class.md#set__erase).  
  
##  \<a name="multiset__find">\</a>  multiset::find  
 Returns an iterator that refers to the location of an element in a multiset that has a key equivalent to a specified key.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 The key value to be matched by the sort key of an element from the multiset being searched.  
  
### Return Value  
 An iterator that refers to the location of an element with a specified key, or the location succeeding the last element in the multiset ( <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>) if no match is found for the key.  
  
### Remarks  
 The member function returns an iterator that refers to an element in the multiset whose key is equivalent to the argument <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> under a binary predicate that induces an ordering based on a less than comparability relation.  
  
 If the return value of **find** is assigned to a **const_iterator**, the multiset object cannot be modified. If the return value of **find** is assigned to an **iterator**, the multiset object can be modified  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
##  \<a name="multiset__get_allocator">\</a>  multiset::get_allocator  
 Returns a copy of the allocator object used to construct the multiset.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 The allocator used by the multiset.  
  
### Remarks  
 Allocators for the multiset class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
##  \<a name="multiset__insert">\</a>  multiset::insert  
 Inserts an element or a range of elements into a multiset.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>196\</CodeContentPlaceHolder>|The value of an element to be inserted into the multiset.|  
|<CodeContentPlaceHolder>197\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (If that point immediately precedes <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>, insertion can occur in amortized constant time instead of logarithmic time.)|  
|<CodeContentPlaceHolder>199\</CodeContentPlaceHolder>|Template parameter that specifies the argument type that the multiset can use to construct an element of [value_type](../vs140/map-class.md#map__value_type), and perfect-forwards <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> as an argument.|  
|<CodeContentPlaceHolder>201\</CodeContentPlaceHolder>|The position of the first element to be copied.|  
|<CodeContentPlaceHolder>202\</CodeContentPlaceHolder>|The position just beyond the last element to be copied.|  
|<CodeContentPlaceHolder>203\</CodeContentPlaceHolder>|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map-class.md#map__value_type) objects.|  
|<CodeContentPlaceHolder>204\</CodeContentPlaceHolder>|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
### Return Value  
 The single-element-insert member functions, (1) and (2), return an iterator to the position where the new element was inserted into the multiset.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the multiset.  
  
### Remarks  
 No pointers or references are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During the insertion of just one element, if an exception is thrown, the container's state is not modified. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 The [value_type](../vs140/map-class.md#map__value_type) of a container is a typedef that belongs to the container, and, for set, <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> is type <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>.  
  
 The range member function (5) inserts the sequence of element values into a multiset that corresponds to each element addressed by an iterator in the range <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>; therefore, <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> does not get inserted. The container member function <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> refers to the position just after the last element in the container—for example, the statement <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> inserts all elements of <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the multiset.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [multiset::emplace](#multiset__emplace) and [multiset::emplace_hint](#multiset__emplace_hint).  
  
### Example  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
##  \<a name="multiset__iterator">\</a>  multiset::iterator  
 A type that provides a constant [bidirectional iterator](../vs140/bidirectional_iterator_tag-struct.md) that can read any element in a multiset.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Example  
  See the example for [begin](#multiset__begin) for an example of how to declare and use an **iterator**.  
  
##  \<a name="multiset__key_comp">\</a>  multiset::key_comp  
 Retrieves a copy of the comparison object used to order keys in a multiset.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
 Returns the function object that a multiset uses to order its elements, which is the template parameter <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>, see the Remarks section of the [multiset Class](../vs140/multiset-class.md) topic.  
  
### Remarks  
 The stored object defines the member function:  
  
 **bool operator**( **const Key&** *x*, **const Key&** *y*);  
  
 which returns true if                         *x* strictly precedes                         *y* in the sort order.  
  
 Note that both [key_compare](#multiset__key_compare) and [value_compare](#multiset__value_compare) are synonyms for the template parameter <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>. Both types are provided for the classes set and multiset, where they are identical, for compatibility with the classes map and multimap, where they are distinct.  
  
### Example  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  **kc1( 2,3 ) returns value of true, where kc1 is the function object of s1.**  
**kc2( 2,3 ) returns value of false, where kc2 is the function object of ms2.**    
##  \<a name="multiset__key_compare">\</a>  multiset::key_compare  
 A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the multiset.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Remarks  
 **key_compare** is a synonym for the template parameter <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>, see the Remarks section of the [multiset Class](../vs140/multiset-class.md) topic.  
  
### Example  
  See the example for [key_comp](#multiset__key_comp) for an example of how to declare and use <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>.  
  
##  \<a name="multiset__key_type">\</a>  multiset::key_type  
 A type that provides a function object that can compare sort keys to determine the relative order of two elements in the multiset.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>, see the Remarks section of the [multiset Class](../vs140/multiset-class.md) topic.  
  
### Example  
  See the example for [value_type](#multiset__value_type) for an example of how to declare and use <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>.  
  
##  \<a name="multiset__lower_bound">\</a>  multiset::lower_bound  
 Returns an iterator to the first element in a multiset with a key that is equal to or greater than a specified key.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the multiset being searched.  
  
### Return Value  
 An **iterator** or <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> that addresses the location of an element in a multiset that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the multiset if no match is found for the key.  
  
### Example  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  **The element of multiset ms1 with a key of 20 is: 20.**  
**The multiset ms1 doesn't have an element with a key of 40.**  
**The element of ms1 with a key matching that of the last element is: 30.**    
##  \<a name="multiset__max_size">\</a>  multiset::max_size  
 Returns the maximum length of the multiset.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
 The maximum possible length of the multiset.  
  
### Example  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
##  \<a name="multiset__multiset">\</a>  multiset::multiset  
 Constructs a multiset that is empty or that is a copy of all or part of some other multiset.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>225\</CodeContentPlaceHolder>|The storage allocator class to be used for this multiset object, which defaults to <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>227\</CodeContentPlaceHolder>|The comparison function of type <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> used to order the elements in the multiset, which defaults to <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>230\</CodeContentPlaceHolder>|The multiset of which the constructed multiset is to be a copy.|  
|<CodeContentPlaceHolder>231\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>232\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>233\</CodeContentPlaceHolder>|The initializer_list from which to copy the elements.|  
  
### Remarks  
 All constructors store a type of allocator object that manages memory storage for the multiset and that can later be returned by calling [get_allocator](#multiset__get_allocator). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their multiset.  
  
 All constructors store a function object of type Compare that is used to establish an order among the keys of the multiset and that can later be returned by calling [key_comp](#multiset__key_comp).  
  
 The first three constructors specify an empty initial multiset, the second specifying the type of comparison function ( <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifying the allocator type ( <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>) to be used. The keyword <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the multiset <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>.  
  
 The fifth constructor specifies a copy of the multiset by moving <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>.  
  
 The sixth, seventh, and eighth constructors specify an initializer_list from which to copy the elements.  
  
 The next three constructors copy the range <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> of a multiset with increasing explicitness in specifying the type of comparison function and allocator.  
  
### Example  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
##  \<a name="multiset__operator_eq">\</a>  multiset::operator=  
 Replaces the elements of this <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> using elements from another <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>242\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> from which elements are copied or moved.|  
  
### Remarks  
 <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> copies or moves the elements in <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> into this <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>, depending on the reference type (lvalue or rvalue) used. Elements that are in this <CodeContentPlaceHolder>247\</CodeContentPlaceHolder> before <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> executes are discarded.  
  
### Example  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
##  \<a name="multiset__pointer">\</a>  multiset::pointer  
 A type that provides a pointer to an element in a multiset.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Remarks  
 A type **pointer** can be used to modify the value of an element.  
  
 In most cases, an [iterator](#multiset__iterator) should be used to access the elements in a multiset object.  
  
##  \<a name="multiset__rbegin">\</a>  multiset::rbegin  
 Returns an iterator addressing the first element in a reversed multiset.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed multiset or addressing what had been the last element in the unreversed multiset.  
  
### Remarks  
 <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> is used with a reversed multiset just as rbegin is used with a multiset.  
  
 If the return value of <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>, then the multiset object cannot be modified. If the return value of <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>, then the multiset object can be modified.  
  
 <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> can be used to iterate through a multiset backwards.  
  
### Example  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  **The first element in the reversed multiset is 30.**  
**The multiset is: 10 20 30**  
**The reversed multiset is: 30 20 10**  
**After the erasure, the first element in the reversed multiset is 20.**    
##  \<a name="multiset__reference">\</a>  multiset::reference  
 A type that provides a reference to an element stored in a multiset.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  **The first element in the multiset is 10.**    
##  \<a name="multiset__rend">\</a>  multiset::rend  
 Returns an iterator that addresses the location succeeding the last element in a reversed multiset.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed multiset (the location that had preceded the first element in the unreversed multiset).  
  
### Remarks  
 <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> is used with a reversed multiset just as [end](#multiset__end) is used with a multiset.  
  
 If the return value of <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>, then the multiset object cannot be modified. If the return value of <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>, then the multiset object can be modified.  
  
 <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its multiset.  
  
 The value returned by <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
##  \<a name="multiset__reverse_iterator">\</a>  multiset::reverse_iterator  
 A type that provides a bidirectional iterator that can read or modify an element in a reversed multiset.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> is use to iterate through the multiset in reverse.  
  
### Example  
  See example for [rbegin](#multiset__rbegin) for an example of how to declare and use <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>.  
  
##  \<a name="multiset__size">\</a>  multiset::size  
 Returns the number of elements in the multiset.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the multiset.  
  
### Example  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  **The multiset length is 1.**  
**The multiset length is now 2.**    
##  \<a name="multiset__size_type">\</a>  multiset::size_type  
 An unsigned integer type that can represent the number of elements in a multiset.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Example  
  See example for [size](#multiset__size) for an example of how to declare and use <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>  
  
##  \<a name="multiset__swap">\</a>  multiset::swap  
 Exchanges the elements of two multisets.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>  
 The argument multiset providing the elements to be swapped with the target multiset.  
  
### Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two multisets whose elements are being exchanged.  
  
### Example  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  **The original multiset ms1 is: 10 20 30.**  
**After swapping with ms2, list ms1 is: 100 200.**  
**After swapping with ms3, list ms1 is: 300.**    
##  \<a name="multiset__upper_bound">\</a>  multiset::upper_bound  
 Returns an iterator to the first element in a multiset with a key that is greater than a specified key.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the multiset being searched.  
  
### Return Value  
 An **iterator** or <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> that addresses the location of an element in a multiset with a key that is greater than the argument key, or that addresses the location succeeding the last element in the multiset if no match is found for the key.  
  
### Example  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  **The first element of multiset ms1 with a key greater than 20 is: 30.**  
**The multiset ms1 doesn't have an element with a key greater than 30.**  
**The first element of ms1 with a key greater than**  
**that of the initial element of ms1 is: 20.**    
##  \<a name="multiset__value_comp">\</a>  multiset::value_comp  
 Retrieves a copy of the comparison object used to order element values in a multiset.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Return Value  
 Returns the function object that a multiset uses to order its elements, which is the template parameter <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>, see the Remarks section of the [multiset Class](../vs140/multiset-class.md) topic.  
  
### Remarks  
 The stored object defines the member function:  
  
 **bool operator**( **const Key&**<CodeContentPlaceHolder>270\</CodeContentPlaceHolder>, **const Key&**<CodeContentPlaceHolder>271\</CodeContentPlaceHolder>);  
  
 which returns true if <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> in the sort order.  
  
 Note that both [key_compare](#multiset__key_compare) and [value_compare](#multiset__value_compare) are synonyms for the template parameter <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>. Both types are provided for the classes set and multiset, where they are identical, for compatibility with the classes map and multimap, where they are distinct.  
  
### Example  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  **vc1( 2,3 ) returns value of true, where vc1 is the function object of ms1.**  
**vc2( 2,3 ) returns value of false, where vc2 is the function object of ms2.**    
##  \<a name="multiset__value_compare">\</a>  multiset::value_compare  
 The type that provides a function object that can compare two sort keys to determine their relative order in the multiset.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>.  
  
 Note that both [key_compare](#multiset__key_compare) and **value_compare** are synonyms for the template parameter <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>. Both types are provided for the classes set and multiset, where they are identical, for compatibility with the classes map and multimap, where they are distinct.  
  
 For more information on <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>, see the Remarks section of the [multiset Class](../vs140/multiset-class.md) topic.  
  
### Example  
  See the example for [value_comp](#multiset__value_comp) for an example of how to declare and use <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>.  
  
##  \<a name="multiset__value_type">\</a>  multiset::value_type  
 A type that describes an object stored as an element as a multiset in its capacity as a value.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>.  
  
 Note that both [key_type](#multiset__key_type) and <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> are synonyms for the template parameter **Key**. Both types are provided for the classes set and multiset, where they are identical, for compatibility with the classes map and multimap, where they are distinct.  
  
 For more information on <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>, see the Remarks section of the topic.  
  
### Example  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  **The multiset has elements: 10 20.**    
## See Also  
 [\<set> Members](assetId:///0c2d57c0-173f-4204-b579-c5f06aad8b95)   
 [Containers](../vs140/containers--modern-c---.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)