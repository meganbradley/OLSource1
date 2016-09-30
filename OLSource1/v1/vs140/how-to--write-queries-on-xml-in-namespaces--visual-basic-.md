---
title: "How to: Write Queries on XML in Namespaces (Visual Basic)"
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
ms.assetid: 7d4131b5-3288-414f-b77c-b2edc2a1f465
caps.latest.revision: 7
---
# How to: Write Queries on XML in Namespaces (Visual Basic)
To write a query on XML that is in a namespace, you must use \<xref:System.Xml.Linq.XName*> objects that have the correct namespace.  
  
 In Visual Basic, the most common approach is to define a global namespace, and then use XML literals and XML properties that use the global namespace. You can define a global default namespace, in which case elements in the XML literals will be in the namespace by default. Alternatively, you can define a global namespace with a prefix, and then use the prefix as required in the XML literals, and in XML properties. As with other forms of XML, attributes are always in no namespace by default.  
  
 The first set of examples in this topic shows how to create an XML tree in a default namespace. The second set shows how to create an XML tree in a namespace with a prefix.  
  
## Example  
 The following example creates an XML tree that is in a default namespace. It then retrieves a collection of elements.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 In Visual Basic, however, writing queries on an XML tree that uses a namespace with a prefix is quite different from querying an XML tree in a default namespace. Typically you use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement to import the namespace with a prefix. You then use the prefix in the element and attribute names when you construct the XML tree. You also use the prefix when querying an XML tree using XML properties.  
  
 The following example creates an XML tree that is in a namespace with a prefix. It then retrieves a collection of elements.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md)