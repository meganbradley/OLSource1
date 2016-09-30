---
title: "IDiaSession::findSymbolByVAEx"
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
  - "IDiaSession::findSymbolByVAEx method"
ms.assetid: 11c685f6-cda2-4474-a432-214ecaae4ffa
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findSymbolByVAEx
Retrieves a specified symbol type that contains, or is closest to, a specified virtual address (VA) and offset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Specifies the VA.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Symbol type to be found. Values are taken from the [SymTagEnum Enumeration](../vs140/symtagenum.md) enumeration.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaSymbol](../vs140/idiasymbol.md) object that represents the symbol retrieved.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns a value that specifies an offset from the virtual address given by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSession::findChildren](../vs140/idiasession--findchildren.md)   
 [IDiaSession::findSymbolByVA](../vs140/idiasession--findsymbolbyva.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [SymTagEnum Enumeration](../vs140/symtagenum.md)