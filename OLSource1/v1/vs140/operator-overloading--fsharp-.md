---
title: "Operator Overloading (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "operators [F#], overloading"
  - "operators [F#], defining"
  - "overloading operators [F#]"
  - "operator overloading [F#]"
ms.assetid: 6217a7e4-863b-475a-9d79-b788cddfb6f9
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator Overloading (F#)
This topic describes how to overload arithmetic operators in a class or record type, and at the global level.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In the previous syntax, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is one of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and so on. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> specifies the operands in the order they appear in the usual syntax for that operator. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> constructs the resulting value.  
  
 Operator overloads for operators must be static. Operator overloads for unary operators, such as <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, must use a tilde (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to indicate that the operator is a unary operator and not a binary operator, as shown in the following declaration.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following code illustrates a vector class that has just two operators, one for unary minus and one for multiplication by a scalar. In the example, two overloads for scalar multiplication are needed because the operator must work regardless of the order in which the vector and scalar appear.  
  
 [!code[FsLangRef2#4001](../vs140/codesnippet/FSharp/operator-overloading--fsharp-_1.fs)]  
  
## Creating New Operators  
 You can overload all the standard operators, but you can also create new operators out of sequences of certain characters. Allowed operator characters are <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> character has the special meaning of making an operator unary, and is not part of the operator character sequence. Not all operators can be made unary, as is described in [Prefix and Infix Operators](#prefix) later in this topic.  
  
 Depending on the exact character sequence you use, your operator will have a certain precedence and associativity. Associativity can be either left to right or right to left and is used whenever operators of the same level of precedence appear in sequence without parentheses.  
  
 The operator character <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> does not affect precedence, so that, for example, if you want to define your own version of multiplication that has the same precedence and associativity as ordinary multiplication, you could create operators such as <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 A table that shows the precedence of all operators in F# can be found in [Symbol and Operator Reference](../vs140/symbol-and-operator-reference--fsharp-.md).  
  
## Overloaded Operator Names  
 When the F# compiler compiles an operator expression, it generates a method that has a compiler-generated name for that operator. This is the name that appears in the Microsoft intermediate language (MSIL) for the method, and also in reflection and IntelliSense. You do not normally need to use these names in F# code.  
  
 The following table shows the standard operators and their corresponding generated names.  
  
|Operator|Generated name|  
|--------------|--------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>|  
  
 Other combinations of operator characters that are not listed here can be used as operators and have names that are made up by concatenating names for the individual characters from the following table. For example, +! becomes <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
|Operator character|Name|  
|------------------------|----------|  
|<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>120\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>125\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>127\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>128\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>129\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>130\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>142\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>148\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>|  
  
##  \<a name="prefix">\</a> Prefix and Infix Operators  
 *Prefix* operators are expected to be placed in front of an operand or operands, much like a function. *Infix* operators are expected to be placed between the two operands.  
  
 Only certain operators can be used as prefix operators. Some operators are always prefix operators, others can be infix or prefix, and the rest are always infix operators. Operators that begin with <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>, except <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>, and the operator <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>, or repeated sequences of<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>, are always prefix operators. The operators <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> can be prefix operators or infix operators. You distinguish the prefix version of these operators from the infix version by adding a <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> at the beginning of a prefix operator when it is defined. The <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> is not used when you use the operator, only when it is defined.  
  
## Example  
 The following code illustrates the use of operator overloading to implement a fraction type. A fraction is represented by a numerator and a denominator. The function <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> is used to determine the highest common factor, which is used to reduce fractions.  
  
 [!code[FsLangRef2#4002](../vs140/codesnippet/FSharp/operator-overloading--fsharp-_2.fs)]  
  
 **// Output:**  
**3/4 + 1/2 = 5/4**  
**3/4 - 1/2 = 1/4**  
**3/4 \* 1/2 = 3/8**  
**3/4 / 1/2 = 3/2**  
**3/4 + 1 = 7/4**   
## Operators at the Global Level  
 You can also define operators at the global level. The following code defines an operator +?.  
  
 [!code[FsLangRef2#4003](../vs140/codesnippet/FSharp/operator-overloading--fsharp-_3.fs)]  
  
 The output of the above code is <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>.  
  
 You can redefine the regular arithmetic operators in this manner because the scoping rules for F# dictate that newly defined operators take precedence over the built-in operators.  
  
 The keyword <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> is often used with global operators, which are often small functions that are best integrated into the calling code. Making operator functions inline also enables them to work with statically resolved type parameters to produce statically resolved generic code. For more information, see [Inline Functions](../vs140/inline-functions--fsharp-.md) and [Statically Resolved Type Parameters](../vs140/statically-resolved-type-parameters--fsharp-.md).  
  
## See Also  
 [Members](../vs140/members--fsharp-.md)