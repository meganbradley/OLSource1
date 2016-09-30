---
title: "_setjmp3"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_setjmp3"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "setjmp3"
  - "_setjmp3"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_setjmp3 function"
  - "setjmp3 function"
ms.assetid: 6129c2f3-8bac-4fdb-a827-44e1eebba500
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _setjmp3
Internal CRT function. A new implementation of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Address of the buffer for storing state information.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of additional <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>s of information that are stored in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Additional data pushed down by the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> intrinsic. The first <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a function pointer that is used to unwind extra data and return to a nonvolatile register state. The second <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is the try level to be restored. Any further data is saved in the generic data array in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Return Value  
 Always returns 0.  
  
## Remarks  
 Do not use this function in a C++ program. It is an intrinsic function that does not support C++. For more information about how to use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, see [Using setjmp/longjmp](../vs140/using-setjmp-longjmp.md).  
  
## Requirements  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [setjmp](../vs140/setjmp.md)