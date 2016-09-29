---
title: "CMFCRibbonGallery::SetGroupName"
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
  - "CMFCRibbonGallery.SetGroupName"
  - "SetGroupName"
  - "CMFCRibbonGallery::SetGroupName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetGroupName method"
ms.assetid: 714ddef7-aaab-4f76-a6a6-effc76350a39
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonGallery::SetGroupName
Sets the name of a group.  
  
## Syntax  
  
```  
void SetGroupName(  
    int nGroupIndex,  
    LPCTSTR lpszGroupName   
);  
```  
  
#### Parameters  
 [in] `nGroupIndex`  
 Specifies the zero-based index for the group for which the name is being changed.  
  
 [in] `lpszGroupName`  
 Specifies the new name for the group.  
  
## Remarks  
 The group whose name is being changed must have been added using the [CMFCRibbonGallery::AddGroup](../vs140/cmfcribbongallery--addgroup.md) method.  
  
## Requirements  
 **Header:** afxRibbonPaletteGallery.h  
  
## See Also  
 [CMFCRibbonGallery Class](../vs140/cmfcribbongallery-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)