---
title: "Querying an XDocument vs. Querying an XElement (C#)"
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
ms.assetid: 46221ff5-62ee-4de8-93ba-66465facb5c1
caps.latest.revision: 3
---
# Querying an XDocument vs. Querying an XElement (C#)
When you load a document via \<xref:System.Xml.Linq.XDocument.Load*?displayProperty=fullName>, you will notice that you have to write queries slightly differently than when you load via \<xref:System.Xml.Linq.XElement.Load*?displayProperty=fullName>.  
  
## Comparison of XDocument.Load and XElement.Load  
 When you load an XML document into an \<xref:System.Xml.Linq.XElement*> via \<xref:System.Xml.Linq.XElement.Load*?displayProperty=fullName>, the \<xref:System.Xml.Linq.XElement*> at the root of the XML tree contains the root element of the loaded document. However, when you load the same XML document into an \<xref:System.Xml.Linq.XDocument*> via \<xref:System.Xml.Linq.XDocument.Load*?displayProperty=fullName>, the root of the tree is an \<xref:System.Xml.Linq.XDocument*> node, and the root element of the loaded document is the one allowed child \<xref:System.Xml.Linq.XElement*> node of the \<xref:System.Xml.Linq.XDocument*>. The [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] axes operate relative to the root node.  
  
 This first example loads an XML tree using \<xref:System.Xml.Linq.XElement.Load*>. It then queries for the child elements of the root of the tree.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 As expected, this example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following example is the same as the one above, with the exception that the XML tree is loaded into an \<xref:System.Xml.Linq.XDocument*> instead of an \<xref:System.Xml.Linq.XElement*>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Notice that the same query returned the one <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> node instead of the three child nodes.  
  
 One approach to dealing with this is to use the \<xref:System.Xml.Linq.XDocument.Root*> property before accessing the axes methods, as follows:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This query now performs in the same way as the query on the tree rooted in \<xref:System.Xml.Linq.XElement*>. The example produces the following output:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Basic Queries (LINQ to XML) (C#)](../vs140/basic-queries--linq-to-xml---csharp-.md)