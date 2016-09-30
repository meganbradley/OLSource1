---
title: "Deferred Execution and Lazy Evaluation in LINQ to XML (Visual Basic)"
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
ms.assetid: 31998eed-b95e-47fb-a865-9de1f337d1fb
caps.latest.revision: 3
---
# Deferred Execution and Lazy Evaluation in LINQ to XML (Visual Basic)
Query and axis operations are often implemented to use deferred execution. This topic explains the requirements and advantages of deferred execution, and some implementation considerations.  
  
## Deferred Execution  
 Deferred execution means that the evaluation of an expression is delayed until its *realized* value is actually required. Deferred execution can greatly improve performance when you have to manipulate large data collections, especially in programs that contain a series of chained queries or manipulations. In the best case, deferred execution enables only a single iteration through the source collection.  
  
 The LINQ technologies make extensive use of deferred execution in both the members of core \<xref:System.Linq*?displayProperty=fullName> classes and in the extension methods in the various LINQ namespaces, such as \<xref:System.Xml.Linq.Extensions*?displayProperty=fullName>.  
  
## Eager vs. Lazy Evaluation  
 When you write a method that implements deferred execution, you also have to decide whether to implement the method using lazy evaluation or eager evaluation.  
  
-   In *lazy evaluation*, a single element of the source collection is processed during each call to the iterator. This is the typical way in which iterators are implemented.  
  
-   In *eager evaluation*, the first call to the iterator will result in the entire collection being processed. A temporary copy of the source collection might also be required. For example, the \<xref:System.Linq.Enumerable.OrderBy*> method has to sort the entire collection before it returns the first element.  
  
 Lazy evaluation usually yields better performance because it distributes overhead processing evenly throughout the evaluation of the collection and minimizes the use of temporary data. Of course, for some operations, there is no other option than to materialize intermediate results.  
  
## Next Steps  
 The next topic in this tutorial illustrates deferred execution:  
  
-   [Deferred Execution Example (Visual Basic)](../vs140/deferred-execution-example--visual-basic-.md)  
  
## See Also  
 [Tutorial: Chaining Queries Together (Visual Basic)](../vs140/tutorial--deferred-execution--visual-basic-.md)   
 [Concepts and Terminology (Functional Transformation) (Visual Basic)](../vs140/concepts-and-terminology--functional-transformation---visual-basic-.md)   
 [Aggregation Operations (Visual Basic)](../vs140/aggregation-operations--visual-basic-.md)