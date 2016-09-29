---
title: "CAtlPreviewCtrlImpl::SetRect"
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
  - "SetRect"
  - "atlpreviewctrlimpl/CAtlPreviewCtrlImpl::SetRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRect"
ms.assetid: 567ce1d8-0e42-497b-9862-485098d82900
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlPreviewCtrlImpl::SetRect
Sets a new bounding rectangle for this control.  
  
## Syntax  
  
```  
virtual void SetRect(  
   const RECT* prc,  
   BOOL bRedraw  
);  
```  
  
#### Parameters  
 `prc`  
 Specifies the new size and position of the preview control.  
  
 `bRedraw`  
 Specifies whether the control should be redrawn.  
  
## Remarks  
  
## Requirements  
 **Header:** atlpreviewctrlimpl.h  
  
## See Also  
 [CAtlPreviewCtrlImpl Class](../vs140/catlpreviewctrlimpl-class.md)