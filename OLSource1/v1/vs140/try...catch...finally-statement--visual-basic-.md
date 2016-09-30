---
title: "Try...Catch...Finally Statement (Visual Basic)"
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
  - "vb.Try...Catch...Finally"
  - "vb.when"
  - "vb.Finally"
  - "vb.Catch"
  - "vb.Try"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Try...Catch...Finally statements"
  - "Try statement"
  - "try-catch exception handling, Try...Catch...Finally statements"
  - "error handling, while running code"
  - "Try statement, Try...Catch...Finally"
  - "Finally keyword [Visual Basic], Try...Catch...Finally"
  - "Catch statement"
  - "When keyword"
  - "Visual Basic code, handling errors while running"
  - "structured exception handling, Try...Catch...Finally statements"
ms.assetid: d6488026-ccb3-42b8-a810-0d97b9d6472b
caps.latest.revision: 73
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Try...Catch...Finally Statement (Visual Basic)
Provides a way to handle some or all possible errors that may occur in a given block of code, while still running code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional. Statement(s) where an error can occur. Can be a compound statement.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional. Multiple <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> blocks permitted. If an exception occurs when processing the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block, each <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement is examined in textual order to determine whether it handles the exception, with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> representing the exception that has been thrown.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional. Any variable name. The initial value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is the value of the thrown error. Used with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to specify the error caught. If omitted, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement catches any exception.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional. Specifies the type of class filter. If the value of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is of the type specified by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or of a derived type, the identifier becomes bound to the exception object.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional. A <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement with a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> clause catches exceptions only when <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. A <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> clause is applied only after checking the type of the exception, and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> may refer to the identifier representing the exception.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Optional. Must be implicitly convertible to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. Any expression that describes a generic filter. Typically used to filter by error number. Used with <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> keyword to specify circumstances under which the error is caught.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Optional. Statement(s) to handle errors that occur in the associated <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> block. Can be a compound statement.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Optional. Keyword that breaks out of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> structure. Execution resumes with the code immediately following the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statement. The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> statement will still be executed. Not allowed in <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> blocks.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Optional. A <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> block is always executed when execution leaves any part of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> statement.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Optional. Statement(s) that are executed after all other error processing has occurred.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Terminates the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> structure.|  
  
## Remarks  
 If you expect that a particular exception might occur during a particular section of code, put the code in a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> block and use a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> block to retain control and handle the exception if it occurs.  
  
 A <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> statement consists of a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> block followed by one or more <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> clauses, which specify handlers for various exceptions. When an exception is thrown in a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> block, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] looks for the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> statement that handles the exception. If a matching <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> statement is not found, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] examines the method that called the current method, and so on up the call stack. If no <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> block is found, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] displays an unhandled exception message to the user and stops execution of the program.  
  
 You can use more than one <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> statement in a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> statement. If you do this, the order of the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> clauses is significant because they are examined in order. Catch the more specific exceptions before the less specific ones.  
  
 The following <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> statement conditions are the least specific, and will catch all exceptions that derive from the \<xref:System.Exception*> class. You should ordinarily use one of these variations as the last <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> block in the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> structure, after catching all the specific exceptions you expect. Control flow can never reach a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> block that follows either of these variations.  
  
-   The <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, for example: <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  
-   The statement has no <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> variable, for example: <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  
 When a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> statement is nested in another <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> block, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] first examines each <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> statement in the innermost <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> block. If no matching <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> statement is found, the search proceeds to the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> statements of the outer <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> block.  
  
 Local variables from a <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> block are not available in a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> block because they are separate blocks. If you want to use a variable in more than one block, declare the variable outside the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> structure.  
  
> [!TIP]
>  The <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> statement is available as an IntelliSense code snippet. In the Code Snippets Manager, expand **Code Patterns - If, For Each, Try Catch, Property, etc**, and then **Error Handling (Exceptions)**. For more information, see [Code Snippets](../vs140/code-snippets.md).  
  
## Finally Block  
 If you have one or more statements that must run before you exit the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> structure, use a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> block. Control passes to the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> block just before it passes out of the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> structure. This is true even if an exception occurs anywhere inside the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> structure.  
  
 A <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> block is useful for running any code that must execute even if there is an exception. Control is passed to the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> block regardless of how the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> block exits.  
  
 The code in a <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> block runs even if your code encounters a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> statement in a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> block. Control does not pass from a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> block to the corresponding <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> block in the following cases:  
  
