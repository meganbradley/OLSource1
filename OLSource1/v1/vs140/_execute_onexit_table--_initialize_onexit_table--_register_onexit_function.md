---
title: "_execute_onexit_table, _initialize_onexit_table, _register_onexit_function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_execute_onexit_table"
  - "_initialize_onexit_table"
  - "_register_onexit_function"
apilocation: 
  - "api-ms-win-crt-runtime-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_execute_onexit_table"
  - "process/_execute_onexit_table"
  - "_initialize_onexit_table"
  - "process/_initialize_onexit_table"
  - "_register_onexit_function"
  - "process/_register_onexit_function"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "_execute_onexit_table function"
  - "_initialize_onexit_table function"
  - "_register_onexit_function function"
ms.assetid: ad9e4149-d4ad-4fdf-aaaf-cf786fcb4473
caps.latest.revision: 7
---
# _execute_onexit_table, _initialize_onexit_table, _register_onexit_function
Manages the routines to be called at exit time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [inout] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the onexit function table.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a function to add to the onexit function table.  
  
## Return Value  
 If successful, returns 0. Otherwise, returns a negative value.  
  
## Remarks  
 These functions are infrastructure implementation details used to support the C runtime, and should not be called directly from your code. The C runtime uses an *onexit function table* to represent the sequence of functions registered by calls to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The onexit function table data structure is an opaque implementation detail of the C runtime; the order and meaning of its data members may change. They should not be inspected by external code.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function initializes the onexit function table to its initial value.  This function must be called before the onexit function table is passed to either <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function appends a function to the end of the onexit function table.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function executes all of the functions in the onexit function table, clears the table, and then returns. After a call to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the table is in a non-valid state; it must be reinitialized by a call to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> before it is used again.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|C, C++: \<process.h>|  
  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> functions are Microsoft specific. For compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [atexit](../vs140/atexit.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [_onexit, _onexit_m](../vs140/_onexit--_onexit_m.md)