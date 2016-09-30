---
title: "IDebugComPlusSymbolProvider::IsFunctionDeleted"
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
  - "IDebugComPlusSymbolProvider::IsFunctionDeleted"
ms.assetid: b276bd25-6658-4898-bc36-04ecdf92aa2f
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider::IsFunctionDeleted
Determines that the function at the specified debug address is deleted.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The debug address represented by an [IDebugAddress](../vs140/idebugaddress.md) interface. This address must be a METHOD_ADDRESS.  
  
## Return Value  
 If the function is deleted, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If the function is exists, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md)