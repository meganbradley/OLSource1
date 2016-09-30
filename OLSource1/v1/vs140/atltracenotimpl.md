---
title: "ATLTRACENOTIMPL"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "atlTraceNotImpl"
  - "ATL::atlTraceNotImpl"
  - "ATL.atlTraceNotImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATLTRACENOTIMPL macro"
  - "ATL, debugging"
  - "debugging [ATL], trace macros"
ms.assetid: 1ee1bede-3f30-49b1-bc52-87672cb5e296
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLTRACENOTIMPL
In debug builds of ATL, sends the string "<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is not implemented" to the dump device and returns **E_NOTIMPL**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A string containing the name of the function that is not implemented.  
  
## Remarks  
 In release builds, simply returns **E_NOTIMPL**.  
  
## Example  
 [!code[NVC_ATL_Utilities#127](../vs140/codesnippet/CPP/atltracenotimpl_1.cpp)]  
  
## Requirements  
 **Header:** atltrace.h  
  
## See Also  
 [Debugging and Error Reporting Macros](../vs140/debugging-and-error-reporting-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [ATLTRACE2](../vs140/atltrace2.md)