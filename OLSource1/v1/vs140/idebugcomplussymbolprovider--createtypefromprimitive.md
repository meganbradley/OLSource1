---
title: "IDebugComPlusSymbolProvider::CreateTypeFromPrimitive"
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
  - "IDebugComPlusSymbolProvider::CreateTypeFromPrimitive"
  - "CreateTypeFromPrimitive"
ms.assetid: 37213cc2-a038-42ea-9b28-3ae40d4cfe69
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider::CreateTypeFromPrimitive
Creates a type from the specified primitive type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Value from the [CorElementType Enumeration](assetId:///c3809c8f-1737-4f0f-9442-0c01ee689871) that represents the primitive type.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] An address object represented by an [IDebugAddress](../vs140/idebugaddress.md) interface.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Returns an [IDebugField](../vs140/idebugfield.md) object that describes the type.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md)