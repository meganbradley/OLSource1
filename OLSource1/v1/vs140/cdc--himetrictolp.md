---
title: "CDC::HIMETRICtoLP"
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
  - "CDC.HIMETRICtoLP"
  - "CDC::HIMETRICtoLP"
  - "HIMETRICtoLP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HIMETRICtoLP method"
  - "CDC class, coordinate functions"
ms.assetid: 3d1b132d-1713-4f78-8820-02582715d680
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::HIMETRICtoLP
Call this function to convert **HIMETRIC** units into logical units.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object.  
  
## Remarks  
 Use this function when you get **HIMETRIC** sizes from OLE and wish to convert them to your application's natural mapping mode.  
  
 The conversion is accomplished by first converting the **HIMETRIC** units into pixels and then converting these units into logical units using the device context's current mapping units. Note that the extents of the device's window and viewport will affect the result.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::HIMETRICtoDP](../vs140/cdc--himetrictodp.md)   
 [CDC::DPtoLP](../vs140/cdc--dptolp.md)