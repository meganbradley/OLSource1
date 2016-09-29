---
title: "CMFCVisualManagerOffice2003::IsToolbarRoundShape"
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
  - "CMFCVisualManagerOffice2003::IsToolbarRoundShape"
  - "CMFCVisualManagerOffice2003.IsToolbarRoundShape"
  - "IsToolbarRoundShape"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsToolbarRoundShape method"
ms.assetid: 80037f8b-d279-4a9c-9c5f-c804383a66fa
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::IsToolbarRoundShape
Indicates whether a specified toolbar is round.  
  
## Syntax  
  
```  
virtual BOOL IsToolbarRoundShape(  
   CMFCToolBar* pToolBar  
);  
```  
  
#### Parameters  
 [in] `pToolBar`  
 Pointer to the toolbar in question.  
  
## Return Value  
 Returns `TRUE` if the toolbar is round, or `FALSE` if it is a menu bar.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)