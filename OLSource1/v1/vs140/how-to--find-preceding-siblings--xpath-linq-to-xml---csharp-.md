---
title: "How to: Find Preceding Siblings (XPath-LINQ to XML) (C#)"
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
ms.assetid: b281ff99-d08a-43d0-bea1-eff831b2f8ae
caps.latest.revision: 5
---
# How to: Find Preceding Siblings (XPath-LINQ to XML) (C#)
This topic compares the XPath <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> axis to the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] child \<xref:System.Xml.Linq.XNode.ElementsBeforeSelf*?displayProperty=fullName> axis.  
  
 The XPath expression is:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 Note that the results of both \<xref:System.Xml.XPath.Extensions.XPathSelectElements*> and \<xref:System.Xml.Linq.XNode.ElementsBeforeSelf*?displayProperty=fullName> are in document order.  
  
## Example  
 The following example finds the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element, and then retrieves the previous elements using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> axis.  
  
 This example uses the following XML document: [Sample XML File: Customers and Orders (LINQ to XML)](../vs140/sample-xml-file--customers-and-orders--linq-to-xml-2.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (C#)](../vs140/linq-to-xml-for-xpath-users--csharp-.md)