---
title: "-CLRSUPPORTLASTERROR (Preserve Last Error Code for PInvoke Calls)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/CLRSUPPORTLASTERROR (Preserve Last Error Code for PInvoke Calls)"
f1_keywords: 
  - "/CLRSUPPORTLASTERROR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/CLRSUPPORTLASTERROR linker option"
  - "-CLRSUPPORTLASTERROR linker option"
ms.assetid: b7057990-4154-4b1d-9fc9-6236f7be7575
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -CLRSUPPORTLASTERROR (Preserve Last Error Code for PInvoke Calls)
**/CLRSUPPORTLASTERROR**, which is on by default, preserves the last error code of functions called through the P/Invoke mechanism, which allows you to call native functions in DLLS, from code compiled with **/clr**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Preserving the last error code implies a decrease in performance.  If you do not want to incur the performance impact of preserving the last error code, link with  **/CLRSUPPORTLASTERROR:NO**.  
  
 You can minimize the performance impact by linking with **/CLRSUPPORTLASTERROR:SYSTEMDLL**, which only preserves the last error code for functions in system DLLs.  A system DLL is defined as one of the following:  
  
|||||  
|-|-|-|-|  
|ACLUI.DLL|ACTIVEDS.DLL|ADPTIF.DLL|ADVAPI32.DLL|  
|ASYCFILT.DLL|AUTHZ.DLL|AVICAP32.DLL|AVIFIL32.DLL|  
|CABINET.DLL|CLUSAPI.DLL|COMCTL32.DLL|COMDLG32.DLL|  
|COMSVCS.DLL|CREDUI.DLL|CRYPT32.DLL|CRYPTNET.DLL|  
|CRYPTUI.DLL|D3D8THK.DLL|DBGENG.DLL|DBGHELP.DLL|  
|DCIMAN32.DLL|DNSAPI.DLL|DSPROP.DLL|DSUIEXT.DLL|  
|GDI32.DLL|GLU32.DLL|HLINK.DLL|ICM32.DLL|  
|IMAGEHLP.DLL|IMM32.DLL|IPHLPAPI.DLL|IPROP.DLL|  
|KERNEL32.DLL|KSUSER.DLL|LOADPERF.DLL|LZ32.DLL|  
|MAPI32.DLL|MGMTAPI.DLL|MOBSYNC.DLL|MPR.DLL|  
|MPRAPI.DLL|MQRT.DLL|MSACM32.DLL|MSCMS.DLL|  
|MSI.DLL|MSIMG32.DLL|MSRATING.DLL|MSTASK.DLL|  
|MSVFW32.DLL|MSWSOCK.DLL|MTXEX.DLL|NDDEAPI.DLL|  
|NETAPI32.DLL|NPPTOOLS.DLL|NTDSAPI.DLL|NTDSBCLI.DLL|  
|NTMSAPI.DLL|ODBC32.DLL|ODBCBCP.DLL|OLE32.DLL|  
|OLEACC.DLL|OLEAUT32.DLL|OLEDLG.DLL|OPENGL32.DLL|  
|PDH.DLL|POWRPROF.DLL|QOSNAME.DLL|QUERY.DLL|  
|RASAPI32.DLL|RASDLG.DLL|RASSAPI.DLL|RESUTILS.DLL|  
|RICHED20.DLL|RPCNS4.DLL|RPCRT4.DLL|RTM.DLL|  
|RTUTILS.DLL|SCARDDLG.DLL|SECUR32.DLL|SENSAPI.DLL|  
|SETUPAPI.DLL|SFC.DLL|SHELL32.DLL|SHFOLDER.DLL|  
|SHLWAPI.DLL|SISBKUP.DLL|SNMPAPI.DLL|SRCLIENT.DLL|  
|STI.DLL|TAPI32.DLL|TRAFFIC.DLL|URL.DLL|  
|URLMON.DLL|USER32.DLL|USERENV.DLL|USP10.DLL|  
|UXTHEME.DLL|VDMDBG.DLL|VERSION.DLL|WINFAX.DLL|  
|WINHTTP.DLL|WININET.DLL|WINMM.DLL|WINSCARD.DLL|  
|WINTRUST.DLL|WLDAP32.DLL|WOW32.DLL|WS2_32.DLL|  
|WSNMP32.DLL|WSOCK32.DLL|WTSAPI32.DLL|XOLEHLP.DLL|  
  
> [!NOTE]
>  Preserving the last error is not supported for unmanaged functions that are consumed by CLR code, in the same module.  
  
-   For more information, see [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md).  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the option into the **Additional Options** box.  
  
### To set this linker option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.AdditionalOptions*>.  
  
## Example  
 The following sample defines a native DLL with one exported function that modifies last error.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample consumes the DLL, demonstrating how to use **/CLRSUPPORTLASTERROR**.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **GetLastError for application call failed (127).**  
**GetLastError for system call succeeded (183).**   
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)