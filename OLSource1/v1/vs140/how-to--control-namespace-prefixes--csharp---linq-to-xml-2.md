---
title: "How to: Control Namespace Prefixes (C#) (LINQ to XML)2"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Control Namespace Prefixes (C#) (LINQ to XML)"
dev_langs: 
  - "CSharp"
ms.assetid: 64de5186-b81a-4ddd-8327-8693df59a01b
caps.latest.revision: 7
---
# How to: Control Namespace Prefixes (C#) (LINQ to XML)2
This topic describes how you can control namespace prefixes when serializing an XML tree.  
  
 In many situations, it is not necessary to control namespace prefixes.  
  
 However, certain XML programming tools require specific control of namespace prefixes. For example, you might be manipulating an XSLT style sheet or a XAML document that contains embedded XPath expressions that refer to specific namespace prefixes; in this case, it is important that the document be serialized with those specific prefixes.  
  
 This is the most common reason for controlling namespace prefixes.  
  
 Another common reason for controlling namespace prefixes is that you want users to edit the XML document manually, and you want to create namespace prefixes that are convenient for the user to type. For example, you might be generating an XSD document. Conventions for schemas suggest that you use either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> as the prefix for the schema namespace.  
  
 To control namespace prefixes, you insert attributes that declare namespaces. If you declare the namespaces with specific prefixes, [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] will attempt to honor the namespace prefixes when serializing.  
  
 To create an attribute that declares a namespace with a prefix, you create an attribute where the namespace of the name of the attribute is \<xref:System.Xml.Linq.XNamespace.Xmlns*>, and the name of the attribute is the namespace prefix. The value of the attribute is the URI of the namespace.  
  
## Example  
 This example declares two namespaces. It specifies that the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> namespace has the prefix of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and that the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> namespace has the prefix of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md)