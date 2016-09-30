---
title: "CWinAppEx::GetTooltipManager"
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
  - "GetTooltipManager"
  - "CWinAppEx.GetTooltipManager"
  - "CWinAppEx::GetTooltipManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTooltipManager method"
ms.assetid: 7e56ae86-cb18-4f0f-83f4-1d5c53d0cd26
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::GetTooltipManager
Returns a pointer to the global [CTooltipManager](../vs140/ctooltipmanager-class.md) object.  
  
## Syntax  
  
```  
CTooltipManager* GetTooltipManager();  
```  
  
## Return Value  
 A pointer to the global `CTooltipManager` object.  
  
## Remarks  
 If the `CTooltipManager` object is not initialized, this function calls [CWinAppEx::InitTooltipManager](../vs140/cwinappex--inittooltipmanager.md) before it returns a pointer.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::InitTooltipManager](../vs140/cwinappex--inittooltipmanager.md)   
 [CTooltipManager Class](../vs140/ctooltipmanager-class.md)