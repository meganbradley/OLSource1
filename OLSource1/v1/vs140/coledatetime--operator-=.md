---
title: "COleDateTime::operator ="
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
  - "COleDateTime::operator="
  - "COleDateTime.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, date time"
  - "operator=, date time"
  - "COleDateTime class, operators"
  - "= operator, with specific MFC objects"
ms.assetid: f2d544bf-85ad-4da7-9cea-7d7e35925a83
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::operator =
Copies a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 These overloaded assignment operators copy the source date/time value into this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object. A brief description of each these overloaded assignment operators follows:  
  
-   **operator =(**  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  **)** The value and status of the operand are copied into this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
-   **operator =(**  *varSrc*  **)** If the conversion of the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) value (or [COleVariant](../vs140/colevariant-class.md) object) to a date/time (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) is successful, the converted value is copied into this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object and its status is set to valid. If the conversion is not successful, the value of this object is set to zero (30 December 1899, midnight) and its status to invalid.  
  
-   **operator =(** <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> **)** The **DATE** value is copied into this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object and its status is set to valid.  
  
-   **operator =(** <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **)** The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or **__time64_t** value is converted and copied into this <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object. If the conversion is successful, the status of this object is set to valid; if unsuccessful, it is set to invalid.  
  
-   **operator =(** *systimeSrc* **)** The [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) value is converted and copied into this <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object. If the conversion is successful, the status of this object is set to valid; if unsuccessful, it is set to invalid.  
  
-   **operator =(** <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> **)** The **UDATE** value is converted and copied into this <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object. If the conversion is successful, the status of this object is set to valid; if unsuccessful, it is set to invalid. A **UDATE** structure represents an "unpacked" date. See the function [VarDateFromUdate](assetId:///1c924ac5-b896-49e1-9ccf-825ac7a030c8) for more details.  
  
-   **operator =(** <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> **)** The [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) value is converted and copied into this <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object. If the conversion is successful, the status of this object is set to valid; otherwise it is set to invalid. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> uses Universal Coordinated Time (UTC), so if you pass a UTC time in the structure, your results will be converted from UTC time to local time, and will be stored as variant time. This behavior is the same as in Visual C++ 6.0 and Visual C++.NET 2003 SP2. See [File Times](http://msdn.microsoft.com/library/windows/desktop/ms724290) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 For more information, see the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) entry in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information on the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> data type, see the [time](../vs140/time--_time32--_time64.md) function in the *Run-Time Library Reference*.  
  
 For more information, see the [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) and [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information about the bounds for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::COleDateTime](../vs140/coledatetime--coledatetime.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)