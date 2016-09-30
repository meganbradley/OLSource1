---
title: "How to: Query LINQ to XML Using XPath (Visual Basic)"
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
ms.assetid: e1f69a20-1efa-452d-9089-c472fa84b3d5
caps.latest.revision: 5
---
# How to: Query LINQ to XML Using XPath (Visual Basic)
This topic introduces the extension methods that enable you to query an XML tree by using XPath. For detailed information about using these extension methods, see \<xref:System.Xml.XPath.Extensions*?displayProperty=fullName>.  
  
 Unless you have a very specific reason for querying using XPath, such as extensive use of legacy code, using XPath with LINQ to XML is not recommended. XPath queries will not perform as well as [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] queries.  
  
## Example  
 The following example creates a small XML tree and uses \<xref:System.Xml.XPath.Extensions.XPathSelectElements*> to select a set of elements.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Advanced Query Techniques (LINQ to XML) (Visual Basic)](../vs140/advanced-query-techniques--linq-to-xml---visual-basic-.md)