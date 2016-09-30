---
title: "CReBarCtrl::MoveBand"
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
  - "MoveBand"
  - "CReBarCtrl.MoveBand"
  - "CReBarCtrl::MoveBand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, operations"
  - "MoveBand method"
ms.assetid: c9c7f084-76d0-40ef-92b7-45d6f79aedc4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::MoveBand
Implements the behavior of the Win32 message [RB_MOVEBAND](http://msdn.microsoft.com/library/windows/desktop/bb774504), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *uFrom*  
 Zero-based index of the band to be moved.  
  
 *uTo*  
 Zero-based index of the new band position. This parameter value must never be greater than the number of bands minus one. To obtain the number of bands, call [GetBandCount](../vs140/crebarctrl--getbandcount.md).  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)