---
title: "End &lt;keyword&gt; Statement (Visual Basic)"
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
  - "vb.EndDefinition"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "End keyword"
ms.assetid: 42d6e088-ab0f-4cda-88e8-fdce3e5fcf4f
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
# End &lt;keyword&gt; Statement (Visual Basic)
When followed by an additional keyword, terminates the definition of the statement block introduced by that keyword.  
  
## Syntax  
  
```  
End AddHandler  
End Class   
End Enum   
End Event   
End Function   
End Get   
End If   
End Interface   
End Module   
End Namespace   
End Operator   
End Property   
End RaiseEvent  
End RemoveHandler  
End Select   
End Set   
End Structure   
End Sub   
End SyncLock   
End Try   
End While   
End With  
```  
  
## Parts  
 `End`  
 Required. Terminates the definition of the programming element.  
  
 `AddHandler`  
 Required to terminate an `AddHandler` accessor begun by a matching `AddHandler` statement in a custom [Event Statement](../VS_visualbasic/event-statement.md).  
  
 `Class`  
 Required to terminate a class definition begun by a matching [Class Statement](../VS_visualbasic/class-statement--visual-basic-.md).  
  
 `Enum`  
 Required to terminate an enumeration definition begun by a matching [Enum Statement](../VS_visualbasic/enum-statement--visual-basic-.md).  
  
 `Event`  
 Required to terminate a `Custom` event definition begun by a matching [Event Statement](../VS_visualbasic/event-statement.md).  
  
 `Function`  
 Required to terminate a `Function` procedure definition begun by a matching [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md). If execution encounters an `End``Function` statement, control returns to the calling code.  
  
 `Get`  
 Required to terminate a `Property` procedure definition begun by a matching [Get Statement](../VS_visualbasic/get-statement.md). If execution encounters an `End``Get` statement, control returns to the statement requesting the property's value.  
  
 `If`  
 Required to terminate an `If`...`Then`...`Else` block definition begun by a matching `If` statement. See [If...Then...Else Statement](../VS_visualbasic/if...then...else-statement--visual-basic-.md).  
  
 `Interface`  
 Required to terminate an interface definition begun by a matching [Interface Statement](../VS_visualbasic/interface-statement--visual-basic-.md).  
  
 `Module`  
 Required to terminate a module definition begun by a matching [Module Statement](../VS_visualbasic/module-statement.md).  
  
 `Namespace`  
 Required to terminate a namespace definition begun by a matching [Namespace Statement](../VS_visualbasic/namespace-statement.md).  
  
 `Operator`  
 Required to terminate an operator definition begun by a matching [Operator Statement](../VS_visualbasic/operator-statement.md).  
  
 `Property`  
 Required to terminate a property definition begun by a matching [Property Statement](../VS_visualbasic/property-statement.md).  
  
 `RaiseEvent`  
 Required to terminate a `RaiseEvent` accessor begun by a matching `RaiseEvent` statement in a custom [Event Statement](../VS_visualbasic/event-statement.md).  
  
 `RemoveHandler`  
 Required to terminate a `RemoveHandler` accessor begun by a matching `RemoveHandler` statement in a custom [Event Statement](../VS_visualbasic/event-statement.md).  
  
 `Select`  
 Required to terminate a `Select`...`Case` block definition begun by a matching `Select` statement. See [Select...Case Statement](../VS_visualbasic/select...case-statement--visual-basic-.md).  
  
 `Set`  
 Required to terminate a `Property` procedure definition begun by a matching [Set Statement](../VS_visualbasic/set-statement--visual-basic-.md). If execution encounters an `End``Set` statement, control returns to the statement setting the property's value.  
  
 `Structure`  
 Required to terminate a structure definition begun by a matching [Structure Statement](../VS_visualbasic/structure-statement.md).  
  
 `Sub`  
 Required to terminate a `Sub` procedure definition begun by a matching [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md). If execution encounters an `End``Sub` statement, control returns to the calling code.  
  
 `SyncLock`  
 Required to terminate a `SyncLock` block definition begun by a matching `SyncLock` statement. See [SyncLock Statement](../VS_visualbasic/synclock-statement.md).  
  
 `Try`  
 Required to terminate a `Try`...`Catch`...`Finally` block definition begun by a matching `Try` statement. See [Try...Catch...Finally Statement](../VS_visualbasic/try...catch...finally-statement--visual-basic-.md).  
  
 `While`  
 Required to terminate a `While` loop definition begun by a matching `While` statement. See [While...End While Statement](../VS_visualbasic/while...end-while-statement--visual-basic-.md).  
  
 `With`  
 Required to terminate a `With` block definition begun by a matching `With` statement. See [With...End With Statement](../VS_visualbasic/with...end-with-statement--visual-basic-.md).  
  
## Remarks  
 The [End Statement](../VS_visualbasic/end-statement.md), without an additional keyword, terminates execution immediately.  
  
 When preceded by a number sign (`#`), the `End` keyword terminates a preprocessing block introduced by the corresponding directive.  
  
 `#End`  
 Required. Terminates the definition of the preprocessing block.  
  
 `#ExternalSource`  
 Required to terminate an external source block begun by a matching [#ExternalSource Directive](../VS_visualbasic/sharpexternalsource-directive.md).  
  
 `#If`  
 Required to terminate a conditional compilation block begun by a matching `#If` directive. See [#If...Then...#Else Directives](../VS_visualbasic/sharpif...then...sharpelse-directives.md).  
  
 `#Region`  
 Required to terminate a source region block begun by a matching [#Region Directive](../VS_visualbasic/sharpregion-directive.md).  
  
## Smart Device Developer Notes  
 The `End` statement, without an additional keyword, is not supported.  
  
## See Also  
 [End Statement](../VS_visualbasic/end-statement.md)