---
title: "CDHtmlDialog::TranslateAccelerator"
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
  - "TranslateAccelerator"
  - "CDHtmlDialog::TranslateAccelerator"
  - "CDHtmlDialog.TranslateAccelerator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TranslateAccelerator method"
ms.assetid: bc516a9d-c6e6-4c2a-9332-e19bdc9c4a0f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::TranslateAccelerator
Called to process menu accelerator-key messages.  
  
## Syntax  
  
```  
  
      STDMETHOD(TranslateAccelerator)(  
   LPMSG lpMsg,  
   const GUID * pguidCmdGroup,  
   DWORD nCmdID   
);  
```  
  
#### Parameters  
 `lpMsg`  
 See `lpMsg` in [IDocHostUIHandler::TranslateAccelerator](https://msdn.microsoft.com/en-us/library/aa753266.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pguidCmdGroup`  
 See `pguidCmdGroup` in **IDocHostUIHandler::TranslateAccelerator** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `nCmdID`  
 See `nCmdID` in **IDocHostUIHandler::TranslateAccelerator** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns **S_FALSE**.  
  
## Remarks  
 This member function is CDHtmlDialog's implementation of [IDocHostUIHandler::TranslateAccelerator](https://msdn.microsoft.com/en-us/library/aa753266.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IDocHostUIhandler Interface](https://msdn.microsoft.com/en-us/library/aa753260.aspx)