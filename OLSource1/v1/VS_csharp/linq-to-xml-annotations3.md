---
title: "LINQ to XML Annotations3"
ms.custom: na
ms.date: "10/03/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "LINQ to XML Annotations"
dev_langs: 
  - "CSharp"
ms.assetid: 54e7b9d0-07f5-488f-9065-b6e6b870f810
caps.latest.revision: 3
ms.author: "shoag"
manager: "wpickett"
---
# LINQ to XML Annotations3
Annotations in [!INCLUDE[sqltecxlinq](../VS_csharp/includes/sqltecxlinq_md.md)] enable you to associate any arbitrary object of any arbitrary type with any XML component in an XML tree.  
  
 To add an annotation to an XML component, such as an \<xref:System.Xml.Linq.XElement> or \<xref:System.Xml.Linq.XAttribute>, you call the \<xref:System.Xml.Linq.XObject.AddAnnotation*> method. You retrieve annotations by type.  
  
 Note that annotations are not part of the XML infoset; they are not serialized or deserialized.  
  
## Methods  
 You can use the following methods when working with annotations:  
  
|Method|Description|  
|------------|-----------------|  
|\<xref:System.Xml.Linq.XObject.AddAnnotation*>|Adds an object to the annotation list of an \<xref:System.Xml.Linq.XObject>.|  
|\<xref:System.Xml.Linq.XObject.Annotation*>|Gets the first annotation object of the specified type from an \<xref:System.Xml.Linq.XObject>.|  
|\<xref:System.Xml.Linq.XObject.Annotations*>|Gets a collection of annotations of the specified type for an \<xref:System.Xml.Linq.XObject>.|  
|\<xref:System.Xml.Linq.XObject.RemoveAnnotations*>|Removes the annotations of the specified type from an \<xref:System.Xml.Linq.XObject>.|  
  
## See Also  
 [Advanced LINQ to XML Programming (C#)](../VS_csharp/advanced-linq-to-xml-programming--csharp-.md)