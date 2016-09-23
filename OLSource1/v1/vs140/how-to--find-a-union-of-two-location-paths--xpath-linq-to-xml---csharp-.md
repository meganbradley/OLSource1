---
title: "How to: Find a Union of Two Location Paths (XPath-LINQ to XML) (C#)"
ms.custom: na
ms.date: 09/22/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
ms.assetid: 069622d3-2b58-4919-8903-710a564c0788
caps.latest.revision: 7
---
# How to: Find a Union of Two Location Paths (XPath-LINQ to XML) (C#)
XPath allows you to find the union of the results of two XPath location paths.  
  
 The XPath expression is:  
  
 `//Category|//Price`  
  
 You can achieve the same results by using the <xref:System.Linq.Enumerable.Concat``1?qualifyHint=False> standard query operator.  
  
## Example  
 This example finds all of the `Category` elements and all of the `Price` elements, and concatenates them into a single collection. Note that the [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] query calls <xref:System.Xml.Linq.Extensions.InDocumentOrder``1?qualifyHint=False> to order the results. The results of the XPath expression evaluation are also in document order.  
  
 This example uses the following XML document: [Sample XML File: Numerical Data (LINQ to XML)](../vs140/sample-xml-file--numerical-data--linq-to-xml-3.md).  
  
```c#  
XDocument data = XDocument.Load("Data.xml");  
  
// LINQ to XML query  
IEnumerable<XElement> list1 =  
    data  
    .Descendants("Category")  
    .Concat(  
        data  
        .Descendants("Price")  
    )  
    .InDocumentOrder();  
  
// XPath expression  
IEnumerable<XElement> list2 = data.XPathSelectElements("//Category|//Price");  
  
if (list1.Count() == list2.Count() &&  
        list1.Intersect(list2).Count() == list1.Count())  
    Console.WriteLine("Results are identical");  
else  
    Console.WriteLine("Results differ");  
foreach (XElement el in list1)  
    Console.WriteLine(el);  
```  
  
 This example produces the following output:  
  
```  
Results are identical  
<Category>A</Category>  
<Price>24.50</Price>  
<Category>B</Category>  
<Price>89.99</Price>  
<Category>A</Category>  
<Price>4.95</Price>  
<Category>A</Category>  
<Price>66.00</Price>  
<Category>B</Category>  
<Price>.99</Price>  
<Category>A</Category>  
<Price>29.00</Price>  
<Category>B</Category>  
<Price>6.99</Price>  
```  
  
## See Also  
 [LINQ to XML for XPath Users (C#)](../vs140/linq-to-xml-for-xpath-users--csharp-.md)