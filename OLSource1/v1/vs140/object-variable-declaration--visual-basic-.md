---
title: "Object Variable Declaration (Visual Basic)"
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
  - early binding
  - declarations, class
  - classes [Visual Basic], declaring
  - binding, late and early
  - object variables, declaring
  - variables [Visual Basic], object
  - declaring variables, object variables
  - declaring classes
  - late binding
ms.assetid: 2a5a41a3-1aa8-4236-b1f0-2382af7bf715
caps.latest.revision: 37
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Object Variable Declaration (Visual Basic)
You use a normal declaration statement to declare an object variable. For the data type, you specify either `Object` (that is, the [Object Data Type](../vs140/object-data-type.md)) or a more specific class from which the object is to be created.  
  
 Declaring a variable as `Object` is the same as declaring it as <xref:System.Object?qualifyHint=True>.  
  
 When you declare a variable with a specific object class, it can access all the methods and properties exposed by that class and the classes from which it inherits. If you declare the variable with <xref:System.Object?qualifyHint=False>, it can access only the members of the <xref:System.Object?qualifyHint=False> class, unless you turn `Option Strict Off` to allow late binding.  
  
## Declaration Syntax  
 Use the following syntax to declare an object variable:  
  
```  
Dim variablename As [New] { objectclass | Object }  
```  
  
 You can also specify [Public (Visual Basic)](../vs140/public--visual-basic-.md), [Protected (Visual Basic)](../vs140/protected--visual-basic-.md), [Friend (Visual Basic)](../vs140/friend--visual-basic-.md), `Protected Friend`, [Private (Visual Basic)](../vs140/private--visual-basic-.md), [Shared (Visual Basic)](../vs140/shared--visual-basic-.md), or [Static (Visual Basic)](../vs140/static--visual-basic-.md) in the declaration. The following example declarations are valid:  
  
```  
Private objA As Object  
Static objB As System.Windows.Forms.Label  
Dim objC As System.OperatingSystem  
```  
  
## Late Binding and Early Binding  
 Sometimes the specific class is unknown until your code runs. In this case, you must declare the object variable with the `Object` data type. This creates a general reference to any type of object, and the specific class is assigned at run time. This is called *late binding*. Late binding requires additional execution time. It also limits your code to the methods and properties of the class you have most recently assigned to it. This can cause run-time errors if your code attempts to access members of a different class.  
  
 When you know the specific class at compile time, you should declare the object variable to be of that class. This is called *early binding*. Early binding improves performance and guarantees your code access to all the methods and properties of the specific class. In the preceding example declarations, if variable `objA` uses only objects of class <xref:System.Windows.Forms.Label?qualifyHint=True>, you should specify `As System.Windows.Forms.Label` in its declaration.  
  
### Advantages of Early Binding  
 Declaring an object variable as a specific class gives you several advantages:  
  
-   Automatic type checking  
  
-   Guaranteed access to all members of the specific class  
  
-   Microsoft IntelliSense support in the Code Editor  
  
-   Improved readability of your code  
  
-   Fewer errors in your code  
  
-   Errors caught at compile time rather than run time  
  
-   Faster code execution  
  
## Access to Object Variable Members  
 When `Option Strict` is turned `On`, an object variable can access only the methods and properties of the class with which you declare it. The following example illustrates this.  
  
```  
' Option statements must precede all other source file lines.  
Option Strict On  
' Imports statement must precede all declarations in the source file.  
Imports System.Windows.Forms  
Public Sub accessMembers()  
    Dim p As Object  
    Dim q As System.Windows.Forms.Label  
    p = New System.Windows.Forms.Label  
    q = New System.Windows.Forms.Label  
    Dim j, k As Integer  
    ' The following statement generates a compiler ERROR.  
    j = p.Left  
    ' The following statement retrieves the left edge of the label in pixels.  
    k = q.Left  
End Sub  
```  
  
 In this example, `p` can use only the members of the <xref:System.Object?qualifyHint=False> class itself, which do not include the `Left` property. On the other hand, `q` was declared to be of type <xref:System.Windows.Forms.Label?qualifyHint=False>, so it can use all the methods and properties of the <xref:System.Windows.Forms.Label?qualifyHint=False> class in the <xref:System.Windows.Forms?qualifyHint=False> namespace.  
  
## Flexibility of Object Variables  
 When working with objects in an inheritance hierarchy, you have a choice of which class to use for declaring your object variables. In making this choice, you must balance flexibility of object assignment against access to members of a class. For example, consider the inheritance hierarchy that leads to the <xref:System.Windows.Forms.Form?qualifyHint=True> class:  
  
 <xref:System.Object?qualifyHint=False>  
  
 `` <xref:System.ComponentModel.Component?qualifyHint=False>  
  
 `` <xref:System.Windows.Forms.Control?qualifyHint=False>  
  
 `` <xref:System.Windows.Forms.ScrollableControl?qualifyHint=False>  
  
 `` <xref:System.Windows.Forms.ContainerControl?qualifyHint=False>  
  
 `` <xref:System.Windows.Forms.Form?qualifyHint=False>  
  
 Suppose your application defines a form class called `specialForm`, which inherits from class <xref:System.Windows.Forms.Form?qualifyHint=False>. You can declare an object variable that refers specifically to `specialForm`, as the following example shows.  
  
```  
Public Class specialForm  
    Inherits System.Windows.Forms.Form  
    ' Insert code defining methods and properties of specialForm.  
End Class  
Dim nextForm As New specialForm  
```  
  
 The declaration in the preceding example limits the variable `nextForm` to objects of class `specialForm`, but it also makes all the methods and properties of `specialForm` available to `nextForm`, as well as all the members of all the classes from which `specialForm` inherits.  
  
 You can make an object variable more general by declaring it to be of type <xref:System.Windows.Forms.Form?qualifyHint=False>, as the following example shows.  
  
```  
Dim anyForm As System.Windows.Forms.Form  
```  
  
 The declaration in the preceding example lets you assign any form in your application to `anyForm`. However, although `anyForm` can access all the members of class <xref:System.Windows.Forms.Form?qualifyHint=False>, it cannot use any of the additional methods or properties defined for specific forms such as `specialForm`.  
  
 All the members of a base class are available to derived classes, but the additional members of a derived class are unavailable to the base class.  
  
## See Also  
 [Object Variables](../vs140/object-variables-in-visual-basic.md)   
 [Object Variable Assignment](../vs140/object-variable-assignment--visual-basic-.md)   
 [Object Variable Values](../vs140/object-variable-values--visual-basic-.md)   
 [How to: Declare an Object Variable and Assign an Object to It in Visual Basic](../vs140/how-to--declare-an-object-variable-and-assign-an-object-to-it-in-visual-basic.md)   
 [How to: Access Members of an Object](../vs140/how-to--access-members-of-an-object--visual-basic-.md)   
 [New Operator](../vs140/new-operator--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)