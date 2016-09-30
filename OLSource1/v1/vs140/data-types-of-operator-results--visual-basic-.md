---
title: "Data Types of Operator Results (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "data types [Visual Basic], operator result data types"
  - "result data types"
  - "operator result data types"
  - "operators [Visual Basic], data types"
  - "data types [Visual Basic], ranges"
  - "operators [Visual Basic], result data types"
ms.assetid: 9d524533-e1a1-4aa8-b1b8-622068173d06
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data Types of Operator Results (Visual Basic)
[!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] determines the result data type of an operation based on the data types of the operands. In some cases this might be a data type with a greater range than that of either operand.  
  
## Data Type Ranges  
 The ranges of the relevant data types, in order from smallest to largest, are as follows:  
  
-   [Boolean](../vs140/boolean-data-type--visual-basic-.md) — two possible values  
  
-   [SByte](../vs140/sbyte-data-type--visual-basic-.md), [Byte](../vs140/byte-data-type--visual-basic-.md) — 256 possible integral values  
  
-   [Short](../vs140/short-data-type--visual-basic-.md), [UShort](../vs140/ushort-data-type--visual-basic-.md) — 65,536 (6.5...E+4) possible integral values  
  
-   [Integer](../vs140/integer-data-type--visual-basic-.md), [UInteger](../vs140/uinteger-data-type.md) — 4,294,967,296 (4.2...E+9) possible integral values  
  
-   [Long](../vs140/long-data-type--visual-basic-.md), [ULong](../vs140/ulong-data-type--visual-basic-.md) — 18,446,744,073,709,551,615 (1.8...E+19) possible integral values  
  
-   [Decimal](../vs140/decimal-data-type--visual-basic-.md) — 1.5...E+29 possible integral values, maximum range 7.9...E+28 (absolute value)  
  
-   [Single](../vs140/single-data-type--visual-basic-.md) — maximum range 3.4...E+38 (absolute value)  
  
-   [Double](../vs140/double-data-type--visual-basic-.md) — maximum range 1.7...E+308 (absolute value)  
  
 For more information on [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] data types, see [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md).  
  
 If an operand evaluates to [Nothing](../vs140/nothing--visual-basic-.md), the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] arithmetic operators treat it as zero.  
  
## Decimal Arithmetic  
 Note that the [Decimal](../vs140/decimal-data-type--visual-basic-.md) data type is neither floating-point nor integer.  
  
 If either operand of a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operation is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and the other is not <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] widens the other operand to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. It performs the operation in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and the result data type is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Floating-Point Arithmetic  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] performs most floating-point arithmetic in [Double](../vs140/double-data-type--visual-basic-.md), which is the most efficient data type for such operations. However, if one operand is [Single](../vs140/single-data-type--visual-basic-.md) and the other is not <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] performs the operation in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. It widens each operand as necessary to the appropriate data type before the operation, and the result has that data type.  
  
### / and ^ Operators  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator is defined only for the [Decimal](../vs140/decimal-data-type--visual-basic-.md), [Single](../vs140/single-data-type--visual-basic-.md), and [Double](../vs140/double-data-type--visual-basic-.md) data types. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] widens each operand as necessary to the appropriate data type before the operation, and the result has that data type.  
  
 The following table shows the result data types for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> operator. Note that this table is symmetric; for a given combination of operand data types, the result data type is the same regardless of the order of the operands.  
  
||||||  
|-|-|-|-|-|  
||<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Any integer type|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Decimal|Single|Double|Decimal|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Single|Single|Double|Single|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Double|Double|Double|Double|  
|Any integer type|Decimal|Single|Double|Double|  
  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> operator is defined only for the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> data type. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] widens each operand as necessary to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> before the operation, and the result data type is always <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
## Integer Arithmetic  
 The result data type of an integer operation depends on the data types of the operands. In general, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] uses the following policies for determining the result data type:  
  
