---
title: "Functional Construction (LINQ to XML) (C#)"
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
ms.assetid: 57a82bcf-de03-4f1c-a0c8-9a76e989d542
caps.latest.revision: 7
---
# Functional Construction (LINQ to XML) (C#)
[!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] provides a powerful way to create XML elements called *functional construction*. Functional construction is the ability to create an XML tree in a single statement.  
  
 There are several key features of the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] programming interface that enable functional construction:  
  
-   The \<xref:System.Xml.Linq.XElement*> constructor takes various types of arguments for content. For example, you can pass another \<xref:System.Xml.Linq.XElement*> object, which becomes a child element. You can pass an \<xref:System.Xml.Linq.XAttribute*> object, which becomes an attribute of the element. Or you can pass any other type of object, which is converted to a string and becomes the text content of the element.  
  
-   The \<xref:System.Xml.Linq.XElement*> constructor takes a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array of type \<xref:System.Object*>, so that you can pass any number of objects to the constructor. This enables you to create an element that has complex content.  
  
-   If an object implements \<xref:System.Collections.Generic.IEnumerable`1*>, the collection in the object is enumerated, and all items in the collection are added. If the collection contains \<xref:System.Xml.Linq.XElement*> or \<xref:System.Xml.Linq.XAttribute*> objects, each item in the collection is added separately. This is important because it lets you pass the results of a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query to the constructor.  
  
 These features enable you to write code to create an XML tree. The following is an example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 These features also enable you to write code that uses the results of [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries when you create an XML tree, as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Creating XML Trees (C#)](../vs140/creating-xml-trees--csharp-.md)