---
title: "Filename Search Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "file names [C++], searching for"
  - "_find function"
  - "wfind function"
  - "find function"
  - "_wfind function"
ms.assetid: 2bc2f8ef-44e4-4271-b3e8-666d36fde828
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Filename Search Functions
These functions search for and close searches for specified file names:  
  
-   [_findnext, _wfindnext](../vs140/75d97188-5add-4698-a46c-4c492378f0f8.md)  
  
-   [_findfirst, _wfindfirst](../vs140/9bb46d1a-b946-47de-845a-a0b109a33ead.md)  
  
-   [_findclose](../vs140/_findclose.md)  
  
## Remarks  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function provides information about the first instance of a file name that matches the file specified in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> argument. You can use in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> any combination of wildcard characters that is supported by the host operating system.  
  
 The functions return file information in a _<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure, which is defined in IO.h. Various functions in the family use many variations on the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure. The basic <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure includes the following elements:  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 File attribute.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Time of file creation (–1L for FAT file systems). This time is stored in UTC format. To convert to the local time, use [localtime_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Time of the last file access (–1L for FAT file systems). This time is stored in UTC format. To convert to the local time, use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Time of the last write to file. This time is stored in UTC format. To convert to the local time, use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Length of the file in bytes.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>[ <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>]  
 Null-terminated name of matched file or directory, without the path.  
  
 In file systems that do not support the creation and last access times of a file, such as the FAT system, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> fields are always –1L.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is defined in Stdlib.h as 260 bytes.  
  
 You cannot specify target attributes (such as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) to limit the find operation. These attributes are returned in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> structure and can have the following values (defined in IO.h). Users should not rely on these being the only values possible for the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> field.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Archive. Set whenever the file is changed and cleared by the **BACKUP** command. Value: 0x20.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Hidden file. Not generally seen with the DIR command, unless you use the **/AH** option. Returns information about normal files and files that have this attribute. Value: 0x02.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Normal. File has no other attributes set and can be read or written to without restriction. Value: 0x00.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Read-only. File cannot be opened for writing and a file that has the same name cannot be created. Value: 0x01.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Subdirectory. Value: 0x10.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 System file. Not ordinarily seen with the **DIR** command, unless the **/A** or **/A:S** option is used. Value: 0x04.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> finds the next name, if any, that matches the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> argument specified in an earlier call to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> argument should point to a structure initialized by the previous call to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. If a match is found, the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> structure contents are changed as described earlier. Otherwise, it is left unchanged. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> closes the specified search handle and releases all associated resources for both <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. The handle returned by either <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> must first be passed to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, before modification operations, such as deleting, can be performed on the directories that form the paths passed to them.  
  
 You can nest the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> functions. For example, if a call to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> finds the file that is a subdirectory, a new search can be initiated with another call to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> are wide-character versions of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. The structure argument of the wide-character versions has the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> data type, which is defined in IO.h and in Wchar.h. The fields of this data type are the same as those of the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> data type, except that in <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> the name field is of type <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> instead of type <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. Otherwise <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> behave identically to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> use the 64-bit time type. If you must use the old 32-bit time type, you can define <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. The versions of these functions that have the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> suffix in their names use the 32-bit time type, and those with the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> suffix use the 64-bit time type.  
  
 Functions <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> also behave identically to the 32-bit time type versions of these functions except they use and return 64-bit file lengths. Functions <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>use the 64-bit time type but use 32-bit file lengths. These functions use appropriate variations of the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> type in which the fields have different types for the time and the file size.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is actually a macro that evaluates to <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> is defined). The following table summarizes the variations on <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>:  
  
|Structure|Time type|File size type|  
|---------------|---------------|--------------------|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> (32 bits).  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Listing of .c files**  
**RDO HID SYS ARC  FILE         DATE                           SIZE**  
**--- --- --- ---  ----         ----                           ----**  
 **N   N   N   Y   blah.c       Wed Feb 13 09:21:42 2002       1715**  
 **N   N   N   Y   test.c       Wed Feb 06 14:30:44 2002        312**   
## See Also  
 [System Calls](../vs140/system-calls.md)