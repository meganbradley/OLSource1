---
title: "Compiler Error CS1597"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CS1597
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS1597
ms.assetid: 735e7cde-38de-4e15-96cc-ce75ffe34ff2
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS1597
Semicolon after method or accessor block is not valid  
  
 Semicolons are not needed (or allowed) to end a method or accessor block.  
  
 The following sample generates CS1597:  
  
```  
// CS1597.cs  
class TestClass  
{  
   public static void Main()  
   {  
   };   // CS1597, remove semicolon  
}  
```