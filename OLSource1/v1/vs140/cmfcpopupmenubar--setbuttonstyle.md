---
title: "CMFCPopupMenuBar::SetButtonStyle"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - SetButtonStyle
  - CMFCPopupMenuBar.SetButtonStyle
  - CMFCPopupMenuBar::SetButtonStyle
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetButtonStyle method
ms.assetid: 0d11eee1-8e72-46d0-bba9-2de849757a20
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPopupMenuBar::SetButtonStyle
Sets the style of the toolbar button at the given index. (Overrides [CMFCToolBar::SetButtonStyle](../vs140/cmfctoolbar--setbuttonstyle.md).)  
  
## Syntax  
  
```  
virtual void SetButtonStyle(  
   int nIndex,  
   UINT nStyle  
);  
```  
  
#### Parameters  
 [in] `nIndex`  
 The zero-based index of the toolbar button whose style is to be set.  
  
 [in] `nStyle`  
 The style of the button. See [ToolBar Control Styles](../vs140/toolbar-control-styles.md) for the list of available toolbar button styles.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpopupmenubar.h  
  
## See Also  
 [CMFCPopupMenuBar Class](../vs140/cmfcpopupmenubar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)