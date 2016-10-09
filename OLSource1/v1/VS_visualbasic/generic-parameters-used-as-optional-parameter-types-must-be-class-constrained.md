---
title: "Generic parameters used as optional parameter types must be class constrained"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc32124"
  - "bc32124"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC32124"
ms.assetid: 55aa8b2a-9ce3-4620-a710-2f9b0feb6143
caps.latest.revision: 8
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
# Generic parameters used as optional parameter types must be class constrained
A procedure is declared with an optional parameter that uses a type parameter that is not constrained to be a reference type.  
  
 You must always supply a default value for each optional parameter. If the parameter is of a reference type, the optional value must be `Nothing`, which is a valid value for any reference type. However, if the parameter is of a value type, that type must be an elementary data type predefined by Visual Basic. This is because a composite value type, such as a user-defined structure, has no valid default value.  
  
 When you use a type parameter for an optional parameter, you must guarantee that it is of a reference type to avoid the possibility of a value type with no valid default value. This means you must constrain the type parameter either with the `Class` keyword or with the name of a specific class.  
  
 **Error ID:** BC32124  
  
### To correct this error  
  
-   Constrain the type parameter to accept only a reference type, or do not use it for the optional parameter.  
  
## See Also  
 [Generic Types in Visual Basic](../VS_visualbasic/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../VS_visualbasic/type-list--visual-basic-.md)   
 [Class Statement](../VS_visualbasic/class-statement--visual-basic-.md)   
 [Optional Parameters](../VS_visualbasic/optional-parameters--visual-basic-.md)   
 [Structures](../VS_visualbasic/structures--visual-basic-.md)   
 [Nothing](../VS_visualbasic/nothing--visual-basic-.md)