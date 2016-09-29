---
title: "Parameter &#39;&lt;parametername&gt;&#39; in extension method &#39;&lt;methodname&gt;&#39; defined in &#39;&lt;typename&gt;&#39; already has a matching omitted argument"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc36583"
  - "vbc36583"
helpviewer_keywords: 
  - "BC36583"
ms.assetid: 662072fa-abb8-43c3-8ca2-aefb20f2e902
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parameter &#39;&lt;parametername&gt;&#39; in extension method &#39;&lt;methodname&gt;&#39; defined in &#39;&lt;typename&gt;&#39; already has a matching omitted argument
A procedure call to an extension method omits an argument by position and then supplies the argument by name. For example, the following call to extension method `ABC` first omits an argument for parameter `Y`, and then supplies it by name.  
  
```  
<Extension()> _  
Public Sub ABC(ByVal X As Integer, Optional ByVal Y As Byte = 0, _  
               Optional ByVal Z As Byte = 0)  
End Sub  
' . . .  
' Calling extension method ABC.  
Dim number As Integer  
' Not valid.  
' number.ABC(, 4, Y:=5)  
```  
  
 **Error ID:** BC36583  
  
### To correct this error  
  
-   Supply the argument by position, or remove the comma that omits it.  
  
## See Also  
 [Extension Methods (Visual Basic)](../vs140/extension-methods--visual-basic-.md)   
 [Passing Arguments by Position and by Name](../vs140/passing-arguments-by-position-and-by-name--visual-basic-.md)