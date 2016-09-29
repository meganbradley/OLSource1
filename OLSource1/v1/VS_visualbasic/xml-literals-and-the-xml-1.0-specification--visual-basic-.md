---
title: "XML Literals and the XML 1.0 Specification (Visual Basic)"
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
  - "XML literals [Visual Basic], XML 1.0 specification"
ms.assetid: 46f046e5-293c-41a3-b893-4e5f6e32e78a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML Literals and the XML 1.0 Specification (Visual Basic)
The XML literal syntax in [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] supports most of the Extensible Markup Language (XML) 1.0 specification. For details about the XML 1.0 specification, see [Extensible Markup Language (XML) 1.0](http://go.microsoft.com/fwlink/?LinkId=73927) on the W3C Web site.  
  
## What Visual Basic Does Not Support  
  
-   An XML literal cannot contain a document type definition (DTD).  
  
-   An XML document literal must start with an XML document declaration.  
  
-   An XML literal cannot contain more than 65,535 characters on one line.  
  
-   XML namespace prefixes, element names, and attribute names cannot contain more than 1,024 characters.  
  
## Extra Features That Visual Basic Supports  
  
-   The embedded expression syntax allowed in document and element literals is not valid XML.  
  
## See Also  
 [Creating XML in Visual Basic](../VS_csharp/creating-xml-in-visual-basic.md)   
 [XML Document Literal](../VS_csharp/xml-document-literal--visual-basic-.md)   
 [XML Element Literal](../VS_csharp/xml-element-literal--visual-basic-.md)