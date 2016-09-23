---
title: "Argument not optional (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbrID449
dev_langs: 
  - VB
ms.assetid: 76e7bcf3-24ed-4cd5-945b-b98f1c76944b
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Argument not optional (Visual Basic)
The number and types of arguments must match those expected. Either there is an incorrect number of arguments, or an omitted argument is not optional. An argument can only be omitted from a call to a user-defined procedure if it was declared `Optional` in the procedure definition.  
  
### To correct this error  
  
1.  Supply all necessary arguments.  
  
2.  Make sure omitted arguments are optional. If they are not, either supply the argument in the call, or declare the parameter `Optional` in the definition.  
  
## See Also  
 [Types of Errors](../vs140/error-types--visual-basic-.md)