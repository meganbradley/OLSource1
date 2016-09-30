---
title: "Using Statement (Visual Basic)"
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
  - "vb.using"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "resource disposal"
  - "Try...Catch...Finally statements, equivalent to Using statement"
  - "resources [Visual Basic], disposing"
  - "Using statement"
ms.assetid: 665d1580-dd54-4e96-a9a9-6be2a68948f1
caps.latest.revision: 40
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Statement (Visual Basic)
Declares the beginning of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block and optionally acquires the system resources that the block controls.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required if you do not supply <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. List of one or more system resources that this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block controls, separated by commas.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Required if you do not supply <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Reference variable or expression referring to a system resource to be controlled by this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional. Block of statements that the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> block runs.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Required. Terminates the definition of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> block and disposes of all the resources that it controls.|  
  
 Each resource in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> part has the following syntax and parts:  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 -or-  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## resourcelist Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Required. Reference variable that refers to a system resource that the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> block controls.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Required if the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement acquires the resource. If you have already acquired the resource, use the second syntax alternative.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Required. The class of the resource. The class must implement the \<xref:System.IDisposable*> interface.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Optional. List of arguments you are passing to the constructor to create an instance of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. See [Parameter List](../vs140/parameter-list--visual-basic-.md).|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Required. Variable or expression referring to a system resource satisfying the requirements of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If you use the second syntax alternative, you must acquire the resource before passing control to the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> statement.|  
  
## Remarks  
 Sometimes your code requires an unmanaged resource, such as a file handle, a COM wrapper, or a SQL connection. A <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> block guarantees the disposal of one or more such resources when your code is finished with them. This makes them available for other code to use.  
  
 Managed resources are disposed of by the .NET Framework garbage collector (GC) without any extra coding on your part. You do not need a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> block for managed resources. However, you can still use a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> block to force the disposal of a managed resource instead of waiting for the garbage collector.  
  
 A <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> block has three parts: acquisition, usage, and disposal.  
  
-   *Acquisition* means creating a variable and initializing it to refer to the system resource. The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> statement can acquire one or more resources, or you can acquire exactly one resource before entering the block and supply it to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> statement. If you supply <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, you must acquire the resource before passing control to the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> statement.  
  
-   *Usage* means accessing the resources and performing actions with them. The statements between <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> represent the usage of the resources.  
  
-   *Disposal* means calling the \<xref:System.IDisposable.Dispose*> method on the object in <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. This allows the object to cleanly terminate its resources. The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> statement disposes of the resources under the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> block's control.  
  
## Behavior  
 A <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> block behaves like a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>41\</CodeContentPlaceHolder> construction in which the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> block uses the resources and the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> block disposes of them. Because of this, the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> block guarantees disposal of the resources, no matter how you exit the block. This is true even in the case of an unhandled exception, except for a \<xref:System.StackOverflowException*>.  
  
 The scope of every resource variable acquired by the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> statement is limited to the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> block.  
  
 If you specify more than one system resource in the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> statement, the effect is the same as if you nested <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> blocks one within another.  
  
 If <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, no call to \<xref:System.IDisposable.Dispose*> is made, and no exception is thrown.  
  
## Structured Exception Handling Within a Using Block  
 If you need to handle an exception that might occur within the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> block, you can add a complete <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>53\</CodeContentPlaceHolder> construction to it. If you need to handle the case where the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> statement is not successful in acquiring a resource, you can test to see if <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
## Structured Exception Handling Instead of a Using Block  
 If you need finer control over the acquisition of the resources, or you need additional code in the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> block, you can rewrite the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> block as a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>60\</CodeContentPlaceHolder> construction. The following example shows skeleton <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> constructions that are equivalent in the acquisition and disposal of <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
> [!NOTE]
>  The code inside the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> block should not assign the object in <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> to another variable. When you exit the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> block, the resource is disposed, and the other variable cannot access the resource to which it points.  
  
## Example  
 The following example creates a file that is named log.txt and writes two lines of text to the file. The example also reads that same file and displays the lines of text.  
  
 Because the \<xref:System.IO.TextWriter*> and \<xref:System.IO.TextReader*> classes implement the \<xref:System.IDisposable*> interface, the code can use <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> statements to ensure that the file is correctly closed after the write and read operations.  
  
 [!code[VbVbalrStatements#50](../vs140/codesnippet/VisualBasic/using-statement--visual-basic-_1.vb)]  
  
## See Also  
 \<xref:System.IDisposable*>   
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [How to: Dispose of a System Resource](../vs140/how-to--dispose-of-a-system-resource--visual-basic-.md)