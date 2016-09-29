---
title: "CMFCReBar::GetReBarCtrl"
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
  - "CMFCReBar.GetReBarCtrl"
  - "GetReBarCtrl"
  - "CMFCReBar::GetReBarCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetReBarCtrl method"
ms.assetid: 2093e44c-ac4c-47a5-800a-5e487d430b1d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCReBar::GetReBarCtrl
Provides direct access to `CReBarCtrl` the underlying common control for `CMFCReBar` objects.  
  
## Syntax  
  
```  
CReBarCtrl& GetReBarCtrl() const;  
```  
  
## Return Value  
 A reference to the underlying `CReBarCtrl` object.  
  
## Remarks  
 Call this method to take advantage of the Windows rebar common control functionality when customizing your rebar.  
  
## Requirements  
 **Header:** afxRebar.h  
  
## See Also  
 [CMFCReBar Class](../vs140/cmfcrebar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)