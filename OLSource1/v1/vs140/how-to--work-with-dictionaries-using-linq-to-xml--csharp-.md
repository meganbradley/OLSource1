---
title: "How to: Work with Dictionaries Using LINQ to XML (C#)"
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
ms.assetid: 57bcefe3-8433-4d3b-935a-511c9bcbdfa8
caps.latest.revision: 7
---
# How to: Work with Dictionaries Using LINQ to XML (C#)
It is often convenient to convert varieties of data structures to XML, and XML back to other data structures. This topic shows a specific implementation of this general approach by converting a \<xref:System.Collections.Generic.Dictionary`2*> to XML and back.  
  
## Example  
 This example uses a form of functional construction in which a query projects new \<xref:System.Xml.Linq.XElement*> objects, and the resulting collection is passed as an argument to the constructor of the Root \<xref:System.Xml.Linq.XElement*> object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following code creates a dictionary from XML.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Projections and Transformations (LINQ to XML) (C#)](../vs140/projections-and-transformations--linq-to-xml---csharp-.md)