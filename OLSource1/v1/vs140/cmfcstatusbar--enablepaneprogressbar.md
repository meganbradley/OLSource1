---
title: "CMFCStatusBar::EnablePaneProgressBar"
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
  - "EnablePaneProgressBar"
  - "CMFCStatusBar::EnablePaneProgressBar"
  - "CMFCStatusBar.EnablePaneProgressBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnablePaneProgressBar method"
ms.assetid: 306a1ad9-6ca5-420b-8fa0-fa9e8b19d9e2
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCStatusBar::EnablePaneProgressBar
Display a progress bar on the specified pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the index of the pane whose progress bar to enable.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the maximum value for the progress bar.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether the progress bar should display the current progress value.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the background color of the progress bar.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the secondary color of the progress bar background. Use different value than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to fill by a color blended into a gradient.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the color of the text of the progress bar.  
  
## Remarks  
 If you want to disable the progress bar call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> set to -1. By default <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is set to 100. Therefore, you do not need any additional calculations to display progress as percentage.  
  
 You should pass different values for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> so that the background color of the progress bar displays a color blended into a gradient. .  
  
 To set the current progress, call the [CMFCStatusBar::SetPaneProgress](../vs140/cmfcstatusbar--setpaneprogress.md) method.  
  
## Requirements  
 **Header:** afxstatusbar.h  
  
## See Also  
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)