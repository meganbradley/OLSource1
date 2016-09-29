---
title: "Compiler Error CS0262"
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
  - "CS0262"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0262"
ms.assetid: 44f8661f-c934-483f-84cd-00ca8257e50a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0262
Partial declarations of 'type' have conflicting accessibility modifiers  
  
 This error occurs if a partial type has inconsistent modifiers such as public, private, protected, internal, or abstract. These modifiers must be consistent in all partial declarations for that type. For more information, see [Partial Class Definitions (C# Programmer's Reference)](../vs140/partial-classes-and-methods--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0262:  
  
```  
// CS0262.cs  
class A  
{  
    public partial class C  // CS0262  
    {  
    }  
    private partial class C  
    {  
    }  
}  
```