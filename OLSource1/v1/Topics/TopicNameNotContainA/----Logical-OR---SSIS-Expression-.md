---
title: || (Logical OR) (SSIS Expression)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a3c07c09-f121-4187-9617-b01adcf843c4
manager: jhubbard
---
# || (Logical OR) (SSIS Expression)
Performs a logical OR operation. The expression evaluates to TRUE if one or both conditions are TRUE.  
  
## Syntax  
  
```  
  
boolean_expression1 || boolean_expression2  
```  
  
## Arguments  
 *boolean_expression1, boolean_expression2*  
 Is any valid expression that evaluates to TRUE, FALSE, or NULL.  
  
## Result Types  
 DT_BOOL  
  
## Remarks  
 The following table shows the result of the &#124;&#124; operator.  
  
|Result|Expression|Expression|  
|------------|----------------|----------------|  
|TRUE|TRUE|TRUE|  
|TRUE|TRUE|FALSE|  
|FALSE|FALSE|FALSE|  
|NULL|NULL|NULL|  
|TRUE|NULL|TRUE|  
|NULL|NULL|FALSE|  
  
## SSIS Expression Examples  
 This example uses the **StandardCost** and **ListPrice** columns. The example evaluates to TRUE if the value of the **StandardCost** column is less than 300 or the **ListPrice** column is greater than 500.  
  
```  
StandardCost < 300 || ListPrice > 500  
```  
  
 This example uses the variables **SPrice** and **LPrice** instead of numeric literals.  
  
```  
StandardCost < @SPrice || ListPrice > @LPrice  
```  
  
## See Also  
 [&#124; (Bitwise Inclusive OR) (SSIS Expression)](../Topic/%7C%20\(Bitwise%20Inclusive%20OR\)%20\(SSIS%20Expression\).md)   
 [^ (Bitwise Exclusive OR) (SSIS Expression)](../Topic/%5E%20\(Bitwise%20Exclusive%20OR\)%20\(SSIS%20Expression\).md)   
 [Operator Precedence and Associativity](../../Topics/TopicNameNotContainA/Operator-Precedence-and-Associativity.md)   
 [Operators (SSIS Expression)](../../Topics/TopicNameNotContainA/Operators--SSIS-Expression-.md)