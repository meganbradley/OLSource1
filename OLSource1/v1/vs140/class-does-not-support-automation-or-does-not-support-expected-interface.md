---
title: "Class does not support Automation or does not support expected interface"
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
  - "vbrID430"
dev_langs: 
  - "VB"
ms.assetid: d985bb7e-e48e-443e-86f2-ddb86758757c
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Class does not support Automation or does not support expected interface
Either the class you specified in the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function call has not exposed a programmability interface, or you changed a project from .dll to .exe, or vice versa.  
  
### To correct this error  
  
1.  Check the documentation of the application that created the object for limitations on the use of automation with this class of object.  
  
2.  If you changed a project from .dll to .exe or vice versa, you must manually unregister the old .dll or .exe.  
  
## See Also  
 [Types of Errors](../vs140/error-types--visual-basic-.md)   
 [Product Support and Accessibility](../vs140/talk-to-us.md)