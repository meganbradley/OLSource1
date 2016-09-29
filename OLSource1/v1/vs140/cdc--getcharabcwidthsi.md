---
title: "CDC::GetCharABCWidthsI"
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
  - "CDC::GetCharABCWidthsI"
  - "CDC.GetCharABCWidthsI"
  - "GetCharABCWidthsI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCharABCWidthsI method"
  - "CDC class, text functions"
ms.assetid: 113d98b9-33a1-4937-852f-ff14a1e947a6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetCharABCWidthsI
Retrieves the widths, in logical units, of consecutive glyph indices in a specified range from the current TrueType font.  
  
## Syntax  
  
```  
  
      BOOL GetCharABCWidthsI(  
   UINT giFirst,  
   UINT cgi,  
   LPWORD pgi,  
   LPABC lpabc  
) const;  
```  
  
#### Parameters  
 `giFirst`  
 Specifies the first glyph index in the group of consecutive glyph indices from the current font. This parameter is only used if the `pgi` parameter is **NULL**.  
  
 `cgi`  
 Specifies the number of glyph indices.  
  
 `pgi`  
 A pointer to an array containing glyph indices. If the value is **NULL**, the `giFirst` parameter is used instead. The `cgi` parameter specifies the number of glyph indices in this array.  
  
 `lpabc`  
 Pointer to an array of [ABC](http://msdn.microsoft.com/library/windows/desktop/dd162454) structures receiving the character widths. This array must contain at least as many **ABC** structures as there are glyph indices specified by the `cgi` parameter.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 This member function emulates the functionality of the function [GetCharABCWidthsI](http://msdn.microsoft.com/library/windows/desktop/dd144859), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetCharWidth](../vs140/cdc--getcharwidth.md)   
 [CDC::GetOutlineTextMetrics](../vs140/cdc--getoutlinetextmetrics.md)