---
title: "IDebugComPlusSymbolProvider::GetSymAttribute"
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
  - "IDebugComPlusSymbolProvider::GetSymAttribute"
  - "GetSymAttribute"
ms.assetid: 6cbaac92-a60b-4165-a7f5-c34407770f3c
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider::GetSymAttribute
Retrieves the debug symbols with the given parent attribute for the specified module.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Identifier of the application domain.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Unique identifier of the module.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Token for the parent attribute.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Name of the module.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] Number of bytes required for the output <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [out] Length of the output <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 [out] Array that contains the symbols.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md)