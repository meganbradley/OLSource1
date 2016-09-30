---
title: "How to: Write Queries on XML in Namespaces (C#)"
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
ms.assetid: 7c54df81-15e4-4091-8c81-a87637029130
caps.latest.revision: 7
---
# How to: Write Queries on XML in Namespaces (C#)
To write a query on XML that is in a namespace, you must use \<xref:System.Xml.Linq.XName*> objects that have the correct namespace.  
  
 For C#, the most common approach is to initialize an \<xref:System.Xml.Linq.XNamespace*> using a string that contains the URI, then use the addition operator overload to combine the namespace with the local name.  
  
 The first set of examples in this topic shows how to create an XML tree in a default namespace. The second set shows how to create an XML tree in a namespace with a prefix.  
  
## Example  
 The following example creates an XML tree that is in a default namespace. It then retrieves a collection of elements.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 In C#, you write queries in the same way regardless of whether you are writing queries on an XML tree that uses a namespace with a prefix or on an XML tree with a default namespace.  
  
 The following example creates an XML tree that is in a namespace with a prefix. It then retrieves a collection of elements.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md)