---
title: "CMFCToolBar::IsExistCustomizeButton"
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
  - "CMFCToolBar.IsExistCustomizeButton"
  - "IsExistCustomizeButton"
  - "CMFCToolBar::IsExistCustomizeButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsExistCustomizeButton method"
ms.assetid: 9f518b89-e03d-4bc7-bea5-29a484c1a4fc
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::IsExistCustomizeButton
Determines whether the toolbar contains the **Customize** button.  
  
## Syntax  
  
```  
BOOL IsExistCustomizeButton();  
```  
  
## Return Value  
 `TRUE` if the toolbar contains the **Customize** button; otherwise `FALSE`.  
  
## Remarks  
 If this method returns `TRUE`, the [CMFCToolBar::GetCustomizeButton](../vs140/cmfctoolbar--getcustomizebutton.md) method returns a pointer to the **Customize** button that appears at the end of the toolbar.  
  
 Use the [CMFCToolBar::EnableCustomizeButton](../vs140/cmfctoolbar--enablecustomizebutton.md) method to add the **Customize** button to your toolbar.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCCustomizeButton Class](assetId:///f0a1da67-dcd4-4f40-bc1d-a8ee4184c647)   
 [CMFCToolBar::GetCustomizeButton](../vs140/cmfctoolbar--getcustomizebutton.md)   
 [CMFCToolBar::EnableCustomizeButton](../vs140/cmfctoolbar--enablecustomizebutton.md)