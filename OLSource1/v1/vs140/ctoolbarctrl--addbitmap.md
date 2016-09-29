---
title: "CToolBarCtrl::AddBitmap"
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
  - "CToolBarCtrl.AddBitmap"
  - "AddBitmap"
  - "CToolBarCtrl::AddBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddBitmap method"
ms.assetid: 3701226f-ec4a-49d1-811b-ee00dd189e12
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::AddBitmap
Adds one or more button images to the list of button images stored in the toolbar control.  
  
## Syntax  
  
```  
  
      int AddBitmap(  
   int nNumButtons,  
   UINT nBitmapID   
);  
int AddBitmap(  
   int nNumButtons,  
   CBitmap* pBitmap   
);  
```  
  
#### Parameters  
 `nNumButtons`  
 Number of button images in the bitmap.  
  
 `nBitmapID`  
 Resource identifier of the bitmap that contains the button image or images to add.  
  
 `pBitmap`  
 Pointer to the `CBitmap` object that contains the button image or images to add.  
  
## Return Value  
 Zero-based index of the first new image if successful; otherwise – 1.  
  
## Remarks  
 You can use the Windows API [CreateMappedBitmap](http://msdn.microsoft.com/library/windows/desktop/bb787467) to map colors before adding the bitmap to the toolbar. If you pass a pointer to a **CBitMap** object, you must ensure that the bitmap is not destroyed until after the toolbar is destroyed.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md)   
 [CToolBarCtrl::InsertButton](../vs140/ctoolbarctrl--insertbutton.md)   
 [CToolBarCtrl::AddString](../vs140/ctoolbarctrl--addstring.md)   
 [CToolBarCtrl::AddStrings](../vs140/ctoolbarctrl--addstrings.md)