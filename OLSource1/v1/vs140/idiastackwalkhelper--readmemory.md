---
title: "IDiaStackWalkHelper::readMemory"
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
  - "IDiaStackWalkHelper2::readMemory method"
ms.assetid: e1eb90aa-49b7-476c-9e70-7e8f08994cbe
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalkHelper::readMemory
Reads a block of data from the executable's image in memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A value from the [MemoryTypeEnum](../vs140/memorytypeenum.md) enumeration specifying the type of memory to read.  
  
 va  
 [in] Virtual address in the image from which to begin reading.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The size of the data buffer in bytes.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the number of bytes actually read. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, then this is the total number of bytes of data available.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in, out] A buffer that is filled in with the memory read.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkHelper](../vs140/idiastackwalkhelper.md)   
 [MemoryTypeEnum](../vs140/memorytypeenum.md)