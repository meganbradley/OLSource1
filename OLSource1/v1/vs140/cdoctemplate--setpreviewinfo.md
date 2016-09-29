---
title: "CDocTemplate::SetPreviewInfo"
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
  - "SetPreviewInfo"
  - "afxwin/CDocTemplate::SetPreviewInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPreviewInfo"
ms.assetid: 438d931f-57fa-4429-9d2a-46629729654c
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate::SetPreviewInfo
Sets up the out of process preview handler.  
  
## Syntax  
  
```  
void SetPreviewInfo(  
   UINT nIDPreviewFrame,  
   CRuntimeClass* pPreviewFrameClass = NULL,  
   CRuntimeClass* pPreviewViewClass = NULL  
);  
```  
  
#### Parameters  
 `nIDPreviewFrame`  
 Specifies a resource ID of the preview frame.  
  
 `pPreviewFrameClass`  
 Specifies a pointer to a runtime class information structure of the preview frame.  
  
 `pPreviewViewClass`  
 Specifies a pointer to a runtime class information structure of the preview view.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)