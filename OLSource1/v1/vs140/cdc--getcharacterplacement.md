---
title: "CDC::GetCharacterPlacement"
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
  - "CDC::GetCharacterPlacement"
  - "CDC.GetCharacterPlacement"
  - "GetCharacterPlacement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCharacterPlacement method"
  - "CDC class, text functions"
ms.assetid: 0c0290b9-b273-4c42-9a4f-2c2be3018136
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetCharacterPlacement
Retrieves various types of information on a character string.  
  
## Syntax  
  
```  
DWORD GetCharacterPlacement(  
   LPCTSTR lpString,  
   int nCount,  
   int nMaxExtent,  
   LPGCP_RESULTS lpResults,  
   DWORD dwFlags  
) const;  
DWORD GetCharacterPlacement(  
   CString& str,  
   int nMaxExtent,  
   LPGCP_RESULTS lpResults,  
   DWORD dwFlags  
) const;  
```  
  
#### Parameters  
 `lpString`  
 A pointer to the character string to process.  
  
 `nCount`  
 Specifies the length of the string. For the ANSI version, it is a BYTE count and for the Unicode function it is a WORD count. For more information, see [GetCharacterPlacement](http://msdn.microsoft.com/library/windows/desktop/dd144860\(v=vs.85\).aspx).  
  
 `nMaxExtent`  
 Specifies the maximum extent (in logical units) to which the string is processed. Characters that, if processed, would exceed this extent are ignored. Computations for any required ordering or glyph arrays apply only to the included characters. This parameter is used only if the GCP_MAXEXTENT value is specified in the `dwFlags` parameter. As the function processes the input string, each character and its extent is added to the output, extent, and other arrays only if the total extent has not yet exceeded the maximum. Once the limit is reached, processing will stop.  
  
 lpResults  
 Pointer to a [GCP_Results](http://msdn.microsoft.com/library/windows/desktop/dd144842\(v=vs.85\).aspx) structure that receives the results of the function.  
  
 `dwFlags`  
 Specifies how to process the string into the required arrays. This parameter can be one or more of the values listed in the `dwFlags` section of the [GetCharacterPlacement](http://msdn.microsoft.com/library/windows/desktop/dd144860\(v=vs.85\).aspx) topic.  
  
 `str`  
 A pointer to a [CString](../vs140/cstringt-class.md) object to process.  
  
## Return Value  
 If the function succeeds, the return value is the width and height of the string in logical units.  
  
 If the function fails, the return value is zero.  
  
## Remarks  
 This member function emulates the functionality of the function [GetCharacterPlacement](http://msdn.microsoft.com/library/windows/desktop/dd144860\(v=vs.85\).aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::ExtTextOut](../vs140/cdc--exttextout.md)   
 [CDC::GetCharABCWidths](../vs140/cdc--getcharabcwidths.md)   
 [CDC::GetTextMetrics](../vs140/cdc--gettextmetrics.md)