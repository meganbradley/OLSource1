---
title: "How to: Find an Element with a Specific Child Element (Visual Basic)"
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
ms.assetid: b0d0a463-6a85-46c3-8453-ad25b0ecf93c
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
---
# How to: Find an Element with a Specific Child Element (Visual Basic)
This topic shows how to find a particular element that has a child element with a specific value.  
  
## Example  
 The example finds the `Test` element that has a `CommandLine` child element with the value of "Examp2.EXE".  
  
 This example uses the following XML document: [Sample XML File: Test Configuration (LINQ to XML)](../vs140/sample-xml-file--test-configuration--linq-to-xml-2.md).  
  
```vb  
Dim root As XElement = XElement.Load("TestConfig.xml")  
Dim tests As IEnumerable(Of XElement) = _  
    From el In root.<Test> _  
    Where el.<CommandLine>.Value = "Examp2.EXE" _  
    Select el  
For Each el as XElement In tests  
    Console.WriteLine(el.@TestId)  
Next  
```  
  
 This code produces the following output:  
  
```  
0002  
0006  
```  
  
 Note that this example uses the [XML Child axis property](../vs140/xml-child-axis-property--visual-basic-.md), the [XML Attribute axis property](../vs140/xml-attribute-axis-property--visual-basic-.md), and the [XML Value property](../vs140/xml-value-property--visual-basic-.md).  
  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md).  
  
 This example uses the following XML document: [Sample XML File: Test Configuration in a Namespace](../vs140/sample-xml-file--test-configuration-in-a-namespace3.md).  
  
```vb  
Imports <xmlns='http://www.adatum.com'>  
  
Module Module1  
    Sub Main()  
        Dim root As XElement = XElement.Load("TestConfigInNamespace.xml")  
        Dim tests As IEnumerable(Of XElement) = _  
            From el In root.<Test> _  
            Where el.<CommandLine>.Value = "Examp2.EXE" _  
            Select el  
        For Each el As XElement In tests  
            Console.WriteLine(el.@TestId)  
        Next  
    End Sub  
End Module  
```  
  
 This code produces the following output:  
  
```  
0002  
0006  
```  
  
## See Also  
 [Attribute](assetId:///M:System.Xml.Linq.XElement.Attribute(System.Xml.Linq.XName)?qualifyHint=False&autoUpgrade=True)   
 <xref:System.Xml.Linq.XContainer.Elements*>   
 [Basic Queries (LINQ to XML) (Visual Basic)](../vs140/basic-queries--linq-to-xml---visual-basic-.md)   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [Projection Operations (Visual Basic)](../vs140/projection-operations--visual-basic-.md)