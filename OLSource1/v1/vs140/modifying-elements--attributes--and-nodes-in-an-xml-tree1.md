---
title: "Modifying Elements, Attributes, and Nodes in an XML Tree1"
ms.custom: na
ms.date: 09/22/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
H1: Modifying Elements, Attributes, and Nodes in an XML Tree
dev_langs: 
  - VB
ms.assetid: 865cf54e-f8ac-4871-863b-a3e6fc61a4b9
caps.latest.revision: 7
---
# Modifying Elements, Attributes, and Nodes in an XML Tree1
The following table summarizes the methods and properties that you can use to modify an element, its child elements, or its attributes.  
  
 The following methods modify an <xref:System.Xml.Linq.XElement?qualifyHint=False>.  
  
|Method|Description|  
|------------|-----------------|  
|<xref:System.Xml.Linq.XElement.Parse?qualifyHint=True>|Replaces an element with parsed XML.|  
|<xref:System.Xml.Linq.XElement.RemoveAll?qualifyHint=True>|Removes all content (child nodes and attributes) of an element.|  
|<xref:System.Xml.Linq.XElement.RemoveAttributes?qualifyHint=True>|Removes the attributes of an element.|  
|<xref:System.Xml.Linq.XElement.ReplaceAll?qualifyHint=True>|Replaces all content (child nodes and attributes) of an element.|  
|<xref:System.Xml.Linq.XElement.ReplaceAttributes?qualifyHint=True>|Replaces the attributes of an element.|  
|<xref:System.Xml.Linq.XElement.SetAttributeValue?qualifyHint=True>|Sets the value of an attribute. Creates the attribute if it doesn't exist. If the value is set to `null`, removes the attribute.|  
|<xref:System.Xml.Linq.XElement.SetElementValue?qualifyHint=True>|Sets the value of a child element. Creates the element if it doesn't exist. If the value is set to `null`, removes the element.|  
|<xref:System.Xml.Linq.XElement.Value?qualifyHint=True>|Replaces the content (child nodes) of an element with the specified text.|  
|<xref:System.Xml.Linq.XElement.SetValue?qualifyHint=True>|Sets the value of an element.|  
  
 The following methods modify an <xref:System.Xml.Linq.XAttribute?qualifyHint=False>.  
  
|Method|Description|  
|------------|-----------------|  
|<xref:System.Xml.Linq.XAttribute.Value?qualifyHint=True>|Sets the value of an attribute.|  
|<xref:System.Xml.Linq.XAttribute.SetValue?qualifyHint=True>|Sets the value of an attribute.|  
  
 The following methods modify an <xref:System.Xml.Linq.XNode?qualifyHint=False> (including an <xref:System.Xml.Linq.XElement?qualifyHint=False> or <xref:System.Xml.Linq.XDocument?qualifyHint=False>).  
  
|Method|Description|  
|------------|-----------------|  
|<xref:System.Xml.Linq.XNode.ReplaceWith?qualifyHint=True>|Replaces a node with new content.|  
  
 The following methods modify an <xref:System.Xml.Linq.XContainer?qualifyHint=False> (an <xref:System.Xml.Linq.XElement?qualifyHint=False> or <xref:System.Xml.Linq.XDocument?qualifyHint=False>).  
  
|Method|Description|  
|------------|-----------------|  
|<xref:System.Xml.Linq.XContainer.ReplaceNodes?qualifyHint=True>|Replaces the children nodes with new content.|  
  
## See Also  
 [Modifying XML Trees (LINQ to XML) (Visual Basic)](../vs140/modifying-xml-trees--linq-to-xml---visual-basic-.md)