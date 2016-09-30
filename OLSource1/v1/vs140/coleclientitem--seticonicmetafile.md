---
title: "COleClientItem::SetIconicMetafile"
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
  - "SetIconicMetafile"
  - "COleClientItem::SetIconicMetafile"
  - "COleClientItem.SetIconicMetafile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, status"
  - "SetIconicMetafile method"
ms.assetid: 1ea01dac-07eb-48f6-a6b8-985299d18d11
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::SetIconicMetafile
Caches the metafile used for drawing the item's icon.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A handle to the metafile used for drawing the item's icon.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Use [GetIconicMetafile](../vs140/coleclientitem--geticonicmetafile.md) to retrieve the metafile.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter is copied into the item; therefore, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> must be freed by the caller.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::GetIconicMetafile](../vs140/coleclientitem--geticonicmetafile.md)