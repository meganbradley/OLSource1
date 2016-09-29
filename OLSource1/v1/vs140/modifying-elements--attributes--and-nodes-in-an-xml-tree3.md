---
title: "Modifying Elements, Attributes, and Nodes in an XML Tree3"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Modifying Elements, Attributes, and Nodes in an XML Tree"
dev_langs: 
  - "CSharp"
ms.assetid: 0ed22e4e-4c6b-4eb1-b0eb-06685efd8c33
caps.latest.revision: 5
---
# Modifying Elements, Attributes, and Nodes in an XML Tree3
The following table summarizes the methods and properties that you can use to modify an element, its child elements, or its attributes.  
  
 The following methods modify an <xref:System.Xml.Linq.XElement*>.  
  
|Method|Description|  
|------------|-----------------|  
|<xref:System.Xml.Linq.XElement.Parse*?displayProperty=fullName>|Replaces an element with parsed XML.|  
|<xref:System.Xml.Linq.XElement.RemoveAll*?displayProperty=fullName>|Removes all content (child nodes and attributes) of an element.|  
|<xref:System.Xml.Linq.XElement.RemoveAttributes*?displayProperty=fullName>|Removes the attributes of an element.|  
|<xref:System.Xml.Linq.XElement.ReplaceAll*?displayProperty=fullName>|Replaces all content (child nodes and attributes) of an element.|  
|<xref:System.Xml.Linq.XElement.ReplaceAttributes*?displayProperty=fullName>|Replaces the attributes of an element.|  
|<xref:System.Xml.Linq.XElement.SetAttributeValue*?displayProperty=fullName>|Sets the value of an attribute. Creates the attribute if it doesn't exist. If the value is set to `null`, removes the attribute.|  
|<xref:System.Xml.Linq.XElement.SetElementValue*?displayProperty=fullName>|Sets the value of a child element. Creates the element if it doesn't exist. If the value is set to `null`, removes the element.|  
|<xref:System.Xml.Linq.XElement.Value*?displayProperty=fullName>|Replaces the content (child nodes) of an element with the specified text.|  
|<xref:System.Xml.Linq.XElement.SetValue*?displayProperty=fullName>|Sets the value of an element.|  
  
 The following methods modify an <xref:System.Xml.Linq.XAttribute*>.  
  
|Method|Description|  
|------------|-----------------|  
|<xref:System.Xml.Linq.XAttribute.Value*?displayProperty=fullName>|Sets the value of an attribute.|  
|<xref:System.Xml.Linq.XAttribute.SetValue*?displayProperty=fullName>|Sets the value of an attribute.|  
  
 The following methods modify an <xref:System.Xml.Linq.XNode*> (including an <xref:System.Xml.Linq.XElement*> or <xref:System.Xml.Linq.XDocument*>).  
  
|Method|Description|  
|------------|-----------------|  
|<xref:System.Xml.Linq.XNode.ReplaceWith*?displayProperty=fullName>|Replaces a node with new content.|  
  
 The following methods modify an <xref:System.Xml.Linq.XContainer*> (an <xref:System.Xml.Linq.XElement*> or <xref:System.Xml.Linq.XDocument*>).  
  
|Method|Description|  
|------------|-----------------|  
|<xref:System.Xml.Linq.XContainer.ReplaceNodes*?displayProperty=fullName>|Replaces the children nodes with new content.|  
  
## See Also  
 [Modifying XML Trees (LINQ to XML) (C#)](../vs140/modifying-xml-trees--linq-to-xml---csharp-.md)