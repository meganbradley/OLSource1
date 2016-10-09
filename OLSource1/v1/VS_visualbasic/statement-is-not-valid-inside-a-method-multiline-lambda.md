---
title: "Statement is not valid inside a method-multiline lambda"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Statement is not valid inside a method/multiline lambda"
f1_keywords: 
  - "vbc30024"
  - "bc30024"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30024"
ms.assetid: 758e7a8f-429b-42c1-9a78-778e5b480e04
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
# Statement is not valid inside a method-multiline lambda
The statement is not valid within a `Sub`, `Function`, property `Get`, or property `Set` procedure. Some statements can be placed at the module or class level. Others, such as `Option Strict`, must be at namespace level and precede all other declarations.  
  
 **Error ID:** BC30024  
  
### To correct this error  
  
-   Remove the statement from the procedure.  
  
## See Also  
 [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md)   
 [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)   
 [Get Statement](../VS_visualbasic/get-statement.md)   
 [Set Statement](../VS_visualbasic/set-statement--visual-basic-.md)