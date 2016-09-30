---
title: "LINQ to XML Overview (Visual Basic)"
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
ms.assetid: 502661e0-bc5d-438d-94c2-7efb63bb6fbd
caps.latest.revision: 7
---
# LINQ to XML Overview (Visual Basic)
XML has been widely adopted as a way to format data in many contexts. For example, you can find XML on the Web, in configuration files, in Microsoft Office Word files, and in databases.  
  
 [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] is an up-to-date, redesigned approach to programming with XML. It provides the in-memory document modification capabilities of the Document Object Model (DOM), and supports [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query expressions. Although these query expressions are syntactically different from XPath, they provide similar functionality.  
  
## LINQ to XML Developers  
 [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] targets a variety of developers. For an average developer who just wants to get something done, [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] makes XML easier by providing a query experience that is similar to SQL. With just a bit of study, programmers can learn to write succinct and powerful queries in their programming language of choice.  
  
 Professional developers can use [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] to greatly increase their productivity. With [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)], they can write less code that is more expressive, more compact, and more powerful. They can use query expressions from multiple data domains at the same time.  
  
## What Is LINQ to XML?  
 [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] is a LINQ-enabled, in-memory XML programming interface that enables you to work with XML from within the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] programming languages.  
  
 [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] is like the Document Object Model (DOM) in that it brings the XML document into memory. You can query and modify the document, and after you modify it you can save it to a file or serialize it and send it over the Internet. However, [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] differs from DOM: It provides a new object model that is lighter weight and easier to work with, and that takes advantage of language features in Visual Basic.  
  
 The most important advantage of [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] is its integration with [!INCLUDE[vbteclinqext](../vs140/includes/vbteclinqext_md.md)]. This integration enables you to write queries on the in-memory XML document to retrieve collections of elements and attributes. The query capability of [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] is comparable in functionality (although not in syntax) to XPath and XQuery. The integration of [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] in Visual Basic provides stronger typing, compile-time checking, and improved debugger support.  
  
 Another advantage of [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] is the ability to use query results as parameters to \<xref:System.Xml.Linq.XElement*> and \<xref:System.Xml.Linq.XAttribute*> object constructors enables a powerful approach to creating XML trees. This approach, called *functional construction*, enables developers to easily transform XML trees from one shape to another.  
  
 For example, you might have a typical XML purchase order as described in [Sample XML File: Typical Purchase Order (LINQ to XML)](../vs140/sample-xml-file--typical-purchase-order--linq-to-xml-3.md). By using [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)], you could run the following query to obtain the part number attribute value for every item element in the purchase order:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 As another example, you might want a list, sorted by part number, of the items with a value greater than $100. To obtain this information, you could run the following query:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In addition to these [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] capabilities, [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] provides an improved XML programming interface. Using [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)], you can:  
  
-   Load XML from files or streams.  
  
-   Serialize XML to files or streams.  
  
-   Create XML from scratch by using functional construction.  
  
-   Query XML using XPath-like axes.  
  
-   Manipulate the in-memory XML tree by using methods such as \<xref:System.Xml.Linq.XContainer.Add*>, \<xref:System.Xml.Linq.XNode.Remove*>, \<xref:System.Xml.Linq.XNode.ReplaceWith*>, and \<xref:System.Xml.Linq.XElement.SetValue*>.  
  
-   Validate XML trees using XSD.  
  
-   Use a combination of these features to transform XML trees from one shape into another.  
  
## Creating XML Trees  
 IOne of the most significant advantages of programming with [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] is that it is easy to create XML trees. For example, to create a small XML tree, you can write  code as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler translates XML literals into [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] method calls.  
  
 For more information, see [Creating XML Trees (Visual Basic)](../vs140/creating-xml-trees--visual-basic-.md).  
  
## See Also  
 \<xref:System.Xml.Linq*>   
 [Getting Started (LINQ to XML)](../vs140/getting-started--linq-to-xml-1.md)   
 [Overview of LINQ to XML in Visual Basic](../vs140/overview-of-linq-to-xml-in-visual-basic.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)