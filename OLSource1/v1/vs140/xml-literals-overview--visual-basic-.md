---
title: "XML Literals Overview (Visual Basic)"
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
  - "XML literals [Visual Basic], about XML literals"
  - "declaring XML literals [Visual Basic]"
  - "LINQ to XML [Visual Basic], XML literals"
  - "literals [Visual Basic], XML"
ms.assetid: 37987c15-4ab8-471b-bd45-399816bfb57f
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML Literals Overview (Visual Basic)
An *XML literal* allows you to incorporate XML directly into your [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] code. The XML literal syntax represents [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] objects, and it is the similar to the XML 1.0 syntax. This makes it easier to create XML elements and documents programmatically because your code has the same structure as the final XML.  
  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiles XML literals into [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] objects. [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] provides a simple object model for creating and manipulating XML, and this model integrates well with [!INCLUDE[vbteclinqext](../vs140/includes/vbteclinqext_md.md)]. For more information, see \<xref:System.Xml.Linq.XElement*>.  
  
 You can embed a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] expression in an XML literal. At run time, your application creates a [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] object for each literal, incorporating the values of the embedded expressions. This lets you specify dynamic content inside an XML literal. For more information, see [Embedded Expressions in XML](../vs140/embedded-expressions-in-xml--visual-basic-.md).  
  
 For more information about the differences between the XML literal syntax and the XML 1.0 syntax, see [XML Literals and the XML 1.0 Specification](../vs140/xml-literals-and-the-xml-1.0-specification--visual-basic-.md).  
  
## Simple Literals  
 You can create a [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] object in your [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] code by typing or pasting in valid XML. An XML element literal returns an \<xref:System.Xml.Linq.XElement*> object. For more information, see [XML Element Literal](../vs140/xml-element-literal--visual-basic-.md) and [XML Literals and the XML 1.0 Specification](../vs140/xml-literals-and-the-xml-1.0-specification--visual-basic-.md). The following example creates an XML element that has several child elements.  
  
 [!code[VbXMLSamples#5](../vs140/codesnippet/VisualBasic/xml-literals-overview--visual-basic-_1.vb)]  
  
 You can create an XML document by starting an XML literal with `<?xml version="1.0"?>`, as shown in the following example. An XML document literal returns an \<xref:System.Xml.Linq.XDocument*> object. For more information, see [XML Document Literal](../vs140/xml-document-literal--visual-basic-.md).  
  
 [!code[VbXMLSamples#6](../vs140/codesnippet/VisualBasic/xml-literals-overview--visual-basic-_2.vb)]  
  
> [!NOTE]
>  The XML literal syntax in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] is not identical to the syntax in the XML 1.0 specification. For more information, see [XML Literals and the XML 1.0 Specification](../vs140/xml-literals-and-the-xml-1.0-specification--visual-basic-.md).  
  
## Line Continuation  
 An XML literal can span multiple lines without using line continuation characters (the space-underscore-enter sequence). This makes it easier to compare XML literals in code with XML documents.  
  
 The compiler treats line continuation characters as part of an XML literal. Therefore, you should use the space-underscore-enter sequence only when it belongs in the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] object.  
  
 However, you do need line continuation characters if you have a multiline expression in an embedded expression. For more information, see [Embedded Expressions In XML](../vs140/embedded-expressions-in-xml--visual-basic-.md).  
  
## Embedding Queries in XML Literals  
 You can use a query in an embedded expression. When you do this, the elements returned by the query are added to the XML element. This lets you add dynamic content, such as the result of a user's query, to an XML literal.  
  
 For example, the following code uses an embedded query to create XML elements from the members of the `phoneNumbers2` array and then add those elements as children of `contact2`.  
  
 [!code[VbXMLSamples#7](../vs140/codesnippet/VisualBasic/xml-literals-overview--visual-basic-_3.vb)]  
  
## How the Compiler Creates Objects from XML Literals  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler translates XML literals into calls to the equivalent [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] constructors to build up the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] object. For example, the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler will translate the following code example into a call to the \<xref:System.Xml.Linq.XProcessingInstruction*> constructor for the XML version instruction, calls to the \<xref:System.Xml.Linq.XElement*> constructor for the `<contact>`, `<name>`, and `<phone>` elements, and calls to the \<xref:System.Xml.Linq.XAttribute*> constructor for the `type` attribute. Specifically, given the attributes in the following sample, the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler will call the \<xref:System.Xml.Linq.XAttribute.#ctor(System.Xml.Linq.XName,System.Object)> constructor twice. The first will pass the value `type` for the `name` parameter and the value `home` for the `value` parameter. The second will also pass the value `type` for the `name` parameter, but the value `work` for the `value` parameter.  
  
 [!code[VbXMLSamples#6](../vs140/codesnippet/VisualBasic/xml-literals-overview--visual-basic-_2.vb)]  
  
## See Also  
 \<xref:System.Xml.Linq.XElement*>   
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)   
 [Embedded Expressions in XML](../vs140/embedded-expressions-in-xml--visual-basic-.md)   
 [XML Document Literal](../vs140/xml-document-literal--visual-basic-.md)   
 [XML Element Literal](../vs140/xml-element-literal--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)