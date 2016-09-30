---
title: "_mkdir, _wmkdir"
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
  - "_wmkdir"
  - "_mkdir"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mkdir"
  - "tmkdir"
  - "_tmkdir"
  - "wmkdir"
  - "_wmkdir"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wmkdir function"
  - "folders [C++], creating"
  - "wmkdir function"
  - "directories [C++], creating"
  - "mkdir function"
  - "tmkdir function"
  - "_mkdir function"
  - "_tmkdir function"
ms.assetid: 7f22d01d-63a5-4712-a6e7-d34878b2d840
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mkdir, _wmkdir
Creates a new directory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Path for a new directory.  
  
## Return Value  
 Each of these functions returns the value 0 if the new directory was created. On an error, the function returns –1 and sets <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> as follows.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Directory was not created because <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the name of an existing file, directory, or device.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Path was not found.  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function creates a new directory with the specified *dirname.* <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> can create only one new directory per call, so only the last component of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> can name a new directory. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> does not translate path delimiters. In Windows NT, both the backslash ( \\) and the forward slash (/ ) are valid path delimiters in character strings in run-time routines.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<direct.h>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<direct.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::IO::Directory::CreateDirectory](https://msdn.microsoft.com/en-us/library/system.io.directory.createdirectory.aspx)  
  
-   [System::IO::DirectoryInfo::CreateSubdirectory](https://msdn.microsoft.com/en-us/library/system.io.directoryinfo.createsubdirectory.aspx)  
  
## See Also  
 [Directory Control](../vs140/directory-control.md)   
 [_chdir, _wchdir](../vs140/_chdir--_wchdir.md)   
 [_rmdir, _wrmdir](../vs140/_rmdir--_wrmdir.md)