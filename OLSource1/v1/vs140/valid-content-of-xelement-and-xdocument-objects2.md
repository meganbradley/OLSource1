---
title: "Valid Content of XElement and XDocument Objects2"
ms.custom: na
ms.date: 09/22/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
H1: Valid Content of XElement and XDocument Objects
dev_langs: 
  - VB
ms.assetid: 400bb692-478a-40b6-ac1b-4ccbb4cbbd02
caps.latest.revision: 4
---
# Valid Content of XElement and XDocument Objects2
This topic describes the valid arguments that can be passed to constructors and methods that you use to add content to elements and documents.  
  
## Valid Content  
 Queries often evaluate to <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> of <xref:System.Xml.Linq.XElement?qualifyHint=False> or <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> of <xref:System.Xml.Linq.XAttribute?qualifyHint=False>. You can pass collections of <xref:System.Xml.Linq.XElement?qualifyHint=False> or <xref:System.Xml.Linq.XAttribute?qualifyHint=False> objects to the <xref:System.Xml.Linq.XElement?qualifyHint=False> constructor. Therefore, it is convenient to pass the results of a query as content into methods and constructors that you use to populate XML trees.  
  
 When adding simple content, various types can be passed to this method. Valid types include the following:  
  
-   <xref:System.String?qualifyHint=False>  
  
-   <xref:System.Double?qualifyHint=False>  
  
-   <xref:System.Single?qualifyHint=False>  
  
-   <xref:System.Decimal?qualifyHint=False>  
  
-   <xref:System.Boolean?qualifyHint=False>  
  
-   <xref:System.DateTime?qualifyHint=False>  
  
-   <xref:System.TimeSpan?qualifyHint=False>  
  
-   <xref:System.DateTimeOffset?qualifyHint=False>  
  
-   Any type that implements `Object.ToString`.  
  
-   Any type that implements <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>.  
  
 When adding complex content, various types can be passed to this method:  
  
-   <xref:System.Xml.Linq.XObject?qualifyHint=False>  
  
-   <xref:System.Xml.Linq.XNode?qualifyHint=False>  
  
-   <xref:System.Xml.Linq.XAttribute?qualifyHint=False>  
  
-   Any type that implements <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>  
  
 If an object implements <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>, the collection in the object is enumerated, and all items in the collection are added. If the collection contains <xref:System.Xml.Linq.XNode?qualifyHint=False> or <xref:System.Xml.Linq.XAttribute?qualifyHint=False> objects, each item in the collection is added separately. If the collection contains text (or objects that are converted to text), the text in the collection is concatenated and added as a single text node.  
  
 If content is `null`, nothing is added. When passing a collection items in the collection can be `null`. A `null` item in the collection has no effect on the tree.  
  
 An added attribute must have a unique name within its containing element.  
  
 When adding <xref:System.Xml.Linq.XNode?qualifyHint=False> or <xref:System.Xml.Linq.XAttribute?qualifyHint=False> objects, if the new content has no parent, then the objects are simply attached to the XML tree. If the new content already is parented and is part of another XML tree, then the new content is cloned, and the newly cloned content is attached to the XML tree.  
  
## Valid Content for Documents  
 Attributes and simple content cannot be added to a document.  
  
 There are not many scenarios that require you to create an <xref:System.Xml.Linq.XDocument?qualifyHint=False>. Instead, you can usually create your XML trees with an <xref:System.Xml.Linq.XElement?qualifyHint=False> root node. Unless you have a specific requirement to create a document (for example, because you have to create processing instructions and comments at the top level, or you have to support document types), it is often more convenient to use <xref:System.Xml.Linq.XElement?qualifyHint=False> as your root node.  
  
 Valid content for a document includes the following:  
  
-   Zero or one <xref:System.Xml.Linq.XDocumentType?qualifyHint=False> objects. The document types must come before the element.  
  
-   Zero or one element.  
  
-   Zero or more comments.  
  
-   Zero or more processing instructions.  
  
-   Zero or more text nodes that contain only white space.  
  
## Constructors and Functions that Allow Adding Content  
 The following methods allow you to add child content to an <xref:System.Xml.Linq.XElement?qualifyHint=False> or an <xref:System.Xml.Linq.XDocument?qualifyHint=False>:  
  
|Method|Description|  
|------------|-----------------|  
|<xref:System.Xml.Linq.XElement.#ctor?qualifyHint=False>|Constructs an <xref:System.Xml.Linq.XElement?qualifyHint=False>.|  
|<xref:System.Xml.Linq.XDocument.#ctor?qualifyHint=False>|Constructs a <xref:System.Xml.Linq.XDocument?qualifyHint=False>.|  
|<xref:System.Xml.Linq.XContainer.Add?qualifyHint=False>|Adds to the end of the child content of the <xref:System.Xml.Linq.XElement?qualifyHint=False> or <xref:System.Xml.Linq.XDocument?qualifyHint=False>.|  
|<xref:System.Xml.Linq.XNode.AddAfterSelf?qualifyHint=False>|Adds content after the <xref:System.Xml.Linq.XNode?qualifyHint=False>.|  
|<xref:System.Xml.Linq.XNode.AddBeforeSelf?qualifyHint=False>|Adds content before the <xref:System.Xml.Linq.XNode?qualifyHint=False>.|  
|<xref:System.Xml.Linq.XContainer.AddFirst?qualifyHint=False>|Adds content at the beginning of the child content of the <xref:System.Xml.Linq.XContainer?qualifyHint=False>.|  
|<xref:System.Xml.Linq.XElement.ReplaceAll?qualifyHint=False>|Replaces all content (child nodes and attributes) of an <xref:System.Xml.Linq.XElement?qualifyHint=False>.|  
|<xref:System.Xml.Linq.XElement.ReplaceAttributes?qualifyHint=False>|Replaces the attributes of an <xref:System.Xml.Linq.XElement?qualifyHint=False>.|  
|<xref:System.Xml.Linq.XContainer.ReplaceNodes?qualifyHint=False>|Replaces the children nodes with new content.|  
|<xref:System.Xml.Linq.XNode.ReplaceWith?qualifyHint=False>|Replaces a node with new content.|  
  
## See Also  
 [Creating XML Trees (Visual Basic)](../vs140/creating-xml-trees--visual-basic-.md)