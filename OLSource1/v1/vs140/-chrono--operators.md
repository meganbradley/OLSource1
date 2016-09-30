---
title: "&lt;chrono&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c5a19267-4684-40c1-b7a9-cc1012b058f3
caps.latest.revision: 11
---
# &lt;chrono&gt; operators
||||  
|-|-|-|  
|[operator modulo](#operator_modulo)|[operator!=](#operator_neq)|[operator&gt;](#operator_gt_)|  
|[operator&gt;=](#operator_gt__eq)|[operator&lt;](#operator_lt_)|[operator&lt;=](#operator_lt__eq)|  
|[operator*](#operator_star)|[operator+](#operator_add)|[operator-](#operator-)|  
|[operator/](#operator_)|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator-">\</a>  operator-  
 Operator for subtraction or negation of [duration](../vs140/duration-class.md) and [time_point](../vs140/time_point-class.md) objects.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The first function returns a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object whose interval length is the difference between the time intervals of the two arguments.  
  
 The second function returns a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object that represents a point in time that is displaced, by the negation of the time interval that is represented by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, from the point in time that is specified by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 The third function returns a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object that represents the time interval between <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Inequality operator for [duration](../vs140/duration-class.md) or [time_point](../vs140/time_point-class.md) objects.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Each function returns <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_star">\</a>  operator*  
 Multiplication operator for [duration](../vs140/-chrono--operators.md#operator_star) objects.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 An integral value.  
  
### Return Value  
 Each function returns a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object whose interval length is <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> multiplied by the length of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 Unless <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>*holds true*, the first function does not participate in overload resolution. For more information, sssee [\<type_traits>](../vs140/-type_traits-.md).  
  
 Unless <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>*holds true*, the second function does not participate in overload resolution. For more information, see [\<type_traits>](../vs140/-type_traits-.md).  
  
##  \<a name="operator_">\</a>  operator/  
 Division operator for [duration](../vs140/-chrono--operators.md#operator_star) objects.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 An integral value.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The first operator returns a duration object whose interval length is the length of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> divided by the value <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 The second operator returns the ratio of the interval lengths of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
 Unless <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>*holds true*, and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is not an instantiation of <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, the first operator does not participate in overload resolution. For more information, see [\<type_traits>](../vs140/-type_traits-.md).  
  
##  \<a name="operator_add">\</a>  operator+  
 Adds [duration](../vs140/duration-class.md) and [time_point](../vs140/time_point-class.md) objects.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The first function returns a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object that has a time interval that is equal to the sum of the intervals of <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
 The second and third functions return a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object that represents a point in time that is displaced, by the interval <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, from the point in time <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Determines whether one [duration](../vs140/duration-class.md) or [time_point](../vs140/time_point-class.md) object is less than another <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The first function returns <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> if the interval length of <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is less than the interval length of <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>. Otherwise, the function returns <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
 The second function returns <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> precedes <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>. Otherwise, the function returns <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Determines whether one [duration](../vs140/duration-class.md) or [time_point](../vs140/time_point-class.md) object is less than or equal to another <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Each function returns <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_eq_eq">\</a>  operator==  
 Determines whether two <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> objects represent time intervals that have the same length, or whether two <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> objects represent the same point in time.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The first function returns <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> represent time intervals that have the same length. Otherwise, the function returns <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
 The second function returns <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> represent the same point in time. Otherwise, the function returns <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Determines whether one [duration](../vs140/duration-class.md) or [time_point](../vs140/time_point-class.md) object is greater than another <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Each function returns <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Determines whether one [duration](../vs140/duration-class.md) or [time_point](../vs140/time_point-class.md) object is greater than or equal to another <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Each function returns <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
##  \<a name="operator_modulo">\</a>  operator modulo  
 Operator for modulo operations on [duration](../vs140/duration-class.md) objects.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 An integral value.  
  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The first function returns a <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object whose interval length is <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> modulo <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
 The second function returns a value that represents <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> modulo <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
## See Also  
 [&lt;chrono&gt;](../vs140/-chrono-.md)