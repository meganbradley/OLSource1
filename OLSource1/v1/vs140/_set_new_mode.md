---
title: "_set_new_mode"
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
  - "_set_new_mode"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "set_new_mode"
  - "_set_new_mode"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "handler modes"
  - "_set_new_mode function"
  - "set_new_mode function"
ms.assetid: 4d14039a-e54e-4689-8c70-74a4b9834768
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _set_new_mode
Sets a new handler mode for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 New handler mode for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; valid value is 0 or 1.  
  
## Return Value  
 Returns the previous handler mode set for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. A return value of 1 indicates that, on failure to allocate memory, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> previously called the new handler routine; a return value of 0 indicates that it did not. If the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> argument does not equal 0 or 1, returns –1.  
  
## Remarks  
 The C++ <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function sets the new handler mode for [malloc](../vs140/malloc.md). The new handler mode indicates whether, on failure, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is to call the new handler routine as set by [_set_new_handler](../vs140/_set_new_handler.md). By default, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> does not call the new handler routine on failure to allocate memory. You can override this default behavior so that, when <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> fails to allocate memory, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> calls the new handler routine in the same way that the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator does when it fails for the same reason. For more information, see the [new](../vs140/new-operator--c---.md) and [delete](../vs140/delete-operator--c---.md) operators in the *C++ Language Reference*. To override the default, call:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 early in your program or link with Newmode.obj (see [Link Options](../vs140/link-options.md)).  
  
 This function validates its parameter. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is anything other than 0 or 1, the function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, **_**<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> returns -1 and sets <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<new.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [calloc](../vs140/calloc.md)   
 [free](../vs140/free.md)   
 [realloc](../vs140/realloc.md)   
 [_query_new_handler](../vs140/_query_new_handler.md)   
 [_query_new_mode](../vs140/_query_new_mode.md)