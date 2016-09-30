---
title: "IDiaSession::findAcceleratorInlineesByLinenum"
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
ms.assetid: 386c87aa-f7b2-4d38-9dd6-fffba9ff01f0
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findAcceleratorInlineesByLinenum
Returns an enumeration of symbols for inline frames that correspond to the specified source location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that corresponds to the Accelerator stub function that needs to be searched.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> of the source location.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The line number of the source location.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The column number of the source location.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] A pointer to an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface pointer that is initialized with the result.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)