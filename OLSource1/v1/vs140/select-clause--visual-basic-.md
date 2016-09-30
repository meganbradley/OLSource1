---
title: "Select Clause (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.QuerySelect"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Select statement"
  - "Select clause"
  - "queries [Visual Basic], Select"
ms.assetid: 27a3f61c-5960-4692-9b91-4d0c4b6178fe
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Select Clause (Visual Basic)
Defines the result of a query.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Optional. An alias that can be used to reference the results of the column expression.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The name of the field to return in the query result.  
  
## Remarks  
 You can use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause to define the results to return from a query. This enables you to either define the members of a new anonymous type that is created by a query, or to target the members of a named type that is returned by a query. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clause is not required for a query. If no <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause is specified, the query will return a type based on all members of the range variables identified for the current scope. For more information, see [Anonymous Types](../vs140/anonymous-types--visual-basic-.md). When a query creates a named type, it will return a result of type <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>T<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>Aggregate<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>Let<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>Group By<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>Group Join<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>ProductName<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>Price<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>Discount<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>DiscountedPrice<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>ProductName<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>Price<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>DiscountedPrice<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>Let<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>Discount<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>Where<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>Customer<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>From<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>cust<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>customers<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>Select<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>CompanyName<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>CustomerID<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>CompanyName<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>CustomerID` columns for each record.  
  
 [!code[VbSimpleQuerySamples#30](../vs140/codesnippet/VisualBasic/select-clause--visual-basic-_4.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)   
 [Where Clause (Visual Basic)](../vs140/where-clause--visual-basic-.md)   
 [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md)   
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)