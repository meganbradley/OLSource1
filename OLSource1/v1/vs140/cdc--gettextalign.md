---
title: "CDC::GetTextAlign"
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
  - "GetTextAlign"
  - "CDC::GetTextAlign"
  - "CDC.GetTextAlign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTextAlign method"
  - "CDC class, text functions"
ms.assetid: 8fdec670-fede-44ad-9446-7b1627f4257e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetTextAlign
Retrieves the status of the text-alignment flags for the device context.  
  
## Syntax  
  
```  
  
UINT GetTextAlign( ) const;  
```  
  
## Return Value  
 The status of the text-alignment flags. The return value is one or more of the following values:  
  
-   **TA_BASELINE** Specifies alignment of the x-axis and the baseline of the chosen font within the bounding rectangle.  
  
-   **TA_BOTTOM** Specifies alignment of the x-axis and the bottom of the bounding rectangle.  
  
-   **TA_CENTER** Specifies alignment of the y-axis and the center of the bounding rectangle.  
  
-   **TA_LEFT** Specifies alignment of the y-axis and the left side of the bounding rectangle.  
  
-   **TA_NOUPDATECP** Specifies that the current position is not updated.  
  
-   **TA_RIGHT** Specifies alignment of the y-axis and the right side of the bounding rectangle.  
  
-   **TA_TOP** Specifies alignment of the x-axis and the top of the bounding rectangle.  
  
-   **TA_UPDATECP** Specifies that the current position is updated.  
  
## Remarks  
 The text-alignment flags determine how the `TextOut` and `ExtTextOut` member functions align a string of text in relation to the string's starting point. The text-alignment flags are not necessarily single-bit flags and may be equal to 0. To test whether a flag is set, an application should follow these steps:  
  
1.  Apply the bitwise OR operator to the flag and its related flags, grouped as follows:  
  
    -   **TA_LEFT**, **TA_CENTER**, and **TA_RIGHT**  
  
    -   **TA_BASELINE**, **TA_BOTTOM**, and **TA_TOP**  
  
    -   **TA_NOUPDATECP** and **TA_UPDATECP**  
  
2.  Apply the bitwise-AND operator to the result and the return value of `GetTextAlign`.  
  
3.  Test for the equality of this result and the flag.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::ExtTextOut](../vs140/cdc--exttextout.md)   
 [CDC::SetTextAlign](../vs140/cdc--settextalign.md)   
 [CDC::TextOut](../vs140/cdc--textout.md)   
 [GetTextAlign](http://msdn.microsoft.com/library/windows/desktop/dd144932)