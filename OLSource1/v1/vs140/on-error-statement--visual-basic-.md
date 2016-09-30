---
title: "On Error Statement (Visual Basic)"
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
  - "vb.OnError"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Visual Basic code, control flow"
  - "Resume Next statement"
  - "errors [Visual Basic], trapping"
  - "error handling, On Error statement"
  - "Next statement, On Error"
  - "control flow, branching"
  - "Error keyword"
  - "execution, conditional"
  - "Resume statement, and On Error statement"
  - "Error statement, and On Error statement"
  - "GoTo statement, and On Error statement"
  - "branching, on error"
  - "conditional statements, On Error"
  - "On Error statement, syntax"
  - "On keyword"
  - "run-time errors, handling"
  - "On Error statement"
ms.assetid: ff947930-fb84-40cf-bd66-1ea219561d5c
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# On Error Statement (Visual Basic)
Enables an error-handling routine and specifies the location of the routine within a procedure; can also be used to disable an error-handling routine.  
  
 Without an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement, any run-time error that occurs is fatal: an error message is displayed, and execution stops.  
  
 Whenever possible, we suggest you use structured exception handling in your code, rather than using unstructured exception handling and the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement. For more information, see [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md).  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword is also used in the [Error Statement](../vs140/error-statement.md), which is supported for backward compatibility.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Enables the error-handling routine that starts at the line specified in the required <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> argument. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> argument is any line label or line number. If a run-time error occurs, control branches to the specified line, making the error handler active. The specified line must be in the same procedure as the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement, or a compile-time error will occur.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> 0|Disables enabled error handler in the current procedure and resets it to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> -1|Disables enabled exception in the current procedure and resets it to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Specifies that when a run-time error occurs, control goes to the statement immediately following the statement where the error occurred, and execution continues from that point. Use this form rather than <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> when accessing objects.|  
  
## Remarks  
  
> [!NOTE]
>  We recommend that you use structured exception handling in your code whenever possible, rather than using unstructured exception handling and the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement. For more information, see [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md).  
  
 An "enabled" error handler is one that is turned on by an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement. An "active" error handler is an enabled handler that is in the process of handling an error.  
  
 If an error occurs while an error handler is active (between the occurrence of the error and a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> statement), the current procedure's error handler cannot handle the error. Control returns to the calling procedure.  
  
 If the calling procedure has an enabled error handler, it is activated to handle the error. If the calling procedure's error handler is also active, control passes back through previous calling procedures until an enabled, but inactive, error handler is found. If no such error handler is found, the error is fatal at the point at which it actually occurred.  
  
 Each time the error handler passes control back to a calling procedure, that procedure becomes the current procedure. Once an error is handled by an error handler in any procedure, execution resumes in the current procedure at the point designated by the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> statement.  
  
> [!NOTE]
>  An error-handling routine is not a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> procedure or a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> procedure. It is a section of code marked by a line label or a line number.  
  
## Number Property  
 Error-handling routines rely on the value in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> property of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object to determine the cause of the error. The routine should test or save relevant property values in the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object before any other error can occur or before a procedure that might cause an error is called. The property values in the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object reflect only the most recent error. The error message associated with <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is contained in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
## Throw Statement  
 An error that is raised with the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> method sets the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> property to a newly created instance of the \<xref:System.Exception*> class. In order to support the raising of exceptions of derived exception types, a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> statement is supported in the language. This takes a single parameter that is the exception instance to be thrown. The following example shows how these features can be used with the existing exception handling support:  
  
 [!code[VbVbalrErrorHandling#17](../vs140/codesnippet/VisualBasic/on-error-statement--visual-basic-_1.vb)]  
  
 Notice that the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> statement traps all errors, regardless of the exception class.  
  
## On Error Resume Next  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> causes execution to continue with the statement immediately following the statement that caused the run-time error, or with the statement immediately following the most recent call out of the procedure containing the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> statement. This statement allows execution to continue despite a run-time error. You can place the error-handling routine where the error would occur rather than transferring control to another location within the procedure. An <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> statement becomes inactive when another procedure is called, so you should execute an <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> statement in each called routine if you want inline error handling within that routine.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> construct may be preferable to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> when handling errors generated during access to other objects. Checking <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> after each interaction with an object removes ambiguity about which object was accessed by the code. You can be sure which object placed the error code in <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, as well as which object originally generated the error (the object specified in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>).  
  
## On Error GoTo 0  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> disables error handling in the current procedure. It doesn't specify line 0 as the start of the error-handling code, even if the procedure contains a line numbered 0. Without an <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> statement, an error handler is automatically disabled when a procedure is exited.  
  
## On Error GoTo -1  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> disables the exception in the current procedure. It does not specify line -1 as the start of the error-handling code, even if the procedure contains a line numbered -1. Without an <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> statement, an exception is automatically disabled when a procedure is exited.  
  
 To prevent error-handling code from running when no error has occurred, place an <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> statement immediately before the error-handling routine, as in the following fragment:  
  
 [!code[VbVbalrErrorHandling#18](../vs140/codesnippet/VisualBasic/on-error-statement--visual-basic-_2.vb)]  
  
 Here, the error-handling code follows the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> statement and precedes the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> statement to separate it from the procedure flow. You can place error-handling code anywhere in a procedure.  
  
## Untrapped Errors  
 Untrapped errors in objects are returned to the controlling application when the object is running as an executable file. Within the development environment, untrapped errors are returned to the controlling application only if the proper options are set. See your host application's documentation for a description of which options should be set during debugging, how to set them, and whether the host can create classes.  
  
 If you create an object that accesses other objects, you should try to handle any unhandled errors they pass back. If you cannot, map the error codes in <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> to one of your own errors and then pass them back to the caller of your object. You should specify your error by adding your error code to the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> constant. For example, if your error code is 1052, assign it as follows:  
  
 [!code[VbVbalrErrorHandling#19](../vs140/codesnippet/VisualBasic/on-error-statement--visual-basic-_3.vb)]  
  
> [!CAUTION]
>  System errors during calls to Windows dynamic-link libraries (DLLs) do not raise exceptions and cannot be trapped with Visual Basic error trapping. When calling DLL functions, you should check each return value for success or failure (according to the API specifications), and in the event of a failure, check the value in the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object's <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> property.  
  
## Example  
 This example first uses the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> statement to specify the location of an error-handling routine within a procedure. In the example, an attempt to divide by zero generates error number 6. The error is handled in the error-handling routine, and control is then returned to the statement that caused the error. The <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> statement turns off error trapping. Then the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> statement is used to defer error trapping so that the context for the error generated by the next statement can be known for certain. Note that <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is used to clear the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object's properties after the error is handled.  
  
 [!code[VbVbalrErrorHandling#20](../vs140/codesnippet/VisualBasic/on-error-statement--visual-basic-_4.vb)]  
  
## Requirements  
 **Namespace:** [Microsoft.VisualBasic](../vs140/visual-basic-runtime-library-members.md)  
  
 **Assembly:** Visual Basic Runtime Library (in Microsoft.VisualBasic.dll)  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Information.Err*>   
 \<xref:Microsoft.VisualBasic.ErrObject.Number*>   
 \<xref:Microsoft.VisualBasic.ErrObject.Description*>   
 \<xref:Microsoft.VisualBasic.ErrObject.LastDllError*>   
 [End Statement](../vs140/end-statement.md)   
 [Exit Statement](../vs140/exit-statement--visual-basic-.md)   
 [Resume Statement](../vs140/resume-statement.md)   
 [Error Messages (Visual Basic)](../vs140/error-messages--visual-basic-.md)   
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)