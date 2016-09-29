---
title: "Overview of LINQ to XML in Visual Basic"
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
  - "LINQ to XML [Visual Basic], about LINQ to XML"
  - "LINQ [Visual Basic], LINQ to XML"
ms.assetid: 01c62a79-6d58-468e-84fb-039c05947701
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overview of LINQ to XML in Visual Basic
[!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] provides support for [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] through XML literals and XML axis properties. This enables you to use a familiar, convenient syntax for working with XML in your [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] code. *XML literals* enable you to include XML directly in your code. *XML axis properties* enable you to access child nodes, descendant nodes, and attributes of an XML literal. For more information, see [XML Literals Overview](../vs140/xml-literals-overview--visual-basic-.md) and [Accessing XML in Visual Basic](../vs140/accessing-xml-in-visual-basic.md).  
  
 [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] is an in-memory XML programming API designed specifically to take advantage of [!INCLUDE[vbteclinqext](../vs140/includes/vbteclinqext_md.md)]. Although you can call the [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] APIs directly, only [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] enables you to declare XML literals and directly access XML axis properties.  
  
> [!NOTE]
>  XML literals and XML axis properties are not supported in declarative code in an ASP.NET page. To use Visual Basic XML features, put your code in a code-behind page in your ASP.NET application.  
  
 ![link to video](../vs140/media/playvideo.gif "PlayVideo") For related video demonstrations, see [How Do I Get Started with LINQ to XML?](http://go.microsoft.com/fwlink/?LinkId=143034) and [How Do I Create Excel Spreadsheets using LINQ to XML?](http://go.microsoft.com/fwlink/?LinkId=143536).  
  
## Creating XML  
 There are two ways to create XML trees in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]. You can declare an XML literal directly in code, or you can use the [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] APIs to create the tree. Both processes enable the code to reflect the final structure of the XML tree. For example, the following code example creates an XML element:  
  
 [!code[VbXmlSamples#5](../vs140/codesnippet/VisualBasic/overview-of-linq-to-xml-in-visual-basic_1.vb)]  
  
 For more information, see [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md).  
  
## Accessing and Navigating XML  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] provides XML axis properties for accessing and navigating XML structures. These properties enable you to access XML elements and attributes by specifying the XML child element names. Alternatively, you can explicitly call the [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] methods for navigating and locating elements and attributes. For example, the following code example uses XML axis properties to refer to the attributes and child elements of an XML element. The code example uses a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query to retrieve child elements and output them as XML elements, effectively performing a transform.  
  
 [!code[VbXmlSamples#8](../vs140/codesnippet/VisualBasic/overview-of-linq-to-xml-in-visual-basic_2.vb)]  
  
 For more information, see [Accessing XML in Visual Basic](../vs140/accessing-xml-in-visual-basic.md).  
  
## XML Namespaces  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] enables you to specify an alias to a global XML namespace by using the `Imports` statement. The following example shows how to use the `Imports` statement to import an XML namespace:  
  
 [!code[VbXMLSamples#1](../vs140/codesnippet/VisualBasic/overview-of-linq-to-xml-in-visual-basic_3.vb)]  
  
 You can use an XML namespace alias when you access XML axis properties and declare XML literals for XML documents and elements.  
  
 You can retrieve an <xref:System.Xml.Linq.XNamespace*> object for a particular namespace prefix by using the [GetXmlNamespace Operator](../vs140/getxmlnamespace-operator--visual-basic-.md).  
  
 For more information, see [Imports Statement (XML Namespace)](../vs140/imports-statement--xml-namespace-.md).  
  
### Using XML Namespaces in XML Literals  
 The following example shows how to create an <xref:System.Xml.Linq.XElement*> object that uses the global namespace `ns`:  
  
 [!code[VbXMLSamples#2](../vs140/codesnippet/VisualBasic/overview-of-linq-to-xml-in-visual-basic_4.vb)]  
  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler translates XML literals that contain XML namespace aliases into equivalent code that uses the XML notation for using XML namespaces, with the `xmlns` attribute. When compiled, the code in the previous section's example produces essentially the same executable code as the following example:  
  
 [!code[VbXMLSamples#3](../vs140/codesnippet/VisualBasic/overview-of-linq-to-xml-in-visual-basic_5.vb)]  
  
### Using XML Namespaces in XML Axis Properties  
 XML namespaces declared in XML literals are not available for use in XML axis properties. However, global namespaces can be used with the XML axis properties. Use a colon to separate the XML namespace prefix from the local element name. Following is an example:  
  
 [!code[VbXMLSamples#4](../vs140/codesnippet/VisualBasic/overview-of-linq-to-xml-in-visual-basic_6.vb)]  
  
## See Also  
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)   
 [Creating XML Trees in Visual Basic](../vs140/creating-xml-in-visual-basic.md)   
 [Accessing XML Elements with Visual Basic](../vs140/accessing-xml-in-visual-basic.md)   
 [Manipulating XML in Visual Basic](../vs140/manipulating-xml-in-visual-basic.md)