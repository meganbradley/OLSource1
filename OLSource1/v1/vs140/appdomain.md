---
title: "appdomain"
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
  - "appdomain_cpp"
  - "appdomain"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "appdomain __declspec keyword"
  - "__declspec keyword [C++], appdomain"
ms.assetid: 29d843cb-cb6b-4d1b-a48d-d928a877234d
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# appdomain
Specifies that each application domain of your managed application should have its own copy of a particular global variable or static member variable. See [Application Domains and Visual C++](../vs140/application-domains-and-visual-c--.md) for more information.  
  
 Every application domain has its own copy of a per-appdomain variable. A constructor of an appdomain variable is executed when an assembly is loaded into an application domain, and the destructor is executed when the application domain is unloaded.  
  
 If you want all application domains within a process in the common language runtime to share a global variable, use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is in effect by default under [/clr](../vs140/-clr--common-language-runtime-compilation-.md) and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is in effect by default under **/clr:pure**. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is enforced under **/clr:safe**.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is only valid when one of the **/clr** compiler options is used. Only a global variable, static member variable, or a static local variable can be marked with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. It is an error to apply <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to static members of managed types because they always have this behavior.  
  
 Using <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is similar to using [Thread Local Storage (TLS)](../vs140/thread-local-storage--tls-.md). Threads have their own storage, as do application domains. Using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> ensures the global variable has its own storage in each application domain created for this application.  
  
 There are limitations to mixing the use of per process and per appdomain variables; see [process](../vs140/process.md) for more information.  
  
 For example, at program start up, all per-process variables are initialized, then all per-appdomain variables are initialized. Therefore when a per-process variable is being initialized, it cannot depend on the value of any per-application domain variable. It is bad practice to mix the use (assignment) of per appdomain and per process variables.  
  
 For information on how to call a function in a specific application domain, see [call_in_appdomain Function](../vs140/call_in_appdomain-function.md).  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **__declspec(process) CGlobal::CGlobal constructor**  
**__declspec(appdomain) CGlobal::CGlobal constructor**  
**Initial value**  
**process_global value in appdomain 'declspec_appdomain.exe': 10**  
**appdomain_global value in appdomain 'declspec_appdomain.exe': 10**  
**__declspec(appdomain) CGlobal::CGlobal constructor**  
**process_global value in appdomain 'Domain 1': 10**  
**appdomain_global value in appdomain 'Domain 1': 10**  
**__declspec(appdomain) CGlobal::CGlobal constructor**  
**process_global value in appdomain 'Domain 2': 10**  
**appdomain_global value in appdomain 'Domain 2': 10**  
**Changed value**  
**process_global value in appdomain 'declspec_appdomain.exe': 20**  
**appdomain_global value in appdomain 'declspec_appdomain.exe': 10**  
**process_global value in appdomain 'Domain 1': 20**  
**appdomain_global value in appdomain 'Domain 1': 11**  
**process_global value in appdomain 'Domain 2': 20**  
**appdomain_global value in appdomain 'Domain 2': 12**  
**__declspec(appdomain) CGlobal::~CGlobal destructor**  
**__declspec(appdomain) CGlobal::~CGlobal destructor**  
**__declspec(appdomain) CGlobal::~CGlobal destructor**  
**__declspec(process) CGlobal::~CGlobal destructor**   
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)