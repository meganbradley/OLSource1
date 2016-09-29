---
title: "Aggregation Operations (Visual Basic)"
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
ms.assetid: 0f47e92c-5dd2-4007-baf4-c5fe5dc3b4a8
caps.latest.revision: 7
---
# Aggregation Operations (Visual Basic)
An aggregation operation computes a single value from a collection of values. An example of an aggregation operation is calculating the average daily temperature from a month's worth of daily temperature values.  
  
 The following illustration shows the results of two different aggregation operations on a sequence of numbers. The first operation sums the numbers. The second operation returns the maximum value in the sequence.  
  
 ![LINQ Aggregation Operations](../vs140/media/linq_aggregation.png "LINQ_Aggregation")  
  
 The standard query operator methods that perform aggregation operations are listed in the following section.  
  
## Methods  
  
|Method Name|Description|Visual Basic Query Expression Syntax|More Information|  
|-----------------|-----------------|------------------------------------------|----------------------|  
|Aggregate|Performs a custom aggregation operation on the values of a collection.|Not applicable.|<xref:System.Linq.Enumerable.Aggregate*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.Aggregate*?displayProperty=fullName>|  
|Average|Calculates the average value of a collection of values.|`Aggregate … In … Into Average()`|<xref:System.Linq.Enumerable.Average*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.Average*?displayProperty=fullName>|  
|Count|Counts the elements in a collection, optionally only those elements that satisfy a predicate function.|`Aggregate … In … Into Count()`|<xref:System.Linq.Enumerable.Count*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.Count*?displayProperty=fullName>|  
|LongCount|Counts the elements in a large collection, optionally only those elements that satisfy a predicate function.|`Aggregate … In … Into LongCount()`|<xref:System.Linq.Enumerable.LongCount*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.LongCount*?displayProperty=fullName>|  
|Max|Determines the maximum value in a collection.|`Aggregate … In … Into Max()`|<xref:System.Linq.Enumerable.Max*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.Max*?displayProperty=fullName>|  
|Min|Determines the minimum value in a collection.|`Aggregate … In … Into Min()`|<xref:System.Linq.Enumerable.Min*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.Min*?displayProperty=fullName>|  
|Sum|Calculates the sum of the values in a collection.|`Aggregate … In … Into Sum()`|<xref:System.Linq.Enumerable.Sum*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.Sum*?displayProperty=fullName>|  
  
## Query Expression Syntax Examples  
  
### Average  
 The following code example uses the `Aggregate Into Average` clause in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] to calculate the average temperature in an array of numbers that represent temperatures.  
  
 [!code[CsLINQAggregating#1](../vs140/codesnippet/VisualBasic/aggregation-operations--visual-basic-_1.vb)]  
  
### Count  
 The following code example uses the `Aggregate Into Count` clause in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] to count the number of values in an array that are greater than or equal to 80.  
  
 [!code[CsLINQAggregating#2](../vs140/codesnippet/VisualBasic/aggregation-operations--visual-basic-_2.vb)]  
  
### LongCount  
 The following code example uses the `Aggregate Into LongCount` clause to count the number of values in an array.  
  
 [!code[CsLINQAggregating#3](../vs140/codesnippet/VisualBasic/aggregation-operations--visual-basic-_3.vb)]  
  
### Max  
 The following code example uses the `Aggregate Into Max` clause  to calculate the maximum temperature in an array of numbers that represent temperatures.  
  
 [!code[CsLINQAggregating#4](../vs140/codesnippet/VisualBasic/aggregation-operations--visual-basic-_4.vb)]  
  
### Min  
 The following code example uses the `Aggregate Into Min` clause  to calculate the minimum temperature in an array of numbers that represent temperatures.  
  
 [!code[CsLINQAggregating#5](../vs140/codesnippet/VisualBasic/aggregation-operations--visual-basic-_5.vb)]  
  
### Sum  
 The following code example uses the `Aggregate Into Sum` clause  to calculate the total expense amount from an array of values that represent expenses.  
  
 [!code[CsLINQAggregating#6](../vs140/codesnippet/VisualBasic/aggregation-operations--visual-basic-_6.vb)]  
  
## See Also  
 <xref:System.Linq*>   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md)   
 [How to: Compute Column Values in a CSV Text File (LINQ) (Visual Basic)](../vs140/how-to--compute-column-values-in-a-csv-text-file--linq---visual-basic-.md)   
 [How To: Count, Sum, or Average Data by Using LINQ (Visual Basic)](../vs140/how-to--count--sum--or-average-data-by-using-linq--visual-basic-.md)   
 [How To: Find the Minimum or Maximum Value in a Query Result by Using LINQ (Visual Basic)](../vs140/how-to--find-the-minimum-or-maximum-value-in-a-query-result-by-using-linq--visual-basic-.md)   
 [How to: Query for the Largest File or Files in a Directory Tree (LINQ) (Visual Basic)](../vs140/how-to--query-for-the-largest-file-or-files-in-a-directory-tree--linq---visual-basic-.md)   
 [How to: Query for the Total Number of Bytes in a Set of Folders (LINQ) (Visual Basic)](../vs140/how-to--query-for-the-total-number-of-bytes-in-a-set-of-folders--linq---visual-basic-.md)