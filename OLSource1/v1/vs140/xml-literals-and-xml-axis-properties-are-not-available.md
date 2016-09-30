---
title: "XML literals and XML axis properties are not available"
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
  - "bc31190"
  - "vbc31190"
helpviewer_keywords: 
  - "BC31190"
ms.assetid: cb861748-0ee4-40d3-a859-98ca6c39b4f4
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML literals and XML axis properties are not available
XML literals and XML axis properties are not available. Add references to System.Xml, System.Xml.Linq, and System.Core.  
  
 The code being compiled includes XML literals or XML axis properties, but it does not reference the assemblies that are needed to compile XML literals or XML axis properties.  
  
 **Error ID:** BC31190  
  
### To correct this error  
  
-   Add references to the System.Xml.dll, System.Xml.Linq.dll, and System.Core.dll assemblies.  
  
## See Also  
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)