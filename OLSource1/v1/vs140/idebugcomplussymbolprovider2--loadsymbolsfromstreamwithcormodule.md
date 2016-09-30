---
title: "IDebugComPlusSymbolProvider2::LoadSymbolsFromStreamWithCorModule"
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
  - "IDebugComPlusSymbolProvider2::LoadSymbolsFromStreamWithCorModule"
  - "LoadSymbolsFromStreamWithCorModule"
ms.assetid: f79b894f-52c4-43c2-9a68-c71536451f6c
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider2::LoadSymbolsFromStreamWithCorModule
Load debug symbols from a data stream given the **ICorDebugModule** object.  
  
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
 [in] Object that contains the symbol metadata.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] Object that implements the [ICorDebugModule Interface](assetId:///32e4d6fa-e5a3-413e-9166-d5e2871d3114).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] Data stream that contains the debug symbols to load.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider2](../vs140/idebugcomplussymbolprovider2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider2](../vs140/idebugcomplussymbolprovider2.md)