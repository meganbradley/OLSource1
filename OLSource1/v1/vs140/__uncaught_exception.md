---
title: "__uncaught_exception"
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
  - "__uncaught_exception"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "__uncaught_exception"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__uncaught_exception"
ms.assetid: 4d9b75c6-c9c7-4876-b761-ea9ab1925e96
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __uncaught_exception
Indicates whether one or more exceptions have been thrown, but have not yet been handled by the corresponding `catch` block of a [try-catch](../vs140/try--throw--and-catch-statements--c---.md) statement.  
  
## Syntax  
  
```cpp  
bool __uncaught_exception(  
   );  
```  
  
## Return Value  
 `true` from the time an exception is thrown in a `try` block until the matching `catch` block is initialized; otherwise, `false`.  
  
## Remarks  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|__uncaught_exception|eh.h|  
  
## See Also  
 [The try, catch, and throw Statements](../vs140/try--throw--and-catch-statements--c---.md)