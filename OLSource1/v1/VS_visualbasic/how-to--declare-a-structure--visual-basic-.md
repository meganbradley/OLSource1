---
title: "How to: Declare a Structure (Visual Basic)"
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
  - "declarations, structures"
  - "structure statements"
  - "statements [Visual Basic], structure"
  - "structures, declaring"
ms.assetid: d5e98381-eb81-47d4-af83-48cc534a2572
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Declare a Structure (Visual Basic)
You begin a structure declaration with the [Structure Statement](../VS_csharp/structure-statement.md), and you end it with the `End` `Structure` statement. Between these two statements you must declare at least one *element*. The elements can be of any data type, but at least one must be either a nonshared variable or a nonshared, noncustom event.  
  
 You cannot initialize any of the structure elements in the structure declaration. When you declare a variable to be of a structure type, you assign values to the elements by accessing them through the variable.  
  
 For a discussion of the differences between structures and classes, see [Structures and Classes](../VS_csharp/structures-and-classes--visual-basic-.md).  
  
 For demonstration purposes, consider a situation where you want to keep track of an employee's name, telephone extension, and salary. A structure allows you to do this in a single variable.  
  
### To declare a structure  
  
1.  Create the beginning and ending statements for the structure.  
  
     You can specify the access level of a structure using the [Public (Visual Basic)](../VS_csharp/public--visual-basic-.md), [Protected (Visual Basic)](../VS_csharp/protected--visual-basic-.md), [Friend (Visual Basic)](../VS_csharp/friend--visual-basic-.md), or [Private (Visual Basic)](../VS_csharp/private--visual-basic-.md) keyword, or you can let it default to `Public`.  
  
    ```  
    Private Structure employee  
    End Structure  
    ```  
  
2.  Add elements to the body of the structure.  
  
     A structure must have at least one element. You must declare every element and specify an access level for it. If you use the [Dim Statement (Visual Basic)](../VS_csharp/dim-statement--visual-basic-.md) without any keywords, the accessibility defaults to `Public`.  
  
    ```  
    Private Structure employee  
        Public givenName As String  
        Public familyName As String  
        Public phoneExtension As Long  
        Private salary As Decimal  
        Public Sub giveRaise(raise As Double)  
            salary *= raise  
        End Sub  
        Public Event salaryReviewTime()  
    End Structure  
    ```  
  
     The `salary` field in the preceding example is `Private`, which means it is inaccessible outside the structure, even from the containing class. However, the `giveRaise` procedure is `Public`, so it can be called from outside the structure. Similarly, you can raise the `salaryReviewTime` event from outside the structure.  
  
     In addition to variables, `Sub` procedures, and events, you can also define constants, `Function` procedures, and properties in a structure. You can designate at most one property as the *default property*, provided it takes at least one argument. You can handle an event with a [Shared (Visual Basic)](../VS_csharp/shared--visual-basic-.md)`Sub` procedure. For more information, see [How to: Declare and Call a Default Property in Visual Basic](../VS_csharp/how-to--declare-and-call-a-default-property-in-visual-basic.md).  
  
## See Also  
 [Data Types in Visual Basic](../VS_csharp/data-types-in-visual-basic.md)   
 [Elementary Data Types](../VS_csharp/elementary-data-types--visual-basic-.md)   
 [Composite Data Types](../VS_csharp/composite-data-types--visual-basic-.md)   
 [Value Types and Reference Types](../VS_csharp/value-types-and-reference-types.md)   
 [Structures: Your Own Data Types](../VS_csharp/structures--visual-basic-.md)   
 [Troubleshooting Data Types](../VS_csharp/troubleshooting-data-types--visual-basic-.md)   
 [Structure Variables](../VS_csharp/structure-variables--visual-basic-.md)   
 [Structures and Other Programming Elements](../VS_csharp/structures-and-other-programming-elements--visual-basic-.md)   
 [Structures and Classes](../VS_csharp/structures-and-classes--visual-basic-.md)   
 [User-Defined Data Type](../VS_csharp/user-defined-data-type.md)