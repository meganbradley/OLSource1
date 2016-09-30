---
title: "Consuming Generics (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "Consuming Generics (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "generics [C++], consuming from .NET languages"
ms.assetid: e6330ef5-e907-432e-b527-7a22f5899639
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Consuming Generics (C++-CLI)
Generics authored in one .NET language may be used in other .NET languages. Unlike templates, a generic in a compiled assembly still remains generic. Thus, one may instantiate the generic type in a different assembly and even in a different language than the assembly in which the generic type was defined.  
  
## Remarks  
 For more information, see:  
  
-   [Generics (C#)](../vs140/introduction-to-generics--csharp-programming-guide-.md)  
  
-   [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)  
  
## Example  
  
### Description  
 This example shows a generic class defined in C#.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 This example consumes the assembly authored in C#.  
  
### Code  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Generics (C++)](../vs140/generics---c---component-extensions-.md)