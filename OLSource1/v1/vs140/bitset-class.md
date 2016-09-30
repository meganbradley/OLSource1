---
title: "bitset Class"
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
  - "bitset/std::bitset"
  - "std::bitset"
  - "std.bitset"
  - "bitset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bitset class"
ms.assetid: 28b86964-87b4-429c-8124-b6c251b6c50b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset Class
Describes a type of object that stores a sequence consisting of a fixed number of bits that provide a compact way of keeping flags for a set of items or conditions. The bitset class supports operations on objects of type bitset that contain a collection of bits and provide constant-time access to each bit.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *N*  
 Specifies the number of bits in the bitset object with a nonzero integer of type                         **size_t** that must be known at compile time.  
  
## Remarks  
 Unlike the similar                 [vector\<bool> Class](../vs140/vector-bool--class.md), the bitset class does not have iterators and is not an Standard Template Library container. It also differs from vector\<bool> by being of some specific size that is fixed at compile time in accordance with the size specified by the template parameter                 **N** when the                 **bitset\<N>** is declared.  
  
 A bit is set if its value is 1 and reset if its value is 0. To flip or toggle a bit is to change its value from 1 to 0 or from 0 to 1. The                 **N** bits in a bitset are indexed by integer values from 0 to                 **N**Â -Â 1, where 0 indexes the first bit position and                 **N***Â* -Â 1 the final bit position.  
  
### Constructors  
  
