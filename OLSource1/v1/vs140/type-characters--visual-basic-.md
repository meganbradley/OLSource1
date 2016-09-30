---
title: "Type Characters (Visual Basic)"
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
  - "&H prefix for hexadecimal values"
  - "hexadecimal literals"
  - "F literal type character"
  - "& identifier type character"
  - "type characters"
  - "octal literals"
  - "literals, hexadecimal"
  - "&O prefix for octal values"
  - "literals, default types"
  - "defaults, literal types"
  - "C literal type character"
  - "type characters, literal"
  - "$ identifier type character"
  - "L literal type character"
  - "UI literal type characters"
  - "default literal types"
  - "D literal type character"
  - "literals, octal"
  - "S literal type character"
  - "! identifier type character"
  - "US literal type characters"
  - "% identifier type character"
  - "data types [Visual Basic], type characters"
  - "characters, identifier type"
  - "type characters, identifier"
  - "# identifier type character"
  - "identifier type characters"
  - "literal type characters"
  - "I literal type character"
  - "R literal type character"
  - "@ identifier type character"
  - "UL literal type characters"
  - "literal types, default"
ms.assetid: 6353cb9b-6ee4-4af6-a5a8-88ce39f90cc5
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type Characters (Visual Basic)
In addition to specifying a data type in a declaration statement, you can force the data type of some programming elements with a *type character*. The type character must immediately follow the element, with no intervening characters of any kind.  
  
 The type character is not part of the name of the element. An element defined with a type character can be referenced without the type character.  
  
## Identifier Type Characters  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] supplies a set of *identifier type characters*, which you can use in a declaration to specify the data type of a variable or constant. The following table shows the available identifier type characters with examples of usage.  
  
|Identifier type character|Data type|Example|  
|-------------------------------|---------------|-------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
  
 No identifier type characters exist for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> data types, or for any composite data types such as arrays or structures.  
  
 In some cases, you can append the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> character to a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] function, for example <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, to obtain a returned value of type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 In all cases, the identifier type character must immediately follow the identifier name.  
  
## Literal Type Characters  
 A *literal* is a textual representation of a particular value of a data type.  
  
### Default Literal Types  
 The form of a literal as it appears in your code ordinarily determines its data type. The following table shows these default types.  
  
|Textual form of literal|Default data type|Example|  
|-----------------------------|-----------------------|-------------|  
|Numeric, no fractional part|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|Numeric, no fractional part, too large for <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|Numeric, fractional part|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|Enclosed in double quotation marks|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|  
|Enclosed within number signs|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
  
### Forced Literal Types  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] supplies a set of *literal type characters*, which you can use to force a literal to assume a data type other than the one its form indicates. You do this by appending the character to the end of the literal. The following table shows the available literal type characters with examples of usage.  
  
|Literal type character|Data type|Example|  
|----------------------------|---------------|-------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|  
  
 No literal type characters exist for the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> data types, or for any composite data types such as arrays or structures.  
  
 Literals can also use the identifier type characters (<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>), as can variables, constants, and expressions. However, the literal type characters (<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>) can be used only with literals.  
  
 In all cases, the literal type character must immediately follow the literal value.  
  
## Hexadecimal and Octal Literals  
 The compiler normally construes an integer literal to be in the decimal (base 10) number system. You can force an integer literal to be hexadecimal (base 16) with the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> prefix, and you can force it to be octal (base 8) with the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> prefix. The digits that follow the prefix must be appropriate for the number system. The following table illustrates this.  
  
|Number base|Prefix|Valid digit values|Example|  
|-----------------|------------|------------------------|-------------|  
|Hexadecimal (base 16)|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|0-9 and A-F|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|  
|Octal (base 8)|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|0-7|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|  
  
 You can follow a prefixed literal with a literal type character. The following example shows this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the previous example, <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> has the decimal value of -32768, and <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> has the decimal value of +32768.  
  
## See Also  
 [Data Types in Visual Basic](../vs140/data-types-in-visual-basic.md)   
 [Elementary Data Types](../vs140/elementary-data-types--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)   
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)   
 [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md)   
 [Variable Declaration in Visual Basic](../vs140/variable-declaration-in-visual-basic.md)   
 [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md)