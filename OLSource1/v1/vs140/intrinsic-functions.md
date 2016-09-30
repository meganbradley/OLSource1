---
title: "Intrinsic Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_String_length_"
  - "_Param_"
  - "_Curr_"
  - "_Old_"
  - "_Nullterm_length_"
  - "_Inexpressible_"
ms.assetid: adf29f8c-89fd-4a5e-9804-35ac83e1c457
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Intrinsic Functions
An expression in SAL can be a C/C++ expression provided that it is an expression that does not have side effects—for example, ++, --, and function calls all have side effects in this context.  However, SAL does provide some function-like objects and some reserved symbols that can be used in SAL expressions. These are referred to as *intrinsic functions*.  
  
## General Purpose  
 The following instrinsic function annotations provide general utility for SAL.  
  
|Annotation|Description|  
|----------------|-----------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|A synonym for the object that is currently being annotated.  When the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> annotation is in use, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the same as the first parameter to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  Otherwise, it is the parameter or the entire function/return value with which the annotation is lexically associated.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Expresses a situation where the size of a buffer is too complex to represent by using an annotation expression—for example, when it is computed by scanning an input data set and then counting selected members.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the number of elements in the buffer up to but not including a null terminator. It may be applied to any buffer of non-aggregate, non-void type.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|When it is evaluated in precondition, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns the input value <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  When it is evaluated in post-condition, it returns the value <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> as it would have been evaluated in precondition.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>th parameter to a function, counting from 1 to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a literal integral constant. If the parameter is named, this annotation is identical to accessing the parameter by name. **Note:**  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> may refer to the positional parameters that are defined by an ellipsis, or may be used in function prototypes where names are not used.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|The C/C++ reserved keyword <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> can be used in a SAL expression to indicate the return value of a function.  The value is only available in post state; it is a syntax error to use it in pre state.|  
  
## String Specific  
 The following intrinsic function annotations enable manipulation of strings. All four of these functions serve the same purpose: to return the number of elements of the type that is found before a null terminator. The differences are the kinds of data in the elements that are referred to. Note that if you want to specify the length of a null-terminated buffer that is not composed of characters, use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> annotation from the previous section.  
  
|Annotation|Description|  
|----------------|-----------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is the number of elements in the string up to but not including a null terminator. This annotation is reserved for string-of-character types.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is the number of elements in the string up to but not including a null terminator. This annotation is reserved for use on character arrays and resembles the C Runtime function [strlen()](../vs140/strlen--wcslen--_mbslen--_mbslen_l--_mbstrlen--_mbstrlen_l.md).|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is the number of elements in the string up to (but not including) a null terminator. This annotation is reserved for use on wide character arrays and resembles the C Runtime function [wcslen()](../vs140/strlen--wcslen--_mbslen--_mbslen_l--_mbstrlen--_mbstrlen_l.md).|  
  
## See Also  
 [Using SAL Annotations to Reduce C/C++ Code Defects](../vs140/using-sal-annotations-to-reduce-c-c---code-defects.md)   
 [Understanding SAL](../vs140/understanding-sal.md)   
 [Annotating Function Parameters and Return Values](../vs140/annotating-function-parameters-and-return-values.md)   
 [Annotating Function Behavior](../vs140/annotating-function-behavior.md)   
 [Annotating Structs and Classes](../vs140/annotating-structs-and-classes.md)   
 [Annotating Locking Behavior](../vs140/annotating-locking-behavior.md)   
 [Specifying When And Where An Annotation Applies](../vs140/specifying-when-and-where-an-annotation-applies.md)   
 [Best Practices and Examples](../vs140/best-practices-and-examples--sal-.md)