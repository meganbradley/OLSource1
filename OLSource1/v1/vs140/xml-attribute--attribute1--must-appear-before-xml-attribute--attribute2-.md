---
title: "XML attribute &#39;attribute1&#39; must appear before XML attribute &#39;attribute2&#39;"
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
  - "bc31157"
  - "vbc31157"
helpviewer_keywords: 
  - "BC31157"
ms.assetid: d8d8769e-533d-454e-b145-99955ce45cc5
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML attribute &#39;attribute1&#39; must appear before XML attribute &#39;attribute2&#39;
Attributes in an XML document literal are specified in an invalid order. Valid attribute order for an XML document literal is based on the XML 1.0 specification. For example, the `encoding` attribute of an XML document literal must immediately follow the `version` attribute.  
  
 **Error ID:** BC31157  
  
### To correct this error  
  
-   Update the attribute order for the XML document literal by using the guidelines specified in the XML 1.0 specification.  
  
## See Also  
 [XML Literals and the XML 1.0 Specification](../vs140/xml-literals-and-the-xml-1.0-specification--visual-basic-.md)   
 [XML Document Literal](../vs140/xml-document-literal--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)