---
title: "CStringT::FormatMessageV"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CStringT.FormatMessageV
  - CStringT::FormatMessageV
  - ATL.CStringT.FormatMessageV
  - ATL::CStringT::FormatMessageV
  - FormatMessageV
dev_langs: 
  - C++
helpviewer_keywords: 
  - FormatMessageV method
ms.assetid: c21bb1e8-610d-4f84-89e6-ddfb0c8e6291
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStringT::FormatMessageV
Formats a message string using a variable argument list.  
  
## Syntax  
  
```  
void FormatMessageV(  
   PCXSTR pszFormat,  
   va_list* pArgList  
);  
```  
  
#### Parameters  
 `pszFormat`  
 Points to the format-control string. It will be scanned for inserts and formatted accordingly. The format string is similar to run-time function `printf`-style format strings, except it allows for the parameters to be inserted in an arbitrary order.  
  
 `pArgList`  
 Pointer to a list of arguments.  
  
## Remarks  
 The function requires a message definition as input, determined by `pszFormat`. The function copies the formatted message text and a variable list of arguments to the `CStringT` object, processing any embedded insert sequences if requested.  
  
> [!NOTE]
>  `FormatMessageV` calls [CStringT::FormatMessage](../vs140/cstringt--formatmessage.md), which attempts to allocate system memory for the newly formatted string. If this attempt fails, a memory exception is automatically thrown.  
  
 For more information, see the Windows [FormatMessage](http://msdn.microsoft.com/library/windows/desktop/ms679351) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)   
 [CStringT::FormatMessage](../vs140/cstringt--formatmessage.md)   
 [printf_s, _printf_s_l, wprintf_s, _wprintf_s_l](../vs140/printf_s--_printf_s_l--wprintf_s--_wprintf_s_l.md)