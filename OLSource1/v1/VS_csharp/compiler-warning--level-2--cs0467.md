---
title: "Compiler Warning (level 2) CS0467"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0467"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0467"
ms.assetid: ae082998-afd6-4f82-9c87-6b429ba8fd57
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) CS0467
Ambiguity between method 'method' and non-method 'non-method'.Using method group.  
  
 Inherited members from different interfaces that have the same signature  cause an ambiguity error.  
  
## Example  
 The following example generates CS0467.  
  
```c#  
// CS0467.cs  
interface IList   
{  
    int Count { get; set; }  
}  
  
interface ICounter  
{  
    void Count(int i);  
}  
  
interface IListCounter : IList, ICounter {}  
  
class Driver   
{  
    void Test(IListCounter x)  
    {  
        // The following line causes the warning. The assignment also  
        // causes an error because you can't assign a value to a method.  
        x.Count = 1;  
        x.Count(3);     
        // To resolve the warning, you can change the name of the method or   
        // the property.  
  
        // You also can disambiguate by specifying IList or ICounter.  
        ((IList)x).Count = 1;  
        ((ICounter)x).Count(3);  
    }  
  
    static void Main()   
    {  
    }  
}  
```