|||  
|-|-|  
|[bitset](#bitset__bitset)|Constructs an object of class                                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and initializes the bits to zero, to some specified value, or to values obtained from characters in a string.|  
  
### Typedefs  
  
|||  
|-|-|  
|[element_type](#bitset__element_type)|A type that is a synonym for the data type                                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and can be used to reference element bits in a                                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[all](#bitset__all)|Tests all of the bits in this                                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> to determine whether they are all set to                                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.|  
|[any](#bitset__any)|The member function tests whether any bit in the sequence is set to 1.|  
|[count](#bitset__count)|The member function returns the number of bits set in the bit sequence.|  
|[flip](#bitset__flip)|Toggles the value of all the bits in a                                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> or toggles a single bit at a specified position.|  
|[none](#bitset__none)|Tests if no bit has been set to 1 in a                                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.|  
|[reset](#bitset__reset)|Resets all the bits in a                                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to 0 or resets a bit at a specified position to 0.|  
|[set](#bitset__set)|Sets all the bits in a                                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to 1 or sets a bit at a specified position to 1.|  
|[size](#bitset__size)|Returns the number of bits in a                                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object.|  
|[test](#bitset__test)|Tests whether the bit at a specified position in a                                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is set to 1.|  
|[to_string](#bitset__to_string)|Converts a                                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object to a string representation.|  
|[to_ullong](#bitset__to_ullong)|Returns the sum of the bit values in the                                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> as an                                         <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.|  
|[to_ulong](#bitset__to_ulong)|Converts a                                         <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object to the                                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> that would generate the sequence of bits contained if used to initialize the                                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.|  
  
### Member Classes  
  
|||  
|-|-|  
|[reference](#bitset__reference)|A proxy class that provides references to bits contained in a                                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> that is used to access and manipulate the individual bits as a helper class for the                                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> of class                                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator!=](#bitset__operator_neq)|Tests a target                                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> for inequality with a specified                                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.|  
|[operator&=](#bitset__operator_amp__eq)|Performs a bitwise combination of bitsets with the logical                                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> operation.|  
|[operator<<](#bitset__operator_lt__lt_)|Shifts the bits in a                                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> to the left a specified number of positions and returns the result to a new                                         <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.|  
|[operator<<=](#bitset__operator_lt__lt__eq)|Shifts the bits in a                                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> to the left a specified number of positions and returns the result to the targeted                                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.|  
|[operator==](#bitset__operator_eq_eq)|Tests a target                                         <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> for equality with a specified                                         <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.|  
|[operator>>](#bitset__operator_gt__gt_)|Shifts the bits in a                                         <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> to the right a specified number of positions and returns the result to a new                                         <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.|  
|[operator>>=](#bitset__operator_gt__gt__eq)|Shifts the bits in a                                         <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> to the right a specified number of positions and returns the result to the targeted                                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.|  
|[operator&#91;&#93;](#bitset__operator_at)|Returns a reference to a bit at a specified position in a                                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> if the                                         <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> is modifiable; otherwise, it returns the value of the bit at that position.|  
|[operator^=](#bitset__operator_xor_eq)|Performs a bitwise combination of bitsets with the exclusive                                         <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> operation.|  
|[operator&#124;=](#bitset__operator_or_eq')|Performs a bitwise combination of bitsets with the inclusive                                         <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> operation.|  
|[operator~](#bitset__operator_dtor)|Toggles all the bits in a target                                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> and returns the result.|  
  
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
##  \<a name="bitset__all">\</a>  bitset::all  
 Tests all of the bits in this bitset to determine if they are all set to true.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 Returns true if all bits in this set are true. Returns                         **false** if one or more bits are false.  
  
##  \<a name="bitset__any">\</a>  bitset::any  
 Tests whether any bit in the sequence is set to 1.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 **true** if any bit in the bitset is set to 1;                         **false** if all the bits are 0.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The original bitset b1( 6 ) is: ( 00110 )**  
**At least one of the bits in bitset is set to 1.**  
**The reset bitset is: ( 00000 )**  
**None of the bits in bitset b1 are set to 1.**    
##  \<a name="bitset__bitset">\</a>  bitset::bitset  
 Constructs an object of class                 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> and initializes the bits to zero, or to some specified value, or to values obtained from characters in a string.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The unsigned integer whose base two representation is used to initialize the bits in the bitset being constructed.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The string of zeros and ones used to initialize the bitset bit values.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 A C-style string of zeros and ones used to initialize the bitset bit values.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The position of the character in the string, counting from left to right and starting with zero, used to initialize the first bit in the bitset.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 The number of characters in the string that is used to provide initial values for the bits in the bitset.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The character that is used to represent a zero. The default is '0'.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The character that is used to represent a one. The default is '1'.  
  
### Remarks  
 Three constructors can be used to construct obects of class                         <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>:  
  
-   The first constructor accepts no parameters, constructs an object of class                                 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> and initializes all N bits to a default value of zero.  
  
-   The second constructor constructs an object of class                                 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> and initializes the bits by using the single                                 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> parameter.  
  
-   The third constructor constructs an object of class                                 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>, initializing the N bits to values that correspond to the characters provided in a c-style character string of zeros and ones. You call the constructor without casting the string into a string type:                                 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
  
 There are also two constructor templates provided:  
  
-   The first constructor template constructs an object of class                                 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> and initializes bits from the characters provided in a string of zeros and ones. If any characters of the string are other than 0 or 1, the constructor throws an object of class                                 [invalid argument](../vs140/invalid_argument-class.md). If the position specified (                                <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>) is beyond the length of the string, then the constructor throws an object of class                                 [out_of_range](../vs140/out_of_range-class.md). The constructor sets only those bits at position                                 *j* in the bitset for which the character in the string at position                                 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> is 1. By default,                                 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> is 0.  
  
-   The second constructor template is similar to the first, but includes an additional parameter (                                <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>) that is used to specify the number of bits to initialize. It also has two optional parameters,                                 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> and                                 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>, which indicate what character in                                 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> is to be interpreted to mean a 0 bit and a 1 bit, respectively.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The set of bits in bitset\<2> b0 is: ( 00 ).**  
**The set of bits in bitset\<5> b1( 6 ) is: ( 00110 ).**  
**The set of bits in bitset\<2 \* sizeof ( int ) > b2 is: ( 00000000 ).**  
**The set of bits in bitset\<3> b3( 6 ) is ( 110 ).**  
**The set of bits in bitset\<5> b4( bitval4 ) is ( 10011 ).**  
**The set of bits in bitset\<11> b5( bitval, 3, 6 ) is ( 100110 ).**  
**The set of bits in bitset\<11> b6( bitval5, 3, 5 ) is ( 00000010011 ).**  
**The set of bits in bitset\<9> b7( bitval, 2 ) is ( 110011011 ).**    
##  \<a name="bitset__count">\</a>  bitset::count  
 Returns the number of bits set in the bit sequence.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The number of bits set in the bit sequence.  
  
### Example  
  The following example demonstrates the use of the bitset::count member function.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The collection of bits in the original bitset is: ( 00100 )**  
**The number of bits in the bitset set to 1 is: 1.**  
**The collection of flipped bits in the modified bitset is: ( 11011 )**  
**The number of bits in the bitset set to 1 is: 4.**    
##  \<a name="bitset__element_type">\</a>  bitset::element_type  
 A type that is a synonym for the data type                 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> and can be used to reference element bits in a bitset.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **Original bitset b1(6) is: ( 010 )**  
**The bit at position 2 of bitset b1has a value of 0.**  
**Bitset b1 modified by b1[2] = 1 is: ( 110 )**  
**The bit at position 2 of bitset b1has a value of 1.**    
##  \<a name="bitset__flip">\</a>  bitset::flip  
 Toggles the value of all the bits in a bitset or toggles a single bit at a specified position.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The position of the bit whose value is to be toggled.  
  
### Return Value  
 A copy of the modified bitset for which the member function was invoked.  
  
### Remarks  
 The second member function throws an                         [out_of_range](../vs140/out_of_range-class.md) exception if the position specified as a parameter is greater than the size                         *N* of the                         **bitset\<***N***>** whose bit was toggled.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **The collection of bits in the original bitset is: ( 00110 )**  
**After flipping all the bits, the bitset becomes: ( 11001 )**  
**After flipping the fourth bit, the bitset becomes: ( 10001 )**  
**00001  The bit flipped is in position 0.**  
**00011  The bit flipped is in position 1.**  
**00111  The bit flipped is in position 2.**  
**01111  The bit flipped is in position 3.**  
**11111  The bit flipped is in position 4.**    
##  \<a name="bitset__none">\</a>  bitset::none  
 Tests if no bit has been set to 1 in a bitset object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 **true** if no bit in the bitset has been set to 1;                         **false** if at least one bit has been set to 1.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **Original bitset b1(6) is: ( 00110 )**  
**At least one of the bits in bitset b1 is set to 1.**  
**None of the bits in bitset b1 are set to 1.**    
##  \<a name="bitset__operator_neq">\</a>  bitset::operator!=  
 Tests a target bitset for inequality with a specified bitset.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 The bitset that is to be compared to the target bitset for inequality.  
  
### Return Value  
 **true** if the bitsets are different;                         **false** if they are the same.  
  
### Remarks  
 Bitsets must be of the same size to be tested for inequality by the member operator function.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **Bitset b1 is the same as bitset b2.**  
**Bitset b1 is different from bitset b3.**    
##  \<a name="bitset__operator_amp__eq">\</a>  bitset::operator&amp;=  
 Performs a bitwise combination of bitsets with the logical                 **AND** operation.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 The bitset that is to be combined bitwise with the target bitset.  
  
### Return Value  
 The modified target bitset that results from the bitwise                         **AND** operation with the bitset specified as a parameter.  
  
### Remarks  
 Two bits combined by the                         **AND** operator return                         **true** if each bit is true; otherwise, their combination returns                         **false**.  
  
 Bitsets must be of the same size to be combined bitwise with the                         **AND** operator by the member operator function.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  **The target bitset b1 is:    ( 00111 ).**  
**The parameter bitset b2 is: ( 01011 ).**  
**After bitwise AND combination,**  
 **the target bitset b1 becomes:   ( 00011 ).**  
**The parameter bitset b2 remains: ( 01011 ).**    
##  \<a name="bitset__operator_lt__lt_">\</a>  bitset::operator&lt;&lt;  
 Shifts the bits in a bitset to the left a specified number of positions and returns the result to a new bitset.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 The number of positions to the left that the bits in the bitset are to be shifted.  
  
### Return Value  
 The modified bitset with the bits shifted to the left the required number of positions.  
  
### Remarks  
 The member operator function returns                         **bitset**(                        **\*this**)                         **<<= pos,** where                         [<<=](#bitset__operator_lt__lt__eq) shifts the bits in a bitset to the left a specified number of positions and returns the result to the targeted bitset.  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="bitset__operator_lt__lt__eq">\</a>  bitset::operator&lt;&lt;=  
 Shifts the bits in a bitset to the left a specified number of positions and returns the result to the targeted bitset.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 The number of positions to the left the bits in the bitset are to be shifted.  
  
### Return Value  
 The targeted bitset modified so that the bits have been shifted to the left the required number of positions.  
  
### Remarks  
 If no element exists to shift into the position, the function clears the bit to a value of 0.  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  **The target bitset b1 is: ( 00111 ).**  
**After shifting the bits 2 positions to the left,**  
 **the target bitset b1 becomes: ( 11100 ).**    
##  \<a name="bitset__operator_eq_eq">\</a>  bitset::operator==  
 Tests a target bitset for equality with a specified bitset.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The bitset that is to be compared to the target bitset for equality.  
  
### Return Value  
 **true** if the bitsets are the same;                         **false** if they are different.  
  
### Remarks  
 Bitsets must be of the same size to be tested for equality by the member operator function.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  **Bitset b1 is the same as bitset b2.**  
**Bitset b1 is different from bitset b3.**    
##  \<a name="bitset__operator_gt__gt_">\</a>  bitset::operator&gt;&gt;  
 Shifts the bits in a bitset to the right a specified number of positions and returns the result to a new bitset.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The number of positions to the right the bits in the bitset are to be shifted.  
  
### Return Value  
 A new bitset where the bits have been shifted to the right the required number of positions relative to the targeted bitset.  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  **The bitset b1 is: ( 00111 ).**  
**After shifting the bits 2 positions to the left,**  
 **the bitset b2 is: ( 11100 ).**  
**After shifting the bits 1 position to the right,**  
 **the bitset b3 is: ( 01110 ).**    
##  \<a name="bitset__operator_gt__gt__eq">\</a>  bitset::operator&gt;&gt;=  
 Shifts the bits in a bitset to the right a specified number of positions and returns the result to the targeted bitset.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The number of positions to the right the bits in the bitset are to be shifted.  
  
### Return Value  
 The targeted bitset modified so that the bits have been shifted to the right the required number of positions.  
  
### Remarks  
 If no element exists to shift into the position, the function clears the bit to a value of 0.  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  **The target bitset b1 is: ( 11100 ).**  
**After shifting the bits 2 positions to the right,**  
 **the target bitset b1 becomes: ( 00111 ).**    
##  \<a name="bitset__operator_at">\</a>  bitset::operator[]  
 Returns a reference to a bit at a specified position in a bitset if the bitset is modifiable; otherwise, it returns the value of the bit at that position.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The position locating the bit within the bitset.  
  
### Remarks  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element outside the bounds of the bitset.  See                         [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
##  \<a name="bitset__operator_xor_eq">\</a>  bitset::operator^=  
 Performs a bitwise combination of bitsets with the exclusive                 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> operation.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The bitset that is to be combined bitwise with the target bitset.  
  
### Return Value  
 The modified target bitset that results from the bitwise exclusive                         <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> operation with the bitset specified as a parameter.  
  
### Remarks  
 Two bits combined by the exclusive                         **OR** operator return                         **true** if at least one, but not both, of the bits is                         **true**; otherwise, their combination returns                         **false**.  
  
 Bitsets must be of the same size to be combined bitwise with the exclusive                         <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> operator by the member operator function.  
  
### Example  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  **The target bitset b1 is:    ( 00111 ).**  
**The parameter bitset b2 is: ( 01011 ).**  
**After bitwise exclusive OR combination,**  
 **the target bitset b1 becomes:   ( 01100 ).**  
**The parameter bitset b2 remains: ( 01011 ).**    
##  \<a name="bitset__operator_or_eq">\</a>  bitset::operator&#124;=  
 Performs a bitwise combination of bitsets with the inclusive                 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> operation.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The bitset that is to be combined bitwise with the target bitset.  
  
### Return Value  
 The modified target bitset that results from the bitwise inclusive                         <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> operation with the bitset specified as a parameter.  
  
### Remarks  
 Two bits combined by the inclusive                         <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> operator return                         **true** if at least one of the bits is                         **true**; if both bits are                         **false**, their combination returns                         **false**.  
  
 Bitsets must be of the same size to be combined bitwise with the inclusive                         <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> operator by the member operator function.  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  **The target bitset b1 is:    ( 00111 ).**  
**The parameter bitset b2 is: ( 01011 ).**  
**After bitwise inclusive OR combination,**  
 **the target bitset b1 becomes:   ( 01111 ).**  
**The parameter bitset b2 remains: ( 01011 ).**    
##  \<a name="bitset__operator_dtor">\</a>  bitset::operator~  
 Toggles all the bits in a target bitset and returns the result.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 The bitset with all its bits toggled with respect to the targeted bitset.  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  **Bitset b1 is: ( 00111 ).**  
**Bitset b2 = ~b1 is: ( 11000 ).**  
**Bitset b3 = b1.flip( ) is: ( 11000 ).**    
##  \<a name="bitset__reference">\</a>  bitset::reference  
 A proxy class that provides references to bits contained in a bitset that is used to access and manipulate the individual bits as a helper class for the                 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> of class bitset.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 The value of the object of type                                 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> to be assigned to a bit in a bitset.  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 A reference of the form                                 *x [ i ]* to the bit at position                                 *i* in bitset                                 *x*.  
  
### Return Value  
 A reference to the bit in the bitset specified by the argument position for the first, second, and fifth member functions of class reference, and                         **true** or                         **false**, to reflect the value of the modified bit in the bitset for the third and fourth member functions of class reference.  
  
### Remarks  
 The class reference exists only as a helper class for the bitset                         <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>. The member class describes an object that can access an individual bit within a bitset. Let                         *b* be an object of type                         <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>,                         *x* and                         *y* objects of type                         **bitset\<***N***>**, and                         *i* and                         *j* valid positions within such an object. The notation                         *x [i]* references the bit at position                         *i* in bitset                         *x*. The member functions of class reference provide, in order, the following operations:  
  
|Operation|Definition|  
|---------------|----------------|  
|*x*[                                        *i*] =                                         *b*|Stores                                         <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> value                                         *b* at bit position                                         *i* in bitset                                         *x*.|  
|*x*[                                        *i*] =                                         *y*[                                        *j*]|Stores the value of the bit                                         *y*[                                        *j*] at bit position                                         *i* in bitset                                         *x*.|  
|*b* = ~                                        *x*[                                        *i*]|Stores the flipped value of the bit                                         *x*[                                        *i*] in                                         <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>Â                                         *b*.|  
|*b* =                                         *x*[                                        *i*]|Stores the value of the bit                                         *x*[                                        *i*] in                                         <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>Â                                         *b*.|  
|*x*[                                        *i*].                                        <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>( )|Stores the flipped value of the bit                                         *x*[                                        *i*] back at bit position                                         *i* in                                         *x*.|  
  
### Example  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  **The initialized bitset\<5> b1( 2 ) is: ( 00010 ).**  
**The initialized bitset\<5> b2( 6 ) is: ( 00110 ).**  
**The bitset\<5> b1 with the bit at position 0 set to 1 is: ( 00011 )**  
**The bitset\<5> b2 with the bit at position 4 set to the value**  
 **of the bit at position 0 of the bit in bitset\<5> b1 is: ( 10110 )**  
**The value of the object b = ~b2 [4] of type bool is false.**  
**The value of the object b = b2 [4] of type bool is true.**  
**Before flipping the value of the bit at position 4 in bitset b2,**  
 **it is ( 10110 ).**  
**After flipping the value of the bit at position 4 in bitset b2,**  
 **it becomes ( 00110 ).**  
**After a second toggle, the value of the position 4 bit in b2 is now: 1.**    
##  \<a name="bitset__reset">\</a>  bitset::reset  
 Resets all the bits in a bitset to 0 or resets a bit at a specified position to 0.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The position of the bit in the bitset to be reset to 0.  
  
### Return Value  
 A copy of the bitset for which the member function was invoked.  
  
### Remarks  
 The second member function throws an                         [out_of_range](../vs140/out_of_range-class.md) exception if the position specified is greater than the size of the bitset.  
  
### Example  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  **The set of bits in bitset\<5> b1(13) is: ( 01101 )**  
**The collecion of bits obtained from resetting the**  
 **third bit of bitset b1 is: ( 01001 )**  
**The collecion of bits obtained from resetting all**  
 **the elements of the bitset b1 is: ( 00000 )**    
##  \<a name="bitset__set">\</a>  bitset::set  
 Sets all the bits in a bitset to 1 or sets a bit at a specified position to 1.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 The position of the bit in the bitset to be set to assigned a value.  
  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 The value to be assigned to the bit at the position specified.  
  
### Return Value  
 A copy of the bitset for which the member function was invoked.  
  
### Remarks  
 The second member function throws an                         [out_of_range](../vs140/out_of_range-class.md) exception if the position specified is greater than the size of the bitset.  
  
### Example  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  **The set of bits in bitset\<5> b1(6) is: ( 00110 )**  
**The collecion of bits obtained from setting the**  
 **zeroth bit of bitset b1 is: ( 00111 )**  
**The collecion of bits obtained from setting all the**  
 **elements of the bitset b1 is: ( 11111 )**    
##  \<a name="bitset__size">\</a>  bitset::size  
 Returns the number of bits in a bitset object.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 The number of bits,                         *N*, in a                         **bitset\<***N***>**.  
  
### Example  
  The following example demonstrates the use of the bitset::size member function.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  **The set of bits in bitset\<5> b1( 6 ) is: ( 00110 )**  
**The number of bits in bitset b1 is: 5.**    
##  \<a name="bitset__test">\</a>  bitset::test  
 Tests whether the bit at a specified position in a bitset is set to 1.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 The position of the bit in the bitset to be tested for its value.  
  
### Return Value  
 **true** if the bit specified by the argument position is set to 1; otherwise,                         **false**.  
  
### Remarks  
 The member function throws an                         [out_of_range](../vs140/out_of_range-class.md) exception that is the size of the bitset is less than or equal to the position specified in the argument.  
  
### Example  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  **Original bitset b1(6) is: ( 00110 )**  
**Note: positions in a bitset are numbered**  
 **from the right starting with 0.**  
**The bit at position 3 of bitset b1 has a value of 0.**  
**Bitset b1 modified by b1[3] = 1 is: ( 01110 )**  
**The bit at position 3 of bitset b1 has a value of 1.**    
##  \<a name="bitset__to_string">\</a>  bitset::to_string  
 Converts a bitset object to a string representation.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Return Value  
 A string object of class basic_string, where each bit set in the bitset has a corresponding character of 1, and a character of 0 if the bit is unset.  
  
### Example  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  **The ordered set of bits in the bitset\<5> b1( 7 )**  
 **that was generated by the number 7 is: ( 00111 )**  
**The string returned from the bitset b1**  
 **by the member function to_string( ) is: 00111.**    
##  \<a name="bitset__to_ullong">\</a>  bitset::to_ullong  
 Returns an unsigned long long value that contains the same bits set as the contents of the bitset object.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
  
### Remarks  
 Returns the sum of the bit values in the bit sequence as an unsigned long long.  
  
##  \<a name="bitset__to_ulong">\</a>  bitset::to_ulong  
 Converts a bitset object to the integer that would generate the sequence of bits contained if used to initialize the bitset.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Return Value  
 An integer that would generate the bits in a bitset if used in the initialization of the bitset.  
  
### Remarks  
 Applying the member function would return the integer that has the same sequence of 1 and 0 digits as is found in sequence of bits contained in the bitset.  
  
 The member function throws                         <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> if any bit in the bit sequence has a bit value that cannot be represented as a value of type                         <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>*.*  
  
### Example  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  **The ordered set of bits in the bitset\<5> b1( 7 )**  
 **that was generated by the number 7 is: ( 00111 )**  
**The integer returned from the bitset b1,**  
 **by the member function to_long( ), that**  
 **generated the bits as a base two number is: 7.**