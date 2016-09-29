---
title: "CDHtmlDialog::OnFrameWindowActivate"
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
  - "CDHtmlDialog::OnFrameWindowActivate"
  - "CDHtmlDialog.OnFrameWindowActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFrameWindowActivate method method"
ms.assetid: 5307e1f3-59dd-4b61-ab07-d08382eb2a5d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::OnFrameWindowActivate
Called by the framework when the frame window is activated or deactivated.  
  
## Syntax  
  
```  
  
      STDMETHOD(OnFrameWindowActivate)(  
   BOOL fActivate   
);  
```  
  
#### Parameters  
 `fActivate`  
 See `fActivate` in [IDocHostUIHandler::OnFrameWindowActivate](https://msdn.microsoft.com/en-us/library/aa753262.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 This member function is CDHtmlDialog's implementation of [IDocHostUIHandler::OnFrameWindowActivate](https://msdn.microsoft.com/en-us/library/aa753262.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IDocHostUIhandler Interface](https://msdn.microsoft.com/en-us/library/aa753260.aspx)