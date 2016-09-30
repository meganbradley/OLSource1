---
title: "XElement Class Overview (C#)"
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
ms.assetid: 2b9f0cd8-a1d1-4037-accf-0f38a410fa11
caps.latest.revision: 3
---
# XElement Class Overview (C#)
The \<xref:System.Xml.Linq.XElement*> class is one of the fundamental classes in [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)]. It represents an XML element. You can use this class to create elements; change the content of the element; add, change, or delete child elements; add attributes to an element; or serialize the contents of an element in text form. You can also interoperate with other classes in \<xref:System.Xml*?displayProperty=fullName>, such as \<xref:System.Xml.XmlReader*>, \<xref:System.Xml.XmlWriter*>, and \<xref:System.Xml.Xsl.XslCompiledTransform*>.  
  
## XElement Functionality  
 This topic describes the functionality provided by the \<xref:System.Xml.Linq.XElement*> class.  
  
### Constructing XML Trees  
 You can construct XML trees in a variety of ways, including the following:  
  
-   You can construct an XML tree in code. For more information, see [Creating XML Trees (C#)](../vs140/creating-xml-trees--csharp-.md).  
  
-   You can parse XML from various sources, including a \<xref:System.IO.TextReader*>, text files, or a Web address (URL). For more information, see [Parsing XML (C#)](../vs140/parsing-xml--csharp-.md).  
  
-   You can use an \<xref:System.Xml.XmlReader*> to populate the tree. For more information, see \<xref:System.Xml.Linq.XNode.ReadFrom*>.  
  
-   If you have a module that can write content to an \<xref:System.Xml.XmlWriter*>, you can use the \<xref:System.Xml.Linq.XContainer.CreateWriter*> method to create a writer, pass the writer to the module, and then use the content that is written to the \<xref:System.Xml.XmlWriter*> to populate the XML tree.  
  
 However, the most common way to create an XML tree is as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Another very common technique for creating an XML tree involves using the results of a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query to populate an XML tree, as shown in the following example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Serializing XML Trees  
 You can serialize the XML tree to a \<xref:System.IO.File*>, a \<xref:System.IO.TextWriter*>, or an \<xref:System.Xml.XmlWriter*>.  
  
 For more information, see [Serializing XML Trees (C#)](../vs140/serializing-xml-trees--csharp-.md).  
  
### Retrieving XML Data via Axis Methods  
 You can use axis methods to retrieve attributes, child elements, descendant elements, and ancestor elements. [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries operate on axis methods, and provide several flexible and powerful ways to navigate through and process an XML tree.  
  
 For more information, see [LINQ to XML Axes (C#)](../vs140/linq-to-xml-axes--csharp-.md).  
  
### Querying XML Trees  
 You can write [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries that extract data from an XML tree.  
  
 For more information, see [Querying XML Trees (C#)](../vs140/querying-xml-trees--csharp-.md).  
  
### Modifying XML Trees  
 You can modify an element in a variety of ways, including changing its content or attributes. You can also remove an element from its parent.  
  
 For more information, see [Modifying XML Trees (LINQ to XML) (C#)](../vs140/modifying-xml-trees--linq-to-xml---csharp-.md).  
  
## See Also  
 [LINQ to XML Programming Overview (C#)](../vs140/linq-to-xml-programming-overview--csharp-.md)