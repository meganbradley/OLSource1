---
title: "How to: Make an Object Variable Not Refer to Any Instance (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 9
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Make an Object Variable Not Refer to Any Instance (Visual Basic)
You can disassociate an object variable from any object instance by setting it to [Nothing](../VS_visualbasic/nothing--visual-basic-.md).  
  
### To disassociate an object variable from any object instance  
  
-   Set the variable to `Nothing` in an assignment statement.  
  
    ```  
    ' Assume account is a defined class  
    Dim currentAccount As account  
    currentAccount = Nothing  
    ```  
  
## Robust Programming  
 If your code tries to access a member of an object variable that has been set to `Nothing`, a \<xref:System.NullReferenceException> occurs. If you set an object variable to `Nothing` frequently, or if it is possible the variable is not initialized, it is a good idea to enclose member accesses in a `Try...Catch...Finally` block.  
  
## .NET Framework Security  
 If you use an object variable for objects that contain confidential or sensitive data, you can set the variable to `Nothing` when you are not actively dealing with one of those objects. This reduces the chance of malicious code gaining access to the data.  
  
## See Also  
 \<xref:System.NullReferenceException>   
 [Object Variables](../VS_visualbasic/object-variables-in-visual-basic.md)   
 [Object Variable Assignment](../VS_visualbasic/object-variable-assignment--visual-basic-.md)   
 [Nothing](../VS_visualbasic/nothing--visual-basic-.md)   
 [Try...Catch...Finally Statement](../VS_visualbasic/try...catch...finally-statement--visual-basic-.md)   
 [Troubleshooting Exceptions: System.NullReferenceException](../Topic/Troubleshooting%20Exceptions:%20System.NullReferenceException.md)