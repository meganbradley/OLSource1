---
title: "_get_tzname"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_get_tzname"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_get_tzname"
  - "get_tzname"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_get_tzname function"
  - "time zones"
  - "get_tzname function"
ms.assetid: df0065ff-095f-4237-832c-2fe9ab913875
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _get_tzname
Retrieves the character string representation of the time zone name or the daylight standard time zone name (DST).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The string length of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> including a NULL terminator.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The address of a character string for the representation of the time zone name or the daylight standard time zone name (DST), depending on <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The size of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> character string in bytes.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The index of one of the two time zone names to retrieve.  
  
## Return Value  
 Zero if successful, otherwise an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> type value.  
  
 If either <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is zero or less than zero (but not both), an invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Return value|Contents of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|--------------------|--------------------|-------------------|-------------|------------------|--------------------------------|  
|size of TZ name|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|0|0 or 1|0|not modified|  
|size of TZ name|any|> 0|0 or 1|0|TZ name|  
|not modified|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|> 0|any|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|not modified|  
|not modified|any|zero|any|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|not modified|  
|not modified|any|> 0|> 1|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|not modified|  
  
## Remarks  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> function retrieves the character string representation of the time zone name or the daylight standard time zone name (DST) into the address of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> depending on the index value, along with the size of the string in <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is zero, just the size of the string of either time zone in bytes is returned in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. The index values must be either 0 for standard time zone or 1 for daylight standard time zone; any other values of index have undetermined results.  
  
### Index values  
  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Contents of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> default value|  
|-------------|--------------------------------|----------------------------------|  
|0|Time zone name|"PST"|  
|1|Daylight standard time zone name|"PDT"|  
|> 1 or < 0|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|not modified|  
  
 Unless the values are explicitly changed during run time, the default values are "PST" and "PDT" respectively.  The sizes of these character arrays are governed by <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> value.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<time.h>|  
  
 For more information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [Global Variables _doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md)   
 [_get_daylight](../vs140/_get_daylight.md)   
 [_get_dstbias](../vs140/_get_dstbias.md)   
 [_get_timezone](../vs140/_get_timezone.md)   
 [TZNAME_MAX](../vs140/tzname_max.md)