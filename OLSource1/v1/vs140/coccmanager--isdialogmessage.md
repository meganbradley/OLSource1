---
title: "COccManager::IsDialogMessage"
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
  - "COccManager::IsDialogMessage"
  - "COccManager.IsDialogMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COccManager class, operations"
  - "IsDialogMessage method"
ms.assetid: 12d1f4c4-685c-4d2a-bcfe-0eb36c20f34e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COccManager::IsDialogMessage
Called by the framework to determine whether a message is intended for the specified dialog box and, if it is, processes the message.  
  
## Syntax  
  
```  
  
      virtual BOOL IsDialogMessage(  
   CWnd* pWndDlg,  
   LPMSG lpMsg  
);  
```  
  
#### Parameters  
 *pWndDlg*  
 A pointer to the intended target dialog of the message.  
  
 `lpMsg`  
 A pointer to an `MSG` structure that contains the message to be checked.  
  
## Return Value  
 Nonzero if the message is processed; otherwise zero.  
  
## Remarks  
 The default behavior of `IsDialogMessage` is to check for keyboard messages and convert them into selections for the corresponding dialog box. For example, the TAB key, when pressed, selects the next control or group of controls.  
  
 Override this function to provide custom behavior for messages sent to the specified dialog.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COccManager Class](../vs140/coccmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)