---
title: "IDebugComPlusSymbolProvider2::GetTypesByName"
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
  - "GetTypesByName"
  - "IDebugComPlusSymbolProvider2::GetTypesByName"
ms.assetid: ef76b1a8-6910-48fe-b4af-d9045eefd23f
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider2::GetTypesByName
Retrieves a type given its name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Name of the type.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Selects the type of match, for example, case-sensitive. A value from the [NAME_MATCH](../vs140/name_match.md) enumeration.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] An enumerator that contains the type or types with the given name.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 For generic types, the name to look up for 'List\<int>' or 'List\<int,int>' would be 'List'. If types of the same name appear in multiple modules, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> paramter will contain all copies. You have to use [IDebugField::GetTypeInfo](../vs140/idebugfield--gettypeinfo.md) and distinguish based on the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider2](../vs140/idebugcomplussymbolprovider2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider2](../vs140/idebugcomplussymbolprovider2.md)