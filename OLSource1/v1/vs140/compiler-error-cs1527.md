---
title: "Compiler Error CS1527"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1527"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1527"
ms.assetid: a0d52130-d6da-41bb-b153-8e96cbb7e316
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1527
Elements defined in a namespace cannot be explicitly declared as private, protected, or protected internal  
  
 Type declarations in a namespace can have either [public](../vs140/public--csharp-reference-.md) or [internal](../vs140/internal--csharp-reference-.md) access. If no accessibility is specified, **internal** is the default.  
  
 The following sample generates CS1527:  
  
```  
// CS1527.cs  
namespace Sample  
{  
   private class C1 {};             // CS1527  
   protected class C2 {};           // CS1527  
   protected internal class C3 {};  // CS1527  
}  
```  
  
 The following example generates CS1527 because when no namespace is explicitly declared in your program code, all type declarations are located implicitly within the global namespace.  
  
```  
//cs1527_2.cs  
using System;  
  
protected class C4{}  
private struct S1{}  
```  
  
## See Also  
 [Namespaces (C# Programming Guide)](../vs140/namespaces--csharp-programming-guide-.md)   
 [global](../vs140/global--csharp-reference-.md)   
 [:: Operator (C# Reference)](../vs140/---operator--csharp-reference-.md)   
 [Accessibility Domain (C# Reference)](../vs140/accessibility-domain--csharp-reference-.md)   
 [Access Modifiers (C# Programming Guide)](../vs140/access-modifiers--csharp-programming-guide-.md)