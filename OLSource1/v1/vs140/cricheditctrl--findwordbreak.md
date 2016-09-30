---
title: "CRichEditCtrl::FindWordBreak"
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
  - "FindWordBreak"
  - "CRichEditCtrl.FindWordBreak"
  - "CRichEditCtrl::FindWordBreak"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindWordBreak method"
ms.assetid: 99439b22-bca0-4987-99fd-80f152bb25bc
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::FindWordBreak
Finds the next word break before or after the position specified by `nStart`.  
  
## Syntax  
  
```  
  
      DWORD FindWordBreak(  
   UINT nCode,  
   DWORD nStart   
) const;  
```  
  
#### Parameters  
 `nCode`  
 Indicates the action to take. For a list of possible values, see the description for the parameter `code` in **EM_FINDWORDBREAK** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `nStart`  
 The zero-based character position from which to start.  
  
## Return Value  
 Based on the parameter `nCode`. For more information, see [EM_FINDWORDBREAK](http://msdn.microsoft.com/library/windows/desktop/bb788018) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 You can use this member function to retrieve information about a character at a given position.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)