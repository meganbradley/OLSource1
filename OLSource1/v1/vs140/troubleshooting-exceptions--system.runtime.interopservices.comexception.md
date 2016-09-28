---
title: "Troubleshooting Exceptions: System.Runtime.InteropServices.COMException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "EHCOM"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "COMException class"
ms.assetid: 14b6de51-e039-4db7-9321-06c9e16e328a
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Runtime.InteropServices.COMException
A <xref:System.Runtime.InteropServices.COMException*> exception is thrown when an unrecognized HRESULT is returned from a COM method call.  
  
## Associated Tips  
 **Check the ErrorCode property of the exception to determine the HRESULT returned by the COM object**  
 When the runtime encounters an unfamiliar HRESULT, it throws a <xref:System.Runtime.InteropServices.COMException*> exception, which includes a public `ErrorCode` property that contains the HRESULT returned by the call. If an error message is available to the runtime, the message is returned to the caller. However, if the COM component developer fails to include an error message, the runtime returns the eight-digit HRESULT in place of a message string. Having an HRESULT allows the caller to determine the cause of the exception. For more information, see [How to: Map HRESULTs and Exceptions](assetId:///610b364b-2761-429d-9c4a-afbc3e66f1b9).  
  
 **Disable the hosting process.**  
 COM is used to communicate between [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and the hosting process. Because it is used before code runs, a call to `CoInitializeSecurity` causes this exception to be thrown.  
  
### Remarks  
 The common language runtime (CLR) transforms well-known HRESULTS to .NET exceptions, enabling COM objects to return meaningful error information to managed clients. The HRESULT to exception mapping also works in the other direction by returning specific HRESULTS to unmanaged clients.  
  
 When passing late-bound parameters to methods of Microsoft Office objects, a <xref:System.Runtime.InteropServices.COMException*> exception may be thrown when the objects are COM objects. The late binder assumes that such method calls involve a `ByRef` parameter and that the property you pass has a `Set` accessor. If the property does not, the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] generates a <xref:System.MissingMethodException*> exception (HRESULT CORE_E_MISSINGMETHOD). To work around this behavior, use early-bound objects or pass a variable instead of a property of the object.  
  
## See Also  
 <xref:System.Runtime.InteropServices.COMException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)   
 [Handling COM Interop Exceptions](assetId:///e6104aa8-8e5f-4069-b864-def85579c96c)