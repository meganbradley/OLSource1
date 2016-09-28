---
title: "CHeaderCtrl::SetBitmapMargin"
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
  - "CHeaderCtrl::SetBitmapMargin"
  - "SetBitmapMargin"
  - "CHeaderCtrl.SetBitmapMargin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBitmapMargin method"
ms.assetid: 968f89fa-20f7-4f99-8219-e28de95629ee
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::SetBitmapMargin
Sets the width of the margin of a bitmap in a header control.  
  
## Syntax  
  
```  
  
      int SetBitmapMargin(  
   int nWidth   
);  
```  
  
#### Parameters  
 `nWidth`  
 Width, specified in pixels, of the margin that surrounds a bitmap within an existing header control.  
  
## Return Value  
 The width of the bitmap margin in pixels.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [HDM_SETBITMAPMARGIN](http://msdn.microsoft.com/library/windows/desktop/bb775357), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#14](../vs140/codesnippet/CPP/cheaderctrl--setbitmapmargin_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::GetBitmapMargin](../vs140/cheaderctrl--getbitmapmargin.md)