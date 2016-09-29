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
Modifies `__error_mode` to determine a non-default location where the C runtime writes an error message for an error that might end the program.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
int _set_error_mode(  
   int modeval   
);  
```  
  
#### Parameters  
 `modeval`  
 Destination of error messages.  
  
## Return Value  
 Returns the old setting or -1 if an error occurs.  
  
## Remarks  
 Controls the error output sink by setting the value of `__error_mode`. For example, you can direct output to a standard error or use the `MessageBox` API.  
  
 The `modeval` parameter can be set to one of the following values.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_OUT_TO_DEFAULT`|Error sink is determined by `__app_type`.|  
|`_OUT_TO_STDERR`|Error sink is a standard error.|  
|`_OUT_TO_MSGBOX`|Error sink is a message box.|  
|`_REPORT_ERRMODE`|Report the current `__error_mode` value.|  
  
 If a value other than those listed is passed in, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue,`_set_error_mode` sets `errno` to `EINVAL` and returns -1.  
  
 When it's used with an [assert](../vs140/assert-macro--_assert--_wassert.md), `_set_error_mode` displays the failed statement in the dialog box and gives you the option of choosing the `Ignore` button so that you can continue to run the program.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_set_error_mode`|<stdlib.h>|  
  
## Example  
  
```  
  
      // crt_set_error_mode.c  
// compile with: /c  
#include <stdlib.h>  
#include <assert.h>  
  
int main()  
{  
   _set_error_mode(_OUT_TO_STDERR);  
   assert(2+2==5);  
}  
```  
  
 **Assertion failed: 2+2==5, file crt_set_error_mode.c, line 8**  
**This application has requested the Runtime to terminate it in an unusual way.**  
**Please contact the application's support team for more information.**   
## See Also  
 [assert Macro, _assert, _wassert](../vs140/assert-macro--_assert--_wassert.md)