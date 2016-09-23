---
title: "Compiler Error CS1535"
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
  - CS1535
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS1535
ms.assetid: 19f41e78-9aea-4575-abd0-60ddb927276f
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS1535
Overloaded unary operator 'operator' takes one parameter  
  
 The definition of a unary [overloadable operator](../vs140/overloadable-operators--csharp-programming-guide-.md) must take one parameter.  
  
## Example  
 The following sample generates CS1535:  
  
```  
// CS1535.cs  
class MyClass  
{  
    // uncomment the method parameter to resolve CS1535  
    public static MyClass operator ++ (/*MyClass MC1*/)   // CS1535  
    {  
        return new MyClass();  
    }  
  
    public static int Main()  
    {  
        return 1;  
    }  
}  
```