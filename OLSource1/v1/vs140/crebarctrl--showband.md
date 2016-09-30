---
title: "CReBarCtrl::ShowBand"
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
  - "ShowBand"
  - "CReBarCtrl.ShowBand"
  - "CReBarCtrl::ShowBand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, operations"
  - "ShowBand method"
ms.assetid: 26147248-a8bd-47c2-bb77-5d1c079904e2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::ShowBand
Implements the behavior of the Win32 message [RB_SHOWBAND](http://msdn.microsoft.com/library/windows/desktop/bb774532), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      BOOL ShowBand(  
   UINT uBand,  
   BOOL fShow = TRUE   
);  
```  
  
#### Parameters  
 `uBand`  
 Zero-based index of a band in the rebar control.  
  
 *fShow*  
 Indicates if the band should be shown or hidden. If this value is **TRUE**, the band will be shown. Otherwise, the band will be hidden.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::SetBandInfo](../vs140/crebarctrl--setbandinfo.md)   
 [CReBarCtrl::GetBandCount](../vs140/crebarctrl--getbandcount.md)   
 [CReBarCtrl::DeleteBand](../vs140/crebarctrl--deleteband.md)   
 [CReBarCtrl::InsertBand](../vs140/crebarctrl--insertband.md)   
 [CReBarCtrl::GetBandInfo](../vs140/crebarctrl--getbandinfo.md)