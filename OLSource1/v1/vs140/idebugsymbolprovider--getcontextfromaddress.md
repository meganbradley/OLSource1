---
title: "IDebugSymbolProvider::GetContextFromAddress"
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
  - "IDebugSymbolProvider::GetContextFromAddress"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetContextFromAddress method"
ms.assetid: 7a27d56f-20d4-4e5c-af7b-7307d3aff0a1
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProvider::GetContextFromAddress
This method maps a debug address into a document context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The debug address as represented by an [IDebugAddress](../vs140/idebugaddress.md) interface.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns a document context as represented by an [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md) interface.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)   
 [IDebugAddress](../vs140/idebugaddress.md)   
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)