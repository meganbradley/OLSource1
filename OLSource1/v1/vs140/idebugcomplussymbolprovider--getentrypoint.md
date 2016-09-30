---
title: "IDebugComPlusSymbolProvider::GetEntryPoint"
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
  - "IDebugComPlusSymbolProvider::GetEntryPoint"
  - "GetEntryPoint"
ms.assetid: 9640e121-1da1-41f9-8e66-76efca36baf2
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider::GetEntryPoint
Retrieves the application entry point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Identifier for the application domain.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Unique identifier for the module.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns the entry point represented by an [IDebugAddress](../vs140/idebugaddress.md) interface.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md)