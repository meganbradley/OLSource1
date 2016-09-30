---
title: "Registering an Expression Evaluator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], expression evaluation"
  - "expression evaluators, registering"
ms.assetid: 236be234-e05f-4ad8-9200-24ce51768ecf
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Registering an Expression Evaluator
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 The expression evaluator (EE) must register itself as a class factory with both the Windows COM environment and Visual Studio. An EE is implemented as a DLL so that it may be injected into either the debug engine (DE) address space or the Visual Studio address space, depending on which entity instantiates the EE.  
  
## Managed Code Expression Evaluator  
 A managed code EE is implemented as a Class Library, which is a DLL that registers itself with the COM environment, typically started by a call to the VSIP program, **regpkg.exe**. The actual process of writing the registry keys for the COM environment is handled automatically.  
  
 A method of the main class is marked with the \<xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute*>, indicating that that method is to be called when the DLL is being registered with COM. This registration method, often called <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, performs the task of registering the DLL with Visual Studio. A corresponding <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (marked with the \<xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute*>), undoes the effects of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> when the DLL is uninstalled.  
  
 The same registry entries are made as for an EE written in unmanaged code; the only difference is that there is no helper function such as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to do the work for you. An example of this registration/unregistration process looks like this:  
  
### Example  
 This function shows how a managed code EE registers and unregisters itself with Visual Studio.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Unmanaged Code Expression Evaluator  
 The EE DLL implements the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function to register itself with the  COM environment as well as Visual Studio.  
  
> [!NOTE]
>  The MyCEE code sample registry code can be found in the file dllentry.cpp, which is located in the VSIP installation under EnVSDK\MyCPkgs\MyCEE.  
  
### DLL Server Process  
 When registering the EE, the DLL server:  
  
1.  Registers its class factory <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> as per normal COM conventions.  
  
2.  Calls the helper function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to register with Visual Studio the EE metrics shown in the following table. The function <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and the metrics specified below are part of the dbgmetric.lib library. See [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md) for details.  
  
    |Metric|Description|  
    |------------|-----------------|  
    |<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> of the EE class factory|  
    |<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Name of the EE as a displayable string|  
    |<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The name of the language that the EE is designed to evaluate|  
    |<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>s of the debug engines (DE) that work with this EE|  
  
    > [!NOTE]
    >  The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> identifies the language by name, but it is the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> that selects the language. When the compiler generates the debug information file, it should write the appropriate <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> so that the DE knows which EE to use. The DE typically asks the symbol provider for this language <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, which is stored in the debug information file.  
  
3.  Registers with Visual Studio by creating keys under HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*X.Y*, where *X.Y* is the version of Visual Studio to register with.  
  
### Example  
 This function shows how an unmanaged code (C++) EE registers and unregisters itself with Visual Studio.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Writing a Common Language Runtime Expression Evaluator](../vs140/writing-a-common-language-runtime-expression-evaluator.md)   
 [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md)