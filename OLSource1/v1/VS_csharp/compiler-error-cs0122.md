---
title: "Compiler Error CS0122"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 12
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Compiler Error CS0122
'member' is inaccessible due to its protection level  
  
 The [access modifier](../VS_csharp/modifiers--csharp-reference-.md) for a class member prevents accessing the member. For more information, see [Access Modifiers](../VS_csharp/access-modifiers--csharp-programming-guide-.md).  
  
 One cause of this (not shown in the sample below) can be omitting the **/out** compiler flag on the target of a friend assembly. For more information, see [Friend Assemblies](../Topic/Friend%20Assemblies%20\(C%23%20and%20Visual%20Basic\).md) and [/out (C# Compiler Options)](../VS_csharp/-out--csharp-compiler-options-.md)  
  
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