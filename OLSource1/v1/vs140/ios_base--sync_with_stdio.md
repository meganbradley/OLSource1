---
title: "ios_base::sync_with_stdio"
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
  - "ios_base.sync_with_stdio"
  - "sync_with_stdio"
  - "xiosbase/std::ios_base::sync_with_stdio"
  - "ios_base::sync_with_stdio"
  - "std::ios_base::sync_with_stdio"
  - "std.ios_base.sync_with_stdio"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sync_with_stdio method"
ms.assetid: 504a4012-91bb-47c7-ab95-05f834210572
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::sync_with_stdio
Ensures that iostream and C run-time library operations occur in the order that they appear in source code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Whether all streams are in sync with **stdio**.  
  
## Return Value  
 Previous setting for this function.  
  
## Remarks  
 The static member function stores a **stdio** sync flag, which is initially **true**. When **true**, this flag ensures that operations on the same file are properly synchronized between the [iostreams](../vs140/iostreams-conventions.md) functions and those defined in the Standard C++ Library. Otherwise, synchronization may or may not be guaranteed, but performance may be improved. The function stores <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the **stdio** sync flag and returns its previous stored value. You can call it reliably only before performing any operations on the standard streams.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)