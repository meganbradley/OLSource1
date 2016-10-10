---
title: "How to: Call an Overloaded Procedure (Visual Basic)"
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
  - "Visual Basic code, procedures"
  - "procedures, overloading"
  - "procedures, calling"
  - "procedures, multiple versions"
  - "procedure calls, overloaded"
ms.assetid: 3bb331fb-f6bc-406f-9ca0-9609b497014c
caps.latest.revision: 12
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
# How to: Call an Overloaded Procedure (Visual Basic)
The advantage of overloading a procedure is in the flexibility of the call. The calling code can obtain the information it needs to pass to the procedure and then call a single procedure name, no matter what arguments it is passing.  
  
### To call a procedure that has more than one version defined  
  
1.  In the calling code, determine which data to pass to the procedure.  
  
2.  Write the procedure call in the normal way, presenting the data in the argument list. Be sure the arguments match the parameter list in one of the versions defined for the procedure.  
  
3.  You do not have to determine which version of the procedure to call. [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] passes control to the version matching your argument list.  
  
     The following example calls the `post` procedure declared in [How to: Define Multiple Versions of a Procedure](../VS_visualbasic/how-to--define-multiple-versions-of-a-procedure--visual-basic-.md). It obtains the customer identification, determines whether it is a `String` or an `Integer`, and then in either case calls the same procedure.  
  
     [!code[VbVbcnProcedures#56](../VS_visualbasic/codesnippet/VisualBasic/how-to--call-an-overloaded-procedure--visual-basic-_1.vb)]  
  
     [!code[VbVbcnProcedures#57](../VS_visualbasic/codesnippet/VisualBasic/how-to--call-an-overloaded-procedure--visual-basic-_2.vb)]  
  
## See Also  
 [Procedures](../VS_visualbasic/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../VS_visualbasic/procedure-parameters-and-arguments--visual-basic-.md)   
 [Procedure Overloading](../VS_visualbasic/procedure-overloading--visual-basic-.md)   
 [Troubleshooting Procedures](../VS_visualbasic/troubleshooting-procedures--visual-basic-.md)   
 [How to: Define Multiple Versions of a Procedure](../VS_visualbasic/how-to--define-multiple-versions-of-a-procedure--visual-basic-.md)   
 [How to: Overload a Procedure that Takes Optional Parameters](../VS_visualbasic/how-to--overload-a-procedure-that-takes-optional-parameters--visual-basic-.md)   
 [How to: Overload a Procedure that Takes an Indefinite Number of Parameters](../VS_visualbasic/how-to--overload-a-procedure-that-takes-an-indefinite-number-of-parameters--visual-basic-.md)   
 [Considerations in Overloading Procedures](../VS_visualbasic/considerations-in-overloading-procedures--visual-basic-.md)   
 [Overload Resolution](../VS_visualbasic/overload-resolution--visual-basic-.md)   
 [Overloads](../VS_visualbasic/overloads--visual-basic-.md)