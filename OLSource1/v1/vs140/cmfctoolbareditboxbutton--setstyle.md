---
title: "CMFCToolBarEditBoxButton::SetStyle"
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
  - CMFCToolBarEditBoxButton.SetStyle
  - SetStyle
  - CMFCToolBarEditBoxButton::SetStyle
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetStyle method
ms.assetid: 283e9be8-f10a-495d-9e6e-0b870d632c30
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarEditBoxButton::SetStyle
Specifies the style of a toolbar edit box control.  
  
## Syntax  
  
```  
virtual void SetStyle(  
   UINT nStyle   
);  
```  
  
#### Parameters  
 [in] `nStyle`  
 A new style to set.  
  
## Remarks  
 This method sets [CMFCToolBarButton::m_nStyle](../vs140/cmfctoolbarbutton--m_nstyle.md) to `nStyle` It also disables the text box when the application is in Customize mode, and enables it when the application is not in Customize mode (see [CMFCToolBar::SetCustomizeMode](../vs140/cmfctoolbar--setcustomizemode.md) and [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar--iscustomizemode.md)). See [ToolBar Control Styles](../vs140/toolbar-control-styles.md) for a list of valid style flags.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)