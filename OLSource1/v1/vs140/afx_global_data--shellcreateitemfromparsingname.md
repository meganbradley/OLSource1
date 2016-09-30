---
title: "AFX_GLOBAL_DATA::ShellCreateItemFromParsingName"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ShellCreateItemFromParsingName"
  - "afxglobals/AFX_GLOBAL_DATA::ShellCreateItemFromParsingName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShellCreateItemFromParsingName"
ms.assetid: ecb61b6d-8a96-4e2c-aa17-c7ad8eea297d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::ShellCreateItemFromParsingName
Creates and initializes a Shell item object from a parsing name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A pointer to a display name.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a bind context that controls the parsing operation.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to an interface ID.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] When this function returns, contains the interface pointer requested in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. This will typically be <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns S_OK if successful; an error value otherwise.  
  
## Remarks  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)