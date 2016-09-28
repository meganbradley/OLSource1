---
title: "How to: Find a Child Element (XPath-LINQ to XML) (Visual Basic)"
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
ms.assetid: adb46c98-a650-42e2-b62d-835920fe8421
caps.latest.revision: 3
author: ""
ms.author: ""
manager: ""
---
# How to: Find a Child Element (XPath-LINQ to XML) (Visual Basic)
This topic compares the XPath child element axis to the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] [Element](assetId:///M:System.Xml.Linq.XContainer.Element(System.Xml.Linq.XName)?qualifyHint=False&autoUpgrade=True) method.  
  
 The XPath expression is `DeliveryNotes`.  
  
## Example  
 This example finds the child element `DeliveryNotes`.  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders (LINQ to XML)](../vs140/sample-xml-file--multiple-purchase-orders--linq-to-xml-3.md).  
  
```vb  
Dim cpo As XDocument = XDocument.Load("PurchaseOrders.xml")  
Dim po As XElement = cpo.Root.<PurchaseOrder>.FirstOrDefault  
  
'LINQ to XML query  
Dim el1 As XElement = po.<DeliveryNotes>.FirstOrDefault  
  
' XPath expression  
Dim el2 As XElement = po.XPathSelectElement("DeliveryNotes")  
' same as "child::DeliveryNotes"  
' same as "./DeliveryNotes"  
  
If el1 Is el2 Then  
    Console.WriteLine("Results are identical")  
Else  
    Console.WriteLine("Results differ")  
End If  
Console.WriteLine(el1)  
  
```  
  
 This example produces the following output:  
  
```  
Results are identical  
<DeliveryNotes>Please leave packages in shed by driveway.</DeliveryNotes>  
```  
  
## See Also  
 [LINQ to XML for XPath Users (Visual Basic)](../vs140/linq-to-xml-for-xpath-users--visual-basic-.md)