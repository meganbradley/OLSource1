---
title: "XML Value Property (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.XmlPropertyExtensionValue"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Value property [Visual Basic]"
  - "Visual Basic code, accessing XML"
  - "XML axis [Visual Basic], Value"
  - "XML Value property [Visual Basic]"
ms.assetid: 7ddd057a-a195-4e9b-ad8b-2ee0e615a20f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML Value Property (Visual Basic)
Provides access to the value of the first element of a collection of \<xref:System.Xml.Linq.XElement*> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required. Collection of \<xref:System.Xml.Linq.XElement*> objects.|  
  
## Return Value  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that contains the value of the first element of the collection, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the collection is empty.  
  
## Remarks  
 The \<xref:System.Xml.Linq.XElement.Value*> property makes it easy to access the value of the first element in a collection of \<xref:System.Xml.Linq.XElement*> objects. This property first checks whether the collection contains at least one object. If the collection is empty, this property returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Otherwise, this property returns the value of the \<xref:System.Xml.Linq.XElement.Value*> property of the first element in the collection.  
  
> [!NOTE]
>  When you access the value of an XML attribute using the '@' identifier, the attribute value is returned as a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and you do not need to explicitly specify the \<xref:System.Xml.Linq.XAttribute.Value*> property.  
  
 To access other elements in a collection, you can use the XML extension indexer property. For more information, see [XML Extension Indexer Property](../vs140/extension-indexer-property--visual-basic-.md).  
  
## Inheritance  
 Most users will not have to implement <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>IEnumerable(Of XElement)<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>IEnumerable(Of XElement)<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>phone<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>contact<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>Phone number: 206-555-0144<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>type<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>phone<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>home<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## See Also  
 \<xref:System.Xml.Linq.XElement*>   
 \<xref:System.Collections.Generic.IEnumerable`1*>   
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)   
 [Extension Methods (Visual Basic)](../vs140/extension-methods--visual-basic-.md)   
 [XML Extension Indexer Property](../vs140/extension-indexer-property--visual-basic-.md)   
 [XML Child Axis Property](../vs140/xml-child-axis-property--visual-basic-.md)   
 [XML Attribute Axis Property](../vs140/xml-attribute-axis-property--visual-basic-.md)