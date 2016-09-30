---
title: "How to: Find a Union of Two Location Paths (XPath-LINQ to XML) (C#)"
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
ms.assetid: 069622d3-2b58-4919-8903-710a564c0788
caps.latest.revision: 7
---
# How to: Find a Union of Two Location Paths (XPath-LINQ to XML) (C#)
XPath allows you to find the union of the results of two XPath location paths.  
  
 The XPath expression is:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 You can achieve the same results by using the \<xref:System.Linq.Enumerable.Concat*> standard query operator.  
  
## Example  
 This example finds all of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> elements and all of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> elements, and concatenates them into a single collection. Note that the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] query calls \<xref:System.Xml.Linq.Extensions.InDocumentOrder*> to order the results. The results of the XPath expression evaluation are also in document order.  
  
 This example uses the following XML document: [Sample XML File: Numerical Data (LINQ to XML)](../vs140/sample-xml-file--numerical-data--linq-to-xml-3.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (C#)](../vs140/linq-to-xml-for-xpath-users--csharp-.md)