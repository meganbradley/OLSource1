---
title: "How to: Move Data Into and Out of a Variable (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "variables [Visual Basic], retrieving values"
  - "variables [Visual Basic], storing data"
ms.assetid: 93744f46-bf78-4fa0-9640-1de01bc38d9a
caps.latest.revision: 14
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Move Data Into and Out of a Variable (Visual Basic)
You store a value in a variable by putting the variable name on the left side of an assignment statement.  
  
## Putting Data in a Variable  
  
#### To store a value in a variable  
  
-   Use the variable name on the left side of an assignment statement.  
  
     The following example sets the value of the variable `alpha`.  
  
    ```  
    alpha = (beta * 6.27) / (gamma + 2.1)  
    ```  
  
     The value generated on the right side of the assignment statement is stored in the variable.  
  
## Getting Data from a Variable  
 You retrieve a variable's value by including the variable name in an expression.  
  
#### To retrieve a value from a variable  
  
-   Use the variable name in an expression. You can use a variable anywhere you can use a constant or a literal, except in an expression that defines the value of a constant.  
  
     -or-  
  
-   Use the variable name following the equal (`=`) sign in an assignment statement.  
  
     The following example reads the value of the variable `startValue` and then uses the value of the variable `counter` in an expression.  
  
    ```  
    counter = startValue  
    cellValue = (counter + 5) ^ 2  
    ```  
  
     The value of the variable participates in the expression just as a constant would, and then it is stored in the variable or property on the left side of the assignment statement.  
  
## See Also  
 [Variables](../VS_visualbasic/variables-in-visual-basic.md)   
 [Variable Declaration](../VS_visualbasic/variable-declaration-in-visual-basic.md)   
 [Object Variables](../VS_visualbasic/object-variables-in-visual-basic.md)