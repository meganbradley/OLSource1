---
title: "Parameter &#39;&lt;parametername&gt;&#39; already has a matching omitted argument"
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
  - "vbc36566"
  - "bc36566"
helpviewer_keywords: 
  - "BC36566"
ms.assetid: b37af6bc-abd0-4436-bf8a-a467e3603342
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parameter &#39;&lt;parametername&gt;&#39; already has a matching omitted argument
A procedure call supplies an argument by name after omitting the same argument by position. Following is an example:  
  
```vb#  
Public Sub ABC(ByVal X As Byte, Optional ByVal Y As Byte = 0, _  
                                Optional ByVal Z As Byte = 0)  
' ...  
' Argument Y is omitted by position, but supplied by name.  
Call ABC(6, , Y:=3)     
```  
  
 **Error ID:** BC36566  
  
### To correct this error  
  
-   Supply the argument by position, or remove the comma that omits it.  
  
## See Also  
 [Passing Arguments by Position and by Name](../vs140/passing-arguments-by-position-and-by-name--visual-basic-.md)