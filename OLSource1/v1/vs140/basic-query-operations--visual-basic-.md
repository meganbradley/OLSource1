---
title: "Basic Query Operations (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "data sources [LINQ in Visual Basic]"
  - "Join clause [LINQ in Visual Basic]"
  - "ordering data [LINQ in Visual Basic]"
  - "projections [LINQ in Visual Basic]"
  - "LINQ [Visual Basic], query operations"
  - "Order By clause [LINQ in Visual Basic]"
  - "joining data [LINQ in Visual Basic]"
  - "queries [LINQ in Visual Basic], basic operations"
  - "selecting data [LINQ in Visual Basic]"
  - "Group By clause [LINQ in Visual Basic]"
  - "grouping data [LINQ in Visual Basic]"
  - "Select clause [LINQ in Visual Basic]"
ms.assetid: 1146f6d0-fcb8-4f4d-8223-c9db52620d21
caps.latest.revision: 41
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Basic Query Operations (Visual Basic)
This topic provides a brief introduction to [!INCLUDE[vbteclinqext](../vs140/includes/vbteclinqext_md.md)] expressions in Visual Basic, and to some of the typical kinds of operations that you perform in a query. For more information, see the following topics:  
  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)  
  
 [Queries](../vs140/queries--visual-basic-.md)  
  
 [Walkthrough: Writing Queries in Visual Basic](../vs140/walkthrough--writing-queries-in-visual-basic.md)  
  
