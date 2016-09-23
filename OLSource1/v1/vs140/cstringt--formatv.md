---
title: "CStringT::FormatV"
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
  - CStringT::FormatV
  - FormatV
  - ATL.CStringT.FormatV
  - ATL::CStringT::FormatV
  - CStringT.FormatV
dev_langs: 
  - C++
helpviewer_keywords: 
  - FormatV method
ms.assetid: 0330ddca-4fa4-492b-b909-843e5f622ad3
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStringT::FormatV
Formats a message string using a variable argument list.  
  
## Syntax  
  
```  
void FormatV(  
   PCXSTR pszFormat,  
   va_list args  
);  
```  
  
#### Parameters  
 `pszFormat`  
 Points to the format-control string. It will be scanned for inserts and formatted accordingly. The format string is similar to run-time function `printf`-style format strings, except it allows for the parameters to be inserted in an arbitrary order.  
  
 `args`  
 Pointer to a list of arguments.  
  
## Remarks  
 Writes a formatted string and a variable list of arguments to a `CStringT` string in the same way that `vsprintf_s` formats data into a C-style character array.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#119](../vs140/codesnippet/CPP/cstringt--formatv_1.cpp)]
  
  
 [!code[NVC_ATLMFC_Utilities#120](../vs140/codesnippet/CPP/cstringt--formatv_2.cpp)]
  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)