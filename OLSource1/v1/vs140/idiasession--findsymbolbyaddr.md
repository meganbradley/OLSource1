---
title: "IDiaSession::findSymbolByAddr"
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
  - "IDiaSession::findSymbolByAddr method"
ms.assetid: c130abc5-4d0a-4d2d-8286-94fde36ddd4a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findSymbolByAddr
Retrieves a specified symbol type that contains, or is closest to, a specified address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Specifies the section component of the address.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Specifies the offset component of the address.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Symbol type to be found. Values are taken from the [SymTagEnum Enumeration](../vs140/symtagenum.md) enumeration.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaSymbol](../vs140/idiasymbol.md) object that represents the symbol retrieved.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [SymTagEnum Enumeration](../vs140/symtagenum.md)