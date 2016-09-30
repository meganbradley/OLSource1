---
title: "COleDateTimeSpan::Format"
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
  - "COleDateTimeSpan.Format"
  - "COleDateTimeSpan::Format"
  - "ATL.COleDateTimeSpan.Format"
  - "ATL::COleDateTimeSpan::Format"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Format method"
ms.assetid: 2f547357-a92d-4d2f-bbe7-e1db08d70f20
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan::Format
Generates a formatted string representation of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A formatting string similar to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> formatting string. Formatting codes, preceded by a percent (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) sign, are replaced by the corresponding <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> component. Other characters in the formatting string are copied unchanged to the returned string. The value and meaning of the formatting codes for **Format** are listed below:  
  
-   **%H** Hours in the current day  
  
-   **%M** Minutes in the current hour  
  
-   **%S** Seconds in the current minute  
  
-   **%%** Percent sign  
  
 The four format codes listed above are the only codes that Format will accept.  
  
-  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The resource ID for the format-control string.  
  
## Return Value  
 A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that contains the formatted date/time-span value.  
  
## Remarks  
 Call these functions to create a formatted representation of the time-span value. If the status of this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is null, the return value is an empty string. If the status is invalid, the return string is specified by the string resource **IDS_INVALID_DATETIMESPAN**.  
  
 A brief description of the forms for this function follows:  
  
 **Format(**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  **)**  
 This form formats the value using the format string that contains special formatting codes that are preceded by a percent sign (%), as in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The formatting string is passed as a parameter to the function.  
  
 **Format(**  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  **)**  
 This form formats the value using the format string that contains special formatting codes that are preceded by a percent sign (%), as in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The formatting string is a resource. The ID of this string resource is passed as the parameter.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#15](../vs140/codesnippet/CPP/coledatetimespan--format_1.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::GetStatus](../vs140/coledatetimespan--getstatus.md)