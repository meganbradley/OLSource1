---
title: "CAsyncMonikerFile::GetBinding"
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
  - "CAsyncMonikerFile.GetBinding"
  - "CAsyncMonikerFile::GetBinding"
  - "GetBinding"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBinding method"
ms.assetid: af2d8bdf-dd7a-4e25-945b-a5ddb02a42c3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncMonikerFile::GetBinding
Call this function to retrieve a pointer to the asynchronous transfer binding.  
  
## Syntax  
  
```  
  
IBinding* GetBinding( ) const;  
```  
  
## Return Value  
 A pointer to the `IBinding` interface provided when asynchronous transfer begins. Returns **NULL** if for any reason the transfer cannot be made asynchronously.  
  
## Remarks  
 This allows you to control the data transfer process through the `IBinding` interface, for example, with **IBinding::Abort**, **IBinding::Pause**, and **IBinding::Resume**.  
  
 For a description of the `IBinding` interface, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [CAsyncMonikerFile Class](../vs140/casyncmonikerfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)