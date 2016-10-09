---
title: "Declaration expected"
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
  - "vbc30188"
  - "bc30188"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30188"
ms.assetid: da6b1df3-fe6b-4415-88e6-0977e5189e0b
caps.latest.revision: 9
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
# Declaration expected
A nondeclarative statement, such as an assignment or loop statement, occurs outside any procedure. Only declarations are allowed outside procedures.  
  
 Alternatively, a programming element is declared without a declaration keyword such as `Dim` or `Const`.  
  
 **Error ID:** BC30188  
  
### To correct this error  
  
-   Move the nondeclarative statement to the body of a procedure.  
  
-   Begin the declaration with an appropriate declaration keyword.  
  
-   Ensure that a declaration keyword is not misspelled.  
  
## See Also  
 [Procedures](../VS_visualbasic/procedures-in-visual-basic.md)   
 [Dim Statement](../VS_visualbasic/dim-statement--visual-basic-.md)