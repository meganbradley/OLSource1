---
title: "How to: Project an Object Graph (C#)"
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
ms.assetid: 293d15d5-3eaf-48de-9a02-3e13cb117b5b
caps.latest.revision: 7
---
# How to: Project an Object Graph (C#)
This topic illustrates how to project, or populate, an object graph from XML.  
  
## Example  
 The following code populates an object graph with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> classes from the [Sample XML File: Typical Purchase Order (LINQ to XML)](../vs140/sample-xml-file--typical-purchase-order--linq-to-xml-1.md) XML document.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the result of the [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query is returned as an <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>PurchaseOrderItem<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>PurchaseOrder<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>1*> of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The code uses the \<xref:System.Linq.Enumerable.ToList*> extension method to create a \<xref:System.Collections.Generic.List`1*> collection from the results of the query.  
  
 The example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Linq.Enumerable.Select*>   
 \<xref:System.Linq.Enumerable.ToList*>   
 [Projections and Transformations (LINQ to XML) (C#)](../vs140/projections-and-transformations--linq-to-xml---csharp-.md)