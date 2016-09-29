---
title: "CDocument::OnPreviewHandlerTranslateAccelerator"
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
  - "OnPreviewHandlerTranslateAccelerator"
  - "afxwin/CDocument::OnPreviewHandlerTranslateAccelerator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPreviewHandlerTranslateAccelerator"
ms.assetid: bed37e23-70e9-4a30-8c19-41715d93766d
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::OnPreviewHandlerTranslateAccelerator
Directs the preview handler to handle a keystroke passed up from the message pump of the process in which the preview handler is running.  
  
## Syntax  
  
```  
virtual HRESULT OnPreviewHandlerTranslateAccelerator(  
   MSG* pmsg  
);  
```  
  
#### Parameters  
 `pmsg`  
 [in] A pointer to a window message.  
  
## Return Value  
 If the keystroke message can be processed by the preview handler, the handler processes it and returns S_OK. If the preview handler cannot process the keystroke message, it offers it to the host via `IPreviewHandlerFrame::TranslateAccelerator`. If the host processes the message, this method returns S_OK. If the host does not process the message, this method returns S_FALSE.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)