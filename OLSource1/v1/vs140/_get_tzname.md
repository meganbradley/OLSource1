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
  
```  
errno_t _get_tzname(  
    size_t* pReturnValue,  
    char* timeZoneName,  
    size_t sizeInBytes,  
    int index      
);  
```  
  
#### Parameters  
 [out] `pReturnValue`  
 The string length of `timeZoneName` including a NULL terminator.  
  
 [out] `timeZoneName`  
 The address of a character string for the representation of the time zone name or the daylight standard time zone name (DST), depending on `index`.  
  
 [in] `sizeInBytes`  
 The size of the `timeZoneName` character string in bytes.  
  
 [in] `index`  
 The index of one of the two time zone names to retrieve.  
  
## Return Value  
 Zero if successful, otherwise an `errno` type value.  
  
 If either `timeZoneName` is `NULL`, or `sizeInBytes` is zero or less than zero (but not both), an invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets `errno` to `EINVAL` and returns `EINVAL`.  
  
### Error Conditions  
  
|`pReturnValue`|`timeZoneName`|`sizeInBytes`|`index`|Return value|Contents of `timeZoneName`|  
|--------------------|--------------------|-------------------|-------------|------------------|--------------------------------|  
|size of TZ name|`NULL`|0|0 or 1|0|not modified|  
|size of TZ name|any|> 0|0 or 1|0|TZ name|  
|not modified|`NULL`|> 0|any|`EINVAL`|not modified|  
|not modified|any|zero|any|`EINVAL`|not modified|  
|not modified|any|> 0|> 1|`EINVAL`|not modified|  
  
## Remarks  
 The `_get_tzname` function retrieves the character string representation of the time zone name or the daylight standard time zone name (DST) into the address of `timeZoneName` depending on the index value, along with the size of the string in `pReturnValue`. If `timeZoneName` is `NULL` and `sizeInBytes` is zero, just the size of the string of either time zone in bytes is returned in `pReturnValue`. The index values must be either 0 for standard time zone or 1 for daylight standard time zone; any other values of index have undetermined results.  
  
### Index values  
  
|`index`|Contents of `timeZoneName`|`timeZoneName` default value|  
|-------------|--------------------------------|----------------------------------|  
|0|Time zone name|"PST"|  
|1|Daylight standard time zone name|"PDT"|  
|> 1 or < 0|`errno` set to `EINVAL`|not modified|  
  
 Unless the values are explicitly changed during run time, the default values are "PST" and "PDT" respectively.  The sizes of these character arrays are governed by `TZNAME_MAX` value.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_get_tzname`|<time.h>|  
  
 For more information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [Global Variables _doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md)   
 [_get_daylight](../vs140/_get_daylight.md)   
 [_get_dstbias](../vs140/_get_dstbias.md)   
 [_get_timezone](../vs140/_get_timezone.md)   
 [TZNAME_MAX](../vs140/tzname_max.md)