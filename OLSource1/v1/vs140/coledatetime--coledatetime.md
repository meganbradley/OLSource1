---
title: "COleDateTime::COleDateTime"
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
  - "COleDateTime::COleDateTime"
  - "ATL::COleDateTime::COleDateTime"
  - "COleDateTime.COleDateTime"
  - "ATL.COleDateTime.COleDateTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDateTime class, constructor"
ms.assetid: 26e27628-0044-49d6-9aca-825d24a4e797
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::COleDateTime
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to be copied into the new <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 *varSrc*  
 An existing **VARIANT** data structure (possibly a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object) to be converted to a date/time value (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) and copied into the new <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A date/time (**DATE**) value to be copied into the new <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or **__time64_t** value to be converted to a date/time value and copied into the new <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
 *systimeSrc*  
 A <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> structure to be converted to a date/time value and copied into the new <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> structure to be converted to a date/time value and copied into the new <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object. Note that <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> uses Universal Coordinated Time (UTC), so if you pass a local time in the structure, your results will be incorrect. See [File Times](http://msdn.microsoft.com/library/windows/desktop/ms724290) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Indicate the date and time values to be copied into the new <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 MS-DOS date and time values to be converted to a date/time value and copied into the new <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A reference to a \<xref:System.Data.OleDb.OleDbType.DBTimeStamp*> structure containing the current local time.  
  
## Remarks  
 All these constructors create new <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> objects initialized to the specified value. The following table shows valid ranges for each date and time component:  
  
|Date/time component|Valid range|  
|--------------------------|-----------------|  
|year|100 – 9999|  
|month|0 – 12|  
|day|0 – 31|  
|hour|0 – 23|  
|minute|0 – 59|  
|second|0 – 59|  
  
 Note that the actual upper bound for the day component varies based on the month and year components. For details, see the **SetDate** or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> member functions.  
  
 Following is a brief description of each constructor:  
  
-   <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> **)** Constructs a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object initialized to 0 (midnight, 30 December 1899).  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> **)** Constructs a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object from an existing <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> *varSrc* **)** Constructs a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object. Attempts to convert a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> structure or [COleVariant](../vs140/colevariant-class.md) object to a date/time (<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>) value. If this conversion is successful, the converted value is copied into the new <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object. If it is not, the value of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object is set to 0 (midnight, 30 December 1899) and its status to invalid.  
  
-   <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> **)** Constructs a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object from a **DATE** value.  
  
-   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> **)** Constructs a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> value.  
  
-   <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> *systimeSrc* **)** Constructs a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> value.  
  
-   <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> **)** Constructs a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> value. . Note that <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> uses Universal Coordinated Time (UTC), so if you pass a local time in the structure, your results will be incorrect. See [File Times](http://msdn.microsoft.com/library/windows/desktop/ms724290) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
-   <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> **)** Constructs a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object from the specified numerical values.  
  
-   <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> **)** Constructs a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object from the specified MS-DOS date and time values.  
  
 For more information on the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> data type, see the [time](../vs140/time--_time32--_time64.md) function in the *Run-Time Library Reference*.  
  
 For more information, see the [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) and [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information about the bounds for <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
> [!NOTE]
>  The constructor using **DBTIMESTAMP** parameter is only available when OLEDB.h is included.  
  
## Example  
 [!CODE [NVC_ATLMFC_Utilities#2](NVC_ATLMFC_Utilities#2)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::SetDate](../vs140/coledatetime--setdate.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::SetTime](../vs140/coledatetime--settime.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)   
 [COleDateTime::operator =](../vs140/coledatetime--operator-=.md)   
 [COleDateTime::m_dt](../vs140/coledatetime--m_dt.md)   
 [COleDateTime::m_status](../vs140/coledatetime--m_status.md)