---
title: "Understanding SAL"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a94d6907-55f2-4874-9571-51d52d6edcfd
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Understanding SAL
The Microsoft source-code annotation language (SAL) provides a set of annotations that you can use to describe how a function uses its parameters, the assumptions that it makes about them, and the guarantees that it makes when it finishes. The annotations are defined in the header file <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Visual Studio code analysis for C++ uses SAL annotations to modify its analysis of functions. For more information about SAL 2.0 for Windows driver development, see [SAL 2.0 Annotations for Windows Drivers](http://go.microsoft.com/fwlink/?LinkId=250979).  
  
 Natively, C and C++ provide only limited ways for developers to consistently express intent and invariance. By using SAL annotations, you can describe your functions in greater detail so that developers who are consuming them can better understand how to use them.  
  
## What Is SAL and Why Should You Use It?  
 Simply stated, SAL is an inexpensive way to let the compiler check your code for you.  
  
### SAL Makes Code More Valuable  
 SAL can help you make your code design more understandable, both for humans and for code analysis tools. Consider this example that shows the C runtime function <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Can you tell what this function does? When a function is implemented or called, certain properties must be maintained to ensure program correctness. Just by looking at a declaration such as the one in the example, you don't know what they are. Without SAL annotations, you'd have to rely on documentation or code comments. Here’s what the MSDN documentation for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> says:  
  
> "Copies count bytes of src to dest. If the source and destination overlap, the behavior of memcpy is undefined. Use memmove to handle overlapping regions.   
> **Security Note:** Make sure that the destination buffer is the same size or larger than the source buffer. For more information, see Avoiding Buffer Overruns."  
  
 The documentation contains a couple of bits of information that suggest that your code has to maintain certain properties to ensure program correctness:  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> copies the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> of bytes from the source buffer to the destination buffer.  
  
-   The destination buffer must be at least as large as the source buffer.  
  
 However, the compiler can't read the documentation or informal comments. It doesn't know that there is a relationship between the two buffers and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and it also can't effectively guess about a relationship. SAL could provide more clarity about the properties and implementation of the function, as shown here:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Notice that these annotations resemble the information in the MSDN documentation, but they are more concise and they follow a semantic pattern. When you read this code, you can quickly understand the properties of this function and how to avoid buffer overrun security issues. Even better, the semantic patterns that SAL provides can improve the efficiency and effectiveness of automated code analysis tools in the early discovery of potential bugs. Imagine that someone writes this buggy implementation of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This implementation contains a common off-by-one error. Fortunately, the code author included the SAL buffer size annotation—a code analysis tool could catch the bug by analyzing this function alone.  
  
### SAL Basics  
 SAL defines four basic kinds of parameters, which are categorized by usage pattern.  
  
|Category|Parameter Annotation|Description|  
|--------------|--------------------------|-----------------|  
|**Input to called function**|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Data is passed to the called function, and is treated as read-only.|  
|**Input to called function, and output to caller**|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Usable data is passed into the function and potentially is modified.|  
|**Output to caller**|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|The caller only provides space for the called function to write to. The called function writes data into that space.|  
|**Output of pointer to caller**|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Like **Output to caller**. The value that's returned by the called function is a pointer.|  
  
 These four basic annotations can be made more explicit in various ways. By default, annotated pointer parameters are assumed to be required—they must be non-NULL for the function to succeed. The most commonly used variation of the basic annotations indicates that a pointer parameter is optional—if it's NULL, the function can still succeed in doing its work.  
  
 This table shows how to distinguish between required and optional parameters:  
  
||Parameters are required|Parameters are optional|  
|-|-----------------------------|-----------------------------|  
|**Input to called function**|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|**Input to called function, and output to caller**|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|**Output to caller**|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|**Output of pointer to caller**|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
  
 These annotations help identify possible uninitialized values and invalid null pointer uses in a formal and accurate manner. Passing NULL to a required parameter might cause a crash, or it might cause a "failed" error code to be returned. Either way, the function cannot succeed in doing its job.  
  
## SAL Examples  
 This section shows code examples for the basic SAL annotations.  
  
### Using the Visual Studio Code Analysis Tool to Find Defects  
 In the examples, the Visual Studio Code Analysis tool is used together with SAL annotations to find code defects. Here's how to do that.  
  
##### To use Visual Studio code analysis tools and SAL  
  
1.  In Visual Studio, open a C++ project that contains SAL annotations.  
  
2.  On the menu bar, choose **Build**, **Run Code Analysis on Solution**.  
  
     Consider the _In\_ example in this section. If you run code analysis on it, this warning is displayed:  
  
    > **C6387 Invalid Parameter Value**   
    > 'pInt' could be '0': this does not adhere to the specification for the function 'InCallee'.  
  
### Example: The _In\_ Annotation  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> annotation indicates that:  
  
-   The parameter must be valid and will not be modified.  
  
-   The function will only read from the single-element buffer.  
  
-   The caller must provide the buffer and initialize it.  
  
-   <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> specifies "read-only". A common mistake is to apply <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to a parameter that should have the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> annotation instead.  
  
-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is allowed but ignored by the analyzer on non-pointer scalars.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If you use Visual Studio Code Analysis on this example, it validates that the callers pass a non-Null pointer to an initialized buffer for <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. In this case, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> pointer cannot be NULL.  
  
### Example: The _In_opt\_ Annotation  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is the same as <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, except that the input parameter is allowed to be NULL and, therefore, the function should check for this.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Visual Studio Code Analysis validates that the function checks for NULL before it accesses the buffer.  
  
### Example: The _Out\_ Annotation  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> supports a common scenario in which a non-NULL pointer that points to an element buffer is passed in and the function initializes the element. The caller doesn’t have to initialize the buffer before the call; the called function promises to initialize it before it returns.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Visual Studio Code Analysis Tool validates that the caller passes a non-NULL pointer to a buffer for <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and that the buffer is initialized by the function before it returns.  
  
### Example: The _Out_opt\_ Annotation  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is the same as <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, except that the parameter is allowed to be NULL and, therefore, the function should check for this.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Visual Studio Code Analysis validates that this function checks for NULL before <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is dereferenced, and if <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is not NULL, that the buffer is initialized by the function before it returns.  
  
### Example: The _Inout\_ Annotation  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is used to annotate a pointer parameter that may be changed by the function. The pointer must point to valid initialized data before the call, and even if it changes, it must still have a valid value on return. The annotation specifies that the function may freely read from and write to the one-element buffer. The caller must provide the buffer and initialize it.  
  
> [!NOTE]
>  Like <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> must apply to a modifiable value.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Visual Studio Code Analysis validates that callers pass a non-NULL pointer to an initialized buffer for <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, and that, before return, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is still non-NULL and the buffer is initialized.  
  
### Example: The _Inout_opt\_ Annotation  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is the same as <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, except that the input parameter is allowed to be NULL and, therefore, the function should check for this.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Visual Studio Code Analysis validates that this function checks for NULL before it accesses the buffer, and if <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is not NULL, that the buffer is initialized by the function before it returns.  
  
### Example: The _Outptr\_ Annotation  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is used to annotate a parameter that's intended to return a pointer.  The parameter itself should not be NULL, and the called function returns a non-NULL pointer in it and that pointer points to initialized data.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Visual Studio Code Analysis validates that the caller passes a non-NULL pointer for <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, and that the buffer is initialized by the function before it returns.  
  
### Example: The _Outptr_opt\_ Annotation  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is the same as <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, except that the parameter is optional—the caller can pass in a NULL pointer for the parameter.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Visual Studio Code Analysis validates that this function checks for NULL before <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is dereferenced, and that the buffer is initialized by the function before it returns.  
  
### Example: The _Success\_ Annotation in Combination with _Out\_  
 Annotations  can be applied to most objects.  In particular, you can annotate a whole function.  One of the most obvious characteristics of a function is that it can succeed or fail. But like the association between a buffer and its size, C/C++ cannot express function success or failure. By using the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> annotation, you can say what success for a function looks like.  The parameter to the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> annotation is just an expression that when it is true indicates that the function has succeeded. The expression can be anything that the annotation parser can handle. The effects of the annotations after the function returns are only applicable when the function succeeds. This example shows how <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> interacts with <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to do the right thing. You can use the keyword <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to represent the return value.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> annotation causes Visual Studio Code Analysis to validate that the caller passes a non-NULL pointer to a buffer for <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, and that the buffer is initialized by the function before it returns.  
  
## SAL Best Practice  
  
### Adding Annotations to Existing Code  
 SAL is a powerful technology that can help you improve the security and reliability of your code. After you learn SAL, you can apply the new skill to your daily work. In new code, you can use SAL-based specifications by design throughout; in older code, you can add annotations incrementally and thereby increase the benefits every time you update.  
  
 Microsoft public headers are already annotated. Therefore, we suggest that in your projects you first annotate leaf node functions and functions that call Win32 APIs to get the most benefit.  
  
### When Do I Annotate?  
 Here are some guidelines:  
  
-   Annotate all pointer parameters.  
  
-   Annotate value-range annotations so that Code Analysis can ensure buffer and pointer safety.  
  
-   Annotate locking rules and locking side effects. For more information, see [Annotating Locking Behavior](../vs140/annotating-locking-behavior.md).  
  
-   Annotate driver properties and other domain-specific properties.  
  
 Or you can annotate all parameters to make your intent clear throughout and to make it easy to check that annotations have been done.  
  
## Related Resources  
 [Code Analysis Team Blog](http://go.microsoft.com/fwlink/p/?LinkId=251197)  
  
## See Also  
 [Using SAL Annotations to Reduce C/C++ Code Defects](../vs140/using-sal-annotations-to-reduce-c-c---code-defects.md)   
 [Annotating Function Parameters and Return Values](../vs140/annotating-function-parameters-and-return-values.md)   
 [Annotating Function Behavior](../vs140/annotating-function-behavior.md)   
 [Annotating Structs and Classes](../vs140/annotating-structs-and-classes.md)   
 [Annotating Locking Behavior](../vs140/annotating-locking-behavior.md)   
 [Specifying When And Where An Annotation Applies](../vs140/specifying-when-and-where-an-annotation-applies.md)   
 [Best Practices and Examples](../vs140/best-practices-and-examples--sal-.md)