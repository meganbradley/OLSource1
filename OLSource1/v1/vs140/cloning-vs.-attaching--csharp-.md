---
title: "Cloning vs. Attaching (C#)"
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
ms.assetid: 357c5efa-7b73-4f14-aa67-6bebdba4e7ea
caps.latest.revision: 7
---
# Cloning vs. Attaching (C#)
When adding \<xref:System.Xml.Linq.XNode*> (including \<xref:System.Xml.Linq.XElement*>) or \<xref:System.Xml.Linq.XAttribute*> objects to a new tree, if the new content has no parent, the objects are simply attached to the XML tree. If the new content already is parented, and is part of another XML tree, the new content is cloned. The newly cloned content is then attached to the XML tree.  
  
## Example  
 The following code demonstrates the behavior when you add a parented element to a tree, and when you add an element with no parent to a tree.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Creating XML Trees (C#)](../vs140/creating-xml-trees--csharp-.md)