---
title: "CWnd::DeleteTempMap"
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
  - "DeleteTempMap"
  - "CWnd::DeleteTempMap"
  - "CWnd.DeleteTempMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteTempMap method"
ms.assetid: 01023c00-c6ad-4133-b584-2f38e043cfbc
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::DeleteTempMap
Called automatically by the idle time handler of the `CWinApp` object.  
  
## Syntax  
  
```  
  
static void PASCAL DeleteTempMap( );  
```  
  
## Remarks  
 Deletes any temporary `CWnd` objects created by the `FromHandle` member function.  
  
## Example  
 [!code[NVC_MFCWindowing#86](../vs140/codesnippet/CPP/cwnd--deletetempmap_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::FromHandle](../vs140/cwnd--fromhandle.md)