---
title: "Storage-Class Specifiers with Function Declarations"
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
  - "function specifiers, storage class"
  - "declaring functions, specifiers"
  - "external declarations"
  - "specifiers, function"
  - "external linkage, function declarations"
  - "external linkage, storage-class specifiers"
ms.assetid: 801d7df2-efa9-4924-a725-274a5654cfd4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Storage-Class Specifiers with Function Declarations
You can use either the **static** or the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> storage-class specifier in function declarations. Functions always have global lifetimes.  
  
 **Microsoft Specific**  
  
 Function declarations at the internal level have the same meaning as function declarations at the external level. This means that a function is visible from its point of declaration throughout the rest of the translation unit even if it is declared at local scope.  
  
 **END Microsoft Specific**  
  
 The visibility rules for functions vary slightly from the rules for variables, as follows:  
  
-   A function declared to be **static** is visible only within the source file in which it is defined. Functions in the same source file can call the **static** function, but functions in other source files cannot access it directly by name. You can declare another **static** function with the same name in a different source file without conflict.  
  
-   Functions declared as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> are visible throughout all source files in the program (unless you later redeclare such a function as **static**). Any function can call an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function.  
  
-   Function declarations that omit the storage-class specifier are <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> by default.  
  
 **Microsoft Specific**  
  
 Microsoft allows redefinition of an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> identifier as **static**.  
  
 **END Microsoft Specific**  
  
## See Also  
 [C Storage Classes](../vs140/c-storage-classes.md)