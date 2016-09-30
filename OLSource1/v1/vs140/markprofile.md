---
title: "MarkProfile"
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
  - "MarkProfile"
ms.assetid: 54dac8c8-c8ee-4023-af27-b25466e3a6ec
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MarkProfile
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method inserts a profile mark in the .vsp file. Profiling for the thread containing the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function must be ON for the mark to be inserted.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The marker to insert. The marker must be greater than or equal to 0 (zero).  
  
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
 The mark value is inserted into the .vsp file each time the code runs if the thread containing the MarkProfile function is being profiled. You can call MarkProfile multiple times.  
  
 Profile marks are global in scope. For example, a profile mark inserted in one thread can be used to mark the start or end of a data segment in any thread in the .vsp file.  
  
 The profiling state for the thread that contains the mark profile function must be on when marks and comments inserted with the Mark command or with API functions (CommentMarkAtProfile, CommentMarkProfile, or MarkProfile).  
  
> [!IMPORTANT]
>  MarkProfile method should be used with instrumentation profiling only.  
  
## .NET Framework Equivalent  
 Microsoft.VisualStudio.Profiler.dll  
  
## Function Information  
 Header: Declared in VSPerf.h  
  
 Import library: VSPerf.lib  
  
## Example  
 The following code illustrates the MarkProfile function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Profiler API Reference (Native)](../vs140/visual-studio-profiler-api-reference--native-.md)