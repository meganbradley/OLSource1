---
title: "Compiler Error CS0185"
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
  - "CS0185"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0185"
ms.assetid: d6546e10-0af3-4860-8e6f-2da7dbeb3d28
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0185
'type' is not a reference type as required by the lock statement  
  
 The [lock](../vs140/lock-statement--csharp-reference-.md) statement can only evaluate reference types. For more information, see [Lock Statement and Thread Synchronization (C# Programmers Reference)](../vs140/thread-synchronization--csharp-and-visual-basic-.md) and [Reference Types](../vs140/reference-types--csharp-reference-.md).  
  
## Example  
 The following sample generates CS0185:  
  
```  
// CS0185.cs  
public class MainClass  
{  
    public static void Main ()  
    {  
        lock (1)   // CS0185  
        // try the following lines instead  
        // MainClass x = new MainClass();  
        // lock(x)  
        {  
        }  
    }  
}  
```