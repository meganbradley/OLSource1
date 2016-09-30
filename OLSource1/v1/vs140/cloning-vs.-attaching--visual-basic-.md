---
title: "Cloning vs. Attaching (Visual Basic)"
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
ms.assetid: 3c3bd105-c9d3-49bd-875b-27ab4e8bc7a3
caps.latest.revision: 7
---
# Cloning vs. Attaching (Visual Basic)
When adding \<xref:System.Xml.Linq.XNode*> (including \<xref:System.Xml.Linq.XElement*>) or \<xref:System.Xml.Linq.XAttribute*> objects to a new tree, if the new content has no parent, the objects are simply attached to the XML tree. If the new content already is parented, and is part of another XML tree, the new content is cloned. The newly cloned content is then attached to the XML tree.  
  
## Example  
 The following code demonstrates the behavior when you add a parented element to a tree, and when you add an element with no parent to a tree.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Creating XML Trees (Visual Basic)](../vs140/creating-xml-trees--visual-basic-.md)