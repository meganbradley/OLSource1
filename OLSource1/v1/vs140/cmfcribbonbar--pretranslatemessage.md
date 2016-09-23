---
title: "CMFCRibbonBar::PreTranslateMessage"
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
  - CMFCRibbonBar.PreTranslateMessage
  - PreTranslateMessage
  - CMFCRibbonBar::PreTranslateMessage
dev_langs: 
  - C++
helpviewer_keywords: 
  - PreTranslateMessage method
ms.assetid: dccf060d-4558-4b59-a597-7951260c8d1f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonBar::PreTranslateMessage
Determines if the specified message is processed by the ribbon bar.  
  
## Syntax  
  
```  
virtual BOOL PreTranslateMessage(  
   MSG* pMsg  
);  
```  
  
#### Parameters  
 [in] `pMsg`  
 Pointer to a message.  
  
## Return Value  
 `TRUE` if the message was processed by the ribbon bar; otherwise `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)