---
title: "CFont::GetLogFont"
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
  - "CFont.GetLogFont"
  - "CFont::GetLogFont"
  - "GetLogFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLogFont method"
  - "CFont class, attributes"
ms.assetid: 277832a9-82f3-4257-9b75-ddda68577ba6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFont::GetLogFont
Call this function to retrieve a copy of the `LOGFONT` structure for `CFont`.  
  
## Syntax  
  
```  
  
      int GetLogFont(  
   LOGFONT * pLogFont   
);  
```  
  
#### Parameters  
 *pLogFont*  
 Pointer to the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure to receive the font information.  
  
## Return Value  
 Nonzero if the function succeeds, otherwise 0.  
  
## Example  
 [!code[NVC_MFCDocView#76](../vs140/codesnippet/CPP/cfont--getlogfont_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFont Class](../vs140/cfont-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)   
 [GetObject](http://msdn.microsoft.com/library/windows/desktop/dd144904)