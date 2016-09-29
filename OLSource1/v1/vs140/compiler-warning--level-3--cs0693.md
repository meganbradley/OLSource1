---
title: "Compiler Warning (level 3) CS0693"
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
  - "CS0693"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0693"
ms.assetid: a3902336-49db-4808-b41f-8f0936bff53a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) CS0693
Type parameter 'type parameter' has the same name as the type parameter from outer type 'type'  
  
 This error occurs when you have a generic member such as a method inside a generic class. Since the method's type parameter is not necessarily the same as the class's type parameter, you cannot give them both the same name. For more information, see [Generic Methods (C# Programming Guide)](../vs140/generic-methods--csharp-programming-guide-.md).  
  
 To avoid this situation, use a different name for one of the type parameters.  
  
## Example  
 The following sample generates CS0693.  
  
```  
// CS0693.cs  
// compile with: /W:3 /target:library  
class Outer<T>  
{  
   class Inner<T> {}   // CS0693  
   // try the following line instead  
   // class Inner<U> {}  
}  
```