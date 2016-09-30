---
title: "Maintaining Name-Value Pairs (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Maintaining Name/Value Pairs (C#)"
dev_langs: 
  - "CSharp"
ms.assetid: 7b04b0f1-af64-42eb-8737-83f8861b5915
caps.latest.revision: 7
---
# Maintaining Name-Value Pairs (C#)
Many applications have to maintain information that is best kept as name/value pairs. This information might be configuration information or global settings. [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] contains some methods that make it easy to keep a set of name/value pairs. You can either keep the information as attributes or as a set of child elements.  
  
 One difference between keeping the information as attributes or as child elements is that attributes have the constraint that there can be only one attribute with a particular name for an element. This limitation does not apply to child elements.  
  
## SetAttributeValue and SetElementValue  
 The two methods that facilitate keeping name/value pairs are \<xref:System.Xml.Linq.XElement.SetAttributeValue*> and \<xref:System.Xml.Linq.XElement.SetElementValue*>. These two methods have similar semantics.  
  
 \<xref:System.Xml.Linq.XElement.SetAttributeValue*> can add, modify, or remove attributes of an element.  
  
-   If you call \<xref:System.Xml.Linq.XElement.SetAttributeValue*> with a name of an attribute that does not exist, the method creates a new attribute and adds it to the specified element.  
  
-   If you call \<xref:System.Xml.Linq.XElement.SetAttributeValue*> with a name of an existing attribute and with some specified content, the contents of the attribute are replaced with the specified content.  
  
-   If you call \<xref:System.Xml.Linq.XElement.SetAttributeValue*> with a name of an existing attribute, and specify null for the content, the attribute is removed from its parent.  
  
 \<xref:System.Xml.Linq.XElement.SetElementValue*> can add, modify, or remove child elements of an element.  
  
-   If you call \<xref:System.Xml.Linq.XElement.SetElementValue*> with a name of a child element that does not exist, the method creates a new element and adds it to the specified element.  
  
-   If you call \<xref:System.Xml.Linq.XElement.SetElementValue*> with a name of an existing element and with some specified content, the contents of the element are replaced with the specified content.  
  
-   If you call \<xref:System.Xml.Linq.XElement.SetElementValue*> with a name of an existing element, and specify null for the content, the element is removed from its parent.  
  
## Example  
 The following example creates an element with no attributes. It then uses the \<xref:System.Xml.Linq.XElement.SetAttributeValue*> method to create and maintain a list of name/value pairs.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example creates an element with no child elements. It then uses the \<xref:System.Xml.Linq.XElement.SetElementValue*> method to create and maintain a list of name/value pairs.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Xml.Linq.XElement.SetAttributeValue*>   
 \<xref:System.Xml.Linq.XElement.SetElementValue*>   
 [Modifying XML Trees (LINQ to XML) (C#)](../vs140/modifying-xml-trees--linq-to-xml---csharp-.md)