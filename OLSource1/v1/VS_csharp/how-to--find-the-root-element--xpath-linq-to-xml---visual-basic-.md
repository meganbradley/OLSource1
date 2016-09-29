---
title: "How to: Find the Root Element (XPath-LINQ to XML) (Visual Basic)"
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
ms.assetid: 72c3aed5-9522-4454-a876-2070aad13f2e
caps.latest.revision: 7
---
# How to: Find the Root Element (XPath-LINQ to XML) (Visual Basic)
This topic shows how to get the root element with XPath and [!INCLUDE[sqltecxlinq](../VS_csharp/includes/sqltecxlinq_md.md)].  
  
 The XPath expression is:  
  
 `/PurchaseOrders`  
  
## Example  
 This example finds the root element.  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders (LINQ to XML)](../VS_csharp/sample-xml-file--multiple-purchase-orders--linq-to-xml-3.md).  
  
```vb  
Dim po As XDocument = XDocument.Load("PurchaseOrders.xml")  
  
' LINQ to XML query  
Dim el1 As XElement = po.Root  
  
' XPath expression  
Dim el2 As XElement = po.XPathSelectElement("/PurchaseOrders")  
  
If el1 Is el2 Then  
    Console.WriteLine("Results are identical")  
Else  
    Console.WriteLine("Results differ")  
End If  
Console.WriteLine(el1.Name)  
```  
  
 This example produces the following output:  
  
```  
Results are identical  
PurchaseOrders  
```  
  
## See Also  
 [LINQ to XML for XPath Users (Visual Basic)](../VS_csharp/linq-to-xml-for-xpath-users--visual-basic-.md)