---
title: "fwide"
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
  - "fwide"
apilocation: 
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fwide"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fwide function"
ms.assetid: a4641f5b-d74f-4946-95d5-53a64610d28d
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fwide
Unimplemented.  
  
## Syntax  
  
```  
int fwide(  
   FILE *stream,  
   int mode;  
);  
```  
  
#### Parameters  
 `stream`  
 Pointer to `FILE` structure (ignored).  
  
 `mode`  
 The new width of the stream: positive for wide character, negative for byte, zero to leave unchanged. (This value is ignored.)  
  
## Return Value  
 This function currently just returns `mode`.  
  
## Remarks  
 The current version of this function does not comply with the Standard.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|`fwide`|<wchar.h>|  
  
 For more information, see [Compatibility](../vs140/compatibility.md).