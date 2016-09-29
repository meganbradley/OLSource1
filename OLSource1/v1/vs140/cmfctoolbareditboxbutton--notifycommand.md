---
title: "CMFCToolBarEditBoxButton::NotifyCommand"
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
  - "CMFCToolBarEditBoxButton::NotifyCommand"
  - "CMFCToolBarEditBoxButton.NotifyCommand"
  - "NotifyCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NotifyCommand method"
ms.assetid: 12f96002-7311-4a2f-878a-c7fcc580fbe8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::NotifyCommand
Specifies whether the button processes the [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message.  
  
## Syntax  
  
```  
virtual BOOL NotifyCommand(  
   int iNotifyCode  
);  
```  
  
#### Parameters  
 [in] `iNotifyCode`  
 The notification message that is associated with the command.  
  
## Return Value  
 `TRUE` if the button processes the `WM_COMMAND` message, or `FALSE` to indicate that the message must be handled by the parent toolbar.  
  
## Remarks  
 The framework calls this method when it is about to send a [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message to the parent window.  
  
 This method extends the base class implementation ([CMFCToolBarButton::NotifyCommand](../vs140/cmfctoolbarbutton--notifycommand.md)) by processing the [EN_UPDATE](http://msdn.microsoft.com/library/windows/desktop/bb761687) notification. For each edit box with the same command ID as this object, it sets its text label to the text label of this object.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::NotifyCommand](../vs140/cmfctoolbarbutton--notifycommand.md)   
 [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591)   
 [EN_UPDATE](http://msdn.microsoft.com/library/windows/desktop/bb761687)