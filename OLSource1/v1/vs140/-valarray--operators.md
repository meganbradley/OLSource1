---
title: "&lt;valarray&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 8a53562c-90ab-4eb3-85d3-ada5259d90b0
caps.latest.revision: 11
---
# &lt;valarray&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator%](#operator_mod)|[operator&amp;](#operator_amp_)|  
|[operator&amp;&amp;](#operator_amp__amp_)|[operator&gt;](#operator_gt_)|[operator&gt;&gt;](#operator_gt__gt_)|  
|[operator&gt;=](#operator_gt__eq)|[operator&lt;](#operator_lt_)|[operator&lt;&lt;](#operator_lt__lt_)|  
|[operator&lt;=](#operator_lt__eq)|[operator*](#operator_star)|[operator+](#operator_add)|  
|[operator-](#operator-)|[operator/](#operator_)|[operator==](#operator_eq_eq)|  
|[operator^](#operator_xor)|[operator&#124;](#operator_or)|[operator&#124;&#124;](#operator_lor)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Tests whether the corresponding elements of two equally sized valarrays are unequal or whether all the elements of a valarray are unequal a specified value.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The first of the two valarrays whose elements are to be tested for inequality.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The second of the two valarrays whose elements are to be tested for inequality.  
  
### Return Value  
 A valarray of Boolean values, each of which is:  
  
-   **true** if the corresponding elements are unequal.  
  
-   **false** if the corresponding elements are not unequal.  
  
### Remarks  
 The first template operator returns an object of class [valarray\<bool>](../vs140/valarray-bool--class.md), each of whose elements <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>[ <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>] != <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>[ <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>].  
  
 The second template operator stores in element                         *I _Left*[ <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>] != _                        *Right*.  
  
 The third template operator stores in element                         *I _Left* != <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>[ <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>].  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="operator_mod">\</a>  operator%  
 Obtains the remainder of dividing the corresponding elements of two equally sized valarrays or of dividing a valarray by a specified value or of dividing a specified value by a valarray.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A value or valarray that serves as the dividend into which another value or valarray is to be divided.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A value or valarray that serves as the divisor and that divides another value or valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise remainders of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> divided by <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="operator_amp_">\</a>  operator&amp;  
 Obtains the bitwise **AND** between corresponding elements of two equally sized valarrays or between a valarray and a specified value of the element type.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The first of the two valarrays whose respective elements are to be combined with the bitwise **AND** or a specified value of the element type to be combined bitwise with each element of a valarray.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The second of the two valarrays whose respective elements are to be combined with the bitwise **AND** or a specified value of the element type to be combined bitwise with each element of a valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise combination of the bitwise AND operation of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  
### Remarks  
 A bitwise operation can only be used to manipulate bits in <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> data types and variants and not on **float**, **double**, **longdouble**, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> or other, more complex data types.  
  
 The bitwise **AND** has the same truth table as the logical **AND** but applies to the data type on the level of the individual bits. The [operator&&](../vs140/-valarray--operators.md#operator_amp__amp_) applies on an element level, counting all nonzero values as true, and the result is a valarray of Boolean values. The bitwise **ANDoperator&**, by contrast, can result in a valarray of values other than 0 or 1, depending on outcome of the bitwise operation.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="operator_amp__amp_">\</a>  operator&amp;&amp;  
 Obtains the logical **AND** between corresponding elements of two equally sized valarrays or between a valarray and a specified value of the valarray's element type.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The first of the two valarrays whose respective elements are to be combined with the logical **AND** or a specified value of the element type to be combined with each element of a valarray.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The second of the two valarrays whose respective elements are to be combined with the logical **AND** or a specified value of the element type to be combined with each element of a valarray.  
  
### Return Value  
 A valarray whose elements are of type bool and are the element-wise combination of the logical **AND** operation of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  
### Remarks  
 The logical **ANDoperator&&** applies on an element level, counting all nonzero values as true, and the result is a valarray of Boolean values. The bitwise version of **AND**, [operator&,](../vs140/-valarray--operators.md#operator_amp_), by contrast, can result in a valarray of values other than 0 or 1, depending on the outcome of the bitwise operation.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Tests whether the elements of one valarray are greater than the elements of an equally sized valarray or whether all the elements of a valarray are greater or less than a specified value.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The first of the two valarrays whose elements are to be compared or a specified value to be compared with each element of a valarray.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The second of the two valarrays whose elements are to be compared or a specified value to be compared with each element of a valarray.  
  
### Return Value  
 A valarray of Boolean values, each of which is:  
  
-   **true** if the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> element or value is greater than the corresponding <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> element or value.  
  
-   **false** if the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> element or value is not greater than the corresponding <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> element or value.  
  
### Remarks  
 If the number of elements in two valarrays is not equal, the result is undefined.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Tests whether the elements of one valarray are greater than or equal to the elements of an equally sized valarray or whether all the elements of a valarray are greater than or equal to or less than or equal to a specified value.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The first of the two valarrays whose elements are to be compared or a specified value to be compared with each element of a valarray.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The second of the two valarrays whose elements are to be compared or a specified value to be compared with each element of a valarray.  
  
### Return Value  
 A valarray of Boolean values, each of which is:  
  
-   **true** if the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> element or value is greater than or equal to the corresponding <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> element or value.  
  
-   **false** if the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> element or value is less than the corresponding <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> element or value.  
  
### Remarks  
 If the number of elements in two valarrays is not equal, the result is undefined.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="operator_gt__gt_">\</a>  operator&gt;&gt;  
 Right-shifts the bits for each element of a valarray a specified number of positions or by an element-wise amount specified by a second valarray.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The value to be shifted or the valarray whose elements are to be shifted.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The value indicating the amount of right shift or valarray whose elements indicate the element-wise amount of right shift.  
  
### Return Value  
 A valarray whose elements have been shifted right by the specified amount.  
  
### Remarks  
 Signed numbers have their signs preserved.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Tests whether the elements of one valarray are less than the elements of an equally sized valarray or whether all the elements of a valarray are greater or less than a specified value.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The first of the two valarrays whose elements are to be compared or a specified value to be compared with each element of a valarray.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The second of the two valarrays whose elements are to be compared or a specified value to be compared with each element of a valarray.  
  
### Return Value  
 A valarray of Boolean values, each of which is:  
  
-   **true** if the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> element or value is less than the corresponding <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> element or value.  
  
-   **false** if the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> element or value is not less than the corresponding <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> element or value.  
  
### Remarks  
 If the number of elements two valarrays is not equal, the result is undefined.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Tests whether the elements of one valarray are less than or equal to the elements of an equally sized valarray or whether all the elements of a valarray are greater than or equal to or less than or equal to a specified value.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The first of the two valarrays whose elements are to be compared or a specified value to be compared with each element of a valarray.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The second of the two valarrays whose elements are to be compared or a specified value to be compared with each element of a valarray.  
  
### Return Value  
 A valarray of Boolean values, each of which is:  
  
-   **true** if the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> element or value is less than or equal to the corresponding <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> element or value.  
  
-   **false** if the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> element or value is greater than the corresponding <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> element or value.  
  
### Remarks  
 If the number of elements two valarrays is not equal, the result is undefined.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="operator_lt__lt_">\</a>  operator&lt;&lt;  
 Left shifts the bits for each element of a valarray a specified number of positions or by an element-wise amount specified by a second valarray.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The value to be shifted or the valarray whose elements are to be shifted.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The value indicating the amount of left shift or valarray whose elements indicate the element-wise amount of left shift.  
  
### Return Value  
 A valarray whose elements have been shifted left by the specified amount.  
  
### Remarks  
 Signed numbers have their signs preserved.  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="operator_star">\</a>  operator*  
 Obtains the element-wise product between corresponding elements of two equally sized valarrays or of between a valarray a specified value.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The first of the two valarrays whose elements are to be multiplied or a specified value to be multiplied with each element of a valarray.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The second of the two valarrays whose elements are to be multiplied or a specified value to be multiplied with each element of a valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise product of <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="operator_add">\</a>  operator+  
 Obtains the element-wise sum between corresponding elements of two equally sized valarrays or of between a valarray a specified value.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The first of the two valarrays whose elements are to be added or a specified value to be added with each element of a valarray.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 The second of the two valarrays whose elements are to be added or a specified value to be added with each element of a valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise sum of <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
##  \<a name="operator-">\</a>  operator-  
 Obtains the element-wise difference between corresponding elements of two equally sized valarrays or of between a valarray a specified value.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 A value or valarray that serves as the minuend from which other values or valarrays are to be subtracted in forming the difference.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 A value or valarray that serves as the subtrahend that is to be subtracted from other values or valarrays in forming the difference.  
  
### Return Value  
 A valarray whose elements are the element-wise difference of <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
  
### Remarks  
 The arithmetic terminology used in describing a subtraction:  
  
 difference = minuend - subtrahend  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
##  \<a name="operator_">\</a>  operator/  
 Obtains the element-wise quotient between corresponding elements of two equally sized valarrays or of between a valarray a specified value.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 A value or valarray that serves as the dividend into which another value or valarray is to be divided in forming the quotient.  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 A value or valarray that serves as the divisor and that divides another value or valarray in forming the quotient.  
  
### Return Value  
 A valarray whose elements are the element-wise quotient of <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> divided by <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  
### Remarks  
 The arithmetic terminology used in describing a division:  
  
 quotient = dividend / divisor  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests whether the corresponding elements of two equally sized valarrays are equal or whether all the elements of a valarray are equal a specified value.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The first of the two valarrays whose elements are to be tested for equality.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 The second of the two valarrays whose elements are to be tested for equality.  
  
### Return Value  
 A valarray of Boolean values, each of which is:  
  
-   **true** if the corresponding elements are equal.  
  
-   **false** if the corresponding elements are not equal.  
  
### Remarks  
 The first template operator returns an object of class [valarray\<bool>](../vs140/valarray-bool--class.md), each of whose elements <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> is _                        *Left*[ <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>] == \_                        *Right*[ <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>]. The second template operator stores in element <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>[ <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>] == \_                        *Right*. The third template operator stores in element <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>[ <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>].  
  
### Example  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
##  \<a name="operator_xor">\</a>  operator^  
 Obtains the bitwise exclusive <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> ( **XOR**) between corresponding elements of two equally sized valarrays or between a valarray and a specified value of the element type.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 The first of the two valarrays whose respective elements are to be combined with the bitwise **XOR** or a specified value of the element type to be combined bitwise with each element of a valarray.  
  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The second of the two valarrays whose respective elements are to be combined with the bitwise **XOR** or a specified value of the element type to be combined bitwise with each element of a valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise combination of the bitwise **XOR** operation of <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
  
### Remarks  
 A bitwise operation can only be used to manipulate bits in <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> data types and variants and not on **float**, **double**, <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> or other, more complex data types.  
  
 The bitwise exclusive <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> ( **XOR**) has the following semantics: Given bits                         *b*1 and                         *b*2,                         *b*1 **XOR** *b*2 is **true** if exactly one of the bits is true; **false** if both bits are false or if both bits are true.  
  
### Example  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
##  \<a name="operator_or">\</a>  operator&#124;  
 Obtains the bitwise <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> between corresponding elements of two equally sized valarrays or between a valarray and a specified value of the element type.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The first of the two valarrays whose respective elements are to be combined with the bitwise <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> or a specified value of the element type to be combined bitwise with each element of a valarray.  
  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 The second of the two valarrays whose respective elements are to be combined with the bitwise <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> or a specified value of the element type to be combined bitwise with each element of a valarray.  
  
### Return Value  
 A valarray whose elements are the element-wise combination of the bitwise <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> operation of <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
  
### Remarks  
 A bitwise operation can only be used to manipulate bits in <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> data types and variants and not on **float**, **double**, **longdouble**, <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> or other, more complex data types.  
  
 The bitwise OR has the same truth table as the logical <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>, but applies to the data type on the level of the individual bits. Given bits                         *b*1 and                         *b*2,                         *b*1 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> *b*2 is **true** if at least one of the bits is true or **false** if both bits are false. The logical <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>[operator&#124;&#124;](../vs140/-valarray--operators.md#operator_lor) applies on an element level, counting all nonzero values as **true**, and the result is a valarray of Boolean values. The bitwise OR <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, by contrast, can result in a valarray of values other than 0 or 1, depending on the outcome of the bitwise operation.  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
##  \<a name="operator_lor">\</a>  operator&#124;&#124;  
 Obtains the logical <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> between corresponding elements of two equally sized valarrays or between a valarray and a specified value of the valarray element type.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 The first of the two valarrays whose respective elements are to be combined with the logical <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> or a specified value of the element type to be combined with each element of a valarray.  
  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 The second of the two valarrays whose respective elements are to be combined with the logical <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> or a specified value of the element type to be combined with each element of a valarray.  
  
### Return Value  
 A valarray whose elements are of type <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> and are the element-wise combination of the logical OR operation of <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
  
### Remarks  
 The logical <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> applies on an element level, counting all nonzero values as **true**, and the result is a valarray of Boolean values. The bitwise version of <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>, [operator&#124;](../vs140/-valarray--operators.md#operator_or) by contrast, can result in a valarray of values other than 0 or 1, depending on outcome of the bitwise operation.  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
## See Also  
 [&lt;valarray&gt;](../vs140/-valarray-.md)