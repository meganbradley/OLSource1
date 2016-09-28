---
title: "CDHtmlDialog::ShowContextMenu"
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
  - "CDHtmlDialog::ShowContextMenu"
  - "CDHtmlDialog.ShowContextMenu"
  - "ShowContextMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowContextMenu method"
ms.assetid: 11c8647a-9f89-4764-8afd-112657e578af
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::ShowContextMenu
Called when a context menu is about to be displayed.  
  
## Syntax  
  
```  
  
      STDMETHOD(ShowContextMenu)(  
   DWORD dwID,  
   POINT * ppt,  
   IUnknown * pcmdtReserved,  
   IDispatch * pdispReserved   
);  
```  
  
#### Parameters  
 `dwID`  
 See `dwID` in [IDocHostUIHandler::ShowContextMenu](https://msdn.microsoft.com/en-us/library/aa753264.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `ppt`  
 See `ppt` in **IDocHostUIHandler::ShowContextMenu** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pcmdtReserved`  
 See `pcmdtReserved` in **IDocHostUIHandler::ShowContextMenu** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pdispReserved`  
 See `pdispReserved` in **IDocHostUIHandler::ShowContextMenu** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns **S_FALSE**.  
  
## Remarks  
 This member function is CDHtmlDialog's implementation of [IDocHostUIHandler::ShowContextMenu](https://msdn.microsoft.com/en-us/library/aa753264.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IDocHostUIhandler Interface](https://msdn.microsoft.com/en-us/library/aa753260.aspx)