-   If both operands of a binary operator have the same data type, the result has that data type. An exception is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, which is forced to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
-   If an unsigned operand participates with a signed operand, the result has a signed type with at least as large a range as either operand.  
  
-   Otherwise, the result usually has the larger of the two operand data types.  
  
 Note that the result data type might not be the same as either operand data type.  
  
> [!NOTE]
>  The result data type is not always large enough to hold all possible values resulting from the operation. An \<xref:System.OverflowException*> exception can occur if the value is too large for the result data type.  
  
### Unary + and – Operators  
 The following table shows the result data types for the two unary operators, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
|||||||||||  
|-|-|-|-|-|-|-|-|-|-|  
||<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|Unary <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Short|SByte|Byte|Short|UShort|Integer|UInteger|Long|ULong|  
|Unary <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Short|SByte|Short|Short|Integer|Integer|Long|Long|Decimal|  
  
### <\< and >> Operators  
 The following table shows the result data types for the two bit-shift operators, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] treats each bit-shift operator as a unary operator on its left operand (the bit pattern to be shifted).  
  
|||||||||||  
|-|-|-|-|-|-|-|-|-|-|  
||<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Short|SByte|Byte|Short|UShort|Integer|UInteger|Long|ULong|  
  
 If the left operand is <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] attempts to convert it to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> before the operation, and the result data type is <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. The right operand (the number of bit positions to shift) must be <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> or a type that widens to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
### Binary +, –, *, and Mod Operators  
 The following table shows the result data types for the binary <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> operators and the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> operators. Note that this table is symmetric; for a given combination of operand data types, the result data type is the same regardless of the order of the operands.  
  
|||||||||||  
|-|-|-|-|-|-|-|-|-|-|  
||<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|Short|SByte|Short|Short|Integer|Integer|Long|Long|Decimal|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|SByte|SByte|Short|Short|Integer|Integer|Long|Long|Decimal|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|Short|Short|Byte|Short|UShort|Integer|UInteger|Long|ULong|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|Short|Short|Short|Short|Integer|Integer|Long|Long|Decimal|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|Integer|Integer|UShort|Integer|UShort|Integer|UInteger|Long|ULong|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|Integer|Integer|Integer|Integer|Integer|Integer|Long|Long|Decimal|  
|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|Long|Long|UInteger|Long|UInteger|Long|UInteger|Long|ULong|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|Long|Long|Long|Long|Long|Long|Long|Long|Decimal|  
|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|Decimal|Decimal|ULong|Decimal|ULong|Decimal|ULong|Decimal|ULong|  
  
### \ Operator  
 The following table shows the result data types for the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> operator. Note that this table is symmetric; for a given combination of operand data types, the result data type is the same regardless of the order of the operands.  
  
|||||||||||  
|-|-|-|-|-|-|-|-|-|-|  
||<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|Short|SByte|Short|Short|Integer|Integer|Long|Long|Long|  
|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|SByte|SByte|Short|Short|Integer|Integer|Long|Long|Long|  
|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|Short|Short|Byte|Short|UShort|Integer|UInteger|Long|ULong|  
|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|Short|Short|Short|Short|Integer|Integer|Long|Long|Long|  
|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|Integer|Integer|UShort|Integer|UShort|Integer|UInteger|Long|ULong|  
|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|Integer|Integer|Integer|Integer|Integer|Integer|Long|Long|Long|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|Long|Long|UInteger|Long|UInteger|Long|UInteger|Long|ULong|  
|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|Long|Long|Long|Long|Long|Long|Long|Long|Long|  
|<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|Long|Long|ULong|Long|ULong|Long|ULong|Long|ULong|  
  
 If either operand of the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> operator is [Decimal](../vs140/decimal-data-type--visual-basic-.md), [Single](../vs140/single-data-type--visual-basic-.md), or [Double](../vs140/double-data-type--visual-basic-.md), [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] attempts to convert it to [Long](../vs140/long-data-type--visual-basic-.md) before the operation, and the result data type is <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
