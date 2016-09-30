---
title: "COleDateTimeSpan::m_status"
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
  - "COleDateTimeSpan.m_status"
  - "COleDateTimeSpan::m_status"
  - "m_status"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDateTimeSpan class, data members"
  - "DateTimeSpanStatus method"
  - "m_status"
ms.assetid: b34764f1-d070-4597-8a05-cec0510017e9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan::m_status
The type for this data member is the enumerated type **DateTimeSpanStatus**, which is defined within the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 For a brief description of these status values, see the following list:  
  
-   **COleDateTimeSpan::valid** Indicates that this <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is valid.  
  
-   **COleDateTimeSpan::invalid** Indicates that this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is invalid; that is, its value may be incorrect.  
  
-   **COleDateTimeSpan::null** Indicates that this <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++ **NULL**.)  
  
 The status of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is invalid in the following cases:  
  
-   If this object has experienced an overflow or underflow during an arithmetic assignment operation, namely, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
-   If an invalid value was assigned to this object.  
  
-   If the status of this object was explicitly set to invalid using [SetStatus](../vs140/coledatetimespan--setstatus.md).  
  
 For more information about the operations that may set the status to invalid, see [COleDateTimeSpan::operator +, -](../vs140/coledatetime--operator-----.md) and [COleDateTimeSpan::operator +=, -=](../vs140/coledatetime--operator--=---=.md).  
  
> [!CAUTION]
>  This data member is for advanced programming situations. You should use the inline member functions [GetStatus](../vs140/coledatetimespan--getstatus.md) and [SetStatus](../vs140/coledatetimespan--setstatus.md). See <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for further cautions regarding explicitly setting this data member.  
  
 For more information about the bounds for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::GetStatus](../vs140/coledatetimespan--getstatus.md)   
 [COleDateTimeSpan::SetStatus](../vs140/coledatetimespan--setstatus.md)