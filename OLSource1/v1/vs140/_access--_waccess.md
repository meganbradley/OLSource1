---
title: "_access, _waccess"
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
  - "_access"
  - "_waccess"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_waccess"
  - "_access"
  - "taccess"
  - "waccess"
  - "_taccess"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "access function"
  - "_taccess function"
  - "waccess function"
  - "_access function"
  - "_waccess function"
  - "taccess function"
ms.assetid: ba34f745-85c3-49e5-a7d4-3590bd249dd3
caps.latest.revision: 29
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _access, _waccess
Determines if a file is read-only or not. More secure versions are available; see [_access_s, _waccess_s](../vs140/_access_s--_waccess_s.md).  
  
## Syntax  
  
```  
int _access(   
   const char *path,   
   int mode   
);  
int _waccess(   
   const wchar_t *path,   
   int mode   
);  
```  
  
#### Parameters  
 `path`  
 File or directory path.  
  
 `mode`  
 Read/write attribute.  
  
## Return Value  
 Each function returns 0 if the file has the given mode. The function returns –1 if the named file does not exist or does not have the given mode; in this case, `errno` is set as shown in the following table.  
  
 `EACCES`  
 Access denied: the file's permission setting does not allow specified access.  
  
 `ENOENT`  
 File name or path not found.  
  
 `EINVAL`  
 Invalid parameter.  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 When used with files, the `_access` function determines whether the specified file or directory exists and has the attributes specified by the value of `mode`. When used with directories, `_access` determines only whether the specified directory exists; in [!INCLUDE[win2kfamily](../vs140/includes/win2kfamily_md.md)] and later operating systems, all directories have read and write access.  
  
|`mode` value|Checks file for|  
|------------------|---------------------|  
|00|Existence only|  
|02|Write-only|  
|04|Read-only|  
|06|Read and write|  
  
 This function only checks whether the file and directory are read-only or not, it does not check the filesystem security settings. For that you need an access token. For more information on filesystem security, see [Access Tokens](http://msdn.microsoft.com/library/windows/desktop/aa374909). An ATL class exists to provide this functionality; see [CAccessToken Class](../vs140/caccesstoken-class.md).  
  
 `_waccess` is a wide-character version of `_access`; the `path` argument to `_waccess` is a wide-character string. `_waccess` and `_access` behave identically otherwise.  
  
 This function validates its parameters. If `path` is `NULL` or `mode` does not specify a valid mode, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function sets `errno` to `EINVAL` and returns -1.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|`_taccess`|`_access`|`_access`|`_waccess`|  
  
## Requirements  
  
|Routine|Required header|Optional headers|  
|-------------|---------------------|----------------------|  
|`_access`|<io.h>|<errno.h>|  
|`_waccess`|<wchar.h> or <io.h>|<errno.h>|  
  
## Example  
 The following example uses `_access` to check the file named crt_ACCESS.C to see whether it exists and whether writing is allowed.  
  
```  
// crt_access.c  
// compile with: /W1  
// This example uses _access to check the file named  
// crt_ACCESS.C to see if it exists and if writing is allowed.  
  
#include  <io.h>  
#include  <stdio.h>  
#include  <stdlib.h>  
  
int main( void )  
{  
    // Check for existence.  
    if( (_access( "crt_ACCESS.C", 0 )) != -1 )  
    {  
        printf_s( "File crt_ACCESS.C exists.\n" );  
  
        // Check for write permission.  
        // Assume file is read-only.  
        if( (_access( "crt_ACCESS.C", 2 )) == -1 )  
            printf_s( "File crt_ACCESS.C does not have write permission.\n" );  
    }  
}  
```  
  
 **File crt_ACCESS.C exists.**  
**File crt_ACCESS.C does not have write permission.**   
## .NET Framework Equivalent  
 <xref:System.IO.FileAccess*?displayProperty=fullName>  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_chmod, _wchmod](../vs140/_chmod--_wchmod.md)   
 [_fstat, _fstat32, _fstat64, _fstati64, _fstat32i64, _fstat64i32](../vs140/_fstat--_fstat32--_fstat64--_fstati64--_fstat32i64--_fstat64i32.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_stat, _wstat Functions](../vs140/_stat--_stat32--_stat64--_stati64--_stat32i64--_stat64i32--_wstat--_wstat32--_wstat64--_wstati64--_wstat32i64--_wstat64i32.md)