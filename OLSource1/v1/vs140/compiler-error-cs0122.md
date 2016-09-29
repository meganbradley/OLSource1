---
title: "Compiler Error CS0122"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0122"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0122"
ms.assetid: 5f639a66-c807-4166-b88a-93e5f272ceb7
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0122
'member' is inaccessible due to its protection level  
  
 The [access modifier](../vs140/modifiers--csharp-reference-.md) for a class member prevents accessing the member. For more information, see [Access Modifiers (C# Programmer's Reference)](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
 One cause of this (not shown in the sample below) can be omitting the **/out** compiler flag on the target of a friend assembly. For more information, see [Friend Assemblies (C# Programmer's Reference)](../vs140/friend-assemblies--csharp-and-visual-basic-.md) and [/out (Set Output File Name) (C# Compiler Options)](../vs140/-out--csharp-compiler-options-.md)  
  
## Example  
 The following sample generates CS0122:  
  
```  
// CS0122.cs  
public class MyClass  
{  
    // Make public to resolve CS0122  
    void MyMethod()  
    {  
    }  
}  
  
public class MyClass2  
{  
    public static int Main()  
    {  
        MyClass a = new MyClass();  
        // MyMethod is private  
        a.MyMethod();   // CS0122  
        return 0;  
   }  
}  
```