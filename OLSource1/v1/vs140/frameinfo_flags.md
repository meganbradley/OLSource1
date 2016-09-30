---
title: "FRAMEINFO_FLAGS"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "FRAMEINFO_FLAGS"
helpviewer_keywords: 
  - "FRAMEINFO_FLAGS enumeration"
ms.assetid: 41578062-8455-412a-9d8b-1e1e9dc8d52e
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# FRAMEINFO_FLAGS
Specifies the information to retrieve about a stack frame object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 FIF_FUNCNAME  
 Initialize/use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field.  
  
 FIF_RETURNTYPE  
 Initialize/use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field.  
  
 FIF_ARGS  
 Initialize/use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> field.  
  
 FIF_LANGUAGE  
 Initialize/use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field.  
  
 FIF_MODULE  
 Initialize/use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> field.  
  
 FIF_STACKRANGE  
 Initialize/use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (stack range) fields.  
  
 FIF_FRAME  
 Initialize/use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> field.  
  
 FIF_DEBUGINFO  
 Initialize/use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> field.  
  
 FIF_STALECODE  
 Initialize/use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> field.  
  
 FIF_ANNOTATEDFRAME  
 Initialize/use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> field.  
  
 FIF_DEBUG_MODULEP  
 Initialize/use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> field.  
  
 FIF_FUNCNAME_FORMAT  
 Formats the function name. The result is returned in the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> field and no other fields are filled out.  
  
 FIF_FUNCNAME_RETURNTYPE  
 Adds the return type to the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> field.  
  
 FIF_FUNCNAME_ARGS  
 Adds the arguments to the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> field.  
  
 FIF_FUNCNAME_LANGUAGE  
 Adds the language to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> field.  
  
 FIF_FUNCNAME_MODULE  
 Adds the module name to the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> field.  
  
 FIF_FUNCNAME_LINES  
 Adds the number of lines to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> field.  
  
 FIF_FUNCNAME_OFFSET  
 Adds to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> field the offset in bytes from the start of the line if <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is specified. If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is not specified, or if line numbers are not available, adds the offset in bytes from the start of the function.  
  
 FIF_FUNCNAME_ARGS_TYPES  
 Adds the type of each function argument to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> field.  
  
 FIF_FUNCNAME_ARGS_NAMES  
 Adds the name of each function argument to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> field.  
  
 FIF_FUNCNAME_ARGS_VALUES  
 Adds the value of each function argument to the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> field.  
  
 FIF_FUNCNAME_ARGS_ALL  
 Adds the type, name, and value of all arguments to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> field.  
  
 FIF_ARGS_TYPES  
 The argument types are retrieved and formatted.  
  
 FIF_ARGS_NAMES  
 The argument names are retrieved and formatted.  
  
 FIF_ARGS_VALUES  
 The argument values are retrieved and formatted.  
  
 FIF_ARGS_ALL  
 Retrieve and format the type, name, and value of all arguments.  
  
 FIF_ARGS_NOFORMAT  
 Specifies that the arguments are not be formatted (for example, do not add opening and closing parentheses around the argument list nor add a separator between arguments).  
  
 FIF_ARGS_NO_FUNC_EVAL  
 Specifies that function (property) evaluation should not be used when retrieving argument values.  
  
 FIF_FILTER_NON_USER_CODE  
 The debug engine is to filter non-user code frames so they are not included.  
  
 FIF_ARGS_NO_TOSTRING  
 Do not allow <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> function evaluation or formatting when returning function arguments.  
  
 FIF_DESIGN_TIME_EXPR_EVAL  
 Frame information should be gotten from the hosted app-domain rather than the hosting process.  
  
## Remarks  
 These flags are passed to the [EnumFrameInfo](../vs140/idebugthread2--enumframeinfo.md) and [GetInfo](../vs140/idebugstackframe2--getinfo.md) methods to indicate which fields are to be initialized in the [FRAMEINFO](../vs140/frameinfo.md) structure or structures.  
  
 These flags are also used to indicate which fields of the [FRAMEINFO](../vs140/frameinfo.md) structure are used and valid when the structure is returned. These values may be combined with a bitwise <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [FRAMEINFO](../vs140/frameinfo.md)   
 [EnumFrameInfo](../vs140/idebugthread2--enumframeinfo.md)   
 [GetInfo](../vs140/idebugstackframe2--getinfo.md)