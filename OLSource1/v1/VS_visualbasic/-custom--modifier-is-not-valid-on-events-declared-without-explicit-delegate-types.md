---
title: "&#39;Custom&#39; modifier is not valid on events declared without explicit delegate types"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc31122"
  - "bc31122"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC31122"
ms.assetid: 6911f0d1-641a-473b-906d-8ee5681194be
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Custom&#39; modifier is not valid on events declared without explicit delegate types
Unlike a non-custom event, a `Custom Event` declaration requires an `As` clause following the event name that explicitly specifies the delegate type for the event.  
  
 Non-custom events can be defined either with an `As` clause and an explicit delegate type, or with a parameter list immediately following the event name.  
  
 **Error ID:** BC31122  
  
### To correct this error  
  
1.  Define a delegate with the same parameter list as the custom event.  
  
     For example, if the `Custom Event` was defined by `Custom Event Test(ByVal sender As Object, ByVal i As Integer)`, then the corresponding delegate would be the following.  
  
     [!code[VbVbalrEventError#18](../VS_csharp/codesnippet/VisualBasic/-custom--modifier-is-not-valid-on-events-declared-without-explicit-delegate-types_1.vb)]  
  
2.  Replace the parameter list of the custom event with an `As` clause specifying the delegate type.  
  
     Continuing with the example, `Custom Event` declaration would be rewritten as follows.  
  
     [!code[VbVbalrEventError#19](../VS_csharp/codesnippet/VisualBasic/-custom--modifier-is-not-valid-on-events-declared-without-explicit-delegate-types_2.vb)]  
  
## Example  
 This example declares a `Custom Event` and specifies the required `As` clause with a delegate type.  
  
 [!code[VbVbalrEventError#2](../VS_csharp/codesnippet/VisualBasic/-custom--modifier-is-not-valid-on-events-declared-without-explicit-delegate-types_3.vb)]  
  
## See Also  
 [Event Statement](../VS_csharp/event-statement.md)   
 [Delegate Statement](../VS_csharp/delegate-statement.md)   
 [Events in Visual Basic](../VS_csharp/events--visual-basic-.md)