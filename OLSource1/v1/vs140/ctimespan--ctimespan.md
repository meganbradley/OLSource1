---
title: "CTimeSpan::CTimeSpan"
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
  - "ATL::CTimeSpan::CTimeSpan"
  - "CTimeSpan::CTimeSpan"
  - "ATL.CTimeSpan.CTimeSpan"
  - "CTimeSpan.CTimeSpan"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTimeSpan class, constructor"
  - "CTimeSpan class, construction/destruction"
ms.assetid: 027ca262-bccc-45fe-a0c6-7fe201a99cb0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTimeSpan::CTimeSpan
Constructs <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects in various ways.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *timeSpanSrc*  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that already exists.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A **__time64_t** time value, which is the number of seconds in the time span. In Visual C++ versions 6.0 and earlier, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> was a value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Visual C++ .NET or later silently converts a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter to **__time64_t**.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Days, hours, minutes, and seconds, respectively.  
  
## Remarks  
 All these constructors create a new <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object initialized with the specified relative time. Each constructor is described below:  
  
-   **CTimeSpan( );** Constructs an uninitialized <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
-   **CTimeSpan( const CTimeSpan& );** Constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object from another <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> value.  
  
-   **CTimeSpan( __time64_t );** Constructs a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object from a **__time64_t** type.  
  
-   **CTimeSpan( LONG**, **int, int, int );** Constructs a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object from components with each component constrained to the following ranges:  
  
    |Component|Range|  
    |---------------|-----------|  
    |<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|0–25,000 (approximately)|  
    |<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|0–23|  
    |<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|0–59|  
    |<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|0–59|  
  
 Note that the Debug version of the Microsoft Foundation Class Library asserts if one or more of the time-day components is out of range. It is your responsibility to validate the arguments prior to calling.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#162](../vs140/codesnippet/CPP/ctimespan--ctimespan_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTimeSpan Class](../vs140/ctimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)