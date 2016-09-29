---
title: "CDialogImpl::MapDialogRect"
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
  - "CDialogImpl.MapDialogRect"
  - "CDialogImpl::MapDialogRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MapDialogRect method"
ms.assetid: f0815e3e-23e0-4363-b1c4-cd54939dad95
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogImpl::MapDialogRect
Converts (maps) the dialog-box units of the specified rectangle to screen units (pixels).  
  
## Syntax  
  
```  
  
      BOOL MapDialogRect(  
   LPRECT lpRect   
);  
```  
  
#### Parameters  
 `lpRect`  
 Points to a `CRect` object or [RECT](../vs140/rect-structure.md) structure that is to receive the client coordinates of the update that encloses the update region.  
  
## Return Value  
 Nonzero if the update succeeds; 0 if the update fails. To get extended error information, call `GetLastError`.  
  
## Remarks  
 The function replaces the coordinates in the specified `RECT` structure with the converted coordinates, which allows the structure to be used to create a dialog box or position a control within a dialog box.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CDialogImpl Class](../vs140/cdialogimpl-class.md)   
 [MapDialogRect](http://msdn.microsoft.com/library/windows/desktop/ms645502)