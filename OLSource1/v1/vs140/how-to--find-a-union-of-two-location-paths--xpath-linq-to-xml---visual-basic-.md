---
title: "How to: Find a Union of Two Location Paths (XPath-LINQ to XML) (Visual Basic)"
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
ms.assetid: c82c09b4-cb0a-47ec-8cc3-a124144c2788
caps.latest.revision: 5
---
# How to: Find a Union of Two Location Paths (XPath-LINQ to XML) (Visual Basic)
XPath allows you to find the union of the results of two XPath location paths.  
  
 The XPath expression is:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 You can achieve the same results by using the \<xref:System.Linq.Enumerable.Concat*> standard query operator.  
  
## Example  
 This example finds all of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> elements and all of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> elements, and concatenates them into a single collection. Note that the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] query calls \<xref:System.Xml.Linq.Extensions.InDocumentOrder*> to order the results. The results of the XPath expression evaluation are also in document order.  
  
 This example uses the following XML document: [Sample XML File: Numerical Data (LINQ to XML)](../vs140/sample-xml-file--numerical-data--linq-to-xml-2.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML for XPath Users (Visual Basic)](../vs140/linq-to-xml-for-xpath-users--visual-basic-.md)