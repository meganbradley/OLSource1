---
title: "Fundamental Types  (C++)"
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
  - "__wchar_t_cpp"
  - "long_double_cpp"
  - "unsigned"
  - "wchar_t_cpp"
  - "float_cpp"
  - "wchar_t"
  - "char"
  - "char_cpp"
  - "signed"
  - "__wchar_t"
  - "signed_cpp"
  - "short"
  - "double_cpp"
  - "int_cpp"
  - "long"
  - "__intn_cpp"
  - "short_cpp"
  - "double"
  - "unsigned_cpp"
  - "float"
  - "__intn"
  - "long_cpp"
  - "int"
  - "long_double"
  - "unsigned_int"
  - "__int8"
  - "__int8_cpp"
  - "__int16"
  - "__int16_cpp"
  - "__int32"
  - "__int32_cpp"
  - "__int64"
  - "__int64_cpp"
  - "__int128"
  - "__int128_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "specifiers [C++], type"
  - "float keyword [C++]"
  - "char keyword [C++]"
  - "__wchar_t keyword [C++]"
  - "signed types [C++], summary of data types"
  - "Integer data type, C++ data types"
  - "arithmetic operations [C++], types"
  - "int data type"
  - "unsigned types [C++], summary of data types"
  - "short data type"
  - "double data type, summary of types"
  - "long long keyword [C++]"
  - "long double keyword [C++]"
  - "unsigned types [C++]"
  - "signed types [C++]"
  - "void keyword [C++]"
  - "storage [C++], basic type"
  - "integral types, C++"
  - "wchar_t keyword [C++]"
  - "floating-point numbers, C++ data types"
  - "long keyword [C++]"
  - "type specifiers [C++]"
  - "integral types"
  - "long keyword [C++], C++ data types"
  - "storing types [C++]"
  - "data types [C++], void"
ms.assetid: 58b0106a-0406-4b74-a430-7cbd315c0f89
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fundamental Types  (C++)
Fundamental types in C++ are divided into three categories: integral, floating point, and void. Integral types are capable of handling whole numbers. Floating point types are capable of specifying values that may have fractional parts.  
  
 The [void](../vs140/void--c---.md) type describes an empty set of values. No variable of type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> can be specified — it is used primarily to declare functions that return no values or to declare generic pointers to untyped or arbitrarily typed data. Any expression can be explicitly converted or cast to type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. However, such expressions are restricted to the following uses:  
  
-   An expression statement. (See [Expressions](../vs140/expressions--c---.md), for more information.)  
  
-   The left operand of the comma operator. (See [Comma Operator](../vs140/comma-operator---.md) for more information.)  
  
-   The second or third operand of the conditional operator (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>). (See [Expressions with the Conditional Operator](../vs140/conditional-operator-----.md) for more information.)  
  
 The following table explains the restrictions on type sizes. These restrictions are independent of the Microsoft implementation.  
  
### Fundamental Types of the C++ Language  
  
|Category|Type|Contents|  
|--------------|----------|--------------|  
|Integral|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is an integral type that usually contains members of the basic execution character set — By default, this is ASCII in Microsoft C++.\<br />\<br /> The C++ compiler treats variables of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> as having different types. Variables of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are promoted to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> as if they are type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> by default, unless the /J compilation option is used. In this case they are treated as type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and are promoted to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> without sign extension.|  
||<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is an integral type that can have one of the two values <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Its size is unspecified.|  
||<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> (or simply <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>) is an integral type that is larger than or equal to the size of type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and shorter than or equal to the size of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.\<br />\<br /> Objects of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> can be declared as <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is a synonym for <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.|  
||<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Type <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is an integral type that is larger than or equal to the size of type <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, and shorter than or equal to the size of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.\<br />\<br /> Objects of type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> can be declared as <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is a synonym for <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.|  
||<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Sized integer <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is the size, in bits, of the integer variable. <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> are Microsoft-specific keywords. Not all types are available on all architectures. <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is not supported.)|  
||<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Type <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>) is an integral type that is larger than or equal to the size of type <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.\<br />\<br /> Objects of type <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> can be declared as <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is a synonym for <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.|  
||<CodeContentPlaceHolder>70\</CodeContentPlaceHolder> <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|Larger than an unsigned <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.\<br />\<br /> Objects of type <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> can be declared as <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> is a synonym for <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.|  
||<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|A variable of type <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> designates a wide-character or multibyte character type. By default, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is a native type, but you can use [/Zc:wchar_t-](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md) to make <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> a typedef for <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> type is a Microsoft-specific synonym for the native <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> type.\<br />\<br /> Use the L prefix before a character or string literal to designate the wide-character type.|  
|Floating point|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|Type <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> is the smallest floating point type.|  
||<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|Type <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is a floating point type that is larger than or equal to type <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, but shorter than or equal to the size of type <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.\<br />\<br /> Microsoft specific: The representation of <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is identical. However, <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> are separate types.|  
||<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|Type <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> is a floating point type that is larger than or equal to type <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.|  
  
 **Microsoft Specific**  
  
 The following table lists the amount of storage required for fundamental types in Microsoft C++.  
  
### Sizes of Fundamental Types  
  
|Type|Size|  
|----------|----------|  
|<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>|1 byte|  
|<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>|2 bytes|  
|<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>|4 bytes|  
|<CodeContentPlaceHolder>120\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>|8 bytes|  
  
 **END Microsoft Specific**  
  
 See [Data Type Ranges](../vs140/data-type-ranges.md) for a summary of the range of values of each type.  
  
 For more information about type conversion, see [Standard Conversions](../vs140/standard-conversions.md).  
  
## See Also  
 [Data Type Ranges](../vs140/data-type-ranges.md)