---
title: "XML namespace URI &#39;&lt;uri&gt;&#39; can be bound only to &#39;xmlns&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "XML namespace URI &#39;http://www.w3.org/XML/1998/namespace&#39; can be bound only to &#39;xmlns&#39;"
f1_keywords: 
  - "bc31183"
  - "vbc31183"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC31183"
ms.assetid: 0ab1dbce-8397-4959-b2cd-f58798b051a0
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML namespace URI &#39;&lt;uri&gt;&#39; can be bound only to &#39;xmlns&#39;
The URI http://www.w3.org/XML/1998/namespace is used in an XML namespace declaration. This URI is a reserved namespace and cannot be included in an XML namespace declaration.  
  
 **Error ID:** BC31183  
  
### To correct this error  
  
-   Remove the XML namespace declaration or replace the URI http://www.w3.org/XML/1998/namespace with a valid namespace URI.  
  
## See Also  
 [Imports Statement (XML Namespace Prefix)](../VS_csharp/imports-statement--xml-namespace-.md)   
 [XML Literals](../VS_csharp/xml-literals--visual-basic-.md)   
 [XML in Visual Basic](../VS_csharp/xml-in-visual-basic.md)