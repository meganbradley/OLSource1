---
title: "CDC::GetLayout"
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
  - "CDC.GetLayout"
  - "GetLayout"
  - "CDC::GetLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLayout method"
  - "CDC class, layout functions"
ms.assetid: dac9f7fd-634d-4161-8471-e325f5f3f4a7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetLayout
Call this member function to determine the layout of the text and graphics for a device context, such as a printer or a metafile.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If successful, the layout flags for the current device context. Otherwise, **GDI_ERROR**. For extended error information, call [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360). For a list of the layout flags, see [CDC::SetLayout](../vs140/cdc--setlayout.md).  
  
## Remarks  
 The default layout is left to right.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetLayout](http://msdn.microsoft.com/library/windows/desktop/dd144896)