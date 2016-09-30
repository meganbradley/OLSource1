---
title: "CMFCStatusBar::EnablePaneDoubleClick"
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
  - "CMFCStatusBar.EnablePaneDoubleClick"
  - "CMFCStatusBar::EnablePaneDoubleClick"
  - "EnablePaneDoubleClick"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnablePaneDoubleClick method"
ms.assetid: 708433c2-63a8-46e5-96ab-e61e72a5d3ea
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCStatusBar::EnablePaneDoubleClick
Enables or disables the handling of mouse double-clicks on the status bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, enable the processing of the mouse double-click. Otherwise disable the processing of the mouse double-click.  
  
## Remarks  
 If the status bar is enabled to process double clicks, Windows sends the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> notification together with a resource ID to the owner of the status bar every time that the user double clicks on the status bar pane.  
  
## Requirements  
 **Header:** afxstatusbar.h  
  
## See Also  
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)