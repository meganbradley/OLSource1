---
title: "IDebugComPlusSymbolProvider::GetAddressesInModuleFromPosition"
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
  - "GetAddressesInModuleFromPosition"
  - "IDebugComPlusSymbolProvider::GetAddressesInModuleFromPosition"
ms.assetid: f901c66e-f53c-4ea0-8004-d8fcbf46f916
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider::GetAddressesInModuleFromPosition
Maps a document position in the specified module to an array of debug addresses.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Application domain identifier.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Unique identifier of the module.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The document position.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, limits the debug addresses to a single statement.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [out] Returns an enumerator for the starting debug addresses that are associated with this statement or line.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [out] Returns an enumerator for the ending debug addresses that are associated with this statement or line.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md)