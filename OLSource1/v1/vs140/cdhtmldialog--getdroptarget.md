---
title: "CDHtmlDialog::GetDropTarget"
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
  - "GetDropTarget"
  - "CDHtmlDialog::GetDropTarget"
  - "CDHtmlDialog.GetDropTarget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDropTarget method"
ms.assetid: 3da28f53-9cac-43de-8c35-b91d85dadc9a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::GetDropTarget
Called by the contained WebBrowser control when it is being used as a drop target to allow the dialog to supply an alternative [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679).  
  
## Syntax  
  
```  
  
      STDMETHOD(GetDropTarget)(  
   IDropTarget *pDropTarget,  
   IDropTarget **ppDropTarget  
);  
```  
  
#### Parameters  
 `pDropTarget`  
 See `pDropTarget` in [IDocHostUIHandler::GetDropTarget](https://msdn.microsoft.com/en-us/library/aa753255.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `ppDropTarget`  
 See `ppDropTarget` in **IDocHostUIHandler::GetDropTarget** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 This member function is CDHtmlDialog's implementation of [IDocHostUIHandler::GetDropTarget](https://msdn.microsoft.com/en-us/library/aa753255.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IDocHostUIhandler Interface](https://msdn.microsoft.com/en-us/library/aa753260.aspx)