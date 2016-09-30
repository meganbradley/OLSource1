---
title: "IDiaStackWalkFrame::readMemory"
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
  - "IDiaStackWalkFrame::readMemory method"
ms.assetid: 7ab0b525-a5a7-4692-acad-e8c00fa9ab9a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalkFrame::readMemory
Reads memory from image.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] One of the [MemoryTypeEnum](../vs140/memorytypeenum.md) enumeration values that specifies the kind of memory to access.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Virtual address location in image to begin reading.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Size of the data buffer, in bytes.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns the number of bytes returned. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> contains the total number of bytes of data available.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [out] A buffer that is to be filled in with data from the specified location.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkFrame](../vs140/idiastackwalkframe.md)