## Specifying the Data Source (From)  
 In a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query, the first step is to specify the data source that you want to query. Therefore, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause in a query always comes first. Query operators select and shape the result based on the type of the source.  
  
 [!code[VbLINQBasicOps#1](../vs140/codesnippet/VisualBasic/basic-query-operations--visual-basic-_1.vb)]  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause specifies the data source, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and a *range variable*, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The range variable is like a loop iteration variable, except that in a query expression, no actual iteration occurs. When the query is executed, often by using a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> loop, the range variable serves as a reference to each successive element in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Because the compiler can infer the type of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, you do not have to specify it explicitly. For examples of queries written with and without explicit typing, see [Type Relationships in Query Operations (Visual Basic)](../vs140/type-relationships-in-query-operations--visual-basic-.md).  
  
 For more information about how to use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clause in Visual Basic, see [From Clause](../vs140/from-clause--visual-basic-.md).  
  
## Filtering Data (Where)  
 Probably the most common query operation is applying a filter in the form of a Boolean expression. The query then returns only those elements for which the expression is true. A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> clause is used to perform the filtering. The filter specifies which elements in the data source to include in the resulting sequence. In the following example, only those customers who have an address in London are included.  
  
 [!code[VbLINQBasicOps#2](../vs140/codesnippet/VisualBasic/basic-query-operations--visual-basic-_2.vb)]  
  
 You can use logical operators such as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to combine filter expressions in a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> clause. For example, to return only those customers who are from London and whose name is Devon, use the following code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To return customers from London or Paris, use the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more information about how to use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> clause in Visual Basic, see [Where Clause](../vs140/where-clause--visual-basic-.md).  
  
## Ordering Data (Order By)  
 It often is convenient to sort returned data into a particular order. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> clause will cause the elements in the returned sequence to be sorted on a specified field or fields. For example, the following query sorts the results based on the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> property. Because <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a string, the returned data will be sorted alphabetically, from A to Z.  
  
 [!code[VbLINQBasicOps#3](../vs140/codesnippet/VisualBasic/basic-query-operations--visual-basic-_3.vb)]  
  
 To order the results in reverse order, from Z to A, use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> clause. The default is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> when neither <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is specified.  
  
 For more information about how to use the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> clause in Visual Basic, see [Order By Clause](../vs140/order-by-clause--visual-basic-.md).  
  
## Selecting Data (Select)  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> clause specifies the form and content of returned elements. For example, you can specify whether your results will consist of complete <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> objects, just one <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> property, a subset of properties, a combination of properties from various data sources, or some new result type based on a computation. When the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> clause produces something other than a copy of the source element, the operation is called a *projection*.  
  
 To retrieve a collection that consists of complete <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> objects, select the range variable itself:  
  
 [!code[VbLINQBasicOps#4](../vs140/codesnippet/VisualBasic/basic-query-operations--visual-basic-_4.vb)]  
  
 If a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> instance is a large object that has many fields, and all that you want to retrieve is the name, you can select <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, as shown in the following example. Local type inference recognizes that this changes the result type from a collection of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> objects to a collection of strings.  
  
 [!code[VbLINQBasicOps#5](../vs140/codesnippet/VisualBasic/basic-query-operations--visual-basic-_5.vb)]  
  
 To select multiple fields from the data source, you have two choices:  
  
-   In the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> clause, specify the fields you want to include in the result. The compiler will define an anonymous type that has those fields as its properties. For more information, see [Anonymous Types](../vs140/anonymous-types--visual-basic-.md).  
  
     Because the returned elements in the following example are instances of an anonymous type, you cannot refer to the type by name elsewhere in your code. The compiler-designated name for the type contains characters that are not valid in normal Visual Basic code. In the following example, the elements in the collection that is returned by the query in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> are instances of an anonymous type  
  
     [!code[VbLINQBasicOps#6](../vs140/codesnippet/VisualBasic/basic-query-operations--visual-basic-_6.vb)]  
  
     -or-  
  
-   Define a named type that contains the particular fields that you want to include in the result, and create and initialize instances of the type in the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> clause. Use this option only if you have to use individual results outside the collection in which they are returned, or if you have to pass them as parameters in method calls. The type of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> in the following example is IEnumerable(Of NamePhone).  
  
     [!code[VbLINQBasicOps#7](../vs140/codesnippet/VisualBasic/basic-query-operations--visual-basic-_7.vb)]  
  
     [!code[VbLINQBasicOps#8](../vs140/codesnippet/VisualBasic/basic-query-operations--visual-basic-_8.vb)]  
  
 For more information about how to use the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> clause in Visual Basic, see [Select Clause](../vs140/select-clause--visual-basic-.md).  
  
## Joining Data (Join and Group Join)  
 You can combine more than one data source in the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> clause in several ways. For example, the following code uses two data sources and implicitly combines properties from both of them in the result. The query selects students whose last names start with a vowel.  
  
 [!code[VbLINQBasicOps#9](../vs140/codesnippet/VisualBasic/basic-query-operations--visual-basic-_9.vb)]  
  
> [!NOTE]
>  You can run this code with the list of students created in [How to: Create a List of Items](../vs140/how-to--create-a-list-of-items.md).  
  
 The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> keyword is equivalent to an <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> in SQL. It combines two collections based on matching key values between elements in the two collections. The query returns all or part of the collection elements that have matching key values. For example, the following code duplicates the action of the previous implicit join.  
  
 [!code[VbLINQBasicOps#10](../vs140/codesnippet/VisualBasic/basic-query-operations--visual-basic-_10.vb)]  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> combines collections into a single hierarchical collection, just like a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> in SQL. For more information, see [Join Clause](../vs140/join-clause--visual-basic-.md) and [Group Join Clause](../vs140/group-join-clause--visual-basic-.md).  
  
## Grouping Data (Group By)  
 You can add a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> clause to group the elements in a query result according to one or more fields of the elements. For example, the following code groups students by class year.  
  
 [!code[VbLINQBasicOps#11](../vs140/codesnippet/VisualBasic/basic-query-operations--visual-basic-_11.vb)]  
  
 If you run this code using the list of students created in [How to: Create a List of Items](../vs140/how-to--create-a-list-of-items.md), the output from the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> statement is:  
  
 Year: Junior  
  
 Tucker, Michael  
  
 Garcia, Hugo  
  
 Garcia, Debra  
  
 Tucker, Lance  
  
 Year: Senior  
  
 Omelchenko, Svetlana  
  
 Osada, Michiko  
  
 Fakhouri, Fadi  
  
 Feng, Hanying  
  
 Adams, Terry  
  
 Year: Freshman  
  
 Mortensen, Sven  
  
 Garcia, Cesar  
  
 The variation shown in the following code orders the class years, and then orders the students within each year by last name.  
  
 [!code[VbLINQBasicOps#12](../vs140/codesnippet/VisualBasic/basic-query-operations--visual-basic-_12.vb)]  
  
 For more information about <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, see [Group By Clause](../vs140/group-by-clause--visual-basic-.md).  
  
## See Also  
 \<xref:System.Collections.Generic.IEnumerable`1*>   
 [Getting Started with LINQ in Visual Basic](../vs140/getting-started-with-linq-in-visual-basic.md)   
 [Queries](../vs140/queries--visual-basic-.md)   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)