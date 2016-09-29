---
title: "Argument &#39;NPer&#39; must be greater than zero"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbrRate_NPerMustBeGTZero"
ms.assetid: d49242df-dbd1-4b26-bd8c-ed56d24fdfcd
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Argument &#39;NPer&#39; must be greater than zero
The `NPer` function, which returns a `Double` specifying the number of periods for an annuity based on periodic fixed payments and a fixed interest rate, requires an argument greater than zero.  
  
### To correct this error  
  
-   Check the spelling of arguments in the expression. A misspelled variable name can implicitly create a numeric variable that is initialized to zero.  
  
-   Check previous operations on variables in the expression, especially those passed into the procedure as arguments from other procedures.  
  
## See Also  
 [NOT IN BUILD: NPer Function](assetId:///56567d16-29f7-4928-b05f-b4cd56d4fd42)   
 [Argument Passing By Value and By Reference](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)