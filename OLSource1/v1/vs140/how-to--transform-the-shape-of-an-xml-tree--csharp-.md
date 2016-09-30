---
title: "How to: Transform the Shape of an XML Tree (C#)"
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
ms.assetid: 93c5d426-dea2-4709-a991-60204de42e8f
caps.latest.revision: 5
---
# How to: Transform the Shape of an XML Tree (C#)
The *shape* of an XML document refers to its element names, attribute names, and the characteristics of its hierarchy.  
  
 Sometimes you will have to change the shape of an XML document. For example, you might have to send an existing XML document to another system that requires different element and attribute names. You could go through the document, deleting and renaming elements as required, but using functional construction results in more readable and maintainable code. For more information about functional construction, see [Functional Construction (LINQ to XML) (C#)](../vs140/functional-construction--linq-to-xml---csharp-.md).  
  
 The first example changes the organization of the XML document. It moves complex elements from one location in the tree to another.  
  
 The second example in this topic creates an XML document with a different shape than the source document. It changes the casing of the element names, renames some elements, and leaves some elements from the source tree out of the transformed tree.  
  
## Example  
 The following code changes the shape of an XML file using embedded query expressions.  
  
 The source XML document in this example contains a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element under the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element that contains all customers. It also contains an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element under the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element that contains all orders. This example creates a new XML tree in which the orders for each customer are contained in an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element within the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element. The original document also contains a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element; this element will be removed from the re-shaped document.  
  
 This example uses the following XML document: [Sample XML File: Customers and Orders (LINQ to XML)](../vs140/sample-xml-file--customers-and-orders--linq-to-xml-2.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This example renames some elements and converts some attributes to elements.  
  
 The code calls <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, which returns a list of \<xref:System.Xml.Linq.XElement*> objects. The argument to the method is a query that determines the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> complex element where the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> attribute has a value of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 This example uses the following XML document: [Sample XML File: Typical Purchase Order (LINQ to XML)](../vs140/sample-xml-file--typical-purchase-order--linq-to-xml-1.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Projections and Transformations (LINQ to XML) (C#)](../vs140/projections-and-transformations--linq-to-xml---csharp-.md)