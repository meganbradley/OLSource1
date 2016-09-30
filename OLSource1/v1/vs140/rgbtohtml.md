---
title: "RGBToHtml"
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
  - "ATL.RGBToHtml"
  - "ATL::RGBToHtml"
  - "RGBToHtml"
  - "ATLUTIL/RGBToHtml"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RGBToHtml function"
ms.assetid: 356bb9ca-3b14-4382-b83d-543acdb128f6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RGBToHtml
Converts a [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value to the HTML text corresponding to that color value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An RGB color value.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Caller-allocated buffer to receive the text for the HTML color value. The buffer must have space for at least 8 characters including space for the null terminator).  
  
 *nBuffer*  
 The size in bytes of the buffer (including space for the null terminator).  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 An HTML color value is a pound sign followed by a 6-digit hexadecimal value using 2 digits for each of the red, green, and blue components of the color (for example, #FFFFFF is white).  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)