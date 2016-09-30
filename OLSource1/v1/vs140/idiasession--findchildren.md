---
title: "IDiaSession::findChildren"
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
  - "IDiaSession::findChildren method"
ms.assetid: 5d19046f-f668-4aa9-8788-95cda9a98997
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findChildren
Retrieves all children of a specified parent identifier that match the name and symbol type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDiaSymbol](../vs140/idiasymbol.md) object representing the parent. If this parent symbol is a function, module, or block, then its lexical children are returned in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If the parent symbol is a type, then its class children are returned. If this parameter is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must be set to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which returns the global scope (.exe file).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] Specifies the symbol tag of the children to be retrieved. Values are taken from the [SymTagEnum Enumeration](../vs140/symtagenum.md) enumeration. Set to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to retrieve all children.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [in] Specifies the name of the children to be retrieved. Set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for all children to be retrieved.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 [in] Specifies the comparison options applied to name matching. Values from the [NameSearchOptions Enumeration](../vs140/namesearchoptions.md) enumeration can be used alone or in combination.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaEnumSymbols](../vs140/idiaenumsymbols.md) object that contains the list of child symbols retrieved.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to find local variables of function <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that match name <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Overview](../vs140/overview--debug-interface-access-sdk-.md)   
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)   
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [NameSearchOptions Enumeration](../vs140/namesearchoptions.md)   
 [SymTagEnum Enumeration](../vs140/symtagenum.md)