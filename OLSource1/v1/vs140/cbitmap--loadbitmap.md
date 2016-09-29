---
title: "CBitmap::LoadBitmap"
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
  - "CBitmap.LoadBitmap"
  - "CBitmap::LoadBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadBitmap method"
ms.assetid: 455194ed-cbb4-4054-a753-dbf3ae6b7aa5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBitmap::LoadBitmap
Loads the bitmap resource named by `lpszResourceName` or identified by the ID number in `nIDResource` from the application's executable file.  
  
## Syntax  
  
```  
  
      BOOL LoadBitmap(  
   LPCTSTR lpszResourceName   
);  
BOOL LoadBitmap(  
   UINT nIDResource   
);  
```  
  
#### Parameters  
 `lpszResourceName`  
 Points to a null-terminated string that contains the name of the bitmap resource.  
  
 `nIDResource`  
 Specifies the resource ID number of the bitmap resource.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The loaded bitmap is attached to the `CBitmap` object.  
  
 If the bitmap identified by `lpszResourceName` does not exist or if there is insufficient memory to load the bitmap, the function returns 0.  
  
 You can use the [CGdiObject::DeleteObject](../vs140/cgdiobject--deleteobject.md) function to delete bitmap loaded by the `LoadBitmap` function, or the `CBitmap` destructor will delete the object for you.  
  
> [!CAUTION]
>  Before you delete the object, make sure it is not selected into a device context.  
  
 The following bitmaps were added to Windows versions 3.1 and later:  
  
 **OBM_UPARRROWIOBM_DNARROWIOBM_RGARROWIOBM_LFARROWI**  
  
 These bitmaps are not found in device drivers for Windows versions 3.0 and earlier. For a complete list of bitmaps and a display of their appearance, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBitmap::LoadOEMBitmap](../vs140/cbitmap--loadoembitmap.md)   
 [LoadBitmap](http://msdn.microsoft.com/library/windows/desktop/dd145033)   
 [CGdiObject::DeleteObject](../vs140/cgdiobject--deleteobject.md)