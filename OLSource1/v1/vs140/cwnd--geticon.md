---
title: "CWnd::GetIcon"
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
  - "CWnd.GetIcon"
  - "GetIcon"
  - "CWnd::GetIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "icons, retrieving"
  - "GetIcon method"
  - "retrieving icons"
ms.assetid: 14ec8c64-2582-433d-82a4-3f3b7c8cad1d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetIcon
Call this member function to get the handle to either a big (32x32) or the handle to a small (16x16) icon, as indicated by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a 32 pixel by 32 pixel icon if **TRUE**; specifies a 16 pixel by 16 pixel icon if **FALSE**.  
  
## Return Value  
 A handle to an icon. If unsuccessful, returns **NULL**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetIcon](../vs140/cwnd--seticon.md)