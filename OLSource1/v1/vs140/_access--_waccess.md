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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _access, _waccess
Determines if a file is read-only or not. More secure versions are available; see [_access_s, _waccess_s](../vs140/_access_s--_waccess_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 File or directory path.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Read/write attribute.  
  
## Return Value  
 Each function returns 0 if the file has the given mode. The function returns –1 if the named file does not exist or does not have the given mode; in this case, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is set as shown in the following table.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Access denied: the file's permission setting does not allow specified access.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 File name or path not found.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Invalid parameter.  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 When used with files, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function determines whether the specified file or directory exists and has the attributes specified by the value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. When used with directories, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> determines only whether the specified directory exists; in [!INCLUDE[win2kfamily](../vs140/includes/win2kfamily_md.md)] and later operating systems, all directories have read and write access.  
  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> value|Checks file for|  
|------------------|---------------------|  
|00|Existence only|  
|02|Write-only|  
|04|Read-only|  
|06|Read and write|  
  
 This function only checks whether the file and directory are read-only or not, it does not check the filesystem security settings. For that you need an access token. For more information on filesystem security, see [Access Tokens](http://msdn.microsoft.com/library/windows/desktop/aa374909). An ATL class exists to provide this functionality; see [CAccessToken Class](../vs140/caccesstoken-class.md).  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> behave identically otherwise.  
  
 This function validates its parameters. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> does not specify a valid mode, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function sets <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and returns -1.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|Optional headers|  
|-------------|---------------------|----------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<io.h>|\<errno.h>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<wchar.h> or \<io.h>|\<errno.h>|  
  
## Example  
 The following example uses <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to check the file named crt_ACCESS.C to see whether it exists and whether writing is allowed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **File crt_ACCESS.C exists.**  
**File crt_ACCESS.C does not have write permission.**   
## .NET Framework Equivalent  
 \<xref:System.IO.FileAccess*?displayProperty=fullName>  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_chmod, _wchmod](../vs140/_chmod--_wchmod.md)   
 [_fstat, _fstat32, _fstat64, _fstati64, _fstat32i64, _fstat64i32](../vs140/_fstat--_fstat32--_fstat64--_fstati64--_fstat32i64--_fstat64i32.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_stat, _wstat Functions](../vs140/99a75ae6-ff26-47ad-af70-5ea7e17226a5.md)