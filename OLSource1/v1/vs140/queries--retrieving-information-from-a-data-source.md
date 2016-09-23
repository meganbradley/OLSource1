---
title: "Queries: Retrieving Information from a Data Source"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - ls.QueryDesigner
helpviewer_keywords: 
  - restricting data [Visual Studio LightSwitch]
  - queries [Visual Studio LightSwitch], limiting information
  - queries [Visual Studio LightSwitch]
  - limiting data [Visual Studio LightSwitch]
  - queries [Visual Studio LightSwitch], targeting information
  - queries [Visual Studio LightSwitch], retrieving information
ms.assetid: 5eb67251-8c52-4b8d-b16d-c753fafa654d
caps.latest.revision: 41
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Queries: Retrieving Information from a Data Source
You use a *query* to return data that matches a set of criteria. For example, if you want to know how many of your customers live in the United States, you create a query that scans a list of customers and checks the country/region that is specified in their address.  
  
 You can create queries and save them to the model of your application. You can then specify your search criteria by using the *query designer*. If the query designer does not provide the functionality that you need, you can extend the queries by writing some code. When you have specified your criteria, consume the queries in a screen or run them as part of your business logic.  
  
## Creating a Query  
 You can create queries in **Solution Explorer**. A query is based on only one entity or table in the model of your application (for example, a `Customer` entity). A query can also be based on other queries in the model of your application. The entity, table, or query on which the query is based, is called the *source* data of the query. For more information, see [How to: Add, Remove, and Modify a Query](../vs140/how-to--add--remove--and-modify-a-query.md).  
  
## Designing a Query by Using the Query Designer  
 In most cases, you can design a query visually by using the query designer. Add *filter conditions* and *filter groups*, *sort terms* and *parameters* to a query by making selections in the designer. For more information, see [How to: Design a Query by Using the Query Designer](../vs140/how-to--design-a-query-by-using-the-query-designer.md).  
  
### Filter Conditions  
 You can narrow the results of a query by adding one or more *filter conditions*. A filter condition describes a rule that must be met by each row of data. Rows that comply with the rule are included in the query results. A filter condition contains the following three basic parts:  
  
-   A selection property  
  
-   A comparison value  
  
-   An operator  
  
 A *selection property* is the property that you want to use as the basis of the filter condition. For example, to return sales orders that have a certain order date, you might use `OrderDate` as the selection property. A selection property can be a property in the source data or a property on a related entity or table. In the query designer, properties appear only for related entities or tables that have a multiplicity of zero to one or one. For example, a sales order has only one customer. Therefore, in a query that returns sales orders, you can select the properties of the related customer as part of a filter condition. If you want to use a property on a related entity or table that has a multiplicity of many, you must extend the query by using code.  
  
 The *comparison value* is compared to the selection property. A comparison value can be a literal value such as the string "9/22/2009 12:00:00 AM", a selection property, a parameter, or a relative value such as **Now**, **Today**, or **Start of Week**.  
  
 An *operator* is a symbol that specifies the type of comparison that you want to make. For example, to return sales orders for which the order date is less than "9/22/2009 12:00:00 AM", you would select the "<" operator.  
  
 The complete filter condition described in this example is `Where OrderDate < 9/22/2009 12:00:00 AM`.  
  
 You can relate a filter condition to other filter conditions by using one of the following logical operators: `And`, `Or`, `And Not`, `Or Not`.  
  
 You can change the order of conditions by dragging them to their desired positions in the designer.  
  
 The following illustration shows the parts of a filter condition.  
  
 ![Filter conditions in a query](../vs140/media/ls_query_filter_conditions.png "LS_Query_Filter_Conditions")  
  
### Filter Groups  
 You can group filter conditions together so that they are evaluated as a single unit separate from the rest of the filter conditions. To accomplish this, create a *filter group* in the query designer.  
  
 Grouping filter conditions is like putting parentheses around an expression in a mathematical equation or logic statement. When you group conditions, the logical operator that appears before the first condition in a group applies to the whole group.  
  
 Just like individual filter conditions, you can change the order of filter groups by dragging them to the desired position in the designer.  
  
 The following illustration shows two filter groups.  
  
 ![Filter groups in a query](../vs140/media/ls_query_filter_group.png "LS_Query_Filter_Group")  
  
### Sort Terms  
 You can specify the default order in which records appear in the results of a query by adding one or more *sort terms*. A sort term contains a property and a direction (for example, `OrderDate` and `Ascending`). Sort terms define the default sort order of records that appear in a screen. Users can view records in a different order by making selections on the User Interface (UI) of the screen. In the query designer, you can change the order of sort terms by dragging them to the desired position in the list.  
  
