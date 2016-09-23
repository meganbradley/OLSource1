---
title: "Event &#39;&lt;eventname&gt;&#39; event specified by the &#39;DefaultEvent&#39; attribute is not a publicly accessible event for this class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc30770
  - bc30770
helpviewer_keywords: 
  - BC30770
ms.assetid: 7524fba7-2a37-4bc3-b789-87d73a166575
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Event &#39;&lt;eventname&gt;&#39; event specified by the &#39;DefaultEvent&#39; attribute is not a publicly accessible event for this class
The <xref:System.ComponentModel.DefaultEventAttribute?qualifyHint=False> attribute must specify the name of publicly accessible event in the class to which the attribute is applied.  
  
 **Error ID:** BC30770  
  
### To correct this error  
  
1.  Make sure the class defines a publicly accessible event.  
  
2.  Make sure that the name of the event in the class matches the name specified by the <xref:System.ComponentModel.DefaultEventAttribute?qualifyHint=False> attribute.  
  
## See Also  
 <xref:System.ComponentModel.DefaultEventAttribute?qualifyHint=False>   
 [Event Statement](../vs140/event-statement.md)   
 [Class Statement (Visual Basic)](../vs140/class-statement--visual-basic-.md)   
 [Public (Visual Basic)](../vs140/public--visual-basic-.md)