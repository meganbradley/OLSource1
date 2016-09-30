---
title: "IDebugSymbolProvider::GetMethodFieldsByName"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugSymbolProvider::GetMethodFieldsByName"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetMethodFieldsByName method"
ms.assetid: 1f781320-81ef-4037-b068-f1864b271258
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProvider::GetMethodFieldsByName
This method gets the field representing a fully qualified method name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The method name.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Selects the type of match, for example, case-sensitive.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugFields](../vs140/ienumdebugfields.md) enumerator for the fields associated with this method.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 A method can be associated with multiple fields if it is overloaded, for example.  
  
## See Also  
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)   
 [IEnumDebugFields](../vs140/ienumdebugfields.md)