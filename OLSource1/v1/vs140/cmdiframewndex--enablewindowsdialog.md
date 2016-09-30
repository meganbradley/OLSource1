---
title: "CMDIFrameWndEx::EnableWindowsDialog"
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
  - "CMDIFrameWndEx.EnableWindowsDialog"
  - "CMDIFrameWndEx::EnableWindowsDialog"
  - "EnableWindowsDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableWindowsDialog method"
ms.assetid: 0473e4a3-9408-4f6c-93d8-0a7cedb36635
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::EnableWindowsDialog
Inserts a menu item whose command ID calls a [CMFCWindowsManagerDialog](../vs140/cmfcwindowsmanagerdialog-class.md) dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the resource ID of a menu.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the item's text.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether to display a **Help** button on the windows management dialog box.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The string resource identifier that contains the item's text string.  
  
## Remarks  
 Use this method to insert a menu item whose command calls a MDI child window management dialog box ([CMFCWindowsManagerDialog Class](../vs140/cmfcwindowsmanagerdialog-class.md)). The new item is inserted into the menu specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when you process the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> message.  
  
## Example  
 The following example shows how <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#10](../vs140/codesnippet/CPP/cmdiframewndex--enablewindowsdialog_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)