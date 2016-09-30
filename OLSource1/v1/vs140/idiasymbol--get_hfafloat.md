---
title: "IDiaSymbol::get_hfaFloat"
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
  - "IDiaSymbol::get_hfaFloat method"
ms.assetid: 73ddcffe-cdac-4b03-be42-82ef985d17ee
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_hfaFloat
Retrieves a flag that specifies whether a user-defined type (UDT) contains homogeneous floating-point aggregate (HFA) data of type float.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the UDT contains HFA data of type float; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or an error code.  
  
> [!NOTE]
>  A return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> means the property is not available for the symbol.  
  
## Remarks  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia100.dll  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [IDiaSymbol::get_udtKind](../vs140/idiasymbol--get_udtkind.md)