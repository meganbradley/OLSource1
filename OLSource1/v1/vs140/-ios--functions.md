---
title: "&lt;ios&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1382d53f-e531-4b41-adf6-6a1543512e51
caps.latest.revision: 10
---
# &lt;ios&gt; functions
||||  
|-|-|-|  
|[&lt;ios&gt; defaultfloat](#ios_defaultfloat)|[boolalpha](#boolalpha)|[dec](#dec)|  
|[fixed](#fixed)|[hex](#hex)|[internal](#internal)|  
|[left](#left)|[noboolalpha](#noboolalpha)|[noshowbase](#noshowbase)|  
|[noshowpoint](#noshowpoint)|[noshowpos](#noshowpos)|[noskipws](#noskipws)|  
|[nounitbuf](#nounitbuf)|[nouppercase](#nouppercase)|[oct](#oct)|  
|[right](#right)|[scientific](#scientific)|[showbase](#showbase)|  
|[showpoint](#showpoint)|[showpos](#showpos)|[skipws](#skipws)|  
|[unitbuf](#unitbuf)|[uppercase](#uppercase)|  
  
##  \<a name="boolalpha">\</a>  boolalpha  
 Specifies that variables of type [bool](../vs140/bool--c---.md) appear as **true** or **false** in the stream.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 By default, variables of type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> are displayed as 1 or 0.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> effectively calls <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>[setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
 [noboolalpha](../vs140/-ios--functions.md#noboolalpha) reverses the effect of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **1**  
**true**  
**1**  
**true**    
##  \<a name="dec">\</a>  dec  
 Specifies that integer variables appear in base 10 notation.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 By default, integer variables are displayed in base 10.  
  
 **dec** effectively calls <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>[setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>**, ios_base::basefield**), and then returns <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **100**  
**64**  
**100**  
**144**  
**100**    
##  \<a name="ios_defaultfloat">\</a>  &lt;ios&gt; defaultfloat  
 Configures the flags of an <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object to use a default display format for float values.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The manipulator effectively calls _I <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base-class.md#ios_base__unsetf)<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, then returns _I <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
##  \<a name="fixed">\</a>  fixed  
 Specifies that a floating-point number is displayed in fixed-decimal notation.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 **fixed** is the default display notation for floating-point numbers. [scientific](../vs140/-ios--functions.md#scientific) causes floating-point numbers to be displayed using scientific notation.  
  
 The manipulator effectively calls  *_Str.*[setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>,  **ios_base::floatfield**), and then returns <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **1.1**  
**1.100000e+000**  
**1.1**    
##  \<a name="hex">\</a>  hex  
 Specifies that integer variables shall appear in base 16 notation.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 By default, integer variables are displayed in base 10 notation. [dec](../vs140/-ios--functions.md#dec) and [oct](../vs140/-ios--functions.md#oct) also change the way integer variables appear.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>**.**[setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>,  **ios_base::basefield**), and then returns <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
### Example  
  See [dec](../vs140/-ios--functions.md#dec) for an example of how to use **hex**.  
  
##  \<a name="internal">\</a>  internal  
 Causes a number's sign to be left justified and the number to be right justified.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is derived.  
  
### Remarks  
 [showpos](../vs140/-ios--functions.md#showpos) causes the sign to display for positive numbers.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>. [setf](../vs140/ios_base-class.md#ios_base__setf)( [ios_base::internal](../vs140/ios_base-class.md#ios_base__fmtflags), [ios_base::adjustfield](../vs140/ios_base-class.md#ios_base__fmtflags)), and then returns <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **..-123.456**  
**-..123.456**    
##  \<a name="left">\</a>  left  
 Causes text that is not as wide as the output width to appear in the stream flush with the left margin.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 The manipulator effectively calls <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>[setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>,  **ios_base::adjustfield**), and then returns <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
   **5**  
**5**    
##  \<a name="noboolalpha">\</a>  noboolalpha  
 Specifies that variables of type [bool](../vs140/bool--c---.md) appear as 1 or 0 in the stream.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 By default, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> is in effect.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> effectively calls <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base-class.md#ios_base__unsetf)( <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
 [boolalpha](../vs140/-ios--functions.md#boolalpha) reverses the effect of <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
### Example  
  See [boolalpha](../vs140/-ios--functions.md#boolalpha) for an example of using <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
##  \<a name="noshowbase">\</a>  noshowbase  
 Turns off indicating the notational base in which a number is displayed.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> is on by default. Use [showbase](../vs140/-ios--functions.md#showbase) to indicate the notational base of numbers.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base-class.md#ios_base__unsetf)( <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
### Example  
  See [showbase](../vs140/-ios--functions.md#showbase) for an example of how to use <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
##  \<a name="noshowpoint">\</a>  noshowpoint  
 Displays only the whole-number part of floating-point numbers whose fractional part is zero.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is on by default; use [showpoint](../vs140/-ios--functions.md#showpoint) and [precision](../vs140/ios_base-class.md#ios_base__precision) to display zeros after the decimal point.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base-class.md#ios_base__unsetf)( <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **5**  
**5.000**  
**5**    
##  \<a name="noshowpos">\</a>  noshowpos  
 Causes positive numbers to not be explicitly signed.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is on by default.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base-class.md#ios_base__unsetf)( <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>), then returns <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
### Example  
  See [showpos](../vs140/-ios--functions.md#showpos) for an example of using <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
##  \<a name="noskipws">\</a>  noskipws  
 Cause spaces to be read by the input stream.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 By default, [skipws](../vs140/-ios--functions.md#skipws) is in effect. When a space is read in the input stream, it signals the end of the buffer.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base-class.md#ios_base__unsetf)( <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
##  \<a name="nounitbuf">\</a>  nounitbuf  
 Causes output to be buffered and processed on when the buffer is full.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 [unitbuf](../vs140/-ios--functions.md#unitbuf) causes the buffer to be processed when it is not empty.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base-class.md#ios_base__unsetf)( <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.  
  
##  \<a name="nouppercase">\</a>  nouppercase  
 Specifies that hexadecimal digits and the exponent in scientific notation appear in lowercase.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 The manipulator effectively calls <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base-class.md#ios_base__unsetf)( <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
### Example  
  See [uppercase](../vs140/-ios--functions.md#uppercase) for an example of using <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.  
  
##  \<a name="oct">\</a>  oct  
 Specifies that integer variables appear in base 8 notation.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 By default, integer variables are displayed in base 10 notation. [dec](../vs140/-ios--functions.md#dec) and [hex](../vs140/-ios--functions.md#hex) also change the way integer variables appear.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>[setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
### Example  
  See [dec](../vs140/-ios--functions.md#dec) for an example of how to use **oct**.  
  
##  \<a name="right">\</a>  right  
 Causes text that is not as wide as the output width to appear in the stream flush with the right margin.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 [left](../vs140/-ios--functions.md#left) also modifies the justification of text.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>[setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  **5**  
 **5**  
**5**   
**5**   
 **5**  
 **5**    
##  \<a name="scientific">\</a>  scientific  
 Causes floating-point numbers to be displayed using scientific notation.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 By default, [fixed](../vs140/-ios--functions.md#fixed) notation is in effect for floating-point numbers.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>[setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  **100.23**  
**1.002300e+002**    
##  \<a name="showbase">\</a>  showbase  
 Indicates the notational base in which a number is displayed.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 The notational base of a number can be changed with [dec](../vs140/-ios--functions.md#dec), [oct](../vs140/-ios--functions.md#oct), or [hex](../vs140/-ios--functions.md#hex).  
  
 The manipulator effectively calls <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>[setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  **100**  
**0x64**  
**0144**  
**100**  
**64**  
**144**    
##  \<a name="showpoint">\</a>  showpoint  
 Displays the whole-number part of a floating-point number and digits to the right of the decimal point even when the fractional part is zero.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 By default, [noshowpoint](../vs140/-ios--functions.md#noshowpoint) is in effect.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>[setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>.  
  
### Example  
  See [noshowpoint](../vs140/-ios--functions.md#noshowpoint) for an example of using <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.  
  
##  \<a name="showpos">\</a>  showpos  
 Causes positive numbers to be explicitly signed.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 [noshowpos](../vs140/-ios--functions.md#noshowpos) is the default.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>[setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **1**  
**+1**    
##  \<a name="skipws">\</a>  skipws  
 Cause spaces to not be read by the input stream.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which _                        *Str* is derived.  
  
### Remarks  
 By default, <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> is in effect. [noskipws](../vs140/-ios--functions.md#noskipws) will cause spaces to be read from the input stream.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>[setf](../vs140/ios_base-class.md#ios_base__setf)( <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>159\</CodeContentPlaceHolder> <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.1.**  
**.2.**  
**.3.**    
##  \<a name="unitbuf">\</a>  unitbuf  
 Causes output to be processed when the buffer is not empty.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> is derived.  
  
### Remarks  
 Note that <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> also flushes the buffer.  
  
 [nounitbuf](../vs140/-ios--functions.md#nounitbuf) is in effect by default.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>[setf](../vs140/ios_base-class.md#ios_base__setf)( [ios_base::unitbuf](../vs140/ios_base-class.md#ios_base__fmtflags)), and then returns <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
##  \<a name="uppercase">\</a>  uppercase  
 Specifies that hexadecimal digits and the exponent in scientific notation appear in uppercase.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>.  
  
### Return Value  
 A reference to the object from which <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> is derived.  
  
### Remarks  
 By default, [nouppercase](../vs140/-ios--functions.md#nouppercase) is in effect.  
  
 The manipulator effectively calls <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>[setf](../vs140/ios_base-class.md#ios_base__setf)( [ios_base::uppercase](../vs140/ios_base-class.md#ios_base__fmtflags)), and then returns <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  **1.23e+100**  
**1.23E+100**  
**a**  
**A**    
## See Also  
 [&lt;ios&gt;](../vs140/-ios-.md)