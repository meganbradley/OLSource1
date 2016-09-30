---
title: "Scope of Default Namespaces in C#1"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Scope of Default Namespaces in C#"
dev_langs: 
  - "CSharp"
ms.assetid: fe826236-830f-457a-9027-7ad62c909fae
caps.latest.revision: 7
---
# Scope of Default Namespaces in C#1
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
  
 In contrast to the incorrectly coded example above, the correct approach when using C# is to declare and initialize an \<xref:System.Xml.Linq.XNamespace*> object, and to use it when specifying \<xref:System.Xml.Linq.XName*> objects. In this case, the argument to the \<xref:System.Xml.Linq.XElement.Elements*> method is an \<xref:System.Xml.Linq.XName*> object.  
  
### Code  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Comments  
 This example produces the following result:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md)