---
title: Creating Query-Scoped Named Sets (MDX)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 78bc1e9a-1bc4-4a5a-ab0b-cf430c8fbfe1
---
# Creating Query-Scoped Named Sets (MDX)
  If a named set is only required for a single Multidimensional Expressions \(MDX\) query, you can define that named set by using the WITH keyword. A named set that is created by using the WITH keyword no longer exists after the query has finished running.  
  
 As discussed in this topic, the syntax of the WITH keyword is quite flexible, even accommodating the use of functions to define the named set.  
  
> [!NOTE]  
>  For more information about named sets, see [Building Named Sets in MDX &#40;MDX&#41;](../Topic/Building%20Named%20Sets%20in%20MDX%20\(MDX\).md).  
  
## WITH Keyword Syntax  
 Use the following syntax to add the WITH keyword to a MDX SELECT statement:  
  
```  
[ WITH <SELECT WITH clause> [ , <SELECT WITH clause> ... ] ]   
SELECT [ * | ( <SELECT query axis clause> [ , <SELECT query axis clause> ... ] ) ]  
FROM <SELECT subcube clause>   
[ <SELECT slicer axis clause> ]  
[ <SELECT cell property list clause> ]  
  
<SELECT WITH clause> ::=  
   ( SET Set_Identifier AS 'Set_Expression')  
  
```  
  
 In the syntax for the WITH keyword, the `Set_Identifier` parameter contains the alias for the named set. The `Set_Expression` parameter contains the set expression to which the named set alias refers.  
  
## WITH Keyword Example  
 The following MDX query examines the unit sales of the various Chardonnay and Chablis wines in **FoodMart 2000**, the sample database for Microsoft SQL Server 2000 Analysis Services. This query, although fairly simple in terms of the result set, is lengthy and unwieldy when you have to maintenance such a query.  
  
```  
SELECT  
   {[Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Good].[Good Chardonnay],   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Pearl].[Pearl Chardonnay],   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Portsmouth].[Portsmouth Chardonnay],   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Top Measure].[Top Measure Chardonnay],   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Walrus].[Walrus Chardonnay],   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Good].[Good Chablis Wine],   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Pearl].[Pearl Chablis Wine],   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Portsmouth].[Portsmouth Chablis Wine],   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Top Measure].[Top Measure Chablis Wine],   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Walrus].[Walrus Chablis Wine]} ON COLUMNS,  
   {Measures.[Unit Sales]} ON ROWS  
FROM Sales  
```  
  
 To make the previous MDX query easier to maintain, you can create a named set for the query by using the WITH keyword. The following code shows how to use the WITH keyword to create a named set, `[ChardonnayChablis]`, and how the named set makes the SELECT statement shorter and easier to maintain.  
  
```  
WITH SET [ChardonnayChablis] AS  
   {[Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Good].[Good Chardonnay],  
   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Pearl].[Pearl Chardonnay],  
   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Portsmouth].[Portsmouth Chardonnay],  
   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Top Measure].[Top Measure Chardonnay],  
   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Walrus].[Walrus Chardonnay],  
   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Good].[Good Chablis Wine],  
   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Pearl].[Pearl Chablis Wine],  
   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Portsmouth].[Portsmouth Chablis Wine],  
   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Top Measure].[Top Measure Chablis Wine],  
   [Product].[All Products].[Drink].[Alcoholic Beverages].[Beer and Wine].[Wine].[Walrus].[Walrus Chablis Wine]}  
  
SELECT  
   [ChardonnayChablis] ON COLUMNS,  
   {Measures.[Unit Sales]} ON ROWS  
FROM Sales  
```  
  
### Using Functions Together with the WITH Keyword  
 Although you can explicitly define each member of a named set, this approach can produce a lengthy statement. To make the creation and maintenance of a named set easier, you can use MDX functions to define the members.  
  
 For example, the following MDX query example uses the [Filter](../Topic/Filter%20\(MDX\).md), [CurrentMember](../Topic/CurrentMember%20\(MDX\).md), and [Name](../Topic/Name%20\(MDX\).md) MDX functions and the InStr VBA function to create the `[ChardonnayChablis]` named set. This version of the `[ChardonnayChablis]` named set is the same as the explicitly defined version shown previously in this topic.  
  
```  
WITH SET [ChardonnayChablis] AS  
   'Filter([Product].Members, (InStr(1, [Product].CurrentMember.Name, "chardonnay") <> 0) OR (InStr(1, [Product].CurrentMember.Name, "chablis") <> 0))'  
  
SELECT  
   [ChardonnayChablis] ON COLUMNS,  
   {Measures.[Unit Sales]} ON ROWS  
FROM Sales  
  
```  
  
## See Also  
 [SELECT Statement &#40;MDX&#41;](../Topic/SELECT%20Statement%20\(MDX\).md)   
 [Creating Session-Scoped Named Sets &#40;MDX&#41;](../Topic/Creating%20Session-Scoped%20Named%20Sets%20\(MDX\).md)  
  
  