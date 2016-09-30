---
title: "checked_array_iterator Class"
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
  - "iterator/checked_array_iterator"
  - "checked_array_iterator"
  - "std::checked_array_iterator"
  - "std.checked_array_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "checked_array_iterator, syntax"
  - "checked_array_iterator class"
  - "checked_array_iterator"
ms.assetid: 7f07185e-d588-4ae3-9c4f-84ec4aa25a28
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# checked_array_iterator Class
The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> class allows you to transform an array or pointer into a checked iterator. Use this class as a wrapper (using the [make_checked_array_iterator](../vs140/-iterator--functions.md#make_checked_array_iterator) function) for raw pointers or arrays as a targeted way to provide checking and to manage unchecked pointer warnings instead of globally silencing these warnings. If necessary, you can use the unchecked version of this class, [unchecked_array_iterator](../vs140/unchecked_array_iterator-class.md).  
  
> [!NOTE]
>  This class is a Microsoft extension of the Standard C++ Library. Code implemented by using this function is not portable to C++ Standard build environments that do not support this Microsoft extension. For an example demonstrating how to write code that does not require the use of this class, see the second example below.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This class is defined in the [stdext](../vs140/stdext-namespace.md) namespace.  
  
 For more information and example code on the checked iterator feature, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
 The following sample shows how to define and use a checked array iterator.  
  
 If the destination is not large enough to hold all the elements being copied, such as would be the case if you changed the line:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 to  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A runtime error will occur.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 To avoid the need for the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> class when using Standard C++ Library algorithms, consider using a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> instead of a dynamically allocated array. The following example demonstrates how to do this.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Constructors  
  
|||  
|-|-|  
|[checked_array_iterator](#checked_array_iterator__checked_array_iterator)|Constructs a default <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> from an underlying iterator.|  
  
### Typedefs  
  
|||  
|-|-|  
|[difference_type](#checked_array_iterator__difference_type)|A type that provides the difference between two <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>s referring to elements within the same container.|  
|[pointer](#checked_array_iterator__pointer)|A type that provides a pointer to an element addressed by a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.|  
|[reference](#checked_array_iterator__reference)|A type that provides a reference to an element addressed by a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[base](#checked_array_iterator__base)|Recovers the underlying iterator from its <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator==](#checked_array_iterator__operator_eq_eq)|Tests two <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>s for equality.|  
|[operator!=](#checked_array_iterator__operator_neq)|Tests two <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>s for inequality.|  
|[operator<](#checked_array_iterator__operator_lt_)|Tests if the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> on the left side of the operator is less than the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> on the right side.|  
|[operator>](#checked_array_iterator__operator_gt_)|Tests if the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> on the left side of the operator is greater than the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> on the right side.|  
|[operator<=](#checked_array_iterator__operator_lt__eq)|Tests if the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> on the left side of the operator is less than or equal to the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> on the right side.|  
|[operator>=](#checked_array_iterator__operator_gt__eq)|Tests if the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> on the left side of the operator is greater than or equal to the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> on the right side.|  
|[operator*](#checked_array_iterator__operator_star)|Returns the element that a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> addresses.|  
|[operator->](#checked_array_iterator__operator-_gt_)|Returns a pointer to the element addressed by the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.|  
|[operator++](#checked_array_iterator__operator_add_add)|Increments the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to the next element.|  
|[operator--](#checked_array_iterator__operator--)|Decrements the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to the previous element.|  
|[operator+=](#checked_array_iterator__operator_add_eq)|Adds a specified offset to a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.|  
|[operator+](#checked_array_iterator__operator_add)|Adds an offset to an iterator and returns the new <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> addressing the inserted element at the new offset position.|  
|[operator-=](#checked_array_iterator__operator-_eq)|Decrements a specified offset from a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.|  
|[operator-](#checked_array_iterator__operator-)|Decrements an offset from an iterator and returns the new <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> addressing the inserted element at the new offset position.|  
|[operator&#91;&#93;](#checked_array_iterator__operator_at)|Returns a reference to an element offset from the element addressed by a <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> by a specified number of positions.|  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** stdext  
  
##  \<a name="checked_array_iterator__base">\</a>  checked_array_iterator::base  
 Recovers the underlying iterator from its <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__checked_array_iterator">\</a>  checked_array_iterator::checked_array_iterator  
 Constructs a default <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> from an underlying iterator.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 A pointer to the array.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The size of the array.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 (Optional) An element in the array, to initialize the iterator.  By default, the iterator is initialized to the first element in the array.  
  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__difference_type">\</a>  checked_array_iterator::difference_type  
 A type that provides the difference between two <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>s referring to elements within the same container.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> difference type is the same as the iterator difference type.  
  
 See [checked_array_iterator::operator&#91;&#93;](#checked_array_iterator__operator_at) for a code sample.  
  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
##  \<a name="checked_array_iterator__operator_eq_eq">\</a>  checked_array_iterator::operator==  
 Tests two <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>s for equality.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> against which to check for equality.  
  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__operator_neq">\</a>  checked_array_iterator::operator!=  
 Tests two <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>s for inequality.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> against which to check for inequality.  
  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__operator_lt_">\</a>  checked_array_iterator::operator&lt;  
 Tests if the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> on the left side of the operator is less than the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> on the right side.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> against which to check for inequality.  
  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__operator_gt_">\</a>  checked_array_iterator::operator&gt;  
 Tests if the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> on the left side of the operator is greater than the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> on the right side.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> to compare against.  
  
### Remarks  
 See [checked_array_iterator::operator<](#checked_array_iterator__operator_lt_) for a code sample.  
  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
##  \<a name="checked_array_iterator__operator_lt__eq">\</a>  checked_array_iterator::operator&lt;=  
 Tests if the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> on the left side of the operator is less than or equal to the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> on the right side.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> to compare against.  
  
### Remarks  
 See [checked_array_iterator::operator>=](#checked_array_iterator__operator_gt__eq) for a code sample.  
  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
##  \<a name="checked_array_iterator__operator_gt__eq">\</a>  checked_array_iterator::operator&gt;=  
 Tests if the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> on the left side of the operator is greater than or equal to the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> on the right side.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> to compare against.  
  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__operator_star">\</a>  checked_array_iterator::operator*  
 Returns the element that a <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> addresses.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 The value of the element addressed by the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__operator-_gt_">\</a>  checked_array_iterator::operator-&gt;  
 Returns a pointer to the element addressed by the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the element addressed by the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.  
  
### Remarks  
 See [checked_array_iterator::pointer](#checked_array_iterator__pointer) for a code sample.  
  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
##  \<a name="checked_array_iterator__operator_add_add">\</a>  checked_array_iterator::operator++  
 Increments the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> to the next element.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 The first operator returns the preincremented <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> and the second, the postincrement operator, returns a copy of the incremented <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__operator--">\</a>  checked_array_iterator::operator--  
 Decrements the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> to the previous element.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 The first operator returns the predecremented <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> and the second, the postdecrement operator, returns a copy of the decremented <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.  
  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__operator_add_eq">\</a>  checked_array_iterator::operator+=  
 Adds a specified offset to a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 The offset by which to increment the iterator.  
  
### Return Value  
 A reference to the element addressed by the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__operator_add">\</a>  checked_array_iterator::operator+  
 Adds an offset to an iterator and returns the new <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> addressing the inserted element at the new offset position.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The offset to be added to the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
### Return Value  
 A <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> addressing the offset element.  
  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__operator-_eq">\</a>  checked_array_iterator::operator-=  
 Decrements a specified offset from a <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 The offset by which to increment the iterator.  
  
### Return Value  
 A reference to the element addressed by the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.  
  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__operator-">\</a>  checked_array_iterator::operator-  
 Decrements an offset from an iterator and returns the new <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> addressing the inserted element at the new offset position.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The offset to be decremented from the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.  
  
### Return Value  
 A <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> addressing the offset element.  
  
### Remarks  
 See [checked_array_iterator::operator-](#checked_array_iterator__operator-) for a code sample.  
  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
##  \<a name="checked_array_iterator__operator_at">\</a>  checked_array_iterator::operator[]  
 Returns a reference to an element offset from the element addressed by a <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> by a specified number of positions.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The offset from the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> address.  
  
### Return Value  
 The reference to the element offset.  
  
### Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
##  \<a name="checked_array_iterator__pointer">\</a>  checked_array_iterator::pointer  
 A type that provides a pointer to an element addressed by a <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Remarks  
 See [checked_array_iterator::operator*](#checked_array_iterator__operator_star) for a code sample.  
  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
##  \<a name="checked_array_iterator__reference">\</a>  checked_array_iterator::reference  
 A type that provides a reference to an element addressed by a <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Remarks  
 See [checked_array_iterator::operator&#91;&#93;](#checked_array_iterator__operator_at) for a code sample.  
  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)