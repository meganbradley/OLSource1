---
title: "concurrent_vector Class"
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
  - "concurrent_vector/Concurrency::concurrent_vector"
  - "concurrent_vector/concurrency::concurrent_vector"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "concurrent_vector class"
ms.assetid: a217b4ac-af2b-4d41-94eb-09a75ee28622
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector Class
The             <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> class is a sequence container class that allows random access to any element. It enables concurrency-safe append, element access, iterator access, and iterator traversal operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The data type of the elements to be stored in the vector.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the allocation and deallocation of memory for the concurrent vector. This argument is optional and the default value is                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|A type that represents the allocator class for the concurrent vector.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|A type that provides a random-access iterator that can read a                                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> element in a concurrent vector.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|A type that provides a pointer to a                                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> element in a concurrent vector.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|A type that provides a reference to a                                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> element stored in a concurrent vector for reading and performing                                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> operations.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|A type that provides a random-access iterator that can read any                                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> element in the concurrent vector.|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|A type that provides the signed distance between two elements in a concurrent vector.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|A type that provides a random-access iterator that can read any element in a concurrent vector. Modification of an element using the iterator is not concurrency-safe.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|A type that provides a pointer to an element in a concurrent vector.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|A type that provides a reference to an element stored in a concurrent vector.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|A type that provides a random-access iterator that can read any element in a reversed concurrent vector. Modification of an element using the iterator is not concurrency-safe.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|A type that counts the number of elements in a concurrent vector.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|A type that represents the data type stored in a concurrent vector.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_vector::concurrent_vector Constructor](#concurrent_vector__concurrent_vector_constructor)|Overloaded. Constructs a concurrent vector.|  
|[concurrent_vector::~concurrent_vector Destructor](#concurrent_vector___dtorconcurrent_vector_destructor)|Erases all elements and destroys this concurrent vector.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_vector::assign Method](#concurrent_vector__assign_method)|Overloaded. Erases the elements of the concurrent vector and assigns to it either                                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> copies of                                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, or values specified by the iterator range [                                        <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>,                                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>). This method is not concurrency-safe.|  
|[concurrent_vector::at Method](#concurrent_vector__at_method)|Overloaded. Provides access to the element at the given index in the concurrent vector. This method is concurrency-safe for read operations, and also while growing the vector, as long as you have ensured that the value                                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is less than the size of the concurrent vector.|  
|[concurrent_vector::back Method](#concurrent_vector__back_method)|Overloaded. Returns a reference or a                                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> reference to the last element in the concurrent vector. If the concurrent vector is empty, the return value is undefined. This method is concurrency-safe.|  
|[concurrent_vector::begin Method](#concurrent_vector__begin_method)|Overloaded. Returns an iterator of type                                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> or                                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to the beginning of the concurrent vector. This method is concurrency-safe.|  
|[concurrent_vector::capacity Method](#concurrent_vector__capacity_method)|Returns the maximum size to which the concurrent vector can grow without having to allocate more memory. This method is concurrency-safe.|  
|[concurrent_vector::cbegin Method](#concurrent_vector__cbegin_method)|Returns an iterator of type                                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to the beginning of the concurrent vector. This method is concurrency-safe.|  
|[concurrent_vector::cend Method](#concurrent_vector__cend_method)|Returns an iterator of type                                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to the end of the concurrent vector. This method is concurrency-safe.|  
|[concurrent_vector::clear Method](#concurrent_vector__clear_method)|Erases all elements in the concurrent vector. This method is not concurrency-safe.|  
|[concurrent_vector::crbegin Method](#concurrent_vector__crbegin_method)|Returns an iterator of type                                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to the beginning of the concurrent vector. This method is concurrency-safe.|  
|[concurrent_vector::crend Method](#concurrent_vector__crend_method)|Returns an iterator of type                                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to the end of the concurrent vector. This method is concurrency-safe.|  
|[concurrent_vector::empty Method](#concurrent_vector__empty_method)|Tests if the concurrent vector is empty at the time this method is called. This method is concurrency-safe.|  
|[concurrent_vector::end Method](#concurrent_vector__end_method)|Overloaded. Returns an iterator of type                                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> or                                         <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to the end of the concurrent vector. This method is concurrency-safe.|  
|[concurrent_vector::front Method](#concurrent_vector__front_method)|Overloaded. Returns a reference or a                                         <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> reference to the first element in the concurrent vector. If the concurrent vector is empty, the return value is undefined. This method is concurrency-safe.|  
|[concurrent_vector::get_allocator Method](#concurrent_vector__get_allocator_method)|Returns a copy of the allocator used to construct the concurrent vector. This method is concurrency-safe.|  
|[concurrent_vector::grow_by Method](#concurrent_vector__grow_by_method)|Overloaded. Grows this concurrent vector by                                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> elements. This method is concurrency-safe.|  
|[concurrent_vector::grow_to_at_least Method](#concurrent_vector__grow_to_at_least_method)|Grows this concurrent vector until it has at least                                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> elements. This method is concurrency-safe.|  
|[concurrent_vector::max_size Method](#concurrent_vector__max_size_method)|Returns the maximum number of elements the concurrent vector can hold. This method is concurrency-safe.|  
|[concurrent_vector::push_back Method](#concurrent_vector__push_back_method)|Overloaded. Appends the given item to the end of the concurrent vector. This method is concurrency-safe.|  
|[concurrent_vector::rbegin Method](#concurrent_vector__rbegin_method)|Overloaded. Returns an iterator of type                                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> or                                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> to the beginning of the concurrent vector. This method is concurrency-safe.|  
|[concurrent_vector::rend Method](#concurrent_vector__rend_method)|Overloaded. Returns an iterator of type                                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> or                                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to the end of the concurrent vector. This method is concurrency-safe.|  
|[concurrent_vector::reserve Method](#concurrent_vector__reserve_method)|Allocates enough space to grow the concurrent vector to size                                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> without having to allocate more memory later. This method is not concurrency-safe.|  
|[concurrent_vector::resize Method](#concurrent_vector__resize_method)|Overloaded. Changes the size of the concurrent vector to the requested size, deleting or adding elements as necessary. This method is not concurrency-safe.|  
|[concurrent_vector::shrink_to_fit Method](#concurrent_vector__shrink_to_fit_method)|Compacts the internal representation of the concurrent vector to reduce fragmentation and optimize memory usage. This method is not concurrency-safe.|  
|[concurrent_vector::size Method](#concurrent_vector__size_method)|Returns the number of elements in the concurrent vector. This method is concurrency-safe.|  
|[concurrent_vector::swap Method](#concurrent_vector__swap_method)|Swaps the contents of two concurrent vectors. This method is not concurrency-safe.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[concurrent_vector::operator&#91;&#93; Operator](#concurrent_vector__operator_at_operator)|Overloaded. Provides access to the element at the given index in the concurrent vector. This method is concurrency-safe for read operations, and also while growing the vector, as long as the you have ensured that the value                                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is less than the size of the concurrent vector.|  
|[concurrent_vector::operator= Operator](#concurrent_vector__operator_eq_operator)|Overloaded. Assigns the contents of another                                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object to this one. This method is not concurrency-safe.|  
  
## Remarks  
 For detailed information on the                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> class, see                 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
##  \<a name="concurrent_vector__assign_method">\</a>  concurrent_vector::assign Method  
 Erases the elements of the concurrent vector and assigns to it either                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> copies of                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, or values specified by the iterator range [                <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>). This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 The type of the specified iterator.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The number of items to copy into the concurrent vector.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Reference to a value used to fill the concurrent vector.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 An iterator to the first element of the source range.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 An iterator to one past the last element of the source range.  
  
### Remarks  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> is not concurrency-safe. You must ensure that no other threads are invoking methods on the concurrent vector when you call this method.  
  
##  \<a name="concurrent_vector__at_method">\</a>  concurrent_vector::at Method  
 Provides access to the element at the given index in the concurrent vector. This method is concurrency-safe for read operations, and also while growing the vector, as long as you have ensured that the value                 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> is less than the size of the concurrent vector.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The index of the element to be retrieved.  
  
### Return Value  
 A reference to the item at the given index.  
  
### Remarks  
 The version of the function                         <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> that returns a non-                        <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> reference cannot be used to concurrently write to the element from different threads. A different synchronization object should be used to synchronize concurrent read and write operations to the same data element.  
  
 The method throws                         <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> if                         <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> is greater than or equal to the size of the concurrent vector, and                         <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> if the index is for a broken portion of the vector. For details on how a vector can become broken, see                         [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md).  
  
##  \<a name="concurrent_vector__back_method">\</a>  concurrent_vector::back Method  
 Returns a reference or a                 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> reference to the last element in the concurrent vector. If the concurrent vector is empty, the return value is undefined. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A reference or a                         <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> reference to the last element in the concurrent vector.  
  
##  \<a name="concurrent_vector__begin_method">\</a>  concurrent_vector::begin Method  
 Returns an iterator of type                 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> to the beginning of the concurrent vector. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 An iterator of type                         <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> to the beginning of the concurrent vector.  
  
##  \<a name="concurrent_vector__capacity_method">\</a>  concurrent_vector::capacity Method  
 Returns the maximum size to which the concurrent vector can grow without having to allocate more memory. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The maximum size to which the concurrent vector can grow without having to allocate more memory.  
  
### Remarks  
 Unlike an STL                         <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>, a                         <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object does not move existing elements if it allocates more memory.  
  
##  \<a name="concurrent_vector__cbegin_method">\</a>  concurrent_vector::cbegin Method  
 Returns an iterator of type                 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> to the beginning of the concurrent vector. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 An iterator of type                         <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> to the beginning of the concurrent vector.  
  
##  \<a name="concurrent_vector__cend_method">\</a>  concurrent_vector::cend Method  
 Returns an iterator of type                 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> to the end of the concurrent vector. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 An iterator of type                         <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> to the end of the concurrent vector.  
  
##  \<a name="concurrent_vector__clear_method">\</a>  concurrent_vector::clear Method  
 Erases all elements in the concurrent vector. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> is not concurrency-safe. You must ensure that no other threads are invoking methods on the concurrent vector when you call this method.                         <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> does not free internal arrays. To free internal arrays, call the function                         <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> after                         <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
##  \<a name="concurrent_vector__concurrent_vector_constructor">\</a>  concurrent_vector::concurrent_vector Constructor  
 Constructs a concurrent vector.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The allocator type of the source vector.  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 The type of the input iterator.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 The allocator class to use with this object.  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 The source                                 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object to copy or move elements from.  
  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The initial capacity of the                                 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The value of elements in the constructed object.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Position of the first element beyond the range of elements to be copied.  
  
### Remarks  
 All constructors store an allocator object                         <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> and initialize the vector.  
  
 The first constructor specify an empty initial vector and explicitly specifies the allocator type. to be used.  
  
 The second and third constructors specify a copy of the concurrent vector                         <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
 The fourth constructor specifies a move of the concurrent vector                         <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
 The fifth constructor specifies a repetition of a specified number (                        <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>) of elements of the default value for class                         <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.  
  
 The sixth constructor specifies a repetition of (                        <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>) elements of value                         <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
 The last constructor specifies values supplied by the iterator range [                        <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>).  
  
##  \<a name="concurrent_vector___dtorconcurrent_vector_destructor">\</a>  concurrent_vector::~concurrent_vector Destructor  
 Erases all elements and destroys this concurrent vector.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="concurrent_vector__crbegin_method">\</a>  concurrent_vector::crbegin Method  
 Returns an iterator of type                 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> to the beginning of the concurrent vector. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 An iterator of type                         <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> to the beginning of the concurrent vector.  
  
##  \<a name="concurrent_vector__crend_method">\</a>  concurrent_vector::crend Method  
 Returns an iterator of type                 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> to the end of the concurrent vector. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 An iterator of type                         <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> to the end of the concurrent vector.  
  
##  \<a name="concurrent_vector__empty_method">\</a>  concurrent_vector::empty Method  
 Tests if the concurrent vector is empty at the time this method is called. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> if the vector was empty at the moment the function was called,                         <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="concurrent_vector__end_method">\</a>  concurrent_vector::end Method  
 Returns an iterator of type                 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> to the end of the concurrent vector. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 An iterator of type                         <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> to the end of the concurrent vector.  
  
##  \<a name="concurrent_vector__front_method">\</a>  concurrent_vector::front Method  
 Returns a reference or a                 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> reference to the first element in the concurrent vector. If the concurrent vector is empty, the return value is undefined. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 A reference or a                         <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> reference to the first element in the concurrent vector.  
  
##  \<a name="concurrent_vector__get_allocator_method">\</a>  concurrent_vector::get_allocator Method  
 Returns a copy of the allocator used to construct the concurrent vector. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 A copy of the allocator used to construct the                         <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> object.  
  
##  \<a name="concurrent_vector__grow_by_method">\</a>  concurrent_vector::grow_by Method  
 Grows this concurrent vector by                 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> elements. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 The number of elements to append to the object.  
  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 The value to initialize the new elements with.  
  
### Return Value  
 An iterator to first item appended.  
  
### Remarks  
 If                         <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> is not specified, the new elements are default constructed.  
  
##  \<a name="concurrent_vector__grow_to_at_least_method">\</a>  concurrent_vector::grow_to_at_least Method  
 Grows this concurrent vector until it has at least                 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> elements. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 The new minimum size for the                                 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> object.  
  
### Return Value  
 An iterator that points to beginning of appended sequence, or to the element at index                         <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> if no elements were appended.  
  
##  \<a name="concurrent_vector__max_size_method">\</a>  concurrent_vector::max_size Method  
 Returns the maximum number of elements the concurrent vector can hold. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The maximum number of elements the                         <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> object can hold.  
  
##  \<a name="concurrent_vector__operator_eq_operator">\</a>  concurrent_vector::operator= Operator  
 Assigns the contents of another                 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> object to this one. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 The allocator type of the source vector.  
  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 The source                                 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A reference to this                         <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object.  
  
##  \<a name="concurrent_vector__operator_at_operator">\</a>  concurrent_vector::operator[] Operator  
 Provides access to the element at the given index in the concurrent vector. This method is concurrency-safe for read operations, and also while growing the vector, as long as the you have ensured that the value                 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> is less than the size of the concurrent vector.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 The index of the element to be retrieved.  
  
### Return Value  
 A reference to the item at the given index.  
  
### Remarks  
 The version of                         <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> that returns a non-                        <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> reference cannot be used to concurrently write to the element from different threads. A different synchronization object should be used to synchronize concurrent read and write operations to the same data element.  
  
 No bounds checking is performed to ensure that                         <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> is a valid index into the concurrent vector.  
  
##  \<a name="concurrent_vector__push_back_method">\</a>  concurrent_vector::push_back Method  
 Appends the given item to the end of the concurrent vector. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 The value to be appended.  
  
### Return Value  
 An iterator to item appended.  
  
##  \<a name="concurrent_vector__rbegin_method">\</a>  concurrent_vector::rbegin Method  
 Returns an iterator of type                 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> to the beginning of the concurrent vector. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 An iterator of type                         <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> to the beginning of the concurrent vector.  
  
##  \<a name="concurrent_vector__rend_method">\</a>  concurrent_vector::rend Method  
 Returns an iterator of type                 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> to the end of the concurrent vector. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 An iterator of type                         <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> to the end of the concurrent vector.  
  
##  \<a name="concurrent_vector__reserve_method">\</a>  concurrent_vector::reserve Method  
 Allocates enough space to grow the concurrent vector to size                 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> without having to allocate more memory later. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 The number of elements to reserve space for.  
  
### Remarks  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> is not concurrency-safe. You must ensure that no other threads are invoking methods on the concurrent vector when you call this method. The capacity of the concurrent vector after the method returns may be bigger than the requested reservation.  
  
##  \<a name="concurrent_vector__resize_method">\</a>  concurrent_vector::resize Method  
 Changes the size of the concurrent vector to the requested size, deleting or adding elements as necessary. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 The new size of the concurrent_vector.  
  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 The value of new elements added to the vector if the new size is larger than the original size. If the value is omitted, the new objects are assigned the default value for their type.  
  
### Remarks  
 If the size of the container is less than the requested size, elements are added to the vector until it reaches the requested size. If the size of the container is larger than the requested size, the elements closest to the end of the container are deleted until the container reaches the size                         <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>. If the present size of the container is the same as the requested size, no action is taken.  
  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> is not concurrency safe. You must ensure that no other threads are invoking methods on the concurrent vector when you call this method.  
  
##  \<a name="concurrent_vector__shrink_to_fit_method">\</a>  concurrent_vector::shrink_to_fit Method  
 Compacts the internal representation of the concurrent vector to reduce fragmentation and optimize memory usage. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 This method will internally re-allocate memory move elements around, invalidating all the iterators.                         <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> is not concurrency-safe. You must ensure that no other threads are invoking methods on the concurrent vector when you call this function.  
  
##  \<a name="concurrent_vector__size_method">\</a>  concurrent_vector::size Method  
 Returns the number of elements in the concurrent vector. This method is concurrency-safe.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements in this                         <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The returned size is guaranteed to include all elements appended by calls to the function                         <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>, or grow operations that have completed prior to invoking this method. However, it may also include elements that are allocated but still under construction by concurrent calls to any of the growth methods.  
  
##  \<a name="concurrent_vector__swap_method">\</a>  concurrent_vector::swap Method  
 Swaps the contents of two concurrent vectors. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> object to swap contents with.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md)