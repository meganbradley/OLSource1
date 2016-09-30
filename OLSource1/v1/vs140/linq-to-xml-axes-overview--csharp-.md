---
title: "LINQ to XML Axes Overview (C#)"
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
ms.assetid: 516792fb-461d-40a8-8a50-9993a51258fc
caps.latest.revision: 8
---
# LINQ to XML Axes Overview (C#)
After you have created an XML tree or loaded an XML document into an XML tree, you can query it to find elements and attributes and retrieve their values. You retrieve collections through the *axis methods*, also called *axes*. Some of the axes are methods in the \<xref:System.Xml.Linq.XElement*> and \<xref:System.Xml.Linq.XDocument*> classes that return <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>1*>, and the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] axes return <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>1*> of \<xref:System.Xml.Linq.XAttribute*> collections. You need these collections to perform your queries.  
  
 In addition to the axis methods that retrieve collections of elements and attributes, there are axis methods that allow you to iterate through the tree in great detail. For example, instead of dealing with elements and attributes, you can work with the nodes of the tree. Nodes are a finer level of granularity than elements and attributes. When working with nodes, you can examine XML comments, text nodes, processing instructions, and more. This functionality is important, for example, to someone who is writing a word processor and wants to save documents as XML. However, the majority of XML programmers are primarily concerned with elements, attributes, and their values.  
  
## Methods for Retrieving a Collection of Elements  
 The following is a summary of the methods of the \<xref:System.Xml.Linq.XElement*> class (or its base classes) that you call on an \<xref:System.Xml.Linq.XElement*> to return a collection of elements.  
  
|Method|Description|  
|------------|-----------------|  
|\<xref:System.Xml.Linq.XNode.Ancestors*?displayProperty=fullName>|Returns an <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>1*> of \<xref:System.Xml.Linq.XElement*> of the ancestors that have the specified \<xref:System.Xml.Linq.XName*>.|  
|\<xref:System.Xml.Linq.XContainer.Descendants*?displayProperty=fullName>|Returns an <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>1*> of \<xref:System.Xml.Linq.XElement*> of the descendants that have the specified \<xref:System.Xml.Linq.XName*>.|  
|\<xref:System.Xml.Linq.XContainer.Elements*?displayProperty=fullName>|Returns an <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1*> of \<xref:System.Xml.Linq.XElement*> of the child elements that have the specified \<xref:System.Xml.Linq.XName*>.|  
|\<xref:System.Xml.Linq.XNode.ElementsAfterSelf*?displayProperty=fullName>|Returns an <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>1*> of \<xref:System.Xml.Linq.XElement*> of the elements after this element that have the specified \<xref:System.Xml.Linq.XName*>.|  
|\<xref:System.Xml.Linq.XNode.ElementsBeforeSelf*?displayProperty=fullName>|Returns an <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>1*> of \<xref:System.Xml.Linq.XElement*> of the elements before this element that have the specified \<xref:System.Xml.Linq.XName*>.|  
|\<xref:System.Xml.Linq.XElement.AncestorsAndSelf*?displayProperty=fullName>|Returns an <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>1*> of \<xref:System.Xml.Linq.XElement*> of the elements that have the specified \<xref:System.Xml.Linq.XName*>.|  
|\<xref:System.Xml.Linq.XElement.DescendantsAndSelf*?displayProperty=fullName>|Returns an <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>1*> of \<xref:System.Xml.Linq.XElement*> of the elements that have the specified \<xref:System.Xml.Linq.XName*>.|  
  
## Method for Retrieving a Single Element  
 The following method retrieves a single child from an \<xref:System.Xml.Linq.XElement*> object.  
  
|Method|Description|  
|------------|-----------------|  
|\<xref:System.Xml.Linq.XContainer.Element*?displayProperty=fullName>|Returns the first child \<xref:System.Xml.Linq.XElement*> object that has the specified \<xref:System.Xml.Linq.XName*>.|  
  
## Method for Retrieving a Collection of Attributes  
 The following method retrieves attributes from an \<xref:System.Xml.Linq.XElement*> object.  
  
|Method|Description|  
|------------|-----------------|  
|\<xref:System.Xml.Linq.XElement.Attributes*?displayProperty=fullName>|Returns an \<xref:System.Collections.Generic.IEnumerable`1*> of \<xref:System.Xml.Linq.XAttribute*> of all of the attributes.|  
  
## Method for Retrieving a Single Attribute  
 The following method retrieves a single attribute from an \<xref:System.Xml.Linq.XElement*> object.  
  
|Method|Description|  
|------------|-----------------|  
|\<xref:System.Xml.Linq.XElement.Attribute*?displayProperty=fullName>|Returns the \<xref:System.Xml.Linq.XAttribute*> that has the specified \<xref:System.Xml.Linq.XName*>.|  
  
## See Also  
 [LINQ to XML Axes (C#)](../vs140/linq-to-xml-axes--csharp-.md)