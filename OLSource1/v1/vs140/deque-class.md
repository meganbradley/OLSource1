---
title: "deque Class"
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
  - "std.deque"
  - "deque"
  - "std::deque"
  - "deque/std::deque"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deque class, about deque class"
  - "deque class"
ms.assetid: 64842ee5-057a-4063-8c16-4267a0332584
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque Class
Arranges elements of a given type in a linear arrangement and, like a vector, enables fast random access to any element, and efficient insertion and deletion at the back of the container. However, unlike a vector, the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> class also supports efficient insertion and deletion at the front of the container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The element data type to be stored in the deque.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the deque's allocation and deallocation of memory. This argument is optional, and the default value is **allocator\<Type>***.*  
  
## Remarks  
 The choice of container type should be based in general on the type of searching and inserting required by the application. [Vectors](../vs140/vector-class.md) should be the preferred container for managing a sequence when random access to any element is at a premium and insertions or deletions of elements are only required at the end of a sequence. The performance of the [list](../vs140/list-class.md) container is superior when efficient insertions and deletions (in constant time) at any location within the sequence is at a premium. Such operations in the middle of the sequence require element copies and assignments proportional to the number of elements in the sequence (linear time).  
  
 Deque reallocation occurs when a member function must insert or erase elements of the sequence:  
  
