---
title: "Introduction to LINQ in Visual Basic"
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
  - "queries [LINQ in Visual Basic], about LINQ in Visual Basic queries"
  - "query execution [LINQ in Visual Basic]"
  - "range variables"
  - "LINQ [Visual Basic]"
  - "LINQ [Visual Basic], about LINQ in Visual Basic"
  - "query expressions [LINQ in Visual Basic]"
  - "LINQ"
  - "deferred execution"
  - "iteration variables"
ms.assetid: 3047d86e-0d49-40e2-928b-dc02e46c7984
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Introduction to LINQ in Visual Basic
Language-Integrated Query (LINQ) adds query capabilities to [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] and provides simple and powerful capabilities when you work with all kinds of data. Rather than sending a query to a database to be processed, or working with different query syntax for each type of data that you are searching, LINQ introduces queries as part of the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] language. It uses a unified syntax regardless of the type of data.  
  
 LINQ enables you to query data from a SQL Server database, XML, in-memory arrays and collections, [!INCLUDE[vstecado](../vs140/includes/vstecado_md.md)] datasets, or any other remote or local data source that supports LINQ. You can do all this with common [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] language elements. Because your queries are written in the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] language, your query results are returned as strongly-typed objects. These objects support IntelliSense, which enables you to write code faster and catch errors in your queries at compile time instead of at run time. LINQ queries can be used as the source of additional queries to refine results. They can also be bound to controls so that users can easily view and modify your query results.  
  
 For example, the following code example shows a LINQ query that returns a list of customers from a collection and groups them based on their location.  
  
 [!code[VbVbalrIntroToLINQ#1](../vs140/codesnippet/VisualBasic/introduction-to-linq-in-visual-basic_1.vb)]  
  
 In this topic, you will find information about the following areas:  
  
-   [Running the Examples](#RunningtheExamples)  
  
-   [LINQ Providers](#LINQProviders)  
  
-   [Structure of a LINQ Query](#StructureOfALINQQuery)  
  
-   [Visual Basic LINQ Query Operators](#VisualBasicLINQQueryOperators)  
  
-   [Connecting to a Database by Using LINQ to SQL](#ConnectingToADatabase)  
  
-   [Visual Basic Features That Support LINQ](#VisualBasicFeaturesThatSupportLINQ)  
  
-   [Deferred and Immediate Query Execution](#QueryExecution)  
  
-   [XML in Visual Basic](#XMLInVisualBasic)  
  
-   [Related Resources](#RelatedResources)  
  
-   [How To and Walkthrough Topics](#HowToAndWalkthroughTopics)  
  
##  \<a name="RunningtheExamples">\</a> Running the Examples  
 To run the examples in the introduction and in the "Structure of a LINQ Query" section, include the following code, which returns lists of customers and orders.  
  
 [!code[VbVbalrIntroToLINQ#31](../vs140/codesnippet/VisualBasic/introduction-to-linq-in-visual-basic_2.vb)]  
  
##  \<a name="LINQProviders">\</a> LINQ Providers  
 A *LINQ provider* maps your [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] LINQ queries to the data source being queried. When you write a LINQ query, the provider takes that query and translates it into commands that the data source will be able to execute. The provider also converts data from the source to the objects that make up your query result. Finally, it converts objects to data when you send updates to the data source.  
  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] includes the following LINQ providers.  
  
|||  
|-|-|  
|Provider|Description|  
|LINQ to Objects|The LINQ to Objects provider enables you to query in-memory collections and arrays. If an object supports either the \<xref:System.Collections.IEnumerable*> or <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>Aggregate<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>Aggregate<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>customers<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>cust<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>Where<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>Where<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>Join<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>Group Join<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>Group Join<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>CustomerOrders<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>OrderTotal<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>Aggregate<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>Aggregate<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>Aggregate<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>Aggregate<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>Aggregate<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>Aggregate<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>Aggregate<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>NorthwindDataContext<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>For…Next<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>Count<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>Sum<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>Average<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>Min<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>Max<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>ToList<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>ToArray` methods will also force immediate execution. This can be useful when you want to execute the query immediately and cache the results. For more information about these methods, see [Converting Data Types](../vs140/converting-data-types.md).  
  
 For more information about query execution, see [Three Stages of a LINQ Query (Visual Basic)](../vs140/writing-your-first-linq-query--visual-basic-.md).  
  
##  \<a name="XMLInVisualBasic">\</a> XML in Visual Basic  
 The XML features in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] include XML literals and XML axis properties, which enable you easily to create, access, query, and modify XML in your code. XML literals enable you to write XML directly in your code. The Visual Basic compiler treats the XML as a first-class data object.  
  
 The following code example shows how to create an XML element, access its sub-elements and attributes, and query the contents of the element by using LINQ.  
  
 [!code[VbXmlSamples#8](../vs140/codesnippet/VisualBasic/introduction-to-linq-in-visual-basic_24.vb)]  
  
 For more information, see [XML in Visual Basic](../vs140/xml-in-visual-basic.md).  
  
##  \<a name="RelatedResources">\</a> Related Resources  
  
|||  
|-|-|  
|Topic|Description|  
|[XML in Visual Basic](../vs140/xml-in-visual-basic.md)|Describes the XML features in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] that can be queried and that enable you to include XML as first-class data objects in your [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] code.|  
|[Queries (Visual Basic)](../vs140/queries--visual-basic-.md)|Provides reference information about the query clauses that are available in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].|  
|[Language-Integrated Query (LINQ)](../vs140/linq--language-integrated-query-.md)|Includes general information, programming guidance, and samples for LINQ.|  
|[LINQ to SQL](assetId:///73d13345-eece-471a-af40-4cc7a2f11655)|Includes general information, programming guidance, and samples for LINQ to SQL.|  
|[LINQ to Objects](../vs140/linq-to-objects.md)|Includes general information, programming guidance, and samples for LINQ to Objects.|  
|[LINQ to ADO.NET](../vs140/linq-to-ado.net--portal-page-1.md)|Includes links to general information, programming guidance, and samples for LINQ to [!INCLUDE[vstecado](../vs140/includes/vstecado_md.md)].|  
|[LINQ to XML](../vs140/linq-to-xml.md)|Includes general information, programming guidance, and samples for LINQ to XML.|  
  
##  \<a name="HowToAndWalkthroughTopics">\</a> How To and Walkthrough Topics  
 [How To: Query a Database Using LINQ (Visual Basic)](../vs140/how-to--query-a-database-by-using-linq--visual-basic-.md)  
  
 [How To: Call a Stored Procedure by Using LINQ (Visual Basic)](../vs140/how-to--call-a-stored-procedure-by-using-linq--visual-basic-.md)  
  
 [How To: Modify Data in a Database Using LINQ (Visual Basic)](../vs140/how-to--modify-data-in-a-database-by-using-linq--visual-basic-.md)  
  
 [How To: Combine Data with LINQ by Using Joins (Visual Basic)](../vs140/how-to--combine-data-with-linq-by-using-joins--visual-basic-.md)  
  
 [How To: Sort a Collection Using LINQ (Visual Basic)](../vs140/how-to--sort-query-results-by-using-linq--visual-basic-.md)  
  
 [How To: Filter Query Results Using LINQ (Visual Basic)](../vs140/how-to--filter-query-results-by-using-linq--visual-basic-.md)  
  
 [How To: Count, Sum, or Average Data Using LINQ (Visual Basic)](../vs140/how-to--count--sum--or-average-data-by-using-linq--visual-basic-.md)  
  
 [How To: Find the Minimum or Maximum Value in a Query Result Using LINQ (Visual Basic)](../vs140/how-to--find-the-minimum-or-maximum-value-in-a-query-result-by-using-linq--visual-basic-.md)  
  
 [Walkthrough: Creating LINQ to SQL Classes (O/R Designer)](assetId:///35aad4a4-2e8a-46e2-ae09-5fbfd333c233)  
  
 [How to: Assign Stored Procedures to Perform Updates, Inserts, and Deletes (O/R Designer)](assetId:///e88224ab-ff61-4a3a-b6b8-6f3694546cac)  
  
## Featured Book Chapters  
 [Chapter 17: LINQ](http://go.microsoft.com/fwlink/?LinkId=195277) in [Programming Visual Basic 2008](http://go.microsoft.com/fwlink/?LinkId=195383)  
  
## See Also  
 [Language-Integrated Query (LINQ)](../vs140/linq--language-integrated-query-.md)   
 [Overview of LINQ to XML in Visual Basic](../vs140/overview-of-linq-to-xml-in-visual-basic.md)   
 [LINQ to DataSet Overview](assetId:///dc20a8fb-03f6-4b68-9c2b-7f7299e3070b)   
 [LINQ to SQL](assetId:///73d13345-eece-471a-af40-4cc7a2f11655)   
 [LINQ Samples](../Topic/LINQ%20Samples_deleted.md)   
 [Object Relational Designer (O/R Designer)](assetId:///45e477c0-5c6b-41f9-b2d0-2808fb4f6537)   
 [DataContext Methods (O/R Designer)](assetId:///c149f4e5-3b61-4c33-892e-3e26d47f3eeb)