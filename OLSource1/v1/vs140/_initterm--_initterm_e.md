---
title: "_initterm, _initterm_e"
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
  - "_initterm_e"
  - "_initterm"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_initterm_e"
  - "initterm"
  - "_initterm"
  - "initterm_e"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "initterm function"
  - "initterm_e function"
  - "_initterm function"
  - "_initterm_e function"
ms.assetid: 85131efe-c747-429a-8897-bcdedb000172
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _initterm, _initterm_e
Internal methods that walk a table of function pointers and initialize them.  
  
 The first pointer is the starting location in the table and the second pointer is the ending location.  
  
## Syntax  
  
```  
void __cdecl _initterm(  
   PVFV *,  
   PVFV *  
);  
  
int __cdecl _initterm_e(  
   PVFV *,  
   PVFV *  
);  
```  
  
## Return Value  
 A non-zero error code if an initialization fails and throws an error; 0 if no error occurs.  
  
## Remarks  
 These methods are only called internally during the initialization of a C++ program. Do not call these methods in a program.  
  
 When these methods walk a table of function entries, they skip `NULL` entries and continue.  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)