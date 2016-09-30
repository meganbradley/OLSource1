---
title: "CMFCVisualManager::OnDrawStatusBarProgress"
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
  - "CMFCVisualManager::OnDrawStatusBarProgress"
  - "CMFCVisualManager.OnDrawStatusBarProgress"
  - "OnDrawStatusBarProgress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawStatusBarProgress method"
ms.assetid: 22a99c83-e6da-4826-961b-c19cb5255358
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawStatusBarProgress
The framework calls this method when it draws the progress indicator on the [CMFCStatusBar](../vs140/cmfcstatusbar-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the device context for the status bar.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that contains the progress bar.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the progress bar.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The total number for the progress bar.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The current progress for the progress bar.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the initial color for the progress bar. The value is either the start of a color gradient or the complete color of the progress bar.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter that indicates the end of a color gradient for the progress bar. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is -1, the framework does not draw the progress bar as a color gradient. Instead, it fills the whole progress bar with the color specified by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter that indicates the text color for the textual representation of the current progress. This parameter is ignored if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether to display the textual representation of the current progress.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)