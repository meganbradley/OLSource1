---
title: "CMFCMaskedEdit::IsMaskedChar"
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
  - "CMFCMaskedEdit::IsMaskedChar"
  - "CMFCMaskedEdit.IsMaskedChar"
  - "IsMaskedChar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsMaskedChar method"
ms.assetid: 5c2b0bc8-0e4c-4fbd-816e-edea19519796
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMaskedEdit::IsMaskedChar
Called by the framework to validate the specified character against the corresponding mask character.  
  
## Syntax  
  
```  
virtual BOOL IsMaskedChar(  
   TCHAR chChar,  
   TCHAR chMaskChar   
) const;  
```  
  
#### Parameters  
 [in] `chChar`  
 The character to be validated.  
  
 [in] `chMaskChar`  
 The corresponding character from the mask string.  
  
## Return Value  
 `TRUE` if the `chChar` parameter is the type of character permitted by the `chMaskChar` parameter; otherwise, `FALSE`.  
  
## Remarks  
 Override this method to validate input characters on your own. For more information about mask characters, see the [CMFCMaskedEdit::EnableMask](../vs140/cmfcmaskededit--enablemask.md) method.  
  
## Requirements  
 **Header:** afxmaskededit.h  
  
## See Also  
 [CMFCMaskedEdit Class](../vs140/cmfcmaskededit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)