---
title: "CMemFile::GrowFile"
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
  - "CMemFile::GrowFile"
  - "CMemFile.GrowFile"
  - "GrowFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GrowFile method"
  - "CMemFile class, advanced overridables"
ms.assetid: e0edd7c8-9768-4471-bef2-5561923be3f9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMemFile::GrowFile
This function is called by several of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 New size of the memory file.  
  
## Remarks  
 You can override it if you want to change how <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> grows its file. The default implementation calls [Realloc](../vs140/cmemfile--realloc.md) to grow an existing block (or [Alloc](../vs140/cmemfile--alloc.md) to create a memory block), allocating memory in multiples of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value specified in the constructor or [Attach](../vs140/cmemfile--attach.md) call.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CMemFile Class](../vs140/cmemfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMemFile::Alloc](../vs140/cmemfile--alloc.md)   
 [CMemFile::Realloc](../vs140/cmemfile--realloc.md)   
 [CMemFile::CMemFile](../vs140/cmemfile--cmemfile.md)   
 [CMemFile::Attach](../vs140/cmemfile--attach.md)