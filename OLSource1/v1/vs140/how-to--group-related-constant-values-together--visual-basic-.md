---
title: "How to: Group Related Constant Values Together (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
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
  - "enumerations [Visual Basic], constants"
  - "constants, grouping together"
ms.assetid: 09d61da5-c940-4126-a79f-ba93c36653dc
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Group Related Constant Values Together (Visual Basic)
An enumeration is the best way to group related constants together. You create an enumeration with the `Enum` statement in the declarations section of a class or a module. For more information, see [How to: Declare Enumerations](../vs140/how-to--declare-enumerations--visual-basic-.md).  
  
### To group related constant values  
  
1.  Write a declaration that includes a code access level, the `Enum` keyword, and a valid name. This example creates the `Private` enumeration, `temperatureValues`.  
  
     [!code[VbEnumsTask#21](../vs140/codesnippet/VisualBasic/how-to--group-related-constant-values-together--visual-basic-_1.vb)]  
  
2.  Define the constants in the enumeration. This example creates the `Public` enumeration `temperatureValues` and assigns its values.  
  
     [!code[VbEnumsTask#1](../vs140/codesnippet/VisualBasic/how-to--group-related-constant-values-together--visual-basic-_2.vb)]  
  
## See Also  
 [Enumerations and Name Qualification](../vs140/enumerations-and-name-qualification--visual-basic-.md)   
 [How to: Refer to an Enumeration Member](../vs140/how-to--refer-to-an-enumeration-member--visual-basic-.md)   
 [When to Use an Enumeration](../vs140/when-to-use-an-enumeration--visual-basic-.md)   
 [Constants Overview (Visual Basic)](../vs140/constants-overview--visual-basic-.md)   
 [Constant and Literal Data Types](../vs140/constant-and-literal-data-types--visual-basic-.md)   
 [Constants and Enumerations](../vs140/constants-and-enumerations--visual-basic-.md)