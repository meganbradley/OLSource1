---
title: "CReBarCtrl::InsertBand"
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
  - "InsertBand"
  - "CReBarCtrl.InsertBand"
  - "CReBarCtrl::InsertBand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, operations"
  - "InsertBand method"
ms.assetid: d07b5831-fe54-4235-9f7c-d3a887411f3b
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::InsertBand
Implements the behavior of the Win32 message [RB_INSERTBAND](http://msdn.microsoft.com/library/windows/desktop/bb774498), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      BOOL InsertBand(  
   UINT uIndex,  
   REBARBANDINFO* prbbi   
);  
```  
  
#### Parameters  
 *uIndex*  
 Zero-based index of the location where the band will be inserted. If you set this parameter to -1, the control will add the new band at the last location.  
  
 `prbbi`  
 A pointer to a [REBARBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774393) structure that defines the band to be inserted. You must set the `cbSize` member of this structure to `sizeof(REBARBANDINFO)` before calling this function.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CReBarCtrl#9](../vs140/codesnippet/CPP/crebarctrl--insertband_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)