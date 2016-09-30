---
title: "CMFCToolBarButton::OnCustomizeMenu"
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
  - "OnCustomizeMenu"
  - "CMFCToolBarButton::OnCustomizeMenu"
  - "CMFCToolBarButton.OnCustomizeMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCustomizeMenu method"
ms.assetid: 30425651-7c31-49c5-8d08-30e4fcfb1322
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::OnCustomizeMenu
Allows the button to modify the provided menu when the application displays a shortcut menu on the parent toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The menu to customize.  
  
## Return Value  
 This method returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The default implementation does nothing and returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Override this method and return a nonzero value if you want to modify the contents of the provided menu.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)