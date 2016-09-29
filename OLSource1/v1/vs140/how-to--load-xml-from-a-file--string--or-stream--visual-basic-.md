---
title: "How to: Load XML from a File, String, or Stream (Visual Basic)"
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
  - "XML [Visual Basic], loading"
  - "LINQ to XML [Visual Basic], loading XML from files"
ms.assetid: 2b02dcec-4cca-4575-b4ad-89ceb87b984c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Load XML from a File, String, or Stream (Visual Basic)
You can create [XML Literals](../vs140/xml-literals--visual-basic-.md) and populate them with the contents from an external source such as a file, a string, or a stream by using several methods. These methods are shown in the following examples.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
### To load XML from a file  
  
-   To populate an XML literal such as an <xref:System.Xml.Linq.XElement*> or <xref:System.Xml.Linq.XDocument*> object from a file, use the `Load` method. This method can take a file path, text stream, or XML stream as input.  
  
     The following code example shows the use of the <xref:System.Xml.Linq.XDocument.Load(System.String)> method to populate an <xref:System.Xml.Linq.XDocument*> object with XML from a text file.  
  
     [!code[VbXMLSamples#43](../vs140/codesnippet/VisualBasic/how-to--load-xml-from-a-file--string--or-stream--visual-basic-_1.vb)]  
  
### To load XML from a string  
  
-   To populate an XML literal such as an <xref:System.Xml.Linq.XElement*> or <xref:System.Xml.Linq.XDocument*> object from a string, you can use the `Parse` method.  
  
     The following code example shows the use of the <xref:System.Xml.Linq.XDocument.Parse(System.String)?displayProperty=fullName> method to populate an <xref:System.Xml.Linq.XDocument*> object with XML from a string.  
  
     [!code[VbXMLSamples#47](../vs140/codesnippet/VisualBasic/how-to--load-xml-from-a-file--string--or-stream--visual-basic-_2.vb)]  
  
### To load XML from a stream  
  
-   To populate an XML literal such as an <xref:System.Xml.Linq.XElement*> or <xref:System.Xml.Linq.XDocument*> object from a stream, you can use the `Load` method or the <xref:System.Xml.Linq.XNode.ReadFrom*?displayProperty=fullName> method.  
  
 The following code example shows the use of the <xref:System.Xml.Linq.XNode.ReadFrom*> method to populate an <xref:System.Xml.Linq.XDocument*> object with XML from an XML stream.  
  
 [!code[VbXMLSamples#46](../vs140/codesnippet/VisualBasic/how-to--load-xml-from-a-file--string--or-stream--visual-basic-_3.vb)]  
  
## See Also  
 <xref:System.Xml.Linq.XDocument.Load*?displayProperty=fullName>   
 <xref:System.Xml.Linq.XElement.Load*?displayProperty=fullName>   
 <xref:System.Xml.Linq.XElement.Parse*?displayProperty=fullName>   
 <xref:System.Xml.Linq.XDocument.Parse*?displayProperty=fullName>   
 <xref:System.Xml.Linq.XNode.ReadFrom*?displayProperty=fullName>   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)   
 [Manipulating XML in Visual Basic](../vs140/manipulating-xml-in-visual-basic.md)