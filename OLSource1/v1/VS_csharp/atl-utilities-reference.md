---
title: "ATL Utilities Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: dd8a2888-34f4-461e-9bf4-834218f9b95b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL Utilities Reference
ATL provides code for manipulating paths and URLs in the form of [CPathT](../VS_csharp/cpatht-class.md) and [CUrl](../VS_csharp/curl-class.md). A thread pool, [CThreadPool](../VS_csharp/cthreadpool-class.md), can be used in your applications. This code can be found in atlpath.h and atlutil.h.  
  
### Classes  
  
|||  
|-|-|  
|[CPathT Class](../VS_csharp/cpatht-class.md)|This class represents a path.|  
|[CDebugReportHook Class](../VS_csharp/cdebugreporthook-class.md)|Use this class to send debug reports to a named pipe.|  
|[CNonStatelessWorker Class](../VS_csharp/cnonstatelessworker-class.md)|Receives requests from a thread pool and passes them on to a worker object that is created and destroyed on each request.|  
|[CNoWorkerThread Class](../VS_csharp/cnoworkerthread-class.md)|Use this class as the argument for the `MonitorClass` template parameter to cache classes if you want to disable dynamic cache maintenance.|  
|[CThreadPool Class](../VS_csharp/cthreadpool-class.md)|This class provides a pool of worker threads that process a queue of work items.|  
|[CUrl Class](../VS_csharp/curl-class.md)|This class represents a URL. It allows you to manipulate each element of the URL independently of the others whether parsing an existing URL string or building a string from scratch.|  
|[CWorkerThread Class](../VS_csharp/cworkerthread-class.md)|This class creates a worker thread or uses an existing one, waits on one or more kernel object handles, and executes a specified client function when one of the handles is signaled.|  
  
### Typedefs  
  
|||  
|-|-|  
|[CPath](../VS_csharp/cpath.md)|A specialization of [CPathT](../VS_csharp/cpatht-class.md) using `CString`.|  
|[CPathA](../VS_csharp/cpatha.md)|A specialization of [CPathT](../VS_csharp/cpatht-class.md) using `CStringA`.|  
|[CPathW](../VS_csharp/cpathw.md)|A specialization of [CPathT](../VS_csharp/cpatht-class.md) using `CStringW`.|  
|[ATL_URL_PORT](../VS_csharp/atl_url_port.md)|The type used by [CUrl](../VS_csharp/curl-class.md) for specifying a port number.|  
  
### Enums  
  
|||  
|-|-|  
|[ATL_URL_SCHEME](../VS_csharp/atl_url_scheme.md)|The members of this enumeration provide constants for the schemes understood by [CUrl](../VS_csharp/curl-class.md).|  
  
### Functions  
  
