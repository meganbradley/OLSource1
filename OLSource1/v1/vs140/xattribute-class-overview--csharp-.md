---
title: "XAttribute Class Overview (C#)"
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
ms.assetid: 5a630f24-f9ad-400e-831e-c14ebfc9e142
caps.latest.revision: 7
---
# XAttribute Class Overview (C#)
Attributes are name/value pairs that are associated with an element. The \<xref:System.Xml.Linq.XAttribute*> class represents XML attributes.  
  
## Overview  
 Working with attributes in [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] is similar to working with elements. Their constructors are similar. The methods that you use to retrieve collections of them are similar. A [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query expression for a collection of attributes looks very similar to a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query expression for a collection of elements.  
  
 The order in which attributes were added to an element is preserved. That is, when you iterate through the attributes, you see them in the same order that they were added.  
  
## The XAttribute Constructor  
 The following constructor of the \<xref:System.Xml.Linq.XAttribute*> class is the one that you will most commonly use:  
  
|Constructor|Description|  
|-----------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Creates an \<xref:System.Xml.Linq.XAttribute*> object. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> argument specifies the name of the attribute; <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> specifies the content of the attribute.|  
  
### Creating an Element with an Attribute  
 The following code shows the common task of creating an element that contains an attribute:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Functional Construction of Attributes  
 You can construct \<xref:System.Xml.Linq.XAttribute*> objects in-line with the construction of \<xref:System.Xml.Linq.XElement*> objects, as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Attributes Are Not Nodes  
 There are some differences between attributes and elements. \<xref:System.Xml.Linq.XAttribute*> objects are not nodes in the XML tree. They are name/value pairs associated with an XML element. In contrast to the Document Object Model (DOM), this more closely reflects the structure of XML. Although \<xref:System.Xml.Linq.XAttribute*> objects are not actually nodes in the XML tree, working with \<xref:System.Xml.Linq.XAttribute*> objects is very similar to working with \<xref:System.Xml.Linq.XElement*> objects.  
  
 This distinction is primarily important only to developers who are writing code that works with XML trees at the node level. Many developers will not be concerned with this distinction.  
  
## See Also  
 [LINQ to XML Programming Overview (C#)](../vs140/linq-to-xml-programming-overview--csharp-.md)