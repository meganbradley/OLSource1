---
title: "Aggregation Operations (C#)"
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
ms.assetid: 6fc035e5-7639-48b8-bc7f-b093dd31b039
caps.latest.revision: 3
---
# Aggregation Operations (C#)
An aggregation operation computes a single value from a collection of values. An example of an aggregation operation is calculating the average daily temperature from a month's worth of daily temperature values.  
  
 The following illustration shows the results of two different aggregation operations on a sequence of numbers. The first operation sums the numbers. The second operation returns the maximum value in the sequence.  
  
 ![LINQ Aggregation Operations](../vs140/media/linq_aggregation.png "LINQ_Aggregation")  
  
 The standard query operator methods that perform aggregation operations are listed in the following section.  
  
## Methods  
  
|Method Name|Description|C# Query Expression Syntax|More Information|  
|-----------------|-----------------|---------------------------------|----------------------|  
|Aggregate|Performs a custom aggregation operation on the values of a collection.|Not applicable.|<xref:System.Linq.Enumerable.Aggregate``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Aggregate``1?qualifyHint=True>|  
|Average|Calculates the average value of a collection of values.|Not applicable.|<xref:System.Linq.Enumerable.Average?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Average?qualifyHint=True>|  
|Count|Counts the elements in a collection, optionally only those elements that satisfy a predicate function.|Not applicable.|<xref:System.Linq.Enumerable.Count``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Count``1?qualifyHint=True>|  
|LongCount|Counts the elements in a large collection, optionally only those elements that satisfy a predicate function.|Not applicable.|<xref:System.Linq.Enumerable.LongCount``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.LongCount``1?qualifyHint=True>|  
|Max|Determines the maximum value in a collection.|Not applicable.|<xref:System.Linq.Enumerable.Max?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Max``1?qualifyHint=True>|  
|Min|Determines the minimum value in a collection.|Not applicable.|<xref:System.Linq.Enumerable.Min?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Min``1?qualifyHint=True>|  
|Sum|Calculates the sum of the values in a collection.|Not applicable.|<xref:System.Linq.Enumerable.Sum?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Sum?qualifyHint=True>|  
  
## See Also  
 <xref:System.Linq?qualifyHint=False>   
 [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)   
 [How to: Compute Column Values in a CSV Text File (LINQ) (C#)](../vs140/how-to--compute-column-values-in-a-csv-text-file--linq---csharp-.md)   
 [How to: Query for the Largest File or Files in a Directory Tree (LINQ) (C#)](../vs140/how-to--query-for-the-largest-file-or-files-in-a-directory-tree--linq---csharp-.md)   
 [How to: Query for the Total Number of Bytes in a Set of Folders (LINQ) (C#)](../vs140/how-to--query-for-the-total-number-of-bytes-in-a-set-of-folders--linq---csharp-.md)