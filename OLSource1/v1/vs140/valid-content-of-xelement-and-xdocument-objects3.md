---
title: "Valid Content of XElement and XDocument Objects3"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Valid Content of XElement and XDocument Objects"
dev_langs: 
  - "CSharp"
ms.assetid: 0d253586-2b97-459f-b1a7-f30f38f3ed9f
caps.latest.revision: 9
---
# Valid Content of XElement and XDocument Objects3
This topic describes the valid arguments that can be passed to constructors and methods that you use to add content to elements and documents.  
  
## Valid Content  
 Queries often evaluate to <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>1*> of \<xref:System.Xml.Linq.XAttribute*>. You can pass collections of \<xref:System.Xml.Linq.XElement*> or \<xref:System.Xml.Linq.XAttribute*> objects to the \<xref:System.Xml.Linq.XElement*> constructor. Therefore, it is convenient to pass the results of a query as content into methods and constructors that you use to populate XML trees.  
  
 When adding simple content, various types can be passed to this method. Valid types include the following:  
  
-   \<xref:System.String*>  
  
-   \<xref:System.Double*>  
  
-   \<xref:System.Single*>  
  
-   \<xref:System.Decimal*>  
  
-   \<xref:System.Boolean*>  
  
-   \<xref:System.DateTime*>  
  
-   \<xref:System.TimeSpan*>  
  
-   \<xref:System.DateTimeOffset*>  
  
-   Any type that implements <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
-   Any type that implements <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>1*>  
  
 If an object implements <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>null<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>null<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>null` item in the collection has no effect on the tree.  
  
 An added attribute must have a unique name within its containing element.  
  
 When adding \<xref:System.Xml.Linq.XNode*> or \<xref:System.Xml.Linq.XAttribute*> objects, if the new content has no parent, then the objects are simply attached to the XML tree. If the new content already is parented and is part of another XML tree, then the new content is cloned, and the newly cloned content is attached to the XML tree.  
  
## Valid Content for Documents  
 Attributes and simple content cannot be added to a document.  
  
 There are not many scenarios that require you to create an \<xref:System.Xml.Linq.XDocument*>. Instead, you can usually create your XML trees with an \<xref:System.Xml.Linq.XElement*> root node. Unless you have a specific requirement to create a document (for example, because you have to create processing instructions and comments at the top level, or you have to support document types), it is often more convenient to use \<xref:System.Xml.Linq.XElement*> as your root node.  
  
 Valid content for a document includes the following:  
  
-   Zero or one \<xref:System.Xml.Linq.XDocumentType*> objects. The document types must come before the element.  
  
-   Zero or one element.  
  
-   Zero or more comments.  
  
-   Zero or more processing instructions.  
  
-   Zero or more text nodes that contain only white space.  
  
## Constructors and Functions that Allow Adding Content  
 The following methods allow you to add child content to an \<xref:System.Xml.Linq.XElement*> or an \<xref:System.Xml.Linq.XDocument*>:  
  
|Method|Description|  
|------------|-----------------|  
|\<xref:System.Xml.Linq.XElement.#ctor*>|Constructs an \<xref:System.Xml.Linq.XElement*>.|  
|\<xref:System.Xml.Linq.XDocument.#ctor*>|Constructs a \<xref:System.Xml.Linq.XDocument*>.|  
|\<xref:System.Xml.Linq.XContainer.Add*>|Adds to the end of the child content of the \<xref:System.Xml.Linq.XElement*> or \<xref:System.Xml.Linq.XDocument*>.|  
|\<xref:System.Xml.Linq.XNode.AddAfterSelf*>|Adds content after the \<xref:System.Xml.Linq.XNode*>.|  
|\<xref:System.Xml.Linq.XNode.AddBeforeSelf*>|Adds content before the \<xref:System.Xml.Linq.XNode*>.|  
|\<xref:System.Xml.Linq.XContainer.AddFirst*>|Adds content at the beginning of the child content of the \<xref:System.Xml.Linq.XContainer*>.|  
|\<xref:System.Xml.Linq.XElement.ReplaceAll*>|Replaces all content (child nodes and attributes) of an \<xref:System.Xml.Linq.XElement*>.|  
|\<xref:System.Xml.Linq.XElement.ReplaceAttributes*>|Replaces the attributes of an \<xref:System.Xml.Linq.XElement*>.|  
|\<xref:System.Xml.Linq.XContainer.ReplaceNodes*>|Replaces the children nodes with new content.|  
|\<xref:System.Xml.Linq.XNode.ReplaceWith*>|Replaces a node with new content.|  
  
## See Also  
 [Creating XML Trees (C#)](../vs140/creating-xml-trees--csharp-.md)