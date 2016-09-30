---
title: "&#39;&lt;methodname&gt;&#39; has multiple definitions with identical signatures"
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
  - "vbc30269"
  - "bc30269"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30269"
ms.assetid: 39489621-6617-4e5c-9b24-c2faf8273891
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;methodname&gt;&#39; has multiple definitions with identical signatures
A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> procedure declaration uses the identical procedure name and argument list as a previous declaration. One possible cause is an attempt to overload the original procedure. Overloaded procedures must have different argument lists.  
  
 **Error ID:** BC30269  
  
### To correct this error  
  
-   Change the procedure name or the argument list, or remove the duplicate declaration.  
  
## See Also  
 [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md)   
 [Considerations in Overloading Procedures](../vs140/considerations-in-overloading-procedures--visual-basic-.md)