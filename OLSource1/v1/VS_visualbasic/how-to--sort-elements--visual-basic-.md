---
title: "How to: Sort Elements (Visual Basic)"
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
ms.assetid: c2c09279-6c8a-482e-8e71-b1453a815052
caps.latest.revision: 7
---
# How to: Sort Elements (Visual Basic)
This example shows how to write a query that sorts its results.  
  
## Example  
 This example uses the following XML document: [Sample XML File: Numerical Data (LINQ to XML)](../VS_csharp/sample-xml-file--numerical-data--linq-to-xml-2.md).  
  
```vb  
Dim root As XElement = XElement.Load("Data.xml")  
Dim prices As IEnumerable(Of Decimal) = _  
    From el In root.<Data> _  
    Let price = Convert.ToDecimal(el.<Price>.Value) _  
    Order By (price) _  
    Select price  
For Each el As Decimal In prices  
    Console.WriteLine(el)  
Next  
```  
  
 This code produces the following output:  
  
```  
0.99  
4.95  
6.99  
24.50  
29.00  
66.00  
89.99  
```  
  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (Visual Basic)](../VS_csharp/working-with-xml-namespaces--visual-basic-.md).  
  
 This example uses the following XML document: [Sample XML File: Numerical Data in a Namespace](../VS_csharp/sample-xml-file--numerical-data-in-a-namespace1.md).  
  
```vb  
Imports <xmlns='http://www.adatum.com'>  
  
Module Module1  
    Sub Main()  
        Dim root As XElement = XElement.Load("DataInNamespace.xml")  
        Dim prices As IEnumerable(Of Decimal) = _  
            From el In root.<Data> _  
            Let price = Convert.ToDecimal(el.<Price>.Value) _  
            Order By (price) _  
            Select price  
        For Each el As Decimal In prices  
            Console.WriteLine(el)  
        Next  
    End Sub  
End Module  
```  
  
 This code produces the following output:  
  
```  
0.99  
4.95  
6.99  
24.50  
29.00  
66.00  
89.99  
```  
  
## See Also  
 [Sorting Data (Visual Basic)](../VS_csharp/sorting-data--visual-basic-.md)   
 [Basic Queries (LINQ to XML) (Visual Basic)](../VS_csharp/basic-queries--linq-to-xml---visual-basic-.md)