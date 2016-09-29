---
title: "Parameter Validation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "parameters, validation"
ms.assetid: 019dd5f0-dc61-4d2e-b4e9-b66409ddf1f2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parameter Validation
Most of the security-enhanced CRT functions and many of the preexisting functions validate their parameters. This could include checking pointers for NULL, checking that integers fall into a valid range, or checking that enumeration values are valid. When an invalid parameter is found, the invalid parameter handler is executed.  
  
## Invalid Parameter Handler Routine  
 The behavior of the C Runtime when an invalid parameter is found is to call the currently assigned invalid parameter handler. The default invalid parameter invokes Watson crash reporting, which causes the application to crash and asks the user if they want to load the crash dump to Microsoft for analysis. In Debug mode, an invalid parameter also results in a failed assertion.  
  
 This behavior can be changed by using the function [_set_invalid_parameter_handler](../vs140/_set_invalid_parameter_handler--_set_thread_local_invalid_parameter_handler.md) to set the invalid parameter handler to your own function. If the function you specify does not terminate the application, control is returned to the function that received the invalid parameters, and these functions will normally cease execution, return an error code, and set `errno` to an error code. In many cases, the `errno` value and the return value are both `EINVAL`, indicating an invalid parameter. In some cases, a more specific error code is returned, such as `EBADF` for a bad file pointer passed in as a parameter. For more information on errno, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## See Also  
 [Security-Enhanced CRT Functions](../vs140/security-features-in-the-crt.md)   
 [C Run-Time Libraries](../vs140/crt-library-features.md)