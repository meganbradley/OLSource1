---
title: "CReBarCtrl::GetRect"
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
  - "CReBarCtrl.GetRect"
  - "CReBarCtrl::GetRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, attributes"
  - "GetRect method"
ms.assetid: 675c1244-204a-44ea-b158-d176bc62297a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::GetRect
Implements the behavior of the Win32 message [RB_GETRECT](http://msdn.microsoft.com/library/windows/desktop/bb774469), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      BOOL GetRect(  
   UINT uBand,  
   LPRECT prc  
) const;  
```  
  
#### Parameters  
 `uBand`  
 Zero-based index of a band in the rebar control.  
  
 `prc`  
 A pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that will receive the bounds of the rebar band.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CReBarCtrl#6](../vs140/codesnippet/CPP/crebarctrl--getrect_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::SizeToRect](../vs140/crebarctrl--sizetorect.md)