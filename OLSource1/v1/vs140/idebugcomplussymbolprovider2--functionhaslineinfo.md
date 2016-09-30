---
title: "IDebugComPlusSymbolProvider2::FunctionHasLineInfo"
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
  - "FunctionHasLineInfo"
  - "IDebugComPlusSymbolProvider2::FunctionHasLineInfo"
ms.assetid: e1b508f1-6521-492f-b110-ab957744a037
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider2::FunctionHasLineInfo
Determines if the specified method has line information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The debug address that is represented by an [IDebugAddress](../vs140/idebugaddress.md) interface. This address must be a METHOD_ADDRESS.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider2](../vs140/idebugcomplussymbolprovider2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider2](../vs140/idebugcomplussymbolprovider2.md)