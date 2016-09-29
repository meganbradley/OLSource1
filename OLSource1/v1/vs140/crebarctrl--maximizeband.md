---
title: "CReBarCtrl::MaximizeBand"
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
  - "CReBarCtrl.MaximizeBand"
  - "CReBarCtrl::MaximizeBand"
  - "MaximizeBand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, operations"
  - "MaximizeBand method"
ms.assetid: 340183f7-3976-43ed-b935-4d53ecd63eba
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::MaximizeBand
Resizes a band in a rebar control to its largest size.  
  
## Syntax  
  
```  
  
      void MaximizeBand(  
   UINT uBand   
);  
```  
  
#### Parameters  
 `uBand`  
 Zero-based index of the band to be maximized.  
  
## Remarks  
 Implements the behavior of the Win32 message [RB_MAXIMIZEBAND](http://msdn.microsoft.com/library/windows/desktop/bb774500) with `fIdeal` set to 0, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CReBarCtrl#10](../vs140/codesnippet/CPP/crebarctrl--maximizeband_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::MinimizeBand](../vs140/crebarctrl--minimizeband.md)   
 [CReBarCtrl::RestoreBand](../vs140/crebarctrl--restoreband.md)