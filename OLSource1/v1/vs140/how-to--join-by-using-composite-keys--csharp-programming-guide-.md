---
title: "How to: Join by Using Composite Keys (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "composite keys [LINQ in C#]"
  - "joins [C#]"
  - "query expressions [LINQ in C#], joins"
  - "joins [C#], composite keys"
  - "queries [LINQ in C#], joins"
ms.assetid: 3e015b3f-9cca-4b0c-aa97-dca0d36ea592
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Join by Using Composite Keys (C# Programming Guide)
This example shows how to perform join operations in which you want to use more than one key to define a match. This is accomplished by using a composite key. You create a composite key as an anonymous type or named typed with the values that you want to compare. If the query variable will be passed across method boundaries, use a named type that overrides \<xref:System.Object.Equals*> and \<xref:System.Object.GetHashCode*> for the key. The names of the properties, and the order in which they occur, must be identical in each key.  
  
## Example  
 The following example demonstrates how to use a composite key to join data from three tables:  
  
```  
var query = from o in db.Orders  
    from p in db.Products  
    join d in db.OrderDetails   
        on new {o.OrderID, p.ProductID} equals new {d.OrderID,        d.ProductID} into details  
        from d in details  
        select new {o.OrderID, p.ProductID, d.UnitPrice};  
```  
  
 Type inference on composite keys depends on the names of the properties in the keys, and the order in which they occur. If the properties in the source sequences do not have the same names, you must assign new names in the keys. For example, if the `Orders` table and `OrderDetails` table each used different names for their columns, you could create composite keys by assigning identical names in the anonymous types:  
  
```  
join...on new {Name = o.CustomerName, ID = o.CustID} equals   
    new {Name = d.CustName, ID = d.CustID }  
```  
  
 Composite keys can be also used in a `group` clause.  
  
## Compiling the Code  
  
-   To compile and run this code, follow these steps:  
  
-   Open [How to: Create a Data Connection to the Northwind Database](assetId:///cc6cb79f-d035-41f8-b398-8d4a45922bfb) and follow the instructions to set up the project and create the database connection. For more information, see [How to: Install Sample Databases](assetId:///ed1291f6-604c-4972-ae22-0345c6dea12e).  
  
-   In samples.cs, create a new empty method that takes a Northwind input parameter named db (similar to the other methods in that file). Paste the code from this example into the method body.  
  
-   Modify program.cs to call the new method from `Main`.  
  
-   Press F5 to compile and run the query.  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md)   
 [group clause (C# Reference)](../vs140/group-clause--csharp-reference-.md)