|||  
|-|-|  
|[AtlCanonicalizeUrl](../VS_csharp/atlcanonicalizeurl.md)|Call this function to canonicalize a URL, which includes converting unsafe characters and spaces into escape sequences.|  
|[AtlCombineUrl](../VS_csharp/atlcombineurl.md)|Call this function to combine a base URL and a relative URL into a single, canonical URL.|  
|[AtlEscapeUrl](../VS_csharp/atlescapeurl.md)|Call this function to convert all unsafe characters to escape sequences.|  
|[AtlGetDefaultUrlPort](../VS_csharp/atlgetdefaulturlport.md)|Call this function to get the default port number associated with a particular internet protocol or scheme.|  
|[AtlHexValue](../VS_csharp/atlhexvalue.md)|Call this function to get the numeric value of a hexadecimal digit.|  
|[AtlIsUnsafeUrlChar](../VS_csharp/atlisunsafeurlchar.md)|Call this function to find out whether a character is safe for use in a URL.|  
|[AtlUnescapeUrl](../VS_csharp/atlunescapeurl.md)|Call this function to convert escaped characters back to their original values.|  
|[SystemTimeToHttpDate](../VS_csharp/systemtimetohttpdate.md)|Call this function to convert a system time to a string in a format suitable for using in HTTP headers.|  
|[ATLPath::AddBackslash](../VS_csharp/atlpath--addbackslash.md)|This function is an overloaded wrapper for [PathAddBackslash](http://msdn.microsoft.com/library/windows/desktop/bb773561).|  
|[ATLPath::AddExtension](../VS_csharp/atlpath--addextension.md)|This function is an overloaded wrapper for [PathAddExtension](http://msdn.microsoft.com/library/windows/desktop/bb773563).|  
|[ATLPath::Append](../VS_csharp/atlpath--append.md)|This function is an overloaded wrapper for [PathAppend](http://msdn.microsoft.com/library/windows/desktop/bb773565).|  
|[ATLPath::BuildRoot](../VS_csharp/atlpath--buildroot.md)|This function is an overloaded wrapper for [PathBuildRoot](http://msdn.microsoft.com/library/windows/desktop/bb773567).|  
|[ATLPath::Canonicalize](../VS_csharp/atlpath--canonicalize.md)|This function is an overloaded wrapper for [PathCanonicalize](http://msdn.microsoft.com/library/windows/desktop/bb773569).|  
|[ATLPath::Combine](../VS_csharp/atlpath--combine.md)|This function is an overloaded wrapper for [PathCombine](http://msdn.microsoft.com/library/windows/desktop/bb773571).|  
|[ATLPath::CommonPrefix](../VS_csharp/atlpath--commonprefix.md)|This function is an overloaded wrapper for [PathCommonPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773574).|  
|[ATLPath::CompactPath](../VS_csharp/atlpath--compactpath.md)|This function is an overloaded wrapper for [PathCompactPath](http://msdn.microsoft.com/library/windows/desktop/bb773575).|  
|[ATLPath::CompactPathEx](../VS_csharp/atlpath--compactpathex.md)|This function is an overloaded wrapper for [PathCompactPathEx](http://msdn.microsoft.com/library/windows/desktop/bb773578).|  
|[ATLPath::FileExists](../VS_csharp/atlpath--fileexists.md)|This function is an overloaded wrapper for [PathFileExists](http://msdn.microsoft.com/library/windows/desktop/bb773584).|  
|[ATLPath::FindExtension](../VS_csharp/atlpath--findextension.md)|This function is an overloaded wrapper for [PathFindExtension](http://msdn.microsoft.com/library/windows/desktop/bb773587).|  
|[ATLPath::FindFileName](../VS_csharp/atlpath--findfilename.md)|This function is an overloaded wrapper for [PathFindFileName](http://msdn.microsoft.com/library/windows/desktop/bb773589).|  
|[ATLPath::GetDriveNumber](../VS_csharp/atlpath--getdrivenumber.md)|This function is an overloaded wrapper for [PathGetDriveNumber](http://msdn.microsoft.com/library/windows/desktop/bb773612).|  
|[ATLPath::IsDirectory](../VS_csharp/atlpath--isdirectory.md)|This function is an overloaded wrapper for [PathIsDirectory](http://msdn.microsoft.com/library/windows/desktop/bb773621).|  
|[ATLPath::IsFileSpec](../VS_csharp/atlpath--isfilespec.md)|This function is an overloaded wrapper for [PathIsFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773627).|  
|[ATLPath::IsPrefix](../VS_csharp/atlpath--isprefix.md)|This function is an overloaded wrapper for [PathIsPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773650).|  
|[ATLPath::IsRelative](../VS_csharp/atlpath--isrelative.md)|This function is an overloaded wrapper for [PathIsRelative](http://msdn.microsoft.com/library/windows/desktop/bb773660).|  
|[ATLPath::IsRoot](../VS_csharp/atlpath--isroot.md)|This function is an overloaded wrapper for [PathIsRoot](http://msdn.microsoft.com/library/windows/desktop/bb773674).|  
|[ATLPath::IsSameRoot](../VS_csharp/atlpath--issameroot.md)|This function is an overloaded wrapper for [PathIsSameRoot](http://msdn.microsoft.com/library/windows/desktop/bb773687).|  
|[ATLPath::IsUNC](../VS_csharp/atlpath--isunc.md)|This function is an overloaded wrapper for [PathIsUNC](http://msdn.microsoft.com/library/windows/desktop/bb773712).|  
|[ATLPath::IsUNCServer](../VS_csharp/atlpath--isuncserver.md)|This function is an overloaded wrapper for [PathIsUNCServer](http://msdn.microsoft.com/library/windows/desktop/bb773722).|  
|[ATLPath::IsUNCServerShare](../VS_csharp/atlpath--isuncservershare.md)|This function is an overloaded wrapper for [PathIsUNCServerShare](http://msdn.microsoft.com/library/windows/desktop/bb773723).|  
|[ATLPath::MakePretty](../VS_csharp/atlpath--makepretty.md)|This function is an overloaded wrapper for [PathMakePretty](http://msdn.microsoft.com/library/windows/desktop/bb773725).|  
|[ATLPath::MatchSpec](../VS_csharp/atlpath--matchspec.md)|This function is an overloaded wrapper for [PathMatchSpec](http://msdn.microsoft.com/library/windows/desktop/bb773727).|  
|[ATLPath::QuoteSpaces](../VS_csharp/atlpath--quotespaces.md)|This function is an overloaded wrapper for [PathQuoteSpaces](http://msdn.microsoft.com/library/windows/desktop/bb773739).|  
|[ATLPath::RelativePathTo](../VS_csharp/atlpath--relativepathto.md)|This function is an overloaded wrapper for [PathRelativePathTo](http://msdn.microsoft.com/library/windows/desktop/bb773740).|  
|[ATLPath::RemoveArgs](../VS_csharp/atlpath--removeargs.md)|This function is an overloaded wrapper for [PathRemoveArgs](http://msdn.microsoft.com/library/windows/desktop/bb773742).|  
|[ATLPath::RemoveBackslash](../VS_csharp/atlpath--removebackslash.md)|This function is an overloaded wrapper for [PathRemoveBackslash](http://msdn.microsoft.com/library/windows/desktop/bb773743).|  
|[ATLPath::RemoveBlanks](../VS_csharp/atlpath--removeblanks.md)|This function is an overloaded wrapper for [PathRemoveBlanks](http://msdn.microsoft.com/library/windows/desktop/bb773745).|  
|[ATLPath::RemoveExtension](../VS_csharp/atlpath--removeextension.md)|This function is an overloaded wrapper for [PathRemoveExtension](http://msdn.microsoft.com/library/windows/desktop/bb773746).|  
|[ATLPath::RemoveFileSpec](../VS_csharp/atlpath--removefilespec.md)|This function is an overloaded wrapper for [PathRemoveFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773748).|  
|[ATLPath::RenameExtension](../VS_csharp/atlpath--renameextension.md)|This function is an overloaded wrapper for [PathRenameExtension](http://msdn.microsoft.com/library/windows/desktop/bb773749).|  
|[ATLPath::SkipRoot](../VS_csharp/atlpath--skiproot.md)|This function is an overloaded wrapper for [PathSkipRoot](http://msdn.microsoft.com/library/windows/desktop/bb773754).|  
|[ATLPath::StripPath](../VS_csharp/atlpath--strippath.md)|This function is an overloaded wrapper for [PathStripPath](http://msdn.microsoft.com/library/windows/desktop/bb773756).|  
|[ATLPath::StripToRoot](../VS_csharp/atlpath--striptoroot.md)|This function is an overloaded wrapper for [PathStripToRoot](http://msdn.microsoft.com/library/windows/desktop/bb773757).|  
|[ATLPath::UnquoteSpaces](../VS_csharp/atlpath--unquotespaces.md)|This function is an overloaded wrapper for [PathUnquoteSpaces](http://msdn.microsoft.com/library/windows/desktop/bb773763).|  
  
### Macros  
  
|||  
|-|-|  
|[ATL_URL Flags](../VS_csharp/atl_url-flags.md)|These flags modify the behavior of [AtlEscapeUrl](../VS_csharp/atlescapeurl.md) and [AtlCanonicalizeUrl](../VS_csharp/atlcanonicalizeurl.md) .|  
|[ATL_WORKER_THREAD_WAIT](../VS_csharp/atl_worker_thread_wait.md)|This macro defines the default value in milliseconds that [CWorkerThread::Shutdown](../Topic/CWorkerThread::Shutdown.md) will wait for the worker thread to shut down.|  
|[ATLS_DEFAULT_THREADPOOLSHUTDOWNTIMEOUT](../VS_csharp/atls_default_threadpoolshutdowntimeout.md)|This macro defines the default time in milliseconds that [CThreadPool](../VS_csharp/cthreadpool-class.md) will wait for a thread to shut down.|  
|[ATLS_DEFAULT_THREADSPERPROC](../VS_csharp/atls_default_threadsperproc.md)|This macro defines the default number of threads per processor used by [CThreadPool](../VS_csharp/cthreadpool-class.md).|  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)