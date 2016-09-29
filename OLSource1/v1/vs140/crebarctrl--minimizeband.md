---
title: "CReBarCtrl::MinimizeBand"
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
  - "MinimizeBand"
  - "CReBarCtrl::MinimizeBand"
  - "CReBarCtrl.MinimizeBand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MinimizeBand method"
  - "CReBarCtrl class, operations"
ms.assetid: 0f5bdb84-abb4-4fb3-89de-0c674eaf0241
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::MinimizeBand
Resizes a band in a rebar control to its smallest size.  
  
## Syntax  
  
```  
  
      void MinimizeBand(  
   UINT uBand   
);  
```  
  
#### Parameters  
 `uBand`  
 Zero-based index of the band to be minimized.  
  
## Remarks  
 Implements the behavior of the Win32 message [RB_MINIMIZEBAND](http://msdn.microsoft.com/library/windows/desktop/bb774502), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CReBarCtrl#11](../vs140/codesnippet/CPP/crebarctrl--minimizeband_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::MaximizeBand](../vs140/crebarctrl--maximizeband.md)