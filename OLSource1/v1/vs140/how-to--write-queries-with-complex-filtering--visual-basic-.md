---
title: "How to: Write Queries with Complex Filtering (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
ms.assetid: bf286ffc-7990-4b00-a4eb-ee3d70129950
caps.latest.revision: 7
---
# How to: Write Queries with Complex Filtering (Visual Basic)
Sometimes you want to write LINQ to XML queries with complex filters. For example, you might have to find all elements that have a child element with a particular name and value. This topic gives an example of writing a query with complex filtering.  
  
## Example  
 This example shows how to find all `PurchaseOrder` elements that have a child `Address` element that has a `Type` attribute equal to "Shipping" and a child `State` element equal to "NY". It uses a nested query in the `Where` clause, and the `Any` operator returns `True` if the collection has any elements in it.  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders (LINQ to XML)](../vs140/sample-xml-file--multiple-purchase-orders--linq-to-xml-3.md).  
  
 For more information about the `Any` operator, see [Quantifier Operations (Visual Basic)](../vs140/quantifier-operations--visual-basic-.md).  
  
```vb  
Dim root As XElement = XElement.Load("PurchaseOrders.xml")  
Dim purchaseOrders As IEnumerable(Of XElement) = _  
    From el In root.<PurchaseOrder> _  
    Where _  
        (From add In el.<Address> _  
        Where _  
             add.@Type = "Shipping" And _  
             add.<State>.Value = "NY" _  
        Select add) _  
    .Any() _  
    Select el  
For Each el As XElement In purchaseOrders  
    Console.WriteLine(el.@PurchaseOrderNumber)  
Next  
```  
  
 This code produces the following output:  
  
```  
99505  
```  
  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md).  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders in a Namespace](../vs140/sample-xml-file--multiple-purchase-orders-in-a-namespace3.md).  
  
```vb  
Imports <xmlns:aw='http://www.adventure-works.com'>  
  
Module Module1  
    Sub Main()  
        Dim root As XElement = XElement.Load("PurchaseOrdersInNamespace.xml")  
        Dim purchaseOrders As IEnumerable(Of XElement) = _  
            From el In root.<aw:PurchaseOrder> _  
            Where _  
                (From add In el.<aw:Address> _  
                Where _  
                     add.@aw:Type = "Shipping" And _  
                     add.<aw:State>.Value = "NY" _  
                Select add) _  
            .Any() _  
            Select el  
        For Each el As XElement In purchaseOrders  
            Console.WriteLine(el.@aw:PurchaseOrderNumber)  
        Next  
    End Sub  
End Module  
```  
  
 This code produces the following output:  
  
```  
99505  
```  
  
## See Also  
 <xref:System.Xml.Linq.XElement.Attribute?qualifyHint=False>   
 <xref:System.Xml.Linq.XContainer.Elements?qualifyHint=False>   
 [Basic Queries (LINQ to XML) (Visual Basic)](../vs140/basic-queries--linq-to-xml---visual-basic-.md)   
 [XML Child Axis Property](../vs140/xml-child-axis-property--visual-basic-.md)   
 [XML Attribute Axis Property](../vs140/xml-attribute-axis-property--visual-basic-.md)   
 [XML Value Property](../vs140/xml-value-property--visual-basic-.md)   
 [Projection Operations (Visual Basic)](../vs140/projection-operations--visual-basic-.md)   
 [Quantifier Operations (Visual Basic)](../vs140/quantifier-operations--visual-basic-.md)