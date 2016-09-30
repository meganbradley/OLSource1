---
title: "CMDIChildWndEx::CanShowOnWindowsList"
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
  - "CMDIChildWndEx::CanShowOnWindowsList"
  - "CMDIChildWndEx.CanShowOnWindowsList"
  - "CanShowOnWindowsList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanShowOnWindowsList method"
ms.assetid: 2e649415-990e-4136-ab83-48786d3d949e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::CanShowOnWindowsList
Specifies whether the MDI child window name can be displayed in the [CMFCWindowsManagerDialog](../vs140/cmfcwindowsmanagerdialog-class.md) dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the window can be displayed in the **Windows** dialog box; otherwise, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 Override this method in a derived class and return <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the window should not be displayed in the **Windows** dialog box. This function is called from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxMDIChildWndEx.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)