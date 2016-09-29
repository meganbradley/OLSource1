---
title: "Descendants (XElement Dynamic Property)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 9611d00f-23bf-444b-ab0c-f30701bfc13d
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Descendants (XElement Dynamic Property)
Gets an indexer used to retrieve all the descendant elements of the current element that match the specified expanded name.  
  
## Syntax  
  
```  
elem.Descendants[{namespaceName}localName]  
```  
  
## Property Value/Return Value  
 An indexer of the type `IEnumerable<XElement> Item(String expandedName)`. This indexer takes the expanded name of the specified descendant elements and returns the matching child elements in an <xref:System.Collections.IEnumerable*>`<`<xref:System.Xml.Linq.XElement*>`>` collection.  
  
## Remarks  
 This property is equivalent to the <xref:System.Xml.Linq.XContainer.Descendants(System.Xml.Linq.XName)?displayProperty=fullName> method of the <xref:System.Xml.Linq.XContainer*> class.  
  
 The elements in the returned collection are in XML source document order.  
  
 This property uses deferred execution.  
  
## See Also  
 [XElement Class Dynamic Properties](../vs140/xelement-class-dynamic-properties.md)   
 [Elements (XElement Dynamic Property)](../vs140/elements--xelement-dynamic-property-.md)