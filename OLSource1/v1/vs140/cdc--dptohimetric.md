---
title: "CDC::DPtoHIMETRIC"
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
  - "DPtoHIMETRIC"
  - "CDC.DPtoHIMETRIC"
  - "CDC::DPtoHIMETRIC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DPtoHIMETRIC method"
  - "CDC class, coordinate functions"
ms.assetid: 13792fac-de9c-4df1-aa7b-434b6f1e6274
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::DPtoHIMETRIC
Use this function when you give **HIMETRIC** sizes to OLE, converting pixels to **HIMETRIC**.  
  
## Syntax  
  
```  
  
      void DPtoHIMETRIC(  
   LPSIZE lpSize   
) const;  
```  
  
#### Parameters  
 `lpSize`  
 Points to a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object.  
  
## Remarks  
 If the mapping mode of the device context object is `MM_LOENGLISH`, `MM_HIENGLISH`, `MM_LOMETRIC`, or `MM_HIMETRIC`, then the conversion is based on the number of pixels in the physical inch. If the mapping mode is one of the other non-constrained modes (e.g., `MM_TEXT`), then the conversion is based on the number of pixels in the logical inch.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::DPtoLP](../vs140/cdc--dptolp.md)   
 [CDC::LPtoDP](../vs140/cdc--lptodp.md)   
 [CDC::HIMETRICtoLP](../vs140/cdc--himetrictolp.md)   
 [CDC::HIMETRICtoDP](../vs140/cdc--himetrictodp.md)   
 [CDC::LPtoHIMETRIC](../vs140/cdc--lptohimetric.md)