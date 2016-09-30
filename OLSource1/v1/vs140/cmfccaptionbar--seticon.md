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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionBar::SetIcon
Sets the icon for a caption bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The handle to the icon to set.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The alignment of the icon.  
  
## Remarks  
 Caption bars can display either icons or bitmaps. See [CMFCCaptionBar::SetBitmap](../vs140/cmfccaptionbar--setbitmap.md) to find out how to display a bitmap. If you set both an icon and a bitmap, the icon is always displayed. Call [CMFCCaptionBar::RemoveIcon](../vs140/cmfccaptionbar--removeicon.md) to remove an icon from the caption bar.  
  
 The icon is aligned according to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter. It can be one of the following <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> values:  
  
-   ALIGN_INVALID  
  
-   ALIGN_LEFT  
  
-   ALIGN_RIGHT  
  
-   ALIGN_CENTER  
  
## Requirements  
 **Header:** afxcaptionbar.h  
  
## See Also  
 [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)