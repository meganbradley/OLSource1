---
title: "Compiler Error CS0750"
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
  - "CS0750"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0750"
ms.assetid: 84fb6841-7f47-405a-ae05-95567692f73d
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0750
A partial method cannot have access modifiers or the virtual, abstract, override, new, sealed, or extern modifiers.  
  
 Because of their special behavior, partial methods are subject to restrictions as to the modifiers they can accept.  
  
### To correct this error  
  
1.  Remove the unauthorized modifier from the method declaration.  
  
## Example  
 The following example generates CS0750:  
  
```  
// cs0750.cs  
using System;  
  
public class Base  
{  
    protected virtual void PartG()  
    {  
    }  
  
    protected void PartH()  
    {  
    }  
    protected virtual void PartI()  
    {  
    }  
}  
  
public partial class C:Base  
{  
    // All these partial method declarations  
    // will generate CS0750.  
    public partial void PartA();  
    private partial void PartB();  
    protected partial void PartC();  
    internal partial void PartD();  
    virtual partial void PartE();  
    abstract partial void PartF();  
    override partial void PartG();  
    new partial void PartH();  
    sealed override partial void PartI();  
    extern partial void PartJ();  
  
    public static int Main()  
    {  
        return 1;  
    }  
}  
```  
  
## See Also  
 [Partial Classes and Methods (C# Programming Guide)](../vs140/partial-classes-and-methods--csharp-programming-guide-.md)