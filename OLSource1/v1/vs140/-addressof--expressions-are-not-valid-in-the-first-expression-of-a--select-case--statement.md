---
title: "&#39;AddressOf&#39; expressions are not valid in the first expression of a &#39;Select Case&#39; statement"
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
  - "bc36636"
  - "vbc36636"
helpviewer_keywords: 
  - "BC36636"
ms.assetid: 2ccc0ccc-d4d0-4910-8859-dedfa57c8126
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;AddressOf&#39; expressions are not valid in the first expression of a &#39;Select Case&#39; statement
You cannot use an `AddressOf` expression for the test expression in a `Select Case` statement. `AddressOf` expressions return function delegates, and the test expression of a `Select Case` statement must be an elementary data type.  
  
 **Error ID:** BC36636  
  
### To correct this error  
  
-   Examine your code to determine whether a different conditional construction, such as an `If...Then...Else` statement, would work for you.  
  
## See Also  
 [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)   
 [If...Then...Else Statement](../vs140/if...then...else-statement--visual-basic-.md)   
 [Select...Case Statement (Visual Basic)](../vs140/select...case-statement--visual-basic-.md)