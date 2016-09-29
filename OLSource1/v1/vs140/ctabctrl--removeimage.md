---
title: "CTabCtrl::RemoveImage"
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
  - "RemoveImage"
  - "CTabCtrl.RemoveImage"
  - "CTabCtrl::RemoveImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveImage method"
ms.assetid: ff4f199b-2213-4bf8-ad98-b703d9f5284f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::RemoveImage
Removes the specified image from a tab control's image list.  
  
## Syntax  
  
```  
  
      void RemoveImage(  
  int nImage   
);  
```  
  
#### Parameters  
 `nImage`  
 Zero-based index of the image to remove.  
  
## Remarks  
 The tab control updates each tab's image index so that each tab remains associated with the same image.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::GetImageList](../vs140/ctabctrl--getimagelist.md)   
 [CTabCtrl::SetImageList](../vs140/ctabctrl--setimagelist.md)