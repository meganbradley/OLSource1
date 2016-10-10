---
title: "Other Control Structures (Visual Basic)"
ms.custom: na
ms.date: "10/10/2016"
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
  - "statements [Visual Basic], control flow"
  - "control structures"
ms.assetid: 24b811f7-98ba-40ec-8dd3-4d528cfa4574
caps.latest.revision: 19
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
# Other Control Structures (Visual Basic)
[!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] provides control structures that help you dispose of a resource or reduce the number of times you have to repeat an object reference.  
  
## Using...End Using Construction  
 The `Using...End Using` construction establishes a statement block within which you make use of a resource such as a SQL connection. You can optionally acquire the resource with the `Using` statement. When you exit the `Using` block, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] automatically disposes of the resource so that it is available for other code to use. The resource must be local and disposable. For more information, see [Using Statement](../VS_visualbasic/using-statement--visual-basic-.md).  
  
## With...End With Construction  
 The `With...End With` construction lets you specify an object reference once and then run a series of statements that access its members. This can simplify your code and improve performance because [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] does not have to re-establish the reference for each statement that accesses it. For more information, see [With...End With Statement](../VS_visualbasic/with...end-with-statement--visual-basic-.md).  
  
## See Also  
 [Control Flow](../VS_visualbasic/control-flow-in-visual-basic.md)   
 [Decision Structures](../VS_visualbasic/decision-structures--visual-basic-.md)   
 [Loop Structures](../VS_visualbasic/loop-structures--visual-basic-.md)   
 [Nested Control Structures](../VS_visualbasic/nested-control-structures--visual-basic-.md)   
 [Using Statement](../VS_visualbasic/using-statement--visual-basic-.md)   
 [With...End With Statement](../VS_visualbasic/with...end-with-statement--visual-basic-.md)