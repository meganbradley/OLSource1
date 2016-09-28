---
title: "Attribute (XElement Dynamic Property)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 8440fc7d-b3b4-4726-8ec8-492e6af79642
caps.latest.revision: 6
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Attribute (XElement Dynamic Property)
Gets an indexer used to retrieve the attribute instance that corresponds to the specified expanded name.  
  
## Syntax  
  
```  
elem.Attribute[{namespaceName}attribName]  
```  
  
## Property Value/Return Value  
 An indexer of the type `XAttribute Item(String expandedName)`. This indexer takes the expanded name of the specified attribute and returns the corresponding <xref:System.Xml.Linq.XAttribute*>, or `null` if there is no attribute with the specified name.  
  
## Remarks  
 This property is equivalent to the [Attribute](assetId:///M:System.Xml.Linq.XElement.Attribute(System.Xml.Linq.XName)?qualifyHint=False&autoUpgrade=True) method of the <xref:System.Xml.Linq.XElement*?displayProperty=fullName> class.  
  
## See Also  
 [XElement.Attribute](assetId:///M:System.Xml.Linq.XElement.Attribute(System.Xml.Linq.XName)?qualifyHint=True&autoUpgrade=True)   
 [XElement Class Dynamic Properties](../vs140/xelement-class-dynamic-properties.md)   
 [Value (XAttribute Dynamic Property)](../vs140/value--xattribute-dynamic-property-.md)