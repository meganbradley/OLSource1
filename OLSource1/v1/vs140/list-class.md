---
title: "list Class"
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
  - "std.list"
  - "list"
  - "std::list"
  - "list/std::list"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "list class"
ms.assetid: d3707f4a-10fd-444f-b856-f9ca2077c1cd
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list Class
The STL list class is a template class of sequence containers that maintain their elements in a linear arrangement and allow efficient insertions and deletions at any location within the sequence. The sequence is stored as a bidirectional linked list of elements, each containing a member of some type             *Type*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Type*  
 The element data type to be stored in the list.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The type that represents the stored allocator object that encapsulates details about the list's allocation and deallocation of memory. This argument is optional, and the default value is **allocator**\<                        *Type*>                        *.*  
  
## Remarks  
 The choice of container type should be based in general on the type of searching and inserting required by the application. Vectors should be the preferred container for managing a sequence when random access to any element is at a premium and insertions or deletions of elements are only required at the end of a sequence. The performance of the class deque container is superior when random access is needed and insertions and deletions at both the beginning and the end of a sequence are at a premium.  
  
 The list member functions [merge](#list__merge), [reverse](#list__reverse), [unique](#list__unique), [remove](#list__remove), and [remove_if](#list__remove_if) have been optimized for operation on list objects and offer a high-performance alternative to their generic counterparts.  
  
 List reallocation occurs when a member function must insert or erase elements of the list. In all such cases, only iterators or references that point at erased portions of the controlled sequence become invalid.  
  
 Include the STL standard header \<list> to define the [container](../vs140/stl-containers.md) template class list and several supporting templates.  
  
### Constructors  
  
|||  
|-|-|  
|[list](#list__list)|Constructs a list of a specific size or with elements of a specific value or with a specific <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> or as a copy of some other list.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#list__allocator_type)|A type that represents the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> class for a list object.|  
|[const_iterator](#list__const_iterator)|A type that provides a bidirectional iterator that can read a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> element in a list.|  
|[const_pointer](#list__const_pointer)|A type that provides a pointer to a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> element in a list.|  
|[const_reference](#list__const_reference)|A type that provides a reference to a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> element stored in a list for reading and performing <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> operations.|  
|[const_reverse_iterator](#list__const_reverse_iterator)|A type that provides a bidirectional iterator that can read any <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> element in a list.|  
|[difference_type](#list__difference_type)|A type that provides the difference between two iterators that refer to elements within the same list.|  
|[iterator](#list__iterator)|A type that provides a bidirectional iterator that can read or modify any element in a list.|  
|[pointer](#list__pointer)|A type that provides a pointer to an element in a list.|  
|[reference](#list__reference)|A type that provides a reference to a <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> element stored in a list for reading and performing <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> operations.|  
|[reverse_iterator](#list__reverse_iterator)|A type that provides a bidirectional iterator that can read or modify an element in a reversed list.|  
|[size_type](#list__size_type)|A type that counts the number of elements in a list.|  
|[value_type](#list__value_type)|A type that represents the data type stored in a list.|  
  
### Member Functions  
  
|||  
|-|-|  
|[assign](#list__assign)|Erases elements from a list and copies a new set of elements to the target list.|  
|[back](#list__back)|Returns a reference to the last element of a list.|  
|[begin](#list__begin)|Returns an iterator addressing the first element in a list.|  
|[cbegin](#list__cbegin)|Returns a const iterator addressing the first element in a list.|  
|[cend](#list__cend)|Returns a const iterator that addresses the location succeeding the last element in a list.|  
|[clear](#list__clear)|Erases all the elements of a list.|  
|[crbegin](#list__crbegin)|Returns a const iterator addressing the first element in a reversed list.|  
|[crend](#list__crend)|Returns a const iterator that addresses the location succeeding the last element in a reversed list.|  
|[emplace](#list__emplace)|Inserts an element constructed in place into a list at a specified position.|  
|[emplace_back](#list__emplace_back)|Adds an element constructed in place to the end of a list.|  
|[lemplace_front](#list__emplace_front)|Adds an element constructed in place to the beginning of a list.|  
|[empty](#list__empty)|Tests if a list is empty.|  
|[end](#list__end)|Returns an iterator that addresses the location succeeding the last element in a list.|  
|[erase](#list__erase)|Removes an element or a range of elements in a list from specified positions.|  
|[front](#list__front)|Returns a reference to the first element in a list.|  
|[get_allocator](#list__get_allocator)|Returns a copy of the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> object used to construct a list.|  
|[insert](#list__insert)|Inserts an element or a number of elements or a range of elements into a list at a specified position.|  
|[max_size](#list__max_size)|Returns the maximum length of a list.|  
|[merge](#list__merge)|Removes the elements from the argument list, inserts them into the target list, and orders the new, combined set of elements in ascending order or in some other specified order.|  
|[pop_back](#list__pop_back)|Deletes the element at the end of a list.|  
|[pop_front](#list__pop_front)|Deletes the element at the beginning of a list.|  
|[push_back](#list__push_back)|Adds an element to the end of a list.|  
|[push_front](#list__push_front)|Adds an element to the beginning of a list.|  
|[rbegin](#list__rbegin)|Returns an iterator addressing the first element in a reversed list.|  
|[remove](#list__remove)|Erases elements in a list that match a specified value.|  
|[remove_if](#list__remove_if)|Erases elements from the list for which a specified predicate is satisfied.|  
|[rend](#list__rend)|Returns an iterator that addresses the location succeeding the last element in a reversed list.|  
|[resize](#list__resize)|Specifies a new size for a list.|  
|[reverse](#list__reverse)|Reverses the order in which the elements occur in a list.|  
|[size](#list__size)|Returns the number of elements in a list.|  
|[sort](#list__sort)|Arranges the elements of a list in ascending order or with respect to some other order relation.|  
|[splice](#list__splice)|Removes elements from the argument list and inserts them into the target list.|  
|[swap](#list__swap)|Exchanges the elements of two lists.|  
|[unique](#list__unique)|Removes adjacent duplicate elements or adjacent elements that satisfy some other binary predicate from the list.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#list__operator_eq)|Replaces the elements of the list with a copy of another list.|  
  
## Requirements  
 **Header**: \<list>  
  
##  \<a name="list__allocator_type">\</a>  list::allocator_type  
 A type that represents the allocator class for a list object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> is a synonym for the template parameter **Allocator.**  
  
### Example  
  See the example for [get_allocator](#list__get_allocator).  
  
##  \<a name="list__assign">\</a>  list::assign  
 Erases elements from a list and copies a new set of elements to a target list.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Position of the first element in the range of elements to be copied from the argument list.  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 Position of the first element just beyond the range of elements to be copied from the argument list.  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The number of copies of an element being inserted into the list.  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 The value of the element being inserted into the list.  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The initializer_list that contains the elements to be inserted.  
  
### Remarks  
 After erasing any existing elements in the target list, assign either inserts a specified range of elements from the original list or from some other list into the target list or inserts copies of a new element of a specified value into the target list  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **c1 = 10 20 30c1 = 50 60c1 = 4 4 4 4 4 4 4c1 = 10 20 30 40**    
##  \<a name="list__back">\</a>  list::back  
 Returns a reference to the last element of a list.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The last element of the list. If the list is empty, the return value is undefined.  
  
### Remarks  
 If the return value of **back** is assigned to a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, the list object cannot be modified. If the return value of **back** is assigned to a **reference**, the list object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty list.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **The last integer of c1 is 11**  
**The next-to-last integer of c1 is 10**    
##  \<a name="list__begin">\</a>  list::begin  
 Returns an iterator addressing the first element in a list.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator addressing the first element in the list or to the location succeeding an empty list.  
  
### Remarks  
 If the return value of **begin** is assigned to a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, the elements in the list object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the list object can be modified.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 **The first element of c1 is 1**  
**The first element of c1 is now 20**    
##  \<a name="list__cbegin">\</a>  list::cbegin  
 Returns a <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> bidirectional-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="list__cend">\</a>  list::cend  
 Returns a <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> bidirectional-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="list__clear">\</a>  list::clear  
 Erases all the elements of a list.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 **The size of the list is initially 3**  
**The size of list after clearing is 0**    
##  \<a name="list__const_iterator">\</a>  list::const_iterator  
 A type that provides a bidirectional iterator that can read a **const** element in a list.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
### Example  
  See the example for [back](#list__back).  
  
##  \<a name="list__const_pointer">\</a>  list::const_pointer  
 Provides a pointer to a <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> element in a list.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
 In most cases, an [iterator](#list__iterator) should be used to access the elements in a list object.  
  
##  \<a name="list__const_reference">\</a>  list::const_reference  
 A type that provides a reference to a **const** element stored in a list for reading and performing **const** operations.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> cannot be used to modify the value of an element.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 **The first element is 10**  
**The second element is 20**    
##  \<a name="list__const_reverse_iterator">\</a>  list::const_reverse_iterator  
 A type that provides a bidirectional iterator that can read any **const** element in a list.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> cannot modify the value of an element and is used to iterate through the list in reverse.  
  
### Example  
  See the example for [rbegin](#list__rbegin).  
  
##  \<a name="list__crbegin">\</a>  list::crbegin  
 Returns a const iterator addressing the first element in a reversed list.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [list](../vs140/list-class.md) (or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>).  
  
### Remarks  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> is used with a reversed list just as [begin](#list__begin) is used with a <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>, the list object cannot be modified. [list::rbegin](#list__rbegin) can be used to iterate through a list backwards.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **The last element in the list is 30.**    
##  \<a name="list__crend">\</a>  list::crend  
 Returns a const iterator that addresses the location succeeding the last element in a reversed list.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [list](../vs140/list-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>).  
  
### Remarks  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> is used with a reversed list just as [end](#list__end) is used with a <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
 The value returned by <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The first element in the list is: 10**    
##  \<a name="list__difference_type">\</a>  list::difference_type  
 A signed integer type that can be used to represent the number of elements of a list in a range between elements pointed to by iterators.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> is the type returned when subtracting or incrementing through iterators of the container. The <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> is typically used to represent the number of elements in the range [ <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>) between the iterators <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>, includes the element pointed to by <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> and the range of elements up to, but not including, the element pointed to by <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>.  
  
 Note that although <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers like set, subtraction between iterators is only supported by random-access iterators provided by a random-access container, such as [vector Class](../vs140/vector-class.md).  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 **The number '10' is in c1 collection 1 times.**  
**The number '20' is in c1 collection 2 times.**  
**The number '30' is in c1 collection 3 times.**    
##  \<a name="list__emplace">\</a>  list::emplace  
 Inserts an element constructed in place into a list at a specified position.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>|The position in the target [list](../vs140/list-class.md) where the first element is inserted.|  
|<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>|The element added to the end of the <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>.|  
  
### Remarks  
 If an exception is thrown, the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> is left unaltered and the exception is rethrown.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **Moved first element: a**    
##  \<a name="list__emplace_back">\</a>  list::emplace_back  
 Adds an element constructed in place to the beginning of a list.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>158\</CodeContentPlaceHolder>|The element added to the end of the [list](../vs140/list-class.md).|  
  
### Remarks  
 If an exception is thrown, the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> is left unaltered and the exception is rethrown.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **Moved first element: a**    
##  \<a name="list__emplace_front">\</a>  list::emplace_front  
 Adds an element constructed in place to the beginning of a list.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>|The element added to the beginning of the [list](../vs140/list-class.md).|  
  
### Remarks  
 If an exception is thrown, the <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> is left unaltered and the exception is rethrown.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **Moved first element: a**    
##  \<a name="list__empty">\</a>  list::empty  
 Tests if a list is empty.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the list is empty; **false** if the list is not empty.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 **The list is not empty.**    
##  \<a name="list__end">\</a>  list::end  
 Returns an iterator that addresses the location succeeding the last element in a list.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 A bidirectional iterator that addresses the location succeeding the last element in a list. If the list is empty, then <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
### Remarks  
 **end** is used to test whether an iterator has reached the end of its list.  
  
### Example  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 **The last integer of c1 is 30**  
**The new next-to-last integer of c1 is 400**  
**The list is now: 10 400 30**    
##  \<a name="list__erase">\</a>  list::erase  
 Removes an element or a range of elements in a list from specified positions.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 Position of the element to be removed from the list.  
  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 Position of the first element removed from the list.  
  
 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 Position just beyond the last element removed from the list.  
  
### Return Value  
 A bidirectional iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the list if no such element exists.  
  
### Remarks  
 No reallocation occurs, so iterators and references become invalid only for the erased elements.  
  
 **erase** never throws an exception.  
  
### Example  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 **The initial list is: 10 20 30 40 50**  
**After erasing the first element, the list becomes: 20 30 40 50**  
**After erasing all elements but the first, the list becomes:  20**    
##  \<a name="list__front">\</a>  list::front  
 Returns a reference to the first element in a list.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 If the list is empty, the return is undefined.  
  
### Remarks  
 If the return value of <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>, the list object cannot be modified. If the return value of <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> is assigned to a **reference**, the list object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty list.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 **The first integer of c1 is 10**  
**The first integer of c1 is 11**    
##  \<a name="list__get_allocator">\</a>  list::get_allocator  
 Returns a copy of the allocator object used to construct a list.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
 The allocator used by the list.  
  
### Remarks  
 Allocators for the list class specify how the class manages storage. The default allocators supplied with STL container classes are sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
### Example  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
##  \<a name="list__insert">\</a>  list::insert  
 Inserts an element or a number of elements or a range of elements into a list at a specified position.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>169\</CodeContentPlaceHolder>|The position in the target list where the first element is inserted.|  
|<CodeContentPlaceHolder>170\</CodeContentPlaceHolder>|The value of the element being inserted into the list.|  
|<CodeContentPlaceHolder>171\</CodeContentPlaceHolder>|The number of elements being inserted into the list.|  
|<CodeContentPlaceHolder>172\</CodeContentPlaceHolder>|The position of the first element in the range of elements in the argument list to be copied.|  
|<CodeContentPlaceHolder>173\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements in the argument list to be copied.|  
  
### Return Value  
 The first two insert functions return an iterator that points to the position where the new element was inserted into the list.  
  
### Example  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
##  \<a name="list__iterator">\</a>  list::iterator  
 A type that provides a bidirectional iterator that can read or modify any element in a list.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Remarks  
 A type **iterator** can be used to modify the value of an element.  
  
### Example  
  See the example for [begin](#list__begin).  
  
##  \<a name="list__list">\</a>  list::list  
 Constructs a list of a specific size or with elements of a specific value or with a specific allocator or as a copy of all or part of some other list.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>174\</CodeContentPlaceHolder>|The allocator class to use with this object.|  
|<CodeContentPlaceHolder>175\</CodeContentPlaceHolder>|The number of elements in the list constructed.|  
|<CodeContentPlaceHolder>176\</CodeContentPlaceHolder>|The value of the elements in the list.|  
|<CodeContentPlaceHolder>177\</CodeContentPlaceHolder>|The list of which the constructed list is to be a copy.|  
|<CodeContentPlaceHolder>178\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>179\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>180\</CodeContentPlaceHolder>|The initializer_list that contains the elements to be copied.|  
  
### Remarks  
 All constructors store an allocator object ( <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>) and initialize the list.  
  
 [get_allocator](#list__get_allocator) returns a copy of the allocator object used to construct a list.  
  
 The first two constructors specify an empty initial list, the second specifying the allocator type ( <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>) to be used.  
  
 The third constructor specifies a repetition of a specified number ( <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>) of elements of the default value for class **Type**.  
  
 The fourth and fifth constructors specify a repetition of ( <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>) elements of value <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>.  
  
 The sixth constructor specifies a copy of the list <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>.  
  
 The seventh constructor moves the list <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>.  
  
 The eighth constructor uses an initializer_list to specify the elements.  
  
 The next two constructors copy the range <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> of a list.  
  
 None of the constructors perform any interim reallocations.  
  
### Example  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  **c1 = 0 0 0c2 = 2 2 2 2 2c3 = 1 1 1c4 = 2 2 2 2 2c5 = 2 2c6 = 2 2 2c7 = 2 2 2c8 = 1 2 3 4**    
##  \<a name="list__max_size">\</a>  list::max_size  
 Returns the maximum length of a list.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Return Value  
 The maximum possible length of the list.  
  
### Example  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
##  \<a name="list__merge">\</a>  list::merge  
 Removes the elements from the argument list, inserts them into the target list, and orders the new, combined set of elements in ascending order or in some other specified order.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 The argument list to be merged with the target list.  
  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 The comparison operator used to order the elements of the target list.  
  
### Remarks  
 The argument list <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> is merged with the target list.  
  
 Both argument and target lists must be ordered with the same comparison relation by which the resulting sequence is to be ordered. The default order for the first member function is ascending order. The second member function imposes the user-specified comparison operation <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> of class **Traits**.  
  
### Example  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  **c1 = 3 6**  
**c2 = 2 4**  
**After merging c1 with c2 and sorting with >: c2 = 6 4 3 2**  
**c3 = 5 1**  
**After merging c3 with c2 according to the '>' comparison relation: c2 = 6 5 4 3 2 1**    
##  \<a name="list__operator_eq">\</a>  list::operator=  
 Replaces the elements of the list with a copy of another list.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>193\</CodeContentPlaceHolder>|The [list](../vs140/list-class.md) being copied into the <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>.|  
  
### Remarks  
 After erasing any existing elements in a <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>, the operator either copies or moves the contents of <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
##  \<a name="list__pointer">\</a>  list::pointer  
 Provides a pointer to an element in a list.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Remarks  
 A type **pointer** can be used to modify the value of an element.  
  
 In most cases, an [iterator](#list__iterator) should be used to access the elements in a list object.  
  
##  \<a name="list__pop_back">\</a>  list::pop_back  
 Deletes the element at the end of a list.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Remarks  
 The last element must not be empty. <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> never throws an exception.  
  
### Example  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  **The first element is: 1**  
**The last element is: 2**  
**After deleting the element at the end of the list, the last element is: 1**    
##  \<a name="list__pop_front">\</a>  list::pop_front  
 Deletes the element at the beginning of a list.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Remarks  
 The first element must not be empty. <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> never throws an exception.  
  
### Example  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  **The first element is: 1**  
**The second element is: 2**  
**After deleting the element at the beginning of the list, the first element is: 2**    
##  \<a name="list__push_back">\</a>  list::push_back  
 Adds an element to the end of a list.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>200\</CodeContentPlaceHolder>|The element added to the end of the list.|  
  
### Remarks  
 If an exception is thrown, the list is left unaltered and the exception is rethrown.  
  
### Example  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  **Last element: 1**  
**New last element: 2**  
**Moved first element: a**    
##  \<a name="list__push_front">\</a>  list::push_front  
 Adds an element to the beginning of a list.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>201\</CodeContentPlaceHolder>|The element added to the beginning of the list.|  
  
### Remarks  
 If an exception is thrown, the list is left unaltered and the exception is rethrown.  
  
### Example  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  **First element: 1**  
**New first element: 2**  
**Moved first element: a**    
##  \<a name="list__rbegin">\</a>  list::rbegin  
 Returns an iterator that addresses the first element in a reversed list.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed list (or addressing what had been the last element in the unreversed list).  
  
### Remarks  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> is used with a reversed list just as [begin](#list__begin) is used with a list.  
  
 If the return value of <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>, the list object cannot be modified. If the return value of <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>, the list object can be modified.  
  
 <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> can be used to iterate through a list backwards.  
  
### Example  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  **The last element in the list is 30.**  
**The list is: 10 20 30**  
**The reversed list is: 30 20 10**  
**The last element in the list is now 40.**    
##  \<a name="list__reference">\</a>  list::reference  
 A type that provides a reference to an element stored in a list.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 **The first element is 10**  
**The second element is 20**    
##  \<a name="list__remove">\</a>  list::remove  
 Erases elements in a list that match a specified value.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 The value which, if held by an element, will result in that element's removal from the list.  
  
### Remarks  
 The order of the elements remaining is not affected.  
  
### Example  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  **The initial list is c1 = 5 100 5 200 5 300**  
**After removing elements with value 5, the list becomes c2 = 100 200 300**    
##  \<a name="list__remove_if">\</a>  list::remove_if  
 Erases elements from a list for which a specified predicate is satisfied.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 The unary predicate which, if satisfied by an element, results in the deletion of that element from the list.  
  
### Example  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  **The initial list is c1 = 3 4 5 6 7 8**  
**After removing the odd elements, the list becomes c2 = 4 6 8**    
##  \<a name="list__rend">\</a>  list::rend  
 Returns an iterator that addresses the location that follows the last element in a reversed list.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed list (the location that had preceded the first element in the unreversed list).  
  
### Remarks  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> is used with a reversed list just as [end](#list__end) is used with a list.  
  
 If the return value of <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>, the list object cannot be modified. If the return value of <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>, the list object can be modified.  
  
 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its list.  
  
 The value returned by <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  **The first element in the list is: 10**  
**The list is: 10 20 30**  
**The reversed list is: 30 20 10**  
**The modified reversed list is: 30 20 40**    
##  \<a name="list__resize">\</a>  list::resize  
 Specifies a new size for a list.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 The new size of the list.  
  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 The value of the new elements to be added to the list if the new size is larger that the original size. If the value is omitted, the new elements are assigned the default value for the class.  
  
### Remarks  
 If the list's size is less than the requested size, <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>, elements are added to the list until it reaches the requested size.  
  
 If the list's size is larger than the requested size, the elements closest to the end of the list are deleted until the list reaches the size <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>.  
  
 If the present size of the list is the same as the requested size, no action is taken.  
  
 [size](#list__size) reflects the current size of the list.  
  
### Example  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  **The size of c1 is 4**  
**The value of the last element is 40**  
**The size of c1 is now 5**  
**The value of the last element is now 0**  
**The reduced size of c1 is: 2**  
**The value of the last element is now 20**    
##  \<a name="list__reverse">\</a>  list::reverse  
 Reverses the order in which the elements occur in a list.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  **c1 = 10 20 30**  
**Reversed c1 = 30 20 10**    
##  \<a name="list__reverse_iterator">\</a>  list::reverse_iterator  
 A type that provides a bidirectional iterator that can read or modify an element in a reversed list.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Remarks  
 A type <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> is used to iterate through the list in reverse.  
  
### Example  
  See the example for [rbegin](#list__rbegin).  
  
##  \<a name="list__size">\</a>  list::size  
 Returns the number of elements in a list.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Return Value  
 The current length of the list.  
  
### Example  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  **List length is 1.**  
**List length is now 2.**    
##  \<a name="list__size_type">\</a>  list::size_type  
 A type that counts the number of elements in a list.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Example  
  See the example for [size](#list__size).  
  
##  \<a name="list__sort">\</a>  list::sort  
 Arranges the elements of a list in ascending order or with respect to some other user-specified order.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 The comparison operator used to order successive elements.  
  
### Remarks  
 The first member function puts the elements in ascending order by default.  
  
 The member template function orders the elements according to the user-specified comparison operation <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> of class **Traits**.  
  
### Example  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
  **Before sorting: c1 = 20 10 30**  
**After sorting c1 = 10 20 30**  
**After sorting with 'greater than' operation, c1 = 30 20 10**    
##  \<a name="list__splice">\</a>  list::splice  
 Removes elements from a source list and inserts them into a destination list.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 The position in the destination list before which to insert.  
  
 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 The source list that is to be inserted into the destination list.  
  
 <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
 The element to be inserted from the source list.  
  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 The first element in the range to be inserted from the source list.  
  
 <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
 The first position beyond the last element in the range to be inserted from the source list.  
  
### Remarks  
 The first pair of member functions inserts all elements in the source list into the destination list before the position referred to by <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> and removes all elements from the source list. ( <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> must not equal <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.)  
  
 The second pair of member functions inserts the element referred to by <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> before the position in the destination list referred to by <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> and removes <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> from the source list. (If <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>, no change occurs.)  
  
 The third pair of member functions inserts the range designated by [ <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>) before the element in the destination list referred to by <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> and removes that range of elements from the source list. (If <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>, the range <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> must not include the element pointed to by <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>.)  
  
 If the ranged splice inserts <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> elements, and <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>, an object of class [iterator](../vs140/forward_list-class.md#forward_list__iterator) is incremented <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> times.  
  
 In all cases iterators, pointers, or references that refer to spliced elements remain valid and are transferred to the destination container.  
  
### Example  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  **Beginning state of lists:c1 = 2 elements: (10) (11)c2 = 3 elements: (20) (21) (22)c3 = 2 elements: (30) (31)c4 = 4 elements: (40) (41) (42) (43)After splicing c1 into c2:c1 = 0 elements:c2 = 5 elements: (20) (10) (11) (21) (22)After splicing the first element of c3 into c2:c3 = 1 elements: (31)c2 = 6 elements: (20) (10) (11) (30) (21) (22)After splicing a range of c4 into c2:c4 = 2 elements: (40) (43)c2 = 8 elements: (20) (10) (11) (30) (41) (42) (21) (22)**    
##  \<a name="list__swap">\</a>  list::swap  
 Exchanges the elements of two lists.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
 The list providing the elements to be swapped, or the list whose elements are to be exchanged with those of the list <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
 A list whose elements are to be exchanged with those of the list <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  **The original list c1 is: 1 2 3**  
**After swapping with c2, list c1 is: 10 20**  
**After swapping with c3, list c1 is: 100**    
##  \<a name="list__unique">\</a>  list::unique  
 Removes adjacent duplicate elements or adjacent elements that satisfy some other binary predicate from a list.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>  
 The binary predicate used to compare successive elements.  
  
### Remarks  
 This function assumes that the list is sorted, so that all duplicate elements are adjacent. Duplicates that are not adjacent will not be deleted.  
  
 The first member function removes every element that compares equal to its preceding element.  
  
 The second member function removes every element that satisfies the predicate function <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> when compared with its preceding element. You can use any of the binary function objects declared in the <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>header for the argument _Pred or you can create your own.  
  
### Example  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  **The initial list is c1 = -10 10 10 20 20 -10**  
**After removing successive duplicate elements, c2 = -10 10 20 -10**  
**After removing successive unequal elements, c3 = -10 -10**    
##  \<a name="list__value_type">\</a>  list::value_type  
 A type that represents the data type stored in a list.  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> is a synonym for the template parameter  **Type**.  
  
### Example  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 **44**    
## See Also  
 [\<list>](../vs140/-list-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)