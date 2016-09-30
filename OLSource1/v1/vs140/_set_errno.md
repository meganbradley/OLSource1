---
title: "_set_errno"
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
  - "_set_errno"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "set_errno"
  - "_set_errno"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "errno global variable"
  - "set_errno function"
  - "_set_errno function"
ms.assetid: d338914a-1894-4cf3-ae45-f2c4eb26590b
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _set_errno
Set the value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> global variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The new value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns zero if successful.  
  
## Remarks  
 Possible values are defined in Errno.h. Also, see [errno Constants](../vs140/errno-constants.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Oops: Illegal byte sequence**   
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|\<stdlib.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [_get_errno](../vs140/_get_errno.md)   
 [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md)