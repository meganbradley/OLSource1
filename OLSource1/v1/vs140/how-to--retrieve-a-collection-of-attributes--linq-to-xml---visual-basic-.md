---
title: "How to: Retrieve a Collection of Attributes (LINQ to XML) (Visual Basic)"
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
ms.assetid: a07e9645-b45b-403b-b698-f652f904c7d2
caps.latest.revision: 7
---
# How to: Retrieve a Collection of Attributes (LINQ to XML) (Visual Basic)
This topic introduces the \<xref:System.Xml.Linq.XElement.Attributes*> method. This method retrieves the attributes of an element.  
  
## Example  
 The following example shows how to iterate through the collection of attributes of an element.  
  
```vb  
Dim val = _  
    <Value ID="1243" Type="int" ConvertableTo="double">100</Value>  
Dim listOfAttributes As IEnumerable(Of XAttribute) = _  
    From att In val.Attributes() _  
    Select att  
For Each att As XAttribute In listOfAttributes  
    Console.WriteLine(att)  
Next  
```  
  
 This code produces the following output:  
  
```  
ID="1243"  
Type="int"  
ConvertableTo="double"  
```  
  
## See Also  
 [LINQ to XML Axes (Visual Basic)](../vs140/linq-to-xml-axes--visual-basic-.md)