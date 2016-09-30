---
title: "CHtmlView::OnTranslateAccelerator"
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
  - "CHtmlView.OnTranslateAccelerator"
  - "CHtmlView::OnTranslateAccelerator"
  - "OnTranslateAccelerator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnTranslateAccelerator method"
ms.assetid: 216fe615-9c09-4f4b-9e38-e089aee1e3d8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnTranslateAccelerator
Called by Internet Explorer or MSHTML when [IOleInPlaceActiveObject::TranslateAccelerator](http://msdn.microsoft.com/library/windows/desktop/ms693360) or [IOleControlSite::TranslateAccelerator](http://msdn.microsoft.com/library/windows/desktop/ms693756) is called to process menu accelerator-key messages from the container's message queue.  
  
## Syntax  
  
```  
  
      virtual HRESULT OnTranslateAccelerator(  
   LPMSG lpMsg,  
   const GUID* pguidCmdGroup,  
   DWORD nCmdID   
);  
```  
  
#### Parameters  
 `lpMsg`  
 Points to the message that might need to be translated.  
  
 `pguidCmdGroup`  
 Command group identifier.  
  
 `nCmdID`  
 Command identifier.  
  
## Return Value  
 `S_OK` if successful, or **S_FALSE** otherwise.  
  
## Remarks  
 Override `OnTranslateAccelerator` to react to the `TranslateAccelerator` notification from the Microsoft Web Browser control. See [IDocHostUIHandler::TranslateAccelerator](https://msdn.microsoft.com/en-us/library/aa753266.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)