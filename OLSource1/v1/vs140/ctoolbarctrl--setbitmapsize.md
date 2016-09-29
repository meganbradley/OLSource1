---
title: "CToolBarCtrl::SetBitmapSize"
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
  - "SetBitmapSize"
  - "CToolBarCtrl.SetBitmapSize"
  - "CToolBarCtrl::SetBitmapSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBitmapSize method"
ms.assetid: a315d565-a69d-4b80-99c1-71779edbe52c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetBitmapSize
Sets the size of the actual bitmapped images to be added to a toolbar control.  
  
## Syntax  
  
```  
  
      BOOL SetBitmapSize(  
   CSize size   
);  
```  
  
#### Parameters  
 `size`  
 Width and height, in pixels, of the bitmapped images.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 This function must be called only before adding any bitmaps to the toolbar. If the application does not explicitly set the bitmap size, it defaults to 16 by 15 pixels.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetButtonSize](../vs140/ctoolbarctrl--setbuttonsize.md)   
 [CToolBarCtrl::GetItemRect](../vs140/ctoolbarctrl--getitemrect.md)