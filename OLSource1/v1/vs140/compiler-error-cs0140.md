---
title: "Compiler Error CS0140"
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
  - "CS0140"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0140"
ms.assetid: 61787b8a-7b69-41c1-8ee3-87f619698594
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0140
The label 'label' is a duplicate  
  
 A label with the same name appeared twice. For more information, see [goto (C# Programmer's Reference)](../vs140/goto--csharp-reference-.md).  
  
 The following sample generates CS0140:  
  
```  
// CS0140.cs  
namespace MyNamespace  
{  
   public class MyClass  
   {  
      public static void Main()  
      {  
         label1: int i = 0;  
         label1: int j = 0;   // CS0140, comment this line to resolve  
         goto label1;  
      }  
   }  
}  
```