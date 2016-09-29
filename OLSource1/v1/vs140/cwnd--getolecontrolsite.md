---
title: "CWnd::GetOleControlSite"
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
  - "CWnd.GetOleControlSite"
  - "CWnd::GetOleControlSite"
  - "GetOleControlSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOleControlSite method"
ms.assetid: a6e651af-d2ef-4b94-9ce8-cdedd999d5ef
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetOleControlSite
Retrieves the custom site for the specified ActiveX control.  
  
## Syntax  
  
```  
  
      COleControlSite* GetOleControlSite(  
   UINT idControl  
) const;  
```  
  
#### Parameters  
 `idControl`  
 The ID of the ActiveX control.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)