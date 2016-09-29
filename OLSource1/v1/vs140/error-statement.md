---
title: "Error Statement"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.error"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Error statement, syntax"
  - "Error statement"
  - "Error keyword"
  - "run-time errors, codes"
  - "errors [Visual Basic], simulating"
ms.assetid: 85cd5c59-5224-4f02-aaf5-fcfefab17a29
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Error Statement
Simulates the occurrence of an error.  
  
## Syntax  
  
```  
Error errornumber  
```  
  
## Parts  
 `errornumber`  
 Required. Can be any valid error number.  
  
## Remarks  
 The `Error` statement is supported for backward compatibility. In new code, especially when creating objects, use the `Err` object's `Raise` method to generate run-time errors.  
  
 If `errornumber` is defined, the `Error` statement calls the error handler after the properties of the `Err` object are assigned the following default values:  
  
|Property|Value|  
|--------------|-----------|  
|`Number`|Value specified as argument to `Error` statement. Can be any valid error number.|  
|`Source`|Name of the current Visual Basic project.|  
|`Description`|String expression corresponding to the return value of the `Error` function for the specified `Number`, if this string exists. If the string does not exist, `Description` contains a zero-length string ("").|  
|`HelpFile`|The fully qualified drive, path, and file name of the appropriate Visual Basic Help file.|  
|`HelpContext`|The appropriate Visual Basic Help file context ID for the error corresponding to the `Number` property.|  
|`LastDLLError`|Zero.|  
  
 If no error handler exists, or if none is enabled, an error message is created and displayed from the `Err` object properties.  
  
> [!NOTE]
>  Some Visual Basic host applications cannot create objects. See your host application's documentation to determine whether it can create classes and objects.  
  
## Example  
 This example uses the `Error` statement to generate error number 11.  
  
```  
On Error Resume Next   ' Defer error handling.  
Error 11   ' Simulate the "Division by zero" error.  
```  
  
## Requirements  
 **Namespace:** [Microsoft.VisualBasic](../vs140/visual-basic-runtime-library-members.md)  
  
 **Assembly:** Visual Basic Runtime Library (in Microsoft.VisualBasic.dll)  
  
## See Also  
 <xref:Microsoft.VisualBasic.ErrObject.Clear*>   
 <xref:Microsoft.VisualBasic.Information.Err*>   
 <xref:Microsoft.VisualBasic.ErrObject.Raise*>   
 [On Error Statement](../vs140/on-error-statement--visual-basic-.md)   
 [Resume Statement](../vs140/resume-statement.md)   
 [Error Messages (Visual Basic)](../vs140/error-messages--visual-basic-.md)