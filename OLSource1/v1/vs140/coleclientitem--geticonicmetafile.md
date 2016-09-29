---
title: "COleClientItem::GetIconicMetafile"
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
  - "COleClientItem::GetIconicMetafile"
  - "GetIconicMetafile"
  - "COleClientItem.GetIconicMetafile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, status"
  - "GetIconicMetafile method"
ms.assetid: f18a4b3c-8c45-42d6-abd3-ca43a2cebf19
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::GetIconicMetafile
Retrieves the metafile used for drawing the item's icon.  
  
## Syntax  
  
```  
  
HGLOBAL GetIconicMetafile( );  
```  
  
## Return Value  
 A handle to the metafile if successful; otherwise **NULL**.  
  
## Remarks  
 If there is no current icon, a default icon is returned. This is called automatically by the MFC/OLE dialogs and is usually not called directly.  
  
 This function also calls [SetIconicMetafile](../vs140/coleclientitem--seticonicmetafile.md) to cache the metafile for later use.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::SetIconicMetafile](../vs140/coleclientitem--seticonicmetafile.md)