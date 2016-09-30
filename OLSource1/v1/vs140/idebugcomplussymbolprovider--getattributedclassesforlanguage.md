---
title: "IDebugComPlusSymbolProvider::GetAttributedClassesForLanguage"
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
  - "GetAttributedClassesForLanguage"
  - "IDebugComPlusSymbolProvider::GetAttributedClassesForLanguage"
ms.assetid: e5b1b8b6-52a6-4ade-9a36-644abfa9f4b2
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider::GetAttributedClassesForLanguage
Retrieves the classes with the specified attribute that are implemented in the specified programming language.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Unique identifier for the language.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The attribute string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns an enumeration of the attribute classes.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md)