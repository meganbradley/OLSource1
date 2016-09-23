---
title: "CAtlPreviewCtrlImpl::OnPaint"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - atlpreviewctrlimpl/CAtlPreviewCtrlImpl::OnPaint
  - OnPaint
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnPaint
ms.assetid: 549158c8-04cd-41f5-abc5-cc77d27fb94f
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlPreviewCtrlImpl::OnPaint
Handles the WM_PAINT message.  
  
## Syntax  
  
```  
LRESULT OnPaint(  
   UINT nMsg,  
   WPARAM wParam,  
   LPARAM lParam,  
   BOOL& bHandled  
);  
```  
  
#### Parameters  
 `nMsg`  
 Set to WM_PAINT.  
  
 `wParam`  
 This parameter is not used.  
  
 `lParam`  
 This parameter is not used.  
  
 `bHandled`  
 When this function returns, it contains `TRUE`.  
  
## Return Value  
 Always returns 0.  
  
## Remarks  
  
## Requirements  
 **Header:** atlpreviewctrlimpl.h  
  
## See Also  
 [CAtlPreviewCtrlImpl Class](../vs140/catlpreviewctrlimpl-class.md)