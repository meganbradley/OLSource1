---
title: "Compiler Error CS1043"
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
  - "CS1043"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1043"
ms.assetid: 749703a1-d8ac-4be6-9c48-753f64ae92a1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1043
{ or ; expected  
  
 A property accessor was declared incorrectly. For more information, see [Using Properties (C# Programming Guide)](../vs140/using-properties--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS1043.  
  
```  
// CS1043.cs  
// compile with: /target:library  
public class MyClass  
{  
   public int DoSomething  
   {  
      get return 1;   // CS1043  
      set {}  
   }  
  
   // OK  
   public int DoSomething2  
   {  
      get { return 1;}  
   }  
}  
```