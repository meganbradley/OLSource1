---
title: "IDebugComPlusSymbolProvider::GetAttributedClassesinModule"
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
  - "IDebugComPlusSymbolProvider::GetAttributedClassesinModule"
  - "GetAttributedClassesinModule"
ms.assetid: d8b087f3-1d32-4570-9eb0-7e0f7b051bc8
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider::GetAttributedClassesinModule
Retrieves the classes with the specified attribute in a given module.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Identifier of the application domain.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Unique identifier of the module.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The attribute string.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Returns an enumeration of the attributed classes.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md)