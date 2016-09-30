---
title: "COleServerItem::OnOpen"
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
  - "COleServerItem::OnOpen"
  - "OnOpen"
  - "COleServerItem.OnOpen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnOpen method"
  - "COleServerItem class, overridables"
ms.assetid: 589ed825-1536-4c9e-a55c-5ec2ba740e29
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnOpen
Called by the framework to display the OLE item in a separate instance of the server application, rather than in place.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The default implementation activates the first frame window displaying the document that contains the OLE item; if the application is a mini-server, the default implementation shows the main window. The function also notifies the container that the OLE item has been opened.  
  
 Override this function if you want to perform special processing when opening an OLE item. This is especially common with linked items where you want to set the selection to the link when it is opened.  
  
 For more information, see [IOleClientSite::OnShowWindow](http://msdn.microsoft.com/library/windows/desktop/ms688658) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::OnShow](../vs140/coleserveritem--onshow.md)