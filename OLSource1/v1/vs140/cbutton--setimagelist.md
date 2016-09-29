---
title: "CButton::SetImageList"
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
  - "CButton::SetImageList"
  - "CButton.SetImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetImageList method"
ms.assetid: f1ffa933-9d43-4787-98f7-6607fda01955
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetImageList
Call this method to set the image list of the `CButton` object.  
  
## Syntax  
  
```  
  
      BOOL SetImageList(  
   PBUTTON_IMAGELIST pbuttonImagelist  
);  
```  
  
#### Parameters  
 `pbuttonImagelist`  
 A pointer to the new image list.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 This member function emulates the functionality of the **BCM_SETIMAGELIST** message, as described in the [Buttons](http://msdn.microsoft.com/library/windows/desktop/bb775943) section of the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [CButton::GetImageList](../vs140/cbutton--getimagelist.md)