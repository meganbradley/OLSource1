---
title: "COleClientItem::IsRunning"
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
  - "COleClientItem::IsRunning"
  - "COleClientItem.IsRunning"
  - "IsRunning"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsRunning method"
  - "COleClientItem class, status"
ms.assetid: 802fe2af-50ee-4b77-86f1-e9e76c70c88c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::IsRunning
Call this function to see whether the OLE item is running; that is, whether the item is loaded and running in the server application.  
  
## Syntax  
  
```  
  
BOOL IsRunning( ) const;  
```  
  
## Return Value  
 Nonzero if the OLE item is running; otherwise 0.  
  
## Remarks  
 For more information, see [OleIsRunning](http://msdn.microsoft.com/library/windows/desktop/ms688705) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)