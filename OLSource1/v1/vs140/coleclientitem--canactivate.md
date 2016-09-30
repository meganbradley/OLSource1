---
title: "COleClientItem::CanActivate"
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
  - "COleClientItem.CanActivate"
  - "CanActivate"
  - "COleClientItem::CanActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanActivate method"
  - "COleClientItem class, overridables"
ms.assetid: 10dcf905-7df2-49b1-b41c-9d1a3eba90b1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::CanActivate
Called by the framework when the user requests in-place activation of the OLE item; this function's return value determines whether in-place activation is allowed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if in-place activation is allowed; otherwise 0.  
  
## Remarks  
 The default implementation allows in-place activation if the container has a valid window. Override this function to implement special logic for accepting or refusing the activation request. For example, an activation request can be refused if the OLE item is too small or not currently visible.  
  
 For more information, see [IOleInPlaceSite::CanInPlaceActivate](http://msdn.microsoft.com/library/windows/desktop/ms691236) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)