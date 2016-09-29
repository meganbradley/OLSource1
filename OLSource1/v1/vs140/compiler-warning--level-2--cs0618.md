---
title: "Compiler Warning (level 2) CS0618"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0618"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0618"
ms.assetid: b6edf0a9-b186-4ed8-9e16-978659b89205
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) CS0618
'member' is obsolete: 'text'  
  
 A class member was marked with the `Obsolete` attribute, such that a warning will be issued when the class member is referenced. For more information, see [Common Attributes](../vs140/common-attributes--csharp-and-visual-basic-.md).  
  
 The following sample generates CS0618:  
  
```  
// CS0618.cs  
// compile with: /W:2  
using System;  
  
public class C  
{  
   [Obsolete("Use newMethod instead", false)]   // warn if referenced  
   public static void m2()  
   {  
   }  
  
   public static void newMethod()  
   {  
   }  
}  
  
class MyClass  
{  
   public static void Main()  
   {  
      C.m2();  // CS0618  
   }  
}  
```