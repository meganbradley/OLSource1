---
title: "SYMBOL_SEARCH_INFO_FIELDS"
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
  - "SYMBOL_SEARCH_INFO_FIELDS"
helpviewer_keywords: 
  - "SYMBOL_SEARCH_INFO_FIELDS enumeration"
ms.assetid: bce35af0-722d-46d4-afa6-eaae598c51ff
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SYMBOL_SEARCH_INFO_FIELDS
Specifies the kind of symbol information to retrieve.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 SSIF_NONE  
 Indicates no flags  
  
 SSIF_VERBOSE_SEARCH_INFO  
 Returns all search paths used for finding symbols  
  
## Remarks  
 These flags are passed as a parameter to the [IDebugModule3::GetSymbolInfo](../vs140/idebugmodule3--getsymbolinfo.md) method to determine the amount of information returned.  
  
> [!NOTE]
>  Currently, only <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is supported, and it must be specified as the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. All other values return an error.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [IDebugModule3::GetSymbolInfo](../vs140/idebugmodule3--getsymbolinfo.md)