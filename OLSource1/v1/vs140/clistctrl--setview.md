---
title: "CListCtrl::SetView"
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
  - "CListCtrl.SetView"
  - "CListCtrl::SetView"
  - "SetView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetView method"
ms.assetid: 37eb9bda-6fbe-4278-a60d-e7a1fe40f63e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetView
Sets the view of the list view control.  
  
## Syntax  
  
```  
  
      DWORD SetView(  
   int iView   
);  
```  
  
#### Parameters  
 *iView*  
 The view to be selected.  
  
## Return Value  
 Returns 1 if successful, or -1 otherwise. For example, -1 is returned if the view is invalid.  
  
## Remarks  
 This member function emulates the functionality of the [LVM_SETVIEW](http://msdn.microsoft.com/library/windows/desktop/bb761220) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)