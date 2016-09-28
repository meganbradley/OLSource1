---
title: "How to: Invoke a Delegate Method (Visual Basic)"
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
ms.assetid: b56866ae-abf9-4a5a-a855-486359455e9c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Invoke a Delegate Method (Visual Basic)
This example shows how to associate a method with a delegate and then invoke that method through the delegate.  
  
### Create the delegate and matching procedures  
  
1.  Create a delegate named `MySubDelegate`.  
  
    ```  
    Delegate Sub MySubDelegate(ByVal x As Integer)  
    ```  
  
2.  Declare a class that contains a method with the same signature as the delegate.  
  
    ```  
    Class class1  
        Sub Sub1(ByVal x As Integer)  
            MsgBox("The value of x is: " & CStr(x))  
        End Sub  
    End Class  
    ```  
  
3.  Define a method that creates an instance of the delegate and invokes the method associated with the delegate by calling the built-in `Invoke` method.  
  
    ```  
    Protected Sub DelegateTest()  
        Dim c1 As New class1  
        ' Create an instance of the delegate.  
        Dim msd As MySubDelegate = AddressOf c1.Sub1  
        ' Call the method.  
        msd.Invoke(10)  
    End Sub  
    ```  
  
## See Also  
 [Delegate Statement](../vs140/delegate-statement.md)   
 [Delegates in Visual Basic](../vs140/delegates--visual-basic-.md)   
 [Events (Visual Basic)](../vs140/events--visual-basic-.md)   
 [Multithreaded Applications](../vs140/multithreaded-applications--csharp-and-visual-basic-.md)