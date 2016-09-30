---
title: "Performance of Chained Queries (LINQ to XML) (Visual Basic)"
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
ms.assetid: 589f2adc-69f9-404d-b9d6-4c28dabea7f7
caps.latest.revision: 8
---
# Performance of Chained Queries (LINQ to XML) (Visual Basic)
One of the most important benefits of LINQ (and LINQ to XML) is that chained queries can perform as well as a single larger, more complicated query.  
  
 A chained query is a query that uses another query as its source. For example, in the following simple code, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> has <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> as its source:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This chained query provides the same performance profile as iterating through a linked list.  
  
-   The \<xref:System.Xml.Linq.XContainer.Elements*> axis has essentially the same performance as iterating through a linked list. \<xref:System.Xml.Linq.XContainer.Elements*> is implemented as an iterator with deferred execution. This means that it does some work in addition to iterating through the linked list, such as allocating the iterator object and keeping track of execution state. This work can be divided into two categories: the work that is done at the time the iterator is set up, and the work that is done during each iteration. The setup work is a small, fixed amount of work and the work done during each iteration is proportional to the number of items in the source collection.  
  
-   In <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause causes the query to call the \<xref:System.Linq.Enumerable.Where*> method. This method is also implemented as an iterator. The setup work consists of instantiating the delegate that will reference the lambda expression, plus the normal setup for an iterator. With each iteration, the delegate is called to execute the predicate. The setup work and the work done during each iteration is the similar to the work done while iterating through the axis.  
  
-   In <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the select clause causes the query to call the \<xref:System.Linq.Enumerable.Select*> method. This method has the same performance profile as the \<xref:System.Linq.Enumerable.Where*> method.  
  
-   In <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, both the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause and the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clause have the same performance profile as in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The iteration through <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is therefore directly proportional to the number of items in the source of the first query, in other words, linear time.  
  
## See Also  
 [Performance (LINQ to XML) (Visual Basic)](../vs140/performance--linq-to-xml---visual-basic-.md)