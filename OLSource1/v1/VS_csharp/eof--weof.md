---
title: "EOF, WEOF"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "EOF"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "EOF function"
  - "WEOF function"
  - "end of file"
ms.assetid: a7150563-cdae-4cdf-9798-ad509990e505
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EOF, WEOF
## Syntax  
  
```  
  
#include <stdio.h>  
```  
  
## Remarks  
 EOF is returned by an I/O routine when the end-of-file (or in some cases, an error) is encountered.  
  
 WEOF yields the return value, of type **wint_t**, used to signal the end of a wide stream, or to report an error condition.  
  
## See Also  
 [putc, putwc](../VS_csharp/putc--putwc.md)   
 [ungetc, ungetwc](../VS_csharp/ungetc--ungetwc.md)   
 [scanf, _scanf_l, wscanf, _wscanf_l](../VS_csharp/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [fflush](../VS_csharp/fflush.md)   
 [fclose, _fcloseall](../VS_csharp/fclose--_fcloseall.md)   
 [_ungetch, _ungetwch, _ungetch_nolock, _ungetwch_nolock](../VS_csharp/_ungetch--_ungetwch--_ungetch_nolock--_ungetwch_nolock.md)   
 [_putch, _putwch](../VS_csharp/_putch--_putwch.md)   
 [isascii, __isascii, iswascii](../VS_csharp/isascii--__isascii--iswascii.md)   
 [Global Constants](../VS_csharp/global-constants.md)