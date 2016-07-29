---
title: "Breaking Changes to Analysis Services Features in SQL Server 2016"
ms.custom: 
  - SQL2016_New_Updated
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: aeb02542-5a6c-458c-a110-13413dd3e9d9
caps.latest.revision: 54
manager: mblythe
---
# Breaking Changes to Analysis Services Features in SQL Server 2016
A *breaking change* causes a data model, application code, or script  to no longer function after upgrading either the model or the server.  
  
> [!NOTE]  
>  In contrast, a *behavior change* is characterized as a code change that doesn't break a model or application, but does introduce a different behavior from a previous release.  Examples of behavior changes might include changing a default value, or disallowing a configuration of properties or options that was previously allowed. To learn more about behavior changes in this release, see [Behavior Changes to Analysis Services Features in SQL Server 2016](../../Topics/TopicNameNotContainA/Behavior-Changes-to-Analysis-Services-Features-in-SQL-Server-2016.md).  
  
## .NET 4.0 version upgrade  
 Analysis Services Management Objects (AMO), ADOMD.NET, and Tabular Object Model (TOM) client libraries in [!INCLUDE[ssASCurrent](../../Topics/TopicNameContainA/includes/ssASCurrent_md.md)] now target the .NET 4.0 runtime. This can be a breaking change for applications that target .NET 3.5. Applications using newer versions of these assemblies must now target .NET 4.0 or later.  
  
## AMO version upgrade  
 [!INCLUDE[ssASCurrent](../../Topics/TopicNameContainA/includes/ssASCurrent_md.md)] is a version upgrade for [Analysis Services Management Objects (AMO)](assetId:///dcffdfde-0b83-4df1-8140-7f6ad1fc71fd) and is  a breaking change under certain circumstances.  Existing code and scripts that call into AMO will continue to run as before if you upgrade from a previous version. However, if you need to *recompile* your application and you are targeting a [!INCLUDE[ssASCurrent](../../Topics/TopicNameContainA/includes/ssASCurrent_md.md)] instance, you must add the following namespace to make your code or script operational:  
  
```  
  
using Microsoft.AnalysisServices;  
using Microsoft.AnalysisServices.Core;  
  
```  
  
 The [Microsoft.AnalysisServices.Core](assetId:///9d9d1d50-1970-405c-9e58-5593c9b605aa) namespace is now required whenever you reference the Microsoft.AnalysisServices assembly in your code. Objects that were previously only in the **Microsoft.AnalysisServices** namespace are moved to the Core namespace in this release if the object is used the same way in both tabular and multidimensional scenarios.  For example, server-related APIs are relocated to the Core namespace.  
  
 Although there are now multiple namespaces, both exist in the same assembly (Microsoft.AnalysisServices.dll).  
  
## XEvent DISCOVER changes  
 To better support XEvent DISCOVER streaming in SSMS for [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)], `DISCOVER_XEVENT_TRACE_DEFINITION` is replaced with the following XEvent traces:  
  
-   DISCOVER_XEVENT_PACKAGES  
  
-   DISCOVER_XEVENT_OBJECT  
  
-   DISCOVER_XEVENT_OBJECT_COLUMNS  
  
-   DISCOVER_XEVENT_SESSION_TARGETS  
  
## See Also  
 [Analysis Services Backward Compatibility](../../Topics/TopicNameNotContainA/Analysis-Services-Backward-Compatibility.md)