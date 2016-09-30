---
title: "CvWriteAlert Function"
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
  - "cvmarkers/CvWriteAlertVA"
  - "cvmarkers/CvWriteAlertVW"
  - "cvmarkers/CvWriteAlertA"
  - "cvmarkers/CvWriteAlertW"
helpviewer_keywords: 
  - "CvWriteAlertVW method"
  - "CvWriteAlertA method"
  - "CvWriteAlertVA method"
  - "CvWriteAlertW method"
ms.assetid: 937aa9d6-278a-4df3-bef7-151441df16d5
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CvWriteAlert Function
Writes an alert to the Concurrency Visualizer trace file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 List of arguments.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Valid marker series context. Cannot be NULL.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Message format string. Cannot be NULL.  
  
## Return Value  
 S_OK when the message is successfully written. Error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
 **Unicode:** CvWriteAlertW, CvWriteAlertVW  
  
 **ANSI:** CvWriteAlertA, CvWriteAlertVA  
  
## See Also  
 [Native Reference](../vs140/c---library-reference.md)