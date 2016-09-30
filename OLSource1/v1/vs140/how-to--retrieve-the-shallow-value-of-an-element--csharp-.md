---
title: "How to: Retrieve the Shallow Value of an Element (C#)"
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
ms.assetid: 924a2699-72f6-4be1-aaa6-de62f8ec73b9
caps.latest.revision: 7
---
# How to: Retrieve the Shallow Value of an Element (C#)
This topic shows how to get the shallow value of an element. The shallow value is the value of the specific element only, as opposed to the deep value, which includes the values of all descendent elements concatenated into a single string.  
  
 When you retrieve an element value by using either casting or the \<xref:System.Xml.Linq.XElement.Value*?displayProperty=fullName> property, you retrieve the deep value. To retrieve the shallow value, you can use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> extension method, as shown in the follwing example. Retrieving the shallow value is useful when you want to select elements based on their content.  
  
 The following example declares an extension method that retrieves the shallow value of an element. It then uses the extension method in a query to list all elements that contain a calculated value.  
  
## Example  
 The following text file, Report.xml, is the source for this example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML Axes (C#)](../vs140/linq-to-xml-axes--csharp-.md)