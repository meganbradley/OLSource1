---
title: "CHtmlView::OnResizeBorder"
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
  - "OnResizeBorder"
  - "CHtmlView::OnResizeBorder"
  - "CHtmlView.OnResizeBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnResizeBorder method"
ms.assetid: 6c631011-0136-4102-a36d-7b80f46b6d7e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnResizeBorder
Called from the Internet Explorer or MSHTML implementation of [IOleInPlaceActiveObject::ResizeBorder](http://msdn.microsoft.com/library/windows/desktop/ms680053), which alerts the object that it needs to resize its border space.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 New outer rectangle for border space.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the interface for the frame or document window object whose border has changed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **TRUE** if the frame window is calling [IOleInPlaceActiveObject::ResizeBorder](http://msdn.microsoft.com/library/windows/desktop/ms680053), otherwise **FALSE**.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if successful, or an OLE-defined error code otherwise.  
  
## Remarks  
 Override <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See [IDocHostUIHandler::ResizeBorder](https://msdn.microsoft.com/en-us/library/aa753263.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)