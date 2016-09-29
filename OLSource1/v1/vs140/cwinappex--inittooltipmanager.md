---
title: "CWinAppEx::InitTooltipManager"
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
  - "CWinAppEx.InitTooltipManager"
  - "CWinAppEx::InitTooltipManager"
  - "InitTooltipManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitTooltipManager method"
ms.assetid: 69a6285e-6892-430a-93e6-bc315346bd32
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::InitTooltipManager
Initializes the [CTooltipManager](../vs140/ctooltipmanager-class.md) object.  
  
## Syntax  
  
```  
BOOL InitTooltipManager();  
```  
  
## Return Value  
 Nonzero if the method creates the `CTooltipManager` object; 0 if the `CTooltipManager` object already exists.  
  
## Remarks  
 If you call [CWinAppEx::GetTooltipManager](../vs140/cwinappex--gettooltipmanager.md), the default implementation of that method calls `InitTooltipManager`.  
  
 If your application already has a tooltip manager and you call `InitTooltipManager`, your application will have an [ASSERT](../vs140/assert--mfc-.md) failure. Therefore, you should not call `InitTooltipManager` if you create a `CTooltipManager` object directly. If you are not using a custom `CTooltipManager`, you should use `GetTooltipManager` to create a `CTooltipManager` object.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::GetTooltipManager](../vs140/cwinappex--gettooltipmanager.md)   
 [CTooltipManager Class](../vs140/ctooltipmanager-class.md)