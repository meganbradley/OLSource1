---
title: "CDC::GetFontData"
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
  - CDC::GetFontData
  - GetFontData
  - CDC.GetFontData
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetFontData method
  - CDC class, font functions
ms.assetid: ed0ec949-5823-4250-96a9-cc217cc463ba
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::GetFontData
Retrieves font-metric information from a scalable font file.  
  
## Syntax  
  
```  
  
      DWORD GetFontData(  
   DWORD dwTable,  
   DWORD dwOffset,  
   LPVOID lpData,  
   DWORD cbData   
) const;  
```  
  
#### Parameters  
 `dwTable`  
 Specifies the name of the metric table to be returned. This parameter can be one of the metric tables documented in the TrueType Font Files specification published by Microsoft Corporation. If this parameter is 0, the information is retrieved starting at the beginning of the font file.  
  
 `dwOffset`  
 Specifies the offset from the beginning of the table at which to begin retrieving information. If this parameter is 0, the information is retrieved starting at the beginning of the table specified by the `dwTable` parameter. If this value is greater than or equal to the size of the table, `GetFontData` returns 0.  
  
 `lpData`  
 Points to a buffer that will receive the font information. If this value is **NULL**, the function returns the size of the buffer required for the font data specified in the `dwTable` parameter.  
  
 `cbData`  
 Specifies the length, in bytes, of the information to be retrieved. If this parameter is 0, `GetFontData` returns the size of the data specified in the `dwTable` parameter.  
  
## Return Value  
 Specifies the number of bytes returned in the buffer pointed to by `lpData` if the function is successful; otherwise –1.  
  
## Remarks  
 The information to retrieve is identified by specifying an offset into the font file and the length of the information to return.  
  
 An application can sometimes use the `GetFontData` member function to save a TrueType font with a document. To do this, the application determines whether the font can be embedded and then retrieves the entire font file, specifying 0 for the `dwTable`, `dwOffset`, and `cbData` parameters.  
  
 Applications can determine whether a font can be embedded by checking the **otmfsType** member of the [OUTLINETEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd162755) structure. If bit 1 of **otmfsType** is set, embedding is not permitted for the font. If bit 1 is clear, the font can be embedded. If bit 2 is set, the embedding is read only.  
  
 If an application attempts to use this function to retrieve information for a non-TrueType font, the `GetFontData` member function returns –1.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetOutlineTextMetrics](../vs140/cdc--getoutlinetextmetrics.md)   
 [GetFontData](http://msdn.microsoft.com/library/windows/desktop/dd144885)   
 [OUTLINETEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd162755)