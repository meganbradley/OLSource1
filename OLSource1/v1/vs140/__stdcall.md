---
title: "__stdcall"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "__stdcall_cpp"
  - "__stdcall"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__stdcall keyword [C++]"
ms.assetid: e212594b-1827-4d07-9527-7d412b300df8
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __stdcall
**Microsoft Specific**  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> calling convention is used to call Win32 API functions. The callee cleans the stack, so the compiler makes **vararg** functions <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Functions that use this calling convention require a function prototype.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The following list shows the implementation of this calling convention.  
  
|Element|Implementation|  
|-------------|--------------------|  
|Argument-passing order|Right to left.|  
|Argument-passing convention|By value, unless a pointer or reference type is passed.|  
|Stack-maintenance responsibility|Called function pops its own arguments from the stack.|  
|Name-decoration convention|An underscore (_) is prefixed to the name. The name is followed by the at sign (@) followed by the number of bytes (in decimal) in the argument list. Therefore, the function declared as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is decorated as follows: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|Case-translation convention|None|  
  
 The [/Gz](../vs140/-gd---gr---gv---gz--calling-convention-.md) compiler option specifies <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for all functions not explicitly declared with a different calling convention.  
  
 Functions declared using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> modifier return values the same way as functions declared using [__cdecl](../vs140/__cdecl.md).  
  
 On ARM and x64 processors, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is accepted and ignored by the compiler; on ARM and x64 architectures, by convention, arguments are passed in registers when possible, and subsequent arguments are passed on the stack.  
  
 For non-static class functions, if the function is defined out-of-line, the calling convention modifier does not have to be specified on the out-of-line definition. That is, for class non-static member methods, the calling convention specified during declaration is assumed at the point of definition. Given this class definition,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 this  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 is equivalent to this  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 In the following example, use of __**stdcall** results in all <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function types being handled as a standard call:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Argument Passing and Naming Conventions](../vs140/argument-passing-and-naming-conventions.md)   
 [Keywords](../vs140/keywords--c---.md)