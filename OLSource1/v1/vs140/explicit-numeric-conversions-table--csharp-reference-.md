---
title: "Explicit Numeric Conversions Table (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "conversions [C#], explicit numeric"
  - "numeric conversions [C#], explicit"
  - "explicit numeric conversion [C#]"
  - "numeric data types [C#]"
  - "types [C#], explicit numeric conversions"
  - "type conversion [C#], explicit numeric"
ms.assetid: f3bb9e76-6b92-4df7-bc36-f866c24e1dfd
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Explicit Numeric Conversions Table (C# Reference)
Explicit numeric conversion is used to convert any numeric type to any other numeric type, for which there is no implicit conversion, by using a cast expression. The following table shows these conversions.  
  
 For more information about conversions, see [Casting and Type Conversions (C# Programming Guide)](../vs140/casting-and-type-conversions--csharp-programming-guide-.md).  
  
|From|To|  
|----------|--------|  
|[sbyte](../vs140/sbyte--csharp-reference-.md)|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|[byte](../vs140/byte--csharp-reference-.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|[short](../vs140/short--csharp-reference-.md)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|[ushort](../vs140/ushort--csharp-reference-.md)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|[int](../vs140/int--csharp-reference-.md)|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>,or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
|[uint](../vs140/uint--csharp-reference-.md)|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|[long](../vs140/long--csharp-reference-.md)|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|[ulong](../vs140/ulong--csharp-reference-.md)|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
|[char](../vs140/char--csharp-reference-.md)|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
|[float](../vs140/float--csharp-reference-.md)|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>,or <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|  
|[double](../vs140/double--csharp-reference-.md)|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>,or <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|  
|[decimal](../vs140/decimal--csharp-reference-.md)|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|  
  
## Remarks  
  
-   The explicit numeric conversion may cause loss of precision or result in throwing exceptions.  
  
-   When you convert a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> value to an integral type, this value is rounded towards zero to the nearest integral value. If the resulting integral value is outside the range of the destination type, an \<xref:System.OverflowException*> is thrown.  
  
-   When you convert from a <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> value to an integral type, the value is truncated. If the resulting integral value is outside the range of the destination value, the result depends on the overflow checking context. In a checked context, an <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is thrown, while in an unchecked context, the result is an unspecified value of the destination type.  
  
-   When you convert <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> value is rounded to the nearest <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> value. If the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> value is too small or too large to fit into the destination type, the result will be zero or infinity.  
  
-   When you convert <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, the source value is converted to <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> representation and rounded to the nearest number after the 28th decimal place if required. Depending on the value of the source value, one of the following results may occur:  
  
    -   If the source value is too small to be represented as a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>, the result becomes zero.  
  
    -   If the source value is NaN (not a number), infinity, or too large to be represented as a <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, an <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is thrown.  
  
-   When you convert <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> value is rounded to the nearest <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> value.  
  
 For more information on explicit conversion, see Explicit in the C# Language Specification. For more information on how to access the spec, see [C# Language Specification Link Page](../vs140/csharp-language-specification.md).  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Casting and Type Conversions (C# Programming Guide)](../vs140/casting-and-type-conversions--csharp-programming-guide-.md)   
 [() Operator (C# Reference)](../vs140/---operator--csharp-reference-.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)