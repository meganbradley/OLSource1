---
title: "CDockingManager::OnClosePopupMenu"
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
  - "CDockingManager::OnClosePopupMenu"
  - "OnClosePopupMenu"
  - "CDockingManager.OnClosePopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClosePopupMenu method"
ms.assetid: e49e8536-6fa4-438b-945c-753200ec7442
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::OnClosePopupMenu
Called by the framework when an active pop-up menu processes a WM_DESTROY message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The framework sends a WM_DESTROY message when it is about to close the current main window. Override this method to handle notifications from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects that belong to the frame window when a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object processes a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> message.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)