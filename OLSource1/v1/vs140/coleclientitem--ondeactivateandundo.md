---
title: "COleClientItem::OnDeactivateAndUndo"
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
  - "OnDeactivateAndUndo"
  - "COleClientItem::OnDeactivateAndUndo"
  - "COleClientItem.OnDeactivateAndUndo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDeactivateAndUndo method"
  - "COleClientItem class, overridables"
ms.assetid: 5063d392-9211-492e-ac1e-1b8a525bdd45
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnDeactivateAndUndo
Called by the framework when the user invokes the undo command after activating the OLE item in place.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The default implementation calls [DeactivateUI](../vs140/coleclientitem--deactivateui.md) to deactivate the server's user interface. Override this function if you are implementing the undo command in your container application. In your override, call the base class version of the function and then undo the last command executed in your application.  
  
 For more information, see [IOleInPlaceSite::DeactivateAndUndo](http://msdn.microsoft.com/library/windows/desktop/ms683743) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::DeactivateUI](../vs140/coleclientitem--deactivateui.md)