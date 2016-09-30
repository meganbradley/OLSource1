---
title: "Accessing XML in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "LINQ to XML [Visual Basic], accessing XML"
  - "Visual Basic code, XML"
  - "accessing XML [Visual Basic], axis properties"
  - "XML [Visual Basic], axis properties"
  - "XML [Visual Basic], accessing"
ms.assetid: c47f88b2-3cbc-4bb1-b4b9-be60f71ffc6a
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Accessing XML in Visual Basic
[!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] provides XML axis properties for accessing and navigating [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] structures. These properties use a special syntax to enable you to access elements and attributes by specifying the XML names.  
  
 The following table lists the language features that enable you to access XML elements and attributes in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
### XML Axis Properties  
  
|Property description|Example|Description|  
|--------------------------|-------------|-----------------|  
|*child axis*|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|Gets all <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> elements that are child elements of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element.|  
|*attribute axis*|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Gets all <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attributes of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element.|  
|*descendant axis*|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Gets all <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> elements of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element, regardless of how deep in the hierarchy they occur.|  
|*extension indexer*|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Gets the first <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element from the sequence.|  
|*value*|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Gets the string representation of the first object in the sequence, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the sequence is empty.|  
  
## In This Section  
 [How to: Access XML Descendant Elements (Visual Basic)](../vs140/how-to--access-xml-descendant-elements--visual-basic-.md)  
 Shows how to use a descendant axis property to access all XML elements that have a specified name and that are contained under a specified XML element.  
  
 [How to: Access XML Child Elements (Visual Basic)](../vs140/how-to--access-xml-child-elements--visual-basic-.md)  
 Shows how to use a child axis property to access all XML child elements that have a specified name in an XML element.  
  
 [How to: Access XML Attributes (Visual Basic)](../vs140/how-to--access-xml-attributes--visual-basic-.md)  
 Shows how to use an attribute axis property to access all XML attributes that have a specified name in an XML element.  
  
 [How to: Declare and Use XML Namespace Prefixes](../vs140/how-to--declare-and-use-xml-namespace-prefixes--visual-basic-.md)  
 Shows how to declare an XML namespace prefix and use it to create and access XML elements.  
  
## Related Sections  
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)  
 Provides links to sections describing the various XML access properties.  
  
 [Overview of LINQ over XML in Visual Basic](../vs140/overview-of-linq-to-xml-in-visual-basic.md)  
 Provides an introduction to using [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] in Visual Basic.  
  
 [Creating XML in Visual Basic](../vs140/creating-xml-in-visual-basic.md)  
 Provides an introduction to using XML literals in Visual Basic.  
  
 [Manipulating XML in Visual Basic](../vs140/manipulating-xml-in-visual-basic.md)  
 Provides links to sections about loading and modifying XML in Visual Basic.  
  
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)  
 Provides links to sections describing how to use [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] in Visual Basic.