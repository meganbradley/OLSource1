---
title: "&#39;System.ObsoleteAttribute&#39; cannot be applied to the &#39;AddHandler&#39;, &#39;RemoveHandler&#39;, or &#39;RaiseEvent&#39; definitions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc31142"
  - "vbc31142"
helpviewer_keywords: 
  - "BC31142"
ms.assetid: 2bddde2e-9ca0-4f72-8910-0789a6350af8
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;System.ObsoleteAttribute&#39; cannot be applied to the &#39;AddHandler&#39;, &#39;RemoveHandler&#39;, or &#39;RaiseEvent&#39; definitions
'System.ObsoleteAttribute' cannot be applied to the 'AddHandler', 'RemoveHandler', or 'RaiseEvent' definitions. If required, apply the attribute directly to the event.  
  
 A custom event applies the <xref:System.ObsoleteAttribute*> to its `AddHandler`, `RemoveHandler`, or `RaiseEvent` procedure.  
  
 The <xref:System.ObsoleteAttribute*> marks a programming element as no longer in use and informs users that the element is to be removed in future versions of the product.  
  
 It is not meaningful to have certain parts of a custom event still in use while others are no longer in use.  
  
 **Error ID:** BC31142  
  
### To correct this error  
  
-   Remove the <xref:System.ObsoleteAttribute*> from the individual procedure declaration and apply it to the overall event declaration.  
  
## See Also  
 <xref:System.ObsoleteAttribute*>   
 [Event Statement](../vs140/event-statement.md)   
 [AddHandler Statement](../vs140/addhandler-statement.md)   
 [RemoveHandler Statement](../vs140/removehandler-statement.md)   
 [RaiseEvent Statement](../vs140/raiseevent-statement.md)