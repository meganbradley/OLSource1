---
title: "XML literals and XML properties are not supported in embedded code within ASP.NET"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc31200"
  - "bc31200"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC31200"
ms.assetid: 053e8cba-8584-45cc-9fa0-43d122779772
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML literals and XML properties are not supported in embedded code within ASP.NET
XML literals and XML properties are not supported in embedded code within ASP.NET. To use XML features, move the code to code-behind.  
  
 An XML literal or XML axis property is defined within embedded code (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>) in an ASP.NET file.  
  
 **Error ID:** BC31200  
  
### To correct this error  
  
-   Move the code that includes the XML literal or XML axis property to an ASP.NET code-behind file.  
  
## See Also  
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)