---
title: "CMFCToolBar::GetCustomizeButton"
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
  - "CMFCToolBar.GetCustomizeButton"
  - "CMFCToolBar::GetCustomizeButton"
  - "GetCustomizeButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCustomizeButton method"
ms.assetid: 1c37d1a4-90dd-41a8-85f8-b1f272e2d9b4
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetCustomizeButton
Retrieves a pointer to the `CMFCCustomizeButton` object that is associated with the toolbar.  
  
## Syntax  
  
```  
CMFCCustomizeButton* GetCustomizeButton();  
```  
  
## Return Value  
 A pointer to the `CMFCCustomizeButton` object that is associated with the toolbar.  
  
## Remarks  
 This method retrieves the **Customize** button that appears at the end of the toolbar. Use the [CMFCToolBar::EnableCustomizeButton](../vs140/cmfctoolbar--enablecustomizebutton.md) method to add the **Customize** button to your toolbar.  
  
 You can call the [CMFCToolBar::IsExistCustomizeButton](../vs140/cmfctoolbar--isexistcustomizebutton.md) method to determine whether the toolbar contains a valid `CMFCCustomizeButton` object.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCCustomizeButton Class](assetId:///f0a1da67-dcd4-4f40-bc1d-a8ee4184c647)   
 [CMFCToolBar::EnableCustomizeButton](../vs140/cmfctoolbar--enablecustomizebutton.md)   
 [CMFCToolBar::IsExistCustomizeButton](../vs140/cmfctoolbar--isexistcustomizebutton.md)