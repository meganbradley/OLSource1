---
title: "vector Class"
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
  - "std::vector"
  - "vector"
  - "std.vector"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "vector class"
ms.assetid: a3e0a8f8-7565-4fe0-93e4-e4d74ae1b70d
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# vector Class
The STL vector class is a template class of sequence containers that arrange elements of a given type in a linear arrangement and allow fast random access to any element. They should be the preferred container for a sequence when random-access performance is at a premium.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Type*  
 The element data type to be stored in the vector  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the vector's allocation and deallocation of memory. This argument is optional and the default value is **allocator***\<Type>.*  
  
## Remarks  
 Vectors allow constant time insertions and deletions at the end of the sequence. Inserting or deleting elements in the middle of a vector requires linear time. The performance of the [deque Class](../vs140/deque-class.md) container is superior with respect to insertions and deletions at the beginning and end of a sequence. The [list Class](../vs140/list-class.md) container is superior with respect to insertions and deletions at any location within a sequence.  
  
 Vector reallocation occurs when a member function must increase the sequence contained in the vector object beyond its current storage capacity. Other insertions and erasures may alter various storage addresses within the sequence. In all such cases, iterators or references that point at altered portions of the sequence become invalid. If no reallocation happens, only iterators and references before the insertion/deletion point remain valid.  
  
 The [vector\<bool> Class](../vs140/vector-bool--class.md) is a full specialization of the template class vector for elements of type bool with an allocator for the underlying type used by the specialization.  
  
 The [vector\<bool> reference Class](../vs140/vector-bool--class.md#vector_lt_bool_gt___reference_class) is a nested class whose objects are able to provide references to elements (single bits) within a vector\<bool> object.  
  
## Members  
  
### Constructors  
  
|||  
|-|-|  
|[vector](#vector__vector)|Constructs a vector of a specific size or with elements of a specific value or with a specific <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> or as a copy of some other vector.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#vector__allocator_type)|A type that represents the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> class for the vector object.|  
|[const_iterator](#vector__const_iterator)|A type that provides a random-access iterator that can read a <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> element in a vector.|  
|[const_pointer](#vector__const_pointer)|A type that provides a pointer to a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> element in a vector.|  
|[const_reference](#vector__const_reference)|A type that provides a reference to a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> element stored in a vector for reading and performing <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> operations.|  
|[const_reverse_iterator](#vector__const_reverse_iterator)|A type that provides a random-access iterator that can read any <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> element in the vector.|  
|[difference_type](#vector__difference_type)|A type that provides the difference between the addresses of two elements in a vector.|  
|[iterator](#vector__iterator)|A type that provides a random-access iterator that can read or modify any element in a vector.|  
|[pointer](#vector__pointer)|A type that provides a pointer to an element in a vector.|  
|[reference](#vector__reference)|A type that provides a reference to an element stored in a vector.|  
|[reverse_iterator](#vector__reverse_iterator)|A type that provides a random-access iterator that can read or modify any element in a reversed vector.|  
|[size_type](#vector__size_type)|A type that counts the number of elements in a vector.|  
|[value_type](#vector__value_type)|A type that represents the data type stored in a vector.|  
  
### Member Functions  
  
|||  
|-|-|  
|[assign](#vector__assign)|Erases a vector and copies the specified elements to the empty vector.|  
|[at](#vector__at)|Returns a reference to the element at a specified location in the vector.|  
|[back](#vector__back)|Returns a reference to the last element of the vector.|  
|[begin](#vector__begin)|Returns a random-access iterator to the first element in the vector.|  
|[capacity](#vector__capacity)|Returns the number of elements that the vector could contain without allocating more storage.|  
|[cbegin](#vector__cbegin)|Returns a random-access const iterator to the first element in the vector.|  
|[cend](#vector__cend)|Returns a random-access const iterator that points just beyond the end of the vector.|  
|[crbegin](#vector__crbegin)|Returns a const iterator to the first element in a reversed vector.|  
|[crend](#vector__crend)|Returns a const iterator to the end of a reversed vector.|  
|[clear](#vector__clear)|Erases the elements of the vector.|  
|[data](#vector__data)|Returns a pointer to the first element in the vector.|  
|[emplace](#vector__emplace)|Inserts an element constructed in place into the vector at a specified position.|  
|[emplace_back](#vector__emplace_back)|Adds an element constructed in place to the end of the vector.|  
|[empty](#vector__empty)|Tests if the vector container is empty.|  
|[end](#vector__end)|Returns a random-access iterator that points to the end of the vector.|  
|[erase](#vector__erase)|Removes an element or a range of elements in a vector from specified positions.|  
|[front](#vector__front)|Returns a reference to the first element in a vector.|  
|[get_allocator](#vector__get_allocator)|Returns an object to the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> class used by a vector.|  
|[insert](#vector__insert)|Inserts an element or a number of elements into the vector at a specified position.|  
|[max_size](#vector__max_size)|Returns the maximum length of the vector.|  
|[pop_back](#vector__pop_back)|Deletes the element at the end of the vector.|  
|[push_back](#vector__push_back)|Add an element to the end of the vector.|  
|[rbegin](#vector__rbegin)|Returns an iterator to the first element in a reversed vector.|  
|[rend](#vector__rend)|Returns an iterator to the end of a reversed vector.|  
|[reserve](#vector__reserve)|Reserves a minimum length of storage for a vector object.|  
|[resize](#vector__resize)|Specifies a new size for a vector.|  
|[shrink_to_fit](#vector__shrink_to_fit)|Discards excess capacity.|  
|[size](#vector__size)|Returns the number of elements in the vector.|  
|[swap](#vector__swap)|Exchanges the elements of two vectors.|  
  
### Operators  
  
|||  
|-|-|  
|[operator&#91;&#93;](#vector__operator_at)|Returns a reference to the vector element at a specified position.|  
|[operator=](#vector__operator_eq)|Replaces the elements of the vector with a copy of another vector.|  
  
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
##  \<a name="vector__allocator_type">\</a>  vector::allocator_type  
 A type that represents the allocator class for the vector object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> is a synonym for the template parameter **Allocator.**  
  
### Example  
  See the example for [get_allocator](#vector__get_allocator) for an example that uses <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
##  \<a name="vector__assign">\</a>  vector::assign  
 Erases a vector and copies the specified elements to the empty vector.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Position of the first element beyond the range of elements to be copied.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The number of copies of an element being inserted into the vector.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 The value of the element being inserted into the vector.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The initializer_list containing the elements to insert.  
  
### Remarks  
 After erasing any existing elements in a vector, assign either inserts a specified range of elements from the original vector into a vector or inserts copies of a new element of a specified value into a vector.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="vector__at">\</a>  vector::at  
 Returns a reference to the element at a specified location in the vector.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The subscript or position number of the element to reference in the vector.  
  
### Return Value  
 A reference to the element subscripted in the argument. If <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is greater than the size of the vector, **at** throws an exception.  
  
### Remarks  
 If the return value of **at** is assigned to a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, the vector object cannot be modified. If the return value of **at** is assigned to a **reference**, the vector object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The first element is 10**  
**The second element is 20**    
##  \<a name="vector__back">\</a>  vector::back  
 Returns a reference to the last element of the vector.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The last element of the vector. If the vector is empty, the return value is undefined.  
  
### Remarks  
 If the return value of **back** is assigned to a <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>, the vector object cannot be modified. If the return value of **back** is assigned to a **reference**, the vector object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty vector.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="vector__begin">\</a>  vector::begin  
 Returns a random-access iterator to the first element in the vector.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A random-access iterator addressing the first element in the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> or to the location succeeding an empty <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. You should always compare the value returned with [vector::end](#vector__end) to ensure it is valid.  
  
### Remarks  
 If the return value of <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> is assigned to a [vector::const_iterator](#vector__const_iterator), the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object cannot be modified. If the return value of <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> is assigned to an [vector::iterator](#vector__iterator), the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The vector c1 contains elements: 1 2**  
**The vector c1 now contains elements: 20 2**    
##  \<a name="vector__capacity">\</a>  vector::capacity  
 Returns the number of elements that the vector could contain without allocating more storage.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The current length of storage allocated for the vector.  
  
### Remarks  
 The member function [resize](#vector__resize) will be more efficient if sufficient memory is allocated to accommodate it. Use the member function [reserve](#vector__reserve) to specify the amount of memory allocated.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **The length of storage allocated is 1.**  
**The length of storage allocated is now 2.**    
##  \<a name="vector__cbegin">\</a>  vector::cbegin  
 Returns a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> random-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="vector__cend">\</a>  vector::cend  
 Returns a <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> random-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="vector__clear">\</a>  vector::clear  
 Erases the elements of the vector.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  **The size of v1 is 3**  
**The size of v1 after clearing is 0**    
##  \<a name="vector__const_iterator">\</a>  vector::const_iterator  
 A type that provides a random-access iterator that can read a **const** element in a vector.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
### Example  
  See the example for [back](#vector__back) for an example that uses <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
##  \<a name="vector__const_pointer">\</a>  vector::const_pointer  
 A type that provides a pointer to a **const** element in a vector.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 An [iterator](#vector__iterator) is more commonly used to access a vector element.  
  
##  \<a name="vector__const_reference">\</a>  vector::const_reference  
 A type that provides a reference to a **const** element stored in a vector for reading and performing **const** operations.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  **The first element is 10**  
**The second element is 20**    
##  \<a name="vector__const_reverse_iterator">\</a>  vector::const_reverse_iterator  
 A type that provides a random-access iterator that can read any **const** element in the vector.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> cannot modify the value of an element and is used to iterate through the vector in reverse.  
  
### Example  
  See [rbegin](#vector__rbegin) for an example of how to declare and use an iterator.  
  
##  \<a name="vector__crbegin">\</a>  vector::crbegin  
 Returns a const iterator to the first element in a reversed vector.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse random-access iterator addressing the first element in a reversed [vector](../vs140/vector-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> object cannot be modified.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **The first element of vector is 1.**  
**The first element of the reversed vector is 2.**    
##  \<a name="vector__crend">\</a>  vector::crend  
 Returns a const iterator that addresses the location succeeding the last element in a reversed vector.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse random-access iterator that addresses the location succeeding the last element in a reversed [vector](../vs140/vector-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>).  
  
### Remarks  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> just as [cend](#vector__cend) is used with a <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> (suitably decremented), the <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
 The value returned by <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **2**  
**1**    
##  \<a name="vector__data">\</a>  vector::data  
 Returns a pointer to the first element in the vector.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the first element in the [vector](../vs140/vector-class.md) or to the location succeeding an empty <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **The vector c1 contains elements: 1 2**  
**The vector c1 now contains elements: 20 2**    
##  \<a name="vector__difference_type">\</a>  vector::difference_type  
 A type that provides the difference between two iterators that refer to elements within the same vector.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 A <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> can also be described as the number of elements between two pointers, because a pointer to an element contains its address.  
  
 An [iterator](#vector__iterator) is more commonly used to access a vector element.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **The number '10' is in c1 collection 1 times.**  
**The number '20' is in c1 collection 2 times.**  
**The number '30' is in c1 collection 3 times.**    
##  \<a name="vector__emplace">\</a>  vector::emplace  
 Inserts an element constructed in place into the vector at a specified position.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>|The position in the [vector](../vs140/vector-class.md) where the first element is inserted.|  
|<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>|The value of the element being inserted into the <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.|  
  
### Return Value  
 The function returns an iterator that points to the position where the new element was inserted into the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>.  
  
### Remarks  
 Any insertion operation can be expensive, see [vector Class](../vs140/vector-class.md) for a discussion of <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> performance.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  **v1 = 10 20 30**  
**vv1[0] = 10 20 30**    
##  \<a name="vector__emplace_back">\</a>  vector::emplace_back  
 Adds an element constructed in place to the end of the vector.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>|Constructor arguments. The function infers which constructor overload to invoke based on the arguments provided.|  
  
### Example  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
##  \<a name="vector__empty">\</a>  vector::empty  
 Tests if the vector is empty.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the vector is empty; **false** if the vector is not empty.  
  
### Example  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  **The vector is not empty.**    
##  \<a name="vector__end">\</a>  vector::end  
 Returns the past-the-end iterator.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 The past-the-end iterator for the vector. If the vector is empty, <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the return value of **end** is assigned to a variable of type <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>, the vector object cannot be modified. If the return value of **end** is assigned to a variable of type **iterator**, the vector object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  **1**  
**2**    
##  \<a name="vector__erase">\</a>  vector::erase  
 Removes an element or a range of elements in a vector from specified positions.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>|Position of the element to be removed from the vector.|  
|<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>|Position of the first element removed from the vector.|  
|<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>|Position just beyond the last element removed from the vector.|  
  
### Return Value  
 An iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the vector if no such element exists.  
  
### Example  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  **v1 = 10 20 30 40 50**  
**v1 = 20 30 40 50**  
**v1 = 20 50**    
##  \<a name="vector__front">\</a>  vector::front  
 Returns a reference to the first element in a vector.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the first element in the vector object. If the vector is empty, the return is undefined.  
  
### Remarks  
 If the return value of <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>, the vector object cannot be modified. If the return value of <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> is assigned to a **reference**, the vector object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty vector.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
##  \<a name="vector__get_allocator">\</a>  vector::get_allocator  
 Returns a copy of the allocator object used to construct the vector.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 The allocator used by the vector.  
  
### Remarks  
 Allocators for the vector class specify how the class manages storage. The default allocators supplied with STL container classes are sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
### Example  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
##  \<a name="vector__insert">\</a>  vector::insert  
 Inserts an element or a number of elements or a range of elements into the vector at a specified position.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>159\</CodeContentPlaceHolder>|The position in the vector where the first element is inserted.|  
|<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>|The value of the element being inserted into the vector.|  
|<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>|The number of elements being inserted into the vector.|  
|<CodeContentPlaceHolder>162\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>163\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
  
### Return Value  
 The first two <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> functions return an iterator that points to the position where the new element was inserted into the vector.  
  
### Remarks  
 Any insertion operation can be expensive, see [vector Class](../vs140/vector-class.md) for a discussion of <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> performance.  
  
### Example  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  **v1 = 10 20 30**  
**v1 = 10 40 20 30**  
**v1 = 10 40 50 50 50 50 20 30**  
**v1 = 10 50 50 40 50 50 50 50 20 30**  
**vv1[0] = 10 50 50 40 50 50 50 50 20 30**    
##  \<a name="vector__iterator">\</a>  vector::iterator  
 A type that provides a random-access iterator that can read or modify any element in a vector.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Remarks  
 A type **iterator** can be used to modify the value of an element.  
  
### Example  
  See the example for [begin](#vector__begin).  
  
##  \<a name="vector__max_size">\</a>  vector::max_size  
 Returns the maximum length of the vector.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Return Value  
 The maximum possible length of the vector.  
  
### Example  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
##  \<a name="vector__operator_at">\</a>  vector::operator[]  
 Returns a reference to the vector element at a specified position.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>166\</CodeContentPlaceHolder>|The position of the vector element.|  
  
### Return Value  
 If the position specified is greater than or equal to the size of the container, the result is undefined.  
  
### Remarks  
 If the return value of <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, the vector object cannot be modified. If the return value of <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> is assigned to a reference, the vector object can be modified.  
  
 When compiling with _SECURE_SCL 1 (controlled with [_ITERATOR_DEBUG_LEVEL](../vs140/_iterator_debug_level.md)), a runtime error will occur if you attempt to access an element outside the bounds of the vector.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
##  \<a name="vector__operator_eq">\</a>  vector::operator=  
 Replaces the elements of the vector with a copy of another vector.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>170\</CodeContentPlaceHolder>|The [vector](../vs140/vector-class.md) being copied into the <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.|  
  
### Remarks  
 After erasing any existing elements in a <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> either copies or moves the contents of <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
##  \<a name="vector__pointer">\</a>  vector::pointer  
 A type that provides a pointer to an element in a vector.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Remarks  
 A type **pointer** can be used to modify the value of an element.  
  
### Example  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  **11**  
**22**  
**44**    
##  \<a name="vector__pop_back">\</a>  vector::pop_back  
 Deletes the element at the end of the vector.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Remarks  
 For a code example, see [vector::push_back()](#vector__push_back).  
  
##  \<a name="vector__push_back">\</a>  vector::push_back  
 Adds an element to the end of the vector.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 The value to assign to the element added to the end of the vector.  
  
### Example  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
##  \<a name="vector__rbegin">\</a>  vector::rbegin  
 Returns an iterator to the first element in a reversed vector.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Return Value  
 A reverse random-access iterator addressing the first element in a reversed vector or addressing what had been the last element in the unreversed vector.  
  
### Remarks  
 If the return value of <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>, the vector object cannot be modified. If the return value of <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>, the vector object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  **The first element of vector is 1.**  
**The first element of the reversed vector is 2.**    
##  \<a name="vector__reference">\</a>  vector::reference  
 A type that provides a reference to an element stored in a vector.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Example  
  See [at](#vector__at) for an example of how to use **reference** in the vector class.  
  
##  \<a name="vector__rend">\</a>  vector::rend  
 Returns an iterator that addresses the location succeeding the last element in a reversed vector.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Return Value  
 A reverse random-access iterator that addresses the location succeeding the last element in a reversed vector (the location that had preceded the first element in the unreversed vector).  
  
### Remarks  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> is used with a reversed vector just as [end](#vector__end) is used with a vector.  
  
 If the return value of <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>, then the vector object cannot be modified. If the return value of <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>, then the vector object can be modified.  
  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its vector.  
  
 The value returned by <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  **2**  
**1**    
##  \<a name="vector__reserve">\</a>  vector::reserve  
 Reserves a minimum length of storage for a vector object, allocating space if necessary.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 The minimum length of storage to be allocated for the vector.  
  
### Example  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  **Current capacity of v1 = 1**  
**Current capacity of v1 = 20**    
##  \<a name="vector__resize">\</a>  vector::resize  
 Specifies a new size for a vector.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 The new size of the vector.  
  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 The initialization value of new elements added to the vector if the new size is larger that the original size. If the value is omitted, the new objects use their default constructor.  
  
### Remarks  
 If the container's size is less than the requested size, <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>, elements are added to the vector until it reaches the requested size. If the container's size is larger than the requested size, the elements closest to the end of the container are deleted until the container reaches the size <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>. If the present size of the container is the same as the requested size, no action is taken.  
  
 [size](#vector__size) reflects the current size of the vector.  
  
### Example  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
##  \<a name="vector__reverse_iterator">\</a>  vector::reverse_iterator  
 A type that provides a random-access iterator that can read or modify any element in a reversed vector.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> is used to iterate through the vector in reverse.  
  
### Example  
  See the example for [rbegin](#vector__rbegin).  
  
##  \<a name="vector__shrink_to_fit">\</a>  vector::shrink_to_fit  
 Discards excess capacity.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  **Current capacity of v1 = 1**  
**Current capacity of v1 = 20**  
**Current capacity of v1 = 1**    
##  \<a name="vector__size">\</a>  vector::size  
 Returns the number of elements in the vector.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the vector.  
  
### Example  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  **Vector length is 1.**  
**Vector length is now 2.**    
##  \<a name="vector__size_type">\</a>  vector::size_type  
 A type that counts the number of elements in a vector.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Example  
  See the example for [capacity](#vector__capacity).  
  
##  \<a name="vector__swap">\</a>  vector::swap  
 Exchanges the elements of two vectors.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 A vector providing the elements to be swapped, or a vector whose elements are to be exchanged with those of the vector <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 A vector whose elements are to be exchanged with those of the vector <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  **The number of elements in v1 = 3**  
**The number of elements in v2 = 2**  
**The number of elements in v1 = 2**  
**The number of elements in v2 = 3**    
##  \<a name="vector__value_type">\</a>  vector::value_type  
 A type that represents the data type stored in a vector.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> is a synonym for the template parameter **Type**.  
  
### Example  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  **44**    
##  \<a name="vector__vector">\</a>  vector::vector  
 Constructs a vector of a specific size or with elements of a specific value or with a specific allocator or as a copy of all or part of some other vector.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>199\</CodeContentPlaceHolder>|The allocator class to use with this object. [get_allocator](#vector__get_allocator) returns the allocator class for the object.|  
|<CodeContentPlaceHolder>200\</CodeContentPlaceHolder>|The number of elements in the constructed vector.|  
|<CodeContentPlaceHolder>201\</CodeContentPlaceHolder>|The value of the elements in the constructed vector.|  
|<CodeContentPlaceHolder>202\</CodeContentPlaceHolder>|The vector of which the constructed vector is to be a copy.|  
|<CodeContentPlaceHolder>203\</CodeContentPlaceHolder>|Position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>204\</CodeContentPlaceHolder>|Position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>205\</CodeContentPlaceHolder>|The initializer_list containing the elmeents to copy.|  
  
### Remarks  
 All constructors store an allocator object ( <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>) and initialize the vector.  
  
 The first two constructors specify an empty initial vector. The second explicitly specifies the allocator type ( <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>) to be used.  
  
 The third constructor specifies a repetition of a specified number ( <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>) of elements of the default value for class <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>.  
  
 The fourth and fifth constructors specify a repetition of ( <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>) elements of value <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>.  
  
 The sixth constructor specifies a copy of the vector <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>.  
  
 The seventh constructor moves the vector <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>.  
  
 The eighth constructor uses an initializer_list to specify the elements.  
  
 The ninth and tenth constructors copy the range [ <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>) of a vector.  
  
### Example  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  **v1 = 0 0 0v2 = 2 2 2 2 2v3 = 1 1 1v4 = 2 2 2 2 2v5 = 0 1 2 3 4v6 = 1 2v7 = 2 2 2 2 21 2 3 4**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)