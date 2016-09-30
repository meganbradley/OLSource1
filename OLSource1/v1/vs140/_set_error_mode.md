---
title: "_set_error_mode"
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
  - "_set_error_mode"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr120d_clr0400.dll"
  - "msvcr100_clr0400.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "set_error_mode"
  - "_set_error_mode"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_set_error_mode function"
  - "set_error_mode function"
ms.assetid: f0807be5-73d1-4a32-a701-3c9bdd139c5c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _set_error_mode
Modifies <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to determine a non-default location where the C runtime writes an error message for an error that might end the program.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Destination of error messages.  
  
## Return Value  
 Returns the old setting or -1 if an error occurs.  
  
## Remarks  
 Controls the error output sink by setting the value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For example, you can direct output to a standard error or use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> API.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter can be set to one of the following values.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Error sink is determined by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Error sink is a standard error.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Error sink is a message box.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Report the current <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> value.|  
  
 If a value other than those listed is passed in, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue,<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and returns -1.  
  
 When it's used with an [assert](../vs140/assert-macro--_assert--_wassert.md), <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> displays the failed statement in the dialog box and gives you the option of choosing the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> button so that you can continue to run the program.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Assertion failed: 2+2==5, file crt_set_error_mode.c, line 8**  
**This application has requested the Runtime to terminate it in an unusual way.**  
**Please contact the application's support team for more information.**   
## See Also  
 [assert Macro, _assert, _wassert](../vs140/assert-macro--_assert--_wassert.md)