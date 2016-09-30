---
title: "How to: Debug Empty Query Results Sets (C#)"
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
ms.assetid: b569f0dc-425e-45a6-acbf-770fb761c981
caps.latest.revision: 7
---
# How to: Debug Empty Query Results Sets (C#)
One of the most common problems when querying XML trees is that if the XML tree has a default namespace, the developer sometimes writes the query as though the XML were not in a namespace.  
  
 The first set of examples in this topic shows a typical way that XML in a default namespace is loaded, and is queried improperly.  
  
 The second set of examples show the necessary corrections so that you can query XML in a namespace.  
  
 For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
## Example  
 This example shows creation of XML in a namespace, and a query that returns an empty result set.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following result:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This example shows creation of XML in a namespace, and a query that is coded properly.  
  
 The solution is to declare and initialize an \<xref:System.Xml.Linq.XNamespace*> object, and to use it when specifying \<xref:System.Xml.Linq.XName*> objects. In this case, the argument to the \<xref:System.Xml.Linq.XElement.Elements*> method is an \<xref:System.Xml.Linq.XName*> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following result:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Basic Queries (LINQ to XML) (C#)](../vs140/basic-queries--linq-to-xml---csharp-.md)