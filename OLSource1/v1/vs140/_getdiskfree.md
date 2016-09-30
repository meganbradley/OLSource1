---
title: "_getdiskfree"
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
  - "_getdiskfree"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "getdiskfree"
  - "_getdiskfree"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "diskfree_t type"
  - "_getdiskfree function"
  - "_diskfree_t type"
  - "disk size"
  - "getdiskfree function"
ms.assetid: 47a3f6cf-4816-452a-8f3d-1c3ae02a0f2a
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _getdiskfree
Uses information about a disk drive to populate a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The disk drive for which you want information.  
  
 [out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure that will be populated with information about the drive.  
  
## Return Value  
 If the function succeeds, the return value is zero. If the function fails, the return value is the error code. The value <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set for any errors that are returned by the operating system. For more information about error conditions that are indicated by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, see [errno Constants](../vs140/errno-constants.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure is defined in Direct.h.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This function validates its parameters. If the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> pointer is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> specifies an invalid drive, this function invokes an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Valid drives range from 0 to 26. A <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value of 0 specifies the current drive; thereafter, numbers map to letters of the English alphabet such that 1 indicates drive A, 3 indicates drive C, and so on.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The total number of clusters, both used and available, on the disk.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The number of unused clusters on the disk.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The number of sectors in each cluster.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The size of each sector in bytes.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<direct.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **======================================================================**  
**&#124;DRIVE&#124;TOTAL CLUSTERS&#124;AVAIL CLUSTERS&#124;SECTORS / CLUSTER&#124;BYTES / SECTOR&#124;**  
**&#124;=====&#124;==============&#124;==============&#124;=================&#124;==============&#124;**  
**&#124;  A: &#124; The device is not ready.    &#124;                 &#124;              &#124;**  
**&#124;  C: &#124;    4,721,093 &#124;    3,778,303 &#124;               8 &#124;          512 &#124;**  
**&#124;  D: &#124;    1,956,097 &#124;    1,800,761 &#124;               8 &#124;          512 &#124;**  
**&#124;  E: &#124; The device is not ready.    &#124;                 &#124;              &#124;**  
**======================================================================**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Directory Control](../vs140/directory-control.md)