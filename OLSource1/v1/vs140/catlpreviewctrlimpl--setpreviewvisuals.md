---
title: "CAtlPreviewCtrlImpl::SetPreviewVisuals"
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
  - "atlpreviewctrlimpl/CAtlPreviewCtrlImpl::SetPreviewVisuals"
  - "SetPreviewVisuals"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPreviewVisuals"
ms.assetid: 2acc2023-d399-4703-83d2-f2a099fb6101
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlPreviewCtrlImpl::SetPreviewVisuals
Called by a Rich Preview handler when it needs to set visuals of rich preview content.  
  
## Syntax  
  
```  
virtual void SetPreviewVisuals(  
   COLORREF clrBack,  
   COLORREF clrText,  
   const LOGFONTW *plf  
);  
```  
  
#### Parameters  
 `clrBack`  
 Background color of the preview window.  
  
 `clrText`  
 Text color of the preview window.  
  
 `plf`  
 Font used to display text in the preview window.  
  
## Remarks  
  
## Requirements  
 **Header:** atlpreviewctrlimpl.h  
  
## See Also  
 [CAtlPreviewCtrlImpl Class](../vs140/catlpreviewctrlimpl-class.md)