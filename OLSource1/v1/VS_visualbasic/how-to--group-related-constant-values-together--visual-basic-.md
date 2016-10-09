---
title: "How to: Group Related Constant Values Together (Visual Basic)"
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
  - "enumerations [Visual Basic], constants"
  - "constants, grouping together"
ms.assetid: 09d61da5-c940-4126-a79f-ba93c36653dc
caps.latest.revision: 17
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
# How to: Group Related Constant Values Together (Visual Basic)
An enumeration is the best way to group related constants together. You create an enumeration with the `Enum` statement in the declarations section of a class or a module. For more information, see [How to: Declare an Enumeration](../VS_visualbasic/how-to--declare-enumerations--visual-basic-.md).  
  
### To group related constant values  
  
1.  Write a declaration that includes a code access level, the `Enum` keyword, and a valid name. This example creates the `Private` enumeration, `temperatureValues`.  
  
     [!code[VbEnumsTask#21](../VS_visualbasic/codesnippet/VisualBasic/how-to--group-related-constant-values-together--visual-basic-_1.vb)]  
  
2.  Define the constants in the enumeration. This example creates the `Public` enumeration `temperatureValues` and assigns its values.  
  
     [!code[VbEnumsTask#1](../VS_visualbasic/codesnippet/VisualBasic/how-to--group-related-constant-values-together--visual-basic-_2.vb)]  
  
## See Also  
 [Enumerations and Name Qualification](../VS_visualbasic/enumerations-and-name-qualification--visual-basic-.md)   
 [How to: Refer to an Enumeration Member](../VS_visualbasic/how-to--refer-to-an-enumeration-member--visual-basic-.md)   
 [When to Use an Enumeration](../VS_visualbasic/when-to-use-an-enumeration--visual-basic-.md)   
 [Constants Overview](../VS_visualbasic/constants-overview--visual-basic-.md)   
 [Constant and Literal Data Types](../VS_visualbasic/constant-and-literal-data-types--visual-basic-.md)   
 [Constants and Enumerations](../VS_visualbasic/constants-and-enumerations--visual-basic-.md)