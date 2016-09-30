---
title: "hash_multiset Class"
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
  - "stdext.hash_multiset"
  - "std::hash_multiset"
  - "stdext::hash_multiset"
  - "hash_multiset"
  - "std.hash_multiset"
  - "hash_set/stdext::hash_multiset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash_multiset class"
ms.assetid: 0580397a-a76e-40ad-aea2-5c6f3a9d0a21
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset Class
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 The container class hash_multiset is an extension of the Standard Template Library and is used for the storage and fast retrieval of data from a collection in which the values of the elements contained serve as the key values and are not required to be unique.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Key*  
 The element data type to be stored in the hash_multiset.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The type which includes two function objects, one of class compare that is a binary predicate able to compare two element values as sort keys to determine their relative order and a hash function that is a unary predicate mapping key values of the elements to unsigned integers of type **size_t**. This argument is optional, and the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>*<Key,* **less***\<Key> >* is the default value.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the hash_multiset's allocation and deallocation of memory. This argument is optional, and the default value is **allocator***\<Key>.*  
  
## Remarks  
 The hash_multiset is:  
  
-   An associative container, which a variable size container that supports the efficient retrieval of element values based on an associated key value. Further, it is a simple associative container because its element values are its key values.  
  
-   Reversible, because it provides a bidirectional iterator to access its elements.  
  
-   Hashed, because its elements are grouped into buckets based on the value of a hash function applied to the key values of the elements.  
  
-   Unique in the sense that each of its elements must have a unique key. Because hash_multiset is also a simple associative container, its elements are also unique.  
  
