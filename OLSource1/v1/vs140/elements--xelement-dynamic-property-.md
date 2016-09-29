---
title: "Elements (XElement Dynamic Property)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "XElement.Elements"
apitype: "Assembly"
ms.assetid: 3d5737f2-d2ed-410a-821c-349dbb2b574f
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Elements (XElement Dynamic Property)
Gets an indexer used to retrieve the child elements of the current element that match the specified expanded name.  
  
## Syntax  
  
```  
elem.Elements[{namespaceName}localName]   
```  
  
## Property Value/Return Value  
 An indexer of the type `IEnumerable<XElement> Item(String expandedName)`. This indexer takes the expanded name of the desired child elements and returns the matching child elements in an <xref:System.Collections.IEnumerable*>`<`<xref:System.Xml.Linq.XElement*>`>` collection.  
  
## Remarks  
 This property is equivalent to the <xref:System.Xml.Linq.XContainer.Elements(System.Xml.Linq.XName)?displayProperty=fullName> method of the <xref:System.Xml.Linq.XContainer*> class.  
  
 The elements in the returned collection are in XML source document order.  
  
 This property uses deferred execution.  
  
## See Also  
 [XElement Class Dynamic Properties](../vs140/xelement-class-dynamic-properties.md)   
 [Element (XElement Dynamic Property)](../vs140/element--xelement-dynamic-property-.md)   
 [Descendants (XElement Dynamic Property)](../vs140/descendants--xelement-dynamic-property-.md)