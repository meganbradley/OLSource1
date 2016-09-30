---
title: "Error Handling and Return Values"
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
  - "errors [Visual Studio SDK], handling"
  - "error handling"
  - "return values"
ms.assetid: b2d9079d-39a6-438a-8010-290056694b5c
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Error Handling and Return Values
VSPackages and COM use the same architecture for errors. The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> functions are part of the Win32 application programming interface (API). Any VSPackage in the integrated development environment (IDE) can call these global Win32 APIs to record rich error information when receiving an error notification. The [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] provides interop assemblies to manage error information.  
  
## Interop Methods  
 As a convenience, the IDE provides a method, \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo*>, to use instead of calling the Win32 APIs. In managed code use \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo*>. When an error <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> arrives at the level where the error message should be displayed (this is often the object implementing an \<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget*> command handler), the IDE uses another method, \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ReportErrorInfo*>, to display the appropriate message box. In managed code use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ReportErrorInfo*> method.  
  
 As a VSPackage implementer, your COM objects normally implement <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface ensures that rich error information can move vertically up the call chain. Objects that might be used across processes or across threads must support <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to ensure that the rich error information is properly marshaled back to the caller.  
  
 All objects that are related to VSPackages and that are involved in extending the IDE, including editor factories, editors, hierarchies, and offered services, should support rich error information. While the IDE does not require these VSPackage objects to implement <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, it is always encouraged.  
  
 The IDE is responsible for reporting error information and displaying it to a user of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] whenever an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is propagated to the IDE. The IDE is also the mechanism for creating <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects.  
  
## General Guidelines  
 You can use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo*> and \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ReportErrorInfo*> methods to set and report errors that are internal to your VSPackage implementation as well. However, as a general rule, follow these guidelines for handling error messages in your VSPackage:  
  
-   Implement <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in your VSPackage COM objects.  
  
-   Create an error reporting mechanism that calls the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo*> method in objects that implement \<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget*>.  
  
-   Let the IDE display errors to users through the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ReportErrorInfo*> method.  
  
## Error Information in the IDE  
 The following rules indicate how to handle error information in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] IDE:  
  
-   As a defensive strategy to guarantee that stale error info is not reported to users, functions that call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ReportErrorInfo*> method should first call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo*> method. Pass in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to clear cached error messages before calling anything that might set new error information.  
  
-   Functions that do not directly report error messages are only allowed to call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo*> method if they are returning an error <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. It is permissible to clear the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> on the entry to a function or when returning \<xref:Microsoft.VisualStudio.VSConstants.S_OK*>. The only exception to this rule is when a call returns an error <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> from which the receiving party can explicitly recover or safely ignore.  
  
-   Any party that explicitly ignores an error <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> must call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo*> method with \<xref:Microsoft.VisualStudio.VSConstants.S_OK*>. Otherwise, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object might be accidentally used when another party generates an error without providing their own <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
-   All methods that originate an error <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> are encouraged to call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo*> method to provide rich error information. If the returned <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a special <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> error, then the method is required to provide a proper <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>object. If the returned error is a standard system error (for example, \<xref:Microsoft.VisualStudio.VSConstants.E_OUTOFMEMORY*>, \<xref:Microsoft.VisualStudio.VSConstants.E_ABORT*>, \<xref:Microsoft.VisualStudio.VSConstants.E_INVALIDARG*>, \<xref:Microsoft.VisualStudio.VSConstants.E_UNEXPECTED*>, and so on.) it is acceptable to return the error code without explicitly calling the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo*> method. As a defensive coding strategy, when originating an error <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> (including system errors), always call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.SetErrorInfo*> method, either with <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> describing the failure in greater detail, or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
-   All functions that return an error originated by another call must pass on the information that was received from the failing call in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> without modifying the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
## See Also  
 \<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget*>   
 [SetErrorInfo (Component Automation)](assetId:///8eaacfac-fc37-4eaa-870b-10b99d598d66)   
 [GetErrorInfo](assetId:///03317526-8c4f-4173-bc10-110c8112676a)   
 [ISupportErrorInfo Interface](assetId:///42d33066-36b4-4a5b-aa5d-46682e560f32)