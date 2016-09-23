---
title: "CMFCDropDownToolbarButton::CopyFrom"
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
  - CMFCDropDownToolbarButton::CopyFrom
  - CMFCDropDownToolbarButton.CopyFrom
  - CopyFrom
dev_langs: 
  - C++
helpviewer_keywords: 
  - CopyFrom method
ms.assetid: bb8318fa-76c0-440f-93c8-51cb690b21c8
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCDropDownToolbarButton::CopyFrom
Copies the properties of another toolbar button to the current button.  
  
## Syntax  
  
```  
virtual void CopyFrom(  
   const CMFCToolBarButton& src  
);  
```  
  
#### Parameters  
 [in] `src`  
 A reference to the source button from which to copy.  
  
## Remarks  
 Call this method to copy another toolbar button to this toolbar button. `src` must be of type `CMFCDropDownToolbarButton`.  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
## See Also  
 [CMFCDropDownToolbarButton Class](../vs140/cmfcdropdowntoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)