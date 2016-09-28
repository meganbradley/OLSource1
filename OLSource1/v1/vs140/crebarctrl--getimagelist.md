---
title: "CReBarCtrl::GetImageList"
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
  - "CReBarCtrl::GetImageList"
  - "CReBarCtrl.GetImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, attributes"
  - "GetImageList method"
ms.assetid: 78bf95e3-03f2-4865-bd38-df9a33c70018
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::GetImageList
Gets the `CImageList` object associated with a rebar control.  
  
## Syntax  
  
```  
  
CImageList* GetImageList( ) const;  
  
```  
  
## Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object. Returns **NULL** if no image list is set for the control.  
  
## Remarks  
 This member function uses size and mask information stored in the [REBARINFO](http://msdn.microsoft.com/library/windows/desktop/bb774395) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::SetImageList](../vs140/crebarctrl--setimagelist.md)