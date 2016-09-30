---
title: "NMAKE Fatal Error U1051"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "U1051"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "U1051"
ms.assetid: fede5cd5-dac3-47b7-b86d-e1acfb78699f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NMAKE Fatal Error U1051
out of memory  
  
 NMAKE ran out of memory, including virtual memory, because the makefile was too large or complex.  
  
### To fix by using the following possible solutions  
  
1.  Free some space on disk.  
  
2.  Increase the size of the Windows NT paging file or the Windows swap file.  
  
3.  If only part of the makefile is being used, either divide the makefile into separate files or use **!IF** preprocessing directives to limit the amount that NMAKE must process. The **!IF** directives include **!IF**, <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, **!IFNDEF**, **!ELSE IF**, **!ELSE** <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and **!ELSE** <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.