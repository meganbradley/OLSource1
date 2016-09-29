---
title: "Obsolete Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "is_wctype"
  - "_loaddll"
  - "_unloaddll"
  - "_getdllprocaddr"
  - "_seterrormode"
  - "_beep"
  - "_sleep"
  - "_getsystime"
  - "corecrt_wctype/is_wctype"
  - "process/_loaddll"
  - "process/_unloaddll"
  - "process/_getdllprocaddr"
  - "stdlib/_seterrormode"
  - "stdlib/_beep"
  - "stdlib/_sleep"
  - "time/_getsystime"
  - "time/_setsystime"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "obsolete functions"
  - "_beep function"
  - "_sleep function"
  - "_seterrormode function"
ms.assetid: 8e14c2d4-1481-4240-8586-47eb43db02b0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Obsolete Functions
Certain library functions are obsolete and have more recent equivalents. We recommend you change these to the updated versions. Other obsolete functions have been removed from the CRT. This topic lists the functions deprecated as obsolete, and the functions removed in a particular version of Visual Studio.  
  
## Deprecated as obsolete in Visual Studio 2015  
  
|Obsolete function|Alternative|  
|-----------------------|-----------------|  
|`is_wctype`|[iswctype](../VS_csharp/_isctype--iswctype--_isctype_l--_iswctype_l.md)|  
|`_loaddll`|[LoadLibrary](http://go.microsoft.com/fwlink/p/?LinkID=259187), [LoadLibraryEx](http://go.microsoft.com/fwlink/p/?LinkID=236091), or [LoadPackagedLibrary](https://msdn.microsoft.com/library/windows/desktop/hh447159\(v=vs.85\).aspx)|  
|`_unloaddll`|[FreeLibrary](http://go.microsoft.com/fwlink/p/?LinkID=259188)|  
|`_getdllprocaddr`|[GetProcAddress](../VS_csharp/getprocaddress.md)|  
|`_seterrormode`|[SetErrorMode](http://go.microsoft.com/fwlink/p/?LinkID=255242)|  
|`_beep`|[Beep](https://msdn.microsoft.com/library/windows/desktop/ms679277\(v=vs.85\).aspx)|  
|`_sleep`|[Sleep](https://msdn.microsoft.com/library/windows/desktop/ms686298\(v=vs.85\).aspx)|  
|`_getsystime`|[GetLocalTime](https://msdn.microsoft.com/library/windows/desktop/ms724338\(v=vs.85\).aspx)|  
|`_setsystime`|[SetLocalTime](https://msdn.microsoft.com/library/windows/desktop/ms724936\(v=vs.85\).aspx)|  
  
## Removed from the CRT in Visual Studio 2015  
  
|Obsolete function|Alternative|  
|-----------------------|-----------------|  
|[_cgets, _cgetws](../VS_csharp/_cgets--_cgetws.md)|[_cgets_s, _cgetws_s](../VS_csharp/_cgets_s--_cgetws_s.md)|  
|[gets, _getws](../VS_csharp/gets--_getws.md)|[gets_s, _getws_s](../VS_csharp/gets_s--_getws_s.md)|  
|[_get_output_format](../VS_csharp/_get_output_format.md)|None|  
|[_heapadd](../VS_csharp/_heapadd.md)|None|  
|[_heapset](../VS_csharp/_heapset.md)|None|  
|[inp, inpw](../VS_csharp/inp--inpw.md)|None|  
|[_inp, _inpw, _inpd](../VS_csharp/_inp--_inpw--_inpd.md)|None|  
|[outp, outpw](../VS_csharp/outp--outpw.md)|None|  
|[_outp, _outpw, _outpd](../VS_csharp/_outp--_outpw--_outpd.md)|None|  
|[_set_output_format](../VS_csharp/_set_output_format.md)|None|  
  
## Removed from the CRT in earlier versions of Visual Studio  
 [_lock](../VS_csharp/_lock.md)  
  
 [_unlock](../VS_csharp/_unlock.md)