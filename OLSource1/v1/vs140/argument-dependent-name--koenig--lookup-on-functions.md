---
title: "Argument-Dependent Name (Koenig) Lookup on Functions"
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
  - "Koenig lookup"
  - "argument-dependent lookup [C++]"
ms.assetid: c0928401-da2c-4658-942d-9ba4df149c35
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Argument-Dependent Name (Koenig) Lookup on Functions
The compiler can use argument-dependent name lookup to find the definition of an unqualified function call. Argument-dependent name lookup is also called Koenig lookup. The type of every argument in a function call is defined within a hierarchy of namespaces, classes, structures, unions, or templates. When you specify an unqualified [postfix](../vs140/postfix-expressions.md) function call, the compiler searches for the function definition in the hierarchy associated with each argument type.  
  
## Example  
 In the sample, the compiler notes that function <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> takes an argument <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Argument <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which is defined in namespace <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The compiler searches namespace <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and finds a definition for function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that takes an argument of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Visual C++ .NET 2003 Enhanced Compiler Conformance](../vs140/visual-c---.net-2003-enhanced-compiler-conformance.md)