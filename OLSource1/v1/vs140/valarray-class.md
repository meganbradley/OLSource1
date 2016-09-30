---
title: "valarray Class"
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
  - "valarray"
  - "std.valarray"
  - "std::valarray"
  - "valarray/std::valarray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "valarray class"
ms.assetid: 19b862f9-5d09-4003-8844-6ddd02c1a3a7
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray Class
The template class describes an object that controls a sequence of elements of type **Type** that are stored as an array, designed for performing high-speed mathematical operations, and optimized for computational performance.  
  
## Remarks  
 The class is a representation of the mathematical concept of an ordered set of values and the elements are numbered sequentially from zero. The class is described as a near container because it supports some, but not all, of the capabilities that first-class sequence containers, such as [vector](../vs140/vector-class.md), support. It differs from template class vector in two important ways:  
  
-   It defines numerous arithmetic operations between corresponding elements of **valarray\<Type>** objects of the same type and length, such as                         *xarr* = cos(                        *yarr*) + sin(                        *zarr*).  
  
-   It defines a variety of interesting ways to subscript a **valarray\<Type>** object, by overloading [operator&#91;&#93;](#valarray__operator_at).  
  
 An object of class **Type**:  
  
-   Has a public default constructor, destructor, copy constructor, and assignment operator, with conventional behavior.  
  
-   Defines the arithmetic operators and math functions, as needed, that are defined for the floating-point types, with conventional behavior.  
  
 In particular, no subtle differences may exist between copy construction and default construction followed by assignment. None of the operations on objects of class **Type** may throw exceptions.  
  
### Constructors  
  
|||  
|-|-|  
|[valarray](#valarray__valarray)|Constructs a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> of a specific size or with elements of a specific value or as a copy of another <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> or subset of another <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[value_type](#valarray__value_type)|A type that represents the type of element stored in a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[apply](#valarray__apply)|Applies a specified function to each element of a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.|  
|[cshift](#valarray__cshift)|Cyclically shifts all the elements in a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> by a specified number of positions.|  
|[free](#valarray__free)|Frees the memory used by the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.|  
|[max](#valarray__max)|Finds the largest element in a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.|  
|[min](#valarray__min)|Finds the smallest element in a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.|  
|[resize](#valarray__resize)|Changes the number of elements in a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to a specified number, adding or removing elements as required.|  
|[shift](#valarray__shift)|Shifts all the elements in a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> by a specified number of positions.|  
|[size](#valarray__size)|Finds the number of elements in a <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.|  
|[sum](#valarray__sum)|Determines the sum of all the elements in a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> of nonzero length.|  
|[swap](#valarray__swap)||  
  
### Operators  
  
|||  
|-|-|  
|[operator!](#valarray__operator_not)|A unary operator that obtains the logical <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> values of each element in a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.|  
|[operator%=](#valarray__operator_mod_eq)|Obtains the remainder of dividing the elements of an array element-wise either by a specified <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> or by a value of the element type.|  
|[operator&=](#valarray__operator_amp__eq)|Obtains the bitwise <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> of elements in an array either with the corresponding elements in a specified <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> or with a value of the element type.|  
|[operator>>=](#valarray__operator_gt__gt__eq)|Right-shifts the bits for each element of a <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> operand a specified number of positions or by an element-wise amount specified by a second <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.|  
|[operator<<=](#valarray__operator_lt__lt__eq)|Left-shifts the bits for each element of a <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> operand a specified number of positions or by an element-wise amount specified by a second <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.|  
|[operator*=](#valarray__operator_star_eq)|Multiplies the elements of a specified <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> or a value of the element type, element-wise, to an operand <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.|  
|[operator+](#valarray__operator_add)|A unary operator that applies a plus to each element in a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.|  
|[operator+=](#valarray__operator_add_eq)|Adds the elements of a specified <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> or a value of the element type, element-wise, to an operand <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.|  
|[operator-](#valarray__operator-)|A unary operator that applies a minus to each element in a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.|  
|[operator-=](#valarray__operator-_eq)|Subtracts the elements of a specified <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> or a value of the element type, element-wise, from an operand <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.|  
|[operator/=](#valarray__operator__eq)|Divides an operand <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> element-wise by the elements of a specified <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> or a value of the element type.|  
|[operator=](#valarray__operator_eq)|Assigns elements to a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> whose values are specified either directly or as part of some other <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> or by a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.|  
|[operator&#91;&#93;](#valarray__operator_at)|Returns a reference to an element or its value at specified index or a specified subset.|  
|[operator^=](#valarray__operator_xor_eq)|Obtains the element-wise exclusive logical or operator ( <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>) of an array with either a specified valarray or a value of the element type.|  
|[operator&#124;=](#valarray__operator_or_eq)|Obtains the bitwise <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> of elements in an array either with the corresponding elements in a specified <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> or with a value of the element type.|  
|[operator~](#valarray__operator_dtor)|A unary operator that obtains the bitwise <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> values of each element in a <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
##  \<a name="valarray__apply">\</a>  valarray::apply  
 Applies a specified function to each element of a valarray.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 *_Func(Type)*  
 The function object to be applied to each element of the operand valarray.  
  
 *_Func(const Type&)*  
 The function object for const to be applied to each element of the operand valarray.  
  
### Return Value  
 A valarray whose elements have had <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> applied element-wise to the elements of the operand valarray.  
  
### Remarks  
 The member function returns an object of class [valarray](../vs140/valarray-class.md)**\<Type>**, of length [size](#valarray__size), each of whose elements <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is **func**(( **\*this**)[ <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>]).  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="valarray__cshift">\</a>  valarray::cshift  
 Cyclically shifts all the elements in a valarray by a specified number of positions.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The number of places the elements are to be shifted forward.  
  
### Return Value  
 A new valarray in which all the elements have been moved <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> positions cyclically toward the front of the valarray, left with respect to their positions in the operand valarray.  
  
### Remarks  
 A positive value of <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> shifts the elements cyclically left <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> places.  
  
 A negative value of <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> shifts the elements cyclically right <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> places.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="valarray__free">\</a>  valarray::free  
 Frees the memory used by the valarray.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This nonstandard function is equivalent to assigning an empty valarray. For example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="valarray__max">\</a>  valarray::max  
 Finds the largest element in a valarray.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The maximum value of the elements in the operand valarray.  
  
### Remarks  
 The member function compares values by applying **operator\<** or **operator>** between pairs of elements of class **Type**, for which operators must be provided for the element **Type**.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="valarray__min">\</a>  valarray::min  
 Finds the smallest element in a valarray.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The minimum value of the elements in the operand valarray.  
  
### Remarks  
 The member function compares values by applying **operator\<** or **operator>** between pairs of elements of class **Type**, for which operators must be provided for the element **Type**.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator_not">\</a>  valarray::operator!  
 A unary operator that obtains the logical **NOT** values of each element in a valarray.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The valarray of Boolean values that are the negation of the element values of the operand valarray.  
  
### Remarks  
 The logical operation **NOT** negates the elements because it converts all zeros into ones and regards all nonzero values as ones and converts them into zeros. The returned valarray of Boolean values is of the same size as the operand valarray.  
  
 There is also a bitwise **NOT**[valarray::operator~](#valarray__operator_dtor) that negates on the level of individual bits within the binary representation of <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> elements of a valarray.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator_mod_eq">\</a>  valarray::operator%=  
 Obtains the remainder of dividing the elements of an array element-wise either by a specified valarray or by a value of the element type.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 The valarray or value of an element type identical to that of the operand valarray that is to divide, element-wise, the operand valarray.  
  
### Return Value  
 A valarray whose elements are the remainder from the element-wise division of the operand valarray by <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator_amp__eq">\</a>  valarray::operator&amp;=  
 Obtains the bitwise **AND** of elements in an array either with the corresponding elements in a specified valarray or with a value of the element type.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The valarray or value of an element type identical to that of the operand valarray that is to be combined, element-wise, by the logical **AND** with the operand valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise logical **AND** of the operand valarray by <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
  
### Remarks  
 A bitwise operation can only be used to manipulate bits in <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> data types and variants and not on **float**, **double**, **longdouble**, <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>, or other, more complex data types.  
  
 The bitwise AND has the same truth table as the logical **AND** but applies to the data type on the level of the individual bits. Given bits                         *b*1 and                         *b*2,                         *b*1 **AND** *b*2 is **true** if both bits are true; **false** if at least one is false.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator_gt__gt__eq">\</a>  valarray::operator&gt;&gt;=  
 Right-shifts the bits for each element of a valarray operand a specified number of positions or by an element-wise amount specified by a second valarray.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 The value indicating the amount of right shift or valarray whose elements indicate the element-wise amount of right shift.  
  
### Return Value  
 A valarray whose elements have been shifted right the amount specified in <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
### Remarks  
 Signed numbers have their signs preserved.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator_lt__lt__eq">\</a>  valarray::operator&lt;&lt;=  
 Left-shifts the bits for each element of a valarray operand a specified number of positions or by an element-wise amount specified by a second valarray.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The value indicating the amount of left shift or valarray whose elements indicate the element-wise amount of left shift.  
  
### Return Value  
 A valarray whose elements have been shifted left the amount specified in <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
### Remarks  
 Signed numbers have their signs preserved.  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator_star_eq">\</a>  valarray::operator*=  
 Multiplies the elements of a specified valarray or a value of the element type, element-wise, to an operand valarray.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The valarray or value of an element type identical to that of the operand valarray that is to multiply, element-wise, the operand valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise product of the operand valarray and <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator_add">\</a>  valarray::operator+  
 A unary operator that applies a plus to each element in a valarray.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 A valarray whose elements are plus those of the operand array.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator_add_eq">\</a>  valarray::operator+=  
 Adds the elements of a specified valarray or a value of the element type, element-wise, to an operand valarray.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The valarray or value of an element type identical to that of the operand valarray that is to be added, element-wise, to the operand valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise sum of the operand valarray and <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator-">\</a>  valarray::operator-  
 A unary operator that applies a minus to each element in a valarray.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 A valarray whose elements are minus those of the operand array.  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator-_eq">\</a>  valarray::operator-=  
 Subtracts the elements of a specified valarray or a value of the element type, element-wise, from an operand valarray.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 The valarray or value of an element type identical to that of the operand valarray that is to be subtracted, element-wise, from the operand valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise difference of the operand valarray and <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
  
### Example  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator__eq">\</a>  valarray::operator/=  
 Divides an operand valarray element-wise by the elements of a specified valarray or a value of the element type.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The valarray or value of an element type identical to that of the operand valarray that is to be divided, element-wise, into the operand valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise quotient of the operand valarray divided by <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
  
### Example  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator_eq">\</a>  valarray::operator=  
 Assigns elements to a valarray whose values are specified either directly or as part of some other valarray or by a slice_array, gslice_array, mask_array, or indirect_array.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 The valarray to be copied into the operand valarray.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 The value to be assigned to the elements of the operand valarray.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 The slice_array to be copied into the operand valarray.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 The gslice_array to be copied into the operand valarray.  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 The mask_array to be copied into the operand valarray.  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The indirect_array to be copied into the operand valarray.  
  
### Return Value  
 The first member operator replaces the controlled sequence with a copy of the sequence controlled by <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
 The second member operator is the same as the first, but with an [rvalue reference](../vs140/rvalue-reference-declarator----.md).  
  
 The third member operator replaces each element of the controlled sequence with a copy of <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.  
  
 The remaining member operators replace those elements of the controlled sequence selected by their arguments, which are generated only by [operator&#91;&#93;](#valarray__operator_at).  
  
 If the value of a member in the replacement controlled sequence depends on a member in the initial controlled sequence, the result is undefined.  
  
### Remarks  
 If the length of the controlled sequence changes, the result is generally undefined. In this implementation, however, the effect is merely to invalidate any pointers or references to elements in the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator_at">\</a>  valarray::operator[]  
 Returns a reference to an element or its value at specified index or a specified subset.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 The index of the element to be assigned a value.  
  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 A slice_array of a valarray that specifies a subset to be selected or returned to a new valarray.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 A gslice_array of a valarray that specifies a subset to be selected or returned to a new valarray.  
  
 *_Boolarray*  
 A bool_array of a valarray that specifies a subset to be selected or returned to a new valarray.  
  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 An indirect_array of a valarray that specifies a subset to be selected or returned to a new valarray.  
  
### Return Value  
 A reference to an element or its value at specified index or a specified subset.  
  
### Remarks  
 The member operator is overloaded to provide several ways to select sequences of elements from among those controlled by                         *\****this**. The first group of five member operators work in conjunction with various overloads of [operator=](#valarray__operator_eq) (and other assigning operators) to allow selective replacement (slicing) of the controlled sequence. The selected elements must exist.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element outside the bounds of the valarray.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  See the examples for [slice::slice](../vs140/slice-class.md#slice__slice) and [gslice::gslice](../vs140/gslice-class.md#gslice__gslice) for an example of how to declare and use the operator.  
  
##  \<a name="valarray__operator_xor_eq">\</a>  valarray::operator^=  
 Obtains the element-wise exclusive logical or operator ( **XOR**) of an array with either a specified valarray or a value of the element type.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The valarray or value of an element type identical to that of the operand valarray that is to be combined, element-wise, by the exclusive logical **XOR** with the operand valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise, exclusive logical **XOR** of the operand valarray and <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
  
### Remarks  
 The exclusive logical or, referred to as **XOR**, has the following semantics: Given elements                         *e*1 and                         *e*2,                         *e*1 **XOR** *e*2 is **true** if exactly one of the elements is true; **false** if both elements are false or if both elements are true.  
  
### Example  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator_or_eq">\</a>  valarray::operator&#124;=  
 Obtains the bitwise <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> of elements in an array either with the corresponding elements in a specified valarray or with a value of the element type.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 The valarray or value of an element type identical to that of the operand valarray that is to be combined, element-wise, by the bitwise <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> with the operand valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise bitwise <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> of the operand valarray by <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
  
### Remarks  
 A bitwise operation can only be used to manipulate bits in <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> data types and variants and not on **float**, **double**, **longdouble**, <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>, or other, more complex data types.  
  
 The bitwise <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> has the same truth table as the logical <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> but applies to the data type on the level of the individual bits. Given bits                         *b*1 and                         *b*2,                         *b*1 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> *b*2 is **true** if at least one of the bits is true; **false** if both bits are false.  
  
### Example  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
##  \<a name="valarray__operator_dtor">\</a>  valarray::operator~  
 A unary operator that obtains the bitwise **NOT** values of each element in a valarray.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
 The valarray of Boolean values that are the bitwise **NOT** of the element values of the operand valarray.  
  
### Remarks  
 A bitwise operation can only be used to manipulate bits in <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> data types and variants and not on **float**, **double**, **longdouble**, <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> or other, more complex data types.  
  
 The bitwise **NOT** has the same truth table as the logical **NOT** but applies to the data type on the level of the individual bits. Given bit                         *b*, ~                        *b* is true if                         *b* is false and false if                         *b* is true. The logical **NOT**[operator!](#valarray__operator_not) applies on an element level, counting all nonzero values as **true**, and the result is a valarray of Boolean values. The bitwise **NOToperator~**, by contrast, can result in a valarray of values other than 0 or 1, depending on outcome of the bitwise operation.  
  
### Example  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
##  \<a name="valarray__resize">\</a>  valarray::resize  
 Changes the number of elements in a valarray to a specified number.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 The number of elements in the resized valarray.  
  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 The value to be given to the elements of the resized valarray.  
  
### Remarks  
 The first member function initializes elements with their default constructor.  
  
 Any pointers or references to elements in the controlled sequence are invalidated.  
  
### Example  
  The following example demonstrates the use of the valarray::resize member function.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
##  \<a name="valarray__shift">\</a>  valarray::shift  
 Shifts all the elements in a valarray by a specified number of places.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 The number of places the elements are to be shifted forward.  
  
### Return Value  
 A new valarray in which all the elements have been moved <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> positions toward the front of the valarray, left with respect to their positions in the operand valarray.  
  
### Remarks  
 A positive value of <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> shifts the elements left <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> places, with zero fill.  
  
 A negative value of <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> shifts the elements right <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> places, with zero fill.  
  
### Example  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
##  \<a name="valarray__size">\</a>  valarray::size  
 Finds the number of elements in a valarray.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements in the operand valarray.  
  
### Example  
  The following example demonstrates the use of the valarray::size member function.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
##  \<a name="valarray__sum">\</a>  valarray::sum  
 Determines the sum of all the elements in a valarray of nonzero length.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
 The sum of the elements of the operand valarray.  
  
### Remarks  
 If the length is greater than one, the member function adds values to the sum by applying <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> between pairs of elements of class **Type**, which operator, consequently, needs be provided for elements of type **Type**.  
  
### Example  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
##  \<a name="valarray__swap">\</a>  valarray::swap  
 Exchanges the elements of two <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>s.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>168\</CodeContentPlaceHolder>|A <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> providing the elements to be swapped.|  
  
### Remarks  
 The member function swaps the controlled sequences between <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>. It does so in constant time, it throws no exceptions, and it invalidates no references, pointers, or iterators that designate elements in the two controlled sequences.  
  
##  \<a name="valarray__valarray">\</a>  valarray::valarray  
 Constructs a valarray of a specific size or with elements of a specific value or as a copy of another valarray or subset of another valarray.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 The number of elements to be in the valarray.  
  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 The value to be used in initializing the elements in the valarray.  
  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 Pointer to the values to be used to initialize the elements in the valarray.  
  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 An existing valarray to initialize the new valarray.  
  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 A slice_array whose element values are to be used in initializing the elements of the valarray being constructed.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 A gslice_array whose element values are to be used in initializing the elements of the valarray being constructed.  
  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 A mask_array whose element values are to be used in initializing the elements of the valarray being constructed.  
  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 A indirect_array whose element values are to be used in initializing the elements of the valarray being constructed.  
  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 The initializer_list containing the elements to copy.  
  
### Remarks  
 The first (default) constructor initializes the object to an empty array. The next three constructors each initialize the object to an array of <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> elements as follows:  
  
-   For explicit <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>, each element is initialized with the default constructor.  
  
-   For <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>, each element is initialized with <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>.  
  
-   For <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>, the element at position <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> is initialized with <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>[ <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>].  
  
 Each remaining constructor initializes the object to a valarray\<Type> object determined by the subset specified in the argument.  
  
 The last constructor is the same as the next to last, but with an [rvalue reference](../vs140/rvalue-reference-declarator----.md).  
  
### Example  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  **The operand valarray va is:( 0 2 2 2 2 2 2 2 2 2 )The new valarray initialized from the slice is vaSlice =va[slice( 2, 4, 3)] = ( 0 0 0 )1 2 3 4**    
##  \<a name="valarray__value_type">\</a>  valarray::value_type  
 A type that represents the type of element stored in a valarray.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **Type**.  
  
### Example  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)