---
title: "IDebugComPlusSymbolProvider::LoadSymbols"
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
  - "LoadSymbols"
  - "IDebugComPlusSymbolProvider::LoadSymbols"
ms.assetid: 3499680d-0b9a-4f20-8432-c89a41b29b87
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider::LoadSymbols
Loads the specified debug symbols in memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Identifier of the application domain.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Unique identifier of the mondule.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Base memory address.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Object that contains the symbol metadata.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] Name of the module.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] Path to search for the symbol file.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md)