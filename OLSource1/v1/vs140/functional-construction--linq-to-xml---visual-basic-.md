---
title: "Functional Construction (LINQ to XML) (Visual Basic)"
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
ms.assetid: feac4273-39ab-43ae-bab7-4059c807a785
caps.latest.revision: 7
---
# Functional Construction (LINQ to XML) (Visual Basic)
[!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] provides a powerful way to create XML elements called *functional construction*. Functional construction is the ability to create an XML tree in a single statement.  
  
 There are several key features of the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] programming interface that enable functional construction:  
  
-   The \<xref:System.Xml.Linq.XElement*> constructor takes various types of arguments for content. For example, you can pass another \<xref:System.Xml.Linq.XElement*> object, which becomes a child element. You can pass an \<xref:System.Xml.Linq.XAttribute*> object, which becomes an attribute of the element. Or you can pass any other type of object, which is converted to a string and becomes the text content of the element.  
  
-   The \<xref:System.Xml.Linq.XElement*> constructor takes a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> array of type \<xref:System.Object*>, so that you can pass any number of objects to the constructor. This enables you to create an element that has complex content.  
  
-   If an object implements \<xref:System.Collections.Generic.IEnumerable`1*>, the collection in the object is enumerated, and all items in the collection are added. If the collection contains \<xref:System.Xml.Linq.XElement*> or \<xref:System.Xml.Linq.XAttribute*> objects, each item in the collection is added separately. This is important because it lets you pass the results of a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query to the constructor.  
  
 The following is an example:  
  
 These features enable you to write code using XML literals to create an XML tree, and also to write code that uses the results of [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries when you create an XML tree:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Creating XML Trees (Visual Basic)](../vs140/creating-xml-trees--visual-basic-.md)