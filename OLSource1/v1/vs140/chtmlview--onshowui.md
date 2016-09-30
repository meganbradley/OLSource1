---
title: "CHtmlView::OnShowUI"
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
  - "CHtmlView.OnShowUI"
  - "OnShowUI"
  - "CHtmlView::OnShowUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShowUI method"
ms.assetid: 2b45aaeb-7dc4-4c5c-bf6b-e7d07a7e6555
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnShowUI
Called before Internet Explorer or MSHTML displays its menus and toolbars.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Reserved for future use.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [IOleInPlaceActiveObject](http://msdn.microsoft.com/library/windows/desktop/ms691299) interface of the currently active object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [IOleCommandTarget](http://msdn.microsoft.com/library/windows/desktop/ms683797) interface of the object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [IOleInPlaceFrame](http://msdn.microsoft.com/library/windows/desktop/ms692770) interface of the object. This is needed for menus and toolbars.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [IOleInPlaceUIWindow](http://msdn.microsoft.com/library/windows/desktop/ms680716) interface for the object. This is needed for toolbars.  
  
## Return Value  
 See [IDocHostUIHandler::ShowUI](https://msdn.microsoft.com/en-us/library/aa753265.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
## Remarks  
 Override <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See [IDocHostUIHandler::ShowUI](https://msdn.microsoft.com/en-us/library/aa753265.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::OnUpdateUI](../vs140/chtmlview--onupdateui.md)   
 [CHtmlView::OnHideUI](../vs140/chtmlview--onhideui.md)   
 [CHtmlView::OnShowContextMenu](../vs140/chtmlview--onshowcontextmenu.md)