---
title: "IDebugSymbolProvider::GetNamespacesUsedAtAddress"
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
  - "IDebugSymbolProvider::GetNamespacesUsedAtAddress"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetNamespacesUsedAtAddress method"
ms.assetid: 392de54b-9af0-4567-953b-1b41acd1e05c
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProvider::GetNamespacesUsedAtAddress
This method creates an enumerator for namespaces associated with the debug address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The debug address.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugFields](../vs140/ienumdebugfields.md) enumerator for the namespaces.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 There may be several namespaces associated with a given debug address, for example, nested namespaces or multiple <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statements.  
  
## See Also  
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)   
 [IEnumDebugFields](../vs140/ienumdebugfields.md)