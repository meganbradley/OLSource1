---
title: "CMFCBaseTabCtrl::SetDrawNoPrefix"
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
  - "SetDrawNoPrefix"
  - "CMFCBaseTabCtrl.SetDrawNoPrefix"
  - "CMFCBaseTabCtrl::SetDrawNoPrefix"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDrawNoPrefix method"
ms.assetid: 0a532ff5-ffde-4f75-8a9b-e92d598b01de
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::SetDrawNoPrefix
Enables and disables the processing of prefix characters in tab labels.  
  
## Syntax  
  
```  
void SetDrawNoPrefix(  
   BOOL bNoPrefix,  
   BOOL bRedraw = TRUE  
);  
```  
  
#### Parameters  
 [in] `bNoPrefix`  
 `TRUE` if you want to process prefix characters; otherwise `FALSE`.  
  
 [in] `bRedraw`  
 `TRUE` if you want to redraw the tabbed window; otherwise `FALSE`.  
  
## Remarks  
 A prefix character is a mnemonic character that is preceded by an ampersand (&).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)