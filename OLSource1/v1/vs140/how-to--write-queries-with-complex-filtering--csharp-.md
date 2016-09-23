---
title: "How to: Write Queries with Complex Filtering (C#)"
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
ms.assetid: 4065d901-cf89-4e47-8bf9-abb65acfb003
caps.latest.revision: 3
---
# How to: Write Queries with Complex Filtering (C#)
Sometimes you want to write LINQ to XML queries with complex filters. For example, you might have to find all elements that have a child element with a particular name and value. This topic gives an example of writing a query with complex filtering.  
  
## Example  
 This example shows how to find all `PurchaseOrder` elements that have a child `Address` element that has a `Type` attribute equal to "Shipping" and a child `State` element equal to "NY". It uses a nested query in the `Where` clause, and the `Any` operator returns `true` if the collection has any elements in it. For information about using method-based query syntax, see [Query Syntax and Method Syntax in LINQ (C#)](../vs140/query-syntax-and-method-syntax-in-linq--csharp-.md).  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders (LINQ to XML)](../vs140/sample-xml-file--multiple-purchase-orders--linq-to-xml-2.md).  
  
 For more information about the `Any` operator, see [Quantifier Operations (C#)](../vs140/quantifier-operations--csharp-.md).  
  
```c#  
XElement root = XElement.Load("PurchaseOrders.xml");  
IEnumerable<XElement> purchaseOrders =  
    from el in root.Elements("PurchaseOrder")  
    where   
        (from add in el.Elements("Address")  
        where  
            (string)add.Attribute("Type") == "Shipping" &&  
            (string)add.Element("State") == "NY"  
        select add)  
        .Any()  
    select el;  
foreach (XElement el in purchaseOrders)  
    Console.WriteLine((string)el.Attribute("PurchaseOrderNumber"));  
```  
  
 This code produces the following output:  
  
```  
99505  
```  
  
## Example  
 The following example shows the same query for XML that is in a namespace. For more information, see [Working with XML Namespaces (C#)](../vs140/working-with-xml-namespaces--csharp-.md).  
  
 This example uses the following XML document: [Sample XML File: Multiple Purchase Orders in a Namespace](../vs140/sample-xml-file--multiple-purchase-orders-in-a-namespace2.md).  
  
```c#  
XElement root = XElement.Load("PurchaseOrdersInNamespace.xml");  
XNamespace aw = "http://www.adventure-works.com";  
IEnumerable<XElement> purchaseOrders =  
    from el in root.Elements(aw + "PurchaseOrder")  
    where  
        (from add in el.Elements(aw + "Address")  
         where  
             (string)add.Attribute(aw + "Type") == "Shipping" &&  
             (string)add.Element(aw + "State") == "NY"  
         select add)  
        .Any()  
    select el;  
foreach (XElement el in purchaseOrders)  
    Console.WriteLine((string)el.Attribute(aw + "PurchaseOrderNumber"));  
```  
  
 This code produces the following output:  
  
```  
99505  
```  
  
## See Also  
 <xref:System.Xml.Linq.XElement.Attribute?qualifyHint=False>   
 <xref:System.Xml.Linq.XContainer.Elements?qualifyHint=False>   
 [Basic Queries (LINQ to XML) (C#)](../vs140/basic-queries--linq-to-xml---csharp-.md)   
 [Projection Operations (C#)](../vs140/projection-operations--csharp-.md)   
 [Quantifier Operations (C#)](../vs140/quantifier-operations--csharp-.md)