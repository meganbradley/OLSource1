---
title: "Compiler Error CS0442"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0442"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0442"
ms.assetid: a411660d-0db6-4b63-b19e-f4538fc201e5
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0442
'Property': abstract properties cannot have private accessors  
  
 This error occurs when you use the access modifier "private" to modify an abstract accessor. To resolve, use a different access modifier, or make the property non-abstract.  
  
## Example  
 The following sample generates CS0442:  
  
```  
// CS0442.cs  
public abstract class MyClass   
{  
    public abstract int AbstractProperty   
    {  
        get;  
        private set;   // CS0442  
        // Try this instead:  
        // set;  
    }  
}  
```