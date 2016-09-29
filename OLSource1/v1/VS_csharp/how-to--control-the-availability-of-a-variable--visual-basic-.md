---
title: "How to: Control the Availability of a Variable (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "access levels, declared elements"
  - "Private keyword, accessing variables"
  - "access levels, variables"
  - "Public keyword, accessing variables"
  - "Friend keyword, accessing variables"
  - "variables [Visual Basic], access level"
  - "declared elements, access level"
  - "Protected keyword, accessing variables"
ms.assetid: eaf4f073-7922-43ce-ae1e-90ff376ae947
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Control the Availability of a Variable (Visual Basic)
You control the availability of a variable by specifying its *access level*. The access level determines what code has permission to read or write to the variable.  
  
-   *Member variables* (defined at module level and outside any procedure) default to public access, which means any code that can see them can access them. You can change this by specifying an access modifier.  
  
-   *Local variables* (defined inside a procedure) nominally have public access, although only code within their procedure can access them. You cannot change the access level of a local variable, but you can change the access level of the procedure that contains it.  
  
 For more information, see [Access Levels in Visual Basic](../VS_csharp/access-levels-in-visual-basic.md).  
  
## Private and Public Access  
  
#### To make a variable accessible only from within its module, class, or structure  
  
1.  Place the [Dim Statement](../VS_csharp/dim-statement--visual-basic-.md) for the variable inside the module, class, or structure, but outside any procedure.  
  
2.  Include the [Private](../VS_csharp/private--visual-basic-.md) keyword in the `Dim` statement.  
  
     You can read or write to the variable from anywhere within the module, class, or structure, but not from outside it.  
  
#### To make a variable accessible from any code that can see it  
  
1.  For a member variable, place the `Dim` statement for the variable inside a module, class, or structure, but outside any procedure.  
  
2.  Include the [Public](../VS_csharp/public--visual-basic-.md) keyword in the `Dim` statement.  
  
     You can read or write to the variable from any code that interoperates with your assembly.  
  
 -or-  
  
1.  For a local variable, place the `Dim` statement for the variable inside a procedure.  
  
2.  Do not include the `Public` keyword in the `Dim` statement.  
  
     You can read or write to the variable from anywhere within the procedure, but not from outside it.  
  
## Protected and Friend Access  
 You can limit the access level of a variable to its class and any derived classes, or to its assembly. You can also specify the union of these limitations, which allows access from code in any derived class or in any other place in the same assembly. You specify this union by combining the `Protected` and `Friend` keywords in the same declaration.  
  
#### To make a variable accessible only from within its class and any derived classes  
  
1.  Place the `Dim` statement for the variable inside a class, but outside any procedure.  
  
2.  Include the [Protected](../VS_csharp/protected--visual-basic-.md) keyword in the `Dim` statement.  
  
     You can read or write to the variable from anywhere within the class, as well as from within any class derived from it, but not from outside any class in the derivation chain.  
  
#### To make a variable accessible only from within the same assembly  
  
1.  Place the `Dim` statement for the variable inside a module, class, or structure, but outside any procedure.  
  
2.  Include the [Friend](../VS_csharp/friend--visual-basic-.md) keyword in the `Dim` statement.  
  
     You can read or write to the variable from anywhere within the module, class, or structure, as well as from any code in the same assembly, but not from outside the assembly.  
  
## Example  
 The following example shows declarations of variables with `Public`, `Protected`, `Friend`, `Protected Friend`, and `Private` access levels. Note that when the `Dim` statement specifies an access level, you do not need to include the `Dim` keyword.  
  
```  
Public Class classForEverybody  
Protected Class classForMyHeirs  
Friend stringForThisProject As String  
Protected Friend stringForProjectAndHeirs As String  
Private numberForMeOnly As Integer  
```  
  
## .NET Framework Security  
 The more restrictive the access level of a variable, the smaller the chances that malicious code can make improper use of it.  
  
## See Also  
 [Access Levels in Visual Basic](../VS_csharp/access-levels-in-visual-basic.md)   
 [Dim Statement](../VS_csharp/dim-statement--visual-basic-.md)   
 [Public](../VS_csharp/public--visual-basic-.md)   
 [Protected](../VS_csharp/protected--visual-basic-.md)   
 [Friend](../VS_csharp/friend--visual-basic-.md)   
 [Private](../VS_csharp/private--visual-basic-.md)