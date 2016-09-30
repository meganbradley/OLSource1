---
title: "IDiaSymbol::findChildren"
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
  - "IDiaSymbol::findChildren method"
ms.assetid: 5fe7573a-e48b-428d-9c17-7421b7209246
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::findChildren
Retrieves the children of the symbol.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Specifies the symbol tags of the children to be retrieved, as defined in the [SymTagEnum Enumeration](../vs140/symtagenum.md). Set to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for all children to be retrieved.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Specifies the name of the children to be retrieved. Set to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for all children to be retrieved.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Specifies the comparison options applied to name matching. Values from the [NameSearchOptions Enumeration](../vs140/namesearchoptions.md) enumeration can be used alone or in combination.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaEnumSymbols](../vs140/idiaenumsymbols.md) object that contains a list of the child symbols retrieved.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if at least one child of the symbol was found, or returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if no children were found; otherwise returns an error code.  
  
## Remarks  
 This method is identical to calling the [IDiaSession::findChildren](../vs140/idiasession--findchildren.md) method with this symbol as the first parameter.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [SymTagEnum Enumeration](../vs140/symtagenum.md)   
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)   
 [IDiaSession::findChildren](../vs140/idiasession--findchildren.md)   
 [NameSearchOptions Enumeration](../vs140/namesearchoptions.md)