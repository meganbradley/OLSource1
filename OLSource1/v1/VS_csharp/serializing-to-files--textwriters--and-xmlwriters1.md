---
title: "Serializing to Files, TextWriters, and XmlWriters1"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Serializing to Files, TextWriters, and XmlWriters"
dev_langs: 
  - "CSharp"
ms.assetid: bd3ea6f7-895b-4ff4-a625-fe2bb55b1886
caps.latest.revision: 7
---
# Serializing to Files, TextWriters, and XmlWriters1
You can serialize XML trees to a <xref:System.IO.File*>, a <xref:System.IO.TextWriter*>, or an <xref:System.Xml.XmlWriter*>.  
  
 You can serialize any XML component, including <xref:System.Xml.Linq.XDocument*> and <xref:System.Xml.Linq.XElement*>, to a string by using the `ToString` method.  
  
 If you want to suppress formatting when serializing to a string, you can use the <xref:System.Xml.Linq.XNode.ToString*?displayProperty=fullName> method.  
  
 Thedefault behavior when serializing to a file is to format (indent) the resulting XML document. When you indent, the insignificant white space in the XML tree is not preserved. To serialize with formatting, use one of the overloads of the following methods that do not take <xref:System.Xml.Linq.SaveOptions*> as an argument:  
  
-   <xref:System.Xml.Linq.XDocument.Save*?displayProperty=fullName>  
  
-   <xref:System.Xml.Linq.XElement.Save*?displayProperty=fullName>  
  
 If you want the option not to indent and to preserve the insignificant white space in the XML tree, use one of the overloads of the following methods that takes <xref:System.Xml.Linq.SaveOptions*> as an argument:  
  
-   <xref:System.Xml.Linq.XDocument.Save*?displayProperty=fullName>  
  
-   <xref:System.Xml.Linq.XElement.Save*?displayProperty=fullName>  
  
 For examples, see the appropriate reference topic.  
  
## See Also  
 [Serializing XML Trees (C#)](../VS_csharp/serializing-xml-trees--csharp-.md)