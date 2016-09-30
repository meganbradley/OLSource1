---
title: "IDiaSymbol::findInlineeLinesByRVA"
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
ms.assetid: ac108db1-9dbf-4dc4-bf48-159ca8d3725c
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::findInlineeLinesByRVA
Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified relative virtual address (RVA).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Specifies the address as an RVA.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Specifies the address range, in number of bytes, to cover with this query.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Holds an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that contains the list of line numbers that are retrieved.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [SymTagEnum Enumeration](../vs140/symtagenum.md)   
 [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md)   
 [IDiaSession::findInlineeLines](../vs140/idiasession--findinlineelines.md)