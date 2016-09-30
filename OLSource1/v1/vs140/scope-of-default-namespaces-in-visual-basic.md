---
title: "Scope of Default Namespaces in Visual Basic"
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
ms.assetid: d4cce80c-342f-4097-be8b-40ab0bfa90ba
caps.latest.revision: 7
---
# Scope of Default Namespaces in Visual Basic
Default namespaces as represented in the XML tree are not in scope for queries. If you have XML that is in a default namespace, you still must declare an \<xref:System.Xml.Linq.XNamespace*> variable, and combine it with the local name to make a qualified name to be used in the query.  
  
 One of the most common problems when querying XML trees is that if the XML tree has a default namespace, the developer sometimes writes the query as though the XML were not in a namespace.  
  
 The first set of examples in this topic shows a typical way that XML in a default namespace is loaded, but is queried improperly.  
  
 The second set of examples show the necessary corrections so that you can query XML in a namespace.  
  
## Example  
 This example shows the creation of XML in a namespace, and a query that returns an empty result set.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Comments  
 This example produces the following result:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This example shows the creation of XML in a namespace, and a query that is coded properly.  
  
 In contrast to the incorrectly coded example above, the correct approach when using Visual Basic is to declare and initialize a global default namespace. This places all XML properties in the default namespace. No other modifications are required to the example to make it work properly.  
  
### Code  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Comments  
 This example produces the following result:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md)