---
title: "Too many files"
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
  - "vbrID67"
dev_langs: 
  - "VB"
ms.assetid: 2ff203e2-bba6-43ae-b72f-8e92a881c98f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Too many files
Either more files have been created in the root directory than the operating system permits, or more files have been opened than the number specified in the **files=** setting in your CONFIG.SYS file.  
  
### To correct this error  
  
1.  If your program is opening, closing, or saving files in the root directory, change your program so that it uses a subdirectory.  
  
2.  Increase the number of files specified in your **files=** setting in your CONFIG.SYS file, and restart your computer.  
  
## See Also  
 [Types of Errors](../vs140/error-types--visual-basic-.md)