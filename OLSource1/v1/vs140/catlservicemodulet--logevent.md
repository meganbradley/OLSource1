---
title: "CAtlServiceModuleT::LogEvent"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - LogEvent
  - ATL.CAtlServiceModuleT.LogEvent
  - CAtlServiceModuleT.LogEvent
  - CAtlServiceModuleT::LogEvent
  - ATL::CAtlServiceModuleT::LogEvent
dev_langs: 
  - C++
helpviewer_keywords: 
  - LogEvent method
ms.assetid: 32f1dda0-ee5b-471e-bbf6-657c64b5eb88
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlServiceModuleT::LogEvent
Writes to the event log.  
  
## Syntax  
  
```  
  
      void __cdecl LogEvent(  
   LPCTSTR pszFormat,  
   ...   
) throw( );  
```  
  
#### Parameters  
 `pszFormat`  
 The string to write to the event log.  
  
 ...  
 Optional extra strings to be written to the event log.  
  
## Remarks  
 This method writes details out to an event log, using the function [ReportEvent](http://msdn.microsoft.com/library/windows/desktop/aa363679). If no service is running, the string is sent to the console.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlServiceModuleT Class](../vs140/catlservicemodulet-class.md)