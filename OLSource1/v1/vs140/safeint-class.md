---
title: "SafeInt Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "SafeInt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SafeInt class"
ms.assetid: 27a8f087-2511-46f9-8d76-2aeb66ca272f
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SafeInt Class
Extends the integer primitives to help prevent integer overflow and lets you compare different types of integers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Template|Description|  
|--------------|-----------------|  
|T|The type of integer or Boolean parameter that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> replaces.|  
|E|An enumerated data type that defines the error handling policy.|  
|U|The type of integer or Boolean parameter for the secondary operand.|  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] rhs|An input parameter that represents the value on the right side of the operator in several stand-alone functions.|  
|[in] i|An input parameter that represents the value on the right side of the operator in several stand-alone functions.|  
|[in] bits|An input parameter that represents the value on the right side of the operator in several stand-alone functions.|  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[SafeInt::SafeInt](../vs140/safeint--safeint.md)|Default constructor.|  
  
### Assignment Operators  
  
|Name|Syntax|  
|----------|------------|  
|=|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|=|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|=|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|=|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
  
### Casting Operators  
  
|Name|Syntax|  
|----------|------------|  
|bool|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|char|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|signed char|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|unsigned char|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|__int16|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|unsigned __int16|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|__int32|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|unsigned __int32|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|long|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|unsigned long|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|__int64|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|unsigned __int64|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|wchar_t|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
  
### Comparison Operators  
  
|Name|Syntax|  
|----------|------------|  
|<|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|>=|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|>=|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|<=|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|<=|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|==|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|==|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
|==|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|!=|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|  
|!=|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
|!=|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
  
### Arithmetic Operators  
  
|Name|Syntax|  
|----------|------------|  
|+|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|  
|-|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
|++|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
|--|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
|%|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
|%|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|  
|%=|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
|%=|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|  
|*|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|  
|*|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|  
|*=|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|  
|*=|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|  
|*=|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
|/|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|  
|/|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|  
|/=|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|  
|/=|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|  
|/=|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|  
|+|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|  
|+|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|  
|+=|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|  
|+=|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|  
|+=|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|  
|-|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|  
|-|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|  
|-=|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|  
|-=|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|  
|-=|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|  
  
### Logical Operators  
  
|Name|Syntax|  
|----------|------------|  
|!|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|  
|~|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|  
|<<|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|  
|<<|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|  
|<<=|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|  
|<<=|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|  
|>>|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|  
|>>|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|  
|>>=|<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|  
|>>=|<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>|  
|&|<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>|  
|&|<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>|  
|&=|<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>|  
|&=|<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>|  
|&=|<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>|  
|^|<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>|  
|^|<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>|  
|^=|<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>|  
|^=|<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>|  
|^=|<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>|  
|&#124;|<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>|  
|&#124;|<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>|  
|&#124;=|<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>|  
|&#124;=|<CodeContentPlaceHolder>125\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>|  
|&#124;=|<CodeContentPlaceHolder>127\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>|  
  
## Remarks  
 The <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> class protects against integer overflow in mathematical operations. For example, consider adding two 8-bit integers: one has a value of 200 and the second has a value of 100. The correct mathematical operation would be 200 + 100 = 300. However, because of the 8-bit integer limit, the upper bit will be lost and the compiler will return 44 (300 - 2<sup>8\</sup>) as the result. Any operation that depends on this mathematical equation will generate unexpected behavior.  
  
 The <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> class checks whether an arithmetic overflow occurs or whether the code tries to divide by zero. In both cases, the class calls the error handler to warn the program of the potential problem.  
  
 This class also lets you compare two different types of integers as long as they are <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> objects. Typically, when you perform a comparison, you must first convert the numbers to be the same type. Casting one number to another type often requires checks to make sure that there is no loss of data.  
  
 The Operators table in this topic lists the mathematical and comparison operators supported by the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> class. Most mathematical operators return a <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> object of type <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
 Comparison operations between a <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> and an integral type can be performed in either direction. For example, both <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> are valid and will return the same result.  
  
 Many binary operators do not support using two different <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> types. One example of this is the <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> operator. <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> is supported, but <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> is not. In the latter example, the compiler does not know what type of parameter to return. One solution to this problem is to cast the second parameter back to the base type. By using the same parameters, this can be done with <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  For any bitwise operations, the two different parameters should be the same size. If the sizes differ, the compiler will throw an [ASSERT (MFC)](../vs140/assert--mfc-.md) exception. The results of this operation cannot be guaranteed to be accurate. To resolve this issue, cast the smaller parameter until it is the same size as the larger parameter.  
  
 For the shift operators, shifting more bits than exist for the template type will throw an ASSERT exception. This will have no effect in release mode. Mixing two types of SafeInt parameters is possible for the shift operators because the return type is the same as the original type. The number on the right side of the operator only indicates the number of bits to shift.  
  
 When you perform a logical comparison with a SafeInt object, the comparison is strictly arithmetic. For example, consider these expressions:  
  
-   <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
  
 The first statement resolves to <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>, but the second statement resolves to <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>. The bitwise negation of 0 is 0xFFFFFFFF. In the second statement, the default comparison operator compares 0xFFFFFFFF to 0xFFFFFFFF and considers them to be equal. The comparison operator for the <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> class realizes that the second parameter is negative whereas the first parameter is unsigned. Therefore, although the bit representation is identical, the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> logical operator realizes that the unsigned integer is larger than -1.  
  
 Be careful when you use the <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> class together with the <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> ternary operator. Consider the following line of code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The compiler converts it to this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>, the compiler throws an exception instead of assigning the value of -1 to <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>. Therefore, to avoid this behavior, the correct code to use is the following line.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> can be assigned a Boolean type, character type, or integer type. The integer types can be signed or unsigned and any size from 8 bits to 64 bits.  
  
> [!NOTE]
>  Although the <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> class accepts any kind of integer, it performs more efficiently with unsigned types.  
  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> is the error handling mechanism that <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> uses. Two error handling mechanisms are provided with the SafeInt library. The default policy is <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>, which throws a [SafeIntException Class](../vs140/safeintexception-class.md) exception when an error occurs. The other policy is <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>, which stops the program if an error occurs.  
  
 There are two options to customize the error policy. The first option is to set the parameter <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> when you create a <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>. Use this option when you want to change the error handling policy for just one <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>. The other option is to define <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> to be your customized error-handling class before you include the <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> library. Use this option when you want to change the default error handling policy for all instances of the <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> class in your code.  
  
> [!NOTE]
>  A customized class that handles errors from the SafeInt library should not return control to the code that called the error handler. After the error handler is called, the result of the <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> operation cannot be trusted.  
  
## Requirements  
 **Header:** safeint.h  
  
 **Namespace:** msl::utilities  
  
## See Also  
 [Miscellaneous Support Libraries Classes](assetId:///406fd46e-d53f-4096-ab40-36aa754c7a5c)   
 [The SafeInt Library](../vs140/safeint-library.md)   
 [SafeIntException Class](../vs140/safeintexception-class.md)