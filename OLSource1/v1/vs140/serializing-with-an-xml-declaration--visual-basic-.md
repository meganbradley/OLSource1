---
title: "Serializing with an XML Declaration (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 8726f79e-2bb0-4ba0-969d-197cca591647
caps.latest.revision: 5
---
# Serializing with an XML Declaration (Visual Basic)
This topic describes how to control whether serialization generates an XML declaration.  
  
## XML Declaration Generation  
 Serializing to a \<xref:System.IO.File*> or a \<xref:System.IO.TextWriter*> using the \<xref:System.Xml.Linq.XElement.Save*?displayProperty=fullName> method or the \<xref:System.Xml.Linq.XDocument.Save*?displayProperty=fullName> method generates an XML declaration. When you serialize to an \<xref:System.Xml.XmlWriter*>, the writer settings (specified in an \<xref:System.Xml.XmlWriterSettings*> object) determine whether an XML declaration is generated or not.  
  
 If you are serializing to a string using the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method, the resulting XML will not include an XML declaration.  
  
### Serializing with an XML Declaration  
 The following example creates an \<xref:System.Xml.Linq.XElement*>, saves the document to a file, and then prints the file to the console:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Serializing without an XML Declaration  
 The following example shows how to save an \<xref:System.Xml.Linq.XElement*> to an \<xref:System.Xml.XmlWriter*>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Serializing XML Trees (Visual Basic)](../vs140/serializing-xml-trees--visual-basic-.md)