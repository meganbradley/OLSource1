---
title: "Expected &#39;%=&#39; at start of an embedded expression"
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
  - "vbc31179"
  - "bc31179"
helpviewer_keywords: 
  - "BC31179"
ms.assetid: 20b0382e-1744-47e4-84e1-7fc926cbc4df
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expected &#39;%=&#39; at start of an embedded expression
The start identifier for an embedded expression, `<%=`, has not been coded correctly. Note that you cannot use a percent character (%) in the name for an XML element literal.  
  
 **Error ID:** BC31179  
  
### To correct this error  
  
-   Ensure that the start identifier for the embedded expression is coded as `<%=`.  
  
## See Also  
 [Embedded Expressions In XML](../vs140/embedded-expressions-in-xml--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)