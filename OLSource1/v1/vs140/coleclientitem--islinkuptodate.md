---
title: "COleClientItem::IsLinkUpToDate"
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
  - "COleClientItem::IsLinkUpToDate"
  - "IsLinkUpToDate"
  - "COleClientItem.IsLinkUpToDate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsLinkUpToDate method"
  - "COleClientItem class, linked object operations and status"
ms.assetid: 4db8de44-316b-416a-a5b7-42444dd36a37
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::IsLinkUpToDate
Call this function to see whether the OLE item is up to date.  
  
## Syntax  
  
```  
  
BOOL IsLinkUpToDate( ) const;  
```  
  
## Return Value  
 Nonzero if the OLE item is up to date; otherwise 0.  
  
## Remarks  
 A linked item can be out of date if its source document has been updated. An embedded item that contains links within it can similarly become out of date. The function does a recursive check of the OLE item. Note that determining whether an OLE item is out of date can be as expensive as actually performing an update.  
  
 This is called automatically by the [COleLinksDialog](../vs140/colelinksdialog-class.md) implementation.  
  
 For more information, see [IOleObject::IsUpToDate](http://msdn.microsoft.com/library/windows/desktop/ms686624) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)