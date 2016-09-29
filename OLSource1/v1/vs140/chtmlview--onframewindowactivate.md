---
title: "CHtmlView::OnFrameWindowActivate"
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
  - "OnFrameWindowActivate"
  - "CHtmlView::OnFrameWindowActivate"
  - "CHtmlView.OnFrameWindowActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFrameWindowActivate method"
ms.assetid: a9b2e480-45d3-496c-8d01-56f4bd9ccd9c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnFrameWindowActivate
Called from [IOleInPlaceActiveObject::OnFrameWindowActivate](http://msdn.microsoft.com/library/windows/desktop/ms683969) to notify the object when the container's top-level frame window is activated or deactivated.  
  
## Syntax  
  
```  
  
      virtual HRESULT OnFrameWindowActivate(  
   BOOL fActivate   
);  
```  
  
#### Parameters  
 `fActivate`  
 Indicates the state of the container's top-level frame window. If this value is nonzero, the window is being activated. If this value is zero, the window is being deactivated.  
  
## Return Value  
 `S_OK` if successful, or an OLE-defined error code otherwise.  
  
## Remarks  
 Override `OnFrameWindowActivate` to react to the `OnFrameWindowActivate` notification from the Microsoft Web Browser control. See [IDocHostUIHandler::OnFrameWindowActivate](https://msdn.microsoft.com/en-us/library/aa753262.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)