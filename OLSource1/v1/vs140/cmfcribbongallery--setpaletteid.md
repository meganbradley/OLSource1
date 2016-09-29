---
title: "CMFCRibbonGallery::SetPaletteID"
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
  - "SetPaletteID"
  - "CMFCRibbonGallery.SetPaletteID"
  - "CMFCRibbonGallery::SetPaletteID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPaletteID method"
ms.assetid: 5fd67065-2a05-4b41-9e7f-e7c44c91b460
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonGallery::SetPaletteID
Defines the command ID that is sent in the **WM_COMMAND** message when a user selects a gallery item.  
  
## Syntax  
  
```  
void SetPaletteID(  
    UINT nID   
);  
```  
  
#### Parameters  
 [in] `nID`  
 Specifies the command ID that is sent in the **WM_COMMAND** message when a user selects a gallery item.  
  
## Remarks  
 To determine the specific item that a user selected from the gallery, call the [CMFCRibbonGallery::GetLastSelectedItem](../vs140/cmfcribbongallery--getlastselecteditem.md) static method.  
  
## Requirements  
 **Header:** afxRibbonPaletteGallery.h  
  
## See Also  
 [CMFCRibbonGallery Class](../vs140/cmfcribbongallery-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)