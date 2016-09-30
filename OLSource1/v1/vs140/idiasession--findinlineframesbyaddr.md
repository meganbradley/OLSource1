---
title: "IDiaSession::findInlineFramesByAddr"
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
ms.assetid: e7dc1ac7-bb09-45be-96d2-365a9b7336e4
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findInlineFramesByAddr
Retrieves an enumeration that allows a client to iterate through all of the inline frames on a given address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object representing the parent.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Specifies the section component of the address.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Specifies the offset component of the address.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Holds an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that contains the list of frames that are retrieved.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [SymTagEnum Enumeration](../vs140/symtagenum.md)   
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)