---
title: "Compiler Error CS0127"
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
  - "CS0127"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0127"
ms.assetid: b20333bf-badf-4f96-a3ee-bd35f4f7e807
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0127
Since 'function' returns void, a return keyword must not be followed by an object expression  
  
 A method with a [void](../vs140/void--csharp-reference-.md) return type cannot return a value. For more information, see [Class and Struct Methods (C# Programmer's Reference)](../vs140/methods--csharp-programming-guide-.md).  
  
 The following sample generates CS0127:  
  
```  
// CS0127.cs  
namespace MyNamespace  
{  
   public class MyClass  
   {  
      public int hiddenMember2  
      {  
         get  
         {  
            return 0;  
         }  
         set   // CS0127, set has an implicit void return type  
         {  
            return 0;   // remove return statement to resolve this CS0127  
         }  
      }  
  
      public static void Main()  
      {  
      }  
   }  
}  
```