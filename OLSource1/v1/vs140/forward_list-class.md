---
title: "forward_list Class"
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
  - "std::forward_list"
  - "forward_list"
  - "forward_list/std::forward_list"
  - "std.forward_list"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "forward_list class"
ms.assetid: 89a3b805-ab60-4858-b772-5855130c11b1
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list Class
Describes an object that controls a varying-length sequence of elements. The sequence is stored as a singly-linked list of nodes, each containing a member of type <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|The element data type to be stored in the forward_list.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|The stored allocator object that encapsulates details about the  forward_list allocation and deallocation of memory. This parameter is optional. The default value is allocator< <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>>.|  
  
## Remarks  
 A <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object allocates and frees storage for the sequence it controls through a stored object of class <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> that is based on [allocator Class](../vs140/allocator-class.md) (commonly known as <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. For more information, see [Allocators](../vs140/allocators.md). An allocator object must have the same external interface as an object of template class <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  The stored allocator object is not copied when the container object is assigned.  
  
 Iterators, pointers and references might become invalid when elements of their controlled sequence are erased through <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. Insertions and splices performed on the controlled sequence through <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> do not invalidate iterators.  
  
 Additions to the controlled sequence might occur by calls to [forward_list::insert_after](#forward_list__insert_after), which is the only member function that calls the constructor <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> might also call move constructors. If such an expression throws an exception, the container object inserts no new elements and rethrows the exception. Thus, an object of template class <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is left in a known state when such exceptions occur.  
  
### Constructors  
  
|||  
|-|-|  
|[forward_list](#forward_list__forward_list)|Constructs an object of type <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#forward_list__allocator_type)|A type that represents the allocator class for a forward list object.|  
|[const_iterator](#forward_list__const_iterator)|A type that provides a constant iterator for the forward list.|  
|[const_pointer](#forward_list__const_pointer)|A type that provides a pointer to a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> element in a forward list.|  
|[const_reference](#forward_list__const_reference)|A type that provides a constant reference to an element in the forward list.|  
|[difference_type](#forward_list__difference_type)|A signed integer type that can be used to represent the number of elements of a forward list in a range between elements pointed to by iterators.|  
|[iterator](#forward_list__iterator)|A type that provides an iterator for the forward list.|  
|[pointer](#forward_list__pointer)|A type that provides a pointer to an element in the forward list.|  
|[reference](#forward_list__reference)|A type that provides a reference to an element in the forward list.|  
|[size_type](#forward_list__size_type)|A type that represents the unsigned distance between two elements.|  
|[value_type](#forward_list__value_type)|A type that represents the type of element stored in a forward list.|  
  
### Member Functions  
  
|||  
|-|-|  
|[assign](#forward_list__assign)|Erases elements from a forward list and copies a new set of elements to a target forward list.|  
|[before_begin](#forward_list__before_begin)|Returns an iterator addressing the position before the first element in a forward list.|  
|[begin](#forward_list__begin)|Returns an iterator addressing the first element in a forward list.|  
|[cbefore_begin](#forward_list__cbefore_begin)|Returns a const iterator addressing the position before the first element in a forward list.|  
|[cbegin](#forward_list__cbegin)|Returns a const iterator addressing the first element in a forward list.|  
|[cend](#forward_list__cend)|Returns a const iterator that addresses the location succeeding the last element in a forward list.|  
|[clear](#forward_list__clear)|Erases all the elements of a forward list.|  
|[emplace_after](#forward_list__emplace_after)|Move constructs a new element after a specified position.|  
|[emplace_front](#forward_list__emplace_front)|Adds an element constructed in place to the beginning of the list.|  
|[empty](#forward_list__empty)|Tests whether a forward list is empty.|  
|[end](#forward_list__end)|Returns an iterator that addresses the location succeeding the last element in a forward list.|  
|[erase_after](#forward_list__erase_after)|Removes elements from the forward list after a specified position.|  
|[front](#forward_list__front)|Returns a reference to the first element in a forward list.|  
|[get_allocator](#forward_list__get_allocator)|Returns a copy of the allocator object used to construct a forward list.|  
|[insert_after](#forward_list__insert_after)|Adds elements to the forward list after a specified position.|  
|[max_size](#forward_list__max_size)|Returns the maximum length of a forward list.|  
|[merge](#forward_list__merge)|Removes the elements from the argument list, inserts them into the target forward list, and orders the new, combined set of elements in ascending order or in some other specified order.|  
|[pop_front](#forward_list__pop_front)|Deletes the element at the beginning of a forward list.|  
|[push_front](#forward_list__push_front)|Adds an element to the beginning of a forward list.|  
|[remove](#forward_list__remove)|Erases elements in a forward list that matches a specified value.|  
|[remove_if](#forward_list__remove_if)|Erases elements from a forward list for which a specified predicate is satisfied.|  
|[resize](#forward_list__resize)|Specifies a new size for a forward list.|  
|[reverse](#forward_list__reverse)|Reverses the order in which the elements occur in a forward list.|  
|[sort](#forward_list__sort)|Arranges the elements in ascending order or with an order specified by a predicate.|  
|[splice_after](#forward_list__splice_after)|Restitches links between nodes.|  
|[swap](#forward_list__swap)|Exchanges the elements of two forward lists.|  
|[unique](#forward_list__unique)|Removes adjacent elements that pass a specified test.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#forward_list__operator_eq)|Replaces the elements of the forward list with a copy of another forward list.|  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
##  \<a name="forward_list__allocator_type">\</a>  forward_list::allocator_type  
 A type that represents the allocator class for a forward list object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is a synonym for the template parameter Allocator.  
  
##  \<a name="forward_list__assign">\</a>  forward_list::assign  
 Erases elements from a forward list and copies a new set of elements to a target forward list.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|The beginning of the replacement range.|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|The end of the replacement range.|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|The number of elements to assign.|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|The value to assign each element.|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|The type of the value.|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|The initializer_list to copy.|  
  
### Remarks  
 If the forward_list is an integer type, the first member function behaves the same as <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>. Otherwise, the first member function replaces the sequence controlled by <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> with the sequence  [ <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, which must not overlap the initial controlled sequence.  
  
 The second member function replaces the sequence controlled by <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> with a repetition of <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
 The third member function copies the elements of the initializer_list into the forward_list.  
  
##  \<a name="forward_list__before_begin">\</a>  forward_list::before_begin  
 Returns an iterator addressing the position before the first element in a forward list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A forward iterator that points just before the first element of the sequence (or just before the end of an empty sequence).  
  
### Remarks  
  
##  \<a name="forward_list__begin">\</a>  forward_list::begin  
 Returns an iterator addressing the first element in a forward list.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A forward iterator that points at the first element of the sequence (or just beyond the end of an empty sequence).  
  
### Remarks  
  
##  \<a name="forward_list__cbefore_begin">\</a>  forward_list::cbefore_begin  
 Returns a const iterator addressing the position before the first element in a forward list.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A forward iterator that points just before the first element of the sequence (or just before the end of an empty sequence).  
  
### Remarks  
  
##  \<a name="forward_list__cbegin">\</a>  forward_list::cbegin  
 Returns a <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> forward-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="forward_list__cend">\</a>  forward_list::cend  
 Returns a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A forward-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="forward_list__clear">\</a>  forward_list::clear  
 Erases all the elements of a forward list.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 This member function calls <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
  
##  \<a name="forward_list__const_iterator">\</a>  forward_list::const_iterator  
 A type that provides a constant iterator for the forward list.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> describes an object that can serve as a constant forward iterator for the controlled sequence. It is described here as a synonym for an implementation-defined type.  
  
##  \<a name="forward_list__const_pointer">\</a>  forward_list::const_pointer  
 A type that provides a pointer to a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> element in a forward list.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="forward_list__const_reference">\</a>  forward_list::const_reference  
 A type that provides a constant reference to an element in the forward list.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="forward_list__difference_type">\</a>  forward_list::difference_type  
 A signed integer type that can be used to represent the number of elements of a forward list in a range between elements pointed to by iterators.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> describes an object that can represent the difference between the addresses of any two elements in the controlled sequence.  
  
##  \<a name="forward_list__emplace_after">\</a>  forward_list::emplace_after  
 Move constructs a new element after a specified position.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|The position in the target forward list where the new element is constructed.|  
|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|The constructor argument.|  
  
### Return Value  
 An iterator that designates the newly inserted element.  
  
### Remarks  
 This member function inserts an element with the constructor arguments <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> just after the element pointed to by <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> in the controlled sequence. Its behavior is otherwise the same as [insert_after](#forward_list__insert_after).  
  
##  \<a name="forward_list__emplace_front">\</a>  forward_list::emplace_front  
 Adds an element constructed in place to the beginning of the list.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|The element added to the beginning of the forward list.|  
  
### Remarks  
 This member function inserts an element with the constructor arguments <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> at the end of the controlled sequence.  
  
 If an exception is thrown, the container is left unaltered and the exception is rethrown.  
  
##  \<a name="forward_list__empty">\</a>  forward_list::empty  
 Tests whether a forward list is empty.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> if the forward list is empty; otherwise, <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
##  \<a name="forward_list__end">\</a>  forward_list::end  
 Returns an iterator that addresses the location succeeding the last element in a forward list.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 A forward iterator that points just beyond the end of the sequence.  
  
##  \<a name="forward_list__erase_after">\</a>  forward_list::erase_after  
 Removes elements from the forward list after a specified position.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|The position in the target forward list where the element is erased.|  
|<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>|The beginning of the range to erase.|  
|<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>|The end of the range to erase.|  
  
### Return Value  
 An iterator that designates the first element remaining beyond any elements removed, or [end](#forward_list__end) if no such element exists.  
  
### Remarks  
 The first member function removes the element of the controlled sequence just after <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.  
  
 The second member function removes the elements of the controlled sequence in the range <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> (neither end point is included).  
  
 Erasing <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> elements causes <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> destructor calls. [Reallocation](../vs140/forward_list-class.md) occurs, so iterators and references become invalid for the erased elements.  
  
 The member functions never throw an exception.  
  
##  \<a name="forward_list__forward_list">\</a>  forward_list::forward_list  
 Constructs an object of type <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>|The allocator class to use with this object.|  
|<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>|The number of elements in the list constructed.|  
|<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>|The value of the elements in the list constructed.|  
|<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>|The list of which the constructed list is to be a copy.|  
|<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>|The initializer_list to copy.|  
  
### Remarks  
 All constructors store an [allocator](../vs140/allocator-class.md) and initialize the controlled sequence. The allocator object is the argument <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, if present. For the copy constructor, it is <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>. Otherwise, it is <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
 The first two constructors specify an empty initial controlled sequence.  
  
 The third constructor specifies a repetition of <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
 The fourth and fifth constructors specify a repetition of <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
 The sixth constructor specifies a copy of the sequence controlled by <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> is an integer type, the next two constructors specify a repetition of <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>. Otherwise, the next two constructors specify the sequence <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
 The ninth and tenth constructors are the same as the sixth, but with an [rvalue](../vs140/rvalue-reference-declarator----.md) reference.  
  
 The last constructor specifies the initial controlled sequence with an object of class <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.  
  
##  \<a name="forward_list__front">\</a>  forward_list::front  
 Returns a reference to the first element in a forward list.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the first element of the controlled sequence, which must be non-empty.  
  
##  \<a name="forward_list__get_allocator">\</a>  forward_list::get_allocator  
 Returns a copy of the allocator object used to construct a forward list.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 The stored [allocator](../vs140/allocator-class.md) object.  
  
##  \<a name="forward_list__insert_after">\</a>  forward_list::insert_after  
 Adds elements to the forward list after a specified position.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>130\</CodeContentPlaceHolder>|The position in the target forward list where the first element is inserted.|  
|<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>|The number of elements to insert.|  
|<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>|The beginning of the insertion range.|  
|<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>|The end of the insertion range.|  
|<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>|The element added to the forward list.|  
|<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>|The initializer_list to insert.|  
  
### Return Value  
 An iterator that designates the newly inserted element (first and last member functions only).  
  
### Remarks  
 Each of the member functions inserts—just after the element pointed to by <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> in the controlled sequence—a sequence that' specified by the remaining operands.  
  
 The first member function inserts an element that has value <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> and returns an iterator that designates the newly inserted element.  
  
 The second member function inserts a repetition of <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> is an integer type, the third member function behaves the same as <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>. Otherwise, it inserts the sequence <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>, which must not overlap the initial controlled sequence.  
  
 The fourth member function inserts the sequence that's specified by an object of class <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
 The last member function is the same as the first, but with an [rvalue](../vs140/rvalue-reference-declarator----.md) reference.  
  
 Inserting <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> elements causes <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> constructor calls. [Reallocation](../vs140/forward_list-class.md) occurs, but no iterators or references become invalid.  
  
 If an exception is thrown during the insertion of one or more elements, the container is left unaltered and the exception is rethrown.  
  
##  \<a name="forward_list__iterator">\</a>  forward_list::iterator  
 A type that provides an iterator for the forward list.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> describes an object that can serve as a forward iterator for the controlled sequence. It is described here as a synonym for an implementation-defined type.  
  
##  \<a name="forward_list__max_size">\</a>  forward_list::max_size  
 Returns the maximum length of a forward list.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 The length of the longest sequence that the object can control.  
  
### Remarks  
  
##  \<a name="forward_list__merge">\</a>  forward_list::merge  
 Combines two sorted sequences into a single sorted sequence in linear time. Removes the elements from the argument list, and inserts them into this <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>. The two lists should be sorted by the same compare function object before the call to <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>. The combined list will be sorted by that compare function object.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>|The forward list to merge from.|  
|<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>|The compare function object that is used to sort elements.|  
  
### Remarks  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> removes the elements from the <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> and inserts them into this <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>. Both sequences must be ordered by the same predicate, described below. The combined sequence is also ordered by that compare function object.  
  
 For the iterators <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> designating elements at positions <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>, the first member function imposes the order <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> whenever <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>. (The elements are sorted in <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> order.) The second member function imposes the order <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> whenever <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
 No pairs of elements in the original controlled sequence are reversed in the resulting controlled sequence. If a pair of elements in the resulting controlled sequence compares equal ( <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>), an element from the original controlled sequence appears before an element from the sequence controlled by <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>.  
  
 An exception occurs only if <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> throws an exception. In that case, the controlled sequence is left in unspecified order and the exception is rethrown.  
  
##  \<a name="forward_list__operator_eq">\</a>  forward_list::operator=  
 Replaces the elements of the forward list with a copy of another forward list.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>166\</CodeContentPlaceHolder>|The forward list being copied into the forward list.|  
|<CodeContentPlaceHolder>167\</CodeContentPlaceHolder>|A brace-enclosed initializer list, which behaves just like a sequence of elements of type <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>.|  
  
### Remarks  
 The first member operator replaces the controlled sequence with a copy of the sequence controlled by <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>.  
  
 The second member operator replaces the controlled sequence from an object of class <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>.  
  
 The third member operator is the same as the first, but with an [rvalue](../vs140/rvalue-reference-declarator----.md) reference.  
  
##  \<a name="forward_list__pointer">\</a>  forward_list::pointer  
 A type that provides a pointer to an element in the forward list.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="forward_list__pop_front">\</a>  forward_list::pop_front  
 Deletes the element at the beginning of a forward list.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 The first element of the forward list must be non-empty.  
  
 The member function never throws an exception.  
  
##  \<a name="forward_list__push_front">\</a>  forward_list::push_front  
 Adds an element to the beginning of a forward list.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>171\</CodeContentPlaceHolder>|The element added to the beginning of the forward list.|  
  
### Remarks  
 If an exception is thrown, the container is left unaltered and the exception is rethrown.  
  
##  \<a name="forward_list__reference">\</a>  forward_list::reference  
 A type that provides a reference to an element in the forward list.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="forward_list__remove">\</a>  forward_list::remove  
 Erases elements in a forward list that matches a specified value.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>172\</CodeContentPlaceHolder>|The value which, if held by an element, will result in that element's removal from the list.|  
  
### Remarks  
 The member function removes from the controlled sequence all elements, designated by the iterator <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>, for which <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>.  
  
 The member function never throws an exception.  
  
##  \<a name="forward_list__remove_if">\</a>  forward_list::remove_if  
 Erases elements from a forward list for which a specified predicate is satisfied.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>175\</CodeContentPlaceHolder>|The unary predicate which, if satisfied by an element, results in the deletion of that element from the list.|  
  
### Remarks  
 The member function removes from the controlled sequence all elements, designated by the iterator <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>, for which <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> is true.  
  
 An exception occurs only if <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> throws an exception. In that case, the controlled sequence is left in an unspecified state and the exception is rethrown.  
  
##  \<a name="forward_list__resize">\</a>  forward_list::resize  
 Specifies a new size for a forward list.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>179\</CodeContentPlaceHolder>|The number of elements in the resized forward list.|  
|<CodeContentPlaceHolder>180\</CodeContentPlaceHolder>|The value to use for padding.|  
  
### Remarks  
 The member functions both ensure that the number of elements in the list henceforth is <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>. If it must make the controlled sequence longer, the first member function appends elements with value <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>, while the second member function appends elements with value <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>. To make the controlled sequence shorter, both member functions effectively call <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>.  
  
##  \<a name="forward_list__reverse">\</a>  forward_list::reverse  
 Reverses the order in which the elements occur in a forward list.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="forward_list__size_type">\</a>  forward_list::size_type  
 A type that represents the unsigned distance between two elements.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Remarks  
 The unsigned integer type describes an object that can represent the length of any controlled sequence.  
  
##  \<a name="forward_list__sort">\</a>  forward_list::sort  
 Arranges the elements in ascending order or with an order specified by a predicate.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>185\</CodeContentPlaceHolder>|The ordering predicate.|  
  
### Remarks  
 Both member functions order the elements in the controlled sequence by a predicate, described below.  
  
 For the iterators <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> designating elements at positions <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>, the first member function imposes the order <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> whenever <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>. (The elements are sorted in <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> order.) The member template function imposes the order <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> whenever <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>. No ordered pairs of elements in the original controlled sequence are reversed in the resulting controlled sequence. (The sort is stable.)  
  
 An exception occurs only if <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> throws an exception. In that case, the controlled sequence is left in unspecified order and the exception is rethrown.  
  
##  \<a name="forward_list__splice_after">\</a>  forward_list::splice_after  
 Removes elements from a source forward_list and inserts them into a destination forward_list.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 The position in the destination forward_list after which to insert.  
  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 The source forward_list that is to be inserted into the destination forward_list.  
  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The element to be inserted from the source forward_list.  
  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 The first element in the range to be inserted from source forward_list.  
  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 The first position beyond the range to be inserted from the source forward_list.  
  
### Remarks  
 The first pair of member functions inserts the sequence controlled by <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> just after the element in the controlled sequence pointed to by <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>. It also removes all elements from <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>. ( <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> must not equal <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>.)  
  
 The second pair of member functions removes the element just after <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> in the sequence controlled by <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> and inserts it just after the element in the controlled sequence pointed to by <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>. (If <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>, no change occurs.)  
  
 The third pair of member functions (ranged splice) inserts the subrange designated by <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> from the sequence controlled by <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> just after the element in the controlled sequence pointed to by <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>. It also removes the original subrange from the sequence controlled by <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>. (If <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>, the range <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> must not include the element pointed to by <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>.)  
  
 If the ranged splice inserts <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> elements, and <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>, an object of class [iterator](#forward_list__iterator) is incremented <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> times.  
  
 No iterators, pointers, or references that designate spliced elements become invalid.  
  
### Example  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  **Beginning state of lists:c1 = (10) (11)c2 = (20) (21) (22)c3 = (30) (31)c4 = (40) (41) (42) (43)After splicing c1 into c2:c1 =c2 = (20) (21) (10) (11) (22)After splicing the first element of c3 into c2:c3 = (30)c2 = (20) (21) (31) (10) (11) (22)After splicing a range of c4 into c2:c4 = (40) (41)c2 = (20) (21) (42) (43) (31) (10) (11) (22)**    
##  \<a name="forward_list__swap">\</a>  forward_list::swap  
 Exchanges the elements of two forward lists.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>220\</CodeContentPlaceHolder>|The forward list providing the elements to be exchanged.|  
  
### Remarks  
 The member function swaps the controlled sequences between <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>, it does so in constant time, it throws no exceptions, and it invalidates no references, pointers, or iterators that designate elements in the two controlled sequences. Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
##  \<a name="forward_list__unique">\</a>  forward_list::unique  
 Eliminates all but the first element from every consecutive group of equal elements.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>224\</CodeContentPlaceHolder>|The binary predicate used to compare successive elements.|  
  
### Remarks  
 Keeps the first of each unique element, and removes the rest. The elements must be sorted so that elements of equal value are adjacent in the list.  
  
 The first member function removes from the controlled sequence every element that compares equal to its preceding element. For the iterators <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> designating elements at positions <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>, the second member function removes every element for which <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>.  
  
 For a controlled sequence of length <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> (> 0), the predicate <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> is evaluated <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> times.  
  
 An exception occurs only if <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> throws an exception. In that case, the controlled sequence is left in an unspecified state and the exception is rethrown.  
  
##  \<a name="forward_list__value_type">\</a>  forward_list::value_type  
 A type that represents the type of element stored in a forward list.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter _ <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>.  
  
## See Also  
 [\<forward_list>](../vs140/-forward_list-.md)