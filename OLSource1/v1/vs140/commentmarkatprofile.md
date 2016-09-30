---
title: "CommentMarkAtProfile"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "CommentMarkAtProfile"
  - "CommentMarkAtProfileA"
ms.assetid: 04294ca3-bf9c-4c76-86f1-898c2140de27
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CommentMarkAtProfile
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method inserts a timestamp value, a numeric mark, and a comment string in the .vsp file. The timestamp value can be used to synchronize external events. For the mark and comment to be inserted, profiling for the thread that contains the CommentMarkAtProfile function must be ON.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 A 64-bit integer that represents a timestamp value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The numeric marker to insert. The marker must greater than or equal to 0 (zero).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 A pointer to the text string to insert. The string must be less than 256 characters including the NULL terminator.  
  
## Property Value/Return Value  
 The function indicates success or failure by using **PROFILE_COMMAND_STATUS** enumeration. The return value can be one of the following:  
  
|Enumerator|Description|  
|----------------|-----------------|  
|MARK_ERROR_MARKER_RESERVED|The parameter is less than or equal to 0. These values are reserved. The mark and comment are not recorded.|  
|MARK_ERROR_MODE_NEVER|The profiling mode was set to NEVER when the function was called. The mark and comment are not recorded.|  
|MARK_ERROR_MODE_OFF|The profiling mode was set to OFF when the function was called. The mark and comment are not recorded.|  
|MARK_ERROR_NO_SUPPORT|No mark support in this context. The mark and comment are not recorded.|  
|MARK_ERROR_OUTOFMEMORY|Memory was not available to record the event. The mark and comment are not recorded.|  
|MARK_TEXTTOOLONG|The string exceeds the maximum of 256 characters. The comment string is truncated and the mark and comment are recorded.|  
|MARK_OK|MARK_OK is returned to indicate success.|  
  
## Remarks  
 The profiling state for the thread that contains the mark profile function must be on when marks and comments inserted with the Mark command or with API functions (CommentMarkAtProfile, CommentMarkProfile, or MarkProfile). Profile marks are global in scope. For example, a profile mark inserted in one thread can be used to mark the start or end of a data segment in any thread in the .vsp file.  
  
> [!IMPORTANT]
>  CommentMarkAtProfile methods should be used with instrumentation only.  
  
## .NET Framework Equivalent  
 Microsoft.VisualStudio.Profiler.dll  
  
## Function Information  
  
|||  
|-|-|  
|**Header**|Include VSPerf.h|  
|**Library**|Use VSPerf.lib|  
|**Unicode**|Implemented as CommentMarkAtProfileW (Unicode) and CommentMarkAtProfileA (ANSI).|  
  
## Example  
 The following code illustrates the use of the CommentMarkAtProfile generic function call. The example assumes the use of Win32 string macros and the compiler settings for ANSI to determine whether the code calls the ANSI enabled function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Profiler API Reference (Native)](../vs140/visual-studio-profiler-api-reference--native-.md)