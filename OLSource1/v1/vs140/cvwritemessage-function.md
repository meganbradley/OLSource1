---
title: "CvWriteMessage Function"
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
  - "cvmarkers/CvWriteMessageW"
  - "cvmarkers/CvWriteMessageExW"
  - "cvmarkers/CvWriteMessageVA"
  - "cvmarkers/CvWriteMessageExVW"
  - "cvmarkers/CvWriteMessageExA"
  - "cvmarkers/CvWriteMessageA"
  - "cvmarkers/CvWriteMessageExVA"
  - "cvmarkers/CvWriteMessageVW"
helpviewer_keywords: 
  - "CvWriteMessageExVA method"
  - "CvWriteMessageW method"
  - "CvWriteMessageVW method"
  - "CvWriteMessageExVW method"
  - "CvWriteMessageExW method"
  - "CvWriteMessageA method"
  - "CvWriteMessageVA method"
  - "CvWriteMessageExA method"
ms.assetid: e20ae7be-bfa7-437a-b8c1-fa0f1baa7f83
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CvWriteMessage Function
Writes a message to the Concurrency Visualizer trace file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 List of arguments.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Category of the span  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Importance level of the span.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Valid marker series context. Cannot be NULL.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Message format string. Cannot be NULL.  
  
## Return Value  
 S_OK when the message is successfully written. Error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
 **Unicode:** CvWriteMessageW, CvWriteMessageVW, CvWriteMessageExW, CvWriteMessageExVW  
  
 **ANSI:** CvWriteMessageA, CvWriteMessageVA, CvWriteMessageExA, CvWriteMessageExVA  
  
## See Also  
 [Native Reference](../vs140/c---library-reference.md)