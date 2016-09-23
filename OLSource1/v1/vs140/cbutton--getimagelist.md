---
title: "CButton::GetImageList"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CButton::GetImageList
  - CButton.GetImageList
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetImageList method
ms.assetid: d308ad8c-dadb-467c-ae85-c23c547c1728
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CButton::GetImageList
Call this method to get the image list from the button control.  
  
## Syntax  
  
```  
  
      BOOL GetImageList(  
   PBUTTON_IMAGELIST pbuttonImagelist   
);  
```  
  
#### Parameters  
 `pbuttonImagelist`  
 A pointer to the image list of the `CButton` object.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function emulates the functionality of the **BCM_GETIMAGELIST** message, as described in the [Buttons](http://msdn.microsoft.com/library/windows/desktop/bb775943) section of the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)