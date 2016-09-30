---
title: "CMFCOutlookBarTabCtrl::AddControl"
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
  - "AddControl"
  - "CMFCOutlookBarTabCtrl::AddControl"
  - "CMFCOutlookBarTabCtrl.AddControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddControl method"
ms.assetid: 60a81e73-5ce3-4028-a1af-59d1a9c6957d
caps.latest.revision: 24
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBarTabCtrl::AddControl
Adds a Windows control as a new tab in the Outlook bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a control to add.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the name of tab.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the page will be created as detachable.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Image index in the internal image list for the image to be displayed in the new tab.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the AFX_<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>* style for wrapped docking panes.  
  
## Remarks  
 Use this function to add a control as a new page of an outlook bar.  
  
 This function internally calls on [CMFCBaseTabCtrl::AddTab](../vs140/cmfcbasetabctrl--addtab.md).  
  
 If you set <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> internally creates a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object and wraps the added control. It automatically sets the runtime class of the tabbed window to the runtime class of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and the runtime class of the floating frame to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class. This code snippet is part of the [Outlook Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_OutlookDemo#3](../vs140/codesnippet/CPP/cmfcoutlookbartabctrl--addcontrol_1.cpp)]  
  
## Requirements  
 **Header:** afxOutlookBarTabCtrl.h  
  
## See Also  
 [CMFCOutlookBarTabCtrl Class](../vs140/cmfcoutlookbartabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCOutlookBar](../vs140/cmfcoutlookbar-class.md)   
 [CMultiPaneFrameWnd](../vs140/cmultipaneframewnd-class.md)