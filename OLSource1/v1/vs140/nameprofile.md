---
title: "NameProfile"
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
  - "NameProfile"
  - "NameProfileA"
ms.assetid: 1bb05441-c4ff-4323-9fef-f3924fba4430
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NameProfile
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function assigns a string to the specified process or thread.  
  
 The NameProfile API is available only for instrumentation profiling. The NameProfile API is not supported for sampling profiling.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The name of the profiling element. A name is invalid (resulting in NameProfileA return NAME_ERROR_INVALID_NAME) if:  
  
-   The pointer passed into NameProfileA is a NULL value  
  
-   The string data of pszName starts with a number  
  
-   The string data of pszName contains a space  
  
-   The string data of pszName contains any of the following characters: ,;.<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>Level<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>dwId<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>NameProfileW<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>NameProfileA` (ANSI).|  
  
## Example  
 The following code illustrates the NameProfile function call. The example assumes the use of Win32 string macros and the compiler settings for ANSI to determine whether the code calls the ANSI enabled function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Profiler API Reference (Native)](../vs140/visual-studio-profiler-api-reference--native-.md)