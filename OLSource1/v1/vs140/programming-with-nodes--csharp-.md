---
title: "Programming with Nodes (C#)"
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
ms.assetid: c38df0f2-c805-431a-93ff-9103a4284c2f
caps.latest.revision: 7
---
# Programming with Nodes (C#)
[!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] developers who need to write programs such as an XML editor, a transform system, or a report writer often need to write programs that work at a finer level of granularity than elements and attributes. They often need to work at the node level, manipulating text nodes, processing instructions, and comments. This topic provides some details about programming at the node level.  
  
## Node Details  
 There are a number of details of programming that a programmer working at the node level should know.  
  
### Parent Property of Children Nodes of XDocument is Set to Null  
 The \<xref:System.Xml.Linq.XObject.Parent*> property contains the parent \<xref:System.Xml.Linq.XElement*>, not the parent node. Child nodes of \<xref:System.Xml.Linq.XDocument*> have no parent \<xref:System.Xml.Linq.XElement*>. Their parent is the document, so the \<xref:System.Xml.Linq.XObject.Parent*> property for those nodes is set to null.  
  
 The following example demonstrates this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Adjacent Text Nodes are Possible  
 In a number of XML programming models, adjacent text nodes are always merged. This is sometimes called normalization of text nodes. [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] does not normalize text nodes. If you add two text nodes to the same element, it will result in adjacent text nodes. However, if you add content specified as a string rather than as an \<xref:System.Xml.Linq.XText*> node, [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] might merge the string with an adjacent text node.  
  
 The following example demonstrates this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Empty Text Nodes are Possible  
 In some XML programming models, text nodes are guaranteed to not contain the empty string. The reasoning is that such a text node has no impact on serialization of the XML. However, for the same reason that adjacent text nodes are possible, if you remove the text from a text node by setting its value to the empty string, the text node itself will not be deleted.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### An Empty Text Node Impacts Serialization  
 If an element contains only a child text node that is empty, it is serialized with the long tag syntax: <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. If an element contains no child nodes whatsoever, it is serialized with the short tag syntax: <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Namespaces are Attributes in the LINQ to XML Tree  
 Even though namespace declarations have identical syntax to attributes, in some programming interfaces, such as XSLT and XPath, namespace declarations are not considered to be attributes. However, in [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)], namespaces are stored as \<xref:System.Xml.Linq.XAttribute*> objects in the XML tree. If you iterate through the attributes for an element that contains a namespace declaration, you will see the namespace declaration as one of the items in the returned collection.  
  
 The \<xref:System.Xml.Linq.XAttribute.IsNamespaceDeclaration*> property indicates whether an attribute is a namespace declaration.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### XPath Axis Methods Do Not Return Child White Space of XDocument  
 [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] allows for child text nodes of an \<xref:System.Xml.Linq.XDocument*>, as long as the text nodes contain only white space. However, the XPath object model does not include white space as child nodes of a document, so when you iterate through the children of an \<xref:System.Xml.Linq.XDocument*> using the \<xref:System.Xml.Linq.XContainer.Nodes*> axis, white space text nodes will be returned. However, when you iterate through the children of an \<xref:System.Xml.Linq.XDocument*> using the XPath axis methods, white space text nodes will not be returned.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### XDeclaration Objects are not Nodes  
 When you iterate through the children nodes of an \<xref:System.Xml.Linq.XDocument*>, you will not see the XML declaration object. It is a property of the document, not a child node of it.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## See Also  
 [Advanced LINQ to XML Programming (C#)](../vs140/advanced-linq-to-xml-programming--csharp-.md)