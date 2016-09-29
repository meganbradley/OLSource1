---
title: "Overloads (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Overloads"
  - "Overloads"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Overloads keyword"
  - "hiding by signature"
  - "Shadows keyword"
  - "signature, hiding by"
ms.assetid: 0c6820b8-25b2-4664-bc59-5ca93c99c042
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overloads (Visual Basic)
Specifies that a property or procedure redeclares one or more existing properties or procedures with the same name.  
  
## Remarks  
 *Overloading* is the practice of supplying more than one definition for a given property or procedure name in the same scope. Redeclaring a property or procedure with a different signature is sometimes called *hiding by signature*.  
  
## Rules  
  
-   **Declaration Context.** You can use `Overloads` only in a property or procedure declaration statement.  
  
-   **Combined Modifiers.** You cannot specify `Overloads` together with [Shadows](../VS_csharp/shadows--visual-basic-.md) in the same procedure declaration.  
  
-   **Required Differences.** The *signature* in this declaration must be different from the signature of every property or procedure that it overloads. The signature comprises the property or procedure name together with the following:  
  
    -   the number of parameters  
  
    -   the order of the parameters  
  
    -   the data types of the parameters  
  
    -   the number of type parameters (for a generic procedure)  
  
    -   the return type (only for a conversion operator procedure)  
  
     All overloads must have the same name, but each must differ from all the others in one or more of the preceding respects. This allows the compiler to distinguish which version to use when code calls the property or procedure.  
  
-   **Disallowed Differences.** Changing one or more of the following is not valid for overloading a property or procedure, because they are not part of the signature:  
  
    -   whether or not it returns a value (for a procedure)  
  
    -   the data type of the return value (except for a conversion operator)  
  
    -   the names of the parameters or type parameters  
  
    -   the constraints on the type parameters (for a generic procedure)  
  
    -   parameter modifier keywords (such as `ByRef` or `Optional`)  
  
    -   property or procedure modifier keywords (such as `Public` or `Shared`)  
  
-   **Optional Modifier.** You do not have to use the `Overloads` modifier when you are defining multiple overloaded properties or procedures in the same class. However, if you use `Overloads` in one of the declarations, you must use it in all of them.  
  
-   **Shadowing and Overloading.** `Overloads` can also be used to shadow an existing member, or set of overloaded members, in a base class. When you use `Overloads` in this way, you declare the property or method with the same name and the same parameter list as the base class member, and you do not supply the `Shadows` keyword.  
  
 If you use `Overrides`, the compiler implicitly adds `Overloads` so that your library APIs work with C# more easily.  
  
 The `Overloads` modifier can be used in these contexts:  
  
 [Function Statement](../VS_csharp/function-statement--visual-basic-.md)  
  
 [Operator Statement](../VS_csharp/operator-statement.md)  
  
 [Property Statement](../VS_csharp/property-statement.md)  
  
 [Sub Statement](../VS_csharp/sub-statement--visual-basic-.md)  
  
## See Also  
 [Shadows](../VS_csharp/shadows--visual-basic-.md)   
 [Procedure Overloading](../VS_csharp/procedure-overloading--visual-basic-.md)   
 [Generic Types in Visual Basic](../VS_csharp/generic-types-in-visual-basic--visual-basic-.md)   
 [Operator Procedures](../VS_csharp/operator-procedures--visual-basic-.md)   
 [How to: Define a Conversion Operator](../VS_csharp/how-to--define-a-conversion-operator--visual-basic-.md)