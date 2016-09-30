---
title: "Variadic Macros"
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
  - "variadic macros [C++]"
  - "__VA_ARGS__ variadic macro specifier"
ms.assetid: 51e757dc-0134-4bb2-bb74-64ea5ad75134
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Variadic Macros
Variadic macros are function-like macros that contain a variable number of arguments.  
  
## Remarks  
 To use variadic macros, the ellipsis may be specified as the final formal argument in a macro definition, and the replacement identifier <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> may be used in the definition to insert the extra arguments.  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is replaced by all of the arguments that match the ellipsis, including commas between them.  
  
 The C Standard specifies that at least one argument must be passed to the ellipsis, to ensure that the macro does not resolve to an expression with a trailing comma.  The Visual C++ implementation will suppress a trailing comma if no arguments are passed to the ellipsis.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Macros (C/C++)](../vs140/macros--c-c---.md)