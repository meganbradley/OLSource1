---
title: "IDiaSession::findInlineeLinesByRVA"
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
ms.assetid: 7a74d5ee-0dbf-47c0-92b4-47ec03b13ce9
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findInlineeLinesByRVA
Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, by the specified parent symbol and are contained within the specified relative virtual address (RVA).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object representing the parent.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Specifies the address as an RVA.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Specifies the address range, in number of bytes, to cover with this query.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Holds an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that contains the list of line numbers that are retrieved.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [SymTagEnum Enumeration](../vs140/symtagenum.md)   
 [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md)