---
title: "CToolBarCtrl::ChangeBitmap"
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
  - "CToolBarCtrl.ChangeBitmap"
  - "CToolBarCtrl::ChangeBitmap"
  - "ChangeBitmap method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ChangeBitmap method."
ms.assetid: 7b561c86-d907-46dc-8f03-62e66b32c828
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::ChangeBitmap
Changes the bitmap for a button in the current toolbar control.  
  
## Syntax  
  
```  
BOOL ChangeBitmap(  
     int idButton,   
     int iBitmap  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `idButton`|Command identifier of the button that is to receive a new bitmap.|  
|[in] `iBitmap`|Zero-based index of an image in the current toolbar control's image list.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 If this method is successful, the system displays the specified image in the specified button.  
  
 This method sends the [TB_CHANGEBITMAP](http://msdn.microsoft.com/library/windows/desktop/bb787301) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Example  
 The following code example changes the bitmap for the **File Save** button to the bitmap for the **About** button.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#1](../vs140/codesnippet/CPP/ctoolbarctrl--changebitmap_1.cpp)]  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TB_CHANGEBITMAP](http://msdn.microsoft.com/library/windows/desktop/bb787301)   
 [CToolBarCtrl::ReplaceBitmap](../vs140/ctoolbarctrl--replacebitmap.md)