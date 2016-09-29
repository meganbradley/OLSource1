---
title: "CToolBar::GetButtonInfo"
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
  - "CToolBar::GetButtonInfo"
  - "GetButtonInfo"
  - "CToolBar.GetButtonInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "toolbar controls [MFC], getting information"
  - "GetButtonInfo method"
  - "CToolBar class, attributes"
ms.assetid: a2ad9fdd-adb9-4964-a79e-72fbca24d240
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBar::GetButtonInfo
This member function retrieves the control ID, style, and image index of the toolbar button or separator at the location specified by *nIndex.*  
  
## Syntax  
  
```  
  
      void GetButtonInfo(  
   int nIndex,  
   UINT& nID,  
   UINT& nStyle,  
   int& iImage   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Index of the toolbar button or separator whose information is to be retrieved.  
  
 `nID`  
 Reference to a **UINT** that is set to the command ID of the button.  
  
 `nStyle`  
 Reference to a **UINT** that is set to the style of the button.  
  
 `iImage`  
 Reference to an integer that is set to the index of the button's image within the bitmap.  
  
## Remarks  
 Those values are assigned to the variables referenced by `nID`, `nStyle`, and `iImage`. The image index is the position of the image within the bitmap that contains images for all the toolbar buttons. The first image is at position 0.  
  
 If `nIndex` specifies a separator, `iImage` is set to the separator width in pixels.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::SetButtonInfo](../vs140/ctoolbar--setbuttoninfo.md)   
 [CToolBar::GetItemID](../vs140/ctoolbar--getitemid.md)