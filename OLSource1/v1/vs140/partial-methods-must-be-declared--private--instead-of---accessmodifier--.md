---
title: "Partial methods must be declared &#39;Private&#39; instead of &#39;&lt;accessModifier&gt;&#39;"
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
  - "vbc31431"
  - "bc31431"
helpviewer_keywords: 
  - "BC31431"
ms.assetid: bbd757f3-7281-4488-8a06-f3b4bcc820dc
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Partial methods must be declared &#39;Private&#39; instead of &#39;&lt;accessModifier&gt;&#39;
The access modifier `Private` is required in partial method declarations. The following example shows the use of `Private` in the method signature and its implementation.  
  
```vb#  
' Definition of the partial method signature.  
Partial Private Sub OnNameChanged()  
    ' The body of the signature is empty.  
End Sub  
```  
  
```vb#  
' Implementation of the partial method.  
Private Sub OnNameChanged()  
    MsgBox("Name was changed to " & Me.Name)  
End Sub  
```  
  
 **Error ID:** BC31431  
  
### To correct this error  
  
-   Change the access modifier to `Private` in the signature and implementation declarations.  
  
## See Also  
 [Partial Methods](../vs140/partial-methods--visual-basic-.md)