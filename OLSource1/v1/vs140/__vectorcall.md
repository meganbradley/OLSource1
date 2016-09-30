---
title: "__vectorcall"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
ms.assetid: 1c95ed59-86c6-4857-b4ed-10519193f851
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __vectorcall
**Microsoft Specific**  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> calling convention specifies that arguments to functions are to be passed in registers, when possible. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> uses more registers for arguments than [__fastcall](../vs140/__fastcall.md) or the default [x64 calling convention](../vs140/overview-of-x64-calling-conventions.md) use. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> calling convention is only supported in native code on x86 and x64 processors that include Streaming SIMD Extensions 2 (SSE2) and above. Use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to speed functions that pass several floating-point or SIMD vector arguments and perform operations that take advantage of the arguments loaded in registers. The following list shows the features that are common to the x86 and x64 implementations of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The differences are explained later in this article.  
  
|Element|Implementation|  
|-------------|--------------------|  
|C name-decoration convention|Function names are suffixed with two "at" signs (@@) followed by the number of bytes (in decimal) in the parameter list.|  
|Case-translation convention|No case translation is performed.|  
  
 Using the [/Gv](../vs140/-gd---gr---gv---gz--calling-convention-.md) compiler option causes each function in the module to compile as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> unless the function is a member function, is declared with a conflicting calling convention attribute, uses a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> variable argument list, or has the name <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 You can pass three kinds of arguments by register in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> functions: *integer type* values, *vector type* values, and *homogeneous vector aggregate* (HVA) values.  
  
 An integer type satisfies two requirements: it fits in the native register size of the processor—for example, 4 bytes on an x86 machine or 8 bytes on an x64 machine—and it’s convertible to an integer of register length and back again without changing its bit representation. For example, any type that can be promoted to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> on x86 (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> on x64)—for example, a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>—or that can be cast to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> on x64) and back to its original type without change is an integer type. Integer types include pointer, reference, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> types of 4 bytes (8 bytes on x64) or less. On x64 platforms, larger <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> types are passed by reference to memory allocated by the caller; on x86 platforms, they are passed by value on the stack.  
  
 A vector type is either a floating-point type—for example, a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>—or an SIMD vector type—for example, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 An HVA type is a composite type of up to four data members that have identical vector types. An HVA type has the same alignment requirement as the vector type of its members. This is an example of an HVA <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> definition that contains three identical vector types and has 32-byte alignment:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Declare your functions explicitly with the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> keyword in header files to allow separately compiled code to link without errors. Functions must be prototyped to use <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, and can’t use a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> variable length argument list.  
  
 A member function may be declared by using the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> specifier. The hidden <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> pointer is passed by register as the first integer type argument.  
  
 On ARM machines, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is accepted and ignored by the compiler.  
  
 For non-static class member functions, if the function is defined out-of-line, the calling convention modifier does not have to be specified on the out-of-line definition. That is, for class non-static members, the calling convention specified during declaration is assumed at the point of definition. Given this class definition:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 is equivalent to this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> calling convention modifier must be specified when a pointer to a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> function is created. The next example creates a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> for a pointer to a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> function that takes four <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> arguments and returns an <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> value:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## __vectorcall convention on x64  
 The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> calling convention on x64 extends the standard x64 calling convention to take advantage of additional registers. Both integer type arguments and vector type arguments are mapped to registers based on position in the argument list. HVA arguments are allocated to unused vector registers.  
  
 When any of the first four arguments in order from left to right are integer type arguments, they are passed in the register that corresponds to that position—RCX, RDX, R8, or R9. A hidden <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> pointer is treated as the first integer type argument. When an HVA argument in one of the first four arguments can’t be passed in the available registers, a reference to caller-allocated memory is passed in the corresponding integer type register instead. Integer type arguments after the fourth parameter position are passed on the stack.  
  
 When any of the first six arguments in order from left to right are vector type arguments, they are passed by value in SSE vector registers 0 to 5 according to argument position. Floating-point and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> types are passed in XMM registers, and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> types are passed in YMM registers. This differs from the standard x64 calling convention, because the vector types are passed by value instead of by reference, and additional registers are used. The shadow stack space allocated for vector type arguments is fixed at 8 bytes, and the [/homeparams](../vs140/-homeparams--copy-register-parameters-to-stack-.md) option does not apply. Vector type arguments in the seventh and later parameter positions are passed on the stack by reference to memory allocated by the caller.  
  
 After registers are allocated for vector arguments, the data members of HVA arguments are allocated, in ascending order, to unused vector registers XMM0 to XMM5 (or YMM0 to YMM5, for <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> types), as long as there are enough registers available for the entire HVA. If not enough registers are available, the HVA argument is passed by reference to memory allocated by the caller. The stack shadow space for an HVA argument is fixed at 8 bytes with undefined content. HVA arguments are assigned to registers in order from left to right in the parameter list, and may be in any position. HVA arguments in one of the first four argument positions that are not assigned to vector registers are passed by reference in the integer register that corresponds to that position. HVA arguments passed by reference after the fourth parameter position are pushed on the stack.  
  
 Results of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> functions are returned by value in registers when possible. Results of integer type, including structs or unions of 8 bytes or less, are returned by value in RAX. Vector type results are returned by value in XMM0 or YMM0, depending on size. HVA results have each data element returned by value in registers XMM0:XMM3 or YMM0:YMM3, depending on element size. Result types that don't fit in the corresponding registers are returned by reference to memory allocated by the caller.  
  
 The stack is maintained by the caller in the x64 implementation of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. The caller prolog and epilog code allocates and clears the stack for the called function. Arguments are pushed on the stack from right to left, and shadow stack space is allocated for arguments passed in registers.  
  
 Examples:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## __vectorcall convention on x86  
 The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> calling convention follows the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> convention for 32-bit integer type arguments, and takes advantage of the SSE vector registers for vector type and HVA arguments.  
  
 The first two integer type arguments found in the parameter list from left to right are placed in ECX and EDX, respectively. A hidden <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> pointer is treated as the first integer type argument, and is passed in ECX. The first six vector type arguments are passed by value through SSE vector registers 0 to 5, in the XMM or YMM registers, depending on argument size.  
  
 The first six vector type arguments in order from left to right are passed by value in SSE vector registers 0 to 5. Floating-point and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> types are passed in XMM registers, and <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> types are passed in YMM registers. No shadow stack space is allocated for vector type arguments passed by register. The seventh and subsequent vector type arguments are passed on the stack by reference to memory allocated by the caller. The limitation of compiler error [C2719](../vs140/compiler-error-c2719.md) does not apply to these arguments.  
  
 After registers are allocated for vector arguments, the data members of HVA arguments are allocated in ascending order to unused vector registers XMM0 to XMM5 (or YMM0 to YMM5, for <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> types), as long as there are enough registers available for the entire HVA. If not enough registers are available, the HVA argument is passed on the stack by reference to memory allocated by the caller. No stack shadow space for an HVA argument is allocated. HVA arguments are assigned to registers in order from left to right in the parameter list, and may be in any position.  
  
 Results of <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> functions are returned by value in registers when possible. Results of integer type, including structs or unions of 4 bytes or less, are returned by value in EAX. Integer type structs or unions of 8 bytes or less are returned by value in EDX:EAX. Vector type results are returned by value in XMM0 or YMM0, depending on size. HVA results have each data element returned by value in registers XMM0:XMM3 or YMM0:YMM3, depending on element size. Other result types are returned by reference to memory allocated by the caller.  
  
 The x86 implementation of <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> follows the convention of arguments pushed on the stack from right to left by the caller, and the called function clears the stack just before it returns. Only arguments that are not placed in registers are pushed on the stack.  
  
 Examples:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **End Microsoft Specific**  
  
## See Also  
 [Argument Passing and Naming Conventions](../vs140/argument-passing-and-naming-conventions.md)   
 [Keywords](../vs140/keywords--c---.md)