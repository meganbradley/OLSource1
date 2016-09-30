---
title: "CMFCBaseTabCtrl::DetachTab"
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
  - "DetachTab"
  - "CMFCBaseTabCtrl.DetachTab"
  - "CMFCBaseTabCtrl::DetachTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DetachTab method"
ms.assetid: 986fb759-9f69-41f9-94b7-9de9b7491433
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::DetachTab
The framework calls this method to detach a tab from the tab control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An enumerated data type provided by the [CBasePane Class](../vs140/cbasepane-class.md). This data type specifies the method that was used to detach the tab.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The zero-based index of the tab to be detached.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the framework should hide the detached tab.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 If the tab specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is non-detachable, this function fails and returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)