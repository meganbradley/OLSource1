---
title: "THIS_FILE"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFX/THIS_FILE"
  - "THIS_FILE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "THIS_FILE macro"
ms.assetid: 68c147ab-c696-4b20-80a4-5e6db2b15132
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# THIS_FILE
Expands to the name of the file that is being compiled.  
  
## Syntax  
  
```  
  
THIS_FILE  
  
```  
  
## Remarks  
 The information is used by the **ASSERT** and **VERIFY** macros. The Application Wizard and code wizards place the macro in source code files they create.  
  
## Example  
 [!code[NVC_MFC_Utilities#35](../vs140/codesnippet/CPP/this_file_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ASSERT](../vs140/assert--mfc-.md)   
 [VERIFY](../vs140/verify.md)