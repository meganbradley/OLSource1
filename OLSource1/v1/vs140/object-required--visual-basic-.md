---
title: "Object required (Visual Basic)"
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
  - "vbrID424"
dev_langs: 
  - "VB"
ms.assetid: afdc660b-81a5-4c92-ac7e-9c3a3105fc16
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Object required (Visual Basic)
References to properties and methods often require an explicit object qualifier. This is such a case.  
  
### To correct this error  
  
1.  Check that references to an object property or method have valid object qualifier. Specify an object qualifier if you didn't provide one.  
  
2.  Check the spelling of the object qualifier and make sure the object is visible in the part of the program in which you are referencing it.  
  
3.  If a path is supplied to a host application's **File Open** command, check that the arguments in it are correct.  
  
4.  Check the object's documentation and make sure the action is valid.  
  
## See Also  
 [Types of Errors](../vs140/error-types--visual-basic-.md)