### Parameters  
 You can enable users to dynamically filter query results. For example, you can enable a user to view regional sales orders by selecting a specific sales territory on a screen. To support this scenario, add a *parameter* to a query and name the query appropriately (for example, `SalesTerritory`). Then set the comparison value of a filter to the parameter. For example, the query expression might be `Where TerritoryID = SalesTerritory`.  
  
 You can design screens that enable users to provide the parameter value at run time. For more information, see [How to: Provide a Value to a Query Parameter](../vs140/how-to--provide-a-value-to-a-query-parameter.md).  
  
## Extending a Query by Using Code  
 Some types of filter conditions are not supported by the query designer. If you encounter a limitation in the designer, you can add conditions to your query by using code.  
  
> [!NOTE]
>  You cannot extend the query of a screen. You can only extend queries that appear in **Solution Explorer**. For more information about editing the query of a screen, see [How to: Filter Data on a Screen](../vs140/how-to--filter-data-on-a-silverlight-screen.md).  
  
 The following table shows two filter conditions that you cannot create by using the query designer.  
  
|Filter condition|Reason to use code|  
|----------------------|------------------------|  
|Return top 10 customers based on the number of sales orders.|To determine the number of sales orders, you must use the <xref:System.Linq.Queryable.Count?qualifyHint=False> operation. Operations such as <xref:System.Linq.Queryable.Count?qualifyHint=False>, <xref:System.Linq.Queryable.Aggregate?qualifyHint=False>, and <xref:System.Linq.Queryable.Sum?qualifyHint=False> are not available in the query designer|  
|Return all customers who purchased a wheelbarrow.|To determine whether a customer purchased a wheelbarrow, you need to use a filter condition that references a `Product` entity. Because one customer can be associated with several products, the `Product` entity would likely exist on the many side of a `Customer`-`Product` relationship. The query designer does not enable you navigate to the many side of a relationship.|  
  
 To resolve this limitation, you can add custom code to a method that is called when the query is executed. For more information, see [How to: Extend a Query by Using Code](../vs140/how-to--extend-a-query-by-using-code.md).  
  
 In your code, you can define filter conditions by using standard LINQ syntax. When the query is executed, the conditions that you define in the designer are combined with the conditions that you define in your code to produce the query result.  
  
 Any conditions that you define in your code do not appear as filter conditions in the query designer. Similarly, filter conditions that you add by using the query designer do not appear in the method. If you want to add a parameter to a query, do so by using the query designer only. Parameters that you add by using the query designer appear in the parameter list of the method.  
  
## Consuming a Query  
 You can consume a query on a screen or run the query in code as part of a business operation.  
  
### Consuming a Query in a Screen  
 You can create a screen that is based on a custom query (for example, a screen that shows a list of customers who are located in the United States). For more information, see [How to: Create a Screen](../vs140/how-to--create-a-silverlight-screen.md).  
  
 You can add multiple queries to a screen. For example, you might design a query that shows a list of sales orders for a particular customer. You can add that query to the Customer screen. You can then enable the user to select a customer to view all related sales orders. For more information about how to accomplish this, see [How to: Provide a Value to a Query Parameter](../vs140/how-to--provide-a-value-to-a-query-parameter.md).  
  
### Consuming a Query in Code  
 You can retrieve queries from the model of the application, and then run them in code. This enables you to work with targeted collections of data in the business logic of your application. For more information, see [How to: Retrieve Data from a Query by Using Code](../vs140/how-to--retrieve-data-from-a-query-by-using-code.md).  
  
## Related Topics  
  
|||  
|-|-|  
|Title|Description|  
|[How to: Add, Remove and Modify a Query](../vs140/how-to--add--remove--and-modify-a-query.md)|Explains where you can add a query in the [!INCLUDE[smb_current_long](../vs140/includes/smb_current_long_md.md)] UI.|  
|[How to: Design a Query by Using the Query Designer](../vs140/how-to--design-a-query-by-using-the-query-designer.md)|Describes how to define the filter conditions, parameters and sort terms of a query by using a visual designer.|  
|[How to: Provide a Value to a Query Parameter](../vs140/how-to--provide-a-value-to-a-query-parameter.md)|Describes how to enable users to provide a value to a query parameter.|  
|[How to: Extend a Query by Using Code](../vs140/how-to--extend-a-query-by-using-code.md)|Describes how to modify a query in ways that go beyond the capabilities of the designer.|  
|[How to: Handle Query Events](../vs140/how-to--handle-query-events.md)|Describes how to handle events that occur before and after a query is executed.|  
|[How to: Retrieve Data from a Query by Using Code](../vs140/how-to--retrieve-data-from-a-query-by-using-code.md)|Describes how to retrieve and run a query by using code.|  
|[Reference: Query Designer Properties](../vs140/reference--query-designer-properties.md)|Describes the properties of queries and query elements. You can set the values of these properties in the **Properties** window.|