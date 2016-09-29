---
title: "CHtmlView::OnHideUI"
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
  - "CHtmlView::OnHideUI"
  - "CHtmlView.OnHideUI"
  - "OnHideUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHideUI method"
ms.assetid: a0a407d1-2df9-47d0-9c94-e6129d9aa893
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnHideUI
This member function is called by the framework when Internet Explorer or MSHTML removes its menus and toolbars.  
  
## Syntax  
  
```  
  
virtual HRESULT OnHideUI( );  
  
```  
  
## Return Value  
 `S_OK` if successful, or an OLE-defined error code otherwise.  
  
## Remarks  
 Override `OnHideUI` to react to the `HideUI` notification from the Microsoft Web Browser control. See [IDocHostUIHandler::HideUI](https://msdn.microsoft.com/en-us/library/aa753259.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::OnUpdateUI](../vs140/chtmlview--onupdateui.md)   
 [CHtmlView::OnShowUI](../vs140/chtmlview--onshowui.md)   
 [CHtmlView::OnShowContextMenu](../vs140/chtmlview--onshowcontextmenu.md)