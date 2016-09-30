---
title: "Data Transformations with LINQ (C#)"
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
  - "LINQ [C#], data transformations"
  - "source elements [LINQ in C#]"
  - "joining multiple inputs [LINQ in C#]"
  - "multiple outputs for one output sequence [LINQ in C#]"
  - "subset of source elements [LINQ in C#]"
  - "data sources [LINQ in C#], data transformations"
  - "data transformations [LINQ in C#]"
ms.assetid: 674eae9e-bc72-4a88-aed3-802b45b25811
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data Transformations with LINQ (C#)
[!INCLUDE[vbteclinqext](../vs140/includes/vbteclinqext_md.md)] is not only about retrieving data. It is also a powerful tool for transforming data. By using a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query, you can use a source sequence as input and modify it in many ways to create a new output sequence. You can modify the sequence itself without modifying the elements themselves by sorting and grouping. But perhaps the most powerful feature of [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries is the ability to create new types. This is accomplished in the [select](../vs140/select-clause--csharp-reference-.md) clause. For example, you can perform the following tasks:  
  
-   Merge multiple input sequences into a single output sequence that has a new type.  
  
-   Create output sequences whose elements consist of only one or several properties of each element in the source sequence.  
  
-   Create output sequences whose elements consist of the results of operations performed on the source data.  
  
-   Create output sequences in a different format. For example, you can transform data from SQL rows or text files into XML.  
  
 These are just several examples. Of course, these transformations can be combined in various ways in the same query. Furthermore, the output sequence of one query can be used as the input sequence for a new query.  
  
## Joining Multiple Inputs into One Output Sequence  
 You can use a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query to create an output sequence that contains elements from more than one input sequence. The following example shows how to combine two in-memory data structures, but the same principles can be applied to combine data from XML or SQL or DataSet sources. Assume the following two class types:  
  
 [!code[CsLINQGettingStarted#7](../vs140/codesnippet/CSharp/data-transformations-with-linq--csharp-_1.cs)]  
  
 The following example shows the query:  
  
 [!code[CSLinqGettingStarted#8](../vs140/codesnippet/CSharp/data-transformations-with-linq--csharp-_2.cs)]  
  
 For more information, see [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md) and [select clause (C# Reference)](../vs140/select-clause--csharp-reference-.md).  
  
## Selecting a Subset of each Source Element  
 There are two primary ways to select a subset of each element in the source sequence:  
  
1.  To select just one member of the source element, use the dot operation. In the following example, assume that a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object contains several public properties including a string named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. When executed, this query will produce an output sequence of strings.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  To create elements that contain more than one property from the source element, you can use an object initializer with either a named object or an anonymous type. The following example shows the use of an anonymous type to encapsulate two properties from each <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more information, see [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md) and [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md).  
  
## Transforming in-Memory Objects into XML  
 [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries make it easy to transform data between in-memory data structures, SQL databases, [!INCLUDE[vstecado](../vs140/includes/vstecado_md.md)] Datasets and XML streams or documents. The following example transforms objects in an in-memory data structure into XML elements.  
  
 [!code[CsLINQGettingStarted#9](../vs140/codesnippet/CSharp/data-transformations-with-linq--csharp-_3.cs)]  
  
 The code produces the following XML output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For more information, see [Creating XML Trees in C# (LINQ to XML)](../vs140/creating-xml-trees-in-csharp--linq-to-xml-2.md).  
  
## Performing Operations on Source Elements  
 An output sequence might not contain any elements or element properties from the source sequence. The output might instead be a sequence of values that is computed by using the source elements as input arguments. The following simple query, when it is executed, outputs a sequence of strings whose values represent a calculation based on the source sequence of elements of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Calling methods in query expressions is not supported if the query will be translated into some other domain. For example, you cannot call an ordinary C# method in [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)] because SQL Server has no context for it. However, you can map stored procedures to methods and call those. For more information, see [Stored Procedures: Mapping and Calling (LINQ to SQL)](assetId:///4d23dd7a-a85f-44ff-a717-af7d0950c0fc).  
  
 [!code[CsLINQGettingStarted#10](../vs140/codesnippet/CSharp/data-transformations-with-linq--csharp-_4.cs)]  
  
## See Also  
 [Language-Integrated Query (LINQ) (C#)](../vs140/language-integrated-query--linq---csharp-.md)   
 [LINQ to SQL](assetId:///73d13345-eece-471a-af40-4cc7a2f11655)   
 [LINQ to DataSet](assetId:///743e3755-3ecb-45a2-8d9b-9ed41f0dcf17)   
 [LINQ to XML (C#)](../vs140/linq-to-xml--csharp-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [select clause (C# Reference)](../vs140/select-clause--csharp-reference-.md)