-   If an element is inserted into an empty sequence, or if an element is erased to leave an empty sequence, then iterators earlier returned by [begin](#deque__begin) and [end](#deque__end) become invalid.  
  
-   If an element is inserted at the first position of the deque, then all iterators, but no references, that designate existing elements become invalid.  
  
-   If an element is inserted at the end of the deque, then [end](#deque__end) and all iterators, but no references, that designate existing elements become invalid.  
  
-   If an element is erased at the front of the deque, only that iterator and references to the erased element become invalid.  
  
-   If the last element is erased from the end of the deque, only that iterator to the final element and references to the erased element become invalid.  
  
 Otherwise, inserting or erasing an element invalidates all iterators and references.  
  
### Constructors  
  
|||  
|-|-|  
|[deque](#deque__deque)|Constructs a <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> Several constructors are provided to set up the contents of the new <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> in different ways: empty; loaded with a specified number of empty elements; contents moved or copied from another <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>; contents copied or moved by using an iterator; and one element copied into the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> times. Some of the constructors enable using a custom <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> to create elements.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#deque__allocator_type)|A type that represents the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> class for the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object.|  
|[const_iterator](#deque__const_iterator)|A type that provides a random-access iterator that can access and read elements in the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> as <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|  
|[const_pointer](#deque__const_pointer)|A type that provides a pointer to an element in a <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> as a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|  
|[const_reference](#deque__const_reference)|A type that provides a reference to an element in a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> for reading and other operations as a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|  
|[const_reverse_iterator](#deque__const_reverse_iterator)|A type that provides a random-access iterator that can access and read elements in the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> as <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>. The deque is viewed in reverse. For more information, see [reverse_iterator Class](../vs140/reverse_iterator-class.md)|  
|[difference_type](#deque__difference_type)|A type that provides the difference between two random-access iterators that refer to elements in the same <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.|  
|[iterator](#deque__iterator)|A type that provides a random-access iterator that can read or modify any element in a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.|  
|[pointer](#deque__pointer)|A type that provides a pointer to an element in a <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.|  
|[reference](#deque__reference)|A type that provides a reference to an element stored in a <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.|  
|[reverse_iterator](#deque__reverse_iterator)|A type that provides a random-access iterator that can read or modify an element in a <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. The deque is viewed in reverse order.|  
|[size_type](#deque__size_type)|A type that counts the number of elements in a <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.|  
|[value_type](#deque__value_type)|A type that represents the data type stored in a <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[assign](#deque__assign)|Erases elements from a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> and copies a new sequence of elements to the target <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.|  
|[at](#deque__at)|Returns a reference to the element at a specified location in the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.|  
|[back](#deque__back)|Returns a reference to the last element of the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.|  
|[begin](#deque__begin)|Returns a random-access  iterator addressing the first element in the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.|  
|[cbegin](#deque__cbegin)|Returns a const iterator to the first element in the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.|  
|[cend](#deque__cend)|Returns a random-access <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> iterator that points just beyond the end of the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.|  
|[clear](#deque__clear)|Erases all the elements of a <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.|  
|[crbegin](#deque__crbegin)|Returns a random-access const iterator to the first element in a <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> viewed in reverse order.|  
|[crend](#deque__crend)|Returns a random-access const iterator to the first element in a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> viewed in reverse order.|  
|[emplace](#deque__emplace)|Inserts an element constructed in place into the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> at a specified position.|  
|[emplace_back](#deque__emplace_back)|Adds an element constructed in place to the end of the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.|  
|[emplace_front](#deque__emplace_front)|Adds an element constructed in place to the start of the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.|  
|[empty](#deque__empty)|Returns <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> contains zero elements, and <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> if it contains one or more elements.|  
|[end](#deque__end)|Returns a random-access iterator that points just beyond the end of the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.|  
|[erase](#deque__erase)|Removes an element or a range of elements in a <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> from specified positions.|  
|[front](#deque__front)|Returns a reference to the first element in a <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.|  
|[get_allocator](#deque__get_allocator)|Returns a copy of the <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> object that is used to construct the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.|  
|[insert](#deque__insert)|Inserts an element, several elements, or a range of elements into the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> at a specified position.|  
|[max_size](#deque__max_size)|Returns the maximum possible length of the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.|  
|[pop_back](#deque__pop_back)|Erases the element at the end of the <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.|  
|[pop_front](#deque__pop_front)|Erases the element at the start of the <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.|  
|[push_back](#deque__push_back)|Adds an element to the end of the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.|  
|[push_front](#deque__push_front)|Adds an element to the start of the <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.|  
|[rbegin](#deque__rbegin)|Returns a random-access iterator to the first element in a reversed <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.|  
|[rend](#deque__rend)|Returns a random-access iterator that points just beyond the last element in a reversed <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>.|  
|[resize](#deque__resize)|Specifies a new size for a <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.|  
|[shrink_to_fit](#deque__shrink_to_fit)|Discards excess capacity.|  
|[size](#deque__size)|Returns the number of elements in the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.|  
|[swap](#deque__swap)|Exchanges the elements of two <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>s.|  
  
### Operators  
  
|||  
|-|-|  
|[operator&#91;&#93;](#deque__operator_at)|Returns a reference to the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> element at a specified position.|  
|[operator=](#deque__operator_eq)|Replaces the elements of the <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> with a copy of another <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header**: \<deque>  
  
##  \<a name="deque__allocator_type">\</a>  deque::allocator_type  
 A type that represents the allocator class for the deque object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 **allocator_type** is a synonym for the template parameter **Allocator**.  
  
### Example  
  See the example for [get_allocator](#deque__get_allocator).  
  
##  \<a name="deque__assign">\</a>  deque::assign  
 Erases elements from a deque and copies a new set of elements to the target deque.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 Position of the first element in the range of elements to be copied from the argument deque.  
  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 Position of the first element beyond the range of elements to be copied from the argument deque.  
  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 The number of copies of an element being inserted into the deque.  
  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 The value of the element being inserted into the deque.  
  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 The initializer_list being inserted into the deque.  
  
### Remarks  
 After any existing elements in the target deque are erased, <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> either inserts a specified range of elements from the original deque or from some other deque into the target deque, or inserts copies of a new element of a specified value into the target deque.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **d1 = 5678c1 =102030c1 =5060c1 =4444444**    
##  \<a name="deque__at">\</a>  deque::at  
 Returns a reference to the element at a specified location in the deque.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 The subscript (or position number) of the element to reference in the deque.  
  
### Return Value  
 If <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> is greater than the size of the deque, **at** throws an exception.  
  
### Return Value  
 If the return value of **at** is assigned to a <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>, the deque object cannot be modified. If the return value of **at** is assigned to a **reference**, the deque object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **The first element is 10**  
**The second element is 20**    
##  \<a name="deque__back">\</a>  deque::back  
 Returns a reference to the last element of the deque.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The last element of the deque. If the deque is empty, the return value is undefined.  
  
### Remarks  
 If the return value of **back** is assigned to a <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, the deque object cannot be modified. If the return value of **back** is assigned to a **reference**, the deque object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty deque.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 **The last integer of c1 is 11**  
**The next-to-last integer of c1 is 10**    
##  \<a name="deque__begin">\</a>  deque::begin  
 Returns an iterator addressing the first element in the deque.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A random-access iterator addressing the first element in the deque or to the location succeeding an empty deque.  
  
### Remarks  
 If the return value of **begin** is assigned to a <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>, the deque object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the deque object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 **The first element of c1 is 1**  
**The first element of c1 is now 20**    
##  \<a name="deque__cbegin">\</a>  deque::cbegin  
 Returns a <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> random-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="deque__cend">\</a>  deque::cend  
 Returns a <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A random-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="deque__clear">\</a>  deque::clear  
 Erases all the elements of a deque.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 **The size of the deque is initially 3**  
**The size of the deque after clearing is 0**    
##  \<a name="deque__const_iterator">\</a>  deque::const_iterator  
 A type that provides a random-access iterator that can access and read a **const** element in the deque.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
### Example  
  See the example for [back](#deque__back).  
  
##  \<a name="deque__const_pointer">\</a>  deque::const_pointer  
 Provides a pointer to a <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> element in a deque.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> cannot be used to modify the value of an element. An [iterator](#deque__iterator) is more commonly used to access a deque element.  
  
##  \<a name="deque__const_reference">\</a>  deque::const_reference  
 A type that provides a reference to a **const** element stored in a deque for reading and performing **const** operations.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 **The first element is 10**  
**The second element is 20**    
##  \<a name="deque__const_reverse_iterator">\</a>  deque::const_reverse_iterator  
 A type that provides a random-access iterator that can read any **const** element in the deque.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> cannot modify the value of an element and is used to iterate through the deque in reverse.  
  
### Example  
  See the example for [rbegin](#deque__rbegin) for an example of how to declare and use an iterator.  
  
##  \<a name="deque__crbegin">\</a>  deque::crbegin  
 Returns a const iterator to the first element in a reversed deque.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse random-access iterator addressing the first element in a reversed [deque](../vs140/deque-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>.  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> object cannot be modified.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The first element of deque is 1.**  
**The first element of the reversed deque is 2.**    
##  \<a name="deque__crend">\</a>  deque::crend  
 Returns a const iterator that addresses the location succeeding the last element in a reversed deque.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse random-access iterator that addresses the location succeeding the last element in a reversed [deque](../vs140/deque-class.md) (the location that had preceded the first element in the unreversed deque).  
  
### Remarks  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> just as [cend](../vs140/array-class--stl-.md#array__cend) is used with a <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> (suitably decremented), the <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its deque.  
  
 The value returned by <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **2**  
**1**    
##  \<a name="deque__deque">\</a>  deque::deque  
 Constructs a deque of a specific size, or with elements of a specific value, or with a specific allocator, or as a copy of all or part of some other deque.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>185\</CodeContentPlaceHolder>|The allocator class to use with this object.|  
|<CodeContentPlaceHolder>186\</CodeContentPlaceHolder>|The number of elements in the constructed deque.|  
|<CodeContentPlaceHolder>187\</CodeContentPlaceHolder>|The value of the elements in the constructed deque.|  
|<CodeContentPlaceHolder>188\</CodeContentPlaceHolder>|The deque of which the constructed deque is to be a copy.|  
|<CodeContentPlaceHolder>189\</CodeContentPlaceHolder>|Position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>190\</CodeContentPlaceHolder>|Position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>191\</CodeContentPlaceHolder>|The initializer_list to be copied.|  
  
### Remarks  
 All constructors store an allocator object ( <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>) and initialize the deque.  
  
 The first two constructors specify an empty initial deque; the second one also specifies the allocator type ( <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>) to be used.  
  
 The third constructor specifies a repetition of a specified number ( <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>) of elements of the default value for class <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>.  
  
 The fourth and fifth constructors specify a repetition of ( <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>) elements of value <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>.  
  
 The sixth constructor specifies a copy of the deque <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>.  
  
 The seventh and eighth constructors copy the range <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> of a deque.  
  
 The seventh constructor moves the deque <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>.  
  
 The eighth constructor copies the contents of an initializer_list.  
  
 None of the constructors perform any interim reallocations.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
##  \<a name="deque__difference_type">\</a>  deque::difference_type  
 A type that provides the difference between two iterators that refer to elements within the same deque.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 A <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> can also be described as the number of elements between two pointers.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 **The number '10' is in c1 collection 1 times.**  
**The number '20' is in c1 collection 2 times.**  
**The number '30' is in c1 collection 3 times.**    
##  \<a name="deque__emplace">\</a>  deque::emplace  
 Inserts an element constructed in place into the deque at a specified position.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>202\</CodeContentPlaceHolder>|The position in the [deque](../vs140/deque-class.md) where the first element is inserted.|  
|<CodeContentPlaceHolder>203\</CodeContentPlaceHolder>|The value of the element being inserted into the <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>.|  
  
### Return Value  
 The function returns an iterator that points to the position where the new element was inserted into the deque.  
  
### Remarks  
 Any insertion operation can be expensive, see <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> for a discussion of <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> performance.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **v1 = 10 20 30**  
**vv1[0] = 10 20 30**    
##  \<a name="deque__emplace_back">\</a>  deque::emplace_back  
 Adds an element constructed in place to the end of the deque.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>207\</CodeContentPlaceHolder>|The element added to the end of the [deque](../vs140/deque-class.md).|  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  **Last element: 1**  
**New last element: 2**  
**Moved last element: 2**    
##  \<a name="deque__emplace_front">\</a>  deque::emplace_front  
 Adds an element constructed in place to the end of the deque.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>208\</CodeContentPlaceHolder>|The element added to the beginning of the [deque](../vs140/deque-class.md).|  
  
### Example  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  **Last element: 1**  
**New last element: 2**  
**Moved last element: 2**    
##  \<a name="deque__empty">\</a>  deque::empty  
 Tests if a deque is empty.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the deque is empty; **false** if the deque is not empty.  
  
### Example  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 **The deque is not empty.**    
##  \<a name="deque__end">\</a>  deque::end  
 Returns an iterator that addresses the location succeeding the last element in a deque.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 A random-access iterator that addresses the location succeeding the last element in a deque. If the deque is empty, then deque::end == deque::begin.  
  
### Remarks  
 **end** is used to test whether an iterator has reached the end of its deque.  
  
### Example  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 **The last integer of c1 is 30**  
**The new next-to-last integer of c1 is 400**  
**The deque is now: 10 400 30**    
##  \<a name="deque__erase">\</a>  deque::erase  
 Removes an element or a range of elements in a deque from specified positions.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 Position of the element to be removed from the deque.  
  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 Position of the first element removed from the deque.  
  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 Position just beyond the last element removed from the deque.  
  
### Return Value  
 A random-access iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the deque if no such element exists.  
  
### Remarks  
 For more information on **erase**, see [deque::erase and deque::clear](../vs140/deque--erase-and-deque--clear.md).  
  
 **erase** never throws an exception.  
  
### Example  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 **The initial deque is: 10 20 30 40 50**   
**After erasing the first element, the deque becomes:  20 30 40 50**   
**After erasing all elements but the first, deque becomes: 20**     
##  \<a name="deque__front">\</a>  deque::front  
 Returns a reference to the first element in a deque.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Return Value  
 If the deque is empty, the return is undefined.  
  
### Remarks  
 If the return value of <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>, the deque object cannot be modified. If the return value of <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> is assigned to a **reference**, the deque object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty deque.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 **The first integer of c1 is 10**  
**The second integer of c1 is 11**    
##  \<a name="deque__get_allocator">\</a>  deque::get_allocator  
 Returns a copy of the allocator object used to construct the deque.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 The allocator used by the deque.  
  
### Remarks  
 Allocators for the deque class specify how the class manages storage. The default allocators supplied with STL container classes are sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
### Example  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
##  \<a name="deque__insert">\</a>  deque::insert  
 Inserts an element or a number of elements or a range of elements into the deque at a specified position.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>215\</CodeContentPlaceHolder>|The position in the target deque where the first element is inserted.|  
|<CodeContentPlaceHolder>216\</CodeContentPlaceHolder>|The value of the element being inserted into the deque.|  
|<CodeContentPlaceHolder>217\</CodeContentPlaceHolder>|The number of elements being inserted into the deque.|  
|<CodeContentPlaceHolder>218\</CodeContentPlaceHolder>|The position of the first element in the range of elements in the argument deque to be copied.|  
|<CodeContentPlaceHolder>219\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements in the argument deque to be copied.|  
|<CodeContentPlaceHolder>220\</CodeContentPlaceHolder>|The initializer_list of elements to insert.|  
  
### Return Value  
 The first two insert functions return an iterator that points to the position where the new element was inserted into the deque.  
  
### Remarks  
 Any insertion operation can be expensive.  
  
##  \<a name="deque__iterator">\</a>  deque::iterator  
 A type that provides a random-access iterator that can read or modify any element in a deque.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Remarks  
 A type **iterator** can be used to modify the value of an element.  
  
### Example  
  See the example for [begin](#deque__begin).  
  
##  \<a name="deque__max_size">\</a>  deque::max_size  
 Returns the maximum length of the deque.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
 The maximum possible length of the deque.  
  
### Example  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
##  \<a name="deque__operator_at">\</a>  deque::operator[]  
 Returns a reference to the deque element at a specified position.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 The position of the deque element to be referenced.  
  
### Return Value  
 A reference to the element whose position is specified in the argument. If the position specified is greater than the size of the deque, the result is undefined.  
  
### Remarks  
 If the return value of <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>, the deque object cannot be modified. If the return value of <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> is assigned to a **reference**, the deque object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element outside the bounds of the deque.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 **The first integer of c1 is 10**  
**The second integer of c1 is 20**    
##  \<a name="deque__operator_eq">\</a>  deque::operator=  
 Replaces the elements of this deque using the elements from another deque.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>225\</CodeContentPlaceHolder>|The deque that provides the new content.|  
  
### Remarks  
 The first override copies elements to this deque from <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>, the source of the assignment. The second override moves elements to this deque from <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>.  
  
 Elements that are contained in this deque before the operator executes are removed.  
  
### Example  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
##  \<a name="deque__pointer">\</a>  deque::pointer  
 Provides a pointer to an element in a [deque](../vs140/deque-class.md).  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Remarks  
 A type **pointer** can be used to modify the value of an element. An [iterator](#deque__iterator) is more commonly used to access a deque element.  
  
##  \<a name="deque__pop_back">\</a>  deque::pop_back  
 Deletes the element at the end of the deque.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Remarks  
 The last element must not be empty. <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> never throws an exception.  
  
### Example  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 **The first element is: 1**  
**The last element is: 2**  
**After deleting the element at the end of the deque, the last element is: 1**    
##  \<a name="deque__pop_front">\</a>  deque::pop_front  
 Deletes the element at the beginning of the deque.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Remarks  
 The first element must not be empty. <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> never throws an exception.  
  
### Example  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 **The first element is: 1**  
**The second element is: 2**  
**After deleting the element at the beginning of the deque, the first element is: 2**    
##  \<a name="deque__push_back">\</a>  deque::push_back  
 Adds an element to the end of the deque.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>230\</CodeContentPlaceHolder>|The element added to the end of the deque.|  
  
### Remarks  
 If an exception is thrown, the deque is left unaltered and the exception is rethrown.  
  
##  \<a name="deque__push_front">\</a>  deque::push_front  
 Adds an element to the beginning of the deque.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>231\</CodeContentPlaceHolder>|The element added to the beginning of the deque.|  
  
### Remarks  
 If an exception is thrown, the deque is left unaltered and the exception is rethrown.  
  
### Example  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 **First element: 1**  
**New first element: 2**  
**Moved first element: a**    
##  \<a name="deque__rbegin">\</a>  deque::rbegin  
 Returns an iterator to the first element in a reversed deque.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Return Value  
 A reverse random-access iterator addressing the first element in a reversed deque or addressing what had been the last element in the unreversed deque.  
  
### Remarks  
 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> is used with a reversed deque just as [begin](#deque__begin) is used with a deque.  
  
 If the return value of <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>, the deque object cannot be modified. If the return value of <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>, the deque object can be modified.  
  
 <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> can be used to iterate through a deque backwards.  
  
### Example  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 **Last element in the deque is 30.**  
**The deque contains the elements: 10 20 30 in that order.**  
**The reversed deque is: 30 20 10**   
**Last element in deque is now 40.**    
##  \<a name="deque__reference">\</a>  deque::reference  
 A type that provides a reference to an element stored in a deque.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 **The first element is 10**  
**The second element is 20**    
##  \<a name="deque__rend">\</a>  deque::rend  
 Returns an iterator that addresses the location succeeding the last element in a reversed deque.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Return Value  
 A reverse random-access iterator that addresses the location succeeding the last element in a reversed deque (the location that had preceded the first element in the unreversed deque).  
  
### Remarks  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> is used with a reversed deque just as [end](#deque__end) is used with a deque.  
  
 If the return value of <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>, the deque object cannot be modified. If the return value of <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>, the deque object can be modified.  
  
 <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> can be used to test whether a reverse iterator has reached the end of its deque.  
  
 The value returned by <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 **The first element in the deque is: 10**  
**The deque is: 10 20 30**   
**The reversed deque is: 30 20 10**   
**The modified reversed deque is: 30 20 40**     
##  \<a name="deque__resize">\</a>  deque::resize  
 Specifies a new size for a deque.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
 The new size of the deque.  
  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 The value of the new elements to be added to the deque if the new size is larger that the original size. If the value is omitted, the new elements are assigned the default value for the class.  
  
### Remarks  
 If the deque's size is less than the requested size, <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>, elements are added to the deque until it reaches the requested size.  
  
 If the deque's size is larger than the requested size, the elements closest to the end of the deque are deleted until the deque reaches the size <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>.  
  
 If the present size of the deque is the same as the requested size, no action is taken.  
  
 [size](#deque__size) reflects the current size of the deque.  
  
### Example  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 **The size of c1 is: 4**  
**The value of the last element is 40**  
**The size of c1 is now: 5**  
**The value of the last element is now 0**  
**The reduced size of c1 is: 2**  
**The value of the last element is now 20**    
##  \<a name="deque__reverse_iterator">\</a>  deque::reverse_iterator  
 A type that provides a random-access iterator that can read or modify an element in a reversed deque.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> is use to iterate through the deque.  
  
### Example  
  See the example for [rbegin](../vs140/vector-class.md#vector__rbegin).  
  
##  \<a name="deque__shrink_to_fit">\</a>  deque::shrink_to_fit  
 Discards excess capacity.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Remarks  
 There is no portable way to determine if <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> reduces the storage used by a [deque](../vs140/deque-class.md).  
  
### Example  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  **Current size of v1 = 1**  
**Current size of v1 = 1**    
##  \<a name="deque__size">\</a>  deque::size  
 Returns the number of elements in the deque.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the deque.  
  
### Example  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 **The deque length is 1.**  
**The deque length is now 2.**    
##  \<a name="deque__size_type">\</a>  deque::size_type  
 A type that counts the number of elements in a deque.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Example  
  See the example for [size](#deque__size).  
  
##  \<a name="deque__swap">\</a>  deque::swap  
 Exchanges the elements of two deques.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 The deque providing the elements to be swapped, or the deque whose elements are to be exchanged with those of the deque <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
 A deque whose elements are to be exchanged with those of the deque <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 **The original deque c1 is: 1 2 3**  
**After swapping with c2, deque c1 is: 10 20**  
**After swapping with c3, deque c1 is: 100**  
**After swapping with c2, deque c1 is: 1 2 3**    
##  \<a name="deque__value_type">\</a>  deque::value_type  
 A type that represents the data type stored in a deque.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> is a synonym for the template parameter **Type**.  
  
### Example  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 **44**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)