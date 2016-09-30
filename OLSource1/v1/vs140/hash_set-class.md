---
title: "hash_set Class"
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
  - "hash_set/stdext::hash_set"
  - "std::hash_set"
  - "std.hash_set"
  - "stdext::hash_set"
  - "hash_set"
  - "stdext.hash_set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash_set class"
ms.assetid: c765c06e-cbb6-48c2-93ca-d15468eb28d7
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set Class
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 The container class hash_set is an extension of the Standard Template Library (STL) and is used for the storage and fast retrieval of data from a collection in which the values of the elements contained are unique and serve as the key values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The element data type to be stored in the hash_set.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The type which includes two function objects, one of class compare that is a binary predicate able to compare two element values as sort keys to determine their relative order and a hash function that is a unary predicate mapping key values of the elements to unsigned integers of type **size_t**. This argument is optional, and the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>*<Key,* **less***\<Key> >* is the default value.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the hash_set's allocation and deallocation of memory. This argument is optional, and the default value is **allocator***\<Key>.*  
  
## Remarks  
 The hash_set is:  
  
-   An associative container, which a variable size container that supports the efficient retrieval of element values based on an associated key value. Further, it is a simple associative container because its element values are its key values.  
  
-   Reversible, because it provides a bidirectional iterator to access its elements.  
  
-   Hashed, because its elements are grouped into buckets based on the value of a hash function applied to the key values of the elements.  
  
-   Unique in the sense that each of its elements must have a unique key. Because hash_set is also a simple associative container, its elements are also unique.  
  
