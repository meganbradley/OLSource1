---
title: "MODULE_SYMBOL_SEARCH_INFO"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "MODULE_SYMBOL_SEARCH_INFO"
helpviewer_keywords: 
  - "MODULE_SYMBOL_SEARCH_INFO structure"
ms.assetid: 432aff03-08a5-4c5a-b2d5-e212090fc70a
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# MODULE_SYMBOL_SEARCH_INFO
Contains status information about symbol search paths that have been searched.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A combination of flags from the [SYMBOL_SEARCH_INFO_FIELDS](../vs140/symbol_search_info_fields.md) enumeration specifying the kind of search information described in this structure.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Search path and results concatenated into a single string.  
  
## Remarks  
 This structure is returned from a call to the [IDebugModule3::GetSymbolInfo](../vs140/idebugmodule3--getsymbolinfo.md) method.  
  
 If the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> field is not empty, then it contains a list of paths searched and the results of that search. The list is formatted with a path, followed by ellipses ("..."), followed by the result. If there is more than one path result pair, then each pair is separated by a "\r\n" (carriage-return/linefeed) pair. The pattern looks like this:  
  
 \<path>...\<result>\r\n\<path>...\<result>\r\n\<path>...\<result>  
  
 Note that the last entry does not have a \r\n sequence.  
  
 Here is a possible <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> string that has been sent to standard out.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [IDebugModule3::GetSymbolInfo](../vs140/idebugmodule3--getsymbolinfo.md)