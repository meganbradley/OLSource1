---
title: "CReBarCtrl::SetImageList"
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
  - "CReBarCtrl.SetImageList"
  - "CReBarCtrl::SetImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetImageList method"
  - "CReBarCtrl class, attributes"
ms.assetid: fee0dd86-157d-4fe0-8a29-28c91be5e0d0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::SetImageList
Assigns an image list to a rebar control.  
  
## Syntax  
  
```  
  
      BOOL SetImageList(  
   CImageList* pImageList   
);  
```  
  
#### Parameters  
 `pImageList`  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object containing the image list to be assigned to the rebar control.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::GetImageList](../vs140/crebarctrl--getimagelist.md)