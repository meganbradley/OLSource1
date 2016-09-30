---
title: "Return Type"
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
  - "function return types"
  - "return values [C++], function procedures"
  - "function return types, syntax"
  - "return values [C++]"
  - "data types [C++], function return types"
  - "return keyword [C++], function return types"
  - "functions [C++], return types"
ms.assetid: 3e5b8a97-b341-48c5-8be8-8986980ef586
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Return Type
The return type of a function establishes the size and type of the value returned by the function and corresponds to the type-specifier in the syntax below:  
  
## Syntax  
 *function-definition*:  
 *declaration-specifiers* opt*attribute-seq* opt*declarator declaration-list* opt*compound-statement*  
  
 /\* *attribute-seq* is Microsoft Specific */  
  
 *declaration-specifiers*:  
 *storage-class-specifier declaration-specifiers* opt  
  
 *type-specifier declaration-specifiers* opt  
  
 *type-qualifier declaration-specifiers* opt  
  
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
  
 The *type-specifier* can specify any fundamental, structure, or union type. If you do not include *type-specifier*, the return type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is assumed.  
  
 The return type given in the function definition must match the return type in declarations of the function elsewhere in the program. A function returns a value when a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement containing an expression is executed. The expression is evaluated, converted to the return value type if necessary, and returned to the point at which the function was called. If a function is declared with return type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, a return statement containing an expression generates a warning and the expression is not evaluated.  
  
 The following examples illustrate function return values.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example defines the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> type with a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> declaration and defines the function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to have <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> return type. The function selects and returns one of its two structure arguments. In subsequent calls to the function, the compiler checks to make sure the argument types are <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Efficiency would be enhanced by passing pointers to the structure, rather than the entire structure.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example defines a function returning a pointer to an array of characters. The function takes two character arrays (strings) as arguments and returns a pointer to the shorter of the two strings. A pointer to an array points to the first of the array elements and has its type; thus, the return type of the function is a pointer to type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 You need not declare functions with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> return type before you call them, although prototypes are recommended so that correct type checking for arguments and return values is enabled.  
  
## See Also  
 [C Function Definitions](../vs140/c-function-definitions.md)