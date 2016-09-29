---
title: "How to: Find Preceding Siblings (XPath-LINQ to XML) (Visual Basic)"
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
ms.assetid: 59055718-d0a7-4db3-8901-18dd33587703
caps.latest.revision: 5
---
# How to: Find Preceding Siblings (XPath-LINQ to XML) (Visual Basic)
This topic compares the XPath `preceding-sibling` axis to the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] child <xref:System.Xml.Linq.XNode.ElementsBeforeSelf*?displayProperty=fullName> axis.  
  
 The XPath expression is:  
  
 `preceding-sibling::*`  
  
 Note that the results of both <xref:System.Xml.XPath.Extensions.XPathSelectElements*> and <xref:System.Xml.Linq.XNode.ElementsBeforeSelf*?displayProperty=fullName> are in document order.  
  
## Example  
 The following example finds the `FullAddress` element, and then retrieves the previous elements using the `preceding-sibling` axis.  
  
 This example uses the following XML document: [Sample XML File: Customers and Orders (LINQ to XML)](../vs140/sample-xml-file--customers-and-orders--linq-to-xml-1.md).  
  
```vb  
Dim co As XElement = XElement.Load("CustomersOrders.xml")  
Dim add As XElement = co.<Customers>.<Customer>. _  
        <FullAddress>.FirstOrDefault  
  
' LINQ to XML query  
Dim list1 As IEnumerable(Of XElement) = add.ElementsBeforeSelf()  
  
' XPath expression  
Dim list2 As IEnumerable(Of XElement) = add.XPathSelectElements("preceding-sibling::*")  
  
If list1.Count() = list2.Count() And _  
        list1.Intersect(list2).Count() = list1.Count() Then  
    Console.WriteLine("Results are identical")  
Else  
    Console.WriteLine("Results differ")  
End If  
For Each el As XElement In list2  
    Console.WriteLine(el)  
Next  
```  
  
 This example produces the following output:  
  
```  
Results are identical  
<CompanyName>Great Lakes Food Market</CompanyName>  
<ContactName>Howard Snyder</ContactName>  
<ContactTitle>Marketing Manager</ContactTitle>  
<Phone>(503) 555-7555</Phone>  
```  
  
## See Also  
 [LINQ to XML for XPath Users (Visual Basic)](../vs140/linq-to-xml-for-xpath-users--visual-basic-.md)