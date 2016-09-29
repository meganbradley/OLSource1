---
title: "CReBarCtrl::DeleteBand"
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
  - "DeleteBand"
  - "CReBarCtrl.DeleteBand"
  - "CReBarCtrl::DeleteBand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, operations"
  - "DeleteBand method"
ms.assetid: 40eaaf5d-3e5d-4dbb-8998-3a4737bd5a23
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::DeleteBand
Implements the behavior of the Win32 message [RB_DELETEBAND](http://msdn.microsoft.com/library/windows/desktop/bb774431), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      BOOL DeleteBand(  
   UINT uBand   
);  
```  
  
#### Parameters  
 `uBand`  
 Zero-based index of the band to be deleted.  
  
## Return Value  
 Nonzero if the band deleted successfully; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CReBarCtrl#4](../vs140/codesnippet/CPP/crebarctrl--deleteband_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)