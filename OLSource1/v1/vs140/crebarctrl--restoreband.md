---
title: "CReBarCtrl::RestoreBand"
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
  - "RestoreBand"
  - "CReBarCtrl.RestoreBand"
  - "CReBarCtrl::RestoreBand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RestoreBand method"
ms.assetid: 53dd912c-46d9-40bb-a43f-d0d291cf4e2e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::RestoreBand
Resizes a band in a rebar control to its ideal size.  
  
## Syntax  
  
```  
  
      void RestoreBand(  
   UINT uBand  
);  
```  
  
#### Parameters  
 `uBand`  
 Zero-based index of the band to be maximized.  
  
## Remarks  
 Implements the behavior of the Win32 message [RB_MAXIMIZEBAND](http://msdn.microsoft.com/library/windows/desktop/bb774500) with `fIdeal` set to 1, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CReBarCtrl#12](../vs140/codesnippet/CPP/crebarctrl--restoreband_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::MaximizeBand](../vs140/crebarctrl--maximizeband.md)   
 [CReBarCtrl::MinimizeBand](../vs140/crebarctrl--minimizeband.md)