---
title: "Error Handling (CRT)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "c.errors"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "error handling, C routines for"
  - "logic errors"
  - "error handling, library routines"
  - "testing, for program errors"
ms.assetid: 125ac697-9eb0-4152-a440-b7842f23d97f
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Error Handling (CRT)
Use these routines to handle program errors.  
  
### Error-Handling Routines  
  
|Routine|Use|.NET Framework equivalent|  
|-------------|---------|-------------------------------|  
|[assert](../vs140/assert-macro--_assert--_wassert.md) macro|Test for programming logic errors; available in both the release and debug versions of the run-time library|[System::Diagnostics::Debug::Assert](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.assert.aspx)|  
|[_ASSERT, _ASSERTE](../vs140/_assert--_asserte--_assert_expr-macros.md) macros|Similar to `assert`, but only available in the debug versions of the run-time library|[System::Diagnostics::Debug::Assert](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.assert.aspx)|  
|[clearerr](../vs140/clearerr.md)|Reset error indicator. Calling `rewind` or closing a stream also resets the error indicator.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_eof](../vs140/_eof.md)|Check for end of file in low-level I/O|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[feof](../vs140/feof.md)|Test for end of file. End of file is also indicated when `_read` returns 0.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[ferror](../vs140/ferror.md)|Test for stream I/O errors|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_RPT, _RPTF](../vs140/_rpt--_rptf--_rptw--_rptfw-macros.md) macros|Generate a report similar to `printf`, but only available in the debug versions of the run-time library|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_set_error_mode](../vs140/_set_error_mode.md)|Modifies `__error_mode` to determine a non-default location where the C run time writes an error message for an error that will possibly end the program.||  
|[_set_purecall_handler](../vs140/_get_purecall_handler--_set_purecall_handler.md)|Sets the handler for a pure virtual function call.||  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)