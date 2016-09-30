---
title: "Extension Indexer Property (Visual Basic)"
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
  - "vb.XmlPropertyExtensionIndexer"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Visual Basic code, accessing XML"
  - "XML extension indexer [Visual Basic]"
  - "extension indexer [Visual Basic]"
  - "XML [Visual Basic], accessing"
ms.assetid: a16a4b13-54be-432c-82b3-a87091464ada
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Extension Indexer Property (Visual Basic)
Provides access to individual elements in a collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required. A queryable collection. That is, a collection that implements <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>1*>.|  
|(|Required. Denotes the start of the indexer property.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required. An integer expression that specifies the zero-based position of an element of the collection.|  
|)|Required. Denotes the end of the indexer property.|  
  
## Return Value  
 The object from the specified location in the collection, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the index is out of range.  
  
## Remarks  
 You can use the extension indexer property to access individual elements in a collection. This indexer property is typically used on the output of XML axis properties. The XML child and XML descendent axis properties return collections of \<xref:System.Xml.Linq.XElement*> objects or an attribute value.  
  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler converts extension indexer properties to calls to the<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method. Unlike an array indexer, the<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the index is out of range. This behavior is useful when you cannot easily determine the number of elements in a collection.  
  
 This indexer property is like an extension property for collections that implement <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>1*>: it is used only if the collection does not have an indexer or a default property.  
  
 To access the value of the first element in a collection of \<xref:System.Xml.Linq.XElement*> or \<xref:System.Xml.Linq.XAttribute*> objects, you can use the XML <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> property. For more information, see [XML Value Property](../vs140/xml-value-property--visual-basic-.md).  
  
## Example  
 The following example shows how to use the extension indexer to access the second child node in a collection of \<xref:System.Xml.Linq.XElement*> objects. The collection is accessed by using the child axis property, which gets all child elements named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
 [!code[VbXMLSamples#24](../vs140/codesnippet/VisualBasic/extension-indexer-property--visual-basic-_1.vb)]  
  
 This code displays the following text:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## See Also  
 \<xref:System.Xml.Linq.XElement*>   
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)   
 [XML Value Property](../vs140/xml-value-property--visual-basic-.md)