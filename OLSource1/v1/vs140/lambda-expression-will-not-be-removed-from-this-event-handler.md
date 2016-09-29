---
title: "Lambda expression will not be removed from this event handler"
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
  - "bc42326"
  - "vbc42326"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC42326"
ms.assetid: 63214dc6-0112-4245-8ebf-7c9e8f5a5782
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lambda expression will not be removed from this event handler
Lambda expression will not be removed from this event handler. Assign the lambda expression to a variable and use the variable to add and remove the event.  
  
 When lambda expressions are used with event handlers, you may not see the behavior you expect. The compiler generates a new method for each lambda expression definition, even if they are identical. Therefore, the following code displays `False`.  
  
```vb#  
Module Module1  
  
    Sub Main()  
        Dim fun1 As ChangeInteger = Function(p As Integer) p + 1  
        Dim fun2 As ChangeInteger = Function(p As Integer) p + 1  
        Console.WriteLine(fun1 = fun2)  
    End Sub  
  
    Delegate Function ChangeInteger(ByVal x As Integer) As Integer  
  
End Module  
```  
  
 When lambda expressions are used with event handlers, this may cause unexpected results. In the following example, the lambda expression added by `AddHandler` is not removed by the `RemoveHandler` statement.  
  
```vb#  
Module Module1  
  
    Event ProcessInteger(ByVal x As Integer)  
  
    Sub Main()  
  
        ' The following line adds one listener to the event.  
        AddHandler ProcessInteger, Function(m As Integer) m  
  
        ' The following statement searches the current listeners   
        ' for a match to remove. However, this lambda is not the same  
        ' as the previous one, so nothing is removed.  
        RemoveHandler ProcessInteger, Function(m As Integer) m  
  
    End Sub  
End Module  
```  
  
 By default, this message is a warning. For more information about how to hide warnings or treat warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42326  
  
### To correct this error  
  
-   To avoid the warning and remove the lambda expression, assign the lambda expression to a variable and use the variable in both the `AddHandler` and `RemoveHandler` statements, as shown in the following example.  
  
    ```vb#  
    Module Module1  
  
        Event ProcessInteger(ByVal x As Integer)  
  
        Dim PrintHandler As ProcessIntegerEventHandler  
  
        Sub Main()  
  
            ' Assign the lambda expression to a variable.  
            PrintHandler = Function(m As Integer) m  
  
            ' Use the variable to add the listener.  
            AddHandler ProcessInteger, PrintHandler  
  
            ' Use the variable again when you want to remove the listener.  
            RemoveHandler ProcessInteger, PrintHandler  
  
        End Sub  
    End Module  
    ```  
  
## See Also  
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)   
 [Relaxed Delegate Conversion](../vs140/relaxed-delegate-conversion--visual-basic-.md)   
 [Events (Visual Basic)](../vs140/events--visual-basic-.md)