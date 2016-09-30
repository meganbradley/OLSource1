---
title: "IDebugComPlusSymbolProvider2::LoadSymbolsWithCorModule"
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
  - "IDebugComPlusSymbolProvider2::LoadSymbolsWithCorModule"
  - "LoadSymbolsWithCorModule"
ms.assetid: b6abf3a4-ce60-4e66-9637-82ce911148de
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider2::LoadSymbolsWithCorModule
Loads debug symbols given the **ICorDebugModule** object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Identifier of the application domain.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Unique identifier of the module.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Base memory address.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Object that contains the debug symbol metadata.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] Object that implements the [ICorDebugModule Interface](assetId:///32e4d6fa-e5a3-413e-9166-d5e2871d3114).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] Name of the module.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] Path to search for the symbol file.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider2](../vs140/idebugcomplussymbolprovider2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider2](../vs140/idebugcomplussymbolprovider2.md)