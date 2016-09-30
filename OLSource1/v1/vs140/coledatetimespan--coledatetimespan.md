---
title: "COleDateTimeSpan::COleDateTimeSpan"
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
  - "ATL::COleDateTimeSpan::COleDateTimeSpan"
  - "COleDateTimeSpan.COleDateTimeSpan"
  - "COleDateTimeSpan::COleDateTimeSpan"
  - "ATL.COleDateTimeSpan.COleDateTimeSpan"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDateTimeSpan class, constructor"
ms.assetid: 6bf5e93f-3485-4bdc-a669-52e818ed4dc0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan::COleDateTimeSpan
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of days to be copied into the new <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Indicate the day and time values to be copied into the new <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
## Remarks  
 All of these constructors create new <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> objects initialized to the specified value. A brief description of each of these constructors follows:  
  
-   **COleDateTimeSpan( )** Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object initialized to 0.  
  
-   **COleDateTimeSpan(** <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> **)** Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object from a floating-point value.  
  
-   **COleDateTimeSpan(** <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> **)** Constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object initialized to the specified numerical values.  
  
 The status of the new <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object is set to valid.  
  
 For more information about the bounds for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#14](../vs140/codesnippet/CPP/coledatetimespan--coledatetimespan_1.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::operator =](../vs140/coledatetimespan--operator-=.md)   
 [COleDateTimeSpan::GetStatus](../vs140/coledatetimespan--getstatus.md)   
 [COleDateTimeSpan::m_span](../vs140/coledatetimespan--m_span.md)   
 [COleDateTimeSpan::m_status](../vs140/coledatetimespan--m_status.md)