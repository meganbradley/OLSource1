---
title: "CMFCOutlookBar::FloatTab"
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
  - "CMFCOutlookBar::FloatTab"
  - "CMFCOutlookBar.FloatTab"
  - "FloatTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FloatTab method"
ms.assetid: 9a312a3c-91c4-4b91-b17f-45b2936f6906
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBar::FloatTab
Floats a pane.  
  
## Syntax  
  
```  
virtual BOOL FloatTab(  
   CWnd* pBar,  
   int nTabID,  
   AFX_DOCK_METHOD dockMethod,  
   BOOL bHide  
);  
```  
  
#### Parameters  
 [in] `pBar`  
 A pointer to the pane to float.  
  
 [in] `nTabID`  
 The zero-based index of the tab to float.  
  
 [in] `dockMethod`  
 Specifies the method to use to make the pane float.  For more information, see [CBaseTabbedPane::FloatTab](../vs140/cbasetabbedpane--floattab.md).  
  
 [in] `bHide`  
 `TRUE` to hide the pane before floating; otherwise, `FALSE`. Unlike the base class version of this method, this parameter does not have a default value.  
  
## Return Value  
 `TRUE` if the pane floated; otherwise, `FALSE`.  
  
## Remarks  
 This method is like [CBaseTabbedPane::FloatTab](../vs140/cbasetabbedpane--floattab.md) except that it does not enable the last remaining tab on an Outlook bar control to float.  
  
## Requirements  
 **Header:** afxoutlookbar.h  
  
## See Also  
 [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)