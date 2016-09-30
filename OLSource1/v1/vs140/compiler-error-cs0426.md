---
title: "Compiler Error CS0426"
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
  - "CS0426"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0426"
ms.assetid: 62df0deb-3624-436e-9691-ebe3ee1fc31f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0426
The type name 'identifier' does not exist in the type 'type'  
  
 This error occurs when you reference a type nested within another type, but no such nested type exists. This can occur if you mistype the name of the nested type. Check the spelling of the names used, and verify that the enclosing type has the expected member.  
  
 The following sample generates CS0426 because class C has no nested type A:  
  
```  
// CS0426.cs  
  
class C  
{  
    // No nested types are declared.     
}  
  
class D  
{  
   public static void Main()  
   {  
       C c = new C();  
       // Attempt to reference a nested type A:  
       C.A a; // CS0426 because no such type C.A  
   }  
}  
```  
  
## See Also  
 [Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)