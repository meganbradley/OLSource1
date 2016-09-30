---
title: "CSharedFile::SetHandle"
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
  - "CSharedFile::SetHandle"
  - "CSharedFile.SetHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetHandle method"
ms.assetid: 762fe45b-f276-462b-8a4a-b9e7c62c014e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSharedFile::SetHandle
Call this function to attach a block of global memory to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *hGlobalMemory*  
 Handle to the global memory to be attached to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether the memory block is allowed to grow.  
  
## Remarks  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is nonzero, the size of the memory block is increased as necessary, for example, if an attempt is made to write more bytes to the file than were allocated for the memory block.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CSharedFile Class](../vs140/csharedfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSharedFile::CSharedFile](../vs140/csharedfile--csharedfile.md)   
 [CSharedFile::Detach](../vs140/csharedfile--detach.md)