## Relational and Bitwise Comparisons  
 The result data type of a relational operation (<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>) is always <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>[](../vs140/boolean-data-type--visual-basic-.md "Boolean Data Type (Visual Basic)"). The same is true for logical operations (<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>) on <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> operands.  
  
 The result data type of a bitwise logical operation depends on the data types of the operands. Note that <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> are defined only for <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>, and [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] converts each operand as necessary to <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> before performing the operation.  
  
### =, <>, \<, >, \<=, and >= Operators  
 If both operands are <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] considers <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> to be less than <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>. If a numeric type is compared with a <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] attempts to convert the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> before the operation. A <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> operand can be compared only with another operand of the same data type. The result data type is always <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.  
  
### Bitwise Not Operator  
 The following table shows the result data types for the bitwise <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> operator.  
  
|||||||||||  
|-|-|-|-|-|-|-|-|-|-|  
||<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>|Boolean|SByte|Byte|Short|UShort|Integer|UInteger|Long|ULong|  
  
 If the operand is <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] attempts to convert it to <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> before the operation, and the result data type is <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.  
  
### Bitwise And, Or, and Xor Operators  
 The following table shows the result data types for the bitwise <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> operators. Note that this table is symmetric; for a given combination of operand data types, the result data type is the same regardless of the order of the operands.  
  
|||||||||||  
|-|-|-|-|-|-|-|-|-|-|  
||<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>152\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>156\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>157\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>158\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>159\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>|Boolean|SByte|Short|Short|Integer|Integer|Long|Long|Long|  
|<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>|SByte|SByte|Short|Short|Integer|Integer|Long|Long|Long|  
|<CodeContentPlaceHolder>162\</CodeContentPlaceHolder>|Short|Short|Byte|Short|UShort|Integer|UInteger|Long|ULong|  
|<CodeContentPlaceHolder>163\</CodeContentPlaceHolder>|Short|Short|Short|Short|Integer|Integer|Long|Long|Long|  
|<CodeContentPlaceHolder>164\</CodeContentPlaceHolder>|Integer|Integer|UShort|Integer|UShort|Integer|UInteger|Long|ULong|  
|<CodeContentPlaceHolder>165\</CodeContentPlaceHolder>|Integer|Integer|Integer|Integer|Integer|Integer|Long|Long|Long|  
|<CodeContentPlaceHolder>166\</CodeContentPlaceHolder>|Long|Long|UInteger|Long|UInteger|Long|UInteger|Long|ULong|  
|<CodeContentPlaceHolder>167\</CodeContentPlaceHolder>|Long|Long|Long|Long|Long|Long|Long|Long|Long|  
|<CodeContentPlaceHolder>168\</CodeContentPlaceHolder>|Long|Long|ULong|Long|ULong|Long|ULong|Long|ULong|  
  
 If an operand is <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] attempts to convert it to <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> before the operation, and the result data type is the same as if that operand had already been <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>.  
  
## Miscellaneous Operators  
 The <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> operator is defined only for concatenation of <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> operands. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] converts each operand as necessary to <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> before the operation, and the result data type is always <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>. For the purposes of the <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> operator, all conversions to <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> are considered to be widening, even if <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> operators require both operands to be of a reference type. The <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>186\</CodeContentPlaceHolder> expression requires the first operand to be of a reference type and the second operand to be the name of a data type. In all these cases the result data type is <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> operator is defined only for pattern matching of <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> operands. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] attempts to convert each operand as necessary to <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> before the operation. The result data type is always <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>.  
  
## See Also  
 [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md)   
 [Operators and Expressions in Visual Basic](../vs140/operators-and-expressions-in-visual-basic.md)   
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)   
 [Comparison Operators in Visual Basic](../vs140/comparison-operators-in-visual-basic.md)   
 [Operators (Visual Basic)](../vs140/operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Arithmetic Operators (Visual Basic)](../vs140/arithmetic-operators--visual-basic-.md)   
 [Comparison Operators (Visual Basic)](../vs140/comparison-operators--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)