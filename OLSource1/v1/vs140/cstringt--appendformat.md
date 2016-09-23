---
title: "CStringT::AppendFormat"
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
  - CStringT::AppendFormat
  - AppendFormat
  - CStringT.AppendFormat
  - ATL::CStringT::AppendFormat
  - ATL.CStringT.AppendFormat
dev_langs: 
  - C++
helpviewer_keywords: 
  - AppendFormat method
ms.assetid: c686fd78-8b44-4411-b90d-2f2581fe2f2f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStringT::AppendFormat
Appends formatted data to an existing `CStringT` object.  
  
## Syntax  
  
```  
void __cdecl AppendFormat(  
   PCXSTR pszFormat,  
   [, argument]...  
);  
void __cdecl AppendFormat(  
   UINT nFormatID,  
   [, argument]...  
);  
```  
  
#### Parameters  
 `pszFormat`  
 A format-control string.  
  
 `nFormatID`  
 The string resource identifier that contains the format-control string.  
  
 `argument`  
 Optional arguments.  
  
## Remarks  
 This function formats and appends a series of characters and values in the `CStringT`. Each optional argument (if any) is converted and appended according to the corresponding format specification in `pszFormat` or from the string resource identified by `nFormatID`.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#107](../vs140/codesnippet/CPP/cstringt--appendformat_1.cpp)]
  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)