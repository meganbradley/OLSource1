---
title: "Expression cannot appear inside a quoted attribute value"
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
  - "bc31155"
  - "vbc31155"
helpviewer_keywords: 
  - "BC31155"
ms.assetid: ed3e618e-de94-4e4e-afaf-72b11073fb1d
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expression cannot appear inside a quoted attribute value
Expression cannot appear inside a quoted attribute value. Try removing quotes.  
  
 An embedded expression in an attribute value for an XML literal is contained within quotation marks.  
  
 **Error ID:** BC31155  
  
### To correct this error  
  
-   Remove the delimiting quotation marks from the attribute value. The following is an example:  
  
    ```vb#  
    ' Generates an error.  
    Dim elem = <outer attr="<%= value %>" />  
  
    ' Does not generate an error.  
    Dim elem = <outer attr=<%= value %> />  
    ```  
  
## See Also  
 [Embedded Expressions In XML](../vs140/embedded-expressions-in-xml--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)