---
title: "&#39;prefix&#39; is an XML prefix and cannot be used as an expression"
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
  - "bc30114"
  - "vbc30114"
helpviewer_keywords: 
  - "BC30114"
ms.assetid: 5cb7c89e-c61b-483a-9369-5285b7cbcf45
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;prefix&#39; is an XML prefix and cannot be used as an expression
'prefix' is an XML prefix and cannot be used as an expression. Use the GetXmlNamespace operator to create a namespace object.  
  
 The prefix for an XML namespace that is imported by using the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement cannot be used outside an XML literal.  
  
 **Error ID:** BC30114  
  
### To correct this error  
  
-   If you have to refer to part of the imported XML namespace, use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator to retrieve an \<xref:System.Xml.Linq.XNamespace*> object. Use that object instead of the XML namespace prefix.  
  
-   If you are using the XML namespace prefix to qualify an XML literal, ensure that you are using appropriate syntax for the XML literal.  
  
## See Also  
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [Imports Statement (XML Namespace)](../vs140/imports-statement--xml-namespace-.md)   
 [GetXmlNamespace Operator](../vs140/getxmlnamespace-operator--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)