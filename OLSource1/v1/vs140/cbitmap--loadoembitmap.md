---
title: "CBitmap::LoadOEMBitmap"
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
  - "CBitmap.LoadOEMBitmap"
  - "LoadOEMBitmap"
  - "CBitmap::LoadOEMBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadOEMBitmap method"
ms.assetid: f7770ae5-4fce-464a-b676-a6e94fd222b0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBitmap::LoadOEMBitmap
Loads a predefined bitmap used by Windows.  
  
## Syntax  
  
```  
  
      BOOL LoadOEMBitmap(  
   UINT nIDBitmap   
);  
```  
  
#### Parameters  
 `nIDBitmap`  
 ID number of the predefined Windows bitmap. The possible values are listed below from WINDOWS.H:  
  
|||  
|-|-|  
|**OBM_BTNCORNERS**|**OBM_OLD_RESTORE**|  
|**OBM_BTSIZE**|**OBM_OLD_RGARROW**|  
|**OBM_CHECK**|**OBM_OLD_UPARROW**|  
|**OBM_CHECKBOXES**|**OBM_OLD_ZOOM**|  
|**OBM_CLOSE**|**OBM_REDUCE**|  
|**OBM_COMBO**|**OBM_REDUCED**|  
|**OBM_DNARROW**|**OBM_RESTORE**|  
|**OBM_DNARROWD**|**OBM_RESTORED**|  
|**OBM_DNARROWI**|**OBM_RGARROW**|  
|**OBM_LFARROW**|**OBM_RGARROWD**|  
|**OBM_LFARROWD**|**OBM_RGARROWI**|  
|**OBM_LFARROWI**|**OBM_SIZE**|  
|**OBM_MNARROW**|**OBM_UPARROW**|  
|**OBM_OLD_CLOSE**|**OBM_UPARROWD**|  
|**OBM_OLD_DNARROW**|**OBM_UPARROW**|  
|**OBM_OLD_LFARROW**|**OBM_ZOOM**|  
|**OBM_OLD_REDUCE**|**OBM_ZOOMD**|  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Bitmap names that begin with **OBM_OLD** represent bitmaps used by Windows versions prior to 3.0.  
  
 Note that the constant **OEMRESOURCE** must be defined before including WINDOWS.H in order to use any of the **OBM_** constants.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBitmap::LoadBitmap](../vs140/cbitmap--loadbitmap.md)   
 [LoadBitmap](http://msdn.microsoft.com/library/windows/desktop/dd145033)