-   An [End Statement](../vs140/end-statement.md) is encountered in the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> block.  
  
-   A \<xref:System.StackOverflowException*> is thrown in the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> block.  
  
 It is not valid to explicitly transfer execution into a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> block. Transferring execution out of a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> block is not valid, except through an exception.  
  
 If a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> statement does not contain at least one <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> block, it must contain a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> block.  
  
> [!TIP]
>  If you do not have to catch specific exceptions, the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> statement behaves like a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> block, and guarantees disposal of the resources, regardless of how you exit the block. This is true even with an unhandled exception. For more information, see [Using Statement (Visual Basic)](../vs140/using-statement--visual-basic-.md).  
  
## Exception Argument  
 The <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> block <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> argument is an instance of the \<xref:System.Exception*> class or a class that derives from the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> class. The <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> class instance corresponds to the error that occurred in the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> block.  
  
 The properties of the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object help to identify the cause and location of an exception. For example, the \<xref:System.Exception.StackTrace*> property lists the called methods that led to the exception, helping you find where the error occurred in the code. \<xref:System.Exception.Message*> returns a message that describes the exception. \<xref:System.Exception.HelpLink*> returns a link to an associated Help file. \<xref:System.Exception.InnerException*> returns the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> object that caused the current exception, or it returns <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> if there is no original <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
## Considerations When Using a Try…Catch Statement  
 Use a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> statement only to signal the occurrence of unusual or unanticipated program events. Reasons for this include the following:  
  
-   Catching exceptions at runtime creates additional overhead, and is likely to be slower than pre-checking to avoid exceptions.  
  
-   If a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> block is not handled correctly, the exception might not be reported correctly to users.  
  
