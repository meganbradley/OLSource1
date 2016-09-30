---
title: "IDiaFrameData::get_program"
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
  - "IDiaFrameData::get_program method"
ms.assetid: 9201409e-b4b1-4e2e-a9f8-d17678ac538b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaFrameData::get_program
Retrieves the program string that is used to compute the register set before the call to the current function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns the program string.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 The program string is a sequence of macros that is interpreted in order to establish the prologue. For example, a typical stack frame might use the program string <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The format is reverse polish notation, where the operators follow the operands. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> represents a temporary variable on the stack. This example performs the following steps:  
  
1.  Move contents of register <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
2.  Add <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to the value in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to produce an address, get the value from that address, and store the value in register <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
3.  Get the value from the address stored in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and store that value in register <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
4.  Add <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to the value in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and store that value in register <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 Note that the program string is specific to the CPU and to the calling convention set up for the function represented by the current stack frame.  
  
## See Also  
 [IDiaFrameData](../vs140/idiaframedata.md)