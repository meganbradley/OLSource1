---
title: "CToolBarCtrl::LoadImages"
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
  - "LoadImages"
  - "CToolBarCtrl.LoadImages"
  - "CToolBarCtrl::LoadImages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadImages method"
ms.assetid: 062cc3a0-3609-47ff-a1c7-9afb49b70860
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::LoadImages
Loads bitmaps into a toolbar control's image list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *iBitmapID*  
 ID of a bitmap that contains the images to be loaded. To specify your own bitmap resource, set this parameter to the ID of a bitmap resource and set <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to **NULL**. Your bitmap resource will be added to the image list as a single image. You can add standard, system-defined bitmaps by setting *hinst* to **HINST_COMMCTRL** and setting this parameter to one of the following IDs:  
  
|Bitmap ID|Description|  
|---------------|-----------------|  
|IDB_HIST_LARGE_COLOR|Explorer bitmaps in large size|  
|IDB_HIST_SMALL_COLOR|Explorer bitmaps in small size|  
|IDB_STD_LARGE_COLOR|Standard bitmaps in large size|  
|IDB_STD_SMALL_COLOR|Standard bitmaps in small size|  
|IDB_VIEW_LARGE_COLOR|View bitmaps in large size|  
|IDB_VIEW_SMALL_COLOR|View bitmaps in small size|  
  
 *hinst*  
 Program instance handle to the calling application. This parameter can be **HINST_COMMCTRL** to load a standard image list.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_LOADIMAGES](http://msdn.microsoft.com/library/windows/desktop/bb787381), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetImageList](../vs140/ctoolbarctrl--setimagelist.md)   
 [CToolBarCtrl::GetImageList](../vs140/ctoolbarctrl--getimagelist.md)