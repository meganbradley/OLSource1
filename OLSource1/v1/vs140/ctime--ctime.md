---
title: "CTime::CTime"
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
  - "ATL::CTime::CTime"
  - "CTime.CTime"
  - "CTime::CTime"
  - "ATL.CTime.CTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTime class, construction/destruction"
  - "CTime class, constructor"
ms.assetid: 61e1df48-a59f-44cd-a3ad-f2a1308da3da
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::CTime
Creates a new <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object initialized with the specified time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Indicates a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that already exists.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A **__time64_t** time value, which is the number of seconds after January 1, 1970 UTC. Note that this will be adjusted to your local time. For example, if you are in New York and create a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object by passing a parameter of 0, [CTime::GetMonth](../vs140/ctime--getmonth.md) will return 12.  
  
 In Visual C++ versions 6.0 and earlier, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> was a value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Visual C++ .NET and later converts a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter to **__time64_t**.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Indicates the date and time values to be copied into the new <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Indicates whether daylight savings time is in effect. Can have one of three values:  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> set to 0   Standard time is in effect.  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> set to a value greater than 0   Daylight savings time is in effect.  
  
-   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> set to a value less than 0   The default. Automatically computes whether standard time or daylight savings time is in effect.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 MS-DOS date and time values to be converted to a date/time value and copied into the new <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A [SYSTEMTIME](../vs140/systemtime-structure.md) structure to be converted to a date/time value and copied into the new <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A [FILETIME](../vs140/filetime-structure.md) structure to be converted to a date/time value and copied into the new <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
 dbts  
 A reference to a \<xref:System.Data.OleDb.OleDbType.DBTimeStamp*> structure containing the current local time.  
  
## Remarks  
 Each constructor is described below:  
  
-   **CTime( );** Constructs an uninitialized <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object. This constructor allows you to define <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object arrays. You should initialize such arrays with valid times before using.  
  
-   **CTime( const CTime& );** Constructs a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object from another <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> value.  
  
-   **CTime( __time64_t );** Constructs a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object from a **__time64_t** type. This constructor expects a UTC time and converts the result to a local time before storing the result.  
  
-   **CTime( int, int, ...);** Constructs a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object from local time components with each component constrained to the following ranges:  
  
    |Component|Range|  
    |---------------|-----------|  
    |<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|1970–3000|  
    |<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|1–12|  
    |<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|1–31|  
    |<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|0-23|  
    |<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|0-59|  
    |<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|0-59|  
  
     This constructor makes the appropriate conversion to UTC. The Debug version of the Microsoft Foundation Class Library asserts if one or more of the time components are out of range. You must validate the arguments before calling. This constructor expects a local time.  
  
-   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>( **WORD, WORD** )**;** Constructs a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object from the specified MS-DOS date and time values. This constructor expects a local time.  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>( **const SYSTEMTIME&** )**;** Constructs a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> structure. This constructor expects a local time.  
  
-   <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>( **const FILETIME&** )**;** Constructs a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> structure. You most likely will not use <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> initialization directly. If you use a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object to manipulate a file, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> retrieves the file time stamp for you through a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object initialized with a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> structure. This constructor assumes a time based on UTC and automatically converts the value to local time before storing the result.  
  
    > [!NOTE]
    >  The constructor using **DBTIMESTAMP** parameter is only available when OLEDB.h is included.  
  
 For more information, see the [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) and [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. Also see the [MS-DOS Date and Time](http://msdn.microsoft.com/library/windows/desktop/ms724503) entry in the [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)].  
  
## Example  
 [!CODE [NVC_ATLMFC_Utilities#148](NVC_ATLMFC_Utilities#148)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTime::GetTime](../vs140/ctime--gettime.md)   
 [CTime::GetCurrentTime](../vs140/ctime--getcurrenttime.md)   
 [CTime::operator =](../vs140/ctime--operator-=.md)