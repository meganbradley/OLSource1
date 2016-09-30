---
title: "___setlc_active_func, ___unguarded_readlc_active_add_func"
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
  - "___setlc_active_func"
  - "___unguarded_readlc_active_add_func"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "___unguarded_readlc_active_add_func"
  - "___setlc_active_func"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "___setlc_active_func"
  - "___unguarded_readlc_active_add_func"
ms.assetid: 605ec4e3-81e5-4ece-935a-f434768cc702
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ___setlc_active_func, ___unguarded_readlc_active_add_func
OBSOLETE. The CRT exports these internal functions only to preserve binary compatibility.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The value returned is not significant.  
  
## Remarks  
 Although the internal CRT functions <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are obsolete and no longer used, they are exported by the CRT library to preserve binary compatibility. The original purpose of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> was to return the number of currently active calls to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function. The original purpose of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> was to return the number of functions that referenced the locale without locking it.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|none|  
  
## See Also  
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)