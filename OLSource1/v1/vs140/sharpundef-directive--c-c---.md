---
title: "#undef Directive (C-C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "#undef Directive (C/C++)"
f1_keywords: 
  - "#undef"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "#undef directive"
  - "undef directive (#undef)"
  - "preprocessor, directives"
ms.assetid: 88900e0e-2c19-4a63-b681-f3d3133c24ca
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #undef Directive (C-C++)
Removes (undefines) a name previously created with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directive removes the current definition of *identifier*. Consequently, subsequent occurrences of *identifier* are ignored by the preprocessor. To remove a macro definition using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, give only the macro *identifier* ; do not give a parameter list.  
  
 You can also apply the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directive to an identifier that has no previous definition. This ensures that the identifier is undefined. Macro replacement is not performed within <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statements.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> directive is typically paired with a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> directive to create a region in a source program in which an identifier has a special meaning. For example, a specific function of the source program can use manifest constants to define environment-specific values that do not affect the rest of the program. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directive also works with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> directive to control conditional compilation of the source program. See [The #if, #elif, #else, and #endif Directives](../vs140/sharpif--sharpelif--sharpelse--and-sharpendif-directives--c-c---.md) for more information.  
  
 In the following example, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directive removes definitions of a symbolic constant and a macro. Note that only the identifier of the macro is given.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Microsoft Specific**  
  
 Macros can be undefined from the command line using the /U option, followed by the macro names to be undefined. The effect of issuing this command is equivalent to a sequence of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> *macro-name* statements at the beginning of the file.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Preprocessor Directives](../vs140/preprocessor-directives.md)