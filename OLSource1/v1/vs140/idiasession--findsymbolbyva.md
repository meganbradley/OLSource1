---
title: "IDiaSession::findSymbolByVA"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSession::findSymbolByVA method"
ms.assetid: 0350df23-9a5d-4e8d-8c26-7f571d8fb1af
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findSymbolByVA
Retrieves a specified symbol type that contains, or is closest to, a specified virtual address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Specifies the virtual address.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Symbol type to be found. Values are taken from the [SymTagEnum Enumeration](../vs140/symtagenum.md) enumeration.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaSymbol](../vs140/idiasymbol.md) object that represents the symbol retrieved.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [SymTagEnum Enumeration](../vs140/symtagenum.md)