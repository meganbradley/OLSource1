---
title: "Best Practices and Examples (SAL)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 666276fb-99c2-4dc9-8bac-d74861c203ea
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Best Practices and Examples (SAL)
Here are some ways to get the most out of the Source Code Annotation Language (SAL) and avoid some common problems.  
  
## _In\_  
 If the function is supposed to write to the element, use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. This is particularly relevant in cases of automated conversion from older macros to SAL. Prior to SAL, many programmers used macros as comments—macros that were named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, or variants of these names. Although we recommend that you convert these macros to SAL, we also urge you to be careful when you convert them because the code might have changed since the original prototype was written and the old macro might no longer reflect what the code does. Be especially careful about the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> comment macro because it is frequently placed incorrectly—for example, on the wrong side of a comma.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## _opt\_  
 If the caller is not allowed to pass in a null pointer, use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. This applies even to a function that checks its parameters and returns an error if it is NULL when it should not be. Although having a function check its parameter for unexpected NULL and return gracefully is a good defensive coding practice, it does not mean that the parameter annotation can be of an optional type (_*Xxx*_opt\_).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## _Pre_defensive\_ and _Post_defensive\_  
 If a function appears at a trust boundary, we recommend that you use the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> annotation.  The "defensive" modifier modifies certain annotations to indicate that, at the point of call, the interface should be checked strictly, but in the implementation body it should assume that incorrect parameters might be passed. In that case, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is preferred at a trust boundary to indicate that although a caller will get an error if it attempts to pass NULL, the function body will be analyzed as if the parameter might be NULL, and any attempts to de-reference the pointer without first checking it for NULL will be flagged.  A <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> annotation is also available, for use in callbacks where the trusted party is assumed to be the caller and the untrusted code is the called code.  
  
## _Out_writes\_  
 The following example demonstrates a common misuse of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The annotation <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> signifies that you have a buffer. It has <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> bytes allocated, with the first byte initialized on exit. This annotation is not strictly wrong and it is helpful to express the allocated size. However, it does not tell how many elements are initialized by the function.  
  
 The next example shows three correct ways to fully specify the exact size of the initialized portion of the buffer.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## _Out\_ PSTR  
 The use of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is almost always wrong. This is interpreted as having an output parameter that points to a character buffer and it is NULL-terminated.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An annotation like <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is common and useful. It points to an input string that has NULL termination because the precondition of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> allows the recognition of a NULL-terminated string.  
  
## _In\_ WCHAR* p  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> says that there is an input pointer <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> that points to one character. However, in most cases, this is probably not the specification that is intended. Instead, what is probably intended is the specification of a NULL-terminated array; to do that, use <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Missing the proper specification of NULL termination is common. Use the appropriate <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> version to replace the type, as shown in the following example.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## _Out_range\_  
 If the parameter is a pointer and you want to express the range of the value of the element that is pointed to by the pointer, use <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. In the following example, the range of *pcbFilled is expressed, not pcbFilled.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is not strictly required for some tools because it can be inferred from <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, but it is shown here for completeness.  
  
## Wrong Context in _When\_  
 Another common mistake is to use post-state evaluation for preconditions. In the following example, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is a precondition.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The expression <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> refers to a post-state value that is not available in pre-state.  
  
## TRUE in _Success\_  
 If the function succeeds when the return value is nonzero, use <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> as the success condition instead of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. Nonzero does not necessarily mean equivalence to the actual value that the compiler provides for <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. The parameter to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is an expression, and the following expressions are evaluated as equivalent: <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> with no parameters or comparisons.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Reference Variable  
 For a reference variable, the previous version of SAL used the implied pointer as the annotation target and required the addition of a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to annotations that attached to a reference variable. This version uses the object itself and does not require the additional <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## Annotations on Return Values  
 The following example shows a common problem in return value annotations.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 In this example, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> says that the pointer might be NULL as part of the precondition. However, preconditions cannot be applied to the return value. In this case, the correct annotation is <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
## See Also  
 [Using SAL Annotations to Reduce C/C++ Code Defects](../vs140/using-sal-annotations-to-reduce-c-c---code-defects.md)   
 [Understanding SAL](../vs140/understanding-sal.md)   
 [Annotating Function Parameters and Return Values](../vs140/annotating-function-parameters-and-return-values.md)   
 [Annotating Function Behavior](../vs140/annotating-function-behavior.md)   
 [Annotating Structs and Classes](../vs140/annotating-structs-and-classes.md)   
 [Annotating Locking Behavior](../vs140/annotating-locking-behavior.md)   
 [Specifying When And Where An Annotation Applies](../vs140/specifying-when-and-where-an-annotation-applies.md)   
 [Intrinsic Functions](../vs140/intrinsic-functions.md)