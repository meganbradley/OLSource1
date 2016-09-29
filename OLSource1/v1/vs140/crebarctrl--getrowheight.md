---
title: "CReBarCtrl::GetRowHeight"
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
  - "CReBarCtrl::GetRowHeight"
  - "CReBarCtrl.GetRowHeight"
  - "GetRowHeight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRowHeight method"
  - "CReBarCtrl class, attributes"
ms.assetid: 1c31bc1c-b476-4a9a-bd38-1d09d49a8d6f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::GetRowHeight
Implements the behavior of the Win32 message [RB_GETROWHEIGHT](http://msdn.microsoft.com/library/windows/desktop/bb774473), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      UINT GetRowHeight(  
   UINT uRow   
) const;  
```  
  
#### Parameters  
 *uRow*  
 Zero-based index of the band that will have its height retrieved.  
  
## Return Value  
 A **UINT** value that represents the row height, in pixels.  
  
## Example  
 [!code[NVC_MFC_CReBarCtrl#8](../vs140/codesnippet/CPP/crebarctrl--getrowheight_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::GetRowCount](../vs140/crebarctrl--getrowcount.md)