---
title: "How to: Create a Document with Namespaces (C#) (LINQ to XML)2"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Create a Document with Namespaces (C#) (LINQ to XML)"
dev_langs: 
  - "CSharp"
ms.assetid: 37e63c57-f86d-47ac-88a7-2c2d107def30
caps.latest.revision: 7
---
# How to: Create a Document with Namespaces (C#) (LINQ to XML)2
This topic shows how to create documents with namespaces.  
  
## Example  
 To create an element or an attribute that is in a namespace, you first declare and initialize an \<xref:System.Xml.Linq.XNamespace*> object. You then use the addition operator overload to combine the namespace with the local name, expressed as a string.  
  
 The following example creates a document with one namespace. By default, [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] serializes this document with a default namespace.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example creates a document with one namespace. It also creates an attribute that declares the namespace with a namespace prefix. To create an attribute that declares a namespace with a prefix, you create an attribute where the name of the attribute is the namespace prefix, and this name is in the \<xref:System.Xml.Linq.XNamespace.Xmlns*> namespace. The value of this attribute is the URI of the namespace.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 The following example shows the creation of a document that contains two namespaces. One is the default namespace. Another is a namespace with a prefix.  
  
 By including namespace attributes in the root element, the namespaces are serialized so that http://www.adventure-works.com is the default namespace, and www.fourthcoffee.com is serialized with a prefix of "fc". To create an attribute that declares a default namespace, you create an attribute with the name "xmlns", without a namespace. The value of the attribute is the default namespace URI.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Example  
 The following example creates a document that contains two namespaces, both with namespace prefixes.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Example  
 Another way to accomplish the same result is to use expanded names instead of declaring and creating an \<xref:System.Xml.Linq.XNamespace*> object.  
  
 This approach has performance implications. Each time you pass a string that contains an expanded name to [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)], [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] must parse the name, find the atomized namespace, and find the atomized name. This process takes CPU time. If performance is important, you might want to declare and use an \<xref:System.Xml.Linq.XNamespace*> object explicitly.  
  
 If performance is an important issue, see [Pre-Atomization of XName Objects (LINQ to XML) (C#)](../vs140/pre-atomization-of-xname-objects--linq-to-xml---csharp-.md) for more information  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## See Also  
 [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md)