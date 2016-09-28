---
title: "CDC::GetTextExtentPointI"
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
  - "GetTextExtentPointI"
  - "CDC.GetTextExtentPointI"
  - "CDC::GetTextExtentPointI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTextExtentPointI method"
  - "CDC class, text functions"
ms.assetid: 37d9032d-e790-42cb-a567-20f3ea0bd8ef
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetTextExtentPointI
Retrieves the width and height of the specified array of glyph indices.  
  
## Syntax  
  
```  
  
      BOOL GetTextExtentPointI(  
   LPWORD pgiIn,  
   int cgi,  
   LPSIZE lpSize  
) const;  
```  
  
#### Parameters  
 `pgiIn`  
 A pointer to an array of glyph indices for which extents are to be retrieved.  
  
 `cgi`  
 Specifies the number of glyphs in the array pointed to by `pgiIn`.  
  
 `lpSize`  
 Pointer to a [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure that receives the dimensions of the glyph indices array, in logical units. This value cannot be **NULL**.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 This member function emulates the functionality of the function [GetTextExtentPointI](http://msdn.microsoft.com/library/windows/desktop/dd144939), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetTextExtentExPointI](../vs140/cdc--gettextextentexpointi.md)