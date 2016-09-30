---
title: "COleDateTime::GetStatus"
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
  - "ATL.COleDateTime.GetStatus"
  - "COleDateTime::GetStatus"
  - "COleDateTime.GetStatus"
  - "ATL::COleDateTime::GetStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DateTimeStatus method"
  - "GetStatus method"
ms.assetid: b9047549-c616-4cbc-9709-8b3ddd6b19d7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::GetStatus
Gets the status (validity) of a given <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the status of this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value. If you call **GetStatus** on a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object constructed with the default, it will return valid. If you call **GetStatus** on a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object initialized with the constructor set to null, **GetStatus** will return null. See **Remarks** for more information.  
  
## Remarks  
 The return value is defined by the **DateTimeStatus** enumerated type, which is defined within the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 For a brief description of these status values, see the following list:  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> Indicates that an error occurred while attempting to obtain part of the date/time value.  
  
-   **COleDateTime::valid** Indicates that this <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object is valid.  
  
-   **COleDateTime::invalid** Indicates that this <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object is invalid; that is, its value may be incorrect.  
  
-   **COleDateTime::null** Indicates that this <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++ **NULL**.)  
  
 The status of a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object is invalid in the following cases:  
  
-   If its value is set from a **VARIANT** or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> value that could not be converted to a date/time value.  
  
-   If its value is set from a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> value that could not be converted to a valid date/time value.  
  
-   If its value is set by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> with invalid parameter values.  
  
-   If this object has experienced an overflow or underflow during an arithmetic assignment operation, namely, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
-   If an invalid value was assigned to this object.  
  
-   If the status of this object was explicitly set to invalid using <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 For more information about the operations that may set the status to invalid, see the following member functions:  
  
-   [COleDateTime](../vs140/coledatetime--coledatetime.md)  
  
-   [SetDateTime](../vs140/coledatetime--setdatetime.md)  
  
-   [operator +, -](../vs140/coledatetime--operator-----.md)  
  
-   [operator +=, -=](../vs140/coledatetime--operator--=---=.md)  
  
 For more information about the bounds for <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#10](../vs140/codesnippet/CPP/coledatetime--getstatus_1.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::SetStatus](../vs140/coledatetime--setstatus.md)   
 [COleDateTime::m_status](../vs140/coledatetime--m_status.md)