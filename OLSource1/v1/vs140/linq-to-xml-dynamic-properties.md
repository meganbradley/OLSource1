---
title: "LINQ to XML Dynamic Properties"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 0455f47c-4a68-4f2e-a3f8-dd1d85b99012
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LINQ to XML Dynamic Properties
This section provides reference information about the dynamic properties in LINQ to XML. Specifically, these properties are exposed by the \<xref:System.Xml.Linq.XAttribute*> and \<xref:System.Xml.Linq.XElement*> classes, which are in the \<xref:System.Xml.Linq*> namespace.  
  
 As explained in the topic [Overview of WPF Data Binding with LINQ to XML](../vs140/wpf-data-binding-with-linq-to-xml-overview.md), each of the dynamic properties is equivalent to a standard public property or method in the same class. These standard members should be used for most purposes; dynamic properties are provided specifically for LINQ to XML data binding scenarios. For more information about the standard members of these classes, see the \<xref:System.Xml.Linq.XAttribute*> and \<xref:System.Xml.Linq.XElement*> reference topics.  
  
 With respect to their resolved values, the dynamic properties in this section fall into two categories:  
  
-   Simple ones, such as the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> properties in the \<xref:System.Xml.Linq.XAttribute*> and \<xref:System.Xml.Linq.XElement*> classes, that resolve to a single value.  
  
-   Indexed values, such as the [Elements](../vs140/elements--xelement-dynamic-property-.md) and [Descendants](../vs140/descendants--xelement-dynamic-property-.md) properties of \<xref:System.Xml.Linq.XElement*>, that resolve into an indexer type. For indexer types to be resolved to the desired value or collection, an expanded name parameter must be passed to them.  
  
 All the dynamic properties that return an indexed value of type \<xref:System.Collections.Generic.IEnumerable`1*> use deffered execution. For more information about deferred execution, see [The Three Parts of a LINQ Query](../vs140/introduction-to-linq-queries--csharp-.md).  
  
## In This Section  
  
|Topic|Description|  
|-----------|-----------------|  
|[XAttribute Class Dynamic Properties](../vs140/xattribute-class-dynamic-properties.md)|Provides details about the dynamic properties exposed by the \<xref:System.Xml.Linq.XAttribute*> class.|  
|[XElement Class Dynamic Properties](../vs140/xelement-class-dynamic-properties.md)|Provides details about the dynamic properties exposed by the \<xref:System.Xml.Linq.XElement*> class.|  
  
## Reference  
 \<xref:System.Xml.Linq*>  
  
 \<xref:System.Xml.Linq.XElement*?displayProperty=fullName>  
  
 \<xref:System.Xml.Linq.XAttribute*?displayProperty=fullName>  
  
## See Also  
 [WPF Data Binding with LINQ to XML](../vs140/wpf-data-binding-with-linq-to-xml.md)   
 [Overview of WPF Data Binding with LINQ to XML](../vs140/wpf-data-binding-with-linq-to-xml-overview.md)   
 [The Three Parts of a LINQ Query](../vs140/introduction-to-linq-queries--csharp-.md)