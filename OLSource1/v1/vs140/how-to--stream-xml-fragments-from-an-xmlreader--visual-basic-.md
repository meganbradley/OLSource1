---
title: "How to: Stream XML Fragments from an XmlReader (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: f67ce598-4a12-4dcb-9a07-24deca02a111
caps.latest.revision: 7
---
# How to: Stream XML Fragments from an XmlReader (Visual Basic)
When you have to process large XML files, it might not be feasible to load the whole XML tree into memory. This topic shows how to stream fragments using an \<xref:System.Xml.XmlReader*>.  
  
 One of the most effective ways to use an \<xref:System.Xml.XmlReader*> to read \<xref:System.Xml.Linq.XElement*> objects is to write your own custom axis method. An axis method typically returns a collection such as <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>StreamRootChildDoc<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>Child<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>Child` elements, this example would still have a small memory footprint.  
  
## See Also  
 [Walkthrough: Implementing IEnumerable(Of T) in Visual Basic](../vs140/walkthrough--implementing-ienumerable-of-t--in-visual-basic.md)   
 [Parsing XML (Visual Basic)](../vs140/parsing-xml--visual-basic-.md)