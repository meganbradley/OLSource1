---
title: "How to: Join Two Collections (LINQ to XML) (Visual Basic)"
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
ms.assetid: 5a5758d4-906b-4285-908d-5b930db192e6
caps.latest.revision: 7
---
# How to: Join Two Collections (LINQ to XML) (Visual Basic)
An element or attribute in an XML document can sometimes refer to another element or attribute. For example, the [Sample XML File: Customers and Orders (LINQ to XML)](../vs140/sample-xml-file--customers-and-orders--linq-to-xml-1.md) XML document contains a list of customers and a list of orders. Each <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element contains a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute. Each <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element contains a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element in each order refers to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attribute in a customer.  
  
 The topic [Sample XSD File: Customers and Orders](../vs140/sample-xsd-file--customers-and-orders2.md) contains an XSD that can be used to validate this document. It uses the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> features of XSD to establish that the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element is a key, and to establish a relationship between the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element in each <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element and the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> attribute in each <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element.  
  
 With [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)], you can take advantage of this relationship by using the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> clause.  
  
 Note that because there is no index available, such joining will have poor runtime performance.  
  
 For more detailed information about <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, see [Join Operations (Visual Basic)](../vs140/join-operations--visual-basic-.md).  
  
## Example  
 The following example joins the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> elements to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> elements, and generates a new XML document that includes the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> element in the orders.  
  
 Before executing the query, the example validates that the document complies with the schema in [Sample XSD File: Customers and Orders](../vs140/sample-xsd-file--customers-and-orders2.md). This ensures that the join clause will always work.  
  
 This query first retrieves all <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> elements, and then joins them to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> elements. It selects only the orders for customers with a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> greater than "K". It then projects a new <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> element that contains the customer information within each order.  
  
 This example uses the following XML document: [Sample XML File: Customers and Orders (LINQ to XML)](../vs140/sample-xml-file--customers-and-orders--linq-to-xml-1.md).  
  
 This example uses the following XSD schema: [Sample XSD File: Customers and Orders](../vs140/sample-xsd-file--customers-and-orders2.md).  
  
 Note that joining in this fashion will not perform very well. Joins are performed via a linear search. There are no hash tables or indexes to help with performance.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Advanced Query Techniques (LINQ to XML) (Visual Basic)](../vs140/advanced-query-techniques--linq-to-xml---visual-basic-.md)