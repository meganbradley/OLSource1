---
title: "set Class"
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
  - "std::set"
  - "set"
  - "set/std::set"
  - "std.set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set class"
ms.assetid: 8991f9aa-5509-4440-adc1-371512d32018
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set Class
The STL container class set is used for the storage and retrieval of data from a collection in which the values of the elements contained are unique and serve as the key values according to which the data is automatically ordered. The value of an element in a set may not be changed directly. Instead, you must delete old values and insert elements with new values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The element data type to be stored in the set.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The type that provides a function object that can compare two element values as sort keys to determine their relative order in the set. This argument is optional, and the binary predicate **less** *\<Key>* is the default value.  
  
 In C++14 you can enable heterogeneous lookup by specifying the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> predicate that has no type parameters. For more information, see [Heterogeneous Lookup in Associative Containers](../vs140/stl-containers.md#sequence_containers)  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the set's allocation and deallocation of memory. This argument is optional, and the default value is **allocator***\<Key>.*  
  
## Remarks  
 An STL set is:  
  
-   An associative container, which a variable size container that supports the efficient retrieval of element values based on an associated key value. Further, it is a simple associative container because its element values are its key values.  
  
-   Reversible, because it provides a bidirectional iterator to access its elements.  
  
-   Sorted, because its elements are ordered by key values within the container in accordance with a specified comparison function.  
  
-   Unique in the sense that each of its elements must have a unique key. Since set is also a simple associative container, its elements are also unique.  
  
 A set is also described as a template class because the functionality it provides is generic and independent of the specific type of data contained as elements. The data type to be used is, instead, specified as a parameter in the class template along with the comparison function and allocator.  
  
 The choice of container type should be based in general on the type of searching and inserting required by the application. Associative containers are optimized for the operations of lookup, insertion and removal. The member functions that explicitly support these operations are efficient, performing them in a time that is on average proportional to the logarithm of the number of elements in the container. Inserting elements invalidates no iterators, and removing elements invalidates only those iterators that had specifically pointed at the removed elements.  
  
 The set should be the associative container of choice when the conditions associating the values with their keys are satisfied by the application. The elements of a set are unique and serve as their own sort keys. A model for this type of structure is an ordered list of, say, words in which the words may occur only once. If multiple occurrences of the words were allowed, then a multiset would be the appropriate container structure. If values need to be attached to a list of unique key words, then a map would be an appropriate structure to contain this data. If instead the keys are not unique, then a multimap would be the container of choice.  
  
 The set orders the sequence it controls by calling a stored function object of type [key_compare](#set__key_compare). This stored object is a comparison function that may be accessed by calling the member function [key_comp](#set__key_comp). In general, the elements need to be merely less than comparable to establish this order so that, given any two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. On a more technical note, the comparison function is a binary predicate that induces a strict weak ordering in the standard mathematical sense. A binary predicate                 *f*(                *x,y*) is a function object that has two argument objects                 *x* and                 *y* and a return value of **true** or **false**. An ordering imposed on a set is a strict weak ordering if the binary predicate is irreflexive, antisymmetric, and transitive and if equivalence is transitive, where two objects                 *x* and                 *y* are defined to be equivalent when both                 *f*(                *x,y*) and                 *f*(                *y,x*) are false. If the stronger condition of equality between keys replaces that of equivalence, then the ordering becomes total (in the sense that all the elements are ordered with respect to each other) and the keys matched will be indiscernible from each other.  
  
 In C++14 you can enable heterogeneous lookup by specifying the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> predicate that has no type parameters. For more information, see [Heterogeneous Lookup in Associative Containers](../vs140/stl-containers.md#sequence_containers)  
  
 The iterator provided by the set class is a bidirectional iterator, but the class member functions [insert](#set__insert) and [set](#set__set) have versions that take as template parameters a weaker input iterator, whose functionality requirements are more minimal than those guaranteed by the class of bidirectional iterators. The different iterator concepts form a family related by refinements in their functionality. Each iterator concept has its own set of requirements, and the algorithms that work with them must limit their assumptions to the requirements provided by that type of iterator. It may be assumed that an input iterator may be dereferenced to refer to some object and that it may be incremented to the next iterator in the sequence. This is a minimal set of functionality, but it is enough to be able to talk meaningfully about a range of iterators [ <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>) in the context of the class's member functions.  
  
### Constructors  
  
|||  
|-|-|  
|[set](#set__set)|Constructs a set that is empty or that is a copy of all or part of some other set.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#set__allocator_type)|A type that represents the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> class for the set object.|  
|[const_iterator](#set__const_iterator)|A type that provides a bidirectional iterator that can read a <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> element in the set.|  
|[const_pointer](#set__const_pointer)|A type that provides a pointer to a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> element in a set.|  
|[const_reference](#set__const_reference)|A type that provides a reference to a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> element stored in a set for reading and performing <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> operations.|  
|[const_reverse_iterator](#set__const_reverse_iterator)|A type that provides a bidirectional iterator that can read any <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> element in the set.|  
|[difference_type](#set__difference_type)|A signed integer type that can be used to represent the number of elements of a set in a range between elements pointed to by iterators.|  
|[iterator](#set__iterator)|A type that provides a bidirectional iterator that can read or modify any element in a set.|  
|[key_compare](#set__key_compare)|A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the set.|  
|[key_type](#set__key_type)|The type describes an object stored as an element of a set in its capacity as sort key.|  
|[pointer](#set__pointer)|A type that provides a pointer to an element in a set.|  
|[reference](#set__reference)|A type that provides a reference to an element stored in a set.|  
|[reverse_iterator](#set__reverse_iterator)|A type that provides a bidirectional iterator that can read or modify an element in a reversed set.|  
|[size_type](#set__size_type)|An unsigned integer type that can represent the number of elements in a set.|  
|[value_compare](#set__value_compare)|The type that provides a function object that can compare two elements to determine their relative order in the set.|  
|[value_type](#set__value_type)|The type describes an object stored as an element of a set in its capacity as a value.|  
  
### Member Functions  
  
|||  
|-|-|  
|[begin](#set__begin)|Returns an iterator that addresses the first element in the set.|  
|[cbegin](#set__cbegin)|Returns a const iterator that addresses the first element in the set.|  
|[cend](#set__cend)|Returns a const iterator that addresses the location succeeding the last element in a set.|  
|[clear](#set__clear)|Erases all the elements of a set.|  
|[count](#set__count)|Returns the number of elements in a set whose key matches a parameter-specified key.|  
|[crbegin](#set__rbegin)|Returns a const iterator addressing the first element in a reversed set.|  
|[crend](#set__rend)|Returns a const iterator that addresses the location succeeding the last element in a reversed set.|  
|[emplace](#set__emplace)|Inserts an element constructed in place into a set.|  
|[emplace_hint](#set__emplace_hint)|Inserts an element constructed in place into a set, with a placement hint.|  
|[empty](#set__empty)|Tests if a set is empty.|  
|[end](#set__end)|Returns an iterator that addresses the location succeeding the last element in a set.|  
|[equal_range](#set__equal_range)|Returns a pair of iterators respectively to the first element in a set with a key that is greater than a specified key and to the first element in the set with a key that is equal to or greater than the key.|  
|[erase](#set__erase)|Removes an element or a range of elements in a set from specified positions or removes elements that match a specified key.|  
|[find](#set__find)|Returns an iterator addressing the location of an element in a set that has a key equivalent to a specified key.|  
|[get_allocator](#set__get_allocator)|Returns a copy of the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object used to construct the set.|  
|[insert](#set__insert)|Inserts an element or a range of elements into a set.|  
|[key_comp](#set__key_comp)|Retrieves a copy of the comparison object used to order keys in a set.|  
|[lower_bound](#set__lower_bound)|Returns an iterator to the first element in a set with a key that is equal to or greater than a specified key.|  
|[max_size](#set__max_size)|Returns the maximum length of the set.|  
|[rbegin](#set__rbegin)|Returns an iterator addressing the first element in a reversed set.|  
|[rend](#set__rend)|Returns an iterator that addresses the location succeeding the last element in a reversed set.|  
|[size](#set__size)|Returns the number of elements in the set.|  
|[swap](#set__swap)|Exchanges the elements of two sets.|  
|[upper_bound](#set__upper_bound)|Returns an iterator to the first element in a set with a key that is greater than a specified key.|  
|[value_comp](#set__value_comp)|Retrieves a copy of the comparison object used to order element values in a set.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#set__operator_eq)|Replaces the elements of a set with a copy of another set.|  
  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
##  \<a name="set__allocator_type">\</a>  set::allocator_type  
 A type that represents the allocator class for the set object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 **allocator_type** is a synonym for the template parameter [Allocator](../vs140/set-class.md).  
  
 Returns the function object that a multiset uses to order its elements, which is the template parameter <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, see the Remarks section of the [set Class](../vs140/set-class.md) topic.  
  
### Example  
  See the example for [get_allocator](#set__get_allocator) for an example that uses <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
##  \<a name="set__begin">\</a>  set::begin  
 Returns an iterator that addresses the first element in the set.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator addressing the first element in the set or the location succeeding an empty set.  
  
### Remarks  
 If the return value of **begin** is assigned to a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, the elements in the set object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the set object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The first element of s1 is 1**  
**The first element of s1 is now 2**    
##  \<a name="set__cbegin">\</a>  set::cbegin  
 Returns a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> bidirectional-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="set__cend">\</a>  set::cend  
 Returns a <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> bidirectional-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="set__clear">\</a>  set::clear  
 Erases all the elements of a set.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The size of the set is initially 2.**  
**The size of the set after clearing is 0.**    
##  \<a name="set__const_iterator">\</a>  set::const_iterator  
 A type that provides a bidirectional iterator that can read a **const** element in the set.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
### Example  
  See the example for [begin](#set__begin) for an example that uses <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
##  \<a name="set__const_pointer">\</a>  set::const_pointer  
 A type that provides a pointer to a **const** element in a set.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 In most cases, a [const_iterator](#set__const_iterator) should be used to access the elements in a const set object.  
  
##  \<a name="set__const_reference">\</a>  set::const_reference  
 A type that provides a reference to a **const** element stored in a set for reading and performing **const** operations.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The first element in the set is 10.**    
##  \<a name="set__const_reverse_iterator">\</a>  set::const_reverse_iterator  
 A type that provides a bidirectional iterator that can read any **const** element in the set.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> cannot modify the value of an element and is use to iterate through the set in reverse.  
  
### Example  
  See the example for [rend](#set__rend) for an example of how to declare and use the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
##  \<a name="set__count">\</a>  set::count  
 Returns the number of elements in a set whose key matches a parameter-specified key.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The key of the elements to be matched from the set.  
  
### Return Value  
 1 if the set contains an element whose sort key matches the parameter key. 0 if the set does not contain an element with a matching key.  
  
### Remarks  
 The member function returns the number of elements in the following range:  
  
 [ <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> (_                        *Key* ), <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> (\_                        *Key* ) ).  
  
### Example  
  The following example demonstrates the use of the set::count member function.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **The number of elements in s1 with a sort key of 1 is: 1.**  
**The number of elements in s1 with a sort key of 2 is: 0.**    
##  \<a name="set__crbegin">\</a>  set::crbegin  
 Returns a const iterator addressing the first element in a reversed set.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed set or addressing what had been the last element in the unreversed set.  
  
### Remarks  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> is used with a reversed set just as [begin](#set__begin) is used with a set.  
  
 With the return value of <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, the set object cannot be modified.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The first element in the reversed set is 30.**    
##  \<a name="set__crend">\</a>  set::crend  
 Returns a const iterator that addresses the location succeeding the last element in a reversed set.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed set (the location that had preceded the first element in the unreversed set).  
  
### Remarks  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> is used with a reversed set just as [end](#set__end) is used with a set.  
  
 With the return value of <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>, the set object cannot be modified. The value returned by <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> should not be dereferenced.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its set.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
##  \<a name="set__difference_type">\</a>  set::difference_type  
 A signed integer type that can be used to represent the number of elements of a set in a range between elements pointed to by iterators.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> is the type returned when subtracting or incrementing through iterators of the container. The <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> is typically used to represent the number of elements in the range                         *[_First, _Last)* between the iterators <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>, includes the element pointed to by <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> and the range of elements up to, but not including, the element pointed to by <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
 Note that although <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers such as set, subtraction between iterators is only supported by random-access iterators provided by a random-access container such as vector.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The number '5' occurs 0 times in set s1.**  
**The number '10' occurs 1 times in set s1.**  
**The number '20' occurs 1 times in set s1.**  
**The number of elements in the set s1 is: 2.**    
##  \<a name="set__emplace">\</a>  set::emplace  
 Inserts an element constructed in place (no copy or move operations are performed).  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the set unless it already contains an element whose value is equivalently ordered.|  
  
### Return Value  
 A [pair](../vs140/pair-structure.md) whose bool component returns true if an insertion was made, and false if the map already contained an element whose value had an equivalent value in the ordering. The iterator component of the return value pair returns the address where a new element was inserted (if the bool component is true) or where the element was already located (if the bool component is false).  
  
### Remarks  
 No iterators or references are invalidated by this function.  
  
 During emplacement, if an exception is thrown, the container's state is not modified.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
##  \<a name="set__emplace_hint">\</a>  set::emplace_hint  
 Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the set unless the set already contains that element or, more generally, unless it already contains an element whose value is equivalently ordered.|  
|<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (If that point immediately precedes <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>, insertion can occur in amortized constant time instead of logarithmic time.)|  
  
### Return Value  
 An iterator to the newly inserted element.  
  
 If the insertion failed because the element already exists, returns an iterator to the existing element.  
  
### Remarks  
 No iterators or references are invalidated by this function.  
  
 During emplacement, if an exception is thrown, the container's state is not modified.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
##  \<a name="set__empty">\</a>  set::empty  
 Tests if a set is empty.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the set is empty; **false** if the set is nonempty.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **The set s1 is not empty.**  
**The set s2 is empty.**    
##  \<a name="set__end">\</a>  set::end  
 Returns the past-the-end iterator.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 The past-the-end iterator. If the set is empty, then <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
### Remarks  
 **end** is used to test whether an iterator has passed the end of its set.  
  
 The value returned by **end** should not be dereferenced.  
  
 For a code example, see [set::find](#set__find).  
  
##  \<a name="set__equal_range">\</a>  set::equal_range  
 Returns a pair of iterators respectively to the first element in a set with a key that is greater than or equal to a specified key and to the first element in the set with a key that is greater than the key.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the set being searched.  
  
### Return Value  
 A pair of iterators where the first is the [lower_bound](#set__lower_bound) of the key and the second is the [upper_bound](#set__upper_bound) of the key.  
  
 To access the first iterator of a pair <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>. **first**, and to dereference the lower bound iterator, use \*( <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>. **first**). To access the second iterator of a pair <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>. **second**, and to dereference the upper bound iterator, use \*( <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>. **second**).  
  
### Example  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  **The upper bound of the element with a key of 20 in the set s1 is: 30.**  
**The lower bound of the element with a key of 20 in the set s1 is: 20.**  
**A direct call of upper_bound( 20 ) gives 30,**  
**matching the 2nd element of the pair returned by equal_range( 20 ).**  
**The set s1 doesn't have an element with a key less than 40.**    
##  \<a name="set__erase">\</a>  set::erase  
 Removes an element or a range of elements in a set from specified positions or removes elements that match a specified key.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 Position of the element to be removed.  
  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 Position of the first element to be removed.  
  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 Position just beyond the last element to be removed.  
  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 The key value of the elements to be removed.  
  
### Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the set if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the set.  
  
### Remarks  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
##  \<a name="set__find">\</a>  set::find  
 Returns an iterator that refers to the location of an element in a set that has a key equivalent to a specified key.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 The key value to be matched by the sort key of an element from the set being searched.  
  
### Return Value  
 An iterator that refers to the location of an element with a specified key, or the location succeeding the last element in the set ( <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>) if no match is found for the key.  
  
### Remarks  
 The member function returns an iterator that refers to an element in the set whose key is equivalent to the argument <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> under a binary predicate that induces an ordering based on a less than comparability relation.  
  
 If the return value of **find** is assigned to a **const_iterator**, the set object cannot be modified. If the return value of **find** is assigned to an **iterator**, the set object can be modified  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
##  \<a name="set__get_allocator">\</a>  set::get_allocator  
 Returns a copy of the allocator object used to construct the set.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 The allocator used by the set to manage memory, which is the template parameter <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>, see the Remarks section of the [set Class](../vs140/set-class.md) topic.  
  
### Remarks  
 Allocators for the set class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
### Example  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
##  \<a name="set__insert">\</a>  set::insert  
 Inserts an element or a range of elements into a set.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>|The value of an element to be inserted into the set unless it already contains an element whose value is equivalently ordered.|  
|<CodeContentPlaceHolder>156\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (If that point immediately precedes <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>, insertion can occur in amortized constant time instead of logarithmic time.)|  
|<CodeContentPlaceHolder>158\</CodeContentPlaceHolder>|Template parameter that specifies the argument type that the set can use to construct an element of [value_type](../vs140/map-class.md#map__value_type), and perfect-forwards <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> as an argument.|  
|<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>|The position of the first element to be copied.|  
|<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>|The position just beyond the last element to be copied.|  
|<CodeContentPlaceHolder>162\</CodeContentPlaceHolder>|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map-class.md#map__value_type) objects.|  
|<CodeContentPlaceHolder>163\</CodeContentPlaceHolder>|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
### Return Value  
 The single-element member functions, (1) and (2), return a [pair](../vs140/pair-structure.md) whose <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> component is true if an insertion was made, and false if the set already contained an element of equivalent value in the ordering. The iterator component of the return-value pair points to the newly inserted element if the <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> component is true, or to the existing element if the <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> component is false.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the set or, if an element with an equivalent key already exists, to the existing element.  
  
### Remarks  
 No iterators, pointers, or references are invalidated by this function.  
  
 During the insertion of just one element, if an exception is thrown, the container's state is not modified. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 To access the iterator component of a <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> that's returned by the single-element member functions, use <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>; to dereference the iterator within the returned pair, use <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>, giving you an element. To access the <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> component, use <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>. For an example, see the sample code later in this article.  
  
 The [value_type](../vs140/map-class.md#map__value_type) of a container is a typedef that belongs to the container, and, for set, <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> is type <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>.  
  
 The range member function (5) inserts the sequence of element values into a set that corresponds to each element addressed by an iterator in the range <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>; therefore, <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> does not get inserted. The container member function <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> refers to the position just after the last element in the container—for example, the statement <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> attempts to insert all elements of <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>. Only elements that have unique values in the range are inserted; duplicates are ignored. To observe which elements are rejected, use the single-element versions of <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the set.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [set::emplace](#set__emplace) and [set::emplace_hint](#set__emplace_hint).  
  
### Example  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
##  \<a name="set__iterator">\</a>  set::iterator  
 A type that provides a constant [bidirectional iterator](../vs140/bidirectional_iterator_tag-struct.md) that can read any element in a set.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Example  
  See the example for [begin](#set__begin) for an example of how to declare and use an **iterator**.  
  
##  \<a name="set__key_comp">\</a>  set::key_comp  
 Retrieves a copy of the comparison object used to order keys in a set.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Return Value  
 Returns the function object that a set uses to order its elements, which is the template parameter <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> see the [set Class](../vs140/set-class.md) topic.  
  
### Remarks  
 The stored object defines the member function:  
  
 **bool operator()**( **const Key&**<CodeContentPlaceHolder>183\</CodeContentPlaceHolder>,  **const Key&**<CodeContentPlaceHolder>184\</CodeContentPlaceHolder>);  
  
 which returns **true** if <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> in the sort order.  
  
 Note that both [key_compare](#set__key_compare) and [value_compare](#set__value_compare) are synonyms for the template parameter **Traits**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
### Example  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  **kc1( 2,3 ) returns value of true, where kc1 is the function object of s1.**  
**kc2( 2,3 ) returns value of false, where kc2 is the function object of s2.**    
##  \<a name="set__key_compare">\</a>  set::key_compare  
 A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the set.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> see the [set Class](../vs140/set-class.md) topic.  
  
 Note that both <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> and [value_compare](#set__value_compare) are synonyms for the template parameter **Traits**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
### Example  
  See the example for [key_comp](#set__key_comp) for an example of how to declare and use <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>.  
  
##  \<a name="set__key_type">\</a>  set::key_type  
 A type that describes an object stored as an element of a set in its capacity as sort key.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>, see the Remarks section of the [set Class](../vs140/set-class.md) topic.  
  
 Note that both <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> and [value_type](#set__value_type) are synonyms for the template parameter **Key**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
### Example  
  See the example for [value_type](#set__value_type) for an example of how to declare and use <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>.  
  
##  \<a name="set__lower_bound">\</a>  set::lower_bound  
 Returns an iterator to the first element in a set with a key that is equal to or greater than a specified key.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the set being searched.  
  
### Return Value  
 An iterator or <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> that addresses the location of an element in a set that with a key that is equal to or greater than the argument key or that addresses the location succeeding the last element in the set if no match is found for the key.  
  
### Example  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  **The element of set s1 with a key of 20 is: 20.**  
**The set s1 doesn't have an element with a key of 40.**  
**The element of s1 with a key matching that of the last element is: 30.**    
##  \<a name="set__max_size">\</a>  set::max_size  
 Returns the maximum length of the set.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
 The maximum possible length of the set.  
  
### Example  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
##  \<a name="set__operator_eq">\</a>  set::operator=  
 Replaces the elements of this <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> using elements from another <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>201\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> providing new elements to be assigned to this <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>.|  
  
### Remarks  
 The first version of <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> uses an [lvalue reference](../vs140/lvalue-reference-declarator---.md) for <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>, to copy elements from <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> to this <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>.  
  
 The second version uses an [rvalue reference](../vs140/rvalue-reference-declarator----.md) for _Right. It moves elements from <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> to this <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>.  
  
 Any elements in this <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> before the operator function executes are discarded.  
  
### Example  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
##  \<a name="set__pointer">\</a>  set::pointer  
 A type that provides a pointer to an element in a set.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Remarks  
 A type **pointer** can be used to modify the value of an element.  
  
 In most cases, an [iterator](#set__iterator) should be used to access the elements in a set object.  
  
##  \<a name="set__rbegin">\</a>  set::rbegin  
 Returns an iterator addressing the first element in a reversed set.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed set or addressing what had been the last element in the unreversed set.  
  
### Remarks  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> is used with a reversed set just as [begin](#set__begin) is used with a set.  
  
 If the return value of <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>, then the set object cannot be modified. If the return value of <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>, then the set object can be modified.  
  
 <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> can be used to iterate through a set backwards.  
  
### Example  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  **The first element in the reversed set is 30.**  
**The set is: 10 20 30**  
**The reversed set is: 30 20 10**  
**After the erasure, the first element in the reversed set is 20.**    
##  \<a name="set__reference">\</a>  set::reference  
 A type that provides a reference to an element stored in a set.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  **The first element in the set is 10.**    
##  \<a name="set__rend">\</a>  set::rend  
 Returns an iterator that addresses the location succeeding the last element in a reversed set.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed set (the location that had preceded the first element in the unreversed set).  
  
### Remarks  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> is used with a reversed set just as [end](#set__end) is used with a set.  
  
 If the return value of <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>, then the set object cannot be modified. If the return value of <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>, then the set object can be modified. The value returned by <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> should not be dereferenced.  
  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its set.  
  
### Example  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
##  \<a name="set__reverse_iterator">\</a>  set::reverse_iterator  
 A type that provides a bidirectional iterator that can read or modify an element in a reversed set.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> is use to iterate through the set in reverse.  
  
### Example  
  See the example for [rbegin](#set__rbegin) for an example of how to declare and use <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>.  
  
##  \<a name="set__set">\</a>  set::set  
 Constructs a set that is empty or that is a copy of all or part of some other set.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>226\</CodeContentPlaceHolder>|The storage allocator class to be used for this set object, which defaults to **Allocator**.|  
|<CodeContentPlaceHolder>227\</CodeContentPlaceHolder>|The comparison function of type <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> used to order the elements in the set, which defaults to <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>230\</CodeContentPlaceHolder>|The set of which the constructed set is to be a copy.|  
|<CodeContentPlaceHolder>231\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>232\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>233\</CodeContentPlaceHolder>|The initializer_list from which to copy the elements.|  
  
### Remarks  
 All constructors store a type of allocator object that manages memory storage for the set and that can later be returned by calling [get_allocator](#set__get_allocator). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their sets.  
  
 All constructors store a function object of type **Traits** that is used to establish an order among the keys of the set and that can later be returned by calling [key_comp](#set__key_comp).  
  
 The first three constructors specify an empty initial set, the second specifying the type of comparison function ( <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifying the allocator type ( <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>) to be used. The keyword **explicit** suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the set <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>.  
  
 The next three constructors use an initializer_list to specify the elements.  
  
 The next three constructors copy the range [ <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>) of a set with increasing explicitness in specifying the type of comparison function of class **Traits** and **Allocator**.  
  
 The eighth constructor specifies a copy of the set by moving <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  **s1 = 10 20 30 40s2 = 10 20s3 = 30s4 = 10 20 30 40s5 = 10 20s6 = 10s7 = 10 20s8 = 1 2 3 4s9 = 5 6 7 8s10 = 10 20 30 40**    
##  \<a name="set__size">\</a>  set::size  
 Returns the number of elements in the set.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the set.  
  
### Example  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  **The set length is 1.**  
**The set length is now 2.**    
##  \<a name="set__size_type">\</a>  set::size_type  
 An unsigned integer type that can represent the number of elements in a set.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Example  
  See the example for [size](#set__size) for an example of how to declare and use <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
  
##  \<a name="set__swap">\</a>  set::swap  
 Exchanges the elements of two sets.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 The argument set providing the elements to be swapped with the target set.  
  
### Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two sets whose elements are being exchanged.  
  
### Example  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  **The original set s1 is: 10 20 30.**  
**After swapping with s2, list s1 is: 100 200.**  
**After swapping with s3, list s1 is: 300.**    
##  \<a name="set__upper_bound">\</a>  set::upper_bound  
 Returns an iterator to the first element in a set that with a key that is greater than a specified key.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the set being searched.  
  
### Return Value  
 An **iterator** or <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> that addresses the location of an element in a set that with a key that is greater than the argument key, or that addresses the location succeeding the last element in the set if no match is found for the key.  
  
### Example  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  **The first element of set s1 with a key greater than 20 is: 30.**  
**The set s1 doesn't have an element with a key greater than 30.**  
**The first element of s1 with a key greater than**  
**that of the initial element of s1 is: 20.**    
##  \<a name="set__value_comp">\</a>  set::value_comp  
 Retrieves a copy of the comparison object used to order element values in a set.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Return Value  
 Returns the function object that a set uses to order its elements, which is the template parameter <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> see the [set Class](../vs140/set-class.md) topic.  
  
### Remarks  
 The stored object defines the member function:  
  
 **bool operator**( **const Key&**<CodeContentPlaceHolder>246\</CodeContentPlaceHolder>, **const Key&**<CodeContentPlaceHolder>247\</CodeContentPlaceHolder>);  
  
 which returns **true** if <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> in the sort order.  
  
 Note that both [value_compare](#set__value_compare) and [key_compare](#set__key_compare) are synonyms for the template parameter **Traits**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
### Example  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  **vc1( 2,3 ) returns value of true, where vc1 is the function object of s1.**  
**vc2( 2,3 ) returns value of false, where vc2 is the function object of s2.**    
##  \<a name="set__value_compare">\</a>  set::value_compare  
 A type that provides a function object that can compare two element values to determine their relative order in the set.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> see the [set Class](../vs140/set-class.md) topic.  
  
 Note that both [key_compare](#set__key_compare) and **value_compare** are synonyms for the template parameter **Traits**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
### Example  
  See the example for [value_comp](#set__value_comp) for an example of how to declare and use <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>.  
  
##  \<a name="set__value_type">\</a>  set::value_type  
 A type that describes an object stored as an element of a set in its capacity as a value.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>, see the Remarks section of the [set Class](../vs140/set-class.md) topic.  
  
 Note that both [key_type](#set__key_type) and <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> are synonyms for the template parameter **Key**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
### Example  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  **The set has elements: 10 20.**    
## See Also  
 [\<set>](../vs140/-set-.md)   
 [Containers](../vs140/containers--modern-c---.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)