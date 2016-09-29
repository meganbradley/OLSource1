---
title: "_amsg_exit"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_amsg_exit"
apilocation: 
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_amsg_exit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_amsg_exit"
ms.assetid: 146d4faf-d763-43a4-b264-12711196456b
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _amsg_exit
Emits a specified runtime error message and then exits your application with error code 255.  
  
## Syntax  
  
```cpp  
void _amsg_exit (  
   int rterrnum  
   )  
```  
  
#### Parameters  
 `rterrnum`  
 The identification number of a system-defined runtime error message.  
  
## Remarks  
 This function emits the runtime error message to **stderr** for console applications, or displays the message in a message box for Windows applications. In debug mode, you can choose to invoke the debugger before exiting.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|_amsg_exit|internal.h|