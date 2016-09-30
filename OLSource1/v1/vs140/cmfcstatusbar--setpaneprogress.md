---
title: "CMFCStatusBar::SetPaneProgress"
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
  - "CMFCStatusBar::SetPaneProgress"
  - "SetPaneProgress"
  - "CMFCStatusBar.SetPaneProgress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPaneProgress method"
ms.assetid: 7176be87-9589-4981-8b9f-5a931db643c5
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCStatusBar::SetPaneProgress
Set the current progress indicator of the progress bar for the specified pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the index of the pane for which to update the progress indicator.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the current value of the progress indicator.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether the pane should be updated immediately.  
  
## Remarks  
 Call this method when you want to update the progress indicator for the progress bar in the specified pane.  
  
 To use this function for the given pane, you must call [CMFCStatusBar::EnablePaneProgressBar](../vs140/cmfcstatusbar--enablepaneprogressbar.md) first.  
  
## Requirements  
 **Header:** afxstatusbar.h  
  
## See Also  
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)