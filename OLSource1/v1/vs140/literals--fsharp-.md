---
title: "Literals (F#)"
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
  - "int64 [F#]"
  - "unativeint [F#]"
  - "strings [F#], triple-quoted"
  - "literals [F#]"
  - "uint16 [F#]"
  - "byte [F#]"
  - "int16 [F#]"
  - "strings [F#], verbatim"
  - "float [F#]"
  - "nativeint [F#]"
  - "sbyte [F#]"
  - "literals, F#"
  - "float32 [F#]"
  - "verbatim strings [F#]"
  - "bignum [F#]"
  - "bigint [F#]"
  - "Unicode, literals [F#]"
  - "uint64 [F#]"
  - "triple-quoted strings [F#]"
  - "decimal [F#]"
ms.assetid: 365643cc-3047-425c-870a-61f5975393de
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Literals (F#)
This topic provides a table that shows how to specify the type of a literal in F#.  
  
## Literal Types  
 The following table shows the literal types in F#. Characters that represent digits in hexadecimal notation are not case-sensitive; characters that identify the type are case-sensitive.  
  
|Type|Description|Suffix or prefix|Examples|  
|----------|-----------------|----------------------|--------------|  
|sbyte|signed 8-bit integer|y|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|byte|unsigned 8-bit natural number|uy|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|int16|signed 16-bit integer|s|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|uint16|unsigned 16-bit natural number|us|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|int\<br />\<br /> int32|signed 32-bit integer|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or none|86\<br />\<br /> 86l|  
|uint\<br />\<br /> uint32|unsigned 32-bit natural number|u or ul|86u\<br />\<br /> 86ul|  
|unativeint|native pointer as an unsigned natural number|un|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|int64|signed 64-bit integer|L|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|uint64|unsigned 64-bit natural number|UL|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|single, float32|32-bit floating point number|F or f|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|||lf|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|float; double|64-bit floating point number|none|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|||LF|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|bigint|integer not limited to 64-bit representation|I|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|decimal|fractional number represented as a fixed point or rational number|M or m|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|Char|Unicode character|none|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|String|Unicode string|none|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>\<br />\<br /> or\<br />\<br /> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>\<br />\<br /> or\<br />\<br /> <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>\<br />\<br /> or\<br />\<br /> <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>\<br />\<br /> See also [Strings (F#)](../vs140/strings--fsharp-.md).|  
|byte|ASCII character|B|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|byte[]|ASCII string|B|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|String or byte[]|verbatim string|@ prefix|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> (Unicode)\<br />\<br /> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> (ASCII)|  
  
## Remarks  
 Unicode strings can contain explicit encodings that you can specify by using <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> followed by a 16-bit hexadecimal code or UTF-32 encodings that you can specify by using <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> followed by a 32-bit hexadecimal code that represents a Unicode surrogate pair.  
  
 As of F# 3.1, you can use the + sign to combine string literals. You can also use the bitwise or (&#124;&#124;&#124;) operator to combine enum flags. For example, the following code is legal in F# 3.1:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The use of other bitwise operators isn't allowed.  
  
## Named Literals  
 Values that are intended to be constants can be marked with the [Literal](../vs140/core.literalattribute-class--fsharp-.md) attribute. This attribute has the effect of causing a value to be compiled as a constant.  
  
 In pattern matching expressions, identifiers that begin with lowercase characters are always treated as variables to be bound, rather than as literals, so you should generally use initial capitals when you define literals.  
  
## See Also  
 [F# Language Reference](../vs140/literals--fsharp-.md)   
 [Literal Attribute](../vs140/core.literalattribute-class--fsharp-.md)