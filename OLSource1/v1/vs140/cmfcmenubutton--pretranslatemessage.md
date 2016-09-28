---
title: "CMFCMenuButton::PreTranslateMessage"
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
  - "PreTranslateMessage"
  - "CMFCMenuButton::PreTranslateMessage"
  - "CMFCMenuButton.PreTranslateMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PreTranslateMessage method"
ms.assetid: c7eca654-67c7-458f-afa7-a6217fdaaf70
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuButton::PreTranslateMessage
Called by the framework to translate window messages before they are dispatched.  
  
## Syntax  
  
```  
virtual BOOL PreTranslateMessage(  
   MSG* pMsg  
);  
```  
  
#### Parameters  
 [in] `pMsg`  
 Points to a [MSG](../vs140/msg-structure.md) structure that contains the message to process.  
  
## Return Value  
 Nonzero if the message was translated and should not be dispatched; 0 if the message was not translated and should be dispatched.  
  
## Remarks  
  
## Requirements  
 **Header:** afxmenubutton.h  
  
## See Also  
 [CMFCMenuButton Class](../vs140/cmfcmenubutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)