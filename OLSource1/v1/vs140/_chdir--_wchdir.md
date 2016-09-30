---
title: "_chdir, _wchdir"
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
  - "_wchdir"
  - "_chdir"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "tchdir"
  - "_chdir"
  - "_wchdir"
  - "_tchdir"
  - "wchdir"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tchdir function"
  - "_chdir function"
  - "_wchdir function"
  - "tchdir function"
  - "wchdir function"
  - "chdir function"
  - "directories [C++], changing"
ms.assetid: 85e9393b-62ac-45d5-ab2a-fa2217f6152e
caps.latest.revision: 24
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _chdir, _wchdir
Changes the current working directory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Path of new working directory.  
  
## Return Value  
 These functions return a value of 0 if successful. A return value of –1 indicates failure. If the specified path could not be found, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is NULL, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and the function returns -1.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function changes the current working directory to the directory specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter must refer to an existing directory. This function can change the current working directory on any drive. If a new drive letter is specified in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the default drive letter is changed as well. For example, if A is the default drive letter and \BIN is the current working directory, the following call changes the current working directory for drive C and establishes C as the new default drive:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When you use the optional backslash character (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) in paths, you must place two backslashes (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) in a C string literal to represent a single backslash (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a wide-character string<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> behave identically otherwise.  
  
### Generic-Text Routine Mapping:  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<direct.h>|\<errno.h>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<direct.h> or \<wchar.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Volume in drive C has no label.**  
 **Volume Serial Number is 2018-08A1**  
 **Directory of c:\windows**  
**08/29/2002  04:00 AM         1,004,032 explorer.exe**  
**12/17/2002  04:43 PM            10,752 hh.exe**  
**03/03/2003  09:24 AM            33,792 ieuninst.exe**  
**10/29/1998  04:45 PM           306,688 IsUninst.exe**  
**08/29/2002  04:00 AM            66,048 NOTEPAD.EXE**  
**03/03/2003  09:24 AM            33,792 Q330994.exe**  
**08/29/2002  04:00 AM           134,144 regedit.exe**  
**02/28/2003  06:26 PM            46,352 setdebug.exe**  
**08/29/2002  04:00 AM            15,360 TASKMAN.EXE**  
**08/29/2002  04:00 AM            49,680 twunk_16.exe**  
**08/29/2002  04:00 AM            25,600 twunk_32.exe**  
**08/29/2002  04:00 AM           256,192 winhelp.exe**  
**08/29/2002  04:00 AM           266,752 winhlp32.exe**  
 **13 File(s)      2,249,184 bytes**  
 **0 Dir(s)  67,326,029,824 bytes free**   
## .NET Framework Equivalent  
 [System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)  
  
## See Also  
 [Directory Control](../vs140/directory-control.md)   
 [_mkdir, _wmkdir](../vs140/_mkdir--_wmkdir.md)   
 [_rmdir, _wrmdir](../vs140/_rmdir--_wrmdir.md)   
 [system, _wsystem](../vs140/system--_wsystem.md)