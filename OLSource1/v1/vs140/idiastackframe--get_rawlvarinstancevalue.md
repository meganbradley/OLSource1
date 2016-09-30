---
title: "IDiaStackFrame::get_rawLVarInstanceValue"
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
  - "IDiaStackFrame::get_rawLVarInstanceValue method"
ms.assetid: ce526259-85a6-475b-9274-0b3a21d95db2
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackFrame::get_rawLVarInstanceValue
This method retrieves the value of the specified local variable as raw bytes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object representing an instance of local variable to get the value for.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Maximum number of bytes in the buffer pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This can be a maximum of 8 bytes (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Returns the actual number of bytes stored in the buffer.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] A buffer to be filled in with data. This cannot be <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackFrame](../vs140/idiastackframe.md)