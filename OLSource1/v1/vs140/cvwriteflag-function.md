---
title: "CvWriteFlag Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "cvmarkers/CvWriteFlagExVA"
  - "cvmarkers/CvWriteFlagExW"
  - "cvmarkers/CvWriteFlagExVW"
  - "cvmarkers/CvWriteFlagExA"
helpviewer_keywords: 
  - "CvWriteFlagExW method"
  - "CvWriteFlagExVA method"
  - "CvWriteFlagExA method"
  - "CvWriteFlagExVW method"
ms.assetid: ee9da1e2-7b34-4cba-81e2-215d25d32e4d
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CvWriteFlag Function
Writes a flag to the Concurrency Visualizer trace file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 List of arguments.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Category.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Importance level.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Valid marker series context. Cannot be NULL.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Message format string. Cannot be NULL.  
  
## Return Value  
 S_OK when the message is successfully written. Error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
 **Unicode:** CvWriteFlagExW, CvWriteFlagExVW  
  
 **ANSI:**CvWriteFlagExA, CvWriteFlagExVA  
  
## See Also  
 [Native Reference](../vs140/c---library-reference.md)