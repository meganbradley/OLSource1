---
title: "IDebugComPlusSymbolProvider::GetArrayTypeFromAddress"
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
  - "GetArrayTypeFromAddress"
  - "IDebugComPlusSymbolProvider::GetArrayTypeFromAddress"
ms.assetid: cc0c53f1-8c0f-49fa-8dbe-bc155e9ce0ef
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider::GetArrayTypeFromAddress
Retrieves type information about the specified array given its debug address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The debug address represented by an [IDebugAddress](../vs140/idebugaddress.md) interface.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The array to examine.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Length in bytes of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns the array type as represented by an [IDebugClassField](../vs140/idebugclassfield.md) interface.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md)