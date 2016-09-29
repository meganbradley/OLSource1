---
title: "Operator without an &#39;As&#39; clause; type of Object assumed"
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
  - "vbc41005"
  - "bc41005"
helpviewer_keywords: 
  - "BC41005"
ms.assetid: 42be84ed-7aa6-4ac0-9dd4-663e90f13e09
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator without an &#39;As&#39; clause; type of Object assumed
An operator procedure does not specify an `As` clause.  
  
 An `As` clause identifies a data type to be associated with a programming element. In an [Operator Statement](../vs140/operator-statement.md), it specifies the data type of the value the operator procedure returns to the calling code. If you do not include an `As` clause in the `Operator` statement, the return data type defaults to `Object`.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC41005  
  
### To correct this error  
  
-   Include an `As` clause in the `Operator` statement to specify the return data type.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)