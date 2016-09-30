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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the pane to float.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The zero-based index of the tab to float.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the method to use to make the pane float.  For more information, see [CBaseTabbedPane::FloatTab](../vs140/cbasetabbedpane--floattab.md).  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to hide the pane before floating; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Unlike the base class version of this method, this parameter does not have a default value.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the pane floated; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method is like [CBaseTabbedPane::FloatTab](../vs140/cbasetabbedpane--floattab.md) except that it does not enable the last remaining tab on an Outlook bar control to float.  
  
## Requirements  
 **Header:** afxoutlookbar.h  
  
## See Also  
 [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)