---
title: "How to: Refer to the Current Instance of an Object (Visual Basic)"
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
  - "variables [Visual Basic], object"
  - "objects [Visual Basic], referring to current instance"
  - "instances, referring to current"
  - "current instance"
  - "object variables"
ms.assetid: 7f9b2c77-03cd-428f-adc2-b18070226e7c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Refer to the Current Instance of an Object (Visual Basic)
The *current instance* of an object is the instance in which the code is currently executing.  
  
 You use the `Me` keyword to refer to the current instance.  
  
### To refer to the current instance  
  
-   Use the `Me` keyword where you would normally use the name of an object variable.  
  
    ```  
    Me.ForeColor = System.Drawing.Color.Crimson  
    Me.Close()  
    ```  
  
     Although `Me` behaves like an object variable, you cannot declare it or assign anything to it. `Me` always refers to the current instance.  
  
## See Also  
 [Object Variables in Visual Basic](../vs140/object-variables-in-visual-basic.md)   
 [Object Variable Assignment](../vs140/object-variable-assignment--visual-basic-.md)   
 [Me, My, MyBase, and MyClass in Visual Basic](../vs140/me--my--mybase--and-myclass-in-visual-basic.md)