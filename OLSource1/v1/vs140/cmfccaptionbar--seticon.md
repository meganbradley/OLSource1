---
title: "CMFCCaptionBar::SetIcon"
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
  - "CMFCCaptionBar::SetIcon"
  - "SetIcon"
  - "CMFCCaptionBar.SetIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetIcon method"
ms.assetid: a9af0caf-fb79-4a29-b3d1-816194d29fba
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionBar::SetIcon
Sets the icon for a caption bar.  
  
## Syntax  
  
```  
void SetIcon(  
   HICON hIcon,  
   BarElementAlignment iconAlignment=ALIGN_RIGHT   
);  
```  
  
#### Parameters  
 [in] `hIcon`  
 The handle to the icon to set.  
  
 [in] `iconAlignment`  
 The alignment of the icon.  
  
## Remarks  
 Caption bars can display either icons or bitmaps. See [CMFCCaptionBar::SetBitmap](../vs140/cmfccaptionbar--setbitmap.md) to find out how to display a bitmap. If you set both an icon and a bitmap, the icon is always displayed. Call [CMFCCaptionBar::RemoveIcon](../vs140/cmfccaptionbar--removeicon.md) to remove an icon from the caption bar.  
  
 The icon is aligned according to the `iconAlignment` parameter. It can be one of the following `BarElementAlignment` values:  
  
-   ALIGN_INVALID  
  
-   ALIGN_LEFT  
  
-   ALIGN_RIGHT  
  
-   ALIGN_CENTER  
  
## Requirements  
 **Header:** afxcaptionbar.h  
  
## See Also  
 [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)