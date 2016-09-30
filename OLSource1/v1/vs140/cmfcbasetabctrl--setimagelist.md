---
title: "CMFCBaseTabCtrl::SetImageList"
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
  - "CMFCBaseTabCtrl::SetImageList"
  - "SetImageList"
  - "CMFCBaseTabCtrl.SetImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetImageList method"
ms.assetid: a6f5bb77-e2d2-4a4a-9d15-6dc3058c02fe
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::SetImageList
Sets the icon image list for the tab control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A bitmap resource ID. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> loads the image list from this resource.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The width of each image in pixels.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the transparent color of the image.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A handle to a preloaded image list.  
  
## Return Value  
 Nonzero if the method was successful; 0 otherwise.  
  
## Remarks  
 The images from the icon image list are displayed alongside the labels for the tab. To display an icon, you must specify its index when you call [CMFCBaseTabCtrl::AddTab](../vs140/cmfcbasetabctrl--addtab.md).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will fail if the tab control was created with a flat style. It will also fail if the framework cannot load the image indicated by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 This method recalculates the height of the tab according to the image and text sizes.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)