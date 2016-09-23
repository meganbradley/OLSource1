---
title: "How to: Hide an Inherited Variable (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - qualification, of element names
  - element names, qualification
  - references, declared elements
  - declaration statements, declared elements
  - referencing declared elements
  - declared elements, referencing
  - declared elements, about declared elements
  - variables [Visual Basic], hiding inherited
ms.assetid: 765728d9-7351-4a30-999d-b5f34f024412
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Hide an Inherited Variable (Visual Basic)
A derived class inherits all the definitions of its base class. If you want to define a variable using the same name as an element of the base class, you can hide, or *shadow*, that base class element when you define your variable in the derived class. If you do this, code in the derived class accesses your variable unless it explicitly bypasses the shadowing mechanism.  
  
 Another reason you might want to hide an inherited variable is to protect against base class revision. The base class might undergo a change that alters the element you are inheriting. If this happens, the `Shadows` modifier forces references from the derived class to be resolved to your variable, instead of to the base class element.  
  
### To hide an inherited variable  
  
1.  Be sure the variable you want to hide is declared at class level (outside any procedure). Otherwise you do not need to hide it.  
  
2.  Inside your derived class, write a [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md) declaring your variable. Use the same name as that of the inherited variable.  
  
3.  Include the [Shadows](../vs140/shadows--visual-basic-.md) keyword in the declaration.  
  
     When code in the derived class refers to the variable name, the compiler resolves the reference to your variable.  
  
     The following example illustrates shadowing of an inherited variable.  
  
    ```  
    Public Class shadowBaseClass  
        Public shadowString As String = "This is the base class string."  
    End Class  
    Public Class shadowDerivedClass  
        Inherits shadowBaseClass  
        Public Shadows shadowString As String = "This is the derived class string."  
        Public Sub showStrings()  
            Dim s As String = "Unqualified shadowString: " & shadowString &  
                vbCrLf & "MyBase.shadowString: " & MyBase.shadowString  
            MsgBox(s)  
        End Sub  
    End Class  
    ```  
  
     The preceding example declares the variable `shadowString` in the base class and shadows it in the derived class. The procedure `showStrings` in the derived class displays the shadowing version of the string when the name `shadowString` is not qualified. It then displays the shadowed version when `shadowString` is qualified with the `MyBase` keyword.  
  
## Robust Programming  
 Shadowing introduces more than one version of a variable with the same name. When a code statement refers to the variable name, the version to which the compiler resolves the reference depends on factors such as the location of the code statement and the presence of a qualifying string. This can increase the risk of referring to an unintended version of a shadowed variable. You can lower that risk by fully qualifying all references to a shadowed variable.  
  
## See Also  
 [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md)   
 [Shadowing in Visual Basic](../vs140/shadowing-in-visual-basic.md)   
 [Differences Between Shadowing and Overriding](../vs140/differences-between-shadowing-and-overriding--visual-basic-.md)   
 [How to: Hide a Variable with the Same Name as Your Variable](../vs140/how-to--hide-a-variable-with-the-same-name-as-your-variable--visual-basic-.md)   
 [How to: Access a Variable Hidden by a Derived Class](../vs140/how-to--access-a-variable-hidden-by-a-derived-class--visual-basic-.md)   
 [Overrides](../vs140/overrides--visual-basic-.md)   
 [Me, My, MyBase, and MyClass in Visual Basic](../vs140/me--my--mybase--and-myclass-in-visual-basic.md)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)