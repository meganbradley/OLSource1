---
title: "Simple Variable Declarations"
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
  - "untyped variables"
  - "declaring variables, simple"
ms.assetid: b07adf9d-9e79-4b64-8a34-e6fe1c7eccec
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Simple Variable Declarations
The declaration of a simple variable, the simplest form of a direct declarator, specifies the variable's name and type. It also specifies the variable's storage class and data type.  
  
 Storage classes or types (or both) are required on variable declarations. Untyped variables (such as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) generate warnings.  
  
## Syntax  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>:  
 *pointer* opt  
  
 *direct-declarator*  
  
 *direct-declarator*:  
 *identifier*  
  
 *identifier*:  
 *nondigit*  
  
 *identifier nondigit*  
  
 *identifier digit*  
  
 For arithmetic, structure, union, enumerations, and void types, and for types represented by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> names, simple declarators can be used in a declaration since the type specifier supplies all the typing information. Pointer, array, and function types require more complicated declarators.  
  
 You can use a list of identifiers separated by commas (**,**) to specify several variables in the same declaration. All variables defined in the declaration have the same base type. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The variables <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can hold any value in the set defined by the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> type for a particular implementation. The simple object <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is initialized to the value 1 and is not modifiable.  
  
 If the declaration of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> was for an uninitialized static variable or was at file scope, it would receive an initial value of 0, and that value would be unmodifiable.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this example, both the variables, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, have <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> type and hold unsigned integral values.  
  
## See Also  
 [Declarators and Variable Declarations](../vs140/declarators-and-variable-declarations.md)