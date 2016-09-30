---
title: "How to: Find All Nodes in a Namespace (C#)"
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
ms.assetid: 3a38b913-a53e-4d0e-a19d-8782bffd3364
caps.latest.revision: 7
---
# How to: Find All Nodes in a Namespace (C#)
You can filter on the namespace of each element or attribute to find all nodes in that particular namespace.  
  
## Example  
 The following example creates an XML tree with two namespaces. It then iterates through the tree and prints the names of all the elements and attributes in one of those namespaces.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The XML file accessed by the following query contains purchase orders in two different namespaces. The query creates a new tree with just the elements in one of the namespaces.  
  
 This example uses the following XML document: [Sample XML File: Consolidated Purchase Orders](../vs140/sample-xml-file--consolidated-purchase-orders2.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Basic Queries (LINQ to XML) (C#)](../vs140/basic-queries--linq-to-xml---csharp-.md)