-   Exception handling makes a program more complex.  
  
 You do not always need a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> statement to check for a condition that is likely to occur. The following example checks whether a file exists before trying to open it. This reduces the need for catching an exception thrown by the \<xref:System.IO.File.OpenText*> method.  
  
 [!code[VbVbalrStatements#94](../vs140/codesnippet/VisualBasic/try...catch...finally-statement--visual-basic-_1.vb)]  
  
 Ensure that code in <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> blocks can properly report exceptions to users, whether through thread-safe logging or appropriate messages. Otherwise, exceptions might remain unknown.  
  
## Async Methods  
 If you mark a method with the [Async](../vs140/async--visual-basic-.md) modifier, you can use the [Await](../vs140/await-operator--visual-basic-.md) operator in the method. A statement with the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> operator suspends execution of the method until the awaited task completes. The task represents ongoing work. When the task that's associated with the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> operator finishes, execution resumes in the same method. For more information, see [Control Flow in Async Programs (C# and Visual Basic)](../vs140/control-flow-in-async-programs--csharp-and-visual-basic-.md).  
  
 A task returned by an Async method may end in a faulted state, indicating that it completed due to an unhandled exception. A task may also end in a canceled state, which results in an <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> being thrown out of the await expression. To catch either type of exception, place the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> expression that's associated with the task in a <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> block, and catch the exception in the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> block. An example is provided later in this topic.  
  
 A task can be in a faulted state because multiple exceptions were responsible for its faulting. For example, the task might be the result of a call to \<xref:System.Threading.Tasks.Task.WhenAll*?displayProperty=fullName>. When you await such a task, the caught exception is only one of the exceptions, and you can't predict which exception will be caught. An example is provided later in this topic.  
  
 An <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> expression can't be inside a <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> block or <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> block.  
  
## Iterators  
 An iterator function or <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> accessor performs a custom iteration over a collection. An iterator uses a [Yield](../vs140/yield-statement--visual-basic-.md) statement to return each element of the collection one at a time. You call an iterator function by using a [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md).  
  
 A <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> statement can be inside a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> block. A <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> block that contains a <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> statement can have <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> blocks, and can have a <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> block. See the "Try Blocks in Visual Basic" section of [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md) for an example.  
  
 A <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> statement cannot be inside a <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> block or a <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> block.  
  
 If the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> body (outside of the iterator function) throws an exception, a <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> block in the iterator function is not executed, but a <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> block in the iterator function is executed. A <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> block inside an iterator function catches only exceptions that occur inside the iterator function.  
  
## Partial-Trust Situations  
 In partial-trust situations, such as an application hosted on a network share, <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> does not catch security exceptions that occur before the method that contains the call is invoked. The following example, when you put it on a server share and run from there, produces the error "System.Security.SecurityException: Request Failed." For more information about security exceptions, see the \<xref:System.Security.SecurityException*> class.  
  
 [!code[VbVbalrStatements#85](../vs140/codesnippet/VisualBasic/try...catch...finally-statement--visual-basic-_2.vb)]  
  
 In such a partial-trust situation, you have to put the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> statement in a separate <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>. The initial call to the <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> will fail. This enables <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> to catch it before the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> that contains <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> is started and the security exception produced.  
  
## Example  
 The following example illustrates the structure of the <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> statement.  
  
 [!code[VbVbalrStatements#86](../vs140/codesnippet/VisualBasic/try...catch...finally-statement--visual-basic-_3.vb)]  
  
## Example  
 In the following example, the <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> method throws a <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>. The code that generates the exception is not in a <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> block. Therefore, the <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> method does not handle the exception. The <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> method does handle the exception because the call to the <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> method is in a <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> block.  
  
 The example includes <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> statements for several types of exceptions, ordered from the most specific to the most general.  
  
 [!code[VbVbalrStatements#91](../vs140/codesnippet/VisualBasic/try...catch...finally-statement--visual-basic-_4.vb)]  
  
## Example  
 The following example shows how to use a <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> statement to filter on a conditional expression. If the conditional expression evaluates to <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>, the code in the <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> block runs.  
  
 [!code[VbVbalrStatements#92](../vs140/codesnippet/VisualBasic/try...catch...finally-statement--visual-basic-_5.vb)]  
  
## Example  
 The following example has a <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> statement that is contained in a <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> block. The inner <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> block throws an exception that has its <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> property set to the original exception. The outer <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> block reports its own exception and the inner exception.  
  
 [!code[VbVbalrStatements#93](../vs140/codesnippet/VisualBasic/try...catch...finally-statement--visual-basic-_6.vb)]  
  
## Example  
 The following example illustrates exception handling for async methods. To catch an exception that applies to an async task, the <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> expression is in a <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> block of the caller, and the exception is caught in the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> block.  
  
 Uncomment the <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> line in the example to demonstrate exception handling. The exception is caught in the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> block, the task's <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> property is set to <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>, and the task's <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> property is set to the exception.  
  
 Uncomment the <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> line to demonstrate what happens when you cancel an asynchronous process. The exception is caught in the <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> block, and the task's <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> property is set to <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>. However, under some conditions that don't apply to this example, <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>.  
  
 [!code[csAsyncExceptions#1](../vs140/codesnippet/VisualBasic/try...catch...finally-statement--visual-basic-_7.vb)]  
  
## Example  
 The following example illustrates exception handling where multiple tasks can result in multiple exceptions. The <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> block has the <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> expression for the task that \<xref:System.Threading.Tasks.Task.WhenAll*?displayProperty=fullName> returned. The task is complete when the three tasks to which \<xref:System.Threading.Tasks.Task.WhenAll*?displayProperty=fullName> is applied are complete.  
  
 Each of the three tasks causes an exception. The <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> block iterates through the exceptions, which are found in the <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> property of the task that <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> returned.  
  
 [!code[csAsyncExceptions#3](../vs140/codesnippet/VisualBasic/try...catch...finally-statement--visual-basic-_8.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Information.Err*>   
 \<xref:System.Exception*>   
 [Exit Statement](../vs140/exit-statement--visual-basic-.md)   
 [On Error Statement](../vs140/on-error-statement--visual-basic-.md)   
 [Best Practices for Using IntelliSense Code Snippets](../vs140/best-practices-for-using-code-snippets.md)   
 [Exception Handling (Task Parallel Library)](assetId:///beb51e50-9061-4d3d-908c-56a4f7c2e8c1)   
 [Throw Statement (Visual Basic)](../vs140/throw-statement--visual-basic-.md)