-   A template class because the functionality it provides is generic and so independent of the specific type of data contained as elements or keys. The data types to be used for elements and keys are, instead, specified as parameters in the class template along with the comparison function and allocator.  
  
 The main advantage of hashing over sorting is greater efficiency: a successful hashing performs insertions, deletions, and finds in constant average time as compared with a time proportional to the logarithm of the number of elements in the container for sorting techniques. The value of an element in a set may not be changed directly. Instead, you must delete old values and insert elements with new values.  
  
 The choice of container type should be based in general on the type of searching and inserting required by the application. Hashed associative containers are optimized for the operations of lookup, insertion and removal. The member functions that explicitly support these operations are efficient when used with a well-designed hash function, performing them in a time that is on average constant and not dependent on the number of elements in the container. A well-designed hash function produces a uniform distribution of hashed values and minimizes the number of collisions, where a collision is said to occur when distinct key values are mapped into the same hashed value. In the worst case, with the worst possible hash function, the number of operations is proportional to the number of elements in the sequence (linear time).  
  
 The hash_multiset should be the associative container of choice when the conditions associating the values with their keys are satisfies by the application. The elements of a hash_multiset may be multiple and serve as their own sort keys, so keys are not unique. A model for this type of structure is an ordered list of, say, words in which the words may occur more than once. Had multiple occurrences of the words not been allowed, then a hash_set would have been the appropriate container structure. If unique definitions were attached as values to the list of unique keywords, then a hash_map would be an appropriate structure to contain this data. If instead the definitions were not unique, then a hash_multimap would be the container of choice.  
  
 The hash_multiset orders the sequence it controls by calling a stored hash traits object of type [value_compare](#hash_multiset__value_compare). This stored object may be accessed by calling the member function [key_comp](#hash_multiset__key_comp). Such a function object must behave the same as an object of class <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>*<Key,* **less***\<Key> >.* Specifically, for all values                 *Key* of type **Key**, the call **Trait**(                *Key*) yields a distribution of values of type **size_t**.  
  
 In general, the elements need be merely less than comparable to establish this order: so that, given any two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. On a more technical note, the comparison function is a binary predicate that induces a strict weak ordering in the standard mathematical sense. A binary predicate                 *f*(                *x*,                *y*) is a function object that has two argument objects x and y and a return value of true or false. An ordering imposed on a hash_multiset is a strict weak ordering if the binary predicate is irreflexive, antisymmetric, and transitive and if equivalence is transitive, where two objects x and y are defined to be equivalent when both                 *f*(                *x*,                *y*) and                 *f*(                *y*,                *x*) are false. If the stronger condition of equality between keys replaces that of equivalence, then the ordering becomes total (in the sense that all the elements are ordered with respect to each other) and the keys matched will be indiscernible from each other.  
  
 The actual order of elements in the controlled sequence depends on the hash function, the ordering function, and the current size of the hash table stored in the container object. You cannot determine the current size of the hash table, so you cannot in general predict the order of elements in the controlled sequence. Inserting elements invalidates no iterators, and removing elements invalidates only those iterators that had specifically pointed at the removed elements.  
  
 The iterator provided by the hash_multiset class is a bidirectional iterator, but the class member functions insert and hash_multiset have versions that take as template parameters a weaker input iterator, whose functionality requirements are more minimal than those guaranteed by the class of bidirectional iterators. The different iterator concepts form a family related by refinements in their functionality. Each iterator concept has its own hash_multiset of requirements, and the algorithms that work with them must limit their assumptions to the requirements provided by that type of iterator. It may be assumed that an input iterator may be dereferenced to refer to some object and that it may be incremented to the next iterator in the sequence. This is a minimal hash_multiset of functionality, but it is enough to be able to talk meaningfully about a range of iterators [ <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>) in the context of the class member functions.  
  
 In Visual C++ .NET 2003, members of the \<hash_map> and \<hash_set> header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Constructors  
  
|||  
|-|-|  
|[hash_multiset](#hash_multiset__hash_multiset)|Constructs a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> that is empty or that is a copy of all or part of some other <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#hash_multiset__allocator_type)|A type that represents the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> class for the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object.|  
|[const_iterator](#hash_multiset__const_iterator)|A type that provides a bidirectional iterator that can read a <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.|  
|[const_pointer](#hash_multiset__const_pointer)|A type that provides a pointer to a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.|  
|[const_reference](#hash_multiset__const_reference)|A type that provides a reference to a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> element stored in a <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> for reading and performing <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> operations.|  
|[const_reverse_iterator](#hash_multiset__const_reverse_iterator)|A type that provides a bidirectional iterator that can read any <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.|  
|[difference_type](#hash_multiset__difference_type)|A signed integer type that provides the difference between two iterators that address elements within the same <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.|  
|[iterator](#hash_multiset__iterator)|A type that provides a bidirectional iterator that can read or modify any element in a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.|  
|[key_compare](#hash_multiset__key_compare)|A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.|  
|[key_type](#hash_multiset__key_type)|A type that describes an object stored as an element of a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> in its capacity as sort key.|  
|[pointer](#hash_multiset__pointer)|A type that provides a pointer to an element in a <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.|  
|[reference](#hash_multiset__reference)|A type that provides a reference to an element stored in a <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.|  
|[reverse_iterator](#hash_multiset__reverse_iterator)|A type that provides a bidirectional iterator that can read or modify an element in a reversed <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.|  
|[size_type](#hash_multiset__size_type)|An unsigned integer type that can represent the number of elements in a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.|  
|[value_compare](#hash_multiset__value_compare)|A type that provides two function objects, a binary predicate of class compare that can compare two element values of a <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> to determine their relative order and a unary predicate that hashes the elements.|  
|[value_type](#hash_multiset__value_type)|A type that describes an object stored as an element of a <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> in its capacity as a value.|  
  
### Member Functions  
  
|||  
|-|-|  
|[begin](#hash_multiset__begin)|Returns an iterator that addresses the first element in the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.|  
|[cbegin](#hash_multiset__cbegin)|Returns a const iterator addressing the first element in the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.|  
|[cend](#hash_multiset__cend)|Returns a const iterator that addresses the location succeeding the last element in a <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.|  
|[clear](#hash_multiset__clear)|Erases all the elements of a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.|  
|[count](#hash_multiset__count)|Returns the number of elements in a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> whose key matches a parameter-specified key|  
|[crbegin](#hash_multiset__crbegin)|Returns a const iterator addressing the first element in a reversed <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.|  
|[crend](#hash_multiset__crend)|Returns a const iterator that addresses the location succeeding the last element in a reversed <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.|  
|[emplace](#hash_multiset__emplace)|Inserts an element constructed in place into a <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.|  
|[emplace_hint](#hash_multiset__emplace_hint)|Inserts an element constructed in place into a <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>, with a placement hint.|  
|[empty](#hash_multiset__empty)|Tests if a <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> is empty.|  
|[end](#hash_multiset__end)|Returns an iterator that addresses the location succeeding the last element in a <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.|  
|[equal_range](#hash_multiset__equal_range)|Returns a pair of iterators respectively to the first element in a <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> with a key that is greater than a specified key and to the first element in the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> with a key that is equal to or greater than the key.|  
|[erase](#hash_multiset__erase)|Removes an element or a range of elements in a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> from specified positions or removes elements that match a specified key.|  
|[find](#hash_multiset__find)|Returns an iterator addressing the location of an element in a <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> that has a key equivalent to a specified key.|  
|[get_allocator](#hash_multiset__get_allocator)|Returns a copy of the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object used to construct the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.|  
|[insert](#hash_multiset__insert)|Inserts an element or a range of elements into a <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.|  
|[key_comp](#hash_multiset__key_compare)|Retrieves a copy of the comparison object used to order keys in a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.|  
|[lower_bound](#hash_multiset__lower_bound)|Returns an iterator to the first element in a <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> with a key that is equal to or greater than a specified key.|  
|[max_size](#hash_multiset__max_size)|Returns the maximum length of the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.|  
|[rbegin](#hash_multiset__rbegin)|Returns an iterator addressing the first element in a reversed <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.|  
|[rend](#hash_multiset__rend)|Returns an iterator that addresses the location succeeding the last element in a reversed <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.|  
|[size](#hash_multiset__size)|Returns the number of elements in the <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.|  
|[swap](#hash_multiset__swap)|Exchanges the elements of two <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>s.|  
|[upper_bound](#hash_multiset__upper_bound)|Returns an iterator to the first element in a <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> that with a key that is equal to or greater than a specified key.|  
|[value_comp](#hash_multiset__value_comp)|Retrieves a copy of the hash traits object used to hash and order element key values in a <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#hash_multiset__operator_eq)|Replaces the elements of the hash_multiset with a copy of another hash_multiset.|  
  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
##  \<a name="hash_multiset__allocator_type">\</a>  hash_multiset::allocator_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that represents the allocator class for the hash_multiset object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Example  
  See example for [get_allocator](#hash_multiset__get_allocator) for an example using <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
  
##  \<a name="hash_multiset__begin">\</a>  hash_multiset::begin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator that addresses the first element in the hash_multiset.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator addressing the first element in the hash_multiset or the location succeeding an empty hash_multiset.  
  
### Remarks  
 If the return value of **begin** is assigned to a <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>, the elements in the hash_multiset object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the hash_multiset object can be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The first element of hms1 is 1**  
**The first element of hms1 is now 2**    
##  \<a name="hash_multiset__cbegin">\</a>  hash_multiset::cbegin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a const iterator that addresses the first element in the hash_multiset.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A const bidirectional iterator addressing the first element in the [hash_multiset](../vs140/hash_multiset-class.md) or the location succeeding an empty <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>, the elements in the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> object cannot be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The first element of hs1 is 1**    
##  \<a name="hash_multiset__cend">\</a>  hash_multiset::cend  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a hash_multiset.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A const bidirectional iterator that addresses the location succeeding the last element in a [hash_multiset](../vs140/hash_multiset-class.md). If the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> is empty, then <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> is used to test whether an iterator has reached the end of its <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>. The value returned by <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The last element of hs1 is 3**    
##  \<a name="hash_multiset__clear">\</a>  hash_multiset::clear  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Erases all the elements of a hash_multiset.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The size of the hash_multiset is initially 2.**  
**The size of the hash_multiset after clearing is 0.**    
##  \<a name="hash_multiset__const_iterator">\</a>  hash_multiset::const_iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a bidirectional iterator that can read a **const** element in the hash_multiset.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [begin](#hash_multiset__begin) for an example using <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multiset__const_pointer">\</a>  hash_multiset::const_pointer  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a pointer to a **const** element in a hash_multiset.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 In most cases, a [const_iterator](#hash_multiset__const_iterator) should be used to access the elements in a **const** hash_multiset object.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
##  \<a name="hash_multiset__const_reference">\</a>  hash_multiset::const_reference  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a reference to a **const** element stored in a hash_multiset for reading and performing **const** operations.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The first element in the hash_multiset is 10.**    
##  \<a name="hash_multiset__const_reverse_iterator">\</a>  hash_multiset::const_reverse_iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a bidirectional iterator that can read any **const** element in the hash_multiset.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> cannot modify the value of an element and is use to iterate through the hash_multiset in reverse.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the example for [rend](#hash_multiset__rend) for an example of how to declare and use the <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multiset__count">\</a>  hash_multiset::count  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns the number of elements in a hash_multiset whose key matches a parameter-specified key.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 The key of the elements to be matched from the hash_multiset.  
  
### Return Value  
 The number of elements in the hash_multiset with the parameter-specified key.  
  
### Remarks  
 The member function returns the number of elements in the following range:  
  
 [ <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> (_ <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> ), <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> (\_ <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> ) ).  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  The following example demonstrates the use of the hash_multiset::count member function.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **The number of elements in hms1 with a sort key of 1 is: 2.**  
**The number of elements in hms1 with a sort key of 2 is: 0.**    
##  \<a name="hash_multiset__crbegin">\</a>  hash_multiset::crbegin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a const iterator addressing the first element in a reversed hash_multiset.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [hash_multiset](../vs140/hash_multiset-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> just as [begin](#hash_multiset__begin) is used with a <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> can be used to iterate through a <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The first element in the reversed hash_multiset is 30.**    
##  \<a name="hash_multiset__crend">\</a>  hash_multiset::crend  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a reversed hash_multiset.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [hash_multiset](../vs140/hash_multiset-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>).  
  
### Remarks  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> just as [end](#hash_multiset__end) is used with a <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its hash_multiset.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **The last element in the reversed hash_multiset is 10.**    
##  \<a name="hash_multiset__difference_type">\</a>  hash_multiset::difference_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A signed integer type that provides the difference between two iterators that address elements within the same hash_multiset.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> is the type returned when subtracting or incrementing through iterators of the container. The <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> is typically used to represent the number of elements in the range [ <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>) between the iterators <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, includes the element pointed to by <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> and the range of elements up to, but not including, the element pointed to by <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>.  
  
 Note that although <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers such as set. Subtraction between iterators is only supported by random-access iterators provided by a random-access container such as vector or deque.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The number '5' occurs 0 times in hash_multiset hms1.**  
**The number '10' occurs 1 times in hash_multiset hms1.**  
**The number '20' occurs 2 times in hash_multiset hms1.**  
**The number of elements in the hash_multiset hms1 is 3.**    
##  \<a name="hash_multiset__emplace">\</a>  hash_multiset::emplace  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Inserts an element constructed in place into a hash_multiset.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>172\</CodeContentPlaceHolder>|The value of an element to be inserted into the [hash_multiset](../vs140/hash_multiset-class.md) unless the <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> already contains that element or, more generally, an element whose key is equivalently ordered.|  
  
### Return Value  
 The <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> member function returns an iterator that points to the position where the new element was inserted.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **After the emplace insertion, hms3 contains a.**    
##  \<a name="hash_multiset__emplace_hint">\</a>  hash_multiset::emplace_hint  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Inserts an element constructed in place into a hash_multiset, with a placement hint.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>175\</CodeContentPlaceHolder>|The value of an element to be inserted into the [hash_multiset](../vs140/hash_multiset-class.md) unless the <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> already contains that element or, more generally, an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>177\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.)|  
  
### Return Value  
 The [emplace](#hash_multiset__emplace) member function returns an iterator that points to the position where the new element was inserted into the <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>.  
  
### Remarks  
 Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **After the emplace insertion, hms1 contains a.**    
##  \<a name="hash_multiset__empty">\</a>  hash_multiset::empty  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Tests if a hash_multiset is empty.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the hash_multiset is empty; **false** if the hash_multiset is nonempty.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **The hash_multiset hms1 is not empty.**  
**The hash_multiset hms2 is empty.**    
##  \<a name="hash_multiset__end">\</a>  hash_multiset::end  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a hash_multiset.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator that addresses the location succeeding the last element in a hash_multiset. If the hash_multiset is empty, then hash_multiset::end == hash_multiset::begin.  
  
### Remarks  
 **end** is used to test whether an iterator has reached the end of its hash_multiset. The value returned by **end** should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **The last element of hms1 is 3**  
**The last element of hms1 is now 2**    
##  \<a name="hash_multiset__equal_range">\</a>  hash_multiset::equal_range  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a pair of iterators respectively to the first element in a hash_multiset with a key that is greater than a specified key and to the first element in the hash_multiset with a key that is equal to or greater than the key.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the hash_multiset being searched.  
  
### Return Value  
 A pair of iterators where the first is the [lower_bound](#hash_multiset__lower_bound) of the key and the second is the [upper_bound](#hash_multiset__upper_bound) of the key.  
  
 To access the first iterator of a pair <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>. **first** and to dereference the lower bound iterator, use \*( <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>. **first**). To access the second iterator of a pair <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>. **second** and to dereference the upper bound iterator, use \*( <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>. **second**).  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  **The upper bound of the element with a key of 20**  
**in the hash_multiset hms1 is: 30.**  
**The lower bound of the element with a key of 20**  
**in the hash_multiset hms1 is: 20.**  
**A direct call of upper_bound( 20 ) gives 30,**  
**matching the 2nd element of the pair returned by equal_range( 20 ).**  
**The hash_multiset hms1 doesn't have an element with a key less than 40.**    
##  \<a name="hash_multiset__erase">\</a>  hash_multiset::erase  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Removes an element or a range of elements in a hash_multiset from specified positions or removes elements that match a specified key.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 Position of the element to be removed from the hash_multiset.  
  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 Position of the first element removed from the hash_multiset.  
  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 Position just beyond the last element removed from the hash_multiset.  
  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 The key of the elements to be removed from the hash_multiset.  
  
### Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the hash_multiset if no such element exists. For the third member function, the number of elements that have been removed from the hash_multiset.  
  
### Remarks  
 The member functions never throw an exception.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  The following example demonstrates the use of the hash_multiset::erase member function.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  **After the 2nd element is deleted,**  
 **the hash_multiset hms1 is: 1 3 4.**  
**After the middle two elements are deleted,**  
 **the hash_multiset hms2 is: 16 4.**  
**After the element with a key of 2 is deleted,**  
 **the hash_multiset hms3 is: 0 1 3.**  
**The number of elements removed from hms3 is: 1.**  
**After another element with a key equal to that of the 2nd element**  
 **is deleted, the hash_multiset hms3 is: 0 3.**    
##  \<a name="hash_multiset__find">\</a>  hash_multiset::find  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator addressing the location of an element in a hash_multiset that has a key equivalent to a specified key.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 The argument key to be matched by the sort key of an element from the hash_multiset being searched.  
  
### Return Value  
 An [iterator](#hash_multiset__iterator) or [const_iterator](#hash_multiset__const_iterator) that addresses the location of an element equivalent to a specified key or that addresses the location succeeding the last element in the hash_multiset if no match is found for the key.  
  
### Remarks  
 The member function returns an iterator that addresses an element in the hash_multiset whose sort key is **equivalent** to the argument key under a binary predicate that induces an ordering based on a less-than comparability relation.  
  
 If the return value of **find** is assigned to a <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>, the hash_multiset object cannot be modified. If the return value of **find** is assigned to an **iterator**, the hash_multiset object can be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  **The element of hash_multiset hms1 with a key of 20 is: 20.**  
**The hash_multiset hms1 doesn't have an element with a key of 40.**  
**The element of hms1 with a key matching that of the last element is: 30.**    
##  \<a name="hash_multiset__get_allocator">\</a>  hash_multiset::get_allocator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a copy of the allocator object used to construct the hash_multiset.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 The allocator used by the hash_multiset to manage memory, which is the class's template parameter <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>, see the Remarks section of the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
### Remarks  
 Allocators for the hash_multiset class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
##  \<a name="hash_multiset__hash_multiset">\</a>  hash_multiset::hash_multiset  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Constructs a <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> that is empty or that is a copy of all or part of some other <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>198\</CodeContentPlaceHolder>|The storage allocator class to be used for this <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> object, which defaults to <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>201\</CodeContentPlaceHolder>|The comparison function of type <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> used to order the elements in the <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>, which defaults to <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>205\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> of which the constructed <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> is to be a copy.|  
|<CodeContentPlaceHolder>208\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>209\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>210\</CodeContentPlaceHolder>|The initializer_list that contains the elements to be copied.|  
  
### Remarks  
 All constructors store a type of allocator object that manages memory storage for the <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> and that can later be returned by calling [hash_multiset::get_allocator](#hash_multiset__get_allocator). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their hash_multisets.  
  
 All constructors store a function object of type <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> that is used to establish an order among the keys of the <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> and that can later be returned by calling [hash_multiset::key_comp](#hash_multiset__key_comp). For more information on <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> see the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
 The first three constructors specify an empty initial <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>, the second specifying the type of comparison function ( <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifying the allocator type ( <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>) to be used. The keyword <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor moves the <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>.  
  
 The fifth, sixth, and seventh constructors use an initializer_list.  
  
 The last three constructors copy the range [ <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>,                        <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>) of a <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> with increasing explicitness in specifying the type of comparison function of class Compare and allocator.  
  
 The actual order of elements in a hashed set container depends on the hash function, the ordering function and the current size of the hash table and cannot, in general, be predicted as it could with the set container, where it was determined by the ordering function alone.  
  
##  \<a name="hash_multiset__insert">\</a>  hash_multiset::insert  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Inserts an element or a range of elements into a hash_multiset.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>223\</CodeContentPlaceHolder>|The value of an element to be inserted into the hash_multiset unless the hash_multiset already contains that element or, more generally, an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>224\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>.)|  
|<CodeContentPlaceHolder>226\</CodeContentPlaceHolder>|The position of the first element to be copied from a hash_multiset.|  
|<CodeContentPlaceHolder>227\</CodeContentPlaceHolder>|The position just beyond the last element to be copied from a hash_multiset.|  
|<CodeContentPlaceHolder>228\</CodeContentPlaceHolder>|The initializer_list that contains the elements to copy.|  
  
### Return Value  
 The first two insert member functions return an iterator that points to the position where the new element was inserted.  
  
 The next three member functions use an initializer_list.  
  
 The third member function inserts the sequence of element values into a hash_multiset corresponding to each element addressed by an iterator of in the range [ <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>) of a specified hash_multiset.  
  
### Remarks  
 Insertion can occur in amortized constant time for the hint version of insert, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multiset__iterator">\</a>  hash_multiset::iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify any element in a hash_multiset.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Remarks  
 A type **iterator** can be used to modify the value of an element.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [begin](#hash_multiset__begin) for an example of how to declare and use **iterator**.  
  
##  \<a name="hash_multiset__key_comp">\</a>  hash_multiset::key_comp  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Retrieves a copy of the comparison object used to order keys in a hash_multiset.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 Returns the hash_multiset template parameter <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>, which contains function objects that are used to hash and to order the elements of the container.  
  
 For more information on <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> see the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
### Remarks  
 The stored object defines a member function:  
  
 **bool operator**( **const Key&** *_xVal,* **const Key&** _ <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>);  
  
 which returns **true** if <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> in the sort order.  
  
 Note that both [key_compare](#hash_multiset__key_compare) and [value_compare](#hash_multiset__value_compare) are synonyms for the template parameter **Traits**. Both types are provided for the hash_multiset and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
##  \<a name="hash_multiset__key_compare">\</a>  hash_multiset::key_compare  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides two function objects, a binary predicate of class compare that can compare two element values of a hash_multiset to determine their relative order and a unary predicate that hashes the elements.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 **key_compare** is a synonym for the template parameter <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> see the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
 Note that both <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> and value_compare are synonyms for the template parameter **Traits**. Both types are provided for the hash_set and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [key_comp](#hash_multiset__key_comp) for an example of how to declare and use <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multiset__key_type">\</a>  hash_multiset::key_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a function object that can compare sort keys to determine the relative order of two elements in the hash_multiset.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Remarks  
 **key_type** is a synonym for the template parameter <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>.  
  
 Note that both <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> and [value_type](../vs140/hash_set-class.md#hash_set__value_type) are synonyms for the template parameter **Key**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
 For more information on <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>, see the Remarks section of the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [value_type](#hash_multiset__value_type) for an example of how to declare and use <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multiset__lower_bound">\</a>  hash_multiset::lower_bound  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator to the first element in a hash_multiset with a key that is equal to or greater than a specified key.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the hash_multiset being searched.  
  
### Return Value  
 An [iterator](#hash_multiset__iterator) or [const_iterator](#hash_multiset__const_iterator) that addresses the location of the first element in a hash_multiset with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the hash_multiset if no match is found for the key.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
##  \<a name="hash_multiset__max_size">\</a>  hash_multiset::max_size  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns the maximum length of the hash_multiset.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Return Value  
 The maximum possible length of the hash_multiset.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
##  \<a name="hash_multiset__operator_eq">\</a>  hash_multiset::operator=  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Replaces the elements of the hash_multiset with a copy of another hash_multiset.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>246\</CodeContentPlaceHolder>|The [hash_multiset](../vs140/hash_multiset-class.md) being copied into the <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>.|  
  
### Remarks  
 After erasing any existing elements in a <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> either copies or moves the contents of <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
##  \<a name="hash_multiset__pointer">\</a>  hash_multiset::pointer  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a pointer to an element in a hash_multiset.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Remarks  
 A type **pointer** can be used to modify the value of an element.  
  
 In most cases, an [iterator](#hash_multiset__iterator) should be used to access the elements in a multiset object.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
##  \<a name="hash_multiset__rbegin">\</a>  hash_multiset::rbegin  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator addressing the first element in a reversed hash_multiset.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed hash_multiset or addressing what had been the last element in the unreversed hash_multiset.  
  
### Remarks  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> is used with a reversed hash_multiset just as [begin](#hash_multiset__begin) is used with a hash_multiset.  
  
 If the return value of <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>, then the hash_multiset object cannot be modified. If the return value of <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>, then the hash_multiset object can be modified.  
  
 <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> can be used to iterate through a hash_multiset backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  **The first element in the reversed hash_multiset is 30.**  
**The hash_multiset is: 10 20 30**   
**The reversed hash_multiset is: 30 20 10**   
**After the erasure, the first element in the reversed hash_multiset is 20.**    
##  \<a name="hash_multiset__reference">\</a>  hash_multiset::reference  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a reference to an element stored in a hash_multiset.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  **The first element in the hash_multiset is 10.**  
**The first element in the hash_multiset is now 15.**    
##  \<a name="hash_multiset__rend">\</a>  hash_multiset::rend  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a reversed hash_multiset.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed hash_multiset (the location that had preceded the first element in the unreversed hash_multiset).  
  
### Remarks  
 <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> is used with a reversed hash_multiset just as [end](#hash_multiset__end) is used with a hash_multiset.  
  
 If the return value of <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>, then the hash_multiset object cannot be modified. If the return value of <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>, then the hash_multiset object can be modified. The value returned by <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> should not be dereferenced.  
  
 <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its hash_multiset.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  **The last element in the reversed hash_multiset is 10.**  
**The hash_multiset is: 10 20 30 .**  
**The reversed hash_multiset is: 30 20 10 .**  
**After the erasure, the last element in the reversed hash_multiset is 20.**    
##  \<a name="hash_multiset__reverse_iterator">\</a>  hash_multiset::reverse_iterator  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify an element in a reversed hash_multiset.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> is use to iterate through the hash_multiset in reverse.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [rbegin](#hash_multiset__rbegin) for an example of how to declare and use <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multiset__size">\</a>  hash_multiset::size  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns the number of elements in the hash_multiset.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the hash_multiset.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  **The hash_multiset length is 1.**  
**The hash_multiset length is now 2.**    
##  \<a name="hash_multiset__size_type">\</a>  hash_multiset::size_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 An unsigned integer type that can represent the number of elements in a hash_multiset.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [size](#hash_multiset__size) for an example of how to declare and use <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>  
  
##  \<a name="hash_multiset__swap">\</a>  hash_multiset::swap  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Exchanges the elements of two hash_multisets.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
 The argument hash_multiset providing the elements to be swapped with the target hash_multiset.  
  
### Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two hash_multisets whose elements are being exchanged.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  **The original hash_multiset hms1 is: 10 20 30.**  
**After swapping with hms2, list hms1 is: 200 100.**  
**After swapping with hms3, list hms1 is: 300.**    
##  \<a name="hash_multiset__upper_bound">\</a>  hash_multiset::upper_bound  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator to the first element in a hash_multiset with a key that is greater than a specified key.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the hash_multiset being searched.  
  
### Return Value  
 An [iterator](#hash_multiset__iterator) or [const_iterator](#hash_multiset__const_iterator) that addresses the location of the first element in a hash_multiset with a key greater than the argument key, or that addresses the location succeeding the last element in the hash_multiset if no match is found for the key.  
  
### Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  **The first element of hash_multiset hms1**  
 **with a key greater than 20 is: 30.**  
**The hash_multiset hms1 doesn't have an element**   
 **with a key greater than 30.**  
**The first element of hms1**  
 **with a key greater than**   
**that of the initial element of hms1 is: 20.**    
##  \<a name="hash_multiset__value_comp">\</a>  hash_multiset::value_comp  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Retrieves a copy of the comparison object used to order element values in a hash_multiset.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Return Value  
 Returns the hash_multiset template parameter <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>, which contains function objects that are used to hash and to order elements of the container.  
  
 For more information on <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> see the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
### Remarks  
 The stored object defines a member function:  
  
 **bool operator**( **constKey&**<CodeContentPlaceHolder>272\</CodeContentPlaceHolder>, **const Key&** *_yVal*);  
  
 which returns **true** if <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> in the sort order.  
  
 Note that both [key_compare](#hash_multiset__key_compare) and [value_compare](#hash_multiset__value_compare) are synonyms for the template parameter **Traits**. Both types are provided for the hash_multiset and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  **vc1( 2,3 ) returns value of true, where vc1 is the function object of hms1.**  
**vc2( 2,3 ) returns value of false, where vc2 is the function object of hms2.**    
##  \<a name="hash_multiset__value_compare">\</a>  hash_multiset::value_compare  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides two function objects, a binary predicate of class compare that can compare two element values of a hash_multiset to determine their relative order and a unary predicate that hashes the elements.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Remarks  
 **value_compare** is a synonym for the template parameter <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> see the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
 Note that both [key_compare](#hash_multiset__key_compare) and **value_compare** are synonyms for the template parameter **Traits**. Both types are provided for the classes set and multiset, where they are identical, for compatibility with the classes map and multimap, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See example for [value_comp](#hash_multiset__value_comp) for an example of how to declare and use <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>.  
  
##  \<a name="hash_multiset__value_type">\</a>  hash_multiset::value_type  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that describes an object stored as an element as a hash_multiset in its capacity as a value.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  **The hash_multiset has elements: 10 20.**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)