-   A template class because the functionality it provides is generic and so independent of the specific type of data contained as elements or keys. The data types to be used for elements and keys are, instead, specified as parameters in the class template along with the comparison function and allocator.  
  
 The main advantage of hashing over sorting is greater efficiency; a successful hashing performs insertions, deletions, and finds in constant average time as compared with a time proportional to the logarithm of the number of elements in the container for sorting techniques. The value of an element in a set may not be changed directly. Instead, you must delete old values and insert elements with new values.  
  
 The choice of container type should be based in general on the type of searching and inserting required by the application. Hashed associative containers are optimized for the operations of lookup, insertion and removal. The member functions that explicitly support these operations are efficient when used with a well-designed hash function, performing them in a time that is on average constant and not dependent on the number of elements in the container. A well-designed hash function produces a uniform distribution of hashed values and minimizes the number of collisions, where a collision is said to occur when distinct key values are mapped into the same hashed value. In the worst case, with the worst possible hash function, the number of operations is proportional to the number of elements in the sequence (linear time).  
  
 The hash_set should be the associative container of choice when the conditions associating the values with their keys are satisfied by the application. The elements of a hash_set are unique and serve as their own sort keys. A model for this type of structure is an ordered list of, say, words in which the words may occur only once. If multiple occurrences of the words were allowed, then a hash_multiset would be the appropriate container structure. If values need to be attached to a list of unique key words, then a hash_map would be an appropriate structure to contain this data. If instead the keys are not unique, then a hash_multimap would be the container of choice.  
  
 The hash_set orders the sequence it controls by calling a stored hash **Traits** object of type [value_compare](#hash_set__value_compare). This stored object may be accessed by calling the member function [key_comp](#hash_set__key_comp). Such a function object must behave the same as an object of class                 *hash_compare<Key, less\<Key> >.* Specifically, for all values <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> of type Key, the call Trait( <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> ) yields a distribution of values of type size_t.  
  
 In general, the elements need be merely less than comparable to establish this order: so that, given any two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the non-equivalent elements. On a more technical note, the comparison function is a binary predicate that induces a strict weak ordering in the standard mathematical sense. A binary predicate                 *f*(                *x*,                *y*) is a function object that has two argument objects x and y and a return value of true or false. An ordering imposed on a hash_set is a strict weak ordering if the binary predicate is irreflexive, antisymmetric, and transitive and if equivalence is transitive, where two objects                 *x* and                 *y* are defined to be equivalent when both                 *f*(                *x*,                *y*) and                 *f*(                *y*,                *x*) are false. If the stronger condition of equality between keys replaces that of equivalence, then the ordering becomes total (in the sense that all the elements are ordered with respect to each other) and the keys matched will be indiscernible from each other.  
  
 The actual order of elements in the controlled sequence depends on the hash function, the ordering function, and the current size of the hash table stored in the container object. You cannot determine the current size of the hash table, so you cannot in general predict the order of elements in the controlled sequence. Inserting elements invalidates no iterators, and removing elements invalidates only those iterators that had specifically pointed at the removed elements.  
  
 The iterator provided by the hash_set class is a bidirectional iterator, but the class member functions [insert](#hash_set__insert) and [hash_set](#hash_set__hash_set) have versions that take as template parameters a weaker input iterator, whose functionality requirements are more minimal than those guaranteed by the class of bidirectional iterators. The different iterator concepts form a family related by refinements in their functionality. Each iterator concept has its own set of requirements, and the algorithms that work with them must limit their assumptions to the requirements provided by that type of iterator. It may be assumed that an input iterator may be dereferenced to refer to some object and that it may be incremented to the next iterator in the sequence. This is a minimal set of functionality, but it is enough to be able to talk meaningfully about a range of iterators [ <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>) in the context of the class member functions.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Constructors  
  
|||  
|-|-|  
|[hash_set](#hash_set__hash_set)|Constructs a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> that is empty or that is a copy of all or part of some other <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#hash_set__allocator_type)|A type that represents the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> class for the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object.|  
|[const_iterator](#hash_set__const_iterator)|A type that provides a bidirectional iterator that can read a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.|  
|[const_pointer](#hash_set__const_pointer)|A type that provides a pointer to a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>.|  
|[const_reference](#hash_set__const_reference)|A type that provides a reference to a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> element stored in a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> for reading and performing <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> operations.|  
|[const_reverse_iterator](#hash_set__const_reverse_iterator)|A type that provides a bidirectional iterator that can read any <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.|  
|[difference_type](#hash_set__difference_type)|A signed integer type that can be used to represent the number of elements of a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> in a range between elements pointed to by iterators.|  
|[iterator](#hash_set__iterator)|A type that provides a bidirectional iterator that can read or modify any element in a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.|  
|[key_compare](#hash_set__key_compare)|A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.|  
|[key_type](#hash_set__key_type)|A type that describes an object stored as an element of a <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> in its capacity as sort key.|  
|[pointer](#hash_set__pointer)|A type that provides a pointer to an element in a <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.|  
|[reference](#hash_set__reference)|A type that provides a reference to an element stored in a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.|  
|[reverse_iterator](#hash_set__reverse_iterator)|A type that provides a bidirectional iterator that can read or modify an element in a reversed <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.|  
|[size_type](#hash_set__size_type)|An unsigned integer type that can represent the number of elements in a <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.|  
|[value_compare](#hash_set__value_compare)|A type that provides two function objects, a binary predicate of class compare that can compare two element values of a <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> to determine their relative order and a unary predicate that hashes the elements.|  
|[value_type](#hash_set__value_type)|A type that describes an object stored as an element of a <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> in its capacity as a value.|  
  
### Member Functions  
  
|||  
|-|-|  
|[begin](#hash_set__begin)|Returns an iterator that addresses the first element in the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.|  
|[cbegin](#hash_set__cbegin)|Returns a const iterator addressing the first element in the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.|  
|[cend](#hash_set__cend)|Returns a const iterator that addresses the location succeeding the last element in a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.|  
|[clear](#hash_set__clear)|Erases all the elements of a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.|  
|[count](#hash_set__count)|Returns the number of elements in a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> whose key matches a parameter-specified key.|  
|[crbegin](#hash_set__crbegin)|Returns a const iterator addressing the first element in a reversed <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.|  
|[crend](#hash_set__crend)|Returns a const iterator that addresses the location succeeding the last element in a reversed <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.|  
|[emplace](#hash_set__emplace)|Inserts an element constructed in place into a <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.|  
|[emplace_hint](#hash_set__emplace_hint)|Inserts an element constructed in place into a <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>, with a placement hint.|  
|[empty](#hash_set__empty)|Tests if a <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> is empty.|  
|[end](#hash_set__end)|Returns an iterator that addresses the location succeeding the last element in a <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.|  
|[equal_range](#hash_set__equal_range)|Returns a pair of iterators respectively to the first element in a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> with a key that is greater than a specified key and to the first element in the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> with a key that is equal to or greater than the key.|  
|[erase](#hash_set__erase)|Removes an element or a range of elements in a <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> from specified positions or removes elements that match a specified key.|  
|[find](#hash_set__find)|Returns an iterator addressing the location of an element in a <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> that has a key equivalent to a specified key.|  
|[get_allocator](#hash_set__get_allocator)|Returns a copy of the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object used to construct the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.|  
|[insert](#hash_set__insert)|Inserts an element or a range of elements into a <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.|  
|[key_comp](#hash_set__key_comp)|Retrieves a copy of the comparison object used to order keys in a <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.|  
|[lower_bound](#hash_set__lower_bound)|Returns an iterator to the first element in a <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> with a key that is equal to or greater than a specified key.|  
|[max_size](#hash_set__max_size)|Returns the maximum length of the <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.|  
|[rbegin](#hash_set__rbegin)|Returns an iterator addressing the first element in a reversed <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.|  
|[rend](#hash_set__rend)|Returns an iterator that addresses the location succeeding the last element in a reversed <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.|  
|[size](#hash_set__size)|Returns the number of elements in the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.|  
|[swap](#hash_set__swap)|Exchanges the elements of two <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>s.|  
|[upper_bound](#hash_set__upper_bound)|Returns an iterator to the first element in a <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> that with a key that is equal to or greater than a specified key.|  
|[value_comp](#hash_set__value_comp)|Retrieves a copy of the hash traits object used to hash and order element key values in a <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#hash_set__operator_eq)|Replaces the elements of a <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> with a copy of another <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
##  \<a name="hash_set__allocator_type">\</a>  hash_set::allocator_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that represents the allocator class for the hash_set object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 **allocator_type** is a synonym for the template parameter <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>, see the Remarks section of the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [get_allocator](#hash_set__get_allocator) for an example that uses <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_set__begin">\</a>  hash_set::begin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator that addresses the first element in the hash_set.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator addressing the first element in the hash_set or the location succeeding an empty hash_set.  
  
### Remarks  
 If the return value of **begin** is assigned to a <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>, the elements in the hash_set object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the hash_set object can be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The first element of hs1 is 1**  
**The first element of hs1 is now 2**    
##  \<a name="hash_set__cbegin">\</a>  hash_set::cbegin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns a const iterator that addresses the first element in the hash_set.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A const bidirectional iterator addressing the first element in the [hash_set](../vs140/hash_set-class.md) or the location succeeding an empty <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>, the elements in the <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> object cannot be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The first element of hs1 is 1**    
##  \<a name="hash_set__cend">\</a>  hash_set::cend  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a hash_set.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A const bidirectional iterator that addresses the location succeeding the last element in a [hash_set](../vs140/hash_set-class.md). If the <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> is empty, then <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> is used to test whether an iterator has reached the end of its <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>. The value returned by <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The last element of hs1 is 3**    
##  \<a name="hash_set__clear">\</a>  hash_set::clear  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Erases all the elements of a hash_set.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The size of the hash_set is initially 2.**  
**The size of the hash_set after clearing is 0.**    
##  \<a name="hash_set__const_iterator">\</a>  hash_set::const_iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a bidirectional iterator that can read a **const** element in the hash_set.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [begin](#hash_set__begin) for an example that uses <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_set__const_pointer">\</a>  hash_set::const_pointer  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a pointer to a **const** element in a hash_set.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 In most cases, a [const_iterator](#hash_set__const_iterator) should be used to access the elements in a **const** hash_set object.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
##  \<a name="hash_set__const_reference">\</a>  hash_set::const_reference  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a reference to a **const** element stored in a hash_set for reading and performing **const** operations.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The first element in the hash_set is 10.**    
##  \<a name="hash_set__const_reverse_iterator">\</a>  hash_set::const_reverse_iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a bidirectional iterator that can read any **const** element in the hash_set.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> cannot modify the value of an element and is use to iterate through the hash_set in reverse.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [rend](#hash_set__rend) for an example of how to declare and use the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
  
##  \<a name="hash_set__count">\</a>  hash_set::count  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns the number of elements in a hash_set whose key matches a parameter-specified key.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 The key of the elements to be matched from the hash_set.  
  
### Return Value  
 1 if the hash_set contains an element whose sort key matches the parameter key.  
  
 0 if the hash_set does not contain an element with a matching key.  
  
### Remarks  
 The member function returns the number of elements in the following range:  
  
 [ **lower_bound** (_                        *Key* ),  **upper_bound** (\_                        *Key* ) ).  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  The following example demonstrates the use of the hash_set::count member function.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **The number of elements in hs1 with a sort key of 1 is: 1.**  
**The number of elements in hs1 with a sort key of 2 is: 0.**    
##  \<a name="hash_set__crbegin">\</a>  hash_set::crbegin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns a const iterator addressing the first element in a reversed hash_set.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [hash_set](../vs140/hash_set-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> is used with a reversed hash_set just as [begin](#hash_set__begin) is used with a hash_set.  
  
 With the return value of <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> can be used to iterate through a <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The first element in the reversed hash_set is 30.**    
##  \<a name="hash_set__crend">\</a>  hash_set::crend  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a reversed hash_set.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [hash_set](../vs140/hash_set-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>).  
  
### Remarks  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> just as [end](#hash_set__end) is used with a <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **The last element in the reversed hash_set is 10.**    
##  \<a name="hash_set__difference_type">\</a>  hash_set::difference_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A signed integer type that can be used to represent the number of elements of a hash_set in a range between elements pointed to by iterators.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> is the type returned when subtracting or incrementing through iterators of the container. The <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> is typically used to represent the number of elements in the range [ <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>) between the iterators <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>, includes the element pointed to by <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> and the range of elements up to, but not including, the element pointed to by <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
 Note that although <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers such as set, subtraction between iterators is only supported by random-access iterators provided by a random access container, such as vector or deque.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The number '5' occurs 0 times in hash_set hs1.**  
**The number '10' occurs 1 times in hash_set hs1.**  
**The number '20' occurs 1 times in hash_set hs1.**  
**The number of elements in the hash_set hs1 is: 2.**    
##  \<a name="hash_set__emplace">\</a>  hash_set::emplace  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Inserts an element constructed in place into a hash_set.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>173\</CodeContentPlaceHolder>|The value of an element to be inserted into the [hash_set](../vs140/hash_set-class.md) unless the <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> already contains that element or, more generally, an element whose key is equivalently ordered.|  
  
### Return Value  
 The <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> member function returns a pair whose <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> component returns <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> if an insertion was make and <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **After the emplace insertion, hs3 contains a.**    
##  \<a name="hash_set__emplace_hint">\</a>  hash_set::emplace_hint  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Inserts an element constructed in place into a hash_set.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>180\</CodeContentPlaceHolder>|The value of an element to be inserted into the [hash_set](../vs140/hash_set-class.md) unless the <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> already contains that element or, more generally, an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>182\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.)|  
  
### Return Value  
 The [emplace](#hash_set__emplace) member function returns an iterator that points to the position where the new element was inserted into the <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>, or where the existing element with equivalent ordering is located.  
  
### Remarks  
 Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **After the emplace insertion, hs3 contains a.**    
##  \<a name="hash_set__empty">\</a>  hash_set::empty  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Tests if a hash_set is empty.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the hash_set is empty; **false** if the hash_set is nonempty.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **The hash_set hs1 is not empty.**  
**The hash_set hs2 is empty.**    
##  \<a name="hash_set__end">\</a>  hash_set::end  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a hash_set.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator that addresses the location succeeding the last element in a hash_set. If the hash_set is empty, then hash_set::end == hash_set::begin.  
  
### Remarks  
 **end** is used to test whether an iterator has reached the end of its hash_set. The value returned by **end** should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **The last element of hs1 is 3**  
**The last element of hs1 is now 2**    
##  \<a name="hash_set__equal_range">\</a>  hash_set::equal_range  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns a pair of iterators respectively to the first element in a hash set with a key that is equal to a specified key and to the first element in the hash set with a key that is greater than the key.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the hash_set being searched.  
  
### Return Value  
 A pair of iterators where the first is the [lower_bound](../vs140/set-class.md#set__lower_bound) of the key and the second is the [upper_bound](../vs140/set-class.md#set__upper_bound) of the key.  
  
 To access the first iterator of a pair pr returned by the member function, use <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>. **first**, and to dereference the lower bound iterator, use \*( <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>. **first**). To access the second iterator of a pair <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>. **second**, and to dereference the upper bound iterator, use \*( <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>. **second**).  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  **The upper bound of the element with a key of 20 in the hash_set hs1 is: 30.**  
**The lower bound of the element with a key of 20 in the hash_set hs1 is: 20.**  
**A direct call of upper_bound( 20 ) gives 30,**  
**matching the 2nd element of the pair returned by equal_range( 20 ).**  
**The hash_set hs1 doesn't have an element with a key greater than or equal to 40.**    
##  \<a name="hash_set__erase">\</a>  hash_set::erase  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Removes an element or a range of elements in a hash_set from specified positions or removes elements that match a specified key.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 Position of the element to be removed from the hash_set.  
  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 Position of the first element removed from the hash_set.  
  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 Position just beyond the last element removed from the hash_set.  
  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 The key of the elements to be removed from the hash_set.  
  
### Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the hash_set if no such element exists. For the third member function, the number of elements that have been removed from the hash_set.  
  
### Remarks  
 The member functions never throw an exception.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  The following example demonstrates the use of the hash_set::erase member function.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  **After the 2nd element is deleted, the hash_set hs1 is: 1 3 4.**  
**After the middle two elements are deleted, the hash_set hs2 is: 16 4.**  
**After the element with a key of 2 is deleted, the hash_set hs3 is: 0 1 3.**  
**The number of elements removed from hs3 is: 1.**  
**After another element (unique for hash_set) with a key**   
**equal to that of the 2nd element is deleted, the hash_set hs3 is: 0 3.**    
##  \<a name="hash_set__find">\</a>  hash_set::find  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator addressing the location of an element in a hash_set that has a key equivalent to a specified key.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 The argument key to be matched by the sort key of an element from the hash_set being searched.  
  
### Return Value  
 An **iterator** or <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> that addresses the location of an element equivalent to a specified key or that addresses the location succeeding the last element in the hash_set if no match is found for the key.  
  
### Remarks  
 The member function returns an iterator that addresses an element in the hash_set whose sort key is **equivalent** to the argument key under a binary predicate that induces an ordering based on a less-than comparability relation.  
  
 If the return value of **find** is assigned to a <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>, the hash_set object cannot be modified. If the return value of **find** is assigned to an **iterator**, the hash_set object can be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  **The element of hash_set hs1 with a key of 20 is: 20.**  
**The hash_set hs1 doesn't have an element with a key of 40.**  
**The element of hs1 with a key matching that of the last element is: 30.**    
##  \<a name="hash_set__get_allocator">\</a>  hash_set::get_allocator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns a copy of the allocator object used to construct the hash_set.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 The allocator used by the hash_set to manage memory, which is the template parameter <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>, see the Remarks section of the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
### Remarks  
 Allocators for the hash_set class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
##  \<a name="hash_set__hash_set">\</a>  hash_set::hash_set  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Constructs a <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> that is empty or that is a copy of all or part of some other <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>203\</CodeContentPlaceHolder>|The storage allocator class to be used for this <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> object, which defaults to <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>206\</CodeContentPlaceHolder>|The comparison function of type <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> used to order the elements in the <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>, which defaults to <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>210\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> of which the constructed <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> is to be a copy.|  
|<CodeContentPlaceHolder>213\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>214\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
  
### Remarks  
 All constructors store a type of allocator object that manages memory storage for the <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> and that can later be returned by calling [hash_set::get_allocator](#hash_set__get_allocator). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their hash_sets.  
  
 All constructors store a function object of type <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> that is used to establish an order among the keys of the <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> and that can later be returned by calling [hash_set::key_comp](#hash_set__key_comp). For more information on <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> see the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
 The first constructor creates an empty initial <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> The second specifies the type of comparison function ( <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>) to be used in establishing the order of the elements, and the third explicitly specifies the allocator type ( <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>) to be used. The key word <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth and fifth constructors specify a copy of the <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>.  
  
 The last sixth, seventh, and eighth constructors use an initializer_list for the elements.  
  
 The last constructors copy the range [ <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>) of a <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> with increasing explicitness in specifying the type of comparison function of class Traits and allocator.  
  
 The eighth constructor moves the <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>.  
  
 The actual order of elements in a <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> container depends on the hash function, the ordering function and the current size of the hash table and cannot, in general, be predicted as it could with the set container, where it was determined by the ordering function alone.  
  
##  \<a name="hash_set__insert">\</a>  hash_set::insert  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Inserts an element or a range of elements into a <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>230\</CodeContentPlaceHolder>|The value of an element to be inserted into the <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> unless the <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> already contains that element or, more generally, an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>233\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>.)|  
|<CodeContentPlaceHolder>235\</CodeContentPlaceHolder>|The position of the first element to be copied from a <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>237\</CodeContentPlaceHolder>|The position just beyond the last element to be copied from a <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>239\</CodeContentPlaceHolder>|The initializer_list from which to copy the elements.|  
  
### Return Value  
 The first <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> member function returns a pair whose <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> component returns <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> if an insertion was make and <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
 To access the iterator component of a pair <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> and to dereference it, use <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>. To access the <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> component of a pair <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>, and to dereference it, use <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>.  
  
 The second <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> member function returns an iterator that points to the position where the new element was inserted into the <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>.  
  
### Remarks  
 The third member function inserts the elements in an initializer_list.  
  
 The third member function inserts the sequence of element values into a <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> corresponding to each element addressed by an iterator of in the range [ <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>) of a specified <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_set__iterator">\</a>  hash_set::iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify any element in a hash_set.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Remarks  
 A type **iterator** can be used to modify the value of an element.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [begin](#hash_set__begin) for an example of how to declare and use **iterator**.  
  
##  \<a name="hash_set__key_comp">\</a>  hash_set::key_comp  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Retrieves a copy of the hash traits object used to hash and order element key values in a hash_set.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 Returns the function object that a hash_set uses to order its elements, which is the template parameter <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> see the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
### Remarks  
 The stored object defines the member function:  
  
 **bool operator**( **const Key&** _                        *xVal*,  **const Key&** \_ <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>);  
  
 which returns **true** if <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> in the sort order.  
  
 Note that both [key_compare](#hash_set__key_compare) and [value_compare](#hash_set__value_compare) are synonyms for the template parameter **Traits**. Both types are provided for the hash_set and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
##  \<a name="hash_set__key_compare">\</a>  hash_set::key_compare  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the hash_set.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> see the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
 Note that both <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> and [value_compare](#hash_set__value_compare) are synonyms for the template parameter **Traits**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [key_comp](#hash_set__key_comp) for an example of how to declare and use <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_set__key_type">\</a>  hash_set::key_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that describes an object stored as an element of a hash_set in its capacity as sort key.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Remarks  
 **key_type** is a synonym for the template parameter <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>, see the Remarks section of the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
 Note that both <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> and [value_type](#hash_set__value_type) are synonyms for the template parameter **Key**. Both types are provided for the hash_set and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [value_type](#hash_set__value_type) for an example of how to declare and use <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_set__lower_bound">\</a>  hash_set::lower_bound  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator to the first element in a hash_set with a key that is equal to or greater than a specified key.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the hash_set being searched.  
  
### Return Value  
 An **iterator** or <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> that addresses the location of an element in a hash_set that with a key that is equal to or greater than the argument key or that addresses the location succeeding the last element in the hash_set if no match is found for the key.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  **The element of hash_set hs1 with a key of 20 is: 20.**  
**The hash_set hs1 doesn't have an element with a key of 40.**  
**The element of hs1 with a key matching that of the last element is: 30.**    
##  \<a name="hash_set__max_size">\</a>  hash_set::max_size  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns the maximum length of the hash_set.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Return Value  
 The maximum possible length of the hash_set.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
##  \<a name="hash_set__operator_eq">\</a>  hash_set::operator=  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Replaces the elements of the hash_set with a copy of another hash_set.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>274\</CodeContentPlaceHolder>|The [hash_set](../vs140/hash_set-class.md) being copied into the <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>.|  
  
### Remarks  
 After erasing any existing elements in a <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> either copies or moves the contents of <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
##  \<a name="hash_set__pointer">\</a>  hash_set::pointer  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a pointer to an element in a hash_set.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Remarks  
 A type **pointer** can be used to modify the value of an element.  
  
 In most cases, an [iterator](#hash_set__iterator) should be used to access the elements in a hash_set object.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
##  \<a name="hash_set__rbegin">\</a>  hash_set::rbegin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator addressing the first element in a reversed hash_set.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed hash_set or addressing what had been the last element in the unreversed hash_set.  
  
### Remarks  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> is used with a reversed hash_set just as [begin](#hash_set__begin) is used with a hash_set.  
  
 If the return value of <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>, then the hash_set object cannot be modified. If the return value of <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>, then the hash_set object can be modified.  
  
 <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> can be used to iterate through a hash_set backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  **The first element in the reversed hash_set is 30.**  
**The hash_set is: 10 20 30**   
**The reversed hash_set is: 30 20 10**   
**After the erasure, the first element in the reversed hash_set is 20.**    
##  \<a name="hash_set__reference">\</a>  hash_set::reference  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a reference to an element stored in a hash_set.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  **The first element in the hash_set is 10.**  
**The first element in the hash_set is now 15.**    
##  \<a name="hash_set__rend">\</a>  hash_set::rend  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a reversed hash_set.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed hash_set (the location that had preceded the first element in the unreversed hash_set).  
  
### Remarks  
 <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> is used with a reversed hash_set just as [end](#hash_set__end) is used with a hash_set.  
  
 If the return value of <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>, then the hash_set object cannot be modified. If the return value of <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>, then the hash_set object can be modified. The value returned by <CodeContentPlaceHolder>291\</CodeContentPlaceHolder> should not be dereferenced.  
  
 <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its hash_set.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  **The last element in the reversed hash_set is 10.**  
**The hash_set is: 10 20 30 .**  
**The reversed hash_set is: 30 20 10 .**  
**After the erasure, the last element in the reversed hash_set is 20.**    
##  \<a name="hash_set__reverse_iterator">\</a>  hash_set::reverse_iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify an element in a reversed hash_set.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> is use to iterate through the hash_set in reverse.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [rbegin](#hash_set__rbegin) for an example of how to declare and use <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_set__size">\</a>  hash_set::size  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns the number of elements in the hash_set.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the hash_set.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  **The hash_set length is 1.**  
**The hash_set length is now 2.**    
##  \<a name="hash_set__size_type">\</a>  hash_set::size_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 An unsigned integer type that can represent the number of elements in a hash_set.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [size](#hash_set__size) for an example of how to declare and use <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>  
  
##  \<a name="hash_set__swap">\</a>  hash_set::swap  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Exchanges the elements of two hash_sets.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
 The argument hash_set providing the elements to be swapped with the target hash_set.  
  
### Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two hash_sets whose elements are being exchanged.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  **The original hash_set hs1 is: 10 20 30.**  
**After swapping with hs2, list hs1 is: 200 100.**  
**After swapping with hs3, list hs1 is: 300.**    
##  \<a name="hash_set__upper_bound">\</a>  hash_set::upper_bound  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator to the first element in a hash_set that with a key that is greater than a specified key.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the hash_set being searched.  
  
### Return Value  
 An **iterator** or <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> that addresses the location of an element in a hash_set that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the hash_set if no match is found for the key.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  **The first element of hash_set hs1 with a key greater than 20 is: 30.**  
**The hash_set hs1 doesn't have an element with a key greater than 30.**  
**The first element of hs1 with a key greater than**   
**that of the initial element of hs1 is: 20.**    
##  \<a name="hash_set__value_comp">\</a>  hash_set::value_comp  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Retrieves a copy of the comparison object used to order element values in a hash_set.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Return Value  
 Returns the function object that a hash_set uses to order its elements, which is the template parameter <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>, see the Remarks section of the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
### Remarks  
 The stored object defines the member function:  
  
 **bool operator**( **const Key&** _                        *xVal*, **const Key&** \_ <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>);  
  
 which returns **true** if <CodeContentPlaceHolder>302\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>303\</CodeContentPlaceHolder> in the sort order.  
  
 Note that both [value_compare](../vs140/set-class.md#set__value_compare) and [key_compare](../vs140/set-class.md#set__key_compare) are synonyms for the template parameter <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>. Both types are provided for the hash_set and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
##  \<a name="hash_set__value_compare">\</a>  hash_set::value_compare  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides two function objects, a binary predicate of class compare that can compare two element values of a hash_set to determine their relative order and a unary predicate that hashes the elements.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Remarks  
 **value_compare** is a synonym for the template parameter <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> see the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
 Note that both [key_compare](#hash_set__key_compare) and **value_compare** are synonyms for the template parameter **Traits**. Both types are provided for the hash_set and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [value_comp](#hash_set__value_comp) for an example of how to declare and use <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_set__value_type">\</a>  hash_set::value_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that describes an object stored as an element of a hash_set in its capacity as a value.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  **The hash_set has elements: 10 20.**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)