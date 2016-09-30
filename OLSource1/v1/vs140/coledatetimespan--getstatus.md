---
title: "COleDateTimeSpan::GetStatus"
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
  - "ATL.COleDateTimeSpan.GetStatus"
  - "COleDateTimeSpan::GetStatus"
  - "ATL::COleDateTimeSpan::GetStatus"
  - "COleDateTimeSpan.GetStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DateTimeSpanStatus method"
  - "GetStatus method"
ms.assetid: b90e9b9c-5ae2-41a4-97db-b2b85638a6ed
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan::GetStatus
Gets the status (validity) of this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The status of this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value.  
  
## Remarks  
 The return value is defined by the **DateTimeSpanStatus** enumerated type, which is defined within the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 For a brief description of these status values, see the following list:  
  
-   **COleDateTimeSpan::valid** Indicates that this <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object is valid.  
  
-   **COleDateTimeSpan::invalid** Indicates that this <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is invalid; that is, its value may be incorrect.  
  
-   **COleDateTimeSpan::null** Indicates that this <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++ **NULL**.)  
  
 The status of a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object is invalid in the following cases:  
  
-   If this object has experienced an overflow or underflow during an arithmetic assignment operation, namely, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
-   If an invalid value was assigned to this object.  
  
-   If the status of this object was explicitly set to invalid using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 For more information about the operations that may set the status to invalid, see [COleDateTimeSpan::operator +, -](../vs140/coledatetime--operator-----.md) and [COleDateTimeSpan::operator +=, -=](../vs140/coledatetime--operator--=---=.md).  
  
 For more information about the bounds for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::SetStatus](../vs140/coledatetimespan--setstatus.md)   
 [COleDateTimeSpan::m_status](../vs140/coledatetimespan--m_status.md)