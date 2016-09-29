---
title: "CStringT::AllocSysString"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL.CStringT.AllocSysString"
  - "AllocSysString"
  - "CStringT.AllocSysString"
  - "CStringT::AllocSysString"
  - "ATL::CStringT::AllocSysString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AllocSysString method"
ms.assetid: fc34132d-322a-4c40-8dc2-bc877a29d8b6
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::AllocSysString
Allocates an Automation-compatible string of the type `BSTR` and copies the contents of the `CStringT` object into it, including the terminating null character.  
  
## Syntax  
  
```  
BSTR AllocSysString() const;  
```  
  
## Return Value  
 The newly allocated string.  
  
## Remarks  
 In MFC programs, a [CMemoryException Class](../vs140/cmemoryexception-class.md) is thrown if insufficient memory exists. In ATL programs, a [CAtlException](../vs140/catlexception-class.md) is thrown. This function is normally used to return strings for Automation.  
  
 Commonly, if this string is passed to a COM function as an [in] parameter, then this requires the caller to free the string. This can be done by using [SysFreeString](assetId:///8f230ee3-5f6e-4cb9-a910-9c90b754dcd3), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information, see [Allocating and Releasing Memory for a BSTR](../vs140/allocating-and-releasing-memory-for-a-bstr.md).  
  
 For more information about OLE allocation functions in Windows, see [SysAllocString](assetId:///9e0437a2-9b4a-4576-88b0-5cb9d08ca29b) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 The following example demonstrates the use of `CStringT::AllocSysString`.  
  
 [!code[NVC_ATLMFC_Utilities#105](../vs140/codesnippet/CPP/cstringt--allocsysstring_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)