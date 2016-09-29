---
title: "COleDateTimeSpan::SetStatus"
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
  - "COleDateTimeSpan::SetStatus"
  - "ATL::COleDateTimeSpan::SetStatus"
  - "COleDateTimeSpan.SetStatus"
  - "ATL.COleDateTimeSpan.SetStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetStatus method"
  - "DateTimeSpanStatus method"
ms.assetid: 4d84e81d-7e9f-4e82-8d85-6820fc4554d5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan::SetStatus
Sets the status (validity) of this `COleDateTimeSpan` object.  
  
## Syntax  
  
```  
  
      void SetStatus(  
   DateTimeSpanStatus status   
) throw( );  
```  
  
#### Parameters  
 *status*  
 The new status value for this `COleDateTimeSpan` object.  
  
## Remarks  
 The *Status* parameter value is defined by the **DateTimeSpanStatus** enumerated type, which is defined within the `COleDateTimeSpan` class.  
  
 `enum DateTimeSpanStatus{`  
  
 `valid = 0,`  
  
 `invalid = 1,`  
  
 `null = 2,`  
  
 `};`  
  
 For a brief description of these status values, see the following list:  
  
-   **COleDateTimeSpan::valid** Indicates that this `COleDateTimeSpan` object is valid.  
  
-   **COleDateTimeSpan::invalid** Indicates that this `COleDateTimeSpan` object is invalid; that is, its value may be incorrect.  
  
-   **COleDateTimeSpan::null** Indicates that this `COleDateTimeSpan` object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++ **NULL**.)  
  
    > [!CAUTION]
    >  This function is for advanced programming situations. This function does not alter the data in this object. It will most often be used to set the status to `null` or **invalid**. Note that the assignment operator ([operator =](../vs140/coledatetimespan--operator-=.md)) and [SetDateTimeSpan](../vs140/coledatetimespan--setdatetimespan.md) do set the status of the object based on the source value(s).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#22](../vs140/codesnippet/CPP/coledatetimespan--setstatus_1.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::GetStatus](../vs140/coledatetimespan--getstatus.md)   
 [COleDateTimeSpan::m_status](../vs140/coledatetimespan--m_status.md)