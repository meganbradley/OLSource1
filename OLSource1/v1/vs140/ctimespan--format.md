---
title: "CTimeSpan::Format"
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
  - "CTimeSpan::Format"
  - "CTimeSpan.Format"
  - "ATL.CTimeSpan.Format"
  - "ATL::CTimeSpan::Format"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Format method"
  - "CTimeSpan class, conversion"
ms.assetid: 1d21f250-8aef-41da-9454-cff08740db8b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTimeSpan::Format
Generates a formatted string that corresponds to this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A formatting string similar to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> formatting string. Formatting codes, preceded by a percent (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) sign, are replaced by the corresponding <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> component. Other characters in the formatting string are copied unchanged to the returned string. The value and meaning of the formatting codes for **Format** are listed below:  
  
-   **%D** Total days in this <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
-   **%H** Hours in the current day  
  
-   **%M** Minutes in the current hour  
  
-   **%S** Seconds in the current minute  
  
-   **%%** Percent sign  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The ID of the string that identifies this format.  
  
## Return Value  
 A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object that contains the formatted time.  
  
## Remarks  
 The Debug version of the library checks the formatting codes and asserts if the code is not in the list above.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#163](../vs140/codesnippet/CPP/ctimespan--format_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTimeSpan Class](../vs140/ctimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)