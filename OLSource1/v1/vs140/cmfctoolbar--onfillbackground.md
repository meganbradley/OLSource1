---
title: "CMFCToolBar::OnFillBackground"
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
  - CMFCToolBar.OnFillBackground
  - CMFCToolBar::OnFillBackground
  - OnFillBackground
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnFillBackground method
ms.assetid: 9c745c81-4fcf-44e3-8b4a-5aa9b5f53261
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBar::OnFillBackground
Called by the framework from [CBasePane::DoPaint](../vs140/cbasepane--dopaint.md) to fill the toolbar background.  
  
## Syntax  
  
```  
virtual void OnFillBackground(  
   CDC* pDC   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
## Remarks  
 [CMFCToolBar::DoPaint](../vs140/cmfctoolbar--dopaint.md) calls this method when the background of a toolbar has been filled. The default implementation does nothing.  
  
 Override this method to draw custom background in derived classes.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)