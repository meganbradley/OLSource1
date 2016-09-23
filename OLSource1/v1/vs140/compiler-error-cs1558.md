---
title: "Compiler Error CS1558"
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
  - CS1558
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS1558
ms.assetid: ee603d66-007e-4782-9285-7ff031975f0f
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS1558
'class' does not have a suitable static Main method  
  
 The [/main](../vs140/-main--csharp-compiler-options-.md) compiler option specified a class in which to look for a **Main** method. However, the [Main](../vs140/main---and-command-line-arguments--csharp-programming-guide-.md) method was not defined correctly.  
  
 The following example generates CS1558 because of invalid return type.  
  
```  
// CS1558.cs  
// compile with: /main:MyNamespace.MyClass  
  
namespace MyNamespace  
{  
   public class MyClass  
   {  
      public static float Main()   
      {  
         return 0.0; // CS1558 because the return type is a float.  
      }  
   }  
}  
```