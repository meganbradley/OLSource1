---
title: "Serializing to an XmlReader (Invoking XSLT) (Visual Basic)"
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
ms.assetid: 8b64f95a-e8f6-40f7-99f9-a8002c63af96
caps.latest.revision: 5
---
# Serializing to an XmlReader (Invoking XSLT) (Visual Basic)
When you use the \<xref:System.Xml*?displayProperty=fullName> interoperability capabilities of [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)], you can use \<xref:System.Xml.Linq.XNode.CreateReader*> to create an \<xref:System.Xml.XmlReader*>. The module that reads from this \<xref:System.Xml.XmlReader*> reads the nodes from the XML tree and processes them accordingly.  
  
## Invoking an XSLT Transformation  
 One possible use for this method is when invoking an XSLT transformation. You can create an XML tree, create an \<xref:System.Xml.XmlReader*> from the XML tree, create a new document, and then create an \<xref:System.Xml.XmlWriter*> to write into the new document. Then, you can invoke the XSLT transformation, passing in \<xref:System.Xml.XmlReader*> and \<xref:System.Xml.XmlWriter*>. After the transformation successfully completes, the new XML tree is populated with the results of the transformation.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Serializing XML Trees (Visual Basic)](../vs140/serializing-xml-trees--visual-basic-.md)