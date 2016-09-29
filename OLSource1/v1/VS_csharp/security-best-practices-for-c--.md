---
title: "Security Best Practices for C++"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "securitybestpracticesVC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Visual C++, security"
  - "security [C++]"
  - "security [C++], best practices"
ms.assetid: 86acaccf-cdb4-4517-bd58-553618e3ec42
caps.latest.revision: 49
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Security Best Practices for C++
This article contains information about security tools and practices. Using them does not make applications immune from attack, but it makes successful attacks less likely.  
  
## Visual C++ Security Features  
 These security features are built into the Visual C++ compiler and linker:  
  
 [/guard (Enable Control Flow Guard)](../VS_csharp/-guard--enable-control-flow-guard-.md)  
 Causes the compiler to to analyze control flow for indirect call targets at compile time, and then to insert code to verify the targets at runtime.  
  
 [/GS (Buffer Security Check)](../VS_csharp/-gs--buffer-security-check-.md)  
 Instructs the compiler to insert overrun detection code into functions that are at risk of being exploited. When an overrun is detected, execution is stopped. By default, this option is on.  
  
 [/SAFESEH (Image has Safe Exception Handlers)](../VS_csharp/-safeseh--image-has-safe-exception-handlers-.md)  
 Instructs the linker to include in the output image a table that contains the address of each exception handler. At run time, the operating system uses this table to make sure that only legitimate exception handlers are executed. This helps prevent the execution of exception handlers that are introduced by a malicious attack at run time. By default, this option is off.  
  
 [/NXCOMPAT](../VS_csharp/-nxcompat.md), [/NXCOMPAT (Compatible with Data Execution Prevention)](../VS_csharp/-nxcompat--compatible-with-data-execution-prevention-.md)  
 These compiler and linker options enable Data Execution Prevention (DEP) compatibility. DEP guards the CPU against the execution of non-code pages.  
  
 [/analyze](../VS_csharp/-analyze--code-analysis-.md)  
 This compiler option activates code analysis that reports potential security issues such as buffer overrun, un-initialized memory, null pointer dereferencing, and memory leaks. By default, this option is off. For more information, see [Code Analysis for C/C++ Overview](../VS_csharp/code-analysis-for-c-c---overview.md).  
  
 [/DYNAMICBASE (Use Address Space Layout Randomization)](../VS_csharp/-dynamicbase--use-address-space-layout-randomization-.md)  
 This linker option enables the building of an executable image that can be loaded at different locations in memory at the beginning of execution. This option also makes the stack location in memory much less predictable.  
  
## Security-Enhanced CRT  
 The C Runtime Library (CRT) has been augmented to include secure versions of functions that pose security risks—for example, the unchecked `strcpy` string copy function. Because the older, nonsecure versions of these functions are deprecated, they cause compile-time warnings. We encourage you to use the secure versions of these CRT functions instead of suppressing the compilation warnings. For more information, see [Security Enhancements in the CRT](../VS_csharp/security-features-in-the-crt.md).  
  
## SafeInt Library  
 [The SafeInt Library](../VS_csharp/safeint-library.md) helps prevent integer overflows and other exploitable errors that might occur when the application performs mathematical operations. The `SafeInt` library includes the [SafeInt Class](../VS_csharp/safeint-class.md), the [SafeIntException Class](../VS_csharp/safeintexception-class.md), and several [SafeInt Functions](../VS_csharp/safeint-functions.md).  
  
 The `SafeInt` class protects against integer overflow and divide-by-zero exploits. You can use it to handle comparisons between values of different types. I provides two error handling policies. The default policy is for the `SafeInt` class to throw a `SafeIntException` class exception to report why a mathematical operation cannot be completed. The second policy is for the `SafeInt` class to stop program execution. You can also define a custom policy.  
  
 Each `SafeInt` function protects one mathematical operation from an exploitable error. You can use two different kinds of parameters without converting them to the same type. To protect multiple mathematical operations, use the `SafeInt` class.  
  
## Checked Iterators  
 A checked iterator enforces container boundaries. By default, when a checked iterator is out of bounds, it generates an exception and ends program execution. A checked iterator provides other levels of response that depend on values that are assigned to preprocessor defines such as **_SECURE_SCL_THROWS** and **_ITERATOR_DEBUG_LEVEL**. For example, at **_ITERATOR_DEBUG_LEVEL=2**, a checked iterator provides comprehensive correctness checks in debug mode, which are made available by using asserts. For more information, see [Checked Iterators](../VS_csharp/checked-iterators.md).  
  
## Code Analysis for Managed Code  
 Code Analysis for Managed Code, also known as FxCop, checks assemblies for conformance to the.NET Framework design guidelines. FxCop analyzes the code and metadata in each assembly to check for defects in the following areas:  
  
-   Library design  
  
-   Localization  
  
-   Naming conventions  
  
-   Performance  
  
-   Security  
  
## Windows Application Verifier  
 The Application Verifier (AppVerifier) can help you identify potential application compatibility, stability, and security issues.  
  
 The AppVerifier monitors how an application uses the operating system. It watches the file system, registry, memory, and APIs while the application is running, and recommends source-code fixes for issues that it uncovers.  
  
 You can use the AppVerifier to:  
  
-   Test for potential application compatibility errors that are caused by common programming mistakes.  
  
-   Examine an application for memory-related issues.  
  
-   Identify potential security issues in an application.  
  
 The AppVerifier is part of the Application Compatibility Toolkit, which is available from the [Application Compatibility](http://go.microsoft.com/fwlink/?LinkId=91277) on the TechNet web site.  
  
## .NET Framework Security Features  
 [NIB: Configuring Security Policy](assetId:///0f130bcd-1bba-4346-b231-0bcca7dab1a4) describes guidelines and tools for adjusting the .NET Framework security policies.  
  
## Windows User Accounts  
 Using Windows user accounts that belong to the Administrators group exposes developers and--by extension--customers to security risks. For more information, see [Running as a Member of the Users Group](../VS_csharp/running-as-a-member-of-the-users-group.md) and [How User Account Control (UAC) Affects Your Application](../VS_csharp/how-user-account-control--uac--affects-your-application.md).  
  
## See Also  
 <xref:System.Security*>   
 [Securing Applications](assetId:///9a9621d7-8883-4a4f-a874-65e8e09e20a6)   
 [How User Account Control (UAC) Affects Your Application](../VS_csharp/how-user-account-control--uac--affects-your-application.md)