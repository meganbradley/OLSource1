---
title: "Compiler Error CS0082"
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
  - CS0082
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0082
ms.assetid: 7612976f-de2c-4f6b-87c9-43175821650c
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0082
Type 'type' already reserves a member called 'name' with the same parameter types  
  
 Properties at compile time are translated to methods with `get_` and/or `set_` in front of the identifier. If you define your own method that conflicts with the method name, an error is generated.  
  
## Example  
 The following example generates CS0082:  
  
```  
//cs0082.cs  
class MyClass  
{  
  
    //property  
    public int MyProp  
    {  
        get //CS0082  
        {  
            return 1;  
        }  
    }  
  
    //conflicting Get  
    public int get_MyProp()  
    {  
        return 2;  
    }  
  
    public static int Main()  
    {  
        return 1;  
    }  
}  
```  
  
## See Also  
 [Properties (C# Programming Guide)](../vs140/properties--csharp-programming-guide-.md)