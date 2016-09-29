---
title: "CMenu::DeleteTempMap"
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
  - "CMenu::DeleteTempMap"
  - "DeleteTempMap"
  - "CMenu.DeleteTempMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteTempMap method"
  - "CMenu class, initialization"
ms.assetid: cb9f6a96-fd3d-4695-aba5-b63e18bfb5ad
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::DeleteTempMap
Called automatically by the `CWinApp` idle-time handler, deletes any temporary `CMenu` objects created by the [FromHandle](../vs140/cmenu--fromhandle.md) member function.  
  
## Syntax  
  
```  
  
static void PASCAL DeleteTempMap( );  
```  
  
## Remarks  
 `DeleteTempMap` detaches the Windows menu object attached to a temporary `CMenu` object before deleting the `CMenu` object.  
  
## Example  
 [!code[NVC_MFCWindowing#23](../vs140/codesnippet/CPP/cmenu--deletetempmap_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)