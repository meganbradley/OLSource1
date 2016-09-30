---
title: "CvEnterSpan Function"
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
  - "cvmarkers/CvEnterSpanVA"
  - "cvmarkers/CvEnterSpanW"
  - "cvmarkers/CvEnterSpanExW"
  - "cvmarkers/CvEnterSpanA"
  - "cvmarkers/CvEnterSpanExVW"
  - "cvmarkers/CvEnterSpanExA"
  - "cvmarkers/CvEnterSpanVW"
helpviewer_keywords: 
  - "CvEnterSpanVW method"
  - "CvEnterSpanVA method"
  - "CvEnterSpanExA method"
  - "CvEnterSpanW method"
  - "CvEnterSpanA method"
  - "CvEnterSpanExVW method"
  - "CvEnterSpanExW method"
ms.assetid: 91689e9c-6733-44b9-b36a-8b9b2eef7d1d
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CvEnterSpan Function
Marks the beginning of a new span.  
  
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
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Address of the variable which will hold resulting span object. Address cannot be NULL, the variable can have any value.  
  
## Return Value  
 S_OK when the message is successfully written. Error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
 **Unicode:** CvEnterSpanW, CvEnterSpanVW, CvEnterSpanExW, CvEnterSpanExVW  
  
 **ANSI:** CvEnterSpanA, CvEnterSpanVA, CvEnterSpanExA, CvEnterSpanExVW  
  
## See Also  
 [Native Reference](../vs140/c---library-reference.md)