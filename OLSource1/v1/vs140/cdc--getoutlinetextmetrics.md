---
title: "CDC::GetOutlineTextMetrics"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDC.GetOutlineTextMetrics
  - CDC::GetOutlineTextMetrics
  - GetOutlineTextMetrics
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetOutlineTextMetrics method
  - CDC class, font functions
ms.assetid: eaecfdb0-bac3-4dc0-a739-aa5e1d7d8415
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::GetOutlineTextMetrics
Retrieves metric information for TrueType fonts.  
  
## Syntax  
  
```  
  
      UINT GetOutlineTextMetrics(  
   UINT cbData,  
   LPOUTLINETEXTMETRIC lpotm  
) const;  
```  
  
#### Parameters  
 `lpotm`  
 Points to an array of [OUTLINETEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd162755) structures. If this parameter is **NULL**, the function returns the size of the buffer required for the retrieved metric data.  
  
 `cbData`  
 Specifies the size, in bytes, of the buffer to which information is returned.  
  
 `lpotm`  
 Points to an **OUTLINETEXTMETRIC** structure. If this parameter is **NULL**, the function returns the size of the buffer required for the retrieved metric information.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The [OUTLINETEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd162755) structure contains most of the font metric information provided with the TrueType format, including a [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure. The last four members of the **OUTLINETEXTMETRIC** structure are pointers to strings. Applications should allocate space for these strings in addition to the space required for the other members. Because there is no system-imposed limit to the size of the strings, the simplest method for allocating memory is to retrieve the required size by specifying **NULL** for `lpotm` in the first call to the `GetOutlineTextMetrics` function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetTextMetrics](http://msdn.microsoft.com/library/windows/desktop/dd144941)   
 [GetOutlineTextMetrics](http://msdn.microsoft.com/library/windows/desktop/dd144906)   
 [CDC::GetTextMetrics](../vs140/cdc--gettextmetrics.md)