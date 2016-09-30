---
title: "CWin32Heap::Attach"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::CWin32Heap::Attach"
  - "CWin32Heap::Attach"
  - "CWin32Heap.Attach"
  - "ATL.CWin32Heap.Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method [ATL]"
ms.assetid: ac5ca3c5-1376-43db-b562-61c82f894ebd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWin32Heap::Attach
Attaches the heap object to an existing heap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An existing heap handle.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A flag indicating if the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is to take ownership over the resources of the heap.  
  
## Remarks  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is TRUE, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object is responsible for deleting the heap handle.  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CWin32Heap Class](../vs140/cwin32heap-class.md)   
 [CWin32Heap::Detach](../vs140/cwin32heap--detach.md)