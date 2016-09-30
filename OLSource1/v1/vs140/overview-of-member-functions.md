---
title: "Overview of Member Functions"
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
  - "this pointer, and nonstatic member functions"
  - "nonstatic member functions"
  - "inline functions, treating member functions as"
  - "member functions, definition in class declaration"
ms.assetid: 9f77a438-500e-40bb-a6c6-544678f3f4c8
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overview of Member Functions
Member functions are either static or nonstatic. The behavior of static member functions differs from other member functions because static member functions have no implicit **this** argument. Nonstatic member functions have a **this** pointer. Member functions, whether static or nonstatic, can be defined either in or outside the class declaration.  
  
 If a member function is defined inside a class declaration, it is treated as an inline function, and there is no need to qualify the function name with its class name. Although functions defined inside class declarations are already treated as inline functions, you can use the **inline** keyword to document code.  
  
 An example of declaring a function within a class declaration follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If a member function's definition is outside the class declaration, it is treated as an inline function only if it is explicitly declared as **inline**. In addition, the function name in the definition must be qualified with its class name using the scope-resolution operator (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
 The following example is identical to the previous declaration of class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, except that the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function is defined outside the class declaration:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
> [!NOTE]
>  Although member functions can be defined either inside a class declaration or separately, no member functions can be added to a class after the class is defined.  
  
 Classes containing member functions can have many declarations, but the member functions themselves must have only one definition in a program. Multiple definitions cause an error message at link time. If a class contains inline function definitions, the function definitions must be identical to observe this "one definition" rule.  
  
## See Also  
 [Member Functions](../vs140/member-functions--c---.md)