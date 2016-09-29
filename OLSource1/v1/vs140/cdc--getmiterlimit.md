---
title: "CDC::GetMiterLimit"
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
  - "CDC.GetMiterLimit"
  - "CDC::GetMiterLimit"
  - "GetMiterLimit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, path functions"
  - "GetMiterLimit method"
ms.assetid: 63eaa0c2-9ae9-4d9b-bd37-455260c2ee11
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetMiterLimit
Returns the miter limit for the device context.  
  
## Syntax  
  
```  
  
float GetMiterLimit( ) const;  
```  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The miter limit is used when drawing geometric lines that have miter joins.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetMiterLimit](../vs140/cdc--setmiterlimit.md)   
 [GetMiterLimit](http://msdn.microsoft.com/library/windows/desktop/dd144900)