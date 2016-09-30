---
title: "_except_handler3"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_except_handler3"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_except_handler3"
  - "except_handler3"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_except_handler3 function"
  - "except_handler3 function"
ms.assetid: b0c64898-0ae5-48b7-9724-80135a0813e2
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _except_handler3
Internal CRT function. Used by a framework to find the appropriate exception handler to process the current exception.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Information about the specific exception.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The record that indicates which scope table should be used to find the exception handler.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Reserved.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Reserved.  
  
## Return Value  
 If an exception should be dismissed, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If the exception should be passed up a level to the encapsulating exception handlers, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 If this method finds an appropriate exception handler, it passes the exception to the handler. In this situation, this method does not return to the code that called it and the return value is irrelevant.  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)