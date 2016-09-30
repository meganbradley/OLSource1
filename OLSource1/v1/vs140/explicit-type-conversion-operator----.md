---
title: "Explicit Type Conversion Operator: ()"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "explicit data type conversion operator"
  - "conversions [C++], explicit"
  - "operators [C++], explicit type conversion"
  - "data type conversion [C++], explicit"
  - "type conversion [C++], explicit conversions"
ms.assetid: 54272006-5ffb-45ed-8283-27152ab97529
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Explicit Type Conversion Operator: ()
C++ allows explicit type conversion using syntax similar to the function-call syntax.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A *simple-type-name* followed by an *expression-list* enclosed in parentheses constructs an object of the specified type using the specified expressions. The following example shows an explicit type conversion to type int:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following example uses a modified version of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class defined in [Function-Call Results](../vs140/function-call-results.md).  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Although the preceding example demonstrates explicit type conversion using constants, the same technique works to perform these conversions on objects. The following code fragment demonstrates this:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Explicit type conversions can also be specified using the "cast" syntax. The previous example, rewritten using the cast syntax, is:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Both cast and function-style conversions have the same results when converting from single values. However, in the function-style syntax, you can specify more than one argument for conversion. This difference is important for user-defined types. Consider a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class and its conversions:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The preceding example, which uses function-style conversion, shows how to convert two values (one for *x* and one for *y*) to the user-defined type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
> [!CAUTION]
>  Use the explicit type conversions with care, since they override the C++ compiler's built-in type checking.  
  
 The [cast](../vs140/cast-operator----.md) notation must be used for conversions to types that do not have a *simple-type-name* (pointer or reference types, for example). Conversion to types that can be expressed with a *simple-type-name* can be written in either form. See [Type Specifiers](assetId:///34b6c737-0ef1-4470-9b77-b26e46c0bbd4) for more information about what constitutes a *simple-type-name*.  
  
 Type definition within casts is illegal.  
  
## See Also  
 [Postfix Expressions](../vs140/postfix-expressions.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)