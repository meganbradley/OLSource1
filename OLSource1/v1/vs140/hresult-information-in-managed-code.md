---
title: "HRESULT Information in Managed Code"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - VSPackages, HRESULT information
  - HRESULT, managed VSPackages
ms.assetid: 0795ee94-17a8-4327-bf57-27cd5e312a4c
caps.latest.revision: 33
translation.priority.ht: 
  - de-de
  - ja-jp
---
# HRESULT Information in Managed Code
The interaction between managed code and COM can cause problems when HRESULT return values are encountered.  
  
 In a COM interface, an HRESULT return value can play these roles:  
  
-   Deliver error information (for example, <xref:Microsoft.VisualStudio.VSConstants.E_INVALIDARG?qualifyHint=False>).  
  
-   Deliver status information about normal program behavior.  
  
 When COM calls into managed code, HRESULTs can cause these problems:  
  
-   COM functions that return HRESULT values less than zero (failure codes) generate exceptions.  
  
-   COM methods that regularly return two or more different success codes, for example, <xref:Microsoft.VisualStudio.VSConstants.S_OK?qualifyHint=False> or <xref:Microsoft.VisualStudio.VSConstants.S_FALSE?qualifyHint=False>, cannot be distinguished.  
  
 Because many of the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] COM functions either return HRESULT values less than zero or return different success codes, the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] interop assemblies have been written so that the method signatures are preserved. All [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] interop methods are of `int` type. HRESULT values are passed through the interop layer without alteration and without generating exceptions.  
  
 Because a COM function returns an HRESULT to the managed method that calls it, the calling method must check the HRESULT and throw exceptions as necessary.  
  
## Handling HRESULTs Returned to Managed Code from COM  
 When you call a COM interface from managed code, examine the HRESULT value and throw an exception if required. The <xref:Microsoft.VisualStudio.ErrorHandler?qualifyHint=False> class contains the <xref:Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure?qualifyHint=False> method, which throws a COM exception, depending on the value of the HRESULT passed to it.  
  
 By default, <xref:Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure?qualifyHint=False> throws an exception whenever it is passed an HRESULT that has a value less than zero. In cases where such HRESULTs are acceptable values and no exception should be thrown, the values of additional HRESULTS should be passed to <xref:Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure?qualifyHint=False> after the values are tested. If the HRESULT being tested matches any HRESULT values explicitly passed to <xref:Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure?qualifyHint=False>, no exception is thrown.  
  
> [!NOTE]
>  The <xref:Microsoft.VisualStudio.VSConstants?qualifyHint=False> class contains constants for common HRESULTS, for example, <xref:Microsoft.VisualStudio.VSConstants.S_OK?qualifyHint=False> and <xref:Microsoft.VisualStudio.VSConstants.E_NOTIMPL?qualifyHint=False>, and [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] HRESULTS, for example, <xref:Microsoft.VisualStudio.VSConstants.VS_E_INCOMPATIBLEDOCDATA?qualifyHint=False> and <xref:Microsoft.VisualStudio.VSConstants.VS_E_UNSUPPORTEDFORMAT?qualifyHint=False>. <xref:Microsoft.VisualStudio.VSConstants?qualifyHint=False> also provides the <xref:Microsoft.VisualStudio.ErrorHandler.Succeeded?qualifyHint=False> and <xref:Microsoft.VisualStudio.ErrorHandler.Failed?qualifyHint=False> methods, which correspond to the SUCCEEDED and FAILED macros in COM.  
  
 For example, consider the following function call, in which <xref:Microsoft.VisualStudio.VSConstants.E_NOTIMPL?qualifyHint=False> is an acceptable return value but any other HRESULT less than zero represents an error.  
  
 [!code[VSSDKHRESULTInformation#1](../vs140/codesnippet/VisualBasic/hresult-information-in-managed-code_1.vb)]
[!code[VSSDKHRESULTInformation#1](../vs140/codesnippet/CSharp/hresult-information-in-managed-code_1.cs)]
  
  
 If there are more than one acceptable return values, additional HRESULT values can just be appended to the list in the call to <xref:Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure?qualifyHint=False>.  
  
 [!code[VSSDKHRESULTInformation#2](../vs140/codesnippet/VisualBasic/hresult-information-in-managed-code_2.vb)]
[!code[VSSDKHRESULTInformation#2](../vs140/codesnippet/CSharp/hresult-information-in-managed-code_2.cs)]
  
  
## Returning HRESULTS to COM from Managed Code  
 If no exception occurs, managed code returns <xref:Microsoft.VisualStudio.VSConstants.S_OK?qualifyHint=False> to the COM function that called it. COM interop supports common exceptions that are strongly typed in managed code. For example, a method that receives an unacceptable `null` argument throws an <xref:System.ArgumentNullException?qualifyHint=False>.  
  
 If you are not certain which exception to throw, but you know the HRESULT you want to return to COM, you can use the <xref:System.Runtime.InteropServices.Marshal.ThrowExceptionForHR?qualifyHint=False> method to throw an appropriate exception. This works even with a nonstandard error, for example, <xref:Microsoft.VisualStudio.VSConstants.VS_E_INCOMPATIBLEDOCDATA?qualifyHint=False>. <xref:System.Runtime.InteropServices.Marshal.ThrowExceptionForHR?qualifyHint=False> attempts to map the HRESULT passed to it to a strongly typed exception. If it cannot, it throws a generic COM exception instead. The ultimate result is that the HRESULT you pass to <xref:System.Runtime.InteropServices.Marshal.ThrowExceptionForHR?qualifyHint=False> from managed code is returned to the COM function that called it.  
  
> [!NOTE]
>  Exceptions compromise performance and are intended to indicate abnormal program conditions. Conditions that occur often should be handled inline, instead of a thrown exception.  
  
## See Also  
 [Managed VSPackages](../vs140/managed-vspackages.md)   
 [Interoperating with Unmanaged Code](assetId:///ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)   
 [HRESULTs and Exceptions](assetId:///610b364b-2761-429d-9c4a-afbc3e66f1b9)   
 [Building COM Components for Interoperation](assetId:///7a2c657a-cfef-40f0-bed3-7c2c0ac4abdf)   
 [Managed VSPackages](../vs140/managed-vspackages.md)