---
title: "CHtmlView::OnEnableModeless"
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
  - "CHtmlView.OnEnableModeless"
  - "OnEnableModeless"
  - "CHtmlView::OnEnableModeless"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEnableModeless method"
ms.assetid: 552e1b75-48a5-420e-9066-2f5b7280bac1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnEnableModeless
Called when Internet Explorer or MSHTML displays modal UI.  
  
## Syntax  
  
```  
  
      virtual HRESULT OnEnableModeless(  
   BOOL fEnable   
);  
```  
  
#### Parameters  
 `fEnable`  
 Indicates if the host's modeless dialog boxes are enabled or disabled. If this value is nonzero, modeless dialog boxes are enabled. If this value is zero, modeless dialog boxes are disabled.  
  
## Return Value  
 `S_OK` if successful, or an OLE-defined error code otherwise.  
  
## Remarks  
 Enables or disables modeless dialog boxes when the container creates or destroys a modal dialog box. Override `OnEnableModeless` to react to the `EnableModeless` notification from the Microsoft Web Browser control. See [IDocHostUIHandler::EnableModeless](https://msdn.microsoft.com/en-us/library/aa753253.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IOleInPlaceActiveObject::EnableModeless](http://msdn.microsoft.com/library/windows/desktop/ms680115)