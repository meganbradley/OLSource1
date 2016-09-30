---
title: "CDC::HIMETRICtoDP"
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
  - "CDC::HIMETRICtoDP"
  - "HIMETRICtoDP"
  - "CDC.HIMETRICtoDP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HIMETRICtoDP method"
  - "CDC class, coordinate functions"
ms.assetid: 98a71f0e-94a7-4fe4-9cb3-1b18f1c3ac6e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::HIMETRICtoDP
Use this function when you convert **HIMETRIC** sizes from OLE to pixels.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object.  
  
## Remarks  
 If the mapping mode of the device context object is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, then the conversion is based on the number of pixels in the physical inch. If the mapping mode is one of the other non-constrained modes (e.g., <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>), then the conversion is based on the number of pixels in the logical inch.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::LPtoDP](../vs140/cdc--lptodp.md)   
 [CDC::HIMETRICtoLP](../vs140/cdc--himetrictolp.md)