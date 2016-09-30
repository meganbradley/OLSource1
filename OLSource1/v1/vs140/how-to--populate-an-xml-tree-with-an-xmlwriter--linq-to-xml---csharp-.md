---
title: "How to: Populate an XML Tree with an XmlWriter (LINQ to XML) (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: cd5674d1-5c54-4efc-ba68-e23b2875295f
caps.latest.revision: 7
---
# How to: Populate an XML Tree with an XmlWriter (LINQ to XML) (C#)
One way to populate an XML tree is to use \<xref:System.Xml.Linq.XContainer.CreateWriter*> to create an \<xref:System.Xml.XmlWriter*>, and then write to the \<xref:System.Xml.XmlWriter*>. The XML tree is populated with all nodes that are written to the \<xref:System.Xml.XmlWriter*>.  
  
 You would typically use this method when you use [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] with another class that expects to write to an \<xref:System.Xml.XmlWriter*>, such as \<xref:System.Xml.Xsl.XslCompiledTransform*>.  
  
## Example  
 One possible use for \<xref:System.Xml.Linq.XContainer.CreateWriter*> is when invoking an XSLT transformation. This example creates an XML tree, creates an \<xref:System.Xml.XmlReader*> from the XML tree, creates a new document, and then creates an \<xref:System.Xml.XmlWriter*> to write into the new document. It then invokes the XSLT transformation, passing in \<xref:System.Xml.XmlReader*> and \<xref:System.Xml.XmlWriter*>. After the transformation successfully completes, the new XML tree is populated with the results of the transformation.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Xml.Linq.XContainer.CreateWriter*>   
 \<xref:System.Xml.XmlWriter*>   
 \<xref:System.Xml.Xsl.XslCompiledTransform*>   
 [Creating XML Trees (C#)](../vs140/creating-xml-trees--csharp-.md)