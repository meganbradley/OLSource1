---
title: "IDiaSession::findAcceleratorInlineesByName"
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
ms.assetid: e203e5c2-6563-43fa-be56-3063955043ab
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findAcceleratorInlineesByName
Returns an enumeration of symbols for inline frames corresponding to the specified inline function name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The inlinee function name to be searched.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The name search options to be used when searching for inline frames that correspond to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. For more information, see [NameSearchOptions](../vs140/namesearchoptions.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] A pointer to an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface pointer that is initialized with the result.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This function searches for inlinees only within Accelerator stub functions. It ignores native C++ procedure records.  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)