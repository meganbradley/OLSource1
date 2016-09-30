---
title: "IDebugSymbolProviderDirect::GetMethodFromAddress"
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
  - "IDebugSymbolProviderDirect::GetMethodFromAddress"
  - "GetMethodFromAddress"
ms.assetid: 33ffd197-1221-41bc-a9f6-f133ebdcb783
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProviderDirect::GetMethodFromAddress
Retrieves information about the method at the specified debug address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Debug address that is represented by the [IDebugAddress](../vs140/idebugaddress.md) interface.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Unique identifier of the module.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Identifier of the application domain.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Token that represents the containing class.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Token that represents the module.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] An offset in bytes from the start of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [out] Version number of the method.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugSymbolProviderDirect](../vs140/idebugsymbolproviderdirect.md)