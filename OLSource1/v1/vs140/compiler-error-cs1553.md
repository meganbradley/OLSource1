---
title: "Compiler Error CS1553"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CS1553
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS1553
ms.assetid: aec64251-b4ac-45c0-b143-7ebda138af6e
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS1553
Declaration is not valid; use 'modifier operator <dest-type> (...' instead  
  
 The return type for an [operator](../vs140/operator--csharp-reference-2.md) must immediately precede the parameter list, and *modifier* is either `implicit` or **explicit**.  
  
 The following sample generates CS1553:  
  
```  
// CS1553.cs  
class MyClass  
{  
   public static int implicit operator (MyClass f)   // CS1553  
   // try the following line instead  
   // public static implicit operator int (MyClass f)  
   {  
      return 6;  
   }  
  
   public static void Main()  
   {  
   }  
}  
```