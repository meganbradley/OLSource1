---
title: "CReBarCtrl::IDToIndex"
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
  - "IDToIndex"
  - "CReBarCtrl::IDToIndex"
  - "CReBarCtrl.IDToIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDToIndex method"
  - "CReBarCtrl class, attributes"
ms.assetid: 454c676b-19fe-46c4-a5c9-516927b9152f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::IDToIndex
Implements the behavior of the Win32 message [RB_IDTOINDEX](http://msdn.microsoft.com/library/windows/desktop/bb774496), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      int IDToIndex(  
   UINT uBandID   
) const;  
```  
  
#### Parameters  
 *uBandID*  
 The application-defined identifier of the specified band, passed in the **wID** member of the [REBARBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774393) structure when the band is inserted.  
  
## Return Value  
 The zero-based band index if successful, or -1 otherwise. If duplicate band indices exist, the first one is returned.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::InsertBand](../vs140/crebarctrl--insertband.md)