---
title: "How to: Filter on Element Names (LINQ to XML) (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 1849fb03-f075-421f-863c-e8fb32773cdf
caps.latest.revision: 7
---
# How to: Filter on Element Names (LINQ to XML) (C#)
When you call one of the methods that return <xref:System.Collections.Generic.IEnumerable`1*> of <xref:System.Xml.Linq.XElement*>, you can filter on the element name.  
  
## Example  
 This example retrieves a collection of descendants that is filtered to contain only descendants with the specified name.  
  
 This example uses the following XML document: [Sample XML File: Typical Purchase Order (LINQ to XML)](../VS_csharp/sample-xml-file--typical-purchase-order--linq-to-xml-1.md).  
  
```c#  
XElement po = XElement.Load("PurchaseOrder.xml");  
IEnumerable<XElement> items =  
    from el in po.Descendants("ProductName")  
    select el;  
foreach(XElement prdName in items)  
    Console.WriteLine(prdName.Name + ":" + (string) prdName);  
```  
  
 This code produces the following output:  
  
```  
ProductName:Lawnmower  
ProductName:Baby Monitor  
```  
  
 The other methods that return <xref:System.Collections.Generic.IEnumerable`1*> of <xref:System.Xml.Linq.XElement*> collections follow the same pattern. Their signatures are similar to <xref:System.Xml.Linq.XContainer.Elements*> and <xref:System.Xml.Linq.XContainer.Descendants*>. The following is the complete list of methods that have similar method signatures:  
  
-   <xref:System.Xml.Linq.XNode.Ancestors*>  
  
-   <xref:System.Xml.Linq.XContainer.Descendants*>  
  
-   <xref:System.Xml.Linq.XContainer.Elements*>  
  
-   <xref:System.Xml.Linq.XNode.ElementsAfterSelf*>  
  
-   <xref:System.Xml.Linq.XNode.ElementsBeforeSelf*>  
  
-   <xref:System.Xml.Linq.XElement.AncestorsAndSelf*>  
  
-   <xref:System.Xml.Linq.XElement.DescendantsAndSelf*>  
  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (C#)](../VS_csharp/working-with-xml-namespaces--csharp-.md).  
  
 This example uses the following XML document: [Sample XML File: Typical Purchase Order in a Namespace](../VS_csharp/sample-xml-file--typical-purchase-order-in-a-namespace1.md).  
  
```c#  
XNamespace aw = "http://www.adventure-works.com";  
XElement po = XElement.Load("PurchaseOrderInNamespace.xml");  
IEnumerable<XElement> items =  
    from el in po.Descendants(aw + "ProductName")  
    select el;  
foreach (XElement prdName in items)  
    Console.WriteLine(prdName.Name + ":" + (string)prdName);  
```  
  
 This code produces the following output:  
  
```  
{http://www.adventure-works.com}ProductName:Lawnmower  
{http://www.adventure-works.com}ProductName:Baby Monitor  
```  
  
## See Also  
 [LINQ to XML Axes (C#)](../VS_csharp/linq-to-xml-axes--csharp-.md)