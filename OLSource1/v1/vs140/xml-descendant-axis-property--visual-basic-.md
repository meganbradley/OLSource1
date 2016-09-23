---
title: "XML Descendant Axis Property (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vb.XmlPropertyDescendantsAxis
dev_langs: 
  - VB
helpviewer_keywords: 
  - Visual Basic code, accessing XML
  - XML descendant axis property [Visual Basic]
  - descendant axis property [Visual Baisc]
  - XML axis [Visual Basic], descendant
  - XML [Visual Basic], accessing
ms.assetid: a178f85b-5d54-438f-8479-40b62af6fe76
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# XML Descendant Axis Property (Visual Basic)
Provides access to the descendants of the following: an <xref:System.Xml.Linq.XElement?qualifyHint=False> object, an <xref:System.Xml.Linq.XDocument?qualifyHint=False> object, a collection of <xref:System.Xml.Linq.XElement?qualifyHint=False> objects, or a collection of <xref:System.Xml.Linq.XDocument?qualifyHint=False> objects.  
  
## Syntax  
  
```  
  
object...<descendant>  
```  
  
## Parts  
 `object`  
 Required. An <xref:System.Xml.Linq.XElement?qualifyHint=False> object, an <xref:System.Xml.Linq.XDocument?qualifyHint=False> object, a collection of <xref:System.Xml.Linq.XElement?qualifyHint=False> objects, or a collection of <xref:System.Xml.Linq.XDocument?qualifyHint=False> objects.  
  
 ...<  
 Required. Denotes the start of a descendant axis property.  
  
 `descendant`  
 Required. Name of the descendant nodes to access, of the form [`prefix``:`]`name`.  
  
|Part|Description|  
|----------|-----------------|  
|`prefix`|Optional. XML namespace prefix for the descendant node. Must be a global XML namespace that is defined by using an `Imports` statement.|  
|`name`|Required. Local name of the descendant node. See [Names of Declared XML Elements and Attributes](../vs140/names-of-declared-xml-elements-and-attributes--visual-basic-.md).|  
  
 \>  
 Required. Denotes the end of a descendant axis property.  
  
## Return Value  
 A collection of <xref:System.Xml.Linq.XElement?qualifyHint=False> objects.  
  
## Remarks  
 You can use an XML descendant axis property to access descendant nodes by name from an <xref:System.Xml.Linq.XElement?qualifyHint=False> or <xref:System.Xml.Linq.XDocument?qualifyHint=False> object, or from a collection of <xref:System.Xml.Linq.XElement?qualifyHint=False> or <xref:System.Xml.Linq.XDocument?qualifyHint=False> objects. Use the XML `Value` property to access the value of the first descendant node in the returned collection. For more information, see [XML Value Property](../vs140/xml-value-property--visual-basic-.md).  
  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler converts descendant axis properties into calls to the <xref:System.Xml.Linq.XContainer.Descendants?qualifyHint=False> method.  
  
## XML Namespaces  
 The name in a descendant axis property can use only XML namespaces declared globally with the `Imports` statement. It cannot use XML namespaces declared locally within XML element literals. For more information, see [Imports Statement (XML Namespace Prefix)](../vs140/imports-statement--xml-namespace-.md).  
  
## Example  
 The following example shows how to access the value of the first descendant node named `name` and the values of all descendant nodes named `phone` from the `contacts` object.  
  
 [!code[VbXMLSamples#25](../vs140/codesnippet/VisualBasic/xml-descendant-axis-property--visual-basic-_1.vb)]
  
  
 This code displays the following text:  
  
 `Name: Patrick Hines`  
  
 `Home Phone = 206-555-0144`  
  
## Example  
 The following example declares `ns` as an XML namespace prefix. It then uses the prefix of the namespace to create an XML literal and access the value of the first child node with the qualified name `ns:name`.  
  
 [!code[VbXMLSamples#26](../vs140/codesnippet/VisualBasic/xml-descendant-axis-property--visual-basic-_2.vb)]
  
  
 This code displays the following text:  
  
 `Name: Patrick Hines`  
  
## See Also  
 <xref:System.Xml.Linq.XElement?qualifyHint=False>   
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)   
 [Names of Declared XML Elements and Attributes](../vs140/names-of-declared-xml-elements-and-attributes--visual-basic-.md)