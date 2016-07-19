---
title: * (Multiply) (SSIS Expression)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d457f052-ffbb-4485-833f-f4bed4349b69
manager: jhubbard
---
# * (Multiply) (SSIS Expression)
Multiplies two numeric expressions.  
  
## Syntax  
  
```  
  
numeric_expression1 * numeric_expression2  
  
```  
  
## Arguments  
 *numeric_expression1, numeric_expression2*  
 Is any valid expression of a numeric data type. For more information, see [Integration Services Data Types](../../Topics/TopicNameNotContainA/Integration-Services-Data-Types.md).  
  
## Result Types  
 Determined by data types of the two arguments. For more information, see [Integration Services Data Types in Expressions](../../Topics/TopicNameNotContainA/Integration-Services-Data-Types-in-Expressions.md).  
  
## Remarks  
 If either operand is null, the result is null.  
  
## Expression Examples  
 This example multiplies numeric literals.  
  
```  
5 * 6.09  
```  
  
 This example multiplies values in the **ListPrice** column by 10 percent.  
  
```  
ListPrice * .10  
```  
  
 This example subtracts the result of an expression from the **ListPrice** column. The variable **Discount%** must be enclosed in brackets because the name includes the % character. For more information, see [Identifiers (SSIS)](../../Topics/TopicNameNotContainA/Identifiers--SSIS-.md).  
  
```  
ListPrice - (ListPrice * @[Discount%])  
```  
  
## See Also  
 [Operator Precedence and Associativity](../../Topics/TopicNameNotContainA/Operator-Precedence-and-Associativity.md)   
 [Operators (SSIS Expression)](../../Topics/TopicNameNotContainA/Operators--SSIS-Expression-.md)