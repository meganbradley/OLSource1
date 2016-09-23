---
title: "How to: Find an Element with a Specific Attribute (Visual Basic)"
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
ms.assetid: 59fb7c19-d42f-40eb-8cf8-f1d5b9658eb7
caps.latest.revision: 3
---
# How to: Find an Element with a Specific Attribute (Visual Basic)
This topic shows how to find an element that has an attribute that has a specific value.  
  
## Example  
 The example shows how to find the `Address` element that has a `Type` attribute with a value of "Billing".  
  
 This example uses the following XML document: [Sample XML File: Typical Purchase Order (LINQ to XML)](../vs140/sample-xml-file--typical-purchase-order--linq-to-xml-2.md).  
  
```vb  
Dim root As XElement = XElement.Load("PurchaseOrder.xml")  
Dim address As IEnumerable(Of XElement) = _  
    From el In root.<Address> _  
    Where el.@Type = "Billing" _  
    Select el  
For Each el As XElement In address  
    Console.WriteLine(el)  
Next  
```  
  
 This code produces the following output:  
  
```xml  
  
          <Address Type="Billing">  
  <Name>Tai Yee</Name>  
  <Street>8 Oak Avenue</Street>  
  <City>Old Town</City>  
  <State>PA</State>  
  <Zip>95819</Zip>  
  <Country>USA</Country>  
</Address>  
```  
  
 Note that this example uses the [XML Child axis property](../vs140/xml-child-axis-property--visual-basic-.md), the [XML Attribute axis property](../vs140/xml-attribute-axis-property--visual-basic-.md), and the [XML Value property](../vs140/xml-value-property--visual-basic-.md).  
  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md).  
  
 This example uses the following XML document: [Sample XML File: Typical Purchase Order in a Namespace](../vs140/sample-xml-file--typical-purchase-order-in-a-namespace3.md).  
  
```vb  
Imports <xmlns:aw='http://www.adventure-works.com'>  
  
Module Module1  
    Sub Main()  
        Dim root As XElement = XElement.Load("PurchaseOrderInNamespace.xml")  
        Dim address As IEnumerable(Of XElement) = _  
            From el In root.<aw:Address> _  
            Where el.@aw:Type = "Billing" _  
            Select el  
        For Each el As XElement In address  
            Console.WriteLine(el)  
        Next  
    End Sub  
End Module  
```  
  
 This code produces the following output:  
  
```xml  
<aw:Address aw:Type="Billing" xmlns:aw="http://www.adventure-works.com">  
  <aw:Name>Tai Yee</aw:Name>  
  <aw:Street>8 Oak Avenue</aw:Street>  
  <aw:City>Old Town</aw:City>  
  <aw:State>PA</aw:State>  
  <aw:Zip>95819</aw:Zip>  
  <aw:Country>USA</aw:Country>  
</aw:Address>  
```  
  
## See Also  
 <xref:System.Xml.Linq.XElement.Attribute?qualifyHint=False>   
 <xref:System.Xml.Linq.XContainer.Elements?qualifyHint=False>   
 [Basic Queries (LINQ to XML) (Visual Basic)](../vs140/basic-queries--linq-to-xml---visual-basic-.md)   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [Projection Operations (Visual Basic)](../vs140/projection-operations--visual-basic-.md)