---
title: "IDiaSession::symsAreEquiv"
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
  - "IDiaSession::symsAreEquiv method"
ms.assetid: 9941d520-e203-46c0-83c3-b3a967f4fc59
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::symsAreEquiv
Checks to see if two symbols are equivalent.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The first [IDiaSymbol](../vs140/idiasymbol.md) object used in the comparison.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The second <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object used in the comparison.  
  
## Return Value  
 If the symbols are equivalent, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the symbols are not equivalent. Otherwise, return an error code.  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)