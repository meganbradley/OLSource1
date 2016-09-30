---
title: "Adding Elements, Attributes, and Nodes to an XML Tree (Visual Basic)"
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
ms.assetid: e243e694-c987-43aa-8b22-1e33dace582c
caps.latest.revision: 7
---
# Adding Elements, Attributes, and Nodes to an XML Tree (Visual Basic)
You can add content (elements, attributes, comments, processing instructions, text, and CDATA) to an existing XML tree.  
  
## Methods for Adding Content  
 The following methods add child content to an \<xref:System.Xml.Linq.XElement*> or an \<xref:System.Xml.Linq.XDocument*>:  
  
|Method|Description|  
|------------|-----------------|  
|\<xref:System.Xml.Linq.XContainer.Add*>|Adds content at the end of the child content of the \<xref:System.Xml.Linq.XContainer*>.|  
|\<xref:System.Xml.Linq.XContainer.AddFirst*>|Adds content at the beginning of the child content of the \<xref:System.Xml.Linq.XContainer*>.|  
  
 The following methods add content as sibling nodes of an \<xref:System.Xml.Linq.XNode*>. The most common node to which you add sibling content is \<xref:System.Xml.Linq.XElement*>, although you can add valid sibling content to other types of nodes such as \<xref:System.Xml.Linq.XText*> or \<xref:System.Xml.Linq.XComment*>.  
  
|Method|Description|  
|------------|-----------------|  
|\<xref:System.Xml.Linq.XNode.AddAfterSelf*>|Adds content after the \<xref:System.Xml.Linq.XNode*>.|  
|\<xref:System.Xml.Linq.XNode.AddBeforeSelf*>|Adds content before the \<xref:System.Xml.Linq.XNode*>.|  
  
## Example  
  
### Description  
 The following example creates two XML trees, and then modifies one of the trees.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Comments  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Modifying XML Trees (LINQ to XML) (Visual Basic)](../vs140/modifying-xml-trees--linq-to-xml---visual-basic-.md)