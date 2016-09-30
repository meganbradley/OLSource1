---
title: "Type &#39;&lt;typename&gt;&#39; has no constructors"
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
  - "bc30251"
  - "vbc30251"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30251"
ms.assetid: aff3e1df-abe6-4bc0-9abc-a1e70514c561
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type &#39;&lt;typename&gt;&#39; has no constructors
A type does not support a call to `Sub New()`. One possible cause is a corrupted compiler or binary file.  
  
 **Error ID:** BC30251  
  
### To correct this error  
  
1.  If the type is in a different project or in a referenced file, reinstall the project or file.  
  
2.  If the type is in the same project, recompile the assembly containing the type.  
  
3.  If the error recurs, reinstall the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler.  
  
4.  If the error persists, gather information about the circumstances and notify Microsoft Product Support Services.  
  
## See Also  
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)   
 [Product Support and Accessibility](../vs140/talk-to-us.md)