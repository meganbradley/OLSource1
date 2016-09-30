---
title: "How to: Stream XML Fragments from an XmlReader (C#)"
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
ms.assetid: 4a8f0e45-768a-42e2-bc5f-68bdf0e0a726
caps.latest.revision: 7
---
# How to: Stream XML Fragments from an XmlReader (C#)
When you have to process large XML files, it might not be feasible to load the whole XML tree into memory. This topic shows how to stream fragments using an \<xref:System.Xml.XmlReader*>.  
  
 One of the most effective ways to use an \<xref:System.Xml.XmlReader*> to read \<xref:System.Xml.Linq.XElement*> objects is to write your own custom axis method. An axis method typically returns a collection such as <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>StreamRootChildDoc<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>Child<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>Child` elements, this example would still have a small memory footprint.  
  
## See Also  
 [Parsing XML (C#)](../vs140/parsing-xml--csharp-.md)