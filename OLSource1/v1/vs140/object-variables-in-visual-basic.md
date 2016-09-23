---
title: "Object Variables in Visual Basic"
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
  - object variables, about object variables
  - variables [Visual Basic], object
  - objects [Visual Basic], accessing
  - object variables
ms.assetid: 6169a196-2b13-4ba5-a205-154bc1b87844
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Object Variables in Visual Basic
In addition to storing values directly, a variable can refer to an object. You assign an object to a variable for the same reasons you assign any value to a variable:  
  
-   A variable name is often shorter and easier to remember than the full path of methods and properties necessary to access the object itself.  
  
-   Using a variable that refers to an object is more efficient than repeatedly accessing the object itself through the necessary methods or properties.  
  
-   You can change a variable to refer to other objects while your code is running.  
  
## Making Code Shorter  
 You can use object variables to shorten the code you have to type. The following example uses the full path of methods and properties to access a <xref:System.Windows.Forms.Control?qualifyHint=False> object.  
  
```  
' Assume Me is a valid Form, or replace Me with a valid Form.  
Me.ActiveForm.ActiveControl.Text = "Test"  
Me.ActiveForm.ActiveControl.Location = New Point(100, 100)  
Me.ActiveForm.ActiveControl.Show()  
```  
  
 You can shorten this code, and speed up execution, if you use an object variable for the control. You should declare the object variable with the specific class that you intend to assign to it (`Control` in this case). Once you assign an object to the variable, you can treat it exactly the same as you treat the object to which it refers. You can set or retrieve the properties of the object or use any of its methods. The following example uses an object variable to simplify the code in the preceding example.  
  
```  
Dim ctrlActv As System.Windows.Forms.Control = Me.ActiveForm.ActiveControl  
ctrlActv.Text = "Test"  
ctrlActv.Location = New Point(100, 100)  
ctrlActv.Show()  
```  
  
## See Also  
 [Variable Declaration](../vs140/variable-declaration-in-visual-basic.md)   
 [How to: Speed Up Access to an Object with a Long Qualification Path](../vs140/how-to--speed-up-access-to-an-object-with-a-long-qualification-path--visual-basic-.md)   
 [Object Variable Declaration](../vs140/object-variable-declaration--visual-basic-.md)   
 [Object Variable Assignment](../vs140/object-variable-assignment--visual-basic-.md)   
 [Object Variable Values](../vs140/object-variable-values--visual-basic-.md)