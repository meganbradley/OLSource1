---
title: "CMFCToolBarImages::Load"
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
  - "Load"
  - "CMFCToolBarImages::Load"
  - "CMFCToolBarImages.Load"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Load method"
ms.assetid: e2a51953-d6da-4aeb-a2a8-0d2c704ccdc6
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::Load
Loads toolbar images from system resources or from a file.  
  
## Syntax  
  
```  
BOOL Load(  
   UINT uiResID,  
   HINSTANCE hinstRes=NULL,  
   BOOL bAdd=FALSE   
);  
BOOL Load(  
   LPCTSTR lpszBmpFileName,   
   DWORD nMaxFileSize = 819200  
);  
```  
  
#### Parameters  
 [in] `uiResID`  
 The ID of a bitmap resource.  
  
 [in] `hinstRes`  
 An instance of the resource DLL.  
  
 [in] `bAdd`  
 `TRUE` to add the loaded bitmap to the existing bitmap, or `FALSE` to replace the existing bitmap.  
  
 [in] `lpszBmpFileName`  
 A path to a disk file from which to load the bitmap.  
  
 [in] `nMaxFileSize`  
 Maximum number of bytes in the bitmap file; or 0 to load the bitmap regardless of file size. If the size of the file exceeds this maximum size, the method returns `FALSE` and does not load the bitmap.  
  
## Return Value  
 `TRUE` if the bitmap was loaded successfully; otherwise `FALSE`.  
  
## Remarks  
 If the file has the read-only attribute, the image list is marked as read-only.  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)