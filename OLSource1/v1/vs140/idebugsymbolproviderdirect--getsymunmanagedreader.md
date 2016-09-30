---
title: "IDebugSymbolProviderDirect::GetSymUnmanagedReader"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "GetSymUnmanagedReader"
  - "IDebugSymbolProviderDirect::GetSymUnmanagedReader"
ms.assetid: 147bacfa-f66c-43e0-8a72-e601058dc57f
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProviderDirect::GetSymUnmanagedReader
Retrieves a symbol reader for unmanaged code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Identifier of the application domain.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Unique identifier of the module.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns an object that represents the symbol reader for unmanaged code.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugSymbolProviderDirect](../vs140/idebugsymbolproviderdirect.md)