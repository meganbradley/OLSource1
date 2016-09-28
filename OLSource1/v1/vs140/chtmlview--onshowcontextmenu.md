---
title: "CHtmlView::OnShowContextMenu"
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
  - "CHtmlView.OnShowContextMenu"
  - "CHtmlView::OnShowContextMenu"
  - "OnShowContextMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShowContextMenu method"
ms.assetid: 283c91c7-a094-46bc-97d8-2cb425724a91
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnShowContextMenu
Called from Internet Explorer or MSHTML when it is about to show its context menu.  
  
## Syntax  
  
```  
  
      virtual HRESULT OnShowContextMenu(  
   DWORD dwID,  
   LPPOINT ppt,  
   LPUNKNOWN pcmdtReserved,  
   LPDISPATCH pdispReserved   
);  
```  
  
#### Parameters  
 `dwID`  
 Identifier of the context menu to be displayed. See **IDocHostUIHandler::ShowContextMenu** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
 `ppt`  
 Screen coordinates for the menu.  
  
 `pcmdtReserved`  
 [IOleCommandTarget](http://msdn.microsoft.com/library/windows/desktop/ms683797) interface used to query command status and execute commands on this object.  
  
 `pdispReserved`  
 IDispatch interface of the object at the screen coordinates. This allows a host to differentiate particular objects to provide more specific context.  
  
## Return Value  
 See [IDocHostUIHandler::ShowContextMenu](https://msdn.microsoft.com/en-us/library/aa753264.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
## Remarks  
 Override `OnShowContextMenu` to react to the `ShowContextMenu` notification from the Microsoft Web Browser control. See [IDocHostUIHandler::ShowContextMenu](https://msdn.microsoft.com/en-us/library/aa753264.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::OnShowUI](../vs140/chtmlview--onshowui.md)   
 [CHtmlView::OnHideUI](../vs140/chtmlview--onhideui.md)   
 [CHtmlView::OnUpdateUI](../vs140/chtmlview--onupdateui.md)