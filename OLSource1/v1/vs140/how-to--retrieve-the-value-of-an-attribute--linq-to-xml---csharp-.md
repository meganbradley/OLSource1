---
title: "How to: Retrieve the Value of an Attribute (LINQ to XML) (C#)"
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
ms.assetid: 817bbe89-5979-4234-bf0c-46f63692ac8c
caps.latest.revision: 7
---
# How to: Retrieve the Value of an Attribute (LINQ to XML) (C#)
This topic shows how to obtain the value of attributes. There are two main ways: You can cast an \<xref:System.Xml.Linq.XAttribute*> to the desired type; the explicit conversion operator then converts the contents of the element or attribute to the specified type. Alternatively, you can use the \<xref:System.Xml.Linq.XAttribute.Value*> property. However, casting is generally the better approach. If you cast the attribute to a nullable type, the code is simpler to write when retrieving the value of an attribute that might or might not exist. For examples of this technique, see [How to: Retrieve the Value of an Element (LINQ to XML) (C#)](../vs140/how-to--retrieve-the-value-of-an-element--linq-to-xml---csharp-.md).  
  
## Example  
 To retrieve the value of an attribute, you just cast the \<xref:System.Xml.Linq.XAttribute*> object to your desired type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows how to retrieve the value of an attribute where the attribute is in a namespace. For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to XML Axes (C#)](../vs140/linq-to-xml-axes--csharp-.md)