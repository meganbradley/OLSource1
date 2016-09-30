---
title: "Events of shared WithEvents variables cannot be handled by non-shared methods"
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
  - "bc30594"
  - "vbc30594"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30594"
ms.assetid: 5b9fceb4-ab11-41bb-ad3b-6f1a9da8ae7e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Events of shared WithEvents variables cannot be handled by non-shared methods
A variable declared with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> modifier is a shared variable. A shared variable identifies exactly one storage location. A variable declared with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier asserts that the type to which the variable belongs handles the set of events the variable raises. When a value is assigned to the variable, the property created by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> declaration unhooks any existing event handler and hooks up the new event handler via the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method.  
  
 **Error ID:** BC30594  
  
### To correct this error  
  
-   Declare your event handler <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## See Also  
 [Shared](../vs140/shared--visual-basic-.md)   
 [WithEvents](../vs140/withevents--visual-basic-.md)