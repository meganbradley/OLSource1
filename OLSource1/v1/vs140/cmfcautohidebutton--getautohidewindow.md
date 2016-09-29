---
title: "CMFCAutoHideButton::GetAutoHideWindow"
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
  - "GetAutoHideWindow"
  - "CMFCAutoHideButton::GetAutoHideWindow"
  - "CMFCAutoHideButton.GetAutoHideWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAutoHideWindow method"
ms.assetid: 04020bd7-5329-4ed1-ad99-7475edde9970
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAutoHideButton::GetAutoHideWindow
Returns the [CDockablePane](../vs140/cdockablepane-class.md) object associated with the auto-hide button.  
  
## Syntax  
  
```  
CDockablePane* GetAutoHideWindow() const;  
```  
  
## Return Value  
 A pointer to the associated `CDockablePane` object.  
  
## Remarks  
 To associate an auto-hide button with a `CDockablePane`, pass the `CDockablePane` as a parameter to the [CMFCAutoHideButton::Create](../vs140/cmfcautohidebutton--create.md) method.  
  
## Requirements  
 **Header:** afxautohidebutton.h  
  
## See Also  
 [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CDockablePane Class](../vs140/cdockablepane-class.md)