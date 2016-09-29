---
title: "CPathT::CompactPathEx"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::CPathT::CompactPathEx"
  - "ATL.CPathT.CompactPathEx"
  - "CPathT<StringType>.CompactPathEx"
  - "CPathT.CompactPathEx"
  - "ATL.CPathT<StringType>.CompactPathEx"
  - "ATL::CPathT<StringType>::CompactPathEx"
  - "CPathT::CompactPathEx"
  - "CompactPathEx"
  - "CPathT<StringType>::CompactPathEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompactPathEx method"
ms.assetid: af7f071a-4b15-4e2c-b64e-8d3f52e2cd1b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::CompactPathEx
Call this method to truncate a file path to fit within a given number of characters by replacing path components with ellipses.  
  
## Syntax  
  
```  
  
      BOOL CompactPathEx(  
   UINT nMaxChars,  
   DWORD dwFlags = 0   
);  
```  
  
#### Parameters  
 `nMaxChars`  
 The maximum number of characters to be contained in the new string, including the terminating NULL character.  
  
 `dwFlags`  
 Reserved.  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Remarks  
 For more information, see [PathCompactPathEx](http://msdn.microsoft.com/library/windows/desktop/bb773578).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)   
 [CPathT::CompactPath](../vs140/cpatht--compactpath.md)