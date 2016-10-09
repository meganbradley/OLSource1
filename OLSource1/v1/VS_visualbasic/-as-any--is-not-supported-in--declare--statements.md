---
title: "&#39;As Any&#39; is not supported in &#39;Declare&#39; statements"
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
  - "bc30828"
  - "vbc30828"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30828"
ms.assetid: 7e5cf519-8b64-4ac5-8116-705fe26c846d
caps.latest.revision: 11
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
# &#39;As Any&#39; is not supported in &#39;Declare&#39; statements
The `Any` data type was used with `Declare` statements in Visual Basic 6.0 and earlier versions to permit the use of arguments that could contain any type of data. [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] supports overloading, however, and so makes the `Any` data type obsolete.  
  
 **Error ID:** BC30828  
  
### To correct this error  
  
1.  Declare parameters of the specific type you want to use; for example.  
  
     [!code[VbVbalrStatements#95](../VS_visualbasic/codesnippet/VisualBasic/-as-any--is-not-supported-in--declare--statements_1.vb)]  
  
2.  Use the \<xref:System.Runtime.InteropServices.MarshalAsAttribute> attribute to specify `As Any` when `Void*` is expected by the procedure being called.  
  
     [!code[VbVbalrStatements#96](../VS_visualbasic/codesnippet/VisualBasic/-as-any--is-not-supported-in--declare--statements_2.vb)]  
  
## See Also  
 \<xref:System.Runtime.InteropServices.MarshalAsAttribute>   
 [Walkthrough: Calling Windows APIs](../VS_visualbasic/walkthrough--calling-windows-apis--visual-basic-.md)   
 [Declare Statement](../VS_visualbasic/declare-statement.md)   
 [Creating Prototypes in Managed Code](../Topic/Creating%20Prototypes%20in%20Managed%20Code.md)