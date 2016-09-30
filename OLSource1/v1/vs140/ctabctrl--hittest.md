---
title: "CTabCtrl::HitTest"
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
  - "TCHT_NOWHERE"
  - "CTabCtrl::HitTest"
  - "TCHT_ONITEMLABEL"
  - "CTabCtrl.HitTest"
  - "TC_HITTESTINFO"
  - "TCHT_ONITEM"
  - "TCHT_ONITEMICON"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TCHT_ONITEMICON"
  - "TCHT_ONITEM"
  - "TCHT_NOWHERE"
  - "TCHT_ONITEMLABEL"
  - "TC_HITTESTINFO"
  - "HitTest method [MFC]"
ms.assetid: cb8cda0b-9321-4769-b324-e40a82df1b39
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::HitTest
Determines which tab, if any, is at the specified screen position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a [TCHITTESTINFO](http://msdn.microsoft.com/library/windows/desktop/bb760553) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)], which specifies the screen position to test.  
  
## Return Value  
 Returns the zero-based index of the tab or – 1 if no tab is at the specified position.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)