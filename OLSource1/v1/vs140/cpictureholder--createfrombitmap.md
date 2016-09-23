---
title: "CPictureHolder::CreateFromBitmap"
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
  - CPictureHolder.CreateFromBitmap
  - CreateFromBitmap
  - CPictureHolder::CreateFromBitmap
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateFromBitmap method
ms.assetid: 4fff2c07-0b47-41a9-8f1a-55e869c45fec
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPictureHolder::CreateFromBitmap
Uses a bitmap to initialize the picture object in a `CPictureHolder`.  
  
## Syntax  
  
```  
  
      BOOL CreateFromBitmap(  
   UINT idResource   
);  
BOOL CreateFromBitmap(  
   CBitmap* pBitmap,  
   CPalette* pPal = NULL,  
   BOOL bTransferOwnership = TRUE   
);  
BOOL CreateFromBitmap(   
   HBITMAP hbm,   
   HPALETTE hpal = NULL,   
   BOOL bTransferOwnership = FALSE    
);  
```  
  
#### Parameters  
 `idResource`  
 Resource ID of a bitmap resource.  
  
 `pBitmap`  
 Pointer to a [CBitmap](../vs140/cbitmap-class.md) object.  
  
 *pPal*  
 Pointer to a [CPalette](../vs140/cpalette-class.md) object.  
  
 `bTransferOwnership`  
 Indicates whether the picture object will take ownership of the bitmap and palette objects.  
  
 `hbm`  
 Handle to the bitmap from which the `CPictureHolder` object is created.  
  
 `hpal`  
 Handle to the palette used for rendering the bitmap.  
  
## Return Value  
 Nonzero if the object is successfully created; otherwise 0.  
  
## Remarks  
 If `bTransferOwnership` is **TRUE**, the caller should not use the bitmap or palette object in any way after this call returns. If `bTransferOwnership` is **FALSE**, the caller is responsible for ensuring that the bitmap and palette objects remain valid for the lifetime of the picture object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPictureHolder Class](../vs140/cpictureholder-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPictureHolder::CreateEmpty](../vs140/cpictureholder--createempty.md)   
 [CPictureHolder::CreateFromIcon](../vs140/cpictureholder--createfromicon.md)   
 [CPictureHolder::CreateFromMetafile](../vs140/cpictureholder--createfrommetafile.md)