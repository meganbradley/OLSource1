---
title: "IDebugModule3::GetSymbolInfo"
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
  - "IDebugModule3::GetSymbolInfo"
helpviewer_keywords: 
  - "GetSymbolInfo method"
  - "IDebugModule3::GetSymbolInfo method"
ms.assetid: dda5e8e1-6878-4aa9-9ee4-e7d0dcc11210
caps.latest.revision: 21
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugModule3::GetSymbolInfo
Retrieves a list of paths that are searched for symbols as well as the results of searching each path.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [SYMBOL_SEARCH_INFO_FIELDS](../vs140/symbol_search_info_fields.md) enumeration specifying which fields of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are to be filled in.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] A [MODULE_SYMBOL_SEARCH_INFO](../vs140/module_symbol_search_info.md) structure whose members are to be filled in with the specified information. If this is a null value, this method returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 If the method succeeds, it returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, it returns an error code.  
  
> [!NOTE]
>  The returned string (in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure) could be empty even if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is returned. In this case, there was no search information to return.  
  
## Remarks  
 If the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure is not empty, then it contains a list of paths searched and the results of that search. The list is formatted with a path, followed by ellipses ("..."), followed by the result. If there is more than one path result pair, then each pair is separated by a "\r\n" (carriage-return/linefeed) pair. The pattern looks like this:  
  
 \<path>...\<result>\r\n\<path>...\<result>\r\n\<path>...\<result>  
  
 Note that the last entry does not have a \r\n sequence.  
  
## Example  
 In this example, this method returns three paths with three different search results. Each line is terminated with a carriage-return/linefeed pair. The example output just prints the search results as a single string.  
  
> [!NOTE]
>  A status result is everything immediately following the "..." up to the end of the line.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **c:\symbols\user32.pdb... File not found.**  
**c:\winnt\symbols\user32.pdb... Version does not match.**  
**\\\symbols\symbols\user32.dll\0a8sd0ad8ad\user32.pdb... Symbols loaded.**   
## See Also  
 [SYMBOL_SEARCH_INFO_FIELDS](../vs140/symbol_search_info_fields.md)   
 [MODULE_SYMBOL_SEARCH_INFO](../vs140/module_symbol_search_info.md)   
 [IDebugModule3](../vs140/idebugmodule3.md)