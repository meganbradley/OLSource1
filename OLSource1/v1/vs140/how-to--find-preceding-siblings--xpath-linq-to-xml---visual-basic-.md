---
title: "How to: Find Preceding Siblings (XPath-LINQ to XML) (Visual Basic)"
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
ms.assetid: 59055718-d0a7-4db3-8901-18dd33587703
caps.latest.revision: 5
---
# How to: Find Preceding Siblings (XPath-LINQ to XML) (Visual Basic)
This topic compares the XPath <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> axis to the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] child \<xref:System.Xml.Linq.XNode.ElementsBeforeSelf*?displayProperty=fullName> axis.  
  
 The XPath expression is:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 Note that the results of both \<xref:System.Xml.XPath.Extensions.XPathSelectElements*> and \<xref:System.Xml.Linq.XNode.ElementsBeforeSelf*?displayProperty=fullName> are in document order.  
  
## Example  
 The following example finds the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element, and then retrieves the previous elements using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> axis.  
  
 This example uses the following XML document: [Sample XML File: Customers and Orders (LINQ to XML)](../vs140/sample-xml-file--customers-and-orders--linq-to-xml-1.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (Visual Basic)](../vs140/linq-to-xml-for-xpath-users--visual-basic-.md)