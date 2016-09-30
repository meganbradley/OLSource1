---
title: "C Type Specifiers"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "type specifiers, C"
  - "specifiers, type"
ms.assetid: fbe13441-04c3-4829-b047-06d374adc2b6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C Type Specifiers
Type specifiers in declarations define the type of a variable or function declaration.  
  
## Syntax  
 *type-specifier*:  
 **void**  
  
 **char**  
  
 **short**  
  
 **int**  
  
 **long**  
  
 **float**  
  
 **double**  
  
 **signed**  
  
 **unsigned**  
  
 *struct-or-union-specifier*  
  
 *enum-specifier*  
  
 *typedef-name*  
  
 The **signed char**, **signed int**, **signed short int**, and **signed long int** types, together with their <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> counterparts and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, are called "integral" types. The **float**, **double**, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> type specifiers are referred to as "floating" or "floating-point" types. You can use any integral or floating-point type specifier in a variable or function declaration. If a *type-specifier* is not provided in a declaration, it is taken to be <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The optional keywords **signed** and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can precede or follow any of the integral types, except <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and can also be used alone as type specifiers, in which case they are understood as **signed int** and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, respectively. When used alone, the keyword <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is assumed to be **signed**. When used alone, the keywords **long** and **short** are understood as **long int** and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 Enumeration types are considered basic types. Type specifiers for enumeration types are discussed in [Enumeration Declarations](../vs140/c-enumeration-declarations.md).  
  
 The keyword <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> has three uses: to specify a function return type, to specify an argument-type list for a function that takes no arguments, and to specify a pointer to an unspecified type. You can use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> type to declare functions that return no value or to declare a pointer to an unspecified type. See [Arguments](../vs140/arguments.md) for information on <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> when it appears alone within the parentheses following a function name.  
  
 **Microsoft Specific**  
  
 Type checking is now ANSI-compliant, which means that type **short** and type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are distinct types. For example, this is a redefinition in the Microsoft C compiler that was accepted by previous versions of the compiler.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This next example also generates a warning about indirection to different types:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The Microsoft C compiler also generates warnings for differences in sign. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> expressions are evaluated for side effects. You cannot use the (nonexistent) value of an expression that has type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> in any way, nor can you convert a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> expression (by implicit or explicit conversion) to any type except <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If you do use an expression of any other type in a context where a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> expression is required, its value is discarded.  
  
 To conform to the ANSI specification, **void\*\*** cannot be used as **int\*\***. Only **void\*** can be used as a pointer to an unspecified type.  
  
 **END Microsoft Specific**  
  
 You can create additional type specifiers with <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> declarations, as described in [Typedef Declarations](../vs140/typedef-declarations.md). See [Storage of Basic Types](../vs140/storage-of-basic-types.md) for information on the size of each type.  
  
## See Also  
 [Declarations and Types](../vs140/declarations-and-types.md)