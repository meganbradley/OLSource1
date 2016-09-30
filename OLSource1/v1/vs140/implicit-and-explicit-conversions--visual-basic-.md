---
title: "Implicit and Explicit Conversions (Visual Basic)"
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
  - "conversions, type"
  - "variables [Visual Basic], changing data type"
  - "casting"
  - "conversions, data type"
  - "type conversion, implicit conversions"
  - "CType function, conversions"
  - "casting, data types"
  - "data type conversion, explicit"
  - "type conversion, explicit conversions"
  - "data types [Visual Basic], casting"
  - "conversions, implicit"
  - "explicit data type conversions"
  - "conversions"
  - "changing data types"
  - "conversions, explicit"
  - "data type conversion, implicit"
  - "implicit data type conversions"
ms.assetid: 77de1659-af8a-492c-967e-e7ef60ccce66
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implicit and Explicit Conversions (Visual Basic)
An *implicit conversion* does not require any special syntax in the source code. In the following example, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] implicitly converts the value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to a single-precision floating-point value before assigning it to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 An *explicit conversion* uses a type conversion keyword. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] provides several such keywords, which coerce an expression in parentheses to the desired data type. These keywords act like functions, but the compiler generates the code inline, so execution is slightly faster than with a function call.  
  
 In the following extension of the preceding example, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword converts the value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> back to an integer before assigning it to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Conversion Keywords  
 The following table shows the available conversion keywords.  
  
||||  
|-|-|-|  
|Type conversion keyword|Converts an expression to data type|Allowable data types of expression to be converted|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|[Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md)|Any numeric type (including <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and enumerated types), <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|[Byte Data Type (Visual Basic)](../vs140/byte-data-type--visual-basic-.md)|Any numeric type (including <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and enumerated types), <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|[Char Data Type (Visual Basic)](../vs140/char-data-type--visual-basic-.md)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|[Date Data Type (Visual Basic)](../vs140/date-data-type--visual-basic-.md)|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|[Double Data Type (Visual Basic)](../vs140/double-data-type--visual-basic-.md)|Any numeric type (including <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and enumerated types), <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|[Decimal Data Type (Visual Basic)](../vs140/decimal-data-type--visual-basic-.md)|Any numeric type (including <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, and enumerated types), <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|[Integer Data Type (Visual Basic)](../vs140/integer-data-type--visual-basic-.md)|Any numeric type (including <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, and enumerated types), <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|[Long Data Type (Visual Basic)](../vs140/long-data-type--visual-basic-.md)|Any numeric type (including <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, and enumerated types), <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|[Object Data Type](../vs140/object-data-type.md)|Any type|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|[SByte Data Type (Visual Basic)](../vs140/sbyte-data-type--visual-basic-.md)|Any numeric type (including <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and enumerated types), <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|[Short Data Type (Visual Basic)](../vs140/short-data-type--visual-basic-.md)|Any numeric type (including <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, and enumerated types), <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|[Single Data Type (Visual Basic)](../vs140/single-data-type--visual-basic-.md)|Any numeric type (including <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, and enumerated types), <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|[String Data Type (Visual Basic)](../vs140/string-data-type--visual-basic-.md)|Any numeric type (including <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, and enumerated types), <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> array, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|Type specified following the comma (<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>)|When converting to an *elementary data type* (including an array of an elementary type), the same types as allowed for the corresponding conversion keyword\<br />\<br /> When converting to a *composite data type*, the interfaces it implements and the classes from which it inherits\<br />\<br /> When converting to a class or structure on which you have overloaded <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, that class or structure|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|[UInteger Data Type](../vs140/uinteger-data-type.md)|Any numeric type (including <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, and enumerated types), <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|[ULong Data Type (Visual Basic)](../vs140/ulong-data-type--visual-basic-.md)|Any numeric type (including <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, and enumerated types), <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|[UShort Data Type (Visual Basic)](../vs140/ushort-data-type--visual-basic-.md)|Any numeric type (including <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, and enumerated types), <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|  
  
## The CType Function  
 The [CType Function](../vs140/ctype-function--visual-basic-.md) operates on two arguments. The first is the expression to be converted, and the second is the destination data type or object class. Note that the first argument must be an expression, not a type.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is an *inline function*, meaning the compiled code makes the conversion, often without generating a function call. This improves performance.  
  
 For a comparison of <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> with the other type conversion keywords, see [DirectCast](../vs140/directcast-operator--visual-basic-.md) and [TryCast](../vs140/trycast-operator--visual-basic-.md).  
  
### Elementary Types  
 The following example demonstrates the use of <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Composite Types  
 You can use <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> to convert values to composite data types as well as to elementary types. You can also use it to coerce an object class to the type of one of its interfaces, as in the following example.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Array Types  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> can also convert array data types, as in the following example.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 For more information and an example, see [Array Conversions](../vs140/array-conversions--visual-basic-.md).  
  
### Types Defining CType  
 You can define <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> on a class or structure you have defined. This allows you to convert values to and from the type of your class or structure. For more information and an example, see [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md).  
  
> [!NOTE]
>  Values used with a conversion keyword must be valid for the destination data type, or an error occurs. For example, if you attempt to convert a <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> to an <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, the value of the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> must be within the valid range for the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> data type.  
  
> [!CAUTION]
>  Specifying <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> to convert from one class type to another fails at run time if the source type does not derive from the destination type. Such a failure throws an \<xref:System.InvalidCastException*> exception.  
  
 However, if one of the types is a structure or class you have defined, and if you have defined <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> on that structure or class, a conversion can succeed if it satisfies the requirements of your <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>. See [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md).  
  
 Performing an explicit conversion is also known as *casting* an expression to a given data type or object class.  
  
## See Also  
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)   
 [Conversions Between Strings and Other Types](../vs140/conversions-between-strings-and-other-types--visual-basic-.md)   
 [How to: Convert an Object to Another Type in Visual Basic](../vs140/how-to--convert-an-object-to-another-type-in-visual-basic.md)   
 [Structures](../vs140/structures--visual-basic-.md)   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md)