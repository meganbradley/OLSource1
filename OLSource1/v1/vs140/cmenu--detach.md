---
title: "CMenu::Detach"
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
  - "CMenu::Detach"
  - "CMenu.Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMenu class, initialization"
  - "Detach method"
ms.assetid: cc83c02c-4782-42f2-b957-53d1bb62f026
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::Detach
Detaches a Windows menu from a `CMenu` object and returns the handle.  
  
## Syntax  
  
```  
  
HMENU Detach( );  
```  
  
## Return Value  
 The handle, of type `HMENU`, to a Windows menu, if successful; otherwise **NULL**.  
  
## Remarks  
 The `m_hMenu` data member is set to **NULL**.  
  
## Example  
 [!code[NVC_MFCWindowing#21](../vs140/codesnippet/CPP/cmenu--detach_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::Attach](../vs140/cmenu--attach.md)