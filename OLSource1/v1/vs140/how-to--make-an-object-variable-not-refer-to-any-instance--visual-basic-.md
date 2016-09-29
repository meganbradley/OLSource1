---
title: "How to: Make an Object Variable Not Refer to Any Instance (Visual Basic)"
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
  - "Nothing keyword, variable assignment"
  - "object variables, null reference"
ms.assetid: e6d30578-bdae-4142-a3ac-a10697bf696a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Make an Object Variable Not Refer to Any Instance (Visual Basic)
You can disassociate an object variable from any object instance by setting it to [Nothing (Visual Basic)](../vs140/nothing--visual-basic-.md).  
  
### To disassociate an object variable from any object instance  
  
-   Set the variable to `Nothing` in an assignment statement.  
  
    ```  
    ' Assume account is a defined class  
    Dim currentAccount As account  
    currentAccount = Nothing  
    ```  
  
## Robust Programming  
 If your code tries to access a member of an object variable that has been set to `Nothing`, a <xref:System.NullReferenceException*> occurs. If you set an object variable to `Nothing` frequently, or if it is possible the variable is not initialized, it is a good idea to enclose member accesses in a `Try...Catch...Finally` block.  
  
## .NET Framework Security  
 If you use an object variable for objects that contain confidential or sensitive data, you can set the variable to `Nothing` when you are not actively dealing with one of those objects. This reduces the chance of malicious code gaining access to the data.  
  
## See Also  
 <xref:System.NullReferenceException*>   
 [Object Variables in Visual Basic](../vs140/object-variables-in-visual-basic.md)   
 [Object Variable Assignment](../vs140/object-variable-assignment--visual-basic-.md)   
 [Nothing (Visual Basic)](../vs140/nothing--visual-basic-.md)   
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [Troubleshooting Exceptions: NullReferenceException](../vs140/troubleshooting-exceptions--system.